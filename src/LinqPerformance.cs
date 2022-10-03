using BenchmarkDotNet.Attributes;

namespace net._7.performance;

[Config(typeof(BenchmarkConfig))]
public class LinqPerformance
{
    [Params(10, 50, 100)]
    public int Size { get; set; }
    private IEnumerable<int> _enumerableItems;
    private IEnumerable<int> _listItems;
    private IEnumerable<int> _arrayItems;

    [GlobalSetup]
    public void Setup()
    {
        var list = Enumerable.Range(1, Size).OrderBy(o => new Random(Guid.NewGuid().GetHashCode()).Next());
        _enumerableItems = list;
        _listItems = list.ToList();
        _arrayItems = list.ToArray();
    }

    //[Benchmark]
    public int Enumerable_Min() => _enumerableItems.Min();
    
    //[Benchmark]
    public int Enumerable_Max() => _enumerableItems.Max();
    
    //[Benchmark]
    public double Enumerable_Average() => _enumerableItems.Average();
    
    //[Benchmark]
    public int Enumerable_Sum() => _enumerableItems.Sum();
    
    //[Benchmark]
    public int List_Min() => _listItems.Min();
    
    //[Benchmark]
    public int List_Max() => _listItems.Max();
    
    //[Benchmark]
    public double List_Average() => _listItems.Average();
    
    //[Benchmark]
    public int List_Sum() => _listItems.Sum();
    
    [Benchmark]
    public int Array_Min() => _arrayItems.Min();
    
    [Benchmark]
    public int Array_Max() => _arrayItems.Max();
    
    [Benchmark]
    public double Array_Average() => _arrayItems.Average();
    
    [Benchmark]
    public int Array_Sum() => _arrayItems.Sum();
}