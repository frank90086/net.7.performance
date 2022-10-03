using System.Text.RegularExpressions;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Exporters.Csv;
using BenchmarkDotNet.Jobs;

namespace net._7.performance;

public class BenchmarkConfig : ManualConfig
{
    private readonly Regex _regex = new(@"([^-_]+)");
    
    public BenchmarkConfig()
    {
        AddJob(new Job("net60").WithRuntime(CoreRuntime.Core60), new Job("net70").WithRuntime(CoreRuntime.Core70));
        AddDiagnoser(new MemoryDiagnoser(new MemoryDiagnoserConfig(false)));
        AddExporter(CsvMeasurementsExporter.Default);
        AddExporter(RPlotExporter.Default);
        AddColumn(new BenchmarkColumn("Type", name => _regex.Match(name).Success
                                                      ? _regex.Match(name).Groups[1].Value
                                                      : string.Empty));
        AddColumn(new BenchmarkColumn("Method", name => _regex.Match(name).Success
                                                          ? _regex.Match(name).NextMatch().Groups[1].Value
                                                          : string.Empty));
    }
}