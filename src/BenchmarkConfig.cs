using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Exporters.Csv;
using BenchmarkDotNet.Jobs;

namespace net._7.performance;

public class BenchmarkConfig : ManualConfig
{
    public BenchmarkConfig()
    {
        AddJob(new Job("net60").WithRuntime(CoreRuntime.Core60), new Job("net70").WithRuntime(CoreRuntime.Core70));
        AddDiagnoser(new MemoryDiagnoser(new MemoryDiagnoserConfig(false)));
        AddExporter(CsvMeasurementsExporter.Default);
        AddExporter(RPlotExporter.Default);
    }
}