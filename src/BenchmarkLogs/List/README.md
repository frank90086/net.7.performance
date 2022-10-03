```cmd
// Validating benchmarks:
// ***** BenchmarkRunner: Start   *****
// ***** Found 8 benchmark(s) in total *****
// ***** Building 2 exe(s) in Parallel: Start   *****
// ***** Done, took 00:00:09 (9.1 sec)   *****
// Found 8 benchmarks:
//   LinqPerformance.List_Min: net60(Runtime=.NET 6.0)
//   LinqPerformance.List_Max: net60(Runtime=.NET 6.0)
//   LinqPerformance.List_Average: net60(Runtime=.NET 6.0)
//   LinqPerformance.List_Sum: net60(Runtime=.NET 6.0)
//   LinqPerformance.List_Min: net70(Runtime=.NET 7.0)
//   LinqPerformance.List_Max: net70(Runtime=.NET 7.0)
//   LinqPerformance.List_Average: net70(Runtime=.NET 7.0)
//   LinqPerformance.List_Sum: net70(Runtime=.NET 7.0)

// **************************
// Benchmark: LinqPerformance.List_Min: net60(Runtime=.NET 6.0)
// *** Execute ***
// Launch: 1 / 1
// Execute: dotnet 92f4588f-5b5c-430f-9f57-ecccb30f862f.dll --benchmarkName net._7.performance.LinqPerformance.List_Min --job net60 --benchmarkId 0 in /Users/frank.hsu/Documents/Projects/Test/net.7.performance/src/bin/Release/net6.0/92f4588f-5b5c-430f-9f57-ecccb30f862f/bin/Release/net6.0
Failed to set up high priority. Make sure you have the right permissions. Message: Permission denied
// BeforeAnythingElse

// Benchmark Process Environment Information:
// Runtime=.NET 6.0.1 (6.0.121.56705), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: net60

OverheadJitting  1: 1 op, 644037.00 ns, 644.0370 us/op
WorkloadJitting  1: 1 op, 398887.00 ns, 398.8870 us/op

OverheadJitting  2: 16 op, 604744.00 ns, 37.7965 us/op
WorkloadJitting  2: 16 op, 668743.00 ns, 41.7964 us/op

WorkloadPilot    1: 16 op, 18044.00 ns, 1.1278 us/op
WorkloadPilot    2: 32 op, 33419.00 ns, 1.0443 us/op
WorkloadPilot    3: 64 op, 64123.00 ns, 1.0019 us/op
WorkloadPilot    4: 128 op, 125783.00 ns, 982.6797 ns/op
WorkloadPilot    5: 256 op, 269866.00 ns, 1.0542 us/op
WorkloadPilot    6: 512 op, 503049.00 ns, 982.5176 ns/op
WorkloadPilot    7: 1024 op, 972076.00 ns, 949.2930 ns/op
WorkloadPilot    8: 2048 op, 1995861.00 ns, 974.5415 ns/op
WorkloadPilot    9: 4096 op, 4374124.00 ns, 1.0679 us/op
WorkloadPilot   10: 8192 op, 7958826.00 ns, 971.5364 ns/op
WorkloadPilot   11: 16384 op, 21134065.00 ns, 1.2899 us/op
WorkloadPilot   12: 32768 op, 31624887.00 ns, 965.1150 ns/op
WorkloadPilot   13: 65536 op, 63150748.00 ns, 963.6039 ns/op
WorkloadPilot   14: 131072 op, 107475541.00 ns, 819.9733 ns/op
WorkloadPilot   15: 262144 op, 196024443.00 ns, 747.7739 ns/op
WorkloadPilot   16: 524288 op, 401143951.00 ns, 765.1214 ns/op
WorkloadPilot   17: 1048576 op, 1083554540.00 ns, 1.0334 us/op

OverheadWarmup   1: 1048576 op, 2095834.00 ns, 1.9987 ns/op
OverheadWarmup   2: 1048576 op, 2210179.00 ns, 2.1078 ns/op
OverheadWarmup   3: 1048576 op, 2438243.00 ns, 2.3253 ns/op
OverheadWarmup   4: 1048576 op, 2369684.00 ns, 2.2599 ns/op
OverheadWarmup   5: 1048576 op, 2608736.00 ns, 2.4879 ns/op
OverheadWarmup   6: 1048576 op, 2406611.00 ns, 2.2951 ns/op

OverheadActual   1: 1048576 op, 2440402.00 ns, 2.3273 ns/op
OverheadActual   2: 1048576 op, 2426856.00 ns, 2.3144 ns/op
OverheadActual   3: 1048576 op, 2531513.00 ns, 2.4142 ns/op
OverheadActual   4: 1048576 op, 2343988.00 ns, 2.2354 ns/op
OverheadActual   5: 1048576 op, 2389863.00 ns, 2.2792 ns/op
OverheadActual   6: 1048576 op, 2195495.00 ns, 2.0938 ns/op
OverheadActual   7: 1048576 op, 2268346.00 ns, 2.1633 ns/op
OverheadActual   8: 1048576 op, 2384115.00 ns, 2.2737 ns/op
OverheadActual   9: 1048576 op, 2339908.00 ns, 2.2315 ns/op
OverheadActual  10: 1048576 op, 2178454.00 ns, 2.0775 ns/op
OverheadActual  11: 1048576 op, 2026140.00 ns, 1.9323 ns/op
OverheadActual  12: 1048576 op, 1995161.00 ns, 1.9027 ns/op
OverheadActual  13: 1048576 op, 1976693.00 ns, 1.8851 ns/op
OverheadActual  14: 1048576 op, 2065423.00 ns, 1.9697 ns/op
OverheadActual  15: 1048576 op, 1993249.00 ns, 1.9009 ns/op
OverheadActual  16: 1048576 op, 2063472.00 ns, 1.9679 ns/op
OverheadActual  17: 1048576 op, 1991977.00 ns, 1.8997 ns/op
OverheadActual  18: 1048576 op, 1999593.00 ns, 1.9070 ns/op
OverheadActual  19: 1048576 op, 1992195.00 ns, 1.8999 ns/op
OverheadActual  20: 1048576 op, 2041997.00 ns, 1.9474 ns/op

WorkloadWarmup   1: 1048576 op, 819238567.00 ns, 781.2868 ns/op
WorkloadWarmup   2: 1048576 op, 806678884.00 ns, 769.3089 ns/op
WorkloadWarmup   3: 1048576 op, 803938921.00 ns, 766.6959 ns/op
WorkloadWarmup   4: 1048576 op, 784758422.00 ns, 748.4040 ns/op
WorkloadWarmup   5: 1048576 op, 854222581.00 ns, 814.6501 ns/op
WorkloadWarmup   6: 1048576 op, 782306631.00 ns, 746.0657 ns/op
WorkloadWarmup   7: 1048576 op, 779791604.00 ns, 743.6672 ns/op
WorkloadWarmup   8: 1048576 op, 813065990.00 ns, 775.4002 ns/op
WorkloadWarmup   9: 1048576 op, 790464393.00 ns, 753.8456 ns/op

// BeforeActualRun
WorkloadActual   1: 1048576 op, 782687369.00 ns, 746.4288 ns/op
WorkloadActual   2: 1048576 op, 780343507.00 ns, 744.1936 ns/op
WorkloadActual   3: 1048576 op, 780650568.00 ns, 744.4864 ns/op
WorkloadActual   4: 1048576 op, 779170729.00 ns, 743.0751 ns/op
WorkloadActual   5: 1048576 op, 780890475.00 ns, 744.7152 ns/op
WorkloadActual   6: 1048576 op, 780508874.00 ns, 744.3513 ns/op
WorkloadActual   7: 1048576 op, 776494836.00 ns, 740.5232 ns/op
WorkloadActual   8: 1048576 op, 775302573.00 ns, 739.3862 ns/op
WorkloadActual   9: 1048576 op, 774206369.00 ns, 738.3407 ns/op
WorkloadActual  10: 1048576 op, 780942288.00 ns, 744.7646 ns/op
WorkloadActual  11: 1048576 op, 781190880.00 ns, 745.0017 ns/op
WorkloadActual  12: 1048576 op, 778901259.00 ns, 742.8181 ns/op
WorkloadActual  13: 1048576 op, 788112182.00 ns, 751.6023 ns/op
WorkloadActual  14: 1048576 op, 773971327.00 ns, 738.1166 ns/op
WorkloadActual  15: 1048576 op, 772007057.00 ns, 736.2433 ns/op

// AfterActualRun
WorkloadResult   1: 1048576 op, 780565430.50 ns, 744.4052 ns/op
WorkloadResult   2: 1048576 op, 778221568.50 ns, 742.1699 ns/op
WorkloadResult   3: 1048576 op, 778528629.50 ns, 742.4628 ns/op
WorkloadResult   4: 1048576 op, 777048790.50 ns, 741.0515 ns/op
WorkloadResult   5: 1048576 op, 778768536.50 ns, 742.6916 ns/op
WorkloadResult   6: 1048576 op, 778386935.50 ns, 742.3276 ns/op
WorkloadResult   7: 1048576 op, 774372897.50 ns, 738.4995 ns/op
WorkloadResult   8: 1048576 op, 773180634.50 ns, 737.3625 ns/op
WorkloadResult   9: 1048576 op, 772084430.50 ns, 736.3171 ns/op
WorkloadResult  10: 1048576 op, 778820349.50 ns, 742.7410 ns/op
WorkloadResult  11: 1048576 op, 779068941.50 ns, 742.9780 ns/op
WorkloadResult  12: 1048576 op, 776779320.50 ns, 740.7945 ns/op
WorkloadResult  13: 1048576 op, 785990243.50 ns, 749.5787 ns/op
WorkloadResult  14: 1048576 op, 771849388.50 ns, 736.0929 ns/op
WorkloadResult  15: 1048576 op, 769885118.50 ns, 734.2197 ns/op
GC:  8 0 0 41943856 1048576
Threading:  0 0 1048576

// AfterAll
// Benchmark Process 21861 has exited with code 0.

Mean = 740.913 ns, StdErr = 1.004 ns (0.14%), N = 15, StdDev = 3.888 ns
Min = 734.220 ns, Q1 = 737.931 ns, Median = 742.170 ns, Q3 = 742.716 ns, Max = 749.579 ns
IQR = 4.785 ns, LowerFence = 730.753 ns, UpperFence = 749.894 ns
ConfidenceInterval = [736.756 ns; 745.070 ns] (CI 99.9%), Margin = 4.157 ns (0.56% of Mean)
Skewness = 0.18, Kurtosis = 2.63, MValue = 2

// ** Remained 7 (87.5 %) benchmark(s) to run. Estimated finish 2022-10-03 14:13 (0h 2m from now) **
// **************************
// Benchmark: LinqPerformance.List_Max: net60(Runtime=.NET 6.0)
// *** Execute ***
// Launch: 1 / 1
// Execute: dotnet 92f4588f-5b5c-430f-9f57-ecccb30f862f.dll --benchmarkName net._7.performance.LinqPerformance.List_Max --job net60 --benchmarkId 1 in /Users/frank.hsu/Documents/Projects/Test/net.7.performance/src/bin/Release/net6.0/92f4588f-5b5c-430f-9f57-ecccb30f862f/bin/Release/net6.0
Failed to set up high priority. Make sure you have the right permissions. Message: Permission denied
// BeforeAnythingElse

// Benchmark Process Environment Information:
// Runtime=.NET 6.0.1 (6.0.121.56705), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: net60

OverheadJitting  1: 1 op, 280009.00 ns, 280.0090 us/op
WorkloadJitting  1: 1 op, 233232.00 ns, 233.2320 us/op

OverheadJitting  2: 16 op, 391212.00 ns, 24.4507 us/op
WorkloadJitting  2: 16 op, 430691.00 ns, 26.9182 us/op

WorkloadPilot    1: 16 op, 14715.00 ns, 919.6875 ns/op
WorkloadPilot    2: 32 op, 27563.00 ns, 861.3438 ns/op
WorkloadPilot    3: 64 op, 50712.00 ns, 792.3750 ns/op
WorkloadPilot    4: 128 op, 97882.00 ns, 764.7031 ns/op
WorkloadPilot    5: 256 op, 195331.00 ns, 763.0117 ns/op
WorkloadPilot    6: 512 op, 392873.00 ns, 767.3301 ns/op
WorkloadPilot    7: 1024 op, 906472.00 ns, 885.2266 ns/op
WorkloadPilot    8: 2048 op, 1544854.00 ns, 754.3232 ns/op
WorkloadPilot    9: 4096 op, 3079779.00 ns, 751.8992 ns/op
WorkloadPilot   10: 8192 op, 6293875.00 ns, 768.2953 ns/op
WorkloadPilot   11: 16384 op, 12703894.00 ns, 775.3842 ns/op
WorkloadPilot   12: 32768 op, 25403804.00 ns, 775.2626 ns/op
WorkloadPilot   13: 65536 op, 50867647.00 ns, 776.1787 ns/op
WorkloadPilot   14: 131072 op, 101195676.00 ns, 772.0617 ns/op
WorkloadPilot   15: 262144 op, 199575386.00 ns, 761.3197 ns/op
WorkloadPilot   16: 524288 op, 398800559.00 ns, 760.6517 ns/op
WorkloadPilot   17: 1048576 op, 867678055.00 ns, 827.4823 ns/op

OverheadWarmup   1: 1048576 op, 2244416.00 ns, 2.1404 ns/op
OverheadWarmup   2: 1048576 op, 2395149.00 ns, 2.2842 ns/op
OverheadWarmup   3: 1048576 op, 2889660.00 ns, 2.7558 ns/op
OverheadWarmup   4: 1048576 op, 2431493.00 ns, 2.3189 ns/op
OverheadWarmup   5: 1048576 op, 2453237.00 ns, 2.3396 ns/op
OverheadWarmup   6: 1048576 op, 2459481.00 ns, 2.3455 ns/op
OverheadWarmup   7: 1048576 op, 2469724.00 ns, 2.3553 ns/op
OverheadWarmup   8: 1048576 op, 2410677.00 ns, 2.2990 ns/op

OverheadActual   1: 1048576 op, 2356669.00 ns, 2.2475 ns/op
OverheadActual   2: 1048576 op, 2368465.00 ns, 2.2587 ns/op
OverheadActual   3: 1048576 op, 2343589.00 ns, 2.2350 ns/op
OverheadActual   4: 1048576 op, 2355899.00 ns, 2.2468 ns/op
OverheadActual   5: 1048576 op, 2348392.00 ns, 2.2396 ns/op
OverheadActual   6: 1048576 op, 2343885.00 ns, 2.2353 ns/op
OverheadActual   7: 1048576 op, 2361506.00 ns, 2.2521 ns/op
OverheadActual   8: 1048576 op, 2372976.00 ns, 2.2630 ns/op
OverheadActual   9: 1048576 op, 2471212.00 ns, 2.3567 ns/op
OverheadActual  10: 1048576 op, 2422233.00 ns, 2.3100 ns/op
OverheadActual  11: 1048576 op, 2365901.00 ns, 2.2563 ns/op
OverheadActual  12: 1048576 op, 2316215.00 ns, 2.2089 ns/op
OverheadActual  13: 1048576 op, 2300280.00 ns, 2.1937 ns/op
OverheadActual  14: 1048576 op, 2067258.00 ns, 1.9715 ns/op
OverheadActual  15: 1048576 op, 1992333.00 ns, 1.9000 ns/op
OverheadActual  16: 1048576 op, 2040841.00 ns, 1.9463 ns/op
OverheadActual  17: 1048576 op, 1981356.00 ns, 1.8896 ns/op
OverheadActual  18: 1048576 op, 1993997.00 ns, 1.9016 ns/op
OverheadActual  19: 1048576 op, 1997689.00 ns, 1.9051 ns/op
OverheadActual  20: 1048576 op, 2004730.00 ns, 1.9119 ns/op

WorkloadWarmup   1: 1048576 op, 963176548.00 ns, 918.5567 ns/op
WorkloadWarmup   2: 1048576 op, 800605864.00 ns, 763.5173 ns/op
WorkloadWarmup   3: 1048576 op, 799434718.00 ns, 762.4004 ns/op
WorkloadWarmup   4: 1048576 op, 795548072.00 ns, 758.6938 ns/op
WorkloadWarmup   5: 1048576 op, 801698952.00 ns, 764.5597 ns/op
WorkloadWarmup   6: 1048576 op, 809479358.00 ns, 771.9797 ns/op
WorkloadWarmup   7: 1048576 op, 800171110.00 ns, 763.1026 ns/op
WorkloadWarmup   8: 1048576 op, 796819192.00 ns, 759.9060 ns/op
WorkloadWarmup   9: 1048576 op, 796998327.00 ns, 760.0768 ns/op
WorkloadWarmup  10: 1048576 op, 796012292.00 ns, 759.1365 ns/op

// BeforeActualRun
WorkloadActual   1: 1048576 op, 794982461.00 ns, 758.1544 ns/op
WorkloadActual   2: 1048576 op, 800612123.00 ns, 763.5232 ns/op
WorkloadActual   3: 1048576 op, 801176258.00 ns, 764.0612 ns/op
WorkloadActual   4: 1048576 op, 796265081.00 ns, 759.3776 ns/op
WorkloadActual   5: 1048576 op, 799037598.00 ns, 762.0216 ns/op
WorkloadActual   6: 1048576 op, 800022299.00 ns, 762.9607 ns/op
WorkloadActual   7: 1048576 op, 800506888.00 ns, 763.4229 ns/op
WorkloadActual   8: 1048576 op, 810005542.00 ns, 772.4815 ns/op
WorkloadActual   9: 1048576 op, 799469048.00 ns, 762.4331 ns/op
WorkloadActual  10: 1048576 op, 804416627.00 ns, 767.1515 ns/op
WorkloadActual  11: 1048576 op, 803703357.00 ns, 766.4712 ns/op
WorkloadActual  12: 1048576 op, 801374077.00 ns, 764.2499 ns/op
WorkloadActual  13: 1048576 op, 802075713.00 ns, 764.9190 ns/op
WorkloadActual  14: 1048576 op, 830679917.00 ns, 792.1981 ns/op
WorkloadActual  15: 1048576 op, 921094015.00 ns, 878.4237 ns/op

// AfterActualRun
WorkloadResult   1: 1048576 op, 792638724.00 ns, 755.9192 ns/op
WorkloadResult   2: 1048576 op, 798268386.00 ns, 761.2881 ns/op
WorkloadResult   3: 1048576 op, 798832521.00 ns, 761.8261 ns/op
WorkloadResult   4: 1048576 op, 793921344.00 ns, 757.1424 ns/op
WorkloadResult   5: 1048576 op, 796693861.00 ns, 759.7865 ns/op
WorkloadResult   6: 1048576 op, 797678562.00 ns, 760.7256 ns/op
WorkloadResult   7: 1048576 op, 798163151.00 ns, 761.1877 ns/op
WorkloadResult   8: 1048576 op, 807661805.00 ns, 770.2463 ns/op
WorkloadResult   9: 1048576 op, 797125311.00 ns, 760.1979 ns/op
WorkloadResult  10: 1048576 op, 802072890.00 ns, 764.9163 ns/op
WorkloadResult  11: 1048576 op, 801359620.00 ns, 764.2361 ns/op
WorkloadResult  12: 1048576 op, 799030340.00 ns, 762.0147 ns/op
WorkloadResult  13: 1048576 op, 799731976.00 ns, 762.6838 ns/op
GC:  8 0 0 41943856 1048576
Threading:  0 0 1048576

// AfterAll
// Benchmark Process 21913 has exited with code 0.

Mean = 761.705 ns, StdErr = 0.988 ns (0.13%), N = 13, StdDev = 3.564 ns
Min = 755.919 ns, Q1 = 760.198 ns, Median = 761.288 ns, Q3 = 762.684 ns, Max = 770.246 ns
IQR = 2.486 ns, LowerFence = 756.469 ns, UpperFence = 766.413 ns
ConfidenceInterval = [757.438 ns; 765.973 ns] (CI 99.9%), Margin = 4.268 ns (0.56% of Mean)
Skewness = 0.63, Kurtosis = 3.36, MValue = 2

// ** Remained 6 (75.0 %) benchmark(s) to run. Estimated finish 2022-10-03 14:13 (0h 2m from now) **
// **************************
// Benchmark: LinqPerformance.List_Average: net60(Runtime=.NET 6.0)
// *** Execute ***
// Launch: 1 / 1
// Execute: dotnet 92f4588f-5b5c-430f-9f57-ecccb30f862f.dll --benchmarkName net._7.performance.LinqPerformance.List_Average --job net60 --benchmarkId 2 in /Users/frank.hsu/Documents/Projects/Test/net.7.performance/src/bin/Release/net6.0/92f4588f-5b5c-430f-9f57-ecccb30f862f/bin/Release/net6.0
Failed to set up high priority. Make sure you have the right permissions. Message: Permission denied
// BeforeAnythingElse

// Benchmark Process Environment Information:
// Runtime=.NET 6.0.1 (6.0.121.56705), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: net60

OverheadJitting  1: 1 op, 500635.00 ns, 500.6350 us/op
WorkloadJitting  1: 1 op, 470301.00 ns, 470.3010 us/op

OverheadJitting  2: 16 op, 682801.00 ns, 42.6751 us/op
WorkloadJitting  2: 16 op, 1215596.00 ns, 75.9748 us/op

WorkloadPilot    1: 16 op, 16335.00 ns, 1.0209 us/op
WorkloadPilot    2: 32 op, 28854.00 ns, 901.6875 ns/op
WorkloadPilot    3: 64 op, 54790.00 ns, 856.0938 ns/op
WorkloadPilot    4: 128 op, 107783.00 ns, 842.0547 ns/op
WorkloadPilot    5: 256 op, 214589.00 ns, 838.2383 ns/op
WorkloadPilot    6: 512 op, 526608.00 ns, 1.0285 us/op
WorkloadPilot    7: 1024 op, 970455.00 ns, 947.7100 ns/op
WorkloadPilot    8: 2048 op, 2212298.00 ns, 1.0802 us/op
WorkloadPilot    9: 4096 op, 4037773.00 ns, 985.7844 ns/op
WorkloadPilot   10: 8192 op, 7839241.00 ns, 956.9386 ns/op
WorkloadPilot   11: 16384 op, 15338350.00 ns, 936.1786 ns/op
WorkloadPilot   12: 32768 op, 32032763.00 ns, 977.5623 ns/op
WorkloadPilot   13: 65536 op, 59410325.00 ns, 906.5296 ns/op
WorkloadPilot   14: 131072 op, 124376195.00 ns, 948.9151 ns/op
WorkloadPilot   15: 262144 op, 217461454.00 ns, 829.5496 ns/op
WorkloadPilot   16: 524288 op, 396595432.00 ns, 756.4458 ns/op
WorkloadPilot   17: 1048576 op, 795381782.00 ns, 758.5352 ns/op

OverheadWarmup   1: 1048576 op, 2019155.00 ns, 1.9256 ns/op
OverheadWarmup   2: 1048576 op, 2005311.00 ns, 1.9124 ns/op
OverheadWarmup   3: 1048576 op, 2789297.00 ns, 2.6601 ns/op
OverheadWarmup   4: 1048576 op, 2134584.00 ns, 2.0357 ns/op
OverheadWarmup   5: 1048576 op, 2354914.00 ns, 2.2458 ns/op
OverheadWarmup   6: 1048576 op, 2236645.00 ns, 2.1330 ns/op

OverheadActual   1: 1048576 op, 2495011.00 ns, 2.3794 ns/op
OverheadActual   2: 1048576 op, 2568683.00 ns, 2.4497 ns/op
OverheadActual   3: 1048576 op, 2579097.00 ns, 2.4596 ns/op
OverheadActual   4: 1048576 op, 2443388.00 ns, 2.3302 ns/op
OverheadActual   5: 1048576 op, 2487030.00 ns, 2.3718 ns/op
OverheadActual   6: 1048576 op, 2473763.00 ns, 2.3592 ns/op
OverheadActual   7: 1048576 op, 2547747.00 ns, 2.4297 ns/op
OverheadActual   8: 1048576 op, 2507035.00 ns, 2.3909 ns/op
OverheadActual   9: 1048576 op, 2663040.00 ns, 2.5397 ns/op
OverheadActual  10: 1048576 op, 2439017.00 ns, 2.3260 ns/op
OverheadActual  11: 1048576 op, 2507662.00 ns, 2.3915 ns/op
OverheadActual  12: 1048576 op, 2581792.00 ns, 2.4622 ns/op
OverheadActual  13: 1048576 op, 2494939.00 ns, 2.3794 ns/op
OverheadActual  14: 1048576 op, 2594151.00 ns, 2.4740 ns/op
OverheadActual  15: 1048576 op, 2447831.00 ns, 2.3344 ns/op

WorkloadWarmup   1: 1048576 op, 799543684.00 ns, 762.5043 ns/op
WorkloadWarmup   2: 1048576 op, 876529842.00 ns, 835.9240 ns/op
WorkloadWarmup   3: 1048576 op, 797846130.00 ns, 760.8854 ns/op
WorkloadWarmup   4: 1048576 op, 796321780.00 ns, 759.4316 ns/op
WorkloadWarmup   5: 1048576 op, 782713090.00 ns, 746.4534 ns/op
WorkloadWarmup   6: 1048576 op, 784619925.00 ns, 748.2719 ns/op
WorkloadWarmup   7: 1048576 op, 786236296.00 ns, 749.8134 ns/op
WorkloadWarmup   8: 1048576 op, 801729753.00 ns, 764.5891 ns/op
WorkloadWarmup   9: 1048576 op, 842999760.00 ns, 803.9472 ns/op
WorkloadWarmup  10: 1048576 op, 826137234.00 ns, 787.8659 ns/op

// BeforeActualRun
WorkloadActual   1: 1048576 op, 788263430.00 ns, 751.7466 ns/op
WorkloadActual   2: 1048576 op, 818116588.00 ns, 780.2168 ns/op
WorkloadActual   3: 1048576 op, 787488277.00 ns, 751.0073 ns/op
WorkloadActual   4: 1048576 op, 802932539.00 ns, 765.7361 ns/op
WorkloadActual   5: 1048576 op, 798857866.00 ns, 761.8502 ns/op
WorkloadActual   6: 1048576 op, 792022580.00 ns, 755.3316 ns/op
WorkloadActual   7: 1048576 op, 794544942.00 ns, 757.7371 ns/op
WorkloadActual   8: 1048576 op, 783902966.00 ns, 747.5881 ns/op
WorkloadActual   9: 1048576 op, 782512559.00 ns, 746.2621 ns/op
WorkloadActual  10: 1048576 op, 789112300.00 ns, 752.5561 ns/op
WorkloadActual  11: 1048576 op, 783183914.00 ns, 746.9024 ns/op
WorkloadActual  12: 1048576 op, 783215473.00 ns, 746.9325 ns/op
WorkloadActual  13: 1048576 op, 784328002.00 ns, 747.9935 ns/op
WorkloadActual  14: 1048576 op, 782061362.00 ns, 745.8318 ns/op
WorkloadActual  15: 1048576 op, 816404202.00 ns, 778.5837 ns/op

// AfterActualRun
WorkloadResult   1: 1048576 op, 785756395.00 ns, 749.3557 ns/op
WorkloadResult   2: 1048576 op, 784981242.00 ns, 748.6164 ns/op
WorkloadResult   3: 1048576 op, 800425504.00 ns, 763.3452 ns/op
WorkloadResult   4: 1048576 op, 796350831.00 ns, 759.4593 ns/op
WorkloadResult   5: 1048576 op, 789515545.00 ns, 752.9407 ns/op
WorkloadResult   6: 1048576 op, 792037907.00 ns, 755.3462 ns/op
WorkloadResult   7: 1048576 op, 781395931.00 ns, 745.1972 ns/op
WorkloadResult   8: 1048576 op, 780005524.00 ns, 743.8712 ns/op
WorkloadResult   9: 1048576 op, 786605265.00 ns, 750.1652 ns/op
WorkloadResult  10: 1048576 op, 780676879.00 ns, 744.5115 ns/op
WorkloadResult  11: 1048576 op, 780708438.00 ns, 744.5416 ns/op
WorkloadResult  12: 1048576 op, 781820967.00 ns, 745.6026 ns/op
WorkloadResult  13: 1048576 op, 779554327.00 ns, 743.4409 ns/op
WorkloadResult  14: 1048576 op, 813897167.00 ns, 776.1928 ns/op
GC:  8 0 0 41943856 1048576
Threading:  0 0 1048576

// AfterAll
// Benchmark Process 21967 has exited with code 0.

Mean = 751.613 ns, StdErr = 2.502 ns (0.33%), N = 14, StdDev = 9.363 ns
Min = 743.441 ns, Q1 = 744.705 ns, Median = 748.986 ns, Q3 = 754.745 ns, Max = 776.193 ns
IQR = 10.039 ns, LowerFence = 729.646 ns, UpperFence = 769.804 ns
ConfidenceInterval = [741.051 ns; 762.176 ns] (CI 99.9%), Margin = 10.562 ns (1.41% of Mean)
Skewness = 1.28, Kurtosis = 3.76, MValue = 2

// ** Remained 5 (62.5 %) benchmark(s) to run. Estimated finish 2022-10-03 14:13 (0h 1m from now) **
// **************************
// Benchmark: LinqPerformance.List_Sum: net60(Runtime=.NET 6.0)
// *** Execute ***
// Launch: 1 / 1
// Execute: dotnet 92f4588f-5b5c-430f-9f57-ecccb30f862f.dll --benchmarkName net._7.performance.LinqPerformance.List_Sum --job net60 --benchmarkId 3 in /Users/frank.hsu/Documents/Projects/Test/net.7.performance/src/bin/Release/net6.0/92f4588f-5b5c-430f-9f57-ecccb30f862f/bin/Release/net6.0
Failed to set up high priority. Make sure you have the right permissions. Message: Permission denied
// BeforeAnythingElse

// Benchmark Process Environment Information:
// Runtime=.NET 6.0.1 (6.0.121.56705), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: net60

OverheadJitting  1: 1 op, 329826.00 ns, 329.8260 us/op
WorkloadJitting  1: 1 op, 309053.00 ns, 309.0530 us/op

OverheadJitting  2: 16 op, 518262.00 ns, 32.3914 us/op
WorkloadJitting  2: 16 op, 600428.00 ns, 37.5267 us/op

WorkloadPilot    1: 16 op, 16417.00 ns, 1.0261 us/op
WorkloadPilot    2: 32 op, 28773.00 ns, 899.1562 ns/op
WorkloadPilot    3: 64 op, 55092.00 ns, 860.8125 ns/op
WorkloadPilot    4: 128 op, 133665.00 ns, 1.0443 us/op
WorkloadPilot    5: 256 op, 213989.00 ns, 835.8945 ns/op
WorkloadPilot    6: 512 op, 426048.00 ns, 832.1250 ns/op
WorkloadPilot    7: 1024 op, 872437.00 ns, 851.9893 ns/op
WorkloadPilot    8: 2048 op, 1721082.00 ns, 840.3721 ns/op
WorkloadPilot    9: 4096 op, 3432645.00 ns, 838.0481 ns/op
WorkloadPilot   10: 8192 op, 7205779.00 ns, 879.6117 ns/op
WorkloadPilot   11: 16384 op, 16007800.00 ns, 977.0386 ns/op
WorkloadPilot   12: 32768 op, 28356633.00 ns, 865.3758 ns/op
WorkloadPilot   13: 65536 op, 48805020.00 ns, 744.7055 ns/op
WorkloadPilot   14: 131072 op, 94861692.00 ns, 723.7373 ns/op
WorkloadPilot   15: 262144 op, 195466549.00 ns, 745.6457 ns/op
WorkloadPilot   16: 524288 op, 421831808.00 ns, 804.5803 ns/op
WorkloadPilot   17: 1048576 op, 900241662.00 ns, 858.5374 ns/op

OverheadWarmup   1: 1048576 op, 2150442.00 ns, 2.0508 ns/op
OverheadWarmup   2: 1048576 op, 1994539.00 ns, 1.9021 ns/op
OverheadWarmup   3: 1048576 op, 2320815.00 ns, 2.2133 ns/op
OverheadWarmup   4: 1048576 op, 2322102.00 ns, 2.2145 ns/op
OverheadWarmup   5: 1048576 op, 2205125.00 ns, 2.1030 ns/op
OverheadWarmup   6: 1048576 op, 2778715.00 ns, 2.6500 ns/op
OverheadWarmup   7: 1048576 op, 2473330.00 ns, 2.3588 ns/op

OverheadActual   1: 1048576 op, 2721204.00 ns, 2.5951 ns/op
OverheadActual   2: 1048576 op, 2610617.00 ns, 2.4897 ns/op
OverheadActual   3: 1048576 op, 2910116.00 ns, 2.7753 ns/op
OverheadActual   4: 1048576 op, 2533296.00 ns, 2.4159 ns/op
OverheadActual   5: 1048576 op, 2413534.00 ns, 2.3017 ns/op
OverheadActual   6: 1048576 op, 2828961.00 ns, 2.6979 ns/op
OverheadActual   7: 1048576 op, 2677832.00 ns, 2.5538 ns/op
OverheadActual   8: 1048576 op, 2546297.00 ns, 2.4283 ns/op
OverheadActual   9: 1048576 op, 2460006.00 ns, 2.3460 ns/op
OverheadActual  10: 1048576 op, 2443626.00 ns, 2.3304 ns/op
OverheadActual  11: 1048576 op, 2620319.00 ns, 2.4989 ns/op
OverheadActual  12: 1048576 op, 3750058.00 ns, 3.5763 ns/op
OverheadActual  13: 1048576 op, 2936781.00 ns, 2.8007 ns/op
OverheadActual  14: 1048576 op, 3885383.00 ns, 3.7054 ns/op
OverheadActual  15: 1048576 op, 2904690.00 ns, 2.7701 ns/op
OverheadActual  16: 1048576 op, 2721947.00 ns, 2.5959 ns/op
OverheadActual  17: 1048576 op, 2705252.00 ns, 2.5799 ns/op
OverheadActual  18: 1048576 op, 3161008.00 ns, 3.0146 ns/op
OverheadActual  19: 1048576 op, 3008922.00 ns, 2.8695 ns/op
OverheadActual  20: 1048576 op, 2704968.00 ns, 2.5797 ns/op

WorkloadWarmup   1: 1048576 op, 892609233.00 ns, 851.2585 ns/op
WorkloadWarmup   2: 1048576 op, 832412620.00 ns, 793.8505 ns/op
WorkloadWarmup   3: 1048576 op, 1049595686.00 ns, 1.0010 us/op
WorkloadWarmup   4: 1048576 op, 1105420127.00 ns, 1.0542 us/op
WorkloadWarmup   5: 1048576 op, 907153069.00 ns, 865.1286 ns/op
WorkloadWarmup   6: 1048576 op, 1080782757.00 ns, 1.0307 us/op
WorkloadWarmup   7: 1048576 op, 951996231.00 ns, 907.8944 ns/op

// BeforeActualRun
WorkloadActual   1: 1048576 op, 798191815.00 ns, 761.2150 ns/op
WorkloadActual   2: 1048576 op, 785876709.00 ns, 749.4704 ns/op
WorkloadActual   3: 1048576 op, 776581718.00 ns, 740.6060 ns/op
WorkloadActual   4: 1048576 op, 769513493.00 ns, 733.8653 ns/op
WorkloadActual   5: 1048576 op, 762626454.00 ns, 727.2973 ns/op
WorkloadActual   6: 1048576 op, 791949556.00 ns, 755.2620 ns/op
WorkloadActual   7: 1048576 op, 826821519.00 ns, 788.5184 ns/op
WorkloadActual   8: 1048576 op, 815835391.00 ns, 778.0413 ns/op
WorkloadActual   9: 1048576 op, 785251284.00 ns, 748.8740 ns/op
WorkloadActual  10: 1048576 op, 805294528.00 ns, 767.9887 ns/op
WorkloadActual  11: 1048576 op, 801713973.00 ns, 764.5740 ns/op
WorkloadActual  12: 1048576 op, 766682061.00 ns, 731.1650 ns/op
WorkloadActual  13: 1048576 op, 769192871.00 ns, 733.5595 ns/op
WorkloadActual  14: 1048576 op, 1025946187.00 ns, 978.4185 ns/op
WorkloadActual  15: 1048576 op, 761168964.00 ns, 725.9073 ns/op
WorkloadActual  16: 1048576 op, 775309996.00 ns, 739.3932 ns/op
WorkloadActual  17: 1048576 op, 922152441.00 ns, 879.4331 ns/op
WorkloadActual  18: 1048576 op, 766844280.00 ns, 731.3197 ns/op
WorkloadActual  19: 1048576 op, 762005793.00 ns, 726.7054 ns/op
WorkloadActual  20: 1048576 op, 761539987.00 ns, 726.2611 ns/op
WorkloadActual  21: 1048576 op, 760697674.00 ns, 725.4578 ns/op
WorkloadActual  22: 1048576 op, 757848949.00 ns, 722.7411 ns/op
WorkloadActual  23: 1048576 op, 756203010.00 ns, 721.1714 ns/op
WorkloadActual  24: 1048576 op, 763652352.00 ns, 728.2756 ns/op
WorkloadActual  25: 1048576 op, 756471716.00 ns, 721.4276 ns/op
WorkloadActual  26: 1048576 op, 757331010.00 ns, 722.2471 ns/op
WorkloadActual  27: 1048576 op, 763447886.00 ns, 728.0806 ns/op

// AfterActualRun
WorkloadResult   1: 1048576 op, 795478587.00 ns, 758.6275 ns/op
WorkloadResult   2: 1048576 op, 783163481.00 ns, 746.8829 ns/op
WorkloadResult   3: 1048576 op, 773868490.00 ns, 738.0185 ns/op
WorkloadResult   4: 1048576 op, 766800265.00 ns, 731.2777 ns/op
WorkloadResult   5: 1048576 op, 759913226.00 ns, 724.7097 ns/op
WorkloadResult   6: 1048576 op, 789236328.00 ns, 752.6744 ns/op
WorkloadResult   7: 1048576 op, 824108291.00 ns, 785.9309 ns/op
WorkloadResult   8: 1048576 op, 813122163.00 ns, 775.4537 ns/op
WorkloadResult   9: 1048576 op, 782538056.00 ns, 746.2864 ns/op
WorkloadResult  10: 1048576 op, 802581300.00 ns, 765.4012 ns/op
WorkloadResult  11: 1048576 op, 799000745.00 ns, 761.9865 ns/op
WorkloadResult  12: 1048576 op, 763968833.00 ns, 728.5775 ns/op
WorkloadResult  13: 1048576 op, 766479643.00 ns, 730.9719 ns/op
WorkloadResult  14: 1048576 op, 758455736.00 ns, 723.3198 ns/op
WorkloadResult  15: 1048576 op, 772596768.00 ns, 736.8057 ns/op
WorkloadResult  16: 1048576 op, 764131052.00 ns, 728.7322 ns/op
WorkloadResult  17: 1048576 op, 759292565.00 ns, 724.1178 ns/op
WorkloadResult  18: 1048576 op, 758826759.00 ns, 723.6736 ns/op
WorkloadResult  19: 1048576 op, 757984446.00 ns, 722.8703 ns/op
WorkloadResult  20: 1048576 op, 755135721.00 ns, 720.1535 ns/op
WorkloadResult  21: 1048576 op, 753489782.00 ns, 718.5839 ns/op
WorkloadResult  22: 1048576 op, 760939124.00 ns, 725.6881 ns/op
WorkloadResult  23: 1048576 op, 753758488.00 ns, 718.8401 ns/op
WorkloadResult  24: 1048576 op, 754617782.00 ns, 719.6596 ns/op
WorkloadResult  25: 1048576 op, 760734658.00 ns, 725.4931 ns/op
GC:  8 0 0 41943856 1048576
Threading:  0 0 1048576

// AfterAll
// Benchmark Process 22012 has exited with code 0.

Mean = 737.389 ns, StdErr = 3.830 ns (0.52%), N = 25, StdDev = 19.151 ns
Min = 718.584 ns, Q1 = 723.674 ns, Median = 728.732 ns, Q3 = 746.883 ns, Max = 785.931 ns
IQR = 23.209 ns, LowerFence = 688.860 ns, UpperFence = 781.697 ns
ConfidenceInterval = [723.044 ns; 751.735 ns] (CI 99.9%), Margin = 14.345 ns (1.95% of Mean)
Skewness = 1.02, Kurtosis = 2.84, MValue = 2

// ** Remained 4 (50.0 %) benchmark(s) to run. Estimated finish 2022-10-03 14:13 (0h 1m from now) **
// **************************
// Benchmark: LinqPerformance.List_Min: net70(Runtime=.NET 7.0)
// *** Execute ***
// Launch: 1 / 1
// Execute: dotnet c0b5ef73-3dde-4044-8b19-03b03142c60e.dll --benchmarkName net._7.performance.LinqPerformance.List_Min --job net70 --benchmarkId 0 in /Users/frank.hsu/Documents/Projects/Test/net.7.performance/src/bin/Release/net6.0/c0b5ef73-3dde-4044-8b19-03b03142c60e/bin/Release/net7.0
Failed to set up high priority. Make sure you have the right permissions. Message: Permission denied
// BeforeAnythingElse

// Benchmark Process Environment Information:
// Runtime=.NET 7.0.0 (7.0.22.42610), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: net70

OverheadJitting  1: 1 op, 445473.00 ns, 445.4730 us/op
WorkloadJitting  1: 1 op, 2202685.00 ns, 2.2027 ms/op

OverheadJitting  2: 16 op, 512797.00 ns, 32.0498 us/op
WorkloadJitting  2: 16 op, 544397.00 ns, 34.0248 us/op

WorkloadPilot    1: 16 op, 17561.00 ns, 1.0976 us/op
WorkloadPilot    2: 32 op, 29075.00 ns, 908.5938 ns/op
WorkloadPilot    3: 64 op, 53822.00 ns, 840.9688 ns/op
WorkloadPilot    4: 128 op, 105339.00 ns, 822.9609 ns/op
WorkloadPilot    5: 256 op, 209619.00 ns, 818.8242 ns/op
WorkloadPilot    6: 512 op, 410060.00 ns, 800.8984 ns/op
WorkloadPilot    7: 1024 op, 832112.00 ns, 812.6094 ns/op
WorkloadPilot    8: 2048 op, 1665314.00 ns, 813.1416 ns/op
WorkloadPilot    9: 4096 op, 3156039.00 ns, 770.5173 ns/op
WorkloadPilot   10: 8192 op, 5839138.00 ns, 712.7854 ns/op
WorkloadPilot   11: 16384 op, 11289045.00 ns, 689.0286 ns/op
WorkloadPilot   12: 32768 op, 23005461.00 ns, 702.0710 ns/op
WorkloadPilot   13: 65536 op, 46512766.00 ns, 709.7285 ns/op
WorkloadPilot   14: 131072 op, 92143423.00 ns, 702.9985 ns/op
WorkloadPilot   15: 262144 op, 18241887.00 ns, 69.5873 ns/op
WorkloadPilot   16: 524288 op, 9693758.00 ns, 18.4894 ns/op
WorkloadPilot   17: 1048576 op, 19565304.00 ns, 18.6589 ns/op
WorkloadPilot   18: 2097152 op, 39310705.00 ns, 18.7448 ns/op
WorkloadPilot   19: 4194304 op, 78432065.00 ns, 18.6997 ns/op
WorkloadPilot   20: 8388608 op, 155824411.00 ns, 18.5757 ns/op
WorkloadPilot   21: 16777216 op, 313273763.00 ns, 18.6726 ns/op
WorkloadPilot   22: 33554432 op, 625972662.00 ns, 18.6554 ns/op

OverheadWarmup   1: 33554432 op, 72497650.00 ns, 2.1606 ns/op
OverheadWarmup   2: 33554432 op, 72977253.00 ns, 2.1749 ns/op
OverheadWarmup   3: 33554432 op, 67601304.00 ns, 2.0147 ns/op
OverheadWarmup   4: 33554432 op, 55369074.00 ns, 1.6501 ns/op
OverheadWarmup   5: 33554432 op, 55114572.00 ns, 1.6425 ns/op
OverheadWarmup   6: 33554432 op, 55170506.00 ns, 1.6442 ns/op
OverheadWarmup   7: 33554432 op, 55069789.00 ns, 1.6412 ns/op

OverheadActual   1: 33554432 op, 55152590.00 ns, 1.6437 ns/op
OverheadActual   2: 33554432 op, 55035787.00 ns, 1.6402 ns/op
OverheadActual   3: 33554432 op, 55081774.00 ns, 1.6416 ns/op
OverheadActual   4: 33554432 op, 55229860.00 ns, 1.6460 ns/op
OverheadActual   5: 33554432 op, 55241066.00 ns, 1.6463 ns/op
OverheadActual   6: 33554432 op, 55076885.00 ns, 1.6414 ns/op
OverheadActual   7: 33554432 op, 56433575.00 ns, 1.6819 ns/op
OverheadActual   8: 33554432 op, 55185747.00 ns, 1.6447 ns/op
OverheadActual   9: 33554432 op, 55084183.00 ns, 1.6416 ns/op
OverheadActual  10: 33554432 op, 55156018.00 ns, 1.6438 ns/op
OverheadActual  11: 33554432 op, 55218258.00 ns, 1.6456 ns/op
OverheadActual  12: 33554432 op, 55138292.00 ns, 1.6432 ns/op
OverheadActual  13: 33554432 op, 56661822.00 ns, 1.6887 ns/op
OverheadActual  14: 33554432 op, 55374035.00 ns, 1.6503 ns/op
OverheadActual  15: 33554432 op, 55305025.00 ns, 1.6482 ns/op

WorkloadWarmup   1: 33554432 op, 627012224.00 ns, 18.6864 ns/op
WorkloadWarmup   2: 33554432 op, 628149298.00 ns, 18.7203 ns/op
WorkloadWarmup   3: 33554432 op, 626047560.00 ns, 18.6577 ns/op
WorkloadWarmup   4: 33554432 op, 626316844.00 ns, 18.6657 ns/op
WorkloadWarmup   5: 33554432 op, 626823857.00 ns, 18.6808 ns/op
WorkloadWarmup   6: 33554432 op, 622808896.00 ns, 18.5612 ns/op

// BeforeActualRun
WorkloadActual   1: 33554432 op, 627394404.00 ns, 18.6978 ns/op
WorkloadActual   2: 33554432 op, 624484625.00 ns, 18.6111 ns/op
WorkloadActual   3: 33554432 op, 625596734.00 ns, 18.6442 ns/op
WorkloadActual   4: 33554432 op, 632112724.00 ns, 18.8384 ns/op
WorkloadActual   5: 33554432 op, 624112092.00 ns, 18.6000 ns/op
WorkloadActual   6: 33554432 op, 624493855.00 ns, 18.6114 ns/op
WorkloadActual   7: 33554432 op, 622939969.00 ns, 18.5651 ns/op
WorkloadActual   8: 33554432 op, 624644882.00 ns, 18.6159 ns/op
WorkloadActual   9: 33554432 op, 621560318.00 ns, 18.5239 ns/op
WorkloadActual  10: 33554432 op, 621566944.00 ns, 18.5241 ns/op
WorkloadActual  11: 33554432 op, 628293970.00 ns, 18.7246 ns/op
WorkloadActual  12: 33554432 op, 629831932.00 ns, 18.7705 ns/op
WorkloadActual  13: 33554432 op, 624396859.00 ns, 18.6085 ns/op
WorkloadActual  14: 33554432 op, 644991132.00 ns, 19.2222 ns/op
WorkloadActual  15: 33554432 op, 623201707.00 ns, 18.5729 ns/op

// AfterActualRun
WorkloadResult   1: 33554432 op, 572208657.00 ns, 17.0531 ns/op
WorkloadResult   2: 33554432 op, 569298878.00 ns, 16.9664 ns/op
WorkloadResult   3: 33554432 op, 570410987.00 ns, 16.9996 ns/op
WorkloadResult   4: 33554432 op, 576926977.00 ns, 17.1938 ns/op
WorkloadResult   5: 33554432 op, 568926345.00 ns, 16.9553 ns/op
WorkloadResult   6: 33554432 op, 569308108.00 ns, 16.9667 ns/op
WorkloadResult   7: 33554432 op, 567754222.00 ns, 16.9204 ns/op
WorkloadResult   8: 33554432 op, 569459135.00 ns, 16.9712 ns/op
WorkloadResult   9: 33554432 op, 566374571.00 ns, 16.8793 ns/op
WorkloadResult  10: 33554432 op, 566381197.00 ns, 16.8795 ns/op
WorkloadResult  11: 33554432 op, 573108223.00 ns, 17.0800 ns/op
WorkloadResult  12: 33554432 op, 574646185.00 ns, 17.1258 ns/op
WorkloadResult  13: 33554432 op, 569211112.00 ns, 16.9638 ns/op
WorkloadResult  14: 33554432 op, 568015960.00 ns, 16.9282 ns/op
GC:  0 0 0 816 33554432
Threading:  0 0 33554432

// AfterAll
// Benchmark Process 22099 has exited with code 0.

Mean = 16.992 ns, StdErr = 0.024 ns (0.14%), N = 14, StdDev = 0.091 ns
Min = 16.879 ns, Q1 = 16.935 ns, Median = 16.967 ns, Q3 = 17.040 ns, Max = 17.194 ns
IQR = 0.105 ns, LowerFence = 16.778 ns, UpperFence = 17.197 ns
ConfidenceInterval = [16.889 ns; 17.095 ns] (CI 99.9%), Margin = 0.103 ns (0.61% of Mean)
Skewness = 0.75, Kurtosis = 2.49, MValue = 2

// ** Remained 3 (37.5 %) benchmark(s) to run. Estimated finish 2022-10-03 14:13 (0h 1m from now) **
// **************************
// Benchmark: LinqPerformance.List_Max: net70(Runtime=.NET 7.0)
// *** Execute ***
// Launch: 1 / 1
// Execute: dotnet c0b5ef73-3dde-4044-8b19-03b03142c60e.dll --benchmarkName net._7.performance.LinqPerformance.List_Max --job net70 --benchmarkId 1 in /Users/frank.hsu/Documents/Projects/Test/net.7.performance/src/bin/Release/net6.0/c0b5ef73-3dde-4044-8b19-03b03142c60e/bin/Release/net7.0
Failed to set up high priority. Make sure you have the right permissions. Message: Permission denied
// BeforeAnythingElse

// Benchmark Process Environment Information:
// Runtime=.NET 7.0.0 (7.0.22.42610), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: net70

OverheadJitting  1: 1 op, 430814.00 ns, 430.8140 us/op
WorkloadJitting  1: 1 op, 2067297.00 ns, 2.0673 ms/op

OverheadJitting  2: 16 op, 484417.00 ns, 30.2761 us/op
WorkloadJitting  2: 16 op, 460202.00 ns, 28.7626 us/op

WorkloadPilot    1: 16 op, 13962.00 ns, 872.6250 ns/op
WorkloadPilot    2: 32 op, 24266.00 ns, 758.3125 ns/op
WorkloadPilot    3: 64 op, 45980.00 ns, 718.4375 ns/op
WorkloadPilot    4: 128 op, 90710.00 ns, 708.6719 ns/op
WorkloadPilot    5: 256 op, 190804.00 ns, 745.3281 ns/op
WorkloadPilot    6: 512 op, 352184.00 ns, 687.8594 ns/op
WorkloadPilot    7: 1024 op, 700522.00 ns, 684.1035 ns/op
WorkloadPilot    8: 2048 op, 1415307.00 ns, 691.0679 ns/op
WorkloadPilot    9: 4096 op, 2789396.00 ns, 681.0049 ns/op
WorkloadPilot   10: 8192 op, 5754834.00 ns, 702.4944 ns/op
WorkloadPilot   11: 16384 op, 11264369.00 ns, 687.5225 ns/op
WorkloadPilot   12: 32768 op, 23577976.00 ns, 719.5427 ns/op
WorkloadPilot   13: 65536 op, 47129536.00 ns, 719.1396 ns/op
WorkloadPilot   14: 131072 op, 38283661.00 ns, 292.0812 ns/op
WorkloadPilot   15: 262144 op, 4683696.00 ns, 17.8669 ns/op
WorkloadPilot   16: 524288 op, 9452754.00 ns, 18.0297 ns/op
WorkloadPilot   17: 1048576 op, 18725210.00 ns, 17.8578 ns/op
WorkloadPilot   18: 2097152 op, 38327686.00 ns, 18.2761 ns/op
WorkloadPilot   19: 4194304 op, 75938954.00 ns, 18.1053 ns/op
WorkloadPilot   20: 8388608 op, 151205732.00 ns, 18.0251 ns/op
WorkloadPilot   21: 16777216 op, 301403918.00 ns, 17.9651 ns/op
WorkloadPilot   22: 33554432 op, 607767601.00 ns, 18.1129 ns/op

OverheadWarmup   1: 33554432 op, 78196256.00 ns, 2.3304 ns/op
OverheadWarmup   2: 33554432 op, 73828264.00 ns, 2.2003 ns/op
OverheadWarmup   3: 33554432 op, 66967302.00 ns, 1.9958 ns/op
OverheadWarmup   4: 33554432 op, 55146604.00 ns, 1.6435 ns/op
OverheadWarmup   5: 33554432 op, 55839714.00 ns, 1.6642 ns/op
OverheadWarmup   6: 33554432 op, 55204526.00 ns, 1.6452 ns/op
OverheadWarmup   7: 33554432 op, 55163971.00 ns, 1.6440 ns/op
OverheadWarmup   8: 33554432 op, 56614463.00 ns, 1.6872 ns/op
OverheadWarmup   9: 33554432 op, 56918593.00 ns, 1.6963 ns/op
OverheadWarmup  10: 33554432 op, 56218703.00 ns, 1.6754 ns/op

OverheadActual   1: 33554432 op, 55952350.00 ns, 1.6675 ns/op
OverheadActual   2: 33554432 op, 55372204.00 ns, 1.6502 ns/op
OverheadActual   3: 33554432 op, 56264405.00 ns, 1.6768 ns/op
OverheadActual   4: 33554432 op, 56119455.00 ns, 1.6725 ns/op
OverheadActual   5: 33554432 op, 55363111.00 ns, 1.6499 ns/op
OverheadActual   6: 33554432 op, 55188520.00 ns, 1.6447 ns/op
OverheadActual   7: 33554432 op, 55598242.00 ns, 1.6570 ns/op
OverheadActual   8: 33554432 op, 57234442.00 ns, 1.7057 ns/op
OverheadActual   9: 33554432 op, 56058766.00 ns, 1.6707 ns/op
OverheadActual  10: 33554432 op, 56177325.00 ns, 1.6742 ns/op
OverheadActual  11: 33554432 op, 56128563.00 ns, 1.6728 ns/op
OverheadActual  12: 33554432 op, 55323325.00 ns, 1.6488 ns/op
OverheadActual  13: 33554432 op, 55457524.00 ns, 1.6528 ns/op
OverheadActual  14: 33554432 op, 55785815.00 ns, 1.6625 ns/op
OverheadActual  15: 33554432 op, 56642392.00 ns, 1.6881 ns/op

WorkloadWarmup   1: 33554432 op, 622155656.00 ns, 18.5417 ns/op
WorkloadWarmup   2: 33554432 op, 709270658.00 ns, 21.1379 ns/op
WorkloadWarmup   3: 33554432 op, 707383544.00 ns, 21.0817 ns/op
WorkloadWarmup   4: 33554432 op, 646320567.00 ns, 19.2619 ns/op
WorkloadWarmup   5: 33554432 op, 645854066.00 ns, 19.2480 ns/op
WorkloadWarmup   6: 33554432 op, 624210433.00 ns, 18.6029 ns/op
WorkloadWarmup   7: 33554432 op, 655288223.00 ns, 19.5291 ns/op
WorkloadWarmup   8: 33554432 op, 639835160.00 ns, 19.0686 ns/op

// BeforeActualRun
WorkloadActual   1: 33554432 op, 619184512.00 ns, 18.4531 ns/op
WorkloadActual   2: 33554432 op, 652910210.00 ns, 19.4582 ns/op
WorkloadActual   3: 33554432 op, 625321650.00 ns, 18.6360 ns/op
WorkloadActual   4: 33554432 op, 626330544.00 ns, 18.6661 ns/op
WorkloadActual   5: 33554432 op, 632268521.00 ns, 18.8431 ns/op
WorkloadActual   6: 33554432 op, 630049264.00 ns, 18.7769 ns/op
WorkloadActual   7: 33554432 op, 665515496.00 ns, 19.8339 ns/op
WorkloadActual   8: 33554432 op, 632282629.00 ns, 18.8435 ns/op
WorkloadActual   9: 33554432 op, 618786371.00 ns, 18.4413 ns/op
WorkloadActual  10: 33554432 op, 621296972.00 ns, 18.5161 ns/op
WorkloadActual  11: 33554432 op, 620585580.00 ns, 18.4949 ns/op
WorkloadActual  12: 33554432 op, 626277823.00 ns, 18.6645 ns/op
WorkloadActual  13: 33554432 op, 628756365.00 ns, 18.7384 ns/op
WorkloadActual  14: 33554432 op, 619306181.00 ns, 18.4568 ns/op
WorkloadActual  15: 33554432 op, 642043584.00 ns, 19.1344 ns/op

// AfterActualRun
WorkloadResult   1: 33554432 op, 563232162.00 ns, 16.7856 ns/op
WorkloadResult   2: 33554432 op, 569369300.00 ns, 16.9685 ns/op
WorkloadResult   3: 33554432 op, 570378194.00 ns, 16.9986 ns/op
WorkloadResult   4: 33554432 op, 576316171.00 ns, 17.1756 ns/op
WorkloadResult   5: 33554432 op, 574096914.00 ns, 17.1094 ns/op
WorkloadResult   6: 33554432 op, 576330279.00 ns, 17.1760 ns/op
WorkloadResult   7: 33554432 op, 562834021.00 ns, 16.7738 ns/op
WorkloadResult   8: 33554432 op, 565344622.00 ns, 16.8486 ns/op
WorkloadResult   9: 33554432 op, 564633230.00 ns, 16.8274 ns/op
WorkloadResult  10: 33554432 op, 570325473.00 ns, 16.9970 ns/op
WorkloadResult  11: 33554432 op, 572804015.00 ns, 17.0709 ns/op
WorkloadResult  12: 33554432 op, 563353831.00 ns, 16.7893 ns/op
WorkloadResult  13: 33554432 op, 586091234.00 ns, 17.4669 ns/op
GC:  0 0 0 816 33554432
Threading:  0 0 33554432

// AfterAll
// Benchmark Process 22130 has exited with code 0.

Mean = 16.999 ns, StdErr = 0.056 ns (0.33%), N = 13, StdDev = 0.202 ns
Min = 16.774 ns, Q1 = 16.827 ns, Median = 16.997 ns, Q3 = 17.109 ns, Max = 17.467 ns
IQR = 0.282 ns, LowerFence = 16.404 ns, UpperFence = 17.532 ns
ConfidenceInterval = [16.757 ns; 17.242 ns] (CI 99.9%), Margin = 0.242 ns (1.43% of Mean)
Skewness = 0.71, Kurtosis = 2.65, MValue = 2

// ** Remained 2 (25.0 %) benchmark(s) to run. Estimated finish 2022-10-03 14:13 (0h 0m from now) **
// **************************
// Benchmark: LinqPerformance.List_Average: net70(Runtime=.NET 7.0)
// *** Execute ***
// Launch: 1 / 1
// Execute: dotnet c0b5ef73-3dde-4044-8b19-03b03142c60e.dll --benchmarkName net._7.performance.LinqPerformance.List_Average --job net70 --benchmarkId 2 in /Users/frank.hsu/Documents/Projects/Test/net.7.performance/src/bin/Release/net6.0/c0b5ef73-3dde-4044-8b19-03b03142c60e/bin/Release/net7.0
Failed to set up high priority. Make sure you have the right permissions. Message: Permission denied
// BeforeAnythingElse

// Benchmark Process Environment Information:
// Runtime=.NET 7.0.0 (7.0.22.42610), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: net70

OverheadJitting  1: 1 op, 1151832.00 ns, 1.1518 ms/op
WorkloadJitting  1: 1 op, 3300627.00 ns, 3.3006 ms/op

OverheadJitting  2: 16 op, 604659.00 ns, 37.7912 us/op
WorkloadJitting  2: 16 op, 599782.00 ns, 37.4864 us/op

WorkloadPilot    1: 16 op, 20284.00 ns, 1.2677 us/op
WorkloadPilot    2: 32 op, 36203.00 ns, 1.1313 us/op
WorkloadPilot    3: 64 op, 68583.00 ns, 1.0716 us/op
WorkloadPilot    4: 128 op, 125991.00 ns, 984.3047 ns/op
WorkloadPilot    5: 256 op, 247373.00 ns, 966.3008 ns/op
WorkloadPilot    6: 512 op, 537075.00 ns, 1.0490 us/op
WorkloadPilot    7: 1024 op, 989773.00 ns, 966.5752 ns/op
WorkloadPilot    8: 2048 op, 2128537.00 ns, 1.0393 us/op
WorkloadPilot    9: 4096 op, 3935531.00 ns, 960.8230 ns/op
WorkloadPilot   10: 8192 op, 8477627.00 ns, 1.0349 us/op
WorkloadPilot   11: 16384 op, 15915562.00 ns, 971.4088 ns/op
WorkloadPilot   12: 32768 op, 32440510.00 ns, 990.0058 ns/op
WorkloadPilot   13: 65536 op, 65854698.00 ns, 1.0049 us/op
WorkloadPilot   14: 131072 op, 92809219.00 ns, 708.0781 ns/op
WorkloadPilot   15: 262144 op, 7638357.00 ns, 29.1380 ns/op
WorkloadPilot   16: 524288 op, 17598455.00 ns, 33.5664 ns/op
WorkloadPilot   17: 1048576 op, 34941908.00 ns, 33.3232 ns/op
WorkloadPilot   18: 2097152 op, 59610815.00 ns, 28.4247 ns/op
WorkloadPilot   19: 4194304 op, 128202084.00 ns, 30.5658 ns/op
WorkloadPilot   20: 8388608 op, 233210095.00 ns, 27.8008 ns/op
WorkloadPilot   21: 16777216 op, 470838857.00 ns, 28.0642 ns/op
WorkloadPilot   22: 33554432 op, 937713388.00 ns, 27.9460 ns/op

OverheadWarmup   1: 33554432 op, 81195747.00 ns, 2.4198 ns/op
OverheadWarmup   2: 33554432 op, 80953241.00 ns, 2.4126 ns/op
OverheadWarmup   3: 33554432 op, 66457059.00 ns, 1.9806 ns/op
OverheadWarmup   4: 33554432 op, 55915356.00 ns, 1.6664 ns/op
OverheadWarmup   5: 33554432 op, 55653338.00 ns, 1.6586 ns/op
OverheadWarmup   6: 33554432 op, 55474926.00 ns, 1.6533 ns/op
OverheadWarmup   7: 33554432 op, 55199787.00 ns, 1.6451 ns/op
OverheadWarmup   8: 33554432 op, 55693579.00 ns, 1.6598 ns/op
OverheadWarmup   9: 33554432 op, 55079627.00 ns, 1.6415 ns/op
OverheadWarmup  10: 33554432 op, 55358784.00 ns, 1.6498 ns/op

OverheadActual   1: 33554432 op, 55631758.00 ns, 1.6580 ns/op
OverheadActual   2: 33554432 op, 56082376.00 ns, 1.6714 ns/op
OverheadActual   3: 33554432 op, 55596036.00 ns, 1.6569 ns/op
OverheadActual   4: 33554432 op, 56629618.00 ns, 1.6877 ns/op
OverheadActual   5: 33554432 op, 56128364.00 ns, 1.6728 ns/op
OverheadActual   6: 33554432 op, 55228788.00 ns, 1.6459 ns/op
OverheadActual   7: 33554432 op, 55760700.00 ns, 1.6618 ns/op
OverheadActual   8: 33554432 op, 55438997.00 ns, 1.6522 ns/op
OverheadActual   9: 33554432 op, 55488928.00 ns, 1.6537 ns/op
OverheadActual  10: 33554432 op, 56682057.00 ns, 1.6893 ns/op
OverheadActual  11: 33554432 op, 55444891.00 ns, 1.6524 ns/op
OverheadActual  12: 33554432 op, 55579209.00 ns, 1.6564 ns/op
OverheadActual  13: 33554432 op, 56079005.00 ns, 1.6713 ns/op
OverheadActual  14: 33554432 op, 59387700.00 ns, 1.7699 ns/op
OverheadActual  15: 33554432 op, 55429233.00 ns, 1.6519 ns/op

WorkloadWarmup   1: 33554432 op, 945688644.00 ns, 28.1837 ns/op
WorkloadWarmup   2: 33554432 op, 935070043.00 ns, 27.8673 ns/op
WorkloadWarmup   3: 33554432 op, 940222344.00 ns, 28.0208 ns/op
WorkloadWarmup   4: 33554432 op, 940108913.00 ns, 28.0174 ns/op
WorkloadWarmup   5: 33554432 op, 933461121.00 ns, 27.8193 ns/op
WorkloadWarmup   6: 33554432 op, 954487665.00 ns, 28.4459 ns/op
WorkloadWarmup   7: 33554432 op, 971084130.00 ns, 28.9406 ns/op
WorkloadWarmup   8: 33554432 op, 956033436.00 ns, 28.4920 ns/op

// BeforeActualRun
WorkloadActual   1: 33554432 op, 972098595.00 ns, 28.9708 ns/op
WorkloadActual   2: 33554432 op, 971559497.00 ns, 28.9547 ns/op
WorkloadActual   3: 33554432 op, 948591395.00 ns, 28.2702 ns/op
WorkloadActual   4: 33554432 op, 933328042.00 ns, 27.8153 ns/op
WorkloadActual   5: 33554432 op, 929401709.00 ns, 27.6983 ns/op
WorkloadActual   6: 33554432 op, 931481291.00 ns, 27.7603 ns/op
WorkloadActual   7: 33554432 op, 932639274.00 ns, 27.7948 ns/op
WorkloadActual   8: 33554432 op, 971420279.00 ns, 28.9506 ns/op
WorkloadActual   9: 33554432 op, 980496993.00 ns, 29.2211 ns/op
WorkloadActual  10: 33554432 op, 985989143.00 ns, 29.3848 ns/op
WorkloadActual  11: 33554432 op, 933181267.00 ns, 27.8110 ns/op
WorkloadActual  12: 33554432 op, 932361759.00 ns, 27.7865 ns/op
WorkloadActual  13: 33554432 op, 946173951.00 ns, 28.1982 ns/op
WorkloadActual  14: 33554432 op, 934493626.00 ns, 27.8501 ns/op
WorkloadActual  15: 33554432 op, 935827661.00 ns, 27.8898 ns/op
WorkloadActual  16: 33554432 op, 931398934.00 ns, 27.7579 ns/op
WorkloadActual  17: 33554432 op, 932792655.00 ns, 27.7994 ns/op
WorkloadActual  18: 33554432 op, 933905689.00 ns, 27.8326 ns/op

// AfterActualRun
WorkloadResult   1: 33554432 op, 916466837.00 ns, 27.3128 ns/op
WorkloadResult   2: 33554432 op, 915927739.00 ns, 27.2968 ns/op
WorkloadResult   3: 33554432 op, 892959637.00 ns, 26.6123 ns/op
WorkloadResult   4: 33554432 op, 877696284.00 ns, 26.1574 ns/op
WorkloadResult   5: 33554432 op, 873769951.00 ns, 26.0404 ns/op
WorkloadResult   6: 33554432 op, 875849533.00 ns, 26.1024 ns/op
WorkloadResult   7: 33554432 op, 877007516.00 ns, 26.1369 ns/op
WorkloadResult   8: 33554432 op, 915788521.00 ns, 27.2926 ns/op
WorkloadResult   9: 33554432 op, 924865235.00 ns, 27.5631 ns/op
WorkloadResult  10: 33554432 op, 930357385.00 ns, 27.7268 ns/op
WorkloadResult  11: 33554432 op, 877549509.00 ns, 26.1530 ns/op
WorkloadResult  12: 33554432 op, 876730001.00 ns, 26.1286 ns/op
WorkloadResult  13: 33554432 op, 890542193.00 ns, 26.5402 ns/op
WorkloadResult  14: 33554432 op, 878861868.00 ns, 26.1921 ns/op
WorkloadResult  15: 33554432 op, 880195903.00 ns, 26.2319 ns/op
WorkloadResult  16: 33554432 op, 875767176.00 ns, 26.0999 ns/op
WorkloadResult  17: 33554432 op, 877160897.00 ns, 26.1414 ns/op
WorkloadResult  18: 33554432 op, 878273931.00 ns, 26.1746 ns/op
GC:  0 0 0 816 33554432
Threading:  0 0 33554432

// AfterAll
// Benchmark Process 22174 has exited with code 0.

Mean = 26.550 ns, StdErr = 0.140 ns (0.53%), N = 18, StdDev = 0.592 ns
Min = 26.040 ns, Q1 = 26.138 ns, Median = 26.183 ns, Q3 = 27.123 ns, Max = 27.727 ns
IQR = 0.985 ns, LowerFence = 24.661 ns, UpperFence = 28.599 ns
ConfidenceInterval = [25.997 ns; 27.104 ns] (CI 99.9%), Margin = 0.554 ns (2.09% of Mean)
Skewness = 0.84, Kurtosis = 1.92, MValue = 2.77

// ** Remained 1 (12.5 %) benchmark(s) to run. Estimated finish 2022-10-03 14:13 (0h 0m from now) **
// **************************
// Benchmark: LinqPerformance.List_Sum: net70(Runtime=.NET 7.0)
// *** Execute ***
// Launch: 1 / 1
// Execute: dotnet c0b5ef73-3dde-4044-8b19-03b03142c60e.dll --benchmarkName net._7.performance.LinqPerformance.List_Sum --job net70 --benchmarkId 3 in /Users/frank.hsu/Documents/Projects/Test/net.7.performance/src/bin/Release/net6.0/c0b5ef73-3dde-4044-8b19-03b03142c60e/bin/Release/net7.0
Failed to set up high priority. Make sure you have the right permissions. Message: Permission denied
// BeforeAnythingElse

// Benchmark Process Environment Information:
// Runtime=.NET 7.0.0 (7.0.22.42610), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: net70

OverheadJitting  1: 1 op, 364134.00 ns, 364.1340 us/op
WorkloadJitting  1: 1 op, 1563758.00 ns, 1.5638 ms/op

OverheadJitting  2: 16 op, 545197.00 ns, 34.0748 us/op
WorkloadJitting  2: 16 op, 487358.00 ns, 30.4599 us/op

WorkloadPilot    1: 16 op, 10788.00 ns, 674.2500 ns/op
WorkloadPilot    2: 32 op, 19458.00 ns, 608.0625 ns/op
WorkloadPilot    3: 64 op, 37778.00 ns, 590.2812 ns/op
WorkloadPilot    4: 128 op, 71265.00 ns, 556.7578 ns/op
WorkloadPilot    5: 256 op, 146163.00 ns, 570.9492 ns/op
WorkloadPilot    6: 512 op, 280243.00 ns, 547.3496 ns/op
WorkloadPilot    7: 1024 op, 605839.00 ns, 591.6396 ns/op
WorkloadPilot    8: 2048 op, 1202088.00 ns, 586.9570 ns/op
WorkloadPilot    9: 4096 op, 2339918.00 ns, 571.2690 ns/op
WorkloadPilot   10: 8192 op, 4650672.00 ns, 567.7090 ns/op
WorkloadPilot   11: 16384 op, 9382611.00 ns, 572.6691 ns/op
WorkloadPilot   12: 32768 op, 19088158.00 ns, 582.5244 ns/op
WorkloadPilot   13: 65536 op, 37453030.00 ns, 571.4879 ns/op
WorkloadPilot   14: 131072 op, 75801622.00 ns, 578.3205 ns/op
WorkloadPilot   15: 262144 op, 82599193.00 ns, 315.0909 ns/op
WorkloadPilot   16: 524288 op, 25648357.00 ns, 48.9204 ns/op
WorkloadPilot   17: 1048576 op, 50852724.00 ns, 48.4969 ns/op
WorkloadPilot   18: 2097152 op, 101751637.00 ns, 48.5190 ns/op
WorkloadPilot   19: 4194304 op, 205613152.00 ns, 49.0220 ns/op
WorkloadPilot   20: 8388608 op, 407893341.00 ns, 48.6247 ns/op
WorkloadPilot   21: 16777216 op, 812311563.00 ns, 48.4175 ns/op

OverheadWarmup   1: 16777216 op, 36437541.00 ns, 2.1718 ns/op
OverheadWarmup   2: 16777216 op, 36475548.00 ns, 2.1741 ns/op
OverheadWarmup   3: 16777216 op, 36807867.00 ns, 2.1939 ns/op
OverheadWarmup   4: 16777216 op, 36827129.00 ns, 2.1951 ns/op
OverheadWarmup   5: 16777216 op, 35880806.00 ns, 2.1387 ns/op
OverheadWarmup   6: 16777216 op, 35969259.00 ns, 2.1439 ns/op
OverheadWarmup   7: 16777216 op, 36053352.00 ns, 2.1489 ns/op
OverheadWarmup   8: 16777216 op, 36079694.00 ns, 2.1505 ns/op
OverheadWarmup   9: 16777216 op, 29761091.00 ns, 1.7739 ns/op

OverheadActual   1: 16777216 op, 27420551.00 ns, 1.6344 ns/op
OverheadActual   2: 16777216 op, 27489628.00 ns, 1.6385 ns/op
OverheadActual   3: 16777216 op, 27410012.00 ns, 1.6338 ns/op
OverheadActual   4: 16777216 op, 27506465.00 ns, 1.6395 ns/op
OverheadActual   5: 16777216 op, 27274644.00 ns, 1.6257 ns/op
OverheadActual   6: 16777216 op, 27393432.00 ns, 1.6328 ns/op
OverheadActual   7: 16777216 op, 27357169.00 ns, 1.6306 ns/op
OverheadActual   8: 16777216 op, 29260922.00 ns, 1.7441 ns/op
OverheadActual   9: 16777216 op, 27502015.00 ns, 1.6392 ns/op
OverheadActual  10: 16777216 op, 27324125.00 ns, 1.6286 ns/op
OverheadActual  11: 16777216 op, 27429340.00 ns, 1.6349 ns/op
OverheadActual  12: 16777216 op, 27408625.00 ns, 1.6337 ns/op
OverheadActual  13: 16777216 op, 27434721.00 ns, 1.6352 ns/op
OverheadActual  14: 16777216 op, 27446120.00 ns, 1.6359 ns/op
OverheadActual  15: 16777216 op, 27429382.00 ns, 1.6349 ns/op

WorkloadWarmup   1: 16777216 op, 812029795.00 ns, 48.4007 ns/op
WorkloadWarmup   2: 16777216 op, 822760744.00 ns, 49.0404 ns/op
WorkloadWarmup   3: 16777216 op, 817569383.00 ns, 48.7309 ns/op
WorkloadWarmup   4: 16777216 op, 815334375.00 ns, 48.5977 ns/op
WorkloadWarmup   5: 16777216 op, 816170884.00 ns, 48.6476 ns/op
WorkloadWarmup   6: 16777216 op, 816450789.00 ns, 48.6643 ns/op
WorkloadWarmup   7: 16777216 op, 816934594.00 ns, 48.6931 ns/op
WorkloadWarmup   8: 16777216 op, 818537934.00 ns, 48.7887 ns/op
WorkloadWarmup   9: 16777216 op, 816498625.00 ns, 48.6671 ns/op

// BeforeActualRun
WorkloadActual   1: 16777216 op, 841798538.00 ns, 50.1751 ns/op
WorkloadActual   2: 16777216 op, 815413255.00 ns, 48.6024 ns/op
WorkloadActual   3: 16777216 op, 815043048.00 ns, 48.5804 ns/op
WorkloadActual   4: 16777216 op, 815715468.00 ns, 48.6204 ns/op
WorkloadActual   5: 16777216 op, 820889989.00 ns, 48.9289 ns/op
WorkloadActual   6: 16777216 op, 815988838.00 ns, 48.6367 ns/op
WorkloadActual   7: 16777216 op, 823868613.00 ns, 49.1064 ns/op
WorkloadActual   8: 16777216 op, 812553899.00 ns, 48.4320 ns/op
WorkloadActual   9: 16777216 op, 815690627.00 ns, 48.6190 ns/op
WorkloadActual  10: 16777216 op, 812526750.00 ns, 48.4304 ns/op
WorkloadActual  11: 16777216 op, 814475496.00 ns, 48.5465 ns/op
WorkloadActual  12: 16777216 op, 824055509.00 ns, 49.1175 ns/op
WorkloadActual  13: 16777216 op, 813312122.00 ns, 48.4772 ns/op
WorkloadActual  14: 16777216 op, 812594400.00 ns, 48.4344 ns/op
WorkloadActual  15: 16777216 op, 815499351.00 ns, 48.6075 ns/op

// AfterActualRun
WorkloadResult   1: 16777216 op, 787983915.00 ns, 46.9675 ns/op
WorkloadResult   2: 16777216 op, 787613708.00 ns, 46.9454 ns/op
WorkloadResult   3: 16777216 op, 788286128.00 ns, 46.9855 ns/op
WorkloadResult   4: 16777216 op, 793460649.00 ns, 47.2939 ns/op
WorkloadResult   5: 16777216 op, 788559498.00 ns, 47.0018 ns/op
WorkloadResult   6: 16777216 op, 796439273.00 ns, 47.4715 ns/op
WorkloadResult   7: 16777216 op, 785124559.00 ns, 46.7971 ns/op
WorkloadResult   8: 16777216 op, 788261287.00 ns, 46.9840 ns/op
WorkloadResult   9: 16777216 op, 785097410.00 ns, 46.7955 ns/op
WorkloadResult  10: 16777216 op, 787046156.00 ns, 46.9116 ns/op
WorkloadResult  11: 16777216 op, 796626169.00 ns, 47.4826 ns/op
WorkloadResult  12: 16777216 op, 785882782.00 ns, 46.8423 ns/op
WorkloadResult  13: 16777216 op, 785165060.00 ns, 46.7995 ns/op
WorkloadResult  14: 16777216 op, 788070011.00 ns, 46.9726 ns/op
GC:  0 0 0 816 16777216
Threading:  0 0 16777216

// AfterAll
// Benchmark Process 22235 has exited with code 0.

Mean = 47.018 ns, StdErr = 0.062 ns (0.13%), N = 14, StdDev = 0.232 ns
Min = 46.795 ns, Q1 = 46.860 ns, Median = 46.970 ns, Q3 = 46.998 ns, Max = 47.483 ns
IQR = 0.138 ns, LowerFence = 46.652 ns, UpperFence = 47.205 ns
ConfidenceInterval = [46.756 ns; 47.279 ns] (CI 99.9%), Margin = 0.261 ns (0.56% of Mean)
Skewness = 1.01, Kurtosis = 2.55, MValue = 2

// ** Remained 0 (0.0 %) benchmark(s) to run. Estimated finish 2022-10-03 14:13 (0h 0m from now) **
// ***** BenchmarkRunner: Finish  *****

// * Export *
  BenchmarkDotNet.Artifacts/results/net._7.performance.LinqPerformance-report.csv
  BenchmarkDotNet.Artifacts/results/net._7.performance.LinqPerformance-report-github.md
  BenchmarkDotNet.Artifacts/results/net._7.performance.LinqPerformance-report.html
  BenchmarkDotNet.Artifacts/results/net._7.performance.LinqPerformance-measurements.csv
  BenchmarkDotNet.Artifacts/results/BuildPlots.R
  BenchmarkDotNet.Artifacts/results/*.png

// * Detailed results *
LinqPerformance.List_Min: net60(Runtime=.NET 6.0)
Runtime = .NET 6.0.1 (6.0.121.56705), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 740.913 ns, StdErr = 1.004 ns (0.14%), N = 15, StdDev = 3.888 ns
Min = 734.220 ns, Q1 = 737.931 ns, Median = 742.170 ns, Q3 = 742.716 ns, Max = 749.579 ns
IQR = 4.785 ns, LowerFence = 730.753 ns, UpperFence = 749.894 ns
ConfidenceInterval = [736.756 ns; 745.070 ns] (CI 99.9%), Margin = 4.157 ns (0.56% of Mean)
Skewness = 0.18, Kurtosis = 2.63, MValue = 2
-------------------- Histogram --------------------
[732.150 ns ; 750.026 ns) | @@@@@@@@@@@@@@@
---------------------------------------------------

LinqPerformance.List_Max: net60(Runtime=.NET 6.0)
Runtime = .NET 6.0.1 (6.0.121.56705), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 761.705 ns, StdErr = 0.988 ns (0.13%), N = 13, StdDev = 3.564 ns
Min = 755.919 ns, Q1 = 760.198 ns, Median = 761.288 ns, Q3 = 762.684 ns, Max = 770.246 ns
IQR = 2.486 ns, LowerFence = 756.469 ns, UpperFence = 766.413 ns
ConfidenceInterval = [757.438 ns; 765.973 ns] (CI 99.9%), Margin = 4.268 ns (0.56% of Mean)
Skewness = 0.63, Kurtosis = 3.36, MValue = 2
-------------------- Histogram --------------------
[753.930 ns ; 772.236 ns) | @@@@@@@@@@@@@
---------------------------------------------------

LinqPerformance.List_Average: net60(Runtime=.NET 6.0)
Runtime = .NET 6.0.1 (6.0.121.56705), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 751.613 ns, StdErr = 2.502 ns (0.33%), N = 14, StdDev = 9.363 ns
Min = 743.441 ns, Q1 = 744.705 ns, Median = 748.986 ns, Q3 = 754.745 ns, Max = 776.193 ns
IQR = 10.039 ns, LowerFence = 729.646 ns, UpperFence = 769.804 ns
ConfidenceInterval = [741.051 ns; 762.176 ns] (CI 99.9%), Margin = 10.562 ns (1.41% of Mean)
Skewness = 1.28, Kurtosis = 3.76, MValue = 2
-------------------- Histogram --------------------
[740.709 ns ; 781.292 ns) | @@@@@@@@@@@@@@
---------------------------------------------------

LinqPerformance.List_Sum: net60(Runtime=.NET 6.0)
Runtime = .NET 6.0.1 (6.0.121.56705), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 737.389 ns, StdErr = 3.830 ns (0.52%), N = 25, StdDev = 19.151 ns
Min = 718.584 ns, Q1 = 723.674 ns, Median = 728.732 ns, Q3 = 746.883 ns, Max = 785.931 ns
IQR = 23.209 ns, LowerFence = 688.860 ns, UpperFence = 781.697 ns
ConfidenceInterval = [723.044 ns; 751.735 ns] (CI 99.9%), Margin = 14.345 ns (1.95% of Mean)
Skewness = 1.02, Kurtosis = 2.84, MValue = 2
-------------------- Histogram --------------------
[716.335 ns ; 733.527 ns) | @@@@@@@@@@@@@@@
[733.527 ns ; 762.733 ns) | @@@@@@@
[762.733 ns ; 794.527 ns) | @@@
---------------------------------------------------

LinqPerformance.List_Min: net70(Runtime=.NET 7.0)
Runtime = .NET 7.0.0 (7.0.22.42610), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 16.992 ns, StdErr = 0.024 ns (0.14%), N = 14, StdDev = 0.091 ns
Min = 16.879 ns, Q1 = 16.935 ns, Median = 16.967 ns, Q3 = 17.040 ns, Max = 17.194 ns
IQR = 0.105 ns, LowerFence = 16.778 ns, UpperFence = 17.197 ns
ConfidenceInterval = [16.889 ns; 17.095 ns] (CI 99.9%), Margin = 0.103 ns (0.61% of Mean)
Skewness = 0.75, Kurtosis = 2.49, MValue = 2
-------------------- Histogram --------------------
[16.829 ns ; 17.244 ns) | @@@@@@@@@@@@@@
---------------------------------------------------

LinqPerformance.List_Max: net70(Runtime=.NET 7.0)
Runtime = .NET 7.0.0 (7.0.22.42610), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 16.999 ns, StdErr = 0.056 ns (0.33%), N = 13, StdDev = 0.202 ns
Min = 16.774 ns, Q1 = 16.827 ns, Median = 16.997 ns, Q3 = 17.109 ns, Max = 17.467 ns
IQR = 0.282 ns, LowerFence = 16.404 ns, UpperFence = 17.532 ns
ConfidenceInterval = [16.757 ns; 17.242 ns] (CI 99.9%), Margin = 0.242 ns (1.43% of Mean)
Skewness = 0.71, Kurtosis = 2.65, MValue = 2
-------------------- Histogram --------------------
[16.717 ns ; 17.580 ns) | @@@@@@@@@@@@@
---------------------------------------------------

LinqPerformance.List_Average: net70(Runtime=.NET 7.0)
Runtime = .NET 7.0.0 (7.0.22.42610), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 26.550 ns, StdErr = 0.140 ns (0.53%), N = 18, StdDev = 0.592 ns
Min = 26.040 ns, Q1 = 26.138 ns, Median = 26.183 ns, Q3 = 27.123 ns, Max = 27.727 ns
IQR = 0.985 ns, LowerFence = 24.661 ns, UpperFence = 28.599 ns
ConfidenceInterval = [25.997 ns; 27.104 ns] (CI 99.9%), Margin = 0.554 ns (2.09% of Mean)
Skewness = 0.84, Kurtosis = 1.92, MValue = 2.77
-------------------- Histogram --------------------
[26.030 ns ; 26.623 ns) | @@@@@@@@@@@@@
[26.623 ns ; 27.213 ns) | 
[27.213 ns ; 27.806 ns) | @@@@@
---------------------------------------------------

LinqPerformance.List_Sum: net70(Runtime=.NET 7.0)
Runtime = .NET 7.0.0 (7.0.22.42610), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 47.018 ns, StdErr = 0.062 ns (0.13%), N = 14, StdDev = 0.232 ns
Min = 46.795 ns, Q1 = 46.860 ns, Median = 46.970 ns, Q3 = 46.998 ns, Max = 47.483 ns
IQR = 0.138 ns, LowerFence = 46.652 ns, UpperFence = 47.205 ns
ConfidenceInterval = [46.756 ns; 47.279 ns] (CI 99.9%), Margin = 0.261 ns (0.56% of Mean)
Skewness = 1.01, Kurtosis = 2.55, MValue = 2
-------------------- Histogram --------------------
[46.669 ns ; 47.609 ns) | @@@@@@@@@@@@@@
---------------------------------------------------

// * Summary *

BenchmarkDotNet=v0.13.2, OS=macOS Monterey 12.6 (21G115) [Darwin 21.6.0]
Intel Core i7-8850H CPU 2.60GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100-rc.1.22431.12
  [Host] : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT AVX2  [AttachedDebugger]
  net60  : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT AVX2
  net70  : .NET 7.0.0 (7.0.22.42610), X64 RyuJIT AVX2


|       Method |   Job |  Runtime |      Mean |     Error |    StdDev | Allocated |
|------------- |------ |--------- |----------:|----------:|----------:|----------:|
|     List_Min | net60 | .NET 6.0 | 740.91 ns |  4.157 ns |  3.888 ns |      40 B |
|     List_Max | net60 | .NET 6.0 | 761.71 ns |  4.268 ns |  3.564 ns |      40 B |
| List_Average | net60 | .NET 6.0 | 751.61 ns | 10.562 ns |  9.363 ns |      40 B |
|     List_Sum | net60 | .NET 6.0 | 737.39 ns | 14.345 ns | 19.151 ns |      40 B |
|     List_Min | net70 | .NET 7.0 |  16.99 ns |  0.103 ns |  0.091 ns |         - |
|     List_Max | net70 | .NET 7.0 |  17.00 ns |  0.242 ns |  0.202 ns |         - |
| List_Average | net70 | .NET 7.0 |  26.55 ns |  0.554 ns |  0.592 ns |         - |
|     List_Sum | net70 | .NET 7.0 |  47.02 ns |  0.261 ns |  0.232 ns |         - |

// * Warnings *
Environment
  Summary -> Benchmark was executed with attached debugger

// * Hints *
Outliers
  LinqPerformance.List_Max: net60     -> 2 outliers were removed (792.20 ns, 878.42 ns)
  LinqPerformance.List_Average: net60 -> 1 outlier  was  removed (780.22 ns)
  LinqPerformance.List_Sum: net60     -> 2 outliers were removed (879.43 ns, 978.42 ns)
  LinqPerformance.List_Min: net70     -> 1 outlier  was  removed (19.22 ns)
  LinqPerformance.List_Max: net70     -> 2 outliers were removed (19.46 ns, 19.83 ns)
  LinqPerformance.List_Sum: net70     -> 1 outlier  was  removed (50.18 ns)
// * Config Issues *

// * Warnings *
Configuration
  Summary -> The CsvMeasurementsExporter is already present in the configuration. There may be unexpected results of RPlotExporter.

// * Legends *
  Mean      : Arithmetic mean of all measurements
  Error     : Half of 99.9% confidence interval
  StdDev    : Standard deviation of all measurements
  Allocated : Allocated memory per single operation (managed only, inclusive, 1KB = 1024B)
  1 ns      : 1 Nanosecond (0.000000001 sec)

// * Diagnostic Output - MemoryDiagnoser *


// ***** BenchmarkRunner: End *****
Run time: 00:03:07 (187.35 sec), executed benchmarks: 8

Global total time: 00:03:48 (228.85 sec), executed benchmarks: 8
// * Artifacts cleanup *

```
