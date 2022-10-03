using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;

namespace net._7.performance;

public class BenchmarkColumn : IColumn
{
    private readonly Func<string, string> _getTag;

    public BenchmarkColumn(string columnName, Func<string, string> getTag)
    {
        _getTag = getTag;
        ColumnName = columnName;
        Id = $"{nameof(TagColumn)}.{columnName}";
    }

    public string GetValue(Summary summary, BenchmarkCase benchmarkCase) => _getTag(benchmarkCase.Descriptor.WorkloadMethod.Name);

    public string GetValue(Summary summary, BenchmarkCase benchmarkCase, SummaryStyle style) => GetValue(summary, benchmarkCase);

    public bool IsDefault(Summary summary, BenchmarkCase benchmarkCase) => false;

    public bool IsAvailable(Summary summary) => true;

    public string Id { get; }
    public string ColumnName { get; }
    public bool AlwaysShow => true;
    public ColumnCategory Category => ColumnCategory.Custom;
    public int PriorityInCategory => 0;
    public bool IsNumeric => false;
    public UnitType UnitType => UnitType.Dimensionless;
    public string Legend => $"Custom '{ColumnName}' tag column";
}