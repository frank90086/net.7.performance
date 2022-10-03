## Install Benchmark
```cmd
paket add BenchmarkDotNet --version 0.13.2
```

## Install R
### [Page](https://cran.csie.ntu.edu.tw/)
 - [Windows](https://cran.csie.ntu.edu.tw/)
 - [Mac OS](https://cran.csie.ntu.edu.tw/bin/macosx/)
 - [Linux](https://cran.csie.ntu.edu.tw/)
 
### Hints
> if there aren't any *.png on R plots exporter default file "results"  
> try to run the command below  
> [Getting R Plots Working](https://github.com/dotnet/BenchmarkDotNet/issues/567)

```RScript ./bin/Release/net6.0/BenchmarkDotNet.Artifacts/results/BuildPlots.R```

### Results
#### [Enumerable](https://github.com/frank90086/net.7.performance/tree/main/src/BenchmarkLogs/Enumerable)
 - ![image](https://github.com/frank90086/net.7.performance/blob/main/src/RPlots/net._7.performance.enumerable.barplot.png)
 - ![image](https://github.com/frank90086/net.7.performance/blob/main/src/RPlots/net._7.performance.%20enumerable.boxplot.png)
 
#### [List](https://github.com/frank90086/net.7.performance/tree/main/src/BenchmarkLogs/List)
 - ![image](https://github.com/frank90086/net.7.performance/blob/main/src/RPlots/net._7.performance.list.barplot.png)
 - ![image](https://github.com/frank90086/net.7.performance/blob/main/src/RPlots/net._7.performance.list.boxplot.png)
 
#### [Array](https://github.com/frank90086/net.7.performance/tree/main/src/BenchmarkLogs/Array)
 - ![image](https://github.com/frank90086/net.7.performance/blob/main/src/RPlots/net._7.performance.array.barplot.png)
 - ![image](https://github.com/frank90086/net.7.performance/blob/main/src/RPlots/net._7.performance.array.boxplot.png)
