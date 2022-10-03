// Validating benchmarks:
// ***** BenchmarkRunner: Start   *****
// ***** Found 8 benchmark(s) in total *****
// ***** Building 2 exe(s) in Parallel: Start   *****
// ***** Done, took 00:00:09 (9.38 sec)   *****
// Found 8 benchmarks:
//   LinqPerformance.Enumerable_Min: net60(Runtime=.NET 6.0)
//   LinqPerformance.Enumerable_Max: net60(Runtime=.NET 6.0)
//   LinqPerformance.Enumerable_Average: net60(Runtime=.NET 6.0)
//   LinqPerformance.Enumerable_Sum: net60(Runtime=.NET 6.0)
//   LinqPerformance.Enumerable_Min: net70(Runtime=.NET 7.0)
//   LinqPerformance.Enumerable_Max: net70(Runtime=.NET 7.0)
//   LinqPerformance.Enumerable_Average: net70(Runtime=.NET 7.0)
//   LinqPerformance.Enumerable_Sum: net70(Runtime=.NET 7.0)

// **************************
// Benchmark: LinqPerformance.Enumerable_Min: net60(Runtime=.NET 6.0)
// *** Execute ***
// Launch: 1 / 1
// Execute: dotnet 10db21cd-7c13-4042-8108-a54a0aa8f853.dll --benchmarkName net._7.performance.LinqPerformance.Enumerable_Min --job net60 --benchmarkId 0 in /Users/frank.hsu/Documents/Projects/Test/net.7.performance/src/bin/Release/net6.0/10db21cd-7c13-4042-8108-a54a0aa8f853/bin/Release/net6.0
Failed to set up high priority. Make sure you have the right permissions. Message: Permission denied
// BeforeAnythingElse

// Benchmark Process Environment Information:
// Runtime=.NET 6.0.1 (6.0.121.56705), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: net60

OverheadJitting  1: 1 op, 329296.00 ns, 329.2960 us/op
WorkloadJitting  1: 1 op, 1496079.00 ns, 1.4961 ms/op

OverheadJitting  2: 16 op, 509517.00 ns, 31.8448 us/op
WorkloadJitting  2: 16 op, 4267801.00 ns, 266.7376 us/op

WorkloadPilot    1: 16 op, 3258571.00 ns, 203.6607 us/op
WorkloadPilot    2: 32 op, 7668744.00 ns, 239.6482 us/op
WorkloadPilot    3: 64 op, 13957311.00 ns, 218.0830 us/op
WorkloadPilot    4: 128 op, 27711666.00 ns, 216.4974 us/op
WorkloadPilot    5: 256 op, 53538280.00 ns, 209.1339 us/op
WorkloadPilot    6: 512 op, 102725778.00 ns, 200.6363 us/op
WorkloadPilot    7: 1024 op, 165100046.00 ns, 161.2305 us/op
WorkloadPilot    8: 2048 op, 308136878.00 ns, 150.4575 us/op
WorkloadPilot    9: 4096 op, 679701958.00 ns, 165.9429 us/op

OverheadWarmup   1: 4096 op, 11123.00 ns, 2.7156 ns/op
OverheadWarmup   2: 4096 op, 10075.00 ns, 2.4597 ns/op
OverheadWarmup   3: 4096 op, 10633.00 ns, 2.5959 ns/op
OverheadWarmup   4: 4096 op, 9958.00 ns, 2.4312 ns/op
OverheadWarmup   5: 4096 op, 10866.00 ns, 2.6528 ns/op
OverheadWarmup   6: 4096 op, 10730.00 ns, 2.6196 ns/op

OverheadActual   1: 4096 op, 10683.00 ns, 2.6082 ns/op
OverheadActual   2: 4096 op, 10728.00 ns, 2.6191 ns/op
OverheadActual   3: 4096 op, 9905.00 ns, 2.4182 ns/op
OverheadActual   4: 4096 op, 12977.00 ns, 3.1682 ns/op
OverheadActual   5: 4096 op, 10044.00 ns, 2.4521 ns/op
OverheadActual   6: 4096 op, 9999.00 ns, 2.4412 ns/op
OverheadActual   7: 4096 op, 9960.00 ns, 2.4316 ns/op
OverheadActual   8: 4096 op, 10404.00 ns, 2.5400 ns/op
OverheadActual   9: 4096 op, 9885.00 ns, 2.4133 ns/op
OverheadActual  10: 4096 op, 9780.00 ns, 2.3877 ns/op
OverheadActual  11: 4096 op, 10828.00 ns, 2.6436 ns/op
OverheadActual  12: 4096 op, 9858.00 ns, 2.4067 ns/op
OverheadActual  13: 4096 op, 10383.00 ns, 2.5349 ns/op
OverheadActual  14: 4096 op, 10316.00 ns, 2.5186 ns/op
OverheadActual  15: 4096 op, 9876.00 ns, 2.4111 ns/op

WorkloadWarmup   1: 4096 op, 665094676.00 ns, 162.3766 us/op
WorkloadWarmup   2: 4096 op, 647391081.00 ns, 158.0545 us/op
WorkloadWarmup   3: 4096 op, 724531678.00 ns, 176.8876 us/op
WorkloadWarmup   4: 4096 op, 743964872.00 ns, 181.6320 us/op
WorkloadWarmup   5: 4096 op, 695988982.00 ns, 169.9192 us/op
WorkloadWarmup   6: 4096 op, 607327574.00 ns, 148.2733 us/op
WorkloadWarmup   7: 4096 op, 613699270.00 ns, 149.8289 us/op
WorkloadWarmup   8: 4096 op, 804177437.00 ns, 196.3324 us/op
WorkloadWarmup   9: 4096 op, 641472111.00 ns, 156.6094 us/op

// BeforeActualRun
WorkloadActual   1: 4096 op, 613590002.00 ns, 149.8022 us/op
WorkloadActual   2: 4096 op, 628004740.00 ns, 153.3215 us/op
WorkloadActual   3: 4096 op, 610306621.00 ns, 149.0006 us/op
WorkloadActual   4: 4096 op, 632966487.00 ns, 154.5328 us/op
WorkloadActual   5: 4096 op, 611898209.00 ns, 149.3892 us/op
WorkloadActual   6: 4096 op, 608369480.00 ns, 148.5277 us/op
WorkloadActual   7: 4096 op, 610928388.00 ns, 149.1524 us/op
WorkloadActual   8: 4096 op, 609224472.00 ns, 148.7364 us/op
WorkloadActual   9: 4096 op, 611392960.00 ns, 149.2659 us/op
WorkloadActual  10: 4096 op, 627532090.00 ns, 153.2061 us/op
WorkloadActual  11: 4096 op, 609754732.00 ns, 148.8659 us/op
WorkloadActual  12: 4096 op, 610081274.00 ns, 148.9456 us/op
WorkloadActual  13: 4096 op, 608243021.00 ns, 148.4968 us/op
WorkloadActual  14: 4096 op, 611127353.00 ns, 149.2010 us/op
WorkloadActual  15: 4096 op, 609555968.00 ns, 148.8174 us/op

// AfterActualRun
WorkloadResult   1: 4096 op, 613579958.00 ns, 149.7998 us/op
WorkloadResult   2: 4096 op, 610296577.00 ns, 148.9982 us/op
WorkloadResult   3: 4096 op, 611888165.00 ns, 149.3868 us/op
WorkloadResult   4: 4096 op, 608359436.00 ns, 148.5253 us/op
WorkloadResult   5: 4096 op, 610918344.00 ns, 149.1500 us/op
WorkloadResult   6: 4096 op, 609214428.00 ns, 148.7340 us/op
WorkloadResult   7: 4096 op, 611382916.00 ns, 149.2634 us/op
WorkloadResult   8: 4096 op, 609744688.00 ns, 148.8634 us/op
WorkloadResult   9: 4096 op, 610071230.00 ns, 148.9432 us/op
WorkloadResult  10: 4096 op, 608232977.00 ns, 148.4944 us/op
WorkloadResult  11: 4096 op, 611117309.00 ns, 149.1986 us/op
WorkloadResult  12: 4096 op, 609545924.00 ns, 148.8149 us/op
GC:  27 0 0 130482992 4096
Threading:  0 0 4096

// AfterAll
// Benchmark Process 21158 has exited with code 0.

Mean = 149.014 μs, StdErr = 0.108 μs (0.07%), N = 12, StdDev = 0.372 μs
Min = 148.494 μs, Q1 = 148.795 μs, Median = 148.971 μs, Q3 = 149.215 μs, Max = 149.800 μs
IQR = 0.420 μs, LowerFence = 148.165 μs, UpperFence = 149.845 μs
ConfidenceInterval = [148.537 μs; 149.491 μs] (CI 99.9%), Margin = 0.477 μs (0.32% of Mean)
Skewness = 0.43, Kurtosis = 2.35, MValue = 2

// ** Remained 7 (87.5 %) benchmark(s) to run. Estimated finish 2022-10-03 14:07 (0h 2m from now) **
// **************************
// Benchmark: LinqPerformance.Enumerable_Max: net60(Runtime=.NET 6.0)
// *** Execute ***
// Launch: 1 / 1
// Execute: dotnet 10db21cd-7c13-4042-8108-a54a0aa8f853.dll --benchmarkName net._7.performance.LinqPerformance.Enumerable_Max --job net60 --benchmarkId 1 in /Users/frank.hsu/Documents/Projects/Test/net.7.performance/src/bin/Release/net6.0/10db21cd-7c13-4042-8108-a54a0aa8f853/bin/Release/net6.0
Failed to set up high priority. Make sure you have the right permissions. Message: Permission denied
// BeforeAnythingElse

// Benchmark Process Environment Information:
// Runtime=.NET 6.0.1 (6.0.121.56705), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: net60

OverheadJitting  1: 1 op, 319239.00 ns, 319.2390 us/op
WorkloadJitting  1: 1 op, 1436526.00 ns, 1.4365 ms/op

OverheadJitting  2: 16 op, 556728.00 ns, 34.7955 us/op
WorkloadJitting  2: 16 op, 3908552.00 ns, 244.2845 us/op

WorkloadPilot    1: 16 op, 3158980.00 ns, 197.4363 us/op
WorkloadPilot    2: 32 op, 6667793.00 ns, 208.3685 us/op
WorkloadPilot    3: 64 op, 12523558.00 ns, 195.6806 us/op
WorkloadPilot    4: 128 op, 23170758.00 ns, 181.0215 us/op
WorkloadPilot    5: 256 op, 46731935.00 ns, 182.5466 us/op
WorkloadPilot    6: 512 op, 88465031.00 ns, 172.7833 us/op
WorkloadPilot    7: 1024 op, 151783925.00 ns, 148.2265 us/op
WorkloadPilot    8: 2048 op, 305473735.00 ns, 149.1571 us/op
WorkloadPilot    9: 4096 op, 613696038.00 ns, 149.8281 us/op

OverheadWarmup   1: 4096 op, 9017.00 ns, 2.2014 ns/op
OverheadWarmup   2: 4096 op, 8538.00 ns, 2.0845 ns/op
OverheadWarmup   3: 4096 op, 8108.00 ns, 1.9795 ns/op
OverheadWarmup   4: 4096 op, 8230.00 ns, 2.0093 ns/op
OverheadWarmup   5: 4096 op, 8647.00 ns, 2.1111 ns/op
OverheadWarmup   6: 4096 op, 8150.00 ns, 1.9897 ns/op
OverheadWarmup   7: 4096 op, 8910.00 ns, 2.1753 ns/op
OverheadWarmup   8: 4096 op, 8296.00 ns, 2.0254 ns/op

OverheadActual   1: 4096 op, 8152.00 ns, 1.9902 ns/op
OverheadActual   2: 4096 op, 8095.00 ns, 1.9763 ns/op
OverheadActual   3: 4096 op, 8174.00 ns, 1.9956 ns/op
OverheadActual   4: 4096 op, 8367.00 ns, 2.0427 ns/op
OverheadActual   5: 4096 op, 8294.00 ns, 2.0249 ns/op
OverheadActual   6: 4096 op, 8239.00 ns, 2.0115 ns/op
OverheadActual   7: 4096 op, 8689.00 ns, 2.1213 ns/op
OverheadActual   8: 4096 op, 8198.00 ns, 2.0015 ns/op
OverheadActual   9: 4096 op, 9226.00 ns, 2.2524 ns/op
OverheadActual  10: 4096 op, 8147.00 ns, 1.9890 ns/op
OverheadActual  11: 4096 op, 8265.00 ns, 2.0178 ns/op
OverheadActual  12: 4096 op, 8047.00 ns, 1.9646 ns/op
OverheadActual  13: 4096 op, 8057.00 ns, 1.9670 ns/op
OverheadActual  14: 4096 op, 8571.00 ns, 2.0925 ns/op
OverheadActual  15: 4096 op, 8651.00 ns, 2.1121 ns/op

WorkloadWarmup   1: 4096 op, 606427685.00 ns, 148.0536 us/op
WorkloadWarmup   2: 4096 op, 606753900.00 ns, 148.1333 us/op
WorkloadWarmup   3: 4096 op, 608458191.00 ns, 148.5494 us/op
WorkloadWarmup   4: 4096 op, 610761593.00 ns, 149.1117 us/op
WorkloadWarmup   5: 4096 op, 607982604.00 ns, 148.4333 us/op
WorkloadWarmup   6: 4096 op, 608574008.00 ns, 148.5776 us/op
WorkloadWarmup   7: 4096 op, 610501141.00 ns, 149.0481 us/op
WorkloadWarmup   8: 4096 op, 613018126.00 ns, 149.6626 us/op
WorkloadWarmup   9: 4096 op, 607838291.00 ns, 148.3980 us/op

// BeforeActualRun
WorkloadActual   1: 4096 op, 608413792.00 ns, 148.5385 us/op
WorkloadActual   2: 4096 op, 604875705.00 ns, 147.6747 us/op
WorkloadActual   3: 4096 op, 608567395.00 ns, 148.5760 us/op
WorkloadActual   4: 4096 op, 614409560.00 ns, 150.0023 us/op
WorkloadActual   5: 4096 op, 608894800.00 ns, 148.6560 us/op
WorkloadActual   6: 4096 op, 607504703.00 ns, 148.3166 us/op
WorkloadActual   7: 4096 op, 611419938.00 ns, 149.2724 us/op
WorkloadActual   8: 4096 op, 608559982.00 ns, 148.5742 us/op
WorkloadActual   9: 4096 op, 609091503.00 ns, 148.7040 us/op
WorkloadActual  10: 4096 op, 610428042.00 ns, 149.0303 us/op
WorkloadActual  11: 4096 op, 606708659.00 ns, 148.1222 us/op
WorkloadActual  12: 4096 op, 609625485.00 ns, 148.8343 us/op
WorkloadActual  13: 4096 op, 610429415.00 ns, 149.0306 us/op
WorkloadActual  14: 4096 op, 609794548.00 ns, 148.8756 us/op
WorkloadActual  15: 4096 op, 611745088.00 ns, 149.3518 us/op

// AfterActualRun
WorkloadResult   1: 4096 op, 608405553.00 ns, 148.5365 us/op
WorkloadResult   2: 4096 op, 604867466.00 ns, 147.6727 us/op
WorkloadResult   3: 4096 op, 608559156.00 ns, 148.5740 us/op
WorkloadResult   4: 4096 op, 608886561.00 ns, 148.6539 us/op
WorkloadResult   5: 4096 op, 607496464.00 ns, 148.3146 us/op
WorkloadResult   6: 4096 op, 611411699.00 ns, 149.2704 us/op
WorkloadResult   7: 4096 op, 608551743.00 ns, 148.5722 us/op
WorkloadResult   8: 4096 op, 609083264.00 ns, 148.7020 us/op
WorkloadResult   9: 4096 op, 610419803.00 ns, 149.0283 us/op
WorkloadResult  10: 4096 op, 606700420.00 ns, 148.1202 us/op
WorkloadResult  11: 4096 op, 609617246.00 ns, 148.8323 us/op
WorkloadResult  12: 4096 op, 610421176.00 ns, 149.0286 us/op
WorkloadResult  13: 4096 op, 609786309.00 ns, 148.8736 us/op
WorkloadResult  14: 4096 op, 611736849.00 ns, 149.3498 us/op
GC:  27 0 0 130482992 4096
Threading:  0 0 4096

// AfterAll
// Benchmark Process 21189 has exited with code 0.

Mean = 148.681 μs, StdErr = 0.120 μs (0.08%), N = 14, StdDev = 0.448 μs
Min = 147.673 μs, Q1 = 148.545 μs, Median = 148.678 μs, Q3 = 148.990 μs, Max = 149.350 μs
IQR = 0.444 μs, LowerFence = 147.879 μs, UpperFence = 149.656 μs
ConfidenceInterval = [148.176 μs; 149.186 μs] (CI 99.9%), Margin = 0.505 μs (0.34% of Mean)
Skewness = -0.52, Kurtosis = 2.67, MValue = 2

// ** Remained 6 (75.0 %) benchmark(s) to run. Estimated finish 2022-10-03 14:07 (0h 1m from now) **
// **************************
// Benchmark: LinqPerformance.Enumerable_Average: net60(Runtime=.NET 6.0)
// *** Execute ***
// Launch: 1 / 1
// Execute: dotnet 10db21cd-7c13-4042-8108-a54a0aa8f853.dll --benchmarkName net._7.performance.LinqPerformance.Enumerable_Average --job net60 --benchmarkId 2 in /Users/frank.hsu/Documents/Projects/Test/net.7.performance/src/bin/Release/net6.0/10db21cd-7c13-4042-8108-a54a0aa8f853/bin/Release/net6.0
Failed to set up high priority. Make sure you have the right permissions. Message: Permission denied
// BeforeAnythingElse

// Benchmark Process Environment Information:
// Runtime=.NET 6.0.1 (6.0.121.56705), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: net60

OverheadJitting  1: 1 op, 348156.00 ns, 348.1560 us/op
WorkloadJitting  1: 1 op, 1239475.00 ns, 1.2395 ms/op

OverheadJitting  2: 16 op, 577026.00 ns, 36.0641 us/op
WorkloadJitting  2: 16 op, 3468499.00 ns, 216.7812 us/op

WorkloadPilot    1: 16 op, 2686831.00 ns, 167.9269 us/op
WorkloadPilot    2: 32 op, 5505401.00 ns, 172.0438 us/op
WorkloadPilot    3: 64 op, 11188938.00 ns, 174.8272 us/op
WorkloadPilot    4: 128 op, 22637999.00 ns, 176.8594 us/op
WorkloadPilot    5: 256 op, 43296007.00 ns, 169.1250 us/op
WorkloadPilot    6: 512 op, 86215471.00 ns, 168.3896 us/op
WorkloadPilot    7: 1024 op, 152145640.00 ns, 148.5797 us/op
WorkloadPilot    8: 2048 op, 303899511.00 ns, 148.3884 us/op
WorkloadPilot    9: 4096 op, 609880619.00 ns, 148.8966 us/op

OverheadWarmup   1: 4096 op, 9754.00 ns, 2.3813 ns/op
OverheadWarmup   2: 4096 op, 7941.00 ns, 1.9387 ns/op
OverheadWarmup   3: 4096 op, 8987.00 ns, 2.1941 ns/op
OverheadWarmup   4: 4096 op, 7798.00 ns, 1.9038 ns/op
OverheadWarmup   5: 4096 op, 7950.00 ns, 1.9409 ns/op
OverheadWarmup   6: 4096 op, 8465.00 ns, 2.0667 ns/op
OverheadWarmup   7: 4096 op, 7865.00 ns, 1.9202 ns/op

OverheadActual   1: 4096 op, 7800.00 ns, 1.9043 ns/op
OverheadActual   2: 4096 op, 7861.00 ns, 1.9192 ns/op
OverheadActual   3: 4096 op, 9058.00 ns, 2.2114 ns/op
OverheadActual   4: 4096 op, 8038.00 ns, 1.9624 ns/op
OverheadActual   5: 4096 op, 8032.00 ns, 1.9609 ns/op
OverheadActual   6: 4096 op, 8527.00 ns, 2.0818 ns/op
OverheadActual   7: 4096 op, 7885.00 ns, 1.9250 ns/op
OverheadActual   8: 4096 op, 7917.00 ns, 1.9329 ns/op
OverheadActual   9: 4096 op, 8479.00 ns, 2.0701 ns/op
OverheadActual  10: 4096 op, 8637.00 ns, 2.1086 ns/op
OverheadActual  11: 4096 op, 7978.00 ns, 1.9478 ns/op
OverheadActual  12: 4096 op, 7795.00 ns, 1.9031 ns/op
OverheadActual  13: 4096 op, 7880.00 ns, 1.9238 ns/op
OverheadActual  14: 4096 op, 7790.00 ns, 1.9019 ns/op
OverheadActual  15: 4096 op, 7787.00 ns, 1.9011 ns/op

WorkloadWarmup   1: 4096 op, 610526444.00 ns, 149.0543 us/op
WorkloadWarmup   2: 4096 op, 608135586.00 ns, 148.4706 us/op
WorkloadWarmup   3: 4096 op, 610036672.00 ns, 148.9347 us/op
WorkloadWarmup   4: 4096 op, 608547487.00 ns, 148.5712 us/op
WorkloadWarmup   5: 4096 op, 611217485.00 ns, 149.2230 us/op
WorkloadWarmup   6: 4096 op, 609425600.00 ns, 148.7855 us/op

// BeforeActualRun
WorkloadActual   1: 4096 op, 628730992.00 ns, 153.4988 us/op
WorkloadActual   2: 4096 op, 608517530.00 ns, 148.5639 us/op
WorkloadActual   3: 4096 op, 607673715.00 ns, 148.3578 us/op
WorkloadActual   4: 4096 op, 642124043.00 ns, 156.7686 us/op
WorkloadActual   5: 4096 op, 606408315.00 ns, 148.0489 us/op
WorkloadActual   6: 4096 op, 612814733.00 ns, 149.6130 us/op
WorkloadActual   7: 4096 op, 612018708.00 ns, 149.4186 us/op
WorkloadActual   8: 4096 op, 609909046.00 ns, 148.9036 us/op
WorkloadActual   9: 4096 op, 609001590.00 ns, 148.6820 us/op
WorkloadActual  10: 4096 op, 607344882.00 ns, 148.2776 us/op
WorkloadActual  11: 4096 op, 607430522.00 ns, 148.2985 us/op
WorkloadActual  12: 4096 op, 607921816.00 ns, 148.4184 us/op
WorkloadActual  13: 4096 op, 607677897.00 ns, 148.3589 us/op
WorkloadActual  14: 4096 op, 615024646.00 ns, 150.1525 us/op
WorkloadActual  15: 4096 op, 611988107.00 ns, 149.4112 us/op

// AfterActualRun
WorkloadResult   1: 4096 op, 608509613.00 ns, 148.5619 us/op
WorkloadResult   2: 4096 op, 607665798.00 ns, 148.3559 us/op
WorkloadResult   3: 4096 op, 606400398.00 ns, 148.0470 us/op
WorkloadResult   4: 4096 op, 612806816.00 ns, 149.6110 us/op
WorkloadResult   5: 4096 op, 612010791.00 ns, 149.4167 us/op
WorkloadResult   6: 4096 op, 609901129.00 ns, 148.9016 us/op
WorkloadResult   7: 4096 op, 608993673.00 ns, 148.6801 us/op
WorkloadResult   8: 4096 op, 607336965.00 ns, 148.2756 us/op
WorkloadResult   9: 4096 op, 607422605.00 ns, 148.2965 us/op
WorkloadResult  10: 4096 op, 607913899.00 ns, 148.4165 us/op
WorkloadResult  11: 4096 op, 607669980.00 ns, 148.3569 us/op
WorkloadResult  12: 4096 op, 615016729.00 ns, 150.1506 us/op
WorkloadResult  13: 4096 op, 611980190.00 ns, 149.4092 us/op
GC:  27 0 0 130483040 4096
Threading:  0 0 4096

// AfterAll
// Benchmark Process 21230 has exited with code 0.

Mean = 148.806 μs, StdErr = 0.178 μs (0.12%), N = 13, StdDev = 0.642 μs
Min = 148.047 μs, Q1 = 148.356 μs, Median = 148.562 μs, Q3 = 149.409 μs, Max = 150.151 μs
IQR = 1.053 μs, LowerFence = 146.776 μs, UpperFence = 150.989 μs
ConfidenceInterval = [148.037 μs; 149.575 μs] (CI 99.9%), Margin = 0.769 μs (0.52% of Mean)
Skewness = 0.7, Kurtosis = 2.05, MValue = 2

// ** Remained 5 (62.5 %) benchmark(s) to run. Estimated finish 2022-10-03 14:07 (0h 1m from now) **
// **************************
// Benchmark: LinqPerformance.Enumerable_Sum: net60(Runtime=.NET 6.0)
// *** Execute ***
// Launch: 1 / 1
// Execute: dotnet 10db21cd-7c13-4042-8108-a54a0aa8f853.dll --benchmarkName net._7.performance.LinqPerformance.Enumerable_Sum --job net60 --benchmarkId 3 in /Users/frank.hsu/Documents/Projects/Test/net.7.performance/src/bin/Release/net6.0/10db21cd-7c13-4042-8108-a54a0aa8f853/bin/Release/net6.0
Failed to set up high priority. Make sure you have the right permissions. Message: Permission denied
// BeforeAnythingElse

// Benchmark Process Environment Information:
// Runtime=.NET 6.0.1 (6.0.121.56705), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: net60

OverheadJitting  1: 1 op, 271865.00 ns, 271.8650 us/op
WorkloadJitting  1: 1 op, 1189474.00 ns, 1.1895 ms/op

OverheadJitting  2: 16 op, 399164.00 ns, 24.9477 us/op
WorkloadJitting  2: 16 op, 3211207.00 ns, 200.7004 us/op

WorkloadPilot    1: 16 op, 2682497.00 ns, 167.6561 us/op
WorkloadPilot    2: 32 op, 5663980.00 ns, 176.9994 us/op
WorkloadPilot    3: 64 op, 11186258.00 ns, 174.7853 us/op
WorkloadPilot    4: 128 op, 22299003.00 ns, 174.2110 us/op
WorkloadPilot    5: 256 op, 43372715.00 ns, 169.4247 us/op
WorkloadPilot    6: 512 op, 86218524.00 ns, 168.3956 us/op
WorkloadPilot    7: 1024 op, 153570957.00 ns, 149.9716 us/op
WorkloadPilot    8: 2048 op, 303781415.00 ns, 148.3308 us/op
WorkloadPilot    9: 4096 op, 605560703.00 ns, 147.8420 us/op

OverheadWarmup   1: 4096 op, 8938.00 ns, 2.1821 ns/op
OverheadWarmup   2: 4096 op, 7964.00 ns, 1.9443 ns/op
OverheadWarmup   3: 4096 op, 7987.00 ns, 1.9500 ns/op
OverheadWarmup   4: 4096 op, 7923.00 ns, 1.9343 ns/op
OverheadWarmup   5: 4096 op, 7998.00 ns, 1.9526 ns/op
OverheadWarmup   6: 4096 op, 7924.00 ns, 1.9346 ns/op

OverheadActual   1: 4096 op, 7940.00 ns, 1.9385 ns/op
OverheadActual   2: 4096 op, 8019.00 ns, 1.9578 ns/op
OverheadActual   3: 4096 op, 22121.00 ns, 5.4006 ns/op
OverheadActual   4: 4096 op, 8065.00 ns, 1.9690 ns/op
OverheadActual   5: 4096 op, 7992.00 ns, 1.9512 ns/op
OverheadActual   6: 4096 op, 7934.00 ns, 1.9370 ns/op
OverheadActual   7: 4096 op, 8027.00 ns, 1.9597 ns/op
OverheadActual   8: 4096 op, 7984.00 ns, 1.9492 ns/op
OverheadActual   9: 4096 op, 7936.00 ns, 1.9375 ns/op
OverheadActual  10: 4096 op, 7963.00 ns, 1.9441 ns/op
OverheadActual  11: 4096 op, 9285.00 ns, 2.2668 ns/op
OverheadActual  12: 4096 op, 7936.00 ns, 1.9375 ns/op
OverheadActual  13: 4096 op, 8403.00 ns, 2.0515 ns/op
OverheadActual  14: 4096 op, 8443.00 ns, 2.0613 ns/op
OverheadActual  15: 4096 op, 7913.00 ns, 1.9319 ns/op

WorkloadWarmup   1: 4096 op, 605398814.00 ns, 147.8024 us/op
WorkloadWarmup   2: 4096 op, 608714181.00 ns, 148.6119 us/op
WorkloadWarmup   3: 4096 op, 608103599.00 ns, 148.4628 us/op
WorkloadWarmup   4: 4096 op, 612255995.00 ns, 149.4766 us/op
WorkloadWarmup   5: 4096 op, 610682958.00 ns, 149.0925 us/op
WorkloadWarmup   6: 4096 op, 607828851.00 ns, 148.3957 us/op

// BeforeActualRun
WorkloadActual   1: 4096 op, 606623015.00 ns, 148.1013 us/op
WorkloadActual   2: 4096 op, 607880549.00 ns, 148.4083 us/op
WorkloadActual   3: 4096 op, 605706863.00 ns, 147.8777 us/op
WorkloadActual   4: 4096 op, 604620109.00 ns, 147.6123 us/op
WorkloadActual   5: 4096 op, 608669918.00 ns, 148.6011 us/op
WorkloadActual   6: 4096 op, 608086663.00 ns, 148.4587 us/op
WorkloadActual   7: 4096 op, 611148804.00 ns, 149.2063 us/op
WorkloadActual   8: 4096 op, 606514769.00 ns, 148.0749 us/op
WorkloadActual   9: 4096 op, 607086149.00 ns, 148.2144 us/op
WorkloadActual  10: 4096 op, 614121375.00 ns, 149.9320 us/op
WorkloadActual  11: 4096 op, 618025461.00 ns, 150.8851 us/op
WorkloadActual  12: 4096 op, 615725581.00 ns, 150.3236 us/op
WorkloadActual  13: 4096 op, 624412692.00 ns, 152.4445 us/op
WorkloadActual  14: 4096 op, 621127367.00 ns, 151.6424 us/op
WorkloadActual  15: 4096 op, 624061431.00 ns, 152.3587 us/op

// AfterActualRun
WorkloadResult   1: 4096 op, 606615023.00 ns, 148.0994 us/op
WorkloadResult   2: 4096 op, 607872557.00 ns, 148.4064 us/op
WorkloadResult   3: 4096 op, 605698871.00 ns, 147.8757 us/op
WorkloadResult   4: 4096 op, 604612117.00 ns, 147.6104 us/op
WorkloadResult   5: 4096 op, 608661926.00 ns, 148.5991 us/op
WorkloadResult   6: 4096 op, 608078671.00 ns, 148.4567 us/op
WorkloadResult   7: 4096 op, 611140812.00 ns, 149.2043 us/op
WorkloadResult   8: 4096 op, 606506777.00 ns, 148.0729 us/op
WorkloadResult   9: 4096 op, 607078157.00 ns, 148.2124 us/op
WorkloadResult  10: 4096 op, 614113383.00 ns, 149.9300 us/op
WorkloadResult  11: 4096 op, 618017469.00 ns, 150.8832 us/op
WorkloadResult  12: 4096 op, 615717589.00 ns, 150.3217 us/op
WorkloadResult  13: 4096 op, 624404700.00 ns, 152.4426 us/op
WorkloadResult  14: 4096 op, 621119375.00 ns, 151.6405 us/op
WorkloadResult  15: 4096 op, 624053439.00 ns, 152.3568 us/op
GC:  27 0 0 130482992 4096
Threading:  0 0 4096

// AfterAll
// Benchmark Process 21262 has exited with code 0.

Mean = 149.474 μs, StdErr = 0.432 μs (0.29%), N = 15, StdDev = 1.674 μs
Min = 147.610 μs, Q1 = 148.156 μs, Median = 148.599 μs, Q3 = 150.602 μs, Max = 152.443 μs
IQR = 2.447 μs, LowerFence = 144.486 μs, UpperFence = 154.272 μs
ConfidenceInterval = [147.685 μs; 151.263 μs] (CI 99.9%), Margin = 1.789 μs (1.20% of Mean)
Skewness = 0.61, Kurtosis = 1.74, MValue = 2

// ** Remained 4 (50.0 %) benchmark(s) to run. Estimated finish 2022-10-03 14:07 (0h 1m from now) **
// **************************
// Benchmark: LinqPerformance.Enumerable_Min: net70(Runtime=.NET 7.0)
// *** Execute ***
// Launch: 1 / 1
// Execute: dotnet a8bcfeec-bf26-43f0-bd29-d10d18983489.dll --benchmarkName net._7.performance.LinqPerformance.Enumerable_Min --job net70 --benchmarkId 0 in /Users/frank.hsu/Documents/Projects/Test/net.7.performance/src/bin/Release/net6.0/a8bcfeec-bf26-43f0-bd29-d10d18983489/bin/Release/net7.0
Failed to set up high priority. Make sure you have the right permissions. Message: Permission denied
// BeforeAnythingElse

// Benchmark Process Environment Information:
// Runtime=.NET 7.0.0 (7.0.22.42610), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: net70

OverheadJitting  1: 1 op, 449794.00 ns, 449.7940 us/op
WorkloadJitting  1: 1 op, 2121120.00 ns, 2.1211 ms/op

OverheadJitting  2: 16 op, 506551.00 ns, 31.6594 us/op
WorkloadJitting  2: 16 op, 3606778.00 ns, 225.4236 us/op

WorkloadPilot    1: 16 op, 2800987.00 ns, 175.0617 us/op
WorkloadPilot    2: 32 op, 6202082.00 ns, 193.8151 us/op
WorkloadPilot    3: 64 op, 12106306.00 ns, 189.1610 us/op
WorkloadPilot    4: 128 op, 22587415.00 ns, 176.4642 us/op
WorkloadPilot    5: 256 op, 45677851.00 ns, 178.4291 us/op
WorkloadPilot    6: 512 op, 87634796.00 ns, 171.1617 us/op
WorkloadPilot    7: 1024 op, 173985015.00 ns, 169.9072 us/op
WorkloadPilot    8: 2048 op, 335738420.00 ns, 163.9348 us/op
WorkloadPilot    9: 4096 op, 675883080.00 ns, 165.0105 us/op

OverheadWarmup   1: 4096 op, 10048.00 ns, 2.4531 ns/op
OverheadWarmup   2: 4096 op, 8939.00 ns, 2.1824 ns/op
OverheadWarmup   3: 4096 op, 8842.00 ns, 2.1587 ns/op
OverheadWarmup   4: 4096 op, 8875.00 ns, 2.1667 ns/op
OverheadWarmup   5: 4096 op, 8909.00 ns, 2.1750 ns/op
OverheadWarmup   6: 4096 op, 8873.00 ns, 2.1663 ns/op
OverheadWarmup   7: 4096 op, 9176.00 ns, 2.2402 ns/op
OverheadWarmup   8: 4096 op, 8918.00 ns, 2.1772 ns/op

OverheadActual   1: 4096 op, 9031.00 ns, 2.2048 ns/op
OverheadActual   2: 4096 op, 8940.00 ns, 2.1826 ns/op
OverheadActual   3: 4096 op, 8861.00 ns, 2.1633 ns/op
OverheadActual   4: 4096 op, 9136.00 ns, 2.2305 ns/op
OverheadActual   5: 4096 op, 41232.00 ns, 10.0664 ns/op
OverheadActual   6: 4096 op, 9072.00 ns, 2.2148 ns/op
OverheadActual   7: 4096 op, 9086.00 ns, 2.2183 ns/op
OverheadActual   8: 4096 op, 9090.00 ns, 2.2192 ns/op
OverheadActual   9: 4096 op, 9838.00 ns, 2.4019 ns/op
OverheadActual  10: 4096 op, 9079.00 ns, 2.2166 ns/op
OverheadActual  11: 4096 op, 9100.00 ns, 2.2217 ns/op
OverheadActual  12: 4096 op, 9118.00 ns, 2.2261 ns/op
OverheadActual  13: 4096 op, 9124.00 ns, 2.2275 ns/op
OverheadActual  14: 4096 op, 9092.00 ns, 2.2197 ns/op
OverheadActual  15: 4096 op, 9079.00 ns, 2.2166 ns/op

WorkloadWarmup   1: 4096 op, 672894329.00 ns, 164.2808 us/op
WorkloadWarmup   2: 4096 op, 681415894.00 ns, 166.3613 us/op
WorkloadWarmup   3: 4096 op, 694642237.00 ns, 169.5904 us/op
WorkloadWarmup   4: 4096 op, 694074229.00 ns, 169.4517 us/op
WorkloadWarmup   5: 4096 op, 681788593.00 ns, 166.4523 us/op
WorkloadWarmup   6: 4096 op, 700367283.00 ns, 170.9881 us/op
WorkloadWarmup   7: 4096 op, 673935981.00 ns, 164.5352 us/op

// BeforeActualRun
WorkloadActual   1: 4096 op, 672452783.00 ns, 164.1730 us/op
WorkloadActual   2: 4096 op, 678604177.00 ns, 165.6748 us/op
WorkloadActual   3: 4096 op, 673153986.00 ns, 164.3442 us/op
WorkloadActual   4: 4096 op, 679064199.00 ns, 165.7872 us/op
WorkloadActual   5: 4096 op, 691725827.00 ns, 168.8784 us/op
WorkloadActual   6: 4096 op, 691807006.00 ns, 168.8982 us/op
WorkloadActual   7: 4096 op, 686575329.00 ns, 167.6209 us/op
WorkloadActual   8: 4096 op, 681798221.00 ns, 166.4546 us/op
WorkloadActual   9: 4096 op, 681577759.00 ns, 166.4008 us/op
WorkloadActual  10: 4096 op, 683326281.00 ns, 166.8277 us/op
WorkloadActual  11: 4096 op, 702025762.00 ns, 171.3930 us/op
WorkloadActual  12: 4096 op, 688364547.00 ns, 168.0578 us/op
WorkloadActual  13: 4096 op, 668706394.00 ns, 163.2584 us/op
WorkloadActual  14: 4096 op, 686572419.00 ns, 167.6202 us/op
WorkloadActual  15: 4096 op, 682078539.00 ns, 166.5231 us/op

// AfterActualRun
WorkloadResult   1: 4096 op, 672443693.00 ns, 164.1708 us/op
WorkloadResult   2: 4096 op, 678595087.00 ns, 165.6726 us/op
WorkloadResult   3: 4096 op, 673144896.00 ns, 164.3420 us/op
WorkloadResult   4: 4096 op, 679055109.00 ns, 165.7849 us/op
WorkloadResult   5: 4096 op, 691716737.00 ns, 168.8762 us/op
WorkloadResult   6: 4096 op, 691797916.00 ns, 168.8960 us/op
WorkloadResult   7: 4096 op, 686566239.00 ns, 167.6187 us/op
WorkloadResult   8: 4096 op, 681789131.00 ns, 166.4524 us/op
WorkloadResult   9: 4096 op, 681568669.00 ns, 166.3986 us/op
WorkloadResult  10: 4096 op, 683317191.00 ns, 166.8255 us/op
WorkloadResult  11: 4096 op, 688355457.00 ns, 168.0555 us/op
WorkloadResult  12: 4096 op, 668697304.00 ns, 163.2562 us/op
WorkloadResult  13: 4096 op, 686563329.00 ns, 167.6180 us/op
WorkloadResult  14: 4096 op, 682069449.00 ns, 166.5209 us/op
GC:  798 0 0 130482992 4096
Threading:  0 0 4096

// AfterAll
// Benchmark Process 21293 has exited with code 0.

Mean = 166.463 μs, StdErr = 0.458 μs (0.28%), N = 14, StdDev = 1.714 μs
Min = 163.256 μs, Q1 = 165.701 μs, Median = 166.487 μs, Q3 = 167.619 μs, Max = 168.896 μs
IQR = 1.918 μs, LowerFence = 162.824 μs, UpperFence = 170.495 μs
ConfidenceInterval = [164.530 μs; 168.397 μs] (CI 99.9%), Margin = 1.934 μs (1.16% of Mean)
Skewness = -0.28, Kurtosis = 1.93, MValue = 2

// ** Remained 3 (37.5 %) benchmark(s) to run. Estimated finish 2022-10-03 14:07 (0h 0m from now) **
// **************************
// Benchmark: LinqPerformance.Enumerable_Max: net70(Runtime=.NET 7.0)
// *** Execute ***
// Launch: 1 / 1
// Execute: dotnet a8bcfeec-bf26-43f0-bd29-d10d18983489.dll --benchmarkName net._7.performance.LinqPerformance.Enumerable_Max --job net70 --benchmarkId 1 in /Users/frank.hsu/Documents/Projects/Test/net.7.performance/src/bin/Release/net6.0/a8bcfeec-bf26-43f0-bd29-d10d18983489/bin/Release/net7.0
Failed to set up high priority. Make sure you have the right permissions. Message: Permission denied
// BeforeAnythingElse

// Benchmark Process Environment Information:
// Runtime=.NET 7.0.0 (7.0.22.42610), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: net70

OverheadJitting  1: 1 op, 430662.00 ns, 430.6620 us/op
WorkloadJitting  1: 1 op, 1960927.00 ns, 1.9609 ms/op

OverheadJitting  2: 16 op, 510811.00 ns, 31.9257 us/op
WorkloadJitting  2: 16 op, 3463434.00 ns, 216.4646 us/op

WorkloadPilot    1: 16 op, 2842185.00 ns, 177.6366 us/op
WorkloadPilot    2: 32 op, 6828427.00 ns, 213.3883 us/op
WorkloadPilot    3: 64 op, 12307726.00 ns, 192.3082 us/op
WorkloadPilot    4: 128 op, 21949040.00 ns, 171.4769 us/op
WorkloadPilot    5: 256 op, 43472201.00 ns, 169.8133 us/op
WorkloadPilot    6: 512 op, 86106520.00 ns, 168.1768 us/op
WorkloadPilot    7: 1024 op, 166427088.00 ns, 162.5265 us/op
WorkloadPilot    8: 2048 op, 339212293.00 ns, 165.6310 us/op
WorkloadPilot    9: 4096 op, 677995760.00 ns, 165.5263 us/op

OverheadWarmup   1: 4096 op, 10143.00 ns, 2.4763 ns/op
OverheadWarmup   2: 4096 op, 9097.00 ns, 2.2209 ns/op
OverheadWarmup   3: 4096 op, 9073.00 ns, 2.2151 ns/op
OverheadWarmup   4: 4096 op, 9059.00 ns, 2.2117 ns/op
OverheadWarmup   5: 4096 op, 9063.00 ns, 2.2126 ns/op
OverheadWarmup   6: 4096 op, 9067.00 ns, 2.2136 ns/op
OverheadWarmup   7: 4096 op, 9116.00 ns, 2.2256 ns/op
OverheadWarmup   8: 4096 op, 9020.00 ns, 2.2021 ns/op
OverheadWarmup   9: 4096 op, 9075.00 ns, 2.2156 ns/op
OverheadWarmup  10: 4096 op, 9050.00 ns, 2.2095 ns/op

OverheadActual   1: 4096 op, 17410.00 ns, 4.2505 ns/op
OverheadActual   2: 4096 op, 9120.00 ns, 2.2266 ns/op
OverheadActual   3: 4096 op, 9124.00 ns, 2.2275 ns/op
OverheadActual   4: 4096 op, 9130.00 ns, 2.2290 ns/op
OverheadActual   5: 4096 op, 9298.00 ns, 2.2700 ns/op
OverheadActual   6: 4096 op, 9127.00 ns, 2.2283 ns/op
OverheadActual   7: 4096 op, 10607.00 ns, 2.5896 ns/op
OverheadActual   8: 4096 op, 9089.00 ns, 2.2190 ns/op
OverheadActual   9: 4096 op, 9102.00 ns, 2.2222 ns/op
OverheadActual  10: 4096 op, 9115.00 ns, 2.2253 ns/op
OverheadActual  11: 4096 op, 9064.00 ns, 2.2129 ns/op
OverheadActual  12: 4096 op, 9095.00 ns, 2.2205 ns/op
OverheadActual  13: 4096 op, 9101.00 ns, 2.2219 ns/op
OverheadActual  14: 4096 op, 8990.00 ns, 2.1948 ns/op
OverheadActual  15: 4096 op, 9118.00 ns, 2.2261 ns/op

WorkloadWarmup   1: 4096 op, 693535807.00 ns, 169.3203 us/op
WorkloadWarmup   2: 4096 op, 679632495.00 ns, 165.9259 us/op
WorkloadWarmup   3: 4096 op, 677542610.00 ns, 165.4157 us/op
WorkloadWarmup   4: 4096 op, 680438103.00 ns, 166.1226 us/op
WorkloadWarmup   5: 4096 op, 690906896.00 ns, 168.6784 us/op
WorkloadWarmup   6: 4096 op, 733989057.00 ns, 179.1965 us/op
WorkloadWarmup   7: 4096 op, 694336221.00 ns, 169.5157 us/op
WorkloadWarmup   8: 4096 op, 691077450.00 ns, 168.7201 us/op
WorkloadWarmup   9: 4096 op, 684809230.00 ns, 167.1898 us/op
WorkloadWarmup  10: 4096 op, 684891984.00 ns, 167.2100 us/op
WorkloadWarmup  11: 4096 op, 697272810.00 ns, 170.2326 us/op
WorkloadWarmup  12: 4096 op, 691090187.00 ns, 168.7232 us/op

// BeforeActualRun
WorkloadActual   1: 4096 op, 696024136.00 ns, 169.9278 us/op
WorkloadActual   2: 4096 op, 678617561.00 ns, 165.6781 us/op
WorkloadActual   3: 4096 op, 730569363.00 ns, 178.3617 us/op
WorkloadActual   4: 4096 op, 698833817.00 ns, 170.6137 us/op
WorkloadActual   5: 4096 op, 683801659.00 ns, 166.9438 us/op
WorkloadActual   6: 4096 op, 680739333.00 ns, 166.1961 us/op
WorkloadActual   7: 4096 op, 682814291.00 ns, 166.7027 us/op
WorkloadActual   8: 4096 op, 678029962.00 ns, 165.5347 us/op
WorkloadActual   9: 4096 op, 679340343.00 ns, 165.8546 us/op
WorkloadActual  10: 4096 op, 685318278.00 ns, 167.3140 us/op
WorkloadActual  11: 4096 op, 675802098.00 ns, 164.9907 us/op
WorkloadActual  12: 4096 op, 692500187.00 ns, 169.0674 us/op
WorkloadActual  13: 4096 op, 671225563.00 ns, 163.8734 us/op
WorkloadActual  14: 4096 op, 674043342.00 ns, 164.5614 us/op
WorkloadActual  15: 4096 op, 675209830.00 ns, 164.8461 us/op

// AfterActualRun
WorkloadResult   1: 4096 op, 696015018.00 ns, 169.9255 us/op
WorkloadResult   2: 4096 op, 678608443.00 ns, 165.6759 us/op
WorkloadResult   3: 4096 op, 698824699.00 ns, 170.6115 us/op
WorkloadResult   4: 4096 op, 683792541.00 ns, 166.9415 us/op
WorkloadResult   5: 4096 op, 680730215.00 ns, 166.1939 us/op
WorkloadResult   6: 4096 op, 682805173.00 ns, 166.7005 us/op
WorkloadResult   7: 4096 op, 678020844.00 ns, 165.5324 us/op
WorkloadResult   8: 4096 op, 679331225.00 ns, 165.8523 us/op
WorkloadResult   9: 4096 op, 685309160.00 ns, 167.3118 us/op
WorkloadResult  10: 4096 op, 675792980.00 ns, 164.9885 us/op
WorkloadResult  11: 4096 op, 692491069.00 ns, 169.0652 us/op
WorkloadResult  12: 4096 op, 671216445.00 ns, 163.8712 us/op
WorkloadResult  13: 4096 op, 674034224.00 ns, 164.5591 us/op
WorkloadResult  14: 4096 op, 675200712.00 ns, 164.8439 us/op
GC:  798 0 0 130482992 4096
Threading:  0 0 4096

// AfterAll
// Benchmark Process 21325 has exited with code 0.

Mean = 166.577 μs, StdErr = 0.544 μs (0.33%), N = 14, StdDev = 2.036 μs
Min = 163.871 μs, Q1 = 165.124 μs, Median = 166.023 μs, Q3 = 167.219 μs, Max = 170.611 μs
IQR = 2.095 μs, LowerFence = 161.982 μs, UpperFence = 170.361 μs
ConfidenceInterval = [164.280 μs; 168.873 μs] (CI 99.9%), Margin = 2.296 μs (1.38% of Mean)
Skewness = 0.67, Kurtosis = 2.15, MValue = 2

// ** Remained 2 (25.0 %) benchmark(s) to run. Estimated finish 2022-10-03 14:07 (0h 0m from now) **
// **************************
// Benchmark: LinqPerformance.Enumerable_Average: net70(Runtime=.NET 7.0)
// *** Execute ***
// Launch: 1 / 1
// Execute: dotnet a8bcfeec-bf26-43f0-bd29-d10d18983489.dll --benchmarkName net._7.performance.LinqPerformance.Enumerable_Average --job net70 --benchmarkId 2 in /Users/frank.hsu/Documents/Projects/Test/net.7.performance/src/bin/Release/net6.0/a8bcfeec-bf26-43f0-bd29-d10d18983489/bin/Release/net7.0
Failed to set up high priority. Make sure you have the right permissions. Message: Permission denied
// BeforeAnythingElse

// Benchmark Process Environment Information:
// Runtime=.NET 7.0.0 (7.0.22.42610), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: net70

OverheadJitting  1: 1 op, 425593.00 ns, 425.5930 us/op
WorkloadJitting  1: 1 op, 1664151.00 ns, 1.6642 ms/op

OverheadJitting  2: 16 op, 576870.00 ns, 36.0544 us/op
WorkloadJitting  2: 16 op, 3166322.00 ns, 197.8951 us/op

WorkloadPilot    1: 16 op, 2355548.00 ns, 147.2217 us/op
WorkloadPilot    2: 32 op, 5312063.00 ns, 166.0020 us/op
WorkloadPilot    3: 64 op, 11648213.00 ns, 182.0033 us/op
WorkloadPilot    4: 128 op, 21638890.00 ns, 169.0538 us/op
WorkloadPilot    5: 256 op, 45108216.00 ns, 176.2040 us/op
WorkloadPilot    6: 512 op, 86555804.00 ns, 169.0543 us/op
WorkloadPilot    7: 1024 op, 168270903.00 ns, 164.3271 us/op
WorkloadPilot    8: 2048 op, 342339516.00 ns, 167.1580 us/op
WorkloadPilot    9: 4096 op, 675685975.00 ns, 164.9624 us/op

OverheadWarmup   1: 4096 op, 10748.00 ns, 2.6240 ns/op
OverheadWarmup   2: 4096 op, 9964.00 ns, 2.4326 ns/op
OverheadWarmup   3: 4096 op, 9907.00 ns, 2.4187 ns/op
OverheadWarmup   4: 4096 op, 9887.00 ns, 2.4138 ns/op
OverheadWarmup   5: 4096 op, 9919.00 ns, 2.4216 ns/op
OverheadWarmup   6: 4096 op, 9862.00 ns, 2.4077 ns/op
OverheadWarmup   7: 4096 op, 9912.00 ns, 2.4199 ns/op
OverheadWarmup   8: 4096 op, 9889.00 ns, 2.4143 ns/op

OverheadActual   1: 4096 op, 9901.00 ns, 2.4172 ns/op
OverheadActual   2: 4096 op, 9955.00 ns, 2.4304 ns/op
OverheadActual   3: 4096 op, 9952.00 ns, 2.4297 ns/op
OverheadActual   4: 4096 op, 10000.00 ns, 2.4414 ns/op
OverheadActual   5: 4096 op, 9965.00 ns, 2.4329 ns/op
OverheadActual   6: 4096 op, 9880.00 ns, 2.4121 ns/op
OverheadActual   7: 4096 op, 9872.00 ns, 2.4102 ns/op
OverheadActual   8: 4096 op, 9896.00 ns, 2.4160 ns/op
OverheadActual   9: 4096 op, 10525.00 ns, 2.5696 ns/op
OverheadActual  10: 4096 op, 9867.00 ns, 2.4089 ns/op
OverheadActual  11: 4096 op, 9877.00 ns, 2.4114 ns/op
OverheadActual  12: 4096 op, 9899.00 ns, 2.4167 ns/op
OverheadActual  13: 4096 op, 9890.00 ns, 2.4146 ns/op
OverheadActual  14: 4096 op, 9878.00 ns, 2.4116 ns/op
OverheadActual  15: 4096 op, 9890.00 ns, 2.4146 ns/op

WorkloadWarmup   1: 4096 op, 674572187.00 ns, 164.6905 us/op
WorkloadWarmup   2: 4096 op, 683036245.00 ns, 166.7569 us/op
WorkloadWarmup   3: 4096 op, 680033549.00 ns, 166.0238 us/op
WorkloadWarmup   4: 4096 op, 675101464.00 ns, 164.8197 us/op
WorkloadWarmup   5: 4096 op, 676789359.00 ns, 165.2318 us/op
WorkloadWarmup   6: 4096 op, 689353413.00 ns, 168.2992 us/op
WorkloadWarmup   7: 4096 op, 685930136.00 ns, 167.4634 us/op

// BeforeActualRun
WorkloadActual   1: 4096 op, 1184981231.00 ns, 289.3021 us/op
WorkloadActual   2: 4096 op, 690570539.00 ns, 168.5963 us/op
WorkloadActual   3: 4096 op, 700057482.00 ns, 170.9125 us/op
WorkloadActual   4: 4096 op, 686704688.00 ns, 167.6525 us/op
WorkloadActual   5: 4096 op, 676425289.00 ns, 165.1429 us/op
WorkloadActual   6: 4096 op, 683950654.00 ns, 166.9801 us/op
WorkloadActual   7: 4096 op, 774512185.00 ns, 189.0899 us/op
WorkloadActual   8: 4096 op, 689788884.00 ns, 168.4055 us/op
WorkloadActual   9: 4096 op, 684572774.00 ns, 167.1320 us/op
WorkloadActual  10: 4096 op, 686563743.00 ns, 167.6181 us/op
WorkloadActual  11: 4096 op, 676624678.00 ns, 165.1916 us/op
WorkloadActual  12: 4096 op, 795220667.00 ns, 194.1457 us/op
WorkloadActual  13: 4096 op, 908755154.00 ns, 221.8641 us/op
WorkloadActual  14: 4096 op, 843254416.00 ns, 205.8727 us/op
WorkloadActual  15: 4096 op, 1155043086.00 ns, 281.9929 us/op
WorkloadActual  16: 4096 op, 746536382.00 ns, 182.2599 us/op
WorkloadActual  17: 4096 op, 701031395.00 ns, 171.1502 us/op
WorkloadActual  18: 4096 op, 738460829.00 ns, 180.2883 us/op
WorkloadActual  19: 4096 op, 711440414.00 ns, 173.6915 us/op
WorkloadActual  20: 4096 op, 771567797.00 ns, 188.3710 us/op
WorkloadActual  21: 4096 op, 696638219.00 ns, 170.0777 us/op
WorkloadActual  22: 4096 op, 706080579.00 ns, 172.3830 us/op
WorkloadActual  23: 4096 op, 684275996.00 ns, 167.0596 us/op
WorkloadActual  24: 4096 op, 673569979.00 ns, 164.4458 us/op
WorkloadActual  25: 4096 op, 682024494.00 ns, 166.5099 us/op
WorkloadActual  26: 4096 op, 708965278.00 ns, 173.0872 us/op
WorkloadActual  27: 4096 op, 682707897.00 ns, 166.6767 us/op
WorkloadActual  28: 4096 op, 717964636.00 ns, 175.2843 us/op
WorkloadActual  29: 4096 op, 679428313.00 ns, 165.8761 us/op
WorkloadActual  30: 4096 op, 695800222.00 ns, 169.8731 us/op
WorkloadActual  31: 4096 op, 686038585.00 ns, 167.4899 us/op
WorkloadActual  32: 4096 op, 675103774.00 ns, 164.8203 us/op
WorkloadActual  33: 4096 op, 681667191.00 ns, 166.4227 us/op
WorkloadActual  34: 4096 op, 673174972.00 ns, 164.3494 us/op
WorkloadActual  35: 4096 op, 697505954.00 ns, 170.2895 us/op
WorkloadActual  36: 4096 op, 716570287.00 ns, 174.9439 us/op
WorkloadActual  37: 4096 op, 703337017.00 ns, 171.7131 us/op

// AfterActualRun
WorkloadResult   1: 4096 op, 690560643.00 ns, 168.5939 us/op
WorkloadResult   2: 4096 op, 700047586.00 ns, 170.9101 us/op
WorkloadResult   3: 4096 op, 686694792.00 ns, 167.6501 us/op
WorkloadResult   4: 4096 op, 676415393.00 ns, 165.1405 us/op
WorkloadResult   5: 4096 op, 683940758.00 ns, 166.9777 us/op
WorkloadResult   6: 4096 op, 689778988.00 ns, 168.4031 us/op
WorkloadResult   7: 4096 op, 684562878.00 ns, 167.1296 us/op
WorkloadResult   8: 4096 op, 686553847.00 ns, 167.6157 us/op
WorkloadResult   9: 4096 op, 676614782.00 ns, 165.1892 us/op
WorkloadResult  10: 4096 op, 746526486.00 ns, 182.2574 us/op
WorkloadResult  11: 4096 op, 701021499.00 ns, 171.1478 us/op
WorkloadResult  12: 4096 op, 738450933.00 ns, 180.2859 us/op
WorkloadResult  13: 4096 op, 711430518.00 ns, 173.6891 us/op
WorkloadResult  14: 4096 op, 696628323.00 ns, 170.0753 us/op
WorkloadResult  15: 4096 op, 706070683.00 ns, 172.3805 us/op
WorkloadResult  16: 4096 op, 684266100.00 ns, 167.0572 us/op
WorkloadResult  17: 4096 op, 673560083.00 ns, 164.4434 us/op
WorkloadResult  18: 4096 op, 682014598.00 ns, 166.5075 us/op
WorkloadResult  19: 4096 op, 708955382.00 ns, 173.0848 us/op
WorkloadResult  20: 4096 op, 682698001.00 ns, 166.6743 us/op
WorkloadResult  21: 4096 op, 717954740.00 ns, 175.2819 us/op
WorkloadResult  22: 4096 op, 679418417.00 ns, 165.8736 us/op
WorkloadResult  23: 4096 op, 695790326.00 ns, 169.8707 us/op
WorkloadResult  24: 4096 op, 686028689.00 ns, 167.4875 us/op
WorkloadResult  25: 4096 op, 675093878.00 ns, 164.8178 us/op
WorkloadResult  26: 4096 op, 681657295.00 ns, 166.4202 us/op
WorkloadResult  27: 4096 op, 673165076.00 ns, 164.3469 us/op
WorkloadResult  28: 4096 op, 697496058.00 ns, 170.2871 us/op
WorkloadResult  29: 4096 op, 716560391.00 ns, 174.9415 us/op
WorkloadResult  30: 4096 op, 703327121.00 ns, 171.7107 us/op
GC:  798 0 0 130482992 4096
Threading:  0 0 4096

// AfterAll
// Benchmark Process 21366 has exited with code 0.

Mean = 169.542 μs, StdErr = 0.812 μs (0.48%), N = 30, StdDev = 4.448 μs
Min = 164.347 μs, Q1 = 166.549 μs, Median = 168.027 μs, Q3 = 171.570 μs, Max = 182.257 μs
IQR = 5.021 μs, LowerFence = 159.018 μs, UpperFence = 179.101 μs
ConfidenceInterval = [166.570 μs; 172.513 μs] (CI 99.9%), Margin = 2.972 μs (1.75% of Mean)
Skewness = 1.16, Kurtosis = 3.85, MValue = 2

// ** Remained 1 (12.5 %) benchmark(s) to run. Estimated finish 2022-10-03 14:07 (0h 0m from now) **
// **************************
// Benchmark: LinqPerformance.Enumerable_Sum: net70(Runtime=.NET 7.0)
// *** Execute ***
// Launch: 1 / 1
// Execute: dotnet a8bcfeec-bf26-43f0-bd29-d10d18983489.dll --benchmarkName net._7.performance.LinqPerformance.Enumerable_Sum --job net70 --benchmarkId 3 in /Users/frank.hsu/Documents/Projects/Test/net.7.performance/src/bin/Release/net6.0/a8bcfeec-bf26-43f0-bd29-d10d18983489/bin/Release/net7.0
Failed to set up high priority. Make sure you have the right permissions. Message: Permission denied
// BeforeAnythingElse

// Benchmark Process Environment Information:
// Runtime=.NET 7.0.0 (7.0.22.42610), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: net70

OverheadJitting  1: 1 op, 370916.00 ns, 370.9160 us/op
WorkloadJitting  1: 1 op, 1815188.00 ns, 1.8152 ms/op

OverheadJitting  2: 16 op, 476094.00 ns, 29.7559 us/op
WorkloadJitting  2: 16 op, 3160330.00 ns, 197.5206 us/op

WorkloadPilot    1: 16 op, 2556582.00 ns, 159.7864 us/op
WorkloadPilot    2: 32 op, 5167415.00 ns, 161.4817 us/op
WorkloadPilot    3: 64 op, 11017694.00 ns, 172.1515 us/op
WorkloadPilot    4: 128 op, 21585084.00 ns, 168.6335 us/op
WorkloadPilot    5: 256 op, 42937269.00 ns, 167.7237 us/op
WorkloadPilot    6: 512 op, 86022577.00 ns, 168.0128 us/op
WorkloadPilot    7: 1024 op, 171487663.00 ns, 167.4684 us/op
WorkloadPilot    8: 2048 op, 346443676.00 ns, 169.1620 us/op
WorkloadPilot    9: 4096 op, 689169845.00 ns, 168.2544 us/op

OverheadWarmup   1: 4096 op, 9871.00 ns, 2.4099 ns/op
OverheadWarmup   2: 4096 op, 8859.00 ns, 2.1628 ns/op
OverheadWarmup   3: 4096 op, 8819.00 ns, 2.1531 ns/op
OverheadWarmup   4: 4096 op, 8813.00 ns, 2.1516 ns/op
OverheadWarmup   5: 4096 op, 8873.00 ns, 2.1663 ns/op
OverheadWarmup   6: 4096 op, 8795.00 ns, 2.1472 ns/op
OverheadWarmup   7: 4096 op, 8822.00 ns, 2.1538 ns/op
OverheadWarmup   8: 4096 op, 8844.00 ns, 2.1592 ns/op
OverheadWarmup   9: 4096 op, 8874.00 ns, 2.1665 ns/op
OverheadWarmup  10: 4096 op, 8848.00 ns, 2.1602 ns/op

OverheadActual   1: 4096 op, 8886.00 ns, 2.1694 ns/op
OverheadActual   2: 4096 op, 9022.00 ns, 2.2026 ns/op
OverheadActual   3: 4096 op, 8927.00 ns, 2.1794 ns/op
OverheadActual   4: 4096 op, 8922.00 ns, 2.1782 ns/op
OverheadActual   5: 4096 op, 8825.00 ns, 2.1545 ns/op
OverheadActual   6: 4096 op, 8818.00 ns, 2.1528 ns/op
OverheadActual   7: 4096 op, 9443.00 ns, 2.3054 ns/op
OverheadActual   8: 4096 op, 8838.00 ns, 2.1577 ns/op
OverheadActual   9: 4096 op, 8835.00 ns, 2.1570 ns/op
OverheadActual  10: 4096 op, 8866.00 ns, 2.1646 ns/op
OverheadActual  11: 4096 op, 14810.00 ns, 3.6157 ns/op
OverheadActual  12: 4096 op, 9019.00 ns, 2.2019 ns/op
OverheadActual  13: 4096 op, 8847.00 ns, 2.1599 ns/op
OverheadActual  14: 4096 op, 8816.00 ns, 2.1523 ns/op
OverheadActual  15: 4096 op, 8825.00 ns, 2.1545 ns/op

WorkloadWarmup   1: 4096 op, 680054290.00 ns, 166.0289 us/op
WorkloadWarmup   2: 4096 op, 701904422.00 ns, 171.3634 us/op
WorkloadWarmup   3: 4096 op, 680941200.00 ns, 166.2454 us/op
WorkloadWarmup   4: 4096 op, 672605387.00 ns, 164.2103 us/op
WorkloadWarmup   5: 4096 op, 674904292.00 ns, 164.7716 us/op
WorkloadWarmup   6: 4096 op, 671596175.00 ns, 163.9639 us/op

// BeforeActualRun
WorkloadActual   1: 4096 op, 678131388.00 ns, 165.5594 us/op
WorkloadActual   2: 4096 op, 675607614.00 ns, 164.9433 us/op
WorkloadActual   3: 4096 op, 675211975.00 ns, 164.8467 us/op
WorkloadActual   4: 4096 op, 674993068.00 ns, 164.7932 us/op
WorkloadActual   5: 4096 op, 672970552.00 ns, 164.2995 us/op
WorkloadActual   6: 4096 op, 670961828.00 ns, 163.8090 us/op
WorkloadActual   7: 4096 op, 676124507.00 ns, 165.0695 us/op
WorkloadActual   8: 4096 op, 675747314.00 ns, 164.9774 us/op
WorkloadActual   9: 4096 op, 678224924.00 ns, 165.5823 us/op
WorkloadActual  10: 4096 op, 677385045.00 ns, 165.3772 us/op
WorkloadActual  11: 4096 op, 675995064.00 ns, 165.0379 us/op
WorkloadActual  12: 4096 op, 674378146.00 ns, 164.6431 us/op
WorkloadActual  13: 4096 op, 673890963.00 ns, 164.5242 us/op
WorkloadActual  14: 4096 op, 674236723.00 ns, 164.6086 us/op
WorkloadActual  15: 4096 op, 681509510.00 ns, 166.3842 us/op

// AfterActualRun
WorkloadResult   1: 4096 op, 678122522.00 ns, 165.5573 us/op
WorkloadResult   2: 4096 op, 675598748.00 ns, 164.9411 us/op
WorkloadResult   3: 4096 op, 675203109.00 ns, 164.8445 us/op
WorkloadResult   4: 4096 op, 674984202.00 ns, 164.7911 us/op
WorkloadResult   5: 4096 op, 672961686.00 ns, 164.2973 us/op
WorkloadResult   6: 4096 op, 670952962.00 ns, 163.8069 us/op
WorkloadResult   7: 4096 op, 676115641.00 ns, 165.0673 us/op
WorkloadResult   8: 4096 op, 675738448.00 ns, 164.9752 us/op
WorkloadResult   9: 4096 op, 678216058.00 ns, 165.5801 us/op
WorkloadResult  10: 4096 op, 677376179.00 ns, 165.3750 us/op
WorkloadResult  11: 4096 op, 675986198.00 ns, 165.0357 us/op
WorkloadResult  12: 4096 op, 674369280.00 ns, 164.6409 us/op
WorkloadResult  13: 4096 op, 673882097.00 ns, 164.5220 us/op
WorkloadResult  14: 4096 op, 674227857.00 ns, 164.6064 us/op
GC:  798 0 0 130482992 4096
Threading:  0 0 4096

// AfterAll
// Benchmark Process 21452 has exited with code 0.

Mean = 164.860 μs, StdErr = 0.129 μs (0.08%), N = 14, StdDev = 0.482 μs
Min = 163.807 μs, Q1 = 164.615 μs, Median = 164.893 μs, Q3 = 165.059 μs, Max = 165.580 μs
IQR = 0.444 μs, LowerFence = 163.949 μs, UpperFence = 165.726 μs
ConfidenceInterval = [164.316 μs; 165.404 μs] (CI 99.9%), Margin = 0.544 μs (0.33% of Mean)
Skewness = -0.35, Kurtosis = 2.55, MValue = 2

// ** Remained 0 (0.0 %) benchmark(s) to run. Estimated finish 2022-10-03 14:07 (0h 0m from now) **
// ***** BenchmarkRunner: Finish  *****

// * Export *
  BenchmarkDotNet.Artifacts/results/net._7.performance.LinqPerformance-report.csv
  BenchmarkDotNet.Artifacts/results/net._7.performance.LinqPerformance-report-github.md
  BenchmarkDotNet.Artifacts/results/net._7.performance.LinqPerformance-report.html
  BenchmarkDotNet.Artifacts/results/net._7.performance.LinqPerformance-measurements.csv
  BenchmarkDotNet.Artifacts/results/BuildPlots.R
  BenchmarkDotNet.Artifacts/results/*.png

// * Detailed results *
LinqPerformance.Enumerable_Min: net60(Runtime=.NET 6.0)
Runtime = .NET 6.0.1 (6.0.121.56705), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 149.014 μs, StdErr = 0.108 μs (0.07%), N = 12, StdDev = 0.372 μs
Min = 148.494 μs, Q1 = 148.795 μs, Median = 148.971 μs, Q3 = 149.215 μs, Max = 149.800 μs
IQR = 0.420 μs, LowerFence = 148.165 μs, UpperFence = 149.845 μs
ConfidenceInterval = [148.537 μs; 149.491 μs] (CI 99.9%), Margin = 0.477 μs (0.32% of Mean)
Skewness = 0.43, Kurtosis = 2.35, MValue = 2
-------------------- Histogram --------------------
[148.281 μs ; 150.013 μs) | @@@@@@@@@@@@
---------------------------------------------------

LinqPerformance.Enumerable_Max: net60(Runtime=.NET 6.0)
Runtime = .NET 6.0.1 (6.0.121.56705), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 148.681 μs, StdErr = 0.120 μs (0.08%), N = 14, StdDev = 0.448 μs
Min = 147.673 μs, Q1 = 148.545 μs, Median = 148.678 μs, Q3 = 148.990 μs, Max = 149.350 μs
IQR = 0.444 μs, LowerFence = 147.879 μs, UpperFence = 149.656 μs
ConfidenceInterval = [148.176 μs; 149.186 μs] (CI 99.9%), Margin = 0.505 μs (0.34% of Mean)
Skewness = -0.52, Kurtosis = 2.67, MValue = 2
-------------------- Histogram --------------------
[147.429 μs ; 149.594 μs) | @@@@@@@@@@@@@@
---------------------------------------------------

LinqPerformance.Enumerable_Average: net60(Runtime=.NET 6.0)
Runtime = .NET 6.0.1 (6.0.121.56705), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 148.806 μs, StdErr = 0.178 μs (0.12%), N = 13, StdDev = 0.642 μs
Min = 148.047 μs, Q1 = 148.356 μs, Median = 148.562 μs, Q3 = 149.409 μs, Max = 150.151 μs
IQR = 1.053 μs, LowerFence = 146.776 μs, UpperFence = 150.989 μs
ConfidenceInterval = [148.037 μs; 149.575 μs] (CI 99.9%), Margin = 0.769 μs (0.52% of Mean)
Skewness = 0.7, Kurtosis = 2.05, MValue = 2
-------------------- Histogram --------------------
[147.688 μs ; 150.509 μs) | @@@@@@@@@@@@@
---------------------------------------------------

LinqPerformance.Enumerable_Sum: net60(Runtime=.NET 6.0)
Runtime = .NET 6.0.1 (6.0.121.56705), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 149.474 μs, StdErr = 0.432 μs (0.29%), N = 15, StdDev = 1.674 μs
Min = 147.610 μs, Q1 = 148.156 μs, Median = 148.599 μs, Q3 = 150.602 μs, Max = 152.443 μs
IQR = 2.447 μs, LowerFence = 144.486 μs, UpperFence = 154.272 μs
ConfidenceInterval = [147.685 μs; 151.263 μs] (CI 99.9%), Margin = 1.789 μs (1.20% of Mean)
Skewness = 0.61, Kurtosis = 1.74, MValue = 2
-------------------- Histogram --------------------
[146.923 μs ; 150.146 μs) | @@@@@@@@@@
[150.146 μs ; 153.333 μs) | @@@@@
---------------------------------------------------

LinqPerformance.Enumerable_Min: net70(Runtime=.NET 7.0)
Runtime = .NET 7.0.0 (7.0.22.42610), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 166.463 μs, StdErr = 0.458 μs (0.28%), N = 14, StdDev = 1.714 μs
Min = 163.256 μs, Q1 = 165.701 μs, Median = 166.487 μs, Q3 = 167.619 μs, Max = 168.896 μs
IQR = 1.918 μs, LowerFence = 162.824 μs, UpperFence = 170.495 μs
ConfidenceInterval = [164.530 μs; 168.397 μs] (CI 99.9%), Margin = 1.934 μs (1.16% of Mean)
Skewness = -0.28, Kurtosis = 1.93, MValue = 2
-------------------- Histogram --------------------
[162.323 μs ; 168.899 μs) | @@@@@@@@@@@@@@
---------------------------------------------------

LinqPerformance.Enumerable_Max: net70(Runtime=.NET 7.0)
Runtime = .NET 7.0.0 (7.0.22.42610), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 166.577 μs, StdErr = 0.544 μs (0.33%), N = 14, StdDev = 2.036 μs
Min = 163.871 μs, Q1 = 165.124 μs, Median = 166.023 μs, Q3 = 167.219 μs, Max = 170.611 μs
IQR = 2.095 μs, LowerFence = 161.982 μs, UpperFence = 170.361 μs
ConfidenceInterval = [164.280 μs; 168.873 μs] (CI 99.9%), Margin = 2.296 μs (1.38% of Mean)
Skewness = 0.67, Kurtosis = 2.15, MValue = 2
-------------------- Histogram --------------------
[162.763 μs ; 167.552 μs) | @@@@@@@@@@@
[167.552 μs ; 171.720 μs) | @@@
---------------------------------------------------

LinqPerformance.Enumerable_Average: net70(Runtime=.NET 7.0)
Runtime = .NET 7.0.0 (7.0.22.42610), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 169.542 μs, StdErr = 0.812 μs (0.48%), N = 30, StdDev = 4.448 μs
Min = 164.347 μs, Q1 = 166.549 μs, Median = 168.027 μs, Q3 = 171.570 μs, Max = 182.257 μs
IQR = 5.021 μs, LowerFence = 159.018 μs, UpperFence = 179.101 μs
ConfidenceInterval = [166.570 μs; 172.513 μs] (CI 99.9%), Margin = 2.972 μs (1.75% of Mean)
Skewness = 1.16, Kurtosis = 3.85, MValue = 2
-------------------- Histogram --------------------
[164.120 μs ; 167.877 μs) | @@@@@@@@@@@@@@@
[167.877 μs ; 173.356 μs) | @@@@@@@@@@
[173.356 μs ; 179.393 μs) | @@@
[179.393 μs ; 183.150 μs) | @@
---------------------------------------------------

LinqPerformance.Enumerable_Sum: net70(Runtime=.NET 7.0)
Runtime = .NET 7.0.0 (7.0.22.42610), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 164.860 μs, StdErr = 0.129 μs (0.08%), N = 14, StdDev = 0.482 μs
Min = 163.807 μs, Q1 = 164.615 μs, Median = 164.893 μs, Q3 = 165.059 μs, Max = 165.580 μs
IQR = 0.444 μs, LowerFence = 163.949 μs, UpperFence = 165.726 μs
ConfidenceInterval = [164.316 μs; 165.404 μs] (CI 99.9%), Margin = 0.544 μs (0.33% of Mean)
Skewness = -0.35, Kurtosis = 2.55, MValue = 2
-------------------- Histogram --------------------
[163.544 μs ; 165.843 μs) | @@@@@@@@@@@@@@
---------------------------------------------------

// * Summary *

BenchmarkDotNet=v0.13.2, OS=macOS Monterey 12.6 (21G115) [Darwin 21.6.0]
Intel Core i7-8850H CPU 2.60GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100-rc.1.22431.12
  [Host] : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT AVX2
  net60  : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT AVX2
  net70  : .NET 7.0.0 (7.0.22.42610), X64 RyuJIT AVX2


|             Method |   Job |  Runtime |     Mean |   Error |  StdDev | Allocated |
|------------------- |------ |--------- |---------:|--------:|--------:|----------:|
|     Enumerable_Min | net60 | .NET 6.0 | 149.0 μs | 0.48 μs | 0.37 μs |  31.11 KB |
|     Enumerable_Max | net60 | .NET 6.0 | 148.7 μs | 0.51 μs | 0.45 μs |  31.11 KB |
| Enumerable_Average | net60 | .NET 6.0 | 148.8 μs | 0.77 μs | 0.64 μs |  31.11 KB |
|     Enumerable_Sum | net60 | .NET 6.0 | 149.5 μs | 1.79 μs | 1.67 μs |  31.11 KB |
|     Enumerable_Min | net70 | .NET 7.0 | 166.5 μs | 1.93 μs | 1.71 μs |  31.11 KB |
|     Enumerable_Max | net70 | .NET 7.0 | 166.6 μs | 2.30 μs | 2.04 μs |  31.11 KB |
| Enumerable_Average | net70 | .NET 7.0 | 169.5 μs | 2.97 μs | 4.45 μs |  31.11 KB |
|     Enumerable_Sum | net70 | .NET 7.0 | 164.9 μs | 0.54 μs | 0.48 μs |  31.11 KB |

// * Hints *
Outliers
  LinqPerformance.Enumerable_Min: net60     -> 3 outliers were removed (153.21 μs..154.53 μs)
  LinqPerformance.Enumerable_Max: net60     -> 1 outlier  was  removed, 2 outliers were detected (147.67 μs, 150.00 μs)
  LinqPerformance.Enumerable_Average: net60 -> 2 outliers were removed (153.50 μs, 156.77 μs)
  LinqPerformance.Enumerable_Min: net70     -> 1 outlier  was  removed (171.39 μs)
  LinqPerformance.Enumerable_Max: net70     -> 1 outlier  was  removed (178.36 μs)
  LinqPerformance.Enumerable_Average: net70 -> 7 outliers were removed (188.37 μs..289.30 μs)
  LinqPerformance.Enumerable_Sum: net70     -> 1 outlier  was  removed (166.38 μs)
// * Config Issues *

// * Warnings *
Configuration
  Summary -> The CsvMeasurementsExporter is already present in the configuration. There may be unexpected results of RPlotExporter.

// * Legends *
  Mean      : Arithmetic mean of all measurements
  Error     : Half of 99.9% confidence interval
  StdDev    : Standard deviation of all measurements
  Allocated : Allocated memory per single operation (managed only, inclusive, 1KB = 1024B)
  1 μs      : 1 Microsecond (0.000001 sec)

// * Diagnostic Output - MemoryDiagnoser *


// ***** BenchmarkRunner: End *****
Run time: 00:02:33 (153.69 sec), executed benchmarks: 8

Global total time: 00:03:13 (193.37 sec), executed benchmarks: 8
// * Artifacts cleanup *
