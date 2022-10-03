// Validating benchmarks:
// ***** BenchmarkRunner: Start   *****
// ***** Found 8 benchmark(s) in total *****
// ***** Building 2 exe(s) in Parallel: Start   *****
// ***** Done, took 00:00:08 (8.45 sec)   *****
// Found 8 benchmarks:
//   LinqPerformance.Array_Min: net60(Runtime=.NET 6.0)
//   LinqPerformance.Array_Max: net60(Runtime=.NET 6.0)
//   LinqPerformance.Array_Average: net60(Runtime=.NET 6.0)
//   LinqPerformance.Array_Sum: net60(Runtime=.NET 6.0)
//   LinqPerformance.Array_Min: net70(Runtime=.NET 7.0)
//   LinqPerformance.Array_Max: net70(Runtime=.NET 7.0)
//   LinqPerformance.Array_Average: net70(Runtime=.NET 7.0)
//   LinqPerformance.Array_Sum: net70(Runtime=.NET 7.0)

// **************************
// Benchmark: LinqPerformance.Array_Min: net60(Runtime=.NET 6.0)
// *** Execute ***
// Launch: 1 / 1
// Execute: dotnet 9a4c8103-e0e7-49c5-bb4f-3c02d15e2d9c.dll --benchmarkName net._7.performance.LinqPerformance.Array_Min --job net60 --benchmarkId 0 in /Users/frank.hsu/Documents/Projects/Test/net.7.performance/src/bin/Release/net6.0/9a4c8103-e0e7-49c5-bb4f-3c02d15e2d9c/bin/Release/net6.0
Failed to set up high priority. Make sure you have the right permissions. Message: Permission denied
// BeforeAnythingElse

// Benchmark Process Environment Information:
// Runtime=.NET 6.0.1 (6.0.121.56705), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: net60

OverheadJitting  1: 1 op, 356342.00 ns, 356.3420 us/op
WorkloadJitting  1: 1 op, 960374.00 ns, 960.3740 us/op

OverheadJitting  2: 16 op, 802441.00 ns, 50.1526 us/op
WorkloadJitting  2: 16 op, 878879.00 ns, 54.9299 us/op

WorkloadPilot    1: 16 op, 15854.00 ns, 990.8750 ns/op
WorkloadPilot    2: 32 op, 27236.00 ns, 851.1250 ns/op
WorkloadPilot    3: 64 op, 52777.00 ns, 824.6406 ns/op
WorkloadPilot    4: 128 op, 126373.00 ns, 987.2891 ns/op
WorkloadPilot    5: 256 op, 220004.00 ns, 859.3906 ns/op
WorkloadPilot    6: 512 op, 400139.00 ns, 781.5215 ns/op
WorkloadPilot    7: 1024 op, 796911.00 ns, 778.2334 ns/op
WorkloadPilot    8: 2048 op, 1590066.00 ns, 776.3994 ns/op
WorkloadPilot    9: 4096 op, 3271354.00 ns, 798.6704 ns/op
WorkloadPilot   10: 8192 op, 6543170.00 ns, 798.7268 ns/op
WorkloadPilot   11: 16384 op, 13266801.00 ns, 809.7413 ns/op
WorkloadPilot   12: 32768 op, 27783859.00 ns, 847.8961 ns/op
WorkloadPilot   13: 65536 op, 46548619.00 ns, 710.2756 ns/op
WorkloadPilot   14: 131072 op, 81192143.00 ns, 619.4469 ns/op
WorkloadPilot   15: 262144 op, 140179271.00 ns, 534.7415 ns/op
WorkloadPilot   16: 524288 op, 284443397.00 ns, 542.5327 ns/op
WorkloadPilot   17: 1048576 op, 565487993.00 ns, 539.2914 ns/op

OverheadWarmup   1: 1048576 op, 2275323.00 ns, 2.1699 ns/op
OverheadWarmup   2: 1048576 op, 1997751.00 ns, 1.9052 ns/op
OverheadWarmup   3: 1048576 op, 2064971.00 ns, 1.9693 ns/op
OverheadWarmup   4: 1048576 op, 2023430.00 ns, 1.9297 ns/op
OverheadWarmup   5: 1048576 op, 2019092.00 ns, 1.9256 ns/op
OverheadWarmup   6: 1048576 op, 2102760.00 ns, 2.0053 ns/op
OverheadWarmup   7: 1048576 op, 2009033.00 ns, 1.9160 ns/op

OverheadActual   1: 1048576 op, 1983974.00 ns, 1.8921 ns/op
OverheadActual   2: 1048576 op, 2038480.00 ns, 1.9440 ns/op
OverheadActual   3: 1048576 op, 2203492.00 ns, 2.1014 ns/op
OverheadActual   4: 1048576 op, 2191353.00 ns, 2.0898 ns/op
OverheadActual   5: 1048576 op, 2376329.00 ns, 2.2662 ns/op
OverheadActual   6: 1048576 op, 2381342.00 ns, 2.2710 ns/op
OverheadActual   7: 1048576 op, 2364533.00 ns, 2.2550 ns/op
OverheadActual   8: 1048576 op, 2411269.00 ns, 2.2996 ns/op
OverheadActual   9: 1048576 op, 2296208.00 ns, 2.1898 ns/op
OverheadActual  10: 1048576 op, 2132106.00 ns, 2.0333 ns/op
OverheadActual  11: 1048576 op, 1979849.00 ns, 1.8881 ns/op
OverheadActual  12: 1048576 op, 2006386.00 ns, 1.9134 ns/op
OverheadActual  13: 1048576 op, 2074372.00 ns, 1.9783 ns/op
OverheadActual  14: 1048576 op, 2047235.00 ns, 1.9524 ns/op
OverheadActual  15: 1048576 op, 2006280.00 ns, 1.9133 ns/op
OverheadActual  16: 1048576 op, 2036500.00 ns, 1.9422 ns/op
OverheadActual  17: 1048576 op, 2023808.00 ns, 1.9301 ns/op
OverheadActual  18: 1048576 op, 1978267.00 ns, 1.8866 ns/op
OverheadActual  19: 1048576 op, 2027036.00 ns, 1.9331 ns/op
OverheadActual  20: 1048576 op, 1988334.00 ns, 1.8962 ns/op

WorkloadWarmup   1: 1048576 op, 774345798.00 ns, 738.4737 ns/op
WorkloadWarmup   2: 1048576 op, 693052089.00 ns, 660.9460 ns/op
WorkloadWarmup   3: 1048576 op, 566033860.00 ns, 539.8120 ns/op
WorkloadWarmup   4: 1048576 op, 604803292.00 ns, 576.7854 ns/op
WorkloadWarmup   5: 1048576 op, 577358630.00 ns, 550.6121 ns/op
WorkloadWarmup   6: 1048576 op, 607350796.00 ns, 579.2149 ns/op
WorkloadWarmup   7: 1048576 op, 583807863.00 ns, 556.7626 ns/op

// BeforeActualRun
WorkloadActual   1: 1048576 op, 641878231.00 ns, 612.1428 ns/op
WorkloadActual   2: 1048576 op, 621599575.00 ns, 592.8035 ns/op
WorkloadActual   3: 1048576 op, 588924968.00 ns, 561.6426 ns/op
WorkloadActual   4: 1048576 op, 625281677.00 ns, 596.3151 ns/op
WorkloadActual   5: 1048576 op, 609881413.00 ns, 581.6282 ns/op
WorkloadActual   6: 1048576 op, 564503444.00 ns, 538.3524 ns/op
WorkloadActual   7: 1048576 op, 563736780.00 ns, 537.6213 ns/op
WorkloadActual   8: 1048576 op, 581203122.00 ns, 554.2785 ns/op
WorkloadActual   9: 1048576 op, 558013539.00 ns, 532.1632 ns/op
WorkloadActual  10: 1048576 op, 559296259.00 ns, 533.3865 ns/op
WorkloadActual  11: 1048576 op, 560464036.00 ns, 534.5002 ns/op
WorkloadActual  12: 1048576 op, 559184196.00 ns, 533.2796 ns/op
WorkloadActual  13: 1048576 op, 558250611.00 ns, 532.3893 ns/op
WorkloadActual  14: 1048576 op, 564808219.00 ns, 538.6431 ns/op
WorkloadActual  15: 1048576 op, 559681584.00 ns, 533.7540 ns/op
WorkloadActual  16: 1048576 op, 567829857.00 ns, 541.5248 ns/op
WorkloadActual  17: 1048576 op, 559814225.00 ns, 533.8804 ns/op
WorkloadActual  18: 1048576 op, 563917368.00 ns, 537.7935 ns/op
WorkloadActual  19: 1048576 op, 570058335.00 ns, 543.6500 ns/op
WorkloadActual  20: 1048576 op, 574748162.00 ns, 548.1226 ns/op
WorkloadActual  21: 1048576 op, 655718109.00 ns, 625.3415 ns/op
WorkloadActual  22: 1048576 op, 587600444.00 ns, 560.3795 ns/op
WorkloadActual  23: 1048576 op, 570080777.00 ns, 543.6714 ns/op
WorkloadActual  24: 1048576 op, 571529679.00 ns, 545.0532 ns/op
WorkloadActual  25: 1048576 op, 561417932.00 ns, 535.4099 ns/op
WorkloadActual  26: 1048576 op, 561463960.00 ns, 535.4538 ns/op
WorkloadActual  27: 1048576 op, 559384316.00 ns, 533.4705 ns/op

// AfterActualRun
WorkloadResult   1: 1048576 op, 586882110.50 ns, 559.6944 ns/op
WorkloadResult   2: 1048576 op, 607838555.50 ns, 579.6800 ns/op
WorkloadResult   3: 1048576 op, 562460586.50 ns, 536.4042 ns/op
WorkloadResult   4: 1048576 op, 561693922.50 ns, 535.6731 ns/op
WorkloadResult   5: 1048576 op, 579160264.50 ns, 552.3303 ns/op
WorkloadResult   6: 1048576 op, 555970681.50 ns, 530.2150 ns/op
WorkloadResult   7: 1048576 op, 557253401.50 ns, 531.4383 ns/op
WorkloadResult   8: 1048576 op, 558421178.50 ns, 532.5519 ns/op
WorkloadResult   9: 1048576 op, 557141338.50 ns, 531.3314 ns/op
WorkloadResult  10: 1048576 op, 556207753.50 ns, 530.4410 ns/op
WorkloadResult  11: 1048576 op, 562765361.50 ns, 536.6949 ns/op
WorkloadResult  12: 1048576 op, 557638726.50 ns, 531.8057 ns/op
WorkloadResult  13: 1048576 op, 565786999.50 ns, 539.5765 ns/op
WorkloadResult  14: 1048576 op, 557771367.50 ns, 531.9322 ns/op
WorkloadResult  15: 1048576 op, 561874510.50 ns, 535.8453 ns/op
WorkloadResult  16: 1048576 op, 568015477.50 ns, 541.7018 ns/op
WorkloadResult  17: 1048576 op, 572705304.50 ns, 546.1743 ns/op
WorkloadResult  18: 1048576 op, 585557586.50 ns, 558.4312 ns/op
WorkloadResult  19: 1048576 op, 568037919.50 ns, 541.7232 ns/op
WorkloadResult  20: 1048576 op, 569486821.50 ns, 543.1050 ns/op
WorkloadResult  21: 1048576 op, 559375074.50 ns, 533.4616 ns/op
WorkloadResult  22: 1048576 op, 559421102.50 ns, 533.5055 ns/op
WorkloadResult  23: 1048576 op, 557341458.50 ns, 531.5222 ns/op
GC:  7 1 0 33555584 1048576
Threading:  0 0 1048576

// AfterAll
// Benchmark Process 22573 has exited with code 0.

Mean = 540.228 ns, StdErr = 2.533 ns (0.47%), N = 23, StdDev = 12.148 ns
Min = 530.215 ns, Q1 = 531.869 ns, Median = 535.845 ns, Q3 = 542.414 ns, Max = 579.680 ns
IQR = 10.545 ns, LowerFence = 516.051 ns, UpperFence = 558.232 ns
ConfidenceInterval = [530.622 ns; 549.833 ns] (CI 99.9%), Margin = 9.606 ns (1.78% of Mean)
Skewness = 1.71, Kurtosis = 5.5, MValue = 2

// ** Remained 7 (87.5 %) benchmark(s) to run. Estimated finish 2022-10-03 14:17 (0h 2m from now) **
// **************************
// Benchmark: LinqPerformance.Array_Max: net60(Runtime=.NET 6.0)
// *** Execute ***
// Launch: 1 / 1
// Execute: dotnet 9a4c8103-e0e7-49c5-bb4f-3c02d15e2d9c.dll --benchmarkName net._7.performance.LinqPerformance.Array_Max --job net60 --benchmarkId 1 in /Users/frank.hsu/Documents/Projects/Test/net.7.performance/src/bin/Release/net6.0/9a4c8103-e0e7-49c5-bb4f-3c02d15e2d9c/bin/Release/net6.0
Failed to set up high priority. Make sure you have the right permissions. Message: Permission denied
// BeforeAnythingElse

// Benchmark Process Environment Information:
// Runtime=.NET 6.0.1 (6.0.121.56705), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: net60

OverheadJitting  1: 1 op, 328494.00 ns, 328.4940 us/op
WorkloadJitting  1: 1 op, 551262.00 ns, 551.2620 us/op

OverheadJitting  2: 16 op, 554874.00 ns, 34.6796 us/op
WorkloadJitting  2: 16 op, 491437.00 ns, 30.7148 us/op

WorkloadPilot    1: 16 op, 16697.00 ns, 1.0436 us/op
WorkloadPilot    2: 32 op, 30473.00 ns, 952.2812 ns/op
WorkloadPilot    3: 64 op, 59154.00 ns, 924.2812 ns/op
WorkloadPilot    4: 128 op, 114122.00 ns, 891.5781 ns/op
WorkloadPilot    5: 256 op, 227469.00 ns, 888.5508 ns/op
WorkloadPilot    6: 512 op, 452774.00 ns, 884.3242 ns/op
WorkloadPilot    7: 1024 op, 898557.00 ns, 877.4971 ns/op
WorkloadPilot    8: 2048 op, 1773365.00 ns, 865.9009 ns/op
WorkloadPilot    9: 4096 op, 3587587.00 ns, 875.8757 ns/op
WorkloadPilot   10: 8192 op, 6300573.00 ns, 769.1129 ns/op
WorkloadPilot   11: 16384 op, 12486839.00 ns, 762.1362 ns/op
WorkloadPilot   12: 32768 op, 25120476.00 ns, 766.6161 ns/op
WorkloadPilot   13: 65536 op, 50260629.00 ns, 766.9163 ns/op
WorkloadPilot   14: 131072 op, 93506285.00 ns, 713.3963 ns/op
WorkloadPilot   15: 262144 op, 140613535.00 ns, 536.3981 ns/op
WorkloadPilot   16: 524288 op, 282603464.00 ns, 539.0233 ns/op
WorkloadPilot   17: 1048576 op, 565898947.00 ns, 539.6833 ns/op

OverheadWarmup   1: 1048576 op, 2033606.00 ns, 1.9394 ns/op
OverheadWarmup   2: 1048576 op, 2129411.00 ns, 2.0308 ns/op
OverheadWarmup   3: 1048576 op, 2161405.00 ns, 2.0613 ns/op
OverheadWarmup   4: 1048576 op, 1957433.00 ns, 1.8668 ns/op
OverheadWarmup   5: 1048576 op, 2103252.00 ns, 2.0058 ns/op
OverheadWarmup   6: 1048576 op, 2089574.00 ns, 1.9928 ns/op

OverheadActual   1: 1048576 op, 1957650.00 ns, 1.8670 ns/op
OverheadActual   2: 1048576 op, 1999740.00 ns, 1.9071 ns/op
OverheadActual   3: 1048576 op, 2052213.00 ns, 1.9571 ns/op
OverheadActual   4: 1048576 op, 2080555.00 ns, 1.9842 ns/op
OverheadActual   5: 1048576 op, 2006790.00 ns, 1.9138 ns/op
OverheadActual   6: 1048576 op, 1957129.00 ns, 1.8665 ns/op
OverheadActual   7: 1048576 op, 2102823.00 ns, 2.0054 ns/op
OverheadActual   8: 1048576 op, 2056141.00 ns, 1.9609 ns/op
OverheadActual   9: 1048576 op, 1931685.00 ns, 1.8422 ns/op
OverheadActual  10: 1048576 op, 2054091.00 ns, 1.9589 ns/op
OverheadActual  11: 1048576 op, 2138497.00 ns, 2.0394 ns/op
OverheadActual  12: 1048576 op, 2006467.00 ns, 1.9135 ns/op
OverheadActual  13: 1048576 op, 2006379.00 ns, 1.9134 ns/op
OverheadActual  14: 1048576 op, 2050470.00 ns, 1.9555 ns/op
OverheadActual  15: 1048576 op, 1989574.00 ns, 1.8974 ns/op

WorkloadWarmup   1: 1048576 op, 565887630.00 ns, 539.6725 ns/op
WorkloadWarmup   2: 1048576 op, 571216131.00 ns, 544.7542 ns/op
WorkloadWarmup   3: 1048576 op, 571825318.00 ns, 545.3351 ns/op
WorkloadWarmup   4: 1048576 op, 567873237.00 ns, 541.5661 ns/op
WorkloadWarmup   5: 1048576 op, 565152921.00 ns, 538.9718 ns/op
WorkloadWarmup   6: 1048576 op, 566900808.00 ns, 540.6387 ns/op
WorkloadWarmup   7: 1048576 op, 564545241.00 ns, 538.3923 ns/op

// BeforeActualRun
WorkloadActual   1: 1048576 op, 563456716.00 ns, 537.3542 ns/op
WorkloadActual   2: 1048576 op, 569509920.00 ns, 543.1270 ns/op
WorkloadActual   3: 1048576 op, 568203689.00 ns, 541.8813 ns/op
WorkloadActual   4: 1048576 op, 576410077.00 ns, 549.7075 ns/op
WorkloadActual   5: 1048576 op, 565139977.00 ns, 538.9595 ns/op
WorkloadActual   6: 1048576 op, 567008092.00 ns, 540.7411 ns/op
WorkloadActual   7: 1048576 op, 565071260.00 ns, 538.8939 ns/op
WorkloadActual   8: 1048576 op, 565366920.00 ns, 539.1759 ns/op
WorkloadActual   9: 1048576 op, 566256124.00 ns, 540.0239 ns/op
WorkloadActual  10: 1048576 op, 563548833.00 ns, 537.4420 ns/op
WorkloadActual  11: 1048576 op, 568832461.00 ns, 542.4809 ns/op
WorkloadActual  12: 1048576 op, 568524815.00 ns, 542.1875 ns/op
WorkloadActual  13: 1048576 op, 574267206.00 ns, 547.6639 ns/op
WorkloadActual  14: 1048576 op, 571610593.00 ns, 545.1303 ns/op
WorkloadActual  15: 1048576 op, 562759144.00 ns, 536.6889 ns/op

// AfterActualRun
WorkloadResult   1: 1048576 op, 561449926.00 ns, 535.4404 ns/op
WorkloadResult   2: 1048576 op, 567503130.00 ns, 541.2132 ns/op
WorkloadResult   3: 1048576 op, 566196899.00 ns, 539.9674 ns/op
WorkloadResult   4: 1048576 op, 563133187.00 ns, 537.0457 ns/op
WorkloadResult   5: 1048576 op, 565001302.00 ns, 538.8272 ns/op
WorkloadResult   6: 1048576 op, 563064470.00 ns, 536.9801 ns/op
WorkloadResult   7: 1048576 op, 563360130.00 ns, 537.2621 ns/op
WorkloadResult   8: 1048576 op, 564249334.00 ns, 538.1101 ns/op
WorkloadResult   9: 1048576 op, 561542043.00 ns, 535.5282 ns/op
WorkloadResult  10: 1048576 op, 566825671.00 ns, 540.5671 ns/op
WorkloadResult  11: 1048576 op, 566518025.00 ns, 540.2737 ns/op
WorkloadResult  12: 1048576 op, 572260416.00 ns, 545.7501 ns/op
WorkloadResult  13: 1048576 op, 569603803.00 ns, 543.2165 ns/op
WorkloadResult  14: 1048576 op, 560752354.00 ns, 534.7751 ns/op
GC:  7 0 0 33555248 1048576
Threading:  0 0 1048576

// AfterAll
// Benchmark Process 22616 has exited with code 0.

Mean = 538.925 ns, StdErr = 0.837 ns (0.16%), N = 14, StdDev = 3.132 ns
Min = 534.775 ns, Q1 = 536.997 ns, Median = 538.469 ns, Q3 = 540.494 ns, Max = 545.750 ns
IQR = 3.497 ns, LowerFence = 531.751 ns, UpperFence = 545.740 ns
ConfidenceInterval = [535.393 ns; 542.458 ns] (CI 99.9%), Margin = 3.533 ns (0.66% of Mean)
Skewness = 0.57, Kurtosis = 2.35, MValue = 2

// ** Remained 6 (75.0 %) benchmark(s) to run. Estimated finish 2022-10-03 14:17 (0h 1m from now) **
// **************************
// Benchmark: LinqPerformance.Array_Average: net60(Runtime=.NET 6.0)
// *** Execute ***
// Launch: 1 / 1
// Execute: dotnet 9a4c8103-e0e7-49c5-bb4f-3c02d15e2d9c.dll --benchmarkName net._7.performance.LinqPerformance.Array_Average --job net60 --benchmarkId 2 in /Users/frank.hsu/Documents/Projects/Test/net.7.performance/src/bin/Release/net6.0/9a4c8103-e0e7-49c5-bb4f-3c02d15e2d9c/bin/Release/net6.0
Failed to set up high priority. Make sure you have the right permissions. Message: Permission denied
// BeforeAnythingElse

// Benchmark Process Environment Information:
// Runtime=.NET 6.0.1 (6.0.121.56705), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: net60

OverheadJitting  1: 1 op, 323655.00 ns, 323.6550 us/op
WorkloadJitting  1: 1 op, 497562.00 ns, 497.5620 us/op

OverheadJitting  2: 16 op, 567946.00 ns, 35.4966 us/op
WorkloadJitting  2: 16 op, 557566.00 ns, 34.8479 us/op

WorkloadPilot    1: 16 op, 12148.00 ns, 759.2500 ns/op
WorkloadPilot    2: 32 op, 22532.00 ns, 704.1250 ns/op
WorkloadPilot    3: 64 op, 43085.00 ns, 673.2031 ns/op
WorkloadPilot    4: 128 op, 82852.00 ns, 647.2812 ns/op
WorkloadPilot    5: 256 op, 165077.00 ns, 644.8320 ns/op
WorkloadPilot    6: 512 op, 328122.00 ns, 640.8633 ns/op
WorkloadPilot    7: 1024 op, 653225.00 ns, 637.9150 ns/op
WorkloadPilot    8: 2048 op, 1316947.00 ns, 643.0405 ns/op
WorkloadPilot    9: 4096 op, 2632735.00 ns, 642.7576 ns/op
WorkloadPilot   10: 8192 op, 5239972.00 ns, 639.6450 ns/op
WorkloadPilot   11: 16384 op, 10692582.00 ns, 652.6234 ns/op
WorkloadPilot   12: 32768 op, 21357059.00 ns, 651.7657 ns/op
WorkloadPilot   13: 65536 op, 43159469.00 ns, 658.5612 ns/op
WorkloadPilot   14: 131072 op, 87111100.00 ns, 664.6049 ns/op
WorkloadPilot   15: 262144 op, 132746454.00 ns, 506.3875 ns/op
WorkloadPilot   16: 524288 op, 266202035.00 ns, 507.7401 ns/op
WorkloadPilot   17: 1048576 op, 532923557.00 ns, 508.2355 ns/op

OverheadWarmup   1: 1048576 op, 2141766.00 ns, 2.0425 ns/op
OverheadWarmup   2: 1048576 op, 2319536.00 ns, 2.2121 ns/op
OverheadWarmup   3: 1048576 op, 2057425.00 ns, 1.9621 ns/op
OverheadWarmup   4: 1048576 op, 1919035.00 ns, 1.8301 ns/op
OverheadWarmup   5: 1048576 op, 2095086.00 ns, 1.9980 ns/op
OverheadWarmup   6: 1048576 op, 2101268.00 ns, 2.0039 ns/op
OverheadWarmup   7: 1048576 op, 2164825.00 ns, 2.0645 ns/op
OverheadWarmup   8: 1048576 op, 2491474.00 ns, 2.3761 ns/op
OverheadWarmup   9: 1048576 op, 2265151.00 ns, 2.1602 ns/op

OverheadActual   1: 1048576 op, 2203898.00 ns, 2.1018 ns/op
OverheadActual   2: 1048576 op, 1941434.00 ns, 1.8515 ns/op
OverheadActual   3: 1048576 op, 2284561.00 ns, 2.1787 ns/op
OverheadActual   4: 1048576 op, 2606695.00 ns, 2.4859 ns/op
OverheadActual   5: 1048576 op, 2280441.00 ns, 2.1748 ns/op
OverheadActual   6: 1048576 op, 2133288.00 ns, 2.0345 ns/op
OverheadActual   7: 1048576 op, 2077322.00 ns, 1.9811 ns/op
OverheadActual   8: 1048576 op, 2256512.00 ns, 2.1520 ns/op
OverheadActual   9: 1048576 op, 2249502.00 ns, 2.1453 ns/op
OverheadActual  10: 1048576 op, 2036609.00 ns, 1.9423 ns/op
OverheadActual  11: 1048576 op, 2267293.00 ns, 2.1623 ns/op
OverheadActual  12: 1048576 op, 2694437.00 ns, 2.5696 ns/op
OverheadActual  13: 1048576 op, 2078295.00 ns, 1.9820 ns/op
OverheadActual  14: 1048576 op, 2134363.00 ns, 2.0355 ns/op
OverheadActual  15: 1048576 op, 2123001.00 ns, 2.0247 ns/op
OverheadActual  16: 1048576 op, 2146679.00 ns, 2.0472 ns/op
OverheadActual  17: 1048576 op, 2086814.00 ns, 1.9901 ns/op
OverheadActual  18: 1048576 op, 2321686.00 ns, 2.2141 ns/op
OverheadActual  19: 1048576 op, 2100441.00 ns, 2.0031 ns/op

WorkloadWarmup   1: 1048576 op, 533054605.00 ns, 508.3605 ns/op
WorkloadWarmup   2: 1048576 op, 534534497.00 ns, 509.7718 ns/op
WorkloadWarmup   3: 1048576 op, 549884628.00 ns, 524.4108 ns/op
WorkloadWarmup   4: 1048576 op, 536083243.00 ns, 511.2488 ns/op
WorkloadWarmup   5: 1048576 op, 564264276.00 ns, 538.1243 ns/op
WorkloadWarmup   6: 1048576 op, 532926168.00 ns, 508.2380 ns/op

// BeforeActualRun
WorkloadActual   1: 1048576 op, 533114044.00 ns, 508.4172 ns/op
WorkloadActual   2: 1048576 op, 532611231.00 ns, 507.9377 ns/op
WorkloadActual   3: 1048576 op, 534457293.00 ns, 509.6982 ns/op
WorkloadActual   4: 1048576 op, 532738942.00 ns, 508.0594 ns/op
WorkloadActual   5: 1048576 op, 537351116.00 ns, 512.4580 ns/op
WorkloadActual   6: 1048576 op, 553819567.00 ns, 528.1635 ns/op
WorkloadActual   7: 1048576 op, 600493386.00 ns, 572.6751 ns/op
WorkloadActual   8: 1048576 op, 687454052.00 ns, 655.6073 ns/op
WorkloadActual   9: 1048576 op, 533139756.00 ns, 508.4417 ns/op
WorkloadActual  10: 1048576 op, 536055941.00 ns, 511.2228 ns/op
WorkloadActual  11: 1048576 op, 534467139.00 ns, 509.7076 ns/op
WorkloadActual  12: 1048576 op, 532577539.00 ns, 507.9055 ns/op
WorkloadActual  13: 1048576 op, 533258585.00 ns, 508.5550 ns/op
WorkloadActual  14: 1048576 op, 537039586.00 ns, 512.1609 ns/op
WorkloadActual  15: 1048576 op, 541176166.00 ns, 516.1058 ns/op

// AfterActualRun
WorkloadResult   1: 1048576 op, 530967365.00 ns, 506.3699 ns/op
WorkloadResult   2: 1048576 op, 530464552.00 ns, 505.8904 ns/op
WorkloadResult   3: 1048576 op, 532310614.00 ns, 507.6510 ns/op
WorkloadResult   4: 1048576 op, 530592263.00 ns, 506.0122 ns/op
WorkloadResult   5: 1048576 op, 535204437.00 ns, 510.4107 ns/op
WorkloadResult   6: 1048576 op, 530993077.00 ns, 506.3945 ns/op
WorkloadResult   7: 1048576 op, 533909262.00 ns, 509.1756 ns/op
WorkloadResult   8: 1048576 op, 532320460.00 ns, 507.6604 ns/op
WorkloadResult   9: 1048576 op, 530430860.00 ns, 505.8583 ns/op
WorkloadResult  10: 1048576 op, 531111906.00 ns, 506.5078 ns/op
WorkloadResult  11: 1048576 op, 534892907.00 ns, 510.1136 ns/op
WorkloadResult  12: 1048576 op, 539029487.00 ns, 514.0586 ns/op
GC:  7 0 0 33555248 1048576
Threading:  0 0 1048576

// AfterAll
// Benchmark Process 22654 has exited with code 0.

Mean = 508.009 ns, StdErr = 0.723 ns (0.14%), N = 12, StdDev = 2.506 ns
Min = 505.858 ns, Q1 = 506.281 ns, Median = 507.079 ns, Q3 = 509.410 ns, Max = 514.059 ns
IQR = 3.130 ns, LowerFence = 501.586 ns, UpperFence = 514.104 ns
ConfidenceInterval = [504.799 ns; 511.218 ns] (CI 99.9%), Margin = 3.209 ns (0.63% of Mean)
Skewness = 1.1, Kurtosis = 3.11, MValue = 2

// ** Remained 5 (62.5 %) benchmark(s) to run. Estimated finish 2022-10-03 14:17 (0h 1m from now) **
// **************************
// Benchmark: LinqPerformance.Array_Sum: net60(Runtime=.NET 6.0)
// *** Execute ***
// Launch: 1 / 1
// Execute: dotnet 9a4c8103-e0e7-49c5-bb4f-3c02d15e2d9c.dll --benchmarkName net._7.performance.LinqPerformance.Array_Sum --job net60 --benchmarkId 3 in /Users/frank.hsu/Documents/Projects/Test/net.7.performance/src/bin/Release/net6.0/9a4c8103-e0e7-49c5-bb4f-3c02d15e2d9c/bin/Release/net6.0
Failed to set up high priority. Make sure you have the right permissions. Message: Permission denied
// BeforeAnythingElse

// Benchmark Process Environment Information:
// Runtime=.NET 6.0.1 (6.0.121.56705), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: net60

OverheadJitting  1: 1 op, 292679.00 ns, 292.6790 us/op
WorkloadJitting  1: 1 op, 473723.00 ns, 473.7230 us/op

OverheadJitting  2: 16 op, 439838.00 ns, 27.4899 us/op
WorkloadJitting  2: 16 op, 475875.00 ns, 29.7422 us/op

WorkloadPilot    1: 16 op, 12537.00 ns, 783.5625 ns/op
WorkloadPilot    2: 32 op, 24042.00 ns, 751.3125 ns/op
WorkloadPilot    3: 64 op, 47844.00 ns, 747.5625 ns/op
WorkloadPilot    4: 128 op, 92822.00 ns, 725.1719 ns/op
WorkloadPilot    5: 256 op, 178750.00 ns, 698.2422 ns/op
WorkloadPilot    6: 512 op, 346892.00 ns, 677.5234 ns/op
WorkloadPilot    7: 1024 op, 767561.00 ns, 749.5713 ns/op
WorkloadPilot    8: 2048 op, 1299052.00 ns, 634.3027 ns/op
WorkloadPilot    9: 4096 op, 2577594.00 ns, 629.2954 ns/op
WorkloadPilot   10: 8192 op, 5309506.00 ns, 648.1331 ns/op
WorkloadPilot   11: 16384 op, 10381312.00 ns, 633.6250 ns/op
WorkloadPilot   12: 32768 op, 20944393.00 ns, 639.1721 ns/op
WorkloadPilot   13: 65536 op, 41880752.00 ns, 639.0496 ns/op
WorkloadPilot   14: 131072 op, 84652651.00 ns, 645.8485 ns/op
WorkloadPilot   15: 262144 op, 130512889.00 ns, 497.8672 ns/op
WorkloadPilot   16: 524288 op, 257163973.00 ns, 490.5014 ns/op
WorkloadPilot   17: 1048576 op, 507162712.00 ns, 483.6681 ns/op

OverheadWarmup   1: 1048576 op, 2122503.00 ns, 2.0242 ns/op
OverheadWarmup   2: 1048576 op, 1985934.00 ns, 1.8939 ns/op
OverheadWarmup   3: 1048576 op, 2006747.00 ns, 1.9138 ns/op
OverheadWarmup   4: 1048576 op, 2059259.00 ns, 1.9639 ns/op
OverheadWarmup   5: 1048576 op, 1989785.00 ns, 1.8976 ns/op
OverheadWarmup   6: 1048576 op, 2045352.00 ns, 1.9506 ns/op
OverheadWarmup   7: 1048576 op, 2028612.00 ns, 1.9346 ns/op

OverheadActual   1: 1048576 op, 2000505.00 ns, 1.9078 ns/op
OverheadActual   2: 1048576 op, 2001011.00 ns, 1.9083 ns/op
OverheadActual   3: 1048576 op, 2019065.00 ns, 1.9255 ns/op
OverheadActual   4: 1048576 op, 1983840.00 ns, 1.8919 ns/op
OverheadActual   5: 1048576 op, 2068770.00 ns, 1.9729 ns/op
OverheadActual   6: 1048576 op, 2005032.00 ns, 1.9121 ns/op
OverheadActual   7: 1048576 op, 2038547.00 ns, 1.9441 ns/op
OverheadActual   8: 1048576 op, 2007245.00 ns, 1.9143 ns/op
OverheadActual   9: 1048576 op, 2009421.00 ns, 1.9163 ns/op
OverheadActual  10: 1048576 op, 2016934.00 ns, 1.9235 ns/op
OverheadActual  11: 1048576 op, 2041029.00 ns, 1.9465 ns/op
OverheadActual  12: 1048576 op, 2013678.00 ns, 1.9204 ns/op
OverheadActual  13: 1048576 op, 2032053.00 ns, 1.9379 ns/op
OverheadActual  14: 1048576 op, 2041397.00 ns, 1.9468 ns/op
OverheadActual  15: 1048576 op, 1978419.00 ns, 1.8868 ns/op

WorkloadWarmup   1: 1048576 op, 505272789.00 ns, 481.8657 ns/op
WorkloadWarmup   2: 1048576 op, 503978112.00 ns, 480.6310 ns/op
WorkloadWarmup   3: 1048576 op, 505509096.00 ns, 482.0910 ns/op
WorkloadWarmup   4: 1048576 op, 505465842.00 ns, 482.0498 ns/op
WorkloadWarmup   5: 1048576 op, 508251154.00 ns, 484.7061 ns/op
WorkloadWarmup   6: 1048576 op, 512259251.00 ns, 488.5285 ns/op
WorkloadWarmup   7: 1048576 op, 507659757.00 ns, 484.1421 ns/op

// BeforeActualRun
WorkloadActual   1: 1048576 op, 503990124.00 ns, 480.6424 ns/op
WorkloadActual   2: 1048576 op, 509378575.00 ns, 485.7813 ns/op
WorkloadActual   3: 1048576 op, 506706191.00 ns, 483.2327 ns/op
WorkloadActual   4: 1048576 op, 508125624.00 ns, 484.5864 ns/op
WorkloadActual   5: 1048576 op, 506125311.00 ns, 482.6787 ns/op
WorkloadActual   6: 1048576 op, 506595472.00 ns, 483.1271 ns/op
WorkloadActual   7: 1048576 op, 504482833.00 ns, 481.1123 ns/op
WorkloadActual   8: 1048576 op, 507562310.00 ns, 484.0491 ns/op
WorkloadActual   9: 1048576 op, 512066359.00 ns, 488.3445 ns/op
WorkloadActual  10: 1048576 op, 508036414.00 ns, 484.5013 ns/op
WorkloadActual  11: 1048576 op, 505303099.00 ns, 481.8946 ns/op
WorkloadActual  12: 1048576 op, 506334380.00 ns, 482.8781 ns/op
WorkloadActual  13: 1048576 op, 505190677.00 ns, 481.7874 ns/op
WorkloadActual  14: 1048576 op, 506435174.00 ns, 482.9742 ns/op
WorkloadActual  15: 1048576 op, 506994912.00 ns, 483.5080 ns/op

// AfterActualRun
WorkloadResult   1: 1048576 op, 501976446.00 ns, 478.7220 ns/op
WorkloadResult   2: 1048576 op, 507364897.00 ns, 483.8609 ns/op
WorkloadResult   3: 1048576 op, 504692513.00 ns, 481.3123 ns/op
WorkloadResult   4: 1048576 op, 506111946.00 ns, 482.6660 ns/op
WorkloadResult   5: 1048576 op, 504111633.00 ns, 480.7583 ns/op
WorkloadResult   6: 1048576 op, 504581794.00 ns, 481.2067 ns/op
WorkloadResult   7: 1048576 op, 502469155.00 ns, 479.1919 ns/op
WorkloadResult   8: 1048576 op, 505548632.00 ns, 482.1287 ns/op
WorkloadResult   9: 1048576 op, 506022736.00 ns, 482.5809 ns/op
WorkloadResult  10: 1048576 op, 503289421.00 ns, 479.9742 ns/op
WorkloadResult  11: 1048576 op, 504320702.00 ns, 480.9577 ns/op
WorkloadResult  12: 1048576 op, 503176999.00 ns, 479.8670 ns/op
WorkloadResult  13: 1048576 op, 504421496.00 ns, 481.0538 ns/op
WorkloadResult  14: 1048576 op, 504981234.00 ns, 481.5876 ns/op
GC:  7 0 0 33555296 1048576
Threading:  0 0 1048576

// AfterAll
// Benchmark Process 22691 has exited with code 0.

Mean = 481.133 ns, StdErr = 0.377 ns (0.08%), N = 14, StdDev = 1.409 ns
Min = 478.722 ns, Q1 = 480.170 ns, Median = 481.130 ns, Q3 = 481.993 ns, Max = 483.861 ns
IQR = 1.823 ns, LowerFence = 477.435 ns, UpperFence = 484.728 ns
ConfidenceInterval = [479.543 ns; 482.723 ns] (CI 99.9%), Margin = 1.590 ns (0.33% of Mean)
Skewness = 0.08, Kurtosis = 2.15, MValue = 2

// ** Remained 4 (50.0 %) benchmark(s) to run. Estimated finish 2022-10-03 14:16 (0h 1m from now) **
// **************************
// Benchmark: LinqPerformance.Array_Min: net70(Runtime=.NET 7.0)
// *** Execute ***
// Launch: 1 / 1
// Execute: dotnet dbbd0e1b-7597-4575-8128-d4f7a5789f5c.dll --benchmarkName net._7.performance.LinqPerformance.Array_Min --job net70 --benchmarkId 0 in /Users/frank.hsu/Documents/Projects/Test/net.7.performance/src/bin/Release/net6.0/dbbd0e1b-7597-4575-8128-d4f7a5789f5c/bin/Release/net7.0
Failed to set up high priority. Make sure you have the right permissions. Message: Permission denied
// BeforeAnythingElse

// Benchmark Process Environment Information:
// Runtime=.NET 7.0.0 (7.0.22.42610), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: net70

OverheadJitting  1: 1 op, 373908.00 ns, 373.9080 us/op
WorkloadJitting  1: 1 op, 2054096.00 ns, 2.0541 ms/op

OverheadJitting  2: 16 op, 505347.00 ns, 31.5842 us/op
WorkloadJitting  2: 16 op, 513106.00 ns, 32.0691 us/op

WorkloadPilot    1: 16 op, 17231.00 ns, 1.0769 us/op
WorkloadPilot    2: 32 op, 30612.00 ns, 956.6250 ns/op
WorkloadPilot    3: 64 op, 78870.00 ns, 1.2323 us/op
WorkloadPilot    4: 128 op, 111841.00 ns, 873.7578 ns/op
WorkloadPilot    5: 256 op, 219678.00 ns, 858.1172 ns/op
WorkloadPilot    6: 512 op, 512706.00 ns, 1.0014 us/op
WorkloadPilot    7: 1024 op, 994019.00 ns, 970.7217 ns/op
WorkloadPilot    8: 2048 op, 1770772.00 ns, 864.6348 ns/op
WorkloadPilot    9: 4096 op, 3474522.00 ns, 848.2720 ns/op
WorkloadPilot   10: 8192 op, 6861910.00 ns, 837.6355 ns/op
WorkloadPilot   11: 16384 op, 12225567.00 ns, 746.1894 ns/op
WorkloadPilot   12: 32768 op, 24423858.00 ns, 745.3570 ns/op
WorkloadPilot   13: 65536 op, 50477125.00 ns, 770.2198 ns/op
WorkloadPilot   14: 131072 op, 30525068.00 ns, 232.8878 ns/op
WorkloadPilot   15: 262144 op, 4860775.00 ns, 18.5424 ns/op
WorkloadPilot   16: 524288 op, 8880924.00 ns, 16.9390 ns/op
WorkloadPilot   17: 1048576 op, 17282121.00 ns, 16.4815 ns/op
WorkloadPilot   18: 2097152 op, 35013057.00 ns, 16.6955 ns/op
WorkloadPilot   19: 4194304 op, 70046269.00 ns, 16.7003 ns/op
WorkloadPilot   20: 8388608 op, 141524648.00 ns, 16.8711 ns/op
WorkloadPilot   21: 16777216 op, 276947647.00 ns, 16.5074 ns/op
WorkloadPilot   22: 33554432 op, 565428057.00 ns, 16.8511 ns/op

OverheadWarmup   1: 33554432 op, 75065683.00 ns, 2.2371 ns/op
OverheadWarmup   2: 33554432 op, 73852106.00 ns, 2.2010 ns/op
OverheadWarmup   3: 33554432 op, 67772790.00 ns, 2.0198 ns/op
OverheadWarmup   4: 33554432 op, 54804529.00 ns, 1.6333 ns/op
OverheadWarmup   5: 33554432 op, 54649649.00 ns, 1.6287 ns/op
OverheadWarmup   6: 33554432 op, 54578793.00 ns, 1.6266 ns/op
OverheadWarmup   7: 33554432 op, 54792300.00 ns, 1.6329 ns/op
OverheadWarmup   8: 33554432 op, 56279350.00 ns, 1.6773 ns/op
OverheadWarmup   9: 33554432 op, 58002584.00 ns, 1.7286 ns/op
OverheadWarmup  10: 33554432 op, 55085135.00 ns, 1.6417 ns/op

OverheadActual   1: 33554432 op, 55116409.00 ns, 1.6426 ns/op
OverheadActual   2: 33554432 op, 54880611.00 ns, 1.6356 ns/op
OverheadActual   3: 33554432 op, 55185646.00 ns, 1.6447 ns/op
OverheadActual   4: 33554432 op, 55439244.00 ns, 1.6522 ns/op
OverheadActual   5: 33554432 op, 54973826.00 ns, 1.6383 ns/op
OverheadActual   6: 33554432 op, 83002257.00 ns, 2.4737 ns/op
OverheadActual   7: 33554432 op, 58754393.00 ns, 1.7510 ns/op
OverheadActual   8: 33554432 op, 55616553.00 ns, 1.6575 ns/op
OverheadActual   9: 33554432 op, 55067962.00 ns, 1.6412 ns/op
OverheadActual  10: 33554432 op, 54766860.00 ns, 1.6322 ns/op
OverheadActual  11: 33554432 op, 54669434.00 ns, 1.6293 ns/op
OverheadActual  12: 33554432 op, 54728766.00 ns, 1.6310 ns/op
OverheadActual  13: 33554432 op, 54820704.00 ns, 1.6338 ns/op
OverheadActual  14: 33554432 op, 54690939.00 ns, 1.6299 ns/op
OverheadActual  15: 33554432 op, 54672353.00 ns, 1.6294 ns/op

WorkloadWarmup   1: 33554432 op, 557612858.00 ns, 16.6182 ns/op
WorkloadWarmup   2: 33554432 op, 557031958.00 ns, 16.6008 ns/op
WorkloadWarmup   3: 33554432 op, 556554864.00 ns, 16.5866 ns/op
WorkloadWarmup   4: 33554432 op, 558233312.00 ns, 16.6366 ns/op
WorkloadWarmup   5: 33554432 op, 561139428.00 ns, 16.7233 ns/op
WorkloadWarmup   6: 33554432 op, 564723095.00 ns, 16.8301 ns/op
WorkloadWarmup   7: 33554432 op, 559389647.00 ns, 16.6711 ns/op
WorkloadWarmup   8: 33554432 op, 570998224.00 ns, 17.0171 ns/op
WorkloadWarmup   9: 33554432 op, 562926811.00 ns, 16.7765 ns/op

// BeforeActualRun
WorkloadActual   1: 33554432 op, 555776620.00 ns, 16.5634 ns/op
WorkloadActual   2: 33554432 op, 580427630.00 ns, 17.2981 ns/op
WorkloadActual   3: 33554432 op, 568366562.00 ns, 16.9386 ns/op
WorkloadActual   4: 33554432 op, 697700258.00 ns, 20.7931 ns/op
WorkloadActual   5: 33554432 op, 623769010.00 ns, 18.5898 ns/op
WorkloadActual   6: 33554432 op, 588343945.00 ns, 17.5340 ns/op
WorkloadActual   7: 33554432 op, 559584135.00 ns, 16.6769 ns/op
WorkloadActual   8: 33554432 op, 627403697.00 ns, 18.6981 ns/op
WorkloadActual   9: 33554432 op, 631892133.00 ns, 18.8319 ns/op
WorkloadActual  10: 33554432 op, 690262539.00 ns, 20.5714 ns/op
WorkloadActual  11: 33554432 op, 560085925.00 ns, 16.6919 ns/op
WorkloadActual  12: 33554432 op, 556385981.00 ns, 16.5816 ns/op
WorkloadActual  13: 33554432 op, 557816412.00 ns, 16.6242 ns/op
WorkloadActual  14: 33554432 op, 563641748.00 ns, 16.7978 ns/op
WorkloadActual  15: 33554432 op, 620447172.00 ns, 18.4908 ns/op
WorkloadActual  16: 33554432 op, 681722382.00 ns, 20.3169 ns/op
WorkloadActual  17: 33554432 op, 624196029.00 ns, 18.6025 ns/op
WorkloadActual  18: 33554432 op, 587708882.00 ns, 17.5151 ns/op
WorkloadActual  19: 33554432 op, 669565414.00 ns, 19.9546 ns/op
WorkloadActual  20: 33554432 op, 743115980.00 ns, 22.1466 ns/op
WorkloadActual  21: 33554432 op, 714158920.00 ns, 21.2836 ns/op
WorkloadActual  22: 33554432 op, 768144799.00 ns, 22.8925 ns/op
WorkloadActual  23: 33554432 op, 767788730.00 ns, 22.8819 ns/op
WorkloadActual  24: 33554432 op, 740188064.00 ns, 22.0593 ns/op
WorkloadActual  25: 33554432 op, 724348083.00 ns, 21.5873 ns/op
WorkloadActual  26: 33554432 op, 614650006.00 ns, 18.3180 ns/op
WorkloadActual  27: 33554432 op, 583887273.00 ns, 17.4012 ns/op
WorkloadActual  28: 33554432 op, 580383668.00 ns, 17.2968 ns/op
WorkloadActual  29: 33554432 op, 590273727.00 ns, 17.5915 ns/op
WorkloadActual  30: 33554432 op, 596233046.00 ns, 17.7691 ns/op
WorkloadActual  31: 33554432 op, 668006094.00 ns, 19.9081 ns/op
WorkloadActual  32: 33554432 op, 593765865.00 ns, 17.6956 ns/op
WorkloadActual  33: 33554432 op, 600687579.00 ns, 17.9019 ns/op
WorkloadActual  34: 33554432 op, 606036130.00 ns, 18.0613 ns/op
WorkloadActual  35: 33554432 op, 580206530.00 ns, 17.2915 ns/op
WorkloadActual  36: 33554432 op, 582914800.00 ns, 17.3722 ns/op
WorkloadActual  37: 33554432 op, 599725104.00 ns, 17.8732 ns/op
WorkloadActual  38: 33554432 op, 577108672.00 ns, 17.1992 ns/op
WorkloadActual  39: 33554432 op, 618465086.00 ns, 18.4317 ns/op
WorkloadActual  40: 33554432 op, 629973931.00 ns, 18.7747 ns/op
WorkloadActual  41: 33554432 op, 643937925.00 ns, 19.1908 ns/op
WorkloadActual  42: 33554432 op, 691259515.00 ns, 20.6011 ns/op
WorkloadActual  43: 33554432 op, 588757563.00 ns, 17.5463 ns/op
WorkloadActual  44: 33554432 op, 604397254.00 ns, 18.0124 ns/op
WorkloadActual  45: 33554432 op, 574661908.00 ns, 17.1263 ns/op
WorkloadActual  46: 33554432 op, 563847283.00 ns, 16.8040 ns/op
WorkloadActual  47: 33554432 op, 584947099.00 ns, 17.4328 ns/op
WorkloadActual  48: 33554432 op, 611390712.00 ns, 18.2209 ns/op
WorkloadActual  49: 33554432 op, 560973498.00 ns, 16.7183 ns/op
WorkloadActual  50: 33554432 op, 559337949.00 ns, 16.6696 ns/op
WorkloadActual  51: 33554432 op, 558375577.00 ns, 16.6409 ns/op
WorkloadActual  52: 33554432 op, 560200152.00 ns, 16.6953 ns/op
WorkloadActual  53: 33554432 op, 566279319.00 ns, 16.8764 ns/op
WorkloadActual  54: 33554432 op, 627248132.00 ns, 18.6935 ns/op
WorkloadActual  55: 33554432 op, 710849564.00 ns, 21.1850 ns/op
WorkloadActual  56: 33554432 op, 662582048.00 ns, 19.7465 ns/op
WorkloadActual  57: 33554432 op, 575685132.00 ns, 17.1568 ns/op
WorkloadActual  58: 33554432 op, 731370310.00 ns, 21.7965 ns/op
WorkloadActual  59: 33554432 op, 613361690.00 ns, 18.2796 ns/op
WorkloadActual  60: 33554432 op, 594717924.00 ns, 17.7240 ns/op
WorkloadActual  61: 33554432 op, 715375762.00 ns, 21.3199 ns/op
WorkloadActual  62: 33554432 op, 624602970.00 ns, 18.6146 ns/op
WorkloadActual  63: 33554432 op, 661951603.00 ns, 19.7277 ns/op
WorkloadActual  64: 33554432 op, 647301249.00 ns, 19.2911 ns/op
WorkloadActual  65: 33554432 op, 568557524.00 ns, 16.9443 ns/op
WorkloadActual  66: 33554432 op, 597290603.00 ns, 17.8006 ns/op
WorkloadActual  67: 33554432 op, 611669157.00 ns, 18.2292 ns/op
WorkloadActual  68: 33554432 op, 561076856.00 ns, 16.7214 ns/op
WorkloadActual  69: 33554432 op, 562387210.00 ns, 16.7604 ns/op
WorkloadActual  70: 33554432 op, 567645142.00 ns, 16.9171 ns/op
WorkloadActual  71: 33554432 op, 574512958.00 ns, 17.1218 ns/op
WorkloadActual  72: 33554432 op, 566472684.00 ns, 16.8822 ns/op
WorkloadActual  73: 33554432 op, 567739960.00 ns, 16.9200 ns/op
WorkloadActual  74: 33554432 op, 564664810.00 ns, 16.8283 ns/op
WorkloadActual  75: 33554432 op, 585117244.00 ns, 17.4379 ns/op
WorkloadActual  76: 33554432 op, 578548344.00 ns, 17.2421 ns/op
WorkloadActual  77: 33554432 op, 645639421.00 ns, 19.2416 ns/op
WorkloadActual  78: 33554432 op, 593578073.00 ns, 17.6900 ns/op
WorkloadActual  79: 33554432 op, 607819059.00 ns, 18.1144 ns/op
WorkloadActual  80: 33554432 op, 562903600.00 ns, 16.7758 ns/op
WorkloadActual  81: 33554432 op, 567332475.00 ns, 16.9078 ns/op
WorkloadActual  82: 33554432 op, 564697569.00 ns, 16.8293 ns/op
WorkloadActual  83: 33554432 op, 559628438.00 ns, 16.6782 ns/op
WorkloadActual  84: 33554432 op, 557088269.00 ns, 16.6025 ns/op
WorkloadActual  85: 33554432 op, 558907431.00 ns, 16.6567 ns/op
WorkloadActual  86: 33554432 op, 561706336.00 ns, 16.7402 ns/op
WorkloadActual  87: 33554432 op, 571217828.00 ns, 17.0236 ns/op
WorkloadActual  88: 33554432 op, 561158615.00 ns, 16.7238 ns/op
WorkloadActual  89: 33554432 op, 559517112.00 ns, 16.6749 ns/op
WorkloadActual  90: 33554432 op, 559295459.00 ns, 16.6683 ns/op
WorkloadActual  91: 33554432 op, 567990759.00 ns, 16.9274 ns/op
WorkloadActual  92: 33554432 op, 612097509.00 ns, 18.2419 ns/op
WorkloadActual  93: 33554432 op, 571141191.00 ns, 17.0213 ns/op
WorkloadActual  94: 33554432 op, 603331647.00 ns, 17.9807 ns/op
WorkloadActual  95: 33554432 op, 576809343.00 ns, 17.1903 ns/op
WorkloadActual  96: 33554432 op, 607729293.00 ns, 18.1117 ns/op
WorkloadActual  97: 33554432 op, 565490024.00 ns, 16.8529 ns/op
WorkloadActual  98: 33554432 op, 584071824.00 ns, 17.4067 ns/op
WorkloadActual  99: 33554432 op, 558471232.00 ns, 16.6437 ns/op
WorkloadActual  100: 33554432 op, 557145828.00 ns, 16.6042 ns/op

// AfterActualRun
WorkloadResult   1: 33554432 op, 500802794.00 ns, 14.9251 ns/op
WorkloadResult   2: 33554432 op, 525453804.00 ns, 15.6597 ns/op
WorkloadResult   3: 33554432 op, 513392736.00 ns, 15.3003 ns/op
WorkloadResult   4: 33554432 op, 642726432.00 ns, 19.1547 ns/op
WorkloadResult   5: 33554432 op, 568795184.00 ns, 16.9514 ns/op
WorkloadResult   6: 33554432 op, 533370119.00 ns, 15.8957 ns/op
WorkloadResult   7: 33554432 op, 504610309.00 ns, 15.0386 ns/op
WorkloadResult   8: 33554432 op, 572429871.00 ns, 17.0597 ns/op
WorkloadResult   9: 33554432 op, 576918307.00 ns, 17.1935 ns/op
WorkloadResult  10: 33554432 op, 635288713.00 ns, 18.9331 ns/op
WorkloadResult  11: 33554432 op, 505112099.00 ns, 15.0535 ns/op
WorkloadResult  12: 33554432 op, 501412155.00 ns, 14.9432 ns/op
WorkloadResult  13: 33554432 op, 502842586.00 ns, 14.9859 ns/op
WorkloadResult  14: 33554432 op, 508667922.00 ns, 15.1595 ns/op
WorkloadResult  15: 33554432 op, 565473346.00 ns, 16.8524 ns/op
WorkloadResult  16: 33554432 op, 626748556.00 ns, 18.6786 ns/op
WorkloadResult  17: 33554432 op, 569222203.00 ns, 16.9641 ns/op
WorkloadResult  18: 33554432 op, 532735056.00 ns, 15.8767 ns/op
WorkloadResult  19: 33554432 op, 614591588.00 ns, 18.3163 ns/op
WorkloadResult  20: 33554432 op, 559676180.00 ns, 16.6796 ns/op
WorkloadResult  21: 33554432 op, 528913447.00 ns, 15.7628 ns/op
WorkloadResult  22: 33554432 op, 525409842.00 ns, 15.6584 ns/op
WorkloadResult  23: 33554432 op, 535299901.00 ns, 15.9532 ns/op
WorkloadResult  24: 33554432 op, 541259220.00 ns, 16.1308 ns/op
WorkloadResult  25: 33554432 op, 613032268.00 ns, 18.2698 ns/op
WorkloadResult  26: 33554432 op, 538792039.00 ns, 16.0573 ns/op
WorkloadResult  27: 33554432 op, 545713753.00 ns, 16.2635 ns/op
WorkloadResult  28: 33554432 op, 551062304.00 ns, 16.4229 ns/op
WorkloadResult  29: 33554432 op, 525232704.00 ns, 15.6532 ns/op
WorkloadResult  30: 33554432 op, 527940974.00 ns, 15.7339 ns/op
WorkloadResult  31: 33554432 op, 544751278.00 ns, 16.2349 ns/op
WorkloadResult  32: 33554432 op, 522134846.00 ns, 15.5608 ns/op
WorkloadResult  33: 33554432 op, 563491260.00 ns, 16.7933 ns/op
WorkloadResult  34: 33554432 op, 575000105.00 ns, 17.1363 ns/op
WorkloadResult  35: 33554432 op, 588964099.00 ns, 17.5525 ns/op
WorkloadResult  36: 33554432 op, 636285689.00 ns, 18.9628 ns/op
WorkloadResult  37: 33554432 op, 533783737.00 ns, 15.9080 ns/op
WorkloadResult  38: 33554432 op, 549423428.00 ns, 16.3741 ns/op
WorkloadResult  39: 33554432 op, 519688082.00 ns, 15.4879 ns/op
WorkloadResult  40: 33554432 op, 508873457.00 ns, 15.1656 ns/op
WorkloadResult  41: 33554432 op, 529973273.00 ns, 15.7944 ns/op
WorkloadResult  42: 33554432 op, 556416886.00 ns, 16.5825 ns/op
WorkloadResult  43: 33554432 op, 505999672.00 ns, 15.0800 ns/op
WorkloadResult  44: 33554432 op, 504364123.00 ns, 15.0312 ns/op
WorkloadResult  45: 33554432 op, 503401751.00 ns, 15.0025 ns/op
WorkloadResult  46: 33554432 op, 505226326.00 ns, 15.0569 ns/op
WorkloadResult  47: 33554432 op, 511305493.00 ns, 15.2381 ns/op
WorkloadResult  48: 33554432 op, 572274306.00 ns, 17.0551 ns/op
WorkloadResult  49: 33554432 op, 655875738.00 ns, 19.5466 ns/op
WorkloadResult  50: 33554432 op, 607608222.00 ns, 18.1081 ns/op
WorkloadResult  51: 33554432 op, 520711306.00 ns, 15.5184 ns/op
WorkloadResult  52: 33554432 op, 558387864.00 ns, 16.6413 ns/op
WorkloadResult  53: 33554432 op, 539744098.00 ns, 16.0856 ns/op
WorkloadResult  54: 33554432 op, 569629144.00 ns, 16.9763 ns/op
WorkloadResult  55: 33554432 op, 606977777.00 ns, 18.0893 ns/op
WorkloadResult  56: 33554432 op, 592327423.00 ns, 17.6527 ns/op
WorkloadResult  57: 33554432 op, 513583698.00 ns, 15.3060 ns/op
WorkloadResult  58: 33554432 op, 542316777.00 ns, 16.1623 ns/op
WorkloadResult  59: 33554432 op, 556695331.00 ns, 16.5908 ns/op
WorkloadResult  60: 33554432 op, 506103030.00 ns, 15.0830 ns/op
WorkloadResult  61: 33554432 op, 507413384.00 ns, 15.1221 ns/op
WorkloadResult  62: 33554432 op, 512671316.00 ns, 15.2788 ns/op
WorkloadResult  63: 33554432 op, 519539132.00 ns, 15.4835 ns/op
WorkloadResult  64: 33554432 op, 511498858.00 ns, 15.2439 ns/op
WorkloadResult  65: 33554432 op, 512766134.00 ns, 15.2816 ns/op
WorkloadResult  66: 33554432 op, 509690984.00 ns, 15.1900 ns/op
WorkloadResult  67: 33554432 op, 530143418.00 ns, 15.7995 ns/op
WorkloadResult  68: 33554432 op, 523574518.00 ns, 15.6037 ns/op
WorkloadResult  69: 33554432 op, 590665595.00 ns, 17.6032 ns/op
WorkloadResult  70: 33554432 op, 538604247.00 ns, 16.0517 ns/op
WorkloadResult  71: 33554432 op, 552845233.00 ns, 16.4761 ns/op
WorkloadResult  72: 33554432 op, 507929774.00 ns, 15.1375 ns/op
WorkloadResult  73: 33554432 op, 512358649.00 ns, 15.2695 ns/op
WorkloadResult  74: 33554432 op, 509723743.00 ns, 15.1910 ns/op
WorkloadResult  75: 33554432 op, 504654612.00 ns, 15.0399 ns/op
WorkloadResult  76: 33554432 op, 502114443.00 ns, 14.9642 ns/op
WorkloadResult  77: 33554432 op, 503933605.00 ns, 15.0184 ns/op
WorkloadResult  78: 33554432 op, 506732510.00 ns, 15.1018 ns/op
WorkloadResult  79: 33554432 op, 516244002.00 ns, 15.3853 ns/op
WorkloadResult  80: 33554432 op, 506184789.00 ns, 15.0855 ns/op
WorkloadResult  81: 33554432 op, 504543286.00 ns, 15.0366 ns/op
WorkloadResult  82: 33554432 op, 504321633.00 ns, 15.0300 ns/op
WorkloadResult  83: 33554432 op, 513016933.00 ns, 15.2891 ns/op
WorkloadResult  84: 33554432 op, 557123683.00 ns, 16.6036 ns/op
WorkloadResult  85: 33554432 op, 516167365.00 ns, 15.3830 ns/op
WorkloadResult  86: 33554432 op, 548357821.00 ns, 16.3423 ns/op
WorkloadResult  87: 33554432 op, 521835517.00 ns, 15.5519 ns/op
WorkloadResult  88: 33554432 op, 552755467.00 ns, 16.4734 ns/op
WorkloadResult  89: 33554432 op, 510516198.00 ns, 15.2146 ns/op
WorkloadResult  90: 33554432 op, 529097998.00 ns, 15.7683 ns/op
WorkloadResult  91: 33554432 op, 503497406.00 ns, 15.0054 ns/op
WorkloadResult  92: 33554432 op, 502172002.00 ns, 14.9659 ns/op
GC:  0 0 0 816 33554432
Threading:  0 0 33554432

// AfterAll
// Benchmark Process 22712 has exited with code 0.

Mean = 16.079 ns, StdErr = 0.117 ns (0.73%), N = 92, StdDev = 1.127 ns
Min = 14.925 ns, Q1 = 15.184 ns, Median = 15.748 ns, Q3 = 16.613 ns, Max = 19.547 ns
IQR = 1.429 ns, LowerFence = 13.040 ns, UpperFence = 18.757 ns
ConfidenceInterval = [15.680 ns; 16.479 ns] (CI 99.9%), Margin = 0.400 ns (2.48% of Mean)
Skewness = 1.21, Kurtosis = 3.73, MValue = 2.05

// ** Remained 3 (37.5 %) benchmark(s) to run. Estimated finish 2022-10-03 14:18 (0h 1m from now) **
// **************************
// Benchmark: LinqPerformance.Array_Max: net70(Runtime=.NET 7.0)
// *** Execute ***
// Launch: 1 / 1
// Execute: dotnet dbbd0e1b-7597-4575-8128-d4f7a5789f5c.dll --benchmarkName net._7.performance.LinqPerformance.Array_Max --job net70 --benchmarkId 1 in /Users/frank.hsu/Documents/Projects/Test/net.7.performance/src/bin/Release/net6.0/dbbd0e1b-7597-4575-8128-d4f7a5789f5c/bin/Release/net7.0
Failed to set up high priority. Make sure you have the right permissions. Message: Permission denied
// BeforeAnythingElse

// Benchmark Process Environment Information:
// Runtime=.NET 7.0.0 (7.0.22.42610), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: net70

OverheadJitting  1: 1 op, 437580.00 ns, 437.5800 us/op
WorkloadJitting  1: 1 op, 1874798.00 ns, 1.8748 ms/op

OverheadJitting  2: 16 op, 510053.00 ns, 31.8783 us/op
WorkloadJitting  2: 16 op, 508997.00 ns, 31.8123 us/op

WorkloadPilot    1: 16 op, 17144.00 ns, 1.0715 us/op
WorkloadPilot    2: 32 op, 29012.00 ns, 906.6250 ns/op
WorkloadPilot    3: 64 op, 56160.00 ns, 877.5000 ns/op
WorkloadPilot    4: 128 op, 111040.00 ns, 867.5000 ns/op
WorkloadPilot    5: 256 op, 219268.00 ns, 856.5156 ns/op
WorkloadPilot    6: 512 op, 433360.00 ns, 846.4062 ns/op
WorkloadPilot    7: 1024 op, 868055.00 ns, 847.7100 ns/op
WorkloadPilot    8: 2048 op, 1736823.00 ns, 848.0581 ns/op
WorkloadPilot    9: 4096 op, 3482995.00 ns, 850.3406 ns/op
WorkloadPilot   10: 8192 op, 7110456.00 ns, 867.9756 ns/op
WorkloadPilot   11: 16384 op, 12429893.00 ns, 758.6605 ns/op
WorkloadPilot   12: 32768 op, 24413975.00 ns, 745.0554 ns/op
WorkloadPilot   13: 65536 op, 50284480.00 ns, 767.2803 ns/op
WorkloadPilot   14: 131072 op, 22741277.00 ns, 173.5022 ns/op
WorkloadPilot   15: 262144 op, 4352064.00 ns, 16.6018 ns/op
WorkloadPilot   16: 524288 op, 8876198.00 ns, 16.9300 ns/op
WorkloadPilot   17: 1048576 op, 17662668.00 ns, 16.8444 ns/op
WorkloadPilot   18: 2097152 op, 35533586.00 ns, 16.9437 ns/op
WorkloadPilot   19: 4194304 op, 71179177.00 ns, 16.9704 ns/op
WorkloadPilot   20: 8388608 op, 140865540.00 ns, 16.7925 ns/op
WorkloadPilot   21: 16777216 op, 285557653.00 ns, 17.0206 ns/op
WorkloadPilot   22: 33554432 op, 574847723.00 ns, 17.1318 ns/op

OverheadWarmup   1: 33554432 op, 72252079.00 ns, 2.1533 ns/op
OverheadWarmup   2: 33554432 op, 72599035.00 ns, 2.1636 ns/op
OverheadWarmup   3: 33554432 op, 69024576.00 ns, 2.0571 ns/op
OverheadWarmup   4: 33554432 op, 55480385.00 ns, 1.6534 ns/op
OverheadWarmup   5: 33554432 op, 55572113.00 ns, 1.6562 ns/op
OverheadWarmup   6: 33554432 op, 54629972.00 ns, 1.6281 ns/op

OverheadActual   1: 33554432 op, 54780941.00 ns, 1.6326 ns/op
OverheadActual   2: 33554432 op, 54644973.00 ns, 1.6285 ns/op
OverheadActual   3: 33554432 op, 54569445.00 ns, 1.6263 ns/op
OverheadActual   4: 33554432 op, 55699011.00 ns, 1.6600 ns/op
OverheadActual   5: 33554432 op, 55462783.00 ns, 1.6529 ns/op
OverheadActual   6: 33554432 op, 55904965.00 ns, 1.6661 ns/op
OverheadActual   7: 33554432 op, 54609480.00 ns, 1.6275 ns/op
OverheadActual   8: 33554432 op, 55148502.00 ns, 1.6436 ns/op
OverheadActual   9: 33554432 op, 54510628.00 ns, 1.6245 ns/op
OverheadActual  10: 33554432 op, 54862113.00 ns, 1.6350 ns/op
OverheadActual  11: 33554432 op, 54858589.00 ns, 1.6349 ns/op
OverheadActual  12: 33554432 op, 54757117.00 ns, 1.6319 ns/op
OverheadActual  13: 33554432 op, 54569509.00 ns, 1.6263 ns/op
OverheadActual  14: 33554432 op, 54669285.00 ns, 1.6293 ns/op
OverheadActual  15: 33554432 op, 54648790.00 ns, 1.6287 ns/op

WorkloadWarmup   1: 33554432 op, 566037406.00 ns, 16.8692 ns/op
WorkloadWarmup   2: 33554432 op, 567382065.00 ns, 16.9093 ns/op
WorkloadWarmup   3: 33554432 op, 574616095.00 ns, 17.1249 ns/op
WorkloadWarmup   4: 33554432 op, 568441846.00 ns, 16.9409 ns/op
WorkloadWarmup   5: 33554432 op, 569924463.00 ns, 16.9851 ns/op
WorkloadWarmup   6: 33554432 op, 570615575.00 ns, 17.0057 ns/op
WorkloadWarmup   7: 33554432 op, 569684157.00 ns, 16.9779 ns/op

// BeforeActualRun
WorkloadActual   1: 33554432 op, 578342458.00 ns, 17.2359 ns/op
WorkloadActual   2: 33554432 op, 567284885.00 ns, 16.9064 ns/op
WorkloadActual   3: 33554432 op, 568389453.00 ns, 16.9393 ns/op
WorkloadActual   4: 33554432 op, 564968738.00 ns, 16.8374 ns/op
WorkloadActual   5: 33554432 op, 567382245.00 ns, 16.9093 ns/op
WorkloadActual   6: 33554432 op, 568867040.00 ns, 16.9536 ns/op
WorkloadActual   7: 33554432 op, 570928140.00 ns, 17.0150 ns/op
WorkloadActual   8: 33554432 op, 568376592.00 ns, 16.9389 ns/op
WorkloadActual   9: 33554432 op, 577011911.00 ns, 17.1963 ns/op
WorkloadActual  10: 33554432 op, 571777537.00 ns, 17.0403 ns/op
WorkloadActual  11: 33554432 op, 567921616.00 ns, 16.9254 ns/op
WorkloadActual  12: 33554432 op, 568995463.00 ns, 16.9574 ns/op
WorkloadActual  13: 33554432 op, 568777873.00 ns, 16.9509 ns/op
WorkloadActual  14: 33554432 op, 567676793.00 ns, 16.9181 ns/op
WorkloadActual  15: 33554432 op, 567707364.00 ns, 16.9190 ns/op

// AfterActualRun
WorkloadResult   1: 33554432 op, 512527768.00 ns, 15.2745 ns/op
WorkloadResult   2: 33554432 op, 513632336.00 ns, 15.3074 ns/op
WorkloadResult   3: 33554432 op, 510211621.00 ns, 15.2055 ns/op
WorkloadResult   4: 33554432 op, 512625128.00 ns, 15.2774 ns/op
WorkloadResult   5: 33554432 op, 514109923.00 ns, 15.3217 ns/op
WorkloadResult   6: 33554432 op, 516171023.00 ns, 15.3831 ns/op
WorkloadResult   7: 33554432 op, 513619475.00 ns, 15.3071 ns/op
WorkloadResult   8: 33554432 op, 517020420.00 ns, 15.4084 ns/op
WorkloadResult   9: 33554432 op, 513164499.00 ns, 15.2935 ns/op
WorkloadResult  10: 33554432 op, 514238346.00 ns, 15.3255 ns/op
WorkloadResult  11: 33554432 op, 514020756.00 ns, 15.3190 ns/op
WorkloadResult  12: 33554432 op, 512919676.00 ns, 15.2862 ns/op
WorkloadResult  13: 33554432 op, 512950247.00 ns, 15.2871 ns/op
GC:  0 0 0 816 33554432
Threading:  0 0 33554432

// AfterAll
// Benchmark Process 22864 has exited with code 0.

Mean = 15.307 ns, StdErr = 0.014 ns (0.09%), N = 13, StdDev = 0.050 ns
Min = 15.205 ns, Q1 = 15.286 ns, Median = 15.307 ns, Q3 = 15.322 ns, Max = 15.408 ns
IQR = 0.035 ns, LowerFence = 15.233 ns, UpperFence = 15.375 ns
ConfidenceInterval = [15.248 ns; 15.367 ns] (CI 99.9%), Margin = 0.060 ns (0.39% of Mean)
Skewness = 0.2, Kurtosis = 3.04, MValue = 2

// ** Remained 2 (25.0 %) benchmark(s) to run. Estimated finish 2022-10-03 14:18 (0h 0m from now) **
// **************************
// Benchmark: LinqPerformance.Array_Average: net70(Runtime=.NET 7.0)
// *** Execute ***
// Launch: 1 / 1
// Execute: dotnet dbbd0e1b-7597-4575-8128-d4f7a5789f5c.dll --benchmarkName net._7.performance.LinqPerformance.Array_Average --job net70 --benchmarkId 2 in /Users/frank.hsu/Documents/Projects/Test/net.7.performance/src/bin/Release/net6.0/dbbd0e1b-7597-4575-8128-d4f7a5789f5c/bin/Release/net7.0
Failed to set up high priority. Make sure you have the right permissions. Message: Permission denied
// BeforeAnythingElse

// Benchmark Process Environment Information:
// Runtime=.NET 7.0.0 (7.0.22.42610), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: net70

OverheadJitting  1: 1 op, 449181.00 ns, 449.1810 us/op
WorkloadJitting  1: 1 op, 2550563.00 ns, 2.5506 ms/op

OverheadJitting  2: 16 op, 515561.00 ns, 32.2226 us/op
WorkloadJitting  2: 16 op, 502490.00 ns, 31.4056 us/op

WorkloadPilot    1: 16 op, 18792.00 ns, 1.1745 us/op
WorkloadPilot    2: 32 op, 32897.00 ns, 1.0280 us/op
WorkloadPilot    3: 64 op, 62971.00 ns, 983.9219 ns/op
WorkloadPilot    4: 128 op, 124398.00 ns, 971.8594 ns/op
WorkloadPilot    5: 256 op, 244702.00 ns, 955.8672 ns/op
WorkloadPilot    6: 512 op, 489496.00 ns, 956.0469 ns/op
WorkloadPilot    7: 1024 op, 974409.00 ns, 951.5713 ns/op
WorkloadPilot    8: 2048 op, 1949615.00 ns, 951.9604 ns/op
WorkloadPilot    9: 4096 op, 3960611.00 ns, 966.9460 ns/op
WorkloadPilot   10: 8192 op, 7880329.00 ns, 961.9542 ns/op
WorkloadPilot   11: 16384 op, 15731346.00 ns, 960.1652 ns/op
WorkloadPilot   12: 32768 op, 31620471.00 ns, 964.9802 ns/op
WorkloadPilot   13: 65536 op, 65323433.00 ns, 996.7565 ns/op
WorkloadPilot   14: 131072 op, 11282638.00 ns, 86.0797 ns/op
WorkloadPilot   15: 262144 op, 6969394.00 ns, 26.5861 ns/op
WorkloadPilot   16: 524288 op, 14005587.00 ns, 26.7135 ns/op
WorkloadPilot   17: 1048576 op, 28236222.00 ns, 26.9282 ns/op
WorkloadPilot   18: 2097152 op, 56588324.00 ns, 26.9834 ns/op
WorkloadPilot   19: 4194304 op, 111512906.00 ns, 26.5867 ns/op
WorkloadPilot   20: 8388608 op, 223823731.00 ns, 26.6819 ns/op
WorkloadPilot   21: 16777216 op, 456580655.00 ns, 27.2143 ns/op
WorkloadPilot   22: 33554432 op, 899134979.00 ns, 26.7963 ns/op

OverheadWarmup   1: 33554432 op, 81400199.00 ns, 2.4259 ns/op
OverheadWarmup   2: 33554432 op, 81167804.00 ns, 2.4190 ns/op
OverheadWarmup   3: 33554432 op, 67544804.00 ns, 2.0130 ns/op
OverheadWarmup   4: 33554432 op, 56092968.00 ns, 1.6717 ns/op
OverheadWarmup   5: 33554432 op, 56499311.00 ns, 1.6838 ns/op
OverheadWarmup   6: 33554432 op, 55078518.00 ns, 1.6415 ns/op
OverheadWarmup   7: 33554432 op, 55232394.00 ns, 1.6461 ns/op
OverheadWarmup   8: 33554432 op, 55237956.00 ns, 1.6462 ns/op
OverheadWarmup   9: 33554432 op, 55350139.00 ns, 1.6496 ns/op
OverheadWarmup  10: 33554432 op, 55987643.00 ns, 1.6686 ns/op

OverheadActual   1: 33554432 op, 55707434.00 ns, 1.6602 ns/op
OverheadActual   2: 33554432 op, 55516552.00 ns, 1.6545 ns/op
OverheadActual   3: 33554432 op, 55381392.00 ns, 1.6505 ns/op
OverheadActual   4: 33554432 op, 55227643.00 ns, 1.6459 ns/op
OverheadActual   5: 33554432 op, 55560103.00 ns, 1.6558 ns/op
OverheadActual   6: 33554432 op, 55081261.00 ns, 1.6415 ns/op
OverheadActual   7: 33554432 op, 55170709.00 ns, 1.6442 ns/op
OverheadActual   8: 33554432 op, 55495194.00 ns, 1.6539 ns/op
OverheadActual   9: 33554432 op, 55271982.00 ns, 1.6472 ns/op
OverheadActual  10: 33554432 op, 55291181.00 ns, 1.6478 ns/op
OverheadActual  11: 33554432 op, 55022545.00 ns, 1.6398 ns/op
OverheadActual  12: 33554432 op, 55350022.00 ns, 1.6496 ns/op
OverheadActual  13: 33554432 op, 55332727.00 ns, 1.6490 ns/op
OverheadActual  14: 33554432 op, 55174245.00 ns, 1.6443 ns/op
OverheadActual  15: 33554432 op, 55260759.00 ns, 1.6469 ns/op

WorkloadWarmup   1: 33554432 op, 898495994.00 ns, 26.7773 ns/op
WorkloadWarmup   2: 33554432 op, 897812321.00 ns, 26.7569 ns/op
WorkloadWarmup   3: 33554432 op, 907934204.00 ns, 27.0585 ns/op
WorkloadWarmup   4: 33554432 op, 902475674.00 ns, 26.8959 ns/op
WorkloadWarmup   5: 33554432 op, 928043500.00 ns, 27.6579 ns/op
WorkloadWarmup   6: 33554432 op, 896254119.00 ns, 26.7105 ns/op

// BeforeActualRun
WorkloadActual   1: 33554432 op, 898254377.00 ns, 26.7701 ns/op
WorkloadActual   2: 33554432 op, 903534459.00 ns, 26.9274 ns/op
WorkloadActual   3: 33554432 op, 909549682.00 ns, 27.1067 ns/op
WorkloadActual   4: 33554432 op, 917165277.00 ns, 27.3337 ns/op
WorkloadActual   5: 33554432 op, 900636444.00 ns, 26.8411 ns/op
WorkloadActual   6: 33554432 op, 900480426.00 ns, 26.8364 ns/op
WorkloadActual   7: 33554432 op, 901271954.00 ns, 26.8600 ns/op
WorkloadActual   8: 33554432 op, 903393228.00 ns, 26.9232 ns/op
WorkloadActual   9: 33554432 op, 896345845.00 ns, 26.7132 ns/op
WorkloadActual  10: 33554432 op, 893702771.00 ns, 26.6344 ns/op
WorkloadActual  11: 33554432 op, 894910103.00 ns, 26.6704 ns/op
WorkloadActual  12: 33554432 op, 897303738.00 ns, 26.7417 ns/op
WorkloadActual  13: 33554432 op, 897440937.00 ns, 26.7458 ns/op
WorkloadActual  14: 33554432 op, 908030495.00 ns, 27.0614 ns/op
WorkloadActual  15: 33554432 op, 896835823.00 ns, 26.7278 ns/op

// AfterActualRun
WorkloadResult   1: 33554432 op, 842963196.00 ns, 25.1223 ns/op
WorkloadResult   2: 33554432 op, 848243278.00 ns, 25.2796 ns/op
WorkloadResult   3: 33554432 op, 854258501.00 ns, 25.4589 ns/op
WorkloadResult   4: 33554432 op, 845345263.00 ns, 25.1933 ns/op
WorkloadResult   5: 33554432 op, 845189245.00 ns, 25.1886 ns/op
WorkloadResult   6: 33554432 op, 845980773.00 ns, 25.2122 ns/op
WorkloadResult   7: 33554432 op, 848102047.00 ns, 25.2754 ns/op
WorkloadResult   8: 33554432 op, 841054664.00 ns, 25.0654 ns/op
WorkloadResult   9: 33554432 op, 838411590.00 ns, 24.9866 ns/op
WorkloadResult  10: 33554432 op, 839618922.00 ns, 25.0226 ns/op
WorkloadResult  11: 33554432 op, 842012557.00 ns, 25.0939 ns/op
WorkloadResult  12: 33554432 op, 842149756.00 ns, 25.0980 ns/op
WorkloadResult  13: 33554432 op, 852739314.00 ns, 25.4136 ns/op
WorkloadResult  14: 33554432 op, 841544642.00 ns, 25.0800 ns/op
GC:  0 0 0 816 33554432
Threading:  0 0 33554432

// AfterAll
// Benchmark Process 22895 has exited with code 0.

Mean = 25.178 ns, StdErr = 0.037 ns (0.15%), N = 14, StdDev = 0.140 ns
Min = 24.987 ns, Q1 = 25.083 ns, Median = 25.155 ns, Q3 = 25.260 ns, Max = 25.459 ns
IQR = 0.176 ns, LowerFence = 24.819 ns, UpperFence = 25.524 ns
ConfidenceInterval = [25.020 ns; 25.336 ns] (CI 99.9%), Margin = 0.158 ns (0.63% of Mean)
Skewness = 0.6, Kurtosis = 2.18, MValue = 2

// ** Remained 1 (12.5 %) benchmark(s) to run. Estimated finish 2022-10-03 14:18 (0h 0m from now) **
// **************************
// Benchmark: LinqPerformance.Array_Sum: net70(Runtime=.NET 7.0)
// *** Execute ***
// Launch: 1 / 1
// Execute: dotnet dbbd0e1b-7597-4575-8128-d4f7a5789f5c.dll --benchmarkName net._7.performance.LinqPerformance.Array_Sum --job net70 --benchmarkId 3 in /Users/frank.hsu/Documents/Projects/Test/net.7.performance/src/bin/Release/net6.0/dbbd0e1b-7597-4575-8128-d4f7a5789f5c/bin/Release/net7.0
Failed to set up high priority. Make sure you have the right permissions. Message: Permission denied
// BeforeAnythingElse

// Benchmark Process Environment Information:
// Runtime=.NET 7.0.0 (7.0.22.42610), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: net70

OverheadJitting  1: 1 op, 430462.00 ns, 430.4620 us/op
WorkloadJitting  1: 1 op, 1456545.00 ns, 1.4565 ms/op

OverheadJitting  2: 16 op, 539489.00 ns, 33.7181 us/op
WorkloadJitting  2: 16 op, 513047.00 ns, 32.0654 us/op

WorkloadPilot    1: 16 op, 12383.00 ns, 773.9375 ns/op
WorkloadPilot    2: 32 op, 21802.00 ns, 681.3125 ns/op
WorkloadPilot    3: 64 op, 41723.00 ns, 651.9219 ns/op
WorkloadPilot    4: 128 op, 115908.00 ns, 905.5312 ns/op
WorkloadPilot    5: 256 op, 157307.00 ns, 614.4805 ns/op
WorkloadPilot    6: 512 op, 361946.00 ns, 706.9258 ns/op
WorkloadPilot    7: 1024 op, 645272.00 ns, 630.1484 ns/op
WorkloadPilot    8: 2048 op, 1291590.00 ns, 630.6592 ns/op
WorkloadPilot    9: 4096 op, 2450210.00 ns, 598.1958 ns/op
WorkloadPilot   10: 8192 op, 4407200.00 ns, 537.9883 ns/op
WorkloadPilot   11: 16384 op, 8792984.00 ns, 536.6812 ns/op
WorkloadPilot   12: 32768 op, 17669188.00 ns, 539.2208 ns/op
WorkloadPilot   13: 65536 op, 35559279.00 ns, 542.5915 ns/op
WorkloadPilot   14: 131072 op, 58930418.00 ns, 449.6034 ns/op
WorkloadPilot   15: 262144 op, 12098329.00 ns, 46.1515 ns/op
WorkloadPilot   16: 524288 op, 23782772.00 ns, 45.3620 ns/op
WorkloadPilot   17: 1048576 op, 47545328.00 ns, 45.3428 ns/op
WorkloadPilot   18: 2097152 op, 95110652.00 ns, 45.3523 ns/op
WorkloadPilot   19: 4194304 op, 192698166.00 ns, 45.9428 ns/op
WorkloadPilot   20: 8388608 op, 383777845.00 ns, 45.7499 ns/op
WorkloadPilot   21: 16777216 op, 772279818.00 ns, 46.0315 ns/op

OverheadWarmup   1: 16777216 op, 36146824.00 ns, 2.1545 ns/op
OverheadWarmup   2: 16777216 op, 35978564.00 ns, 2.1445 ns/op
OverheadWarmup   3: 16777216 op, 36291740.00 ns, 2.1632 ns/op
OverheadWarmup   4: 16777216 op, 36024906.00 ns, 2.1473 ns/op
OverheadWarmup   5: 16777216 op, 37442374.00 ns, 2.2317 ns/op
OverheadWarmup   6: 16777216 op, 39093672.00 ns, 2.3302 ns/op
OverheadWarmup   7: 16777216 op, 39552263.00 ns, 2.3575 ns/op
OverheadWarmup   8: 16777216 op, 36408628.00 ns, 2.1701 ns/op

OverheadActual   1: 16777216 op, 27393112.00 ns, 1.6328 ns/op
OverheadActual   2: 16777216 op, 27505490.00 ns, 1.6395 ns/op
OverheadActual   3: 16777216 op, 27430363.00 ns, 1.6350 ns/op
OverheadActual   4: 16777216 op, 28427824.00 ns, 1.6944 ns/op
OverheadActual   5: 16777216 op, 28579223.00 ns, 1.7035 ns/op
OverheadActual   6: 16777216 op, 28458255.00 ns, 1.6962 ns/op
OverheadActual   7: 16777216 op, 28010178.00 ns, 1.6695 ns/op
OverheadActual   8: 16777216 op, 27571570.00 ns, 1.6434 ns/op
OverheadActual   9: 16777216 op, 27453821.00 ns, 1.6364 ns/op
OverheadActual  10: 16777216 op, 27577465.00 ns, 1.6437 ns/op
OverheadActual  11: 16777216 op, 27591346.00 ns, 1.6446 ns/op
OverheadActual  12: 16777216 op, 27280969.00 ns, 1.6261 ns/op
OverheadActual  13: 16777216 op, 27500068.00 ns, 1.6391 ns/op
OverheadActual  14: 16777216 op, 27648532.00 ns, 1.6480 ns/op
OverheadActual  15: 16777216 op, 29630307.00 ns, 1.7661 ns/op

WorkloadWarmup   1: 16777216 op, 934905010.00 ns, 55.7247 ns/op
WorkloadWarmup   2: 16777216 op, 843218681.00 ns, 50.2597 ns/op
WorkloadWarmup   3: 16777216 op, 767436082.00 ns, 45.7428 ns/op
WorkloadWarmup   4: 16777216 op, 770117576.00 ns, 45.9026 ns/op
WorkloadWarmup   5: 16777216 op, 765707235.00 ns, 45.6397 ns/op
WorkloadWarmup   6: 16777216 op, 775399475.00 ns, 46.2174 ns/op
WorkloadWarmup   7: 16777216 op, 768595689.00 ns, 45.8119 ns/op

// BeforeActualRun
WorkloadActual   1: 16777216 op, 766886193.00 ns, 45.7100 ns/op
WorkloadActual   2: 16777216 op, 766615227.00 ns, 45.6938 ns/op
WorkloadActual   3: 16777216 op, 769196068.00 ns, 45.8477 ns/op
WorkloadActual   4: 16777216 op, 768912867.00 ns, 45.8308 ns/op
WorkloadActual   5: 16777216 op, 768383311.00 ns, 45.7992 ns/op
WorkloadActual   6: 16777216 op, 776686496.00 ns, 46.2941 ns/op
WorkloadActual   7: 16777216 op, 768069235.00 ns, 45.7805 ns/op
WorkloadActual   8: 16777216 op, 770808429.00 ns, 45.9438 ns/op
WorkloadActual   9: 16777216 op, 767144006.00 ns, 45.7253 ns/op
WorkloadActual  10: 16777216 op, 769807931.00 ns, 45.8841 ns/op
WorkloadActual  11: 16777216 op, 767916478.00 ns, 45.7714 ns/op
WorkloadActual  12: 16777216 op, 774558237.00 ns, 46.1673 ns/op
WorkloadActual  13: 16777216 op, 766098728.00 ns, 45.6630 ns/op
WorkloadActual  14: 16777216 op, 790399913.00 ns, 47.1115 ns/op
WorkloadActual  15: 16777216 op, 767252573.00 ns, 45.7318 ns/op

// AfterActualRun
WorkloadResult   1: 16777216 op, 739308728.00 ns, 44.0662 ns/op
WorkloadResult   2: 16777216 op, 739037762.00 ns, 44.0501 ns/op
WorkloadResult   3: 16777216 op, 741618603.00 ns, 44.2039 ns/op
WorkloadResult   4: 16777216 op, 741335402.00 ns, 44.1870 ns/op
WorkloadResult   5: 16777216 op, 740805846.00 ns, 44.1555 ns/op
WorkloadResult   6: 16777216 op, 740491770.00 ns, 44.1367 ns/op
WorkloadResult   7: 16777216 op, 743230964.00 ns, 44.3000 ns/op
WorkloadResult   8: 16777216 op, 739566541.00 ns, 44.0816 ns/op
WorkloadResult   9: 16777216 op, 742230466.00 ns, 44.2404 ns/op
WorkloadResult  10: 16777216 op, 740339013.00 ns, 44.1276 ns/op
WorkloadResult  11: 16777216 op, 746980772.00 ns, 44.5235 ns/op
WorkloadResult  12: 16777216 op, 738521263.00 ns, 44.0193 ns/op
WorkloadResult  13: 16777216 op, 739675108.00 ns, 44.0881 ns/op
GC:  0 0 0 816 16777216
Threading:  0 0 16777216

// AfterAll
// Benchmark Process 22947 has exited with code 0.

Mean = 44.168 ns, StdErr = 0.037 ns (0.08%), N = 13, StdDev = 0.133 ns
Min = 44.019 ns, Q1 = 44.082 ns, Median = 44.137 ns, Q3 = 44.204 ns, Max = 44.524 ns
IQR = 0.122 ns, LowerFence = 43.898 ns, UpperFence = 44.387 ns
ConfidenceInterval = [44.008 ns; 44.328 ns] (CI 99.9%), Margin = 0.160 ns (0.36% of Mean)
Skewness = 1.32, Kurtosis = 4.18, MValue = 2

// ** Remained 0 (0.0 %) benchmark(s) to run. Estimated finish 2022-10-03 14:18 (0h 0m from now) **
// ***** BenchmarkRunner: Finish  *****

// * Export *
  BenchmarkDotNet.Artifacts/results/net._7.performance.LinqPerformance-report.csv
  BenchmarkDotNet.Artifacts/results/net._7.performance.LinqPerformance-report-github.md
  BenchmarkDotNet.Artifacts/results/net._7.performance.LinqPerformance-report.html
  BenchmarkDotNet.Artifacts/results/net._7.performance.LinqPerformance-measurements.csv
  BenchmarkDotNet.Artifacts/results/BuildPlots.R
  BenchmarkDotNet.Artifacts/results/*.png

// * Detailed results *
LinqPerformance.Array_Min: net60(Runtime=.NET 6.0)
Runtime = .NET 6.0.1 (6.0.121.56705), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 540.228 ns, StdErr = 2.533 ns (0.47%), N = 23, StdDev = 12.148 ns
Min = 530.215 ns, Q1 = 531.869 ns, Median = 535.845 ns, Q3 = 542.414 ns, Max = 579.680 ns
IQR = 10.545 ns, LowerFence = 516.051 ns, UpperFence = 558.232 ns
ConfidenceInterval = [530.622 ns; 549.833 ns] (CI 99.9%), Margin = 9.606 ns (1.78% of Mean)
Skewness = 1.71, Kurtosis = 5.5, MValue = 2
-------------------- Histogram --------------------
[529.289 ns ; 540.502 ns) | @@@@@@@@@@@@@@@
[540.502 ns ; 552.623 ns) | @@@@@
[552.623 ns ; 564.669 ns) | @@
[564.669 ns ; 585.287 ns) | @
---------------------------------------------------

LinqPerformance.Array_Max: net60(Runtime=.NET 6.0)
Runtime = .NET 6.0.1 (6.0.121.56705), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 538.925 ns, StdErr = 0.837 ns (0.16%), N = 14, StdDev = 3.132 ns
Min = 534.775 ns, Q1 = 536.997 ns, Median = 538.469 ns, Q3 = 540.494 ns, Max = 545.750 ns
IQR = 3.497 ns, LowerFence = 531.751 ns, UpperFence = 545.740 ns
ConfidenceInterval = [535.393 ns; 542.458 ns] (CI 99.9%), Margin = 3.533 ns (0.66% of Mean)
Skewness = 0.57, Kurtosis = 2.35, MValue = 2
-------------------- Histogram --------------------
[533.070 ns ; 547.456 ns) | @@@@@@@@@@@@@@
---------------------------------------------------

LinqPerformance.Array_Average: net60(Runtime=.NET 6.0)
Runtime = .NET 6.0.1 (6.0.121.56705), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 508.009 ns, StdErr = 0.723 ns (0.14%), N = 12, StdDev = 2.506 ns
Min = 505.858 ns, Q1 = 506.281 ns, Median = 507.079 ns, Q3 = 509.410 ns, Max = 514.059 ns
IQR = 3.130 ns, LowerFence = 501.586 ns, UpperFence = 514.104 ns
ConfidenceInterval = [504.799 ns; 511.218 ns] (CI 99.9%), Margin = 3.209 ns (0.63% of Mean)
Skewness = 1.1, Kurtosis = 3.11, MValue = 2
-------------------- Histogram --------------------
[504.422 ns ; 515.495 ns) | @@@@@@@@@@@@
---------------------------------------------------

LinqPerformance.Array_Sum: net60(Runtime=.NET 6.0)
Runtime = .NET 6.0.1 (6.0.121.56705), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 481.133 ns, StdErr = 0.377 ns (0.08%), N = 14, StdDev = 1.409 ns
Min = 478.722 ns, Q1 = 480.170 ns, Median = 481.130 ns, Q3 = 481.993 ns, Max = 483.861 ns
IQR = 1.823 ns, LowerFence = 477.435 ns, UpperFence = 484.728 ns
ConfidenceInterval = [479.543 ns; 482.723 ns] (CI 99.9%), Margin = 1.590 ns (0.33% of Mean)
Skewness = 0.08, Kurtosis = 2.15, MValue = 2
-------------------- Histogram --------------------
[477.954 ns ; 484.629 ns) | @@@@@@@@@@@@@@
---------------------------------------------------

LinqPerformance.Array_Min: net70(Runtime=.NET 7.0)
Runtime = .NET 7.0.0 (7.0.22.42610), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 16.079 ns, StdErr = 0.117 ns (0.73%), N = 92, StdDev = 1.127 ns
Min = 14.925 ns, Q1 = 15.184 ns, Median = 15.748 ns, Q3 = 16.613 ns, Max = 19.547 ns
IQR = 1.429 ns, LowerFence = 13.040 ns, UpperFence = 18.757 ns
ConfidenceInterval = [15.680 ns; 16.479 ns] (CI 99.9%), Margin = 0.400 ns (2.48% of Mean)
Skewness = 1.21, Kurtosis = 3.73, MValue = 2.05
-------------------- Histogram --------------------
[14.915 ns ; 15.571 ns) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[15.571 ns ; 16.286 ns) | @@@@@@@@@@@@@@@@@@@@
[16.286 ns ; 16.987 ns) | @@@@@@@@@@@@@@@
[16.987 ns ; 17.681 ns) | @@@@@@@
[17.681 ns ; 18.056 ns) | 
[18.056 ns ; 18.712 ns) | @@@@@
[18.712 ns ; 19.567 ns) | @@@@
---------------------------------------------------

LinqPerformance.Array_Max: net70(Runtime=.NET 7.0)
Runtime = .NET 7.0.0 (7.0.22.42610), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 15.307 ns, StdErr = 0.014 ns (0.09%), N = 13, StdDev = 0.050 ns
Min = 15.205 ns, Q1 = 15.286 ns, Median = 15.307 ns, Q3 = 15.322 ns, Max = 15.408 ns
IQR = 0.035 ns, LowerFence = 15.233 ns, UpperFence = 15.375 ns
ConfidenceInterval = [15.248 ns; 15.367 ns] (CI 99.9%), Margin = 0.060 ns (0.39% of Mean)
Skewness = 0.2, Kurtosis = 3.04, MValue = 2
-------------------- Histogram --------------------
[15.178 ns ; 15.436 ns) | @@@@@@@@@@@@@
---------------------------------------------------

LinqPerformance.Array_Average: net70(Runtime=.NET 7.0)
Runtime = .NET 7.0.0 (7.0.22.42610), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 25.178 ns, StdErr = 0.037 ns (0.15%), N = 14, StdDev = 0.140 ns
Min = 24.987 ns, Q1 = 25.083 ns, Median = 25.155 ns, Q3 = 25.260 ns, Max = 25.459 ns
IQR = 0.176 ns, LowerFence = 24.819 ns, UpperFence = 25.524 ns
ConfidenceInterval = [25.020 ns; 25.336 ns] (CI 99.9%), Margin = 0.158 ns (0.63% of Mean)
Skewness = 0.6, Kurtosis = 2.18, MValue = 2
-------------------- Histogram --------------------
[24.910 ns ; 25.535 ns) | @@@@@@@@@@@@@@
---------------------------------------------------

LinqPerformance.Array_Sum: net70(Runtime=.NET 7.0)
Runtime = .NET 7.0.0 (7.0.22.42610), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 44.168 ns, StdErr = 0.037 ns (0.08%), N = 13, StdDev = 0.133 ns
Min = 44.019 ns, Q1 = 44.082 ns, Median = 44.137 ns, Q3 = 44.204 ns, Max = 44.524 ns
IQR = 0.122 ns, LowerFence = 43.898 ns, UpperFence = 44.387 ns
ConfidenceInterval = [44.008 ns; 44.328 ns] (CI 99.9%), Margin = 0.160 ns (0.36% of Mean)
Skewness = 1.32, Kurtosis = 4.18, MValue = 2
-------------------- Histogram --------------------
[43.945 ns ; 44.598 ns) | @@@@@@@@@@@@@
---------------------------------------------------

// * Summary *

BenchmarkDotNet=v0.13.2, OS=macOS Monterey 12.6 (21G115) [Darwin 21.6.0]
Intel Core i7-8850H CPU 2.60GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK=7.0.100-rc.1.22431.12
  [Host] : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT AVX2
  net60  : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT AVX2
  net70  : .NET 7.0.0 (7.0.22.42610), X64 RyuJIT AVX2


|        Method |   Job |  Runtime |      Mean |    Error |    StdDev |    Median | Allocated |
|-------------- |------ |--------- |----------:|---------:|----------:|----------:|----------:|
|     Array_Min | net60 | .NET 6.0 | 540.23 ns | 9.606 ns | 12.148 ns | 535.85 ns |      32 B |
|     Array_Max | net60 | .NET 6.0 | 538.93 ns | 3.533 ns |  3.132 ns | 538.47 ns |      32 B |
| Array_Average | net60 | .NET 6.0 | 508.01 ns | 3.209 ns |  2.506 ns | 507.08 ns |      32 B |
|     Array_Sum | net60 | .NET 6.0 | 481.13 ns | 1.590 ns |  1.409 ns | 481.13 ns |      32 B |
|     Array_Min | net70 | .NET 7.0 |  16.08 ns | 0.400 ns |  1.127 ns |  15.75 ns |         - |
|     Array_Max | net70 | .NET 7.0 |  15.31 ns | 0.060 ns |  0.050 ns |  15.31 ns |         - |
| Array_Average | net70 | .NET 7.0 |  25.18 ns | 0.158 ns |  0.140 ns |  25.16 ns |         - |
|     Array_Sum | net70 | .NET 7.0 |  44.17 ns | 0.160 ns |  0.133 ns |  44.14 ns |         - |

// * Hints *
Outliers
  LinqPerformance.Array_Min: net60     -> 4 outliers were removed (592.80 ns..625.34 ns)
  LinqPerformance.Array_Max: net60     -> 1 outlier  was  removed (549.71 ns)
  LinqPerformance.Array_Average: net60 -> 3 outliers were removed (528.16 ns..655.61 ns)
  LinqPerformance.Array_Sum: net60     -> 1 outlier  was  removed (488.34 ns)
  LinqPerformance.Array_Min: net70     -> 8 outliers were removed (21.28 ns..22.89 ns)
  LinqPerformance.Array_Max: net70     -> 2 outliers were removed (17.20 ns, 17.24 ns)
  LinqPerformance.Array_Average: net70 -> 1 outlier  was  removed (27.33 ns)
  LinqPerformance.Array_Sum: net70     -> 2 outliers were removed (46.29 ns, 47.11 ns)
// * Config Issues *

// * Warnings *
Configuration
  Summary -> The CsvMeasurementsExporter is already present in the configuration. There may be unexpected results of RPlotExporter.

// * Legends *
  Mean      : Arithmetic mean of all measurements
  Error     : Half of 99.9% confidence interval
  StdDev    : Standard deviation of all measurements
  Median    : Value separating the higher half of all measurements (50th percentile)
  Allocated : Allocated memory per single operation (managed only, inclusive, 1KB = 1024B)
  1 ns      : 1 Nanosecond (0.000000001 sec)

// * Diagnostic Output - MemoryDiagnoser *


// ***** BenchmarkRunner: End *****
Run time: 00:03:12 (192.61 sec), executed benchmarks: 8

Global total time: 00:03:49 (229.22 sec), executed benchmarks: 8
// * Artifacts cleanup *
