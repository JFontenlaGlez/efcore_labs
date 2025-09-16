// AfterAll
// Benchmark Process 25148 has exited with code 0.

Mean = 207.712 ms, StdErr = 1.714 ms (0.83%), N = 96, StdDev = 16.793 ms
Min = 178.632 ms, Q1 = 194.218 ms, Median = 205.725 ms, Q3 = 219.012 ms, Max = 255.605 ms
IQR = 24.794 ms, LowerFence = 157.028 ms, UpperFence = 256.203 ms
ConfidenceInterval = [201.892 ms; 213.533 ms] (CI 99.9%), Margin = 5.820 ms (2.80% of Mean)
Skewness = 0.71, Kurtosis = 3.01, MValue = 2.55

// ** Remained 0 (0,0 %) benchmark(s) to run. Estimated finish 2025-09-09 22:36 (0h 0m from now) **
Successfully reverted power plan (GUID: 381b4222-f694-41f0-9685-ff5bb260df2e FriendlyName: Equilibrado)
// ***** BenchmarkRunner: Finish  *****

// * Export *
  BenchmarkDotNet.Artifacts\results\EfCore.Benchmarks.QueryBenchmarks-report.csv
  BenchmarkDotNet.Artifacts\results\EfCore.Benchmarks.QueryBenchmarks-report-github.md
  BenchmarkDotNet.Artifacts\results\EfCore.Benchmarks.QueryBenchmarks-report.html

// * Detailed results *
QueryBenchmarks.ProjectionDto: DefaultJob [Take=50]
Runtime = .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 3.146 ms, StdErr = 0.088 ms (2.80%), N = 90, StdDev = 0.834 ms
Min = 2.341 ms, Q1 = 2.597 ms, Median = 2.790 ms, Q3 = 3.401 ms, Max = 5.442 ms
IQR = 0.804 ms, LowerFence = 1.392 ms, UpperFence = 4.607 ms
ConfidenceInterval = [2.847 ms; 3.445 ms] (CI 99.9%), Margin = 0.299 ms (9.51% of Mean)
Skewness = 1.43, Kurtosis = 3.85, MValue = 2.4
-------------------- Histogram --------------------
[2.096 ms ; 2.515 ms) | @@@@@@@@@@@
[2.515 ms ; 3.004 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[3.004 ms ; 3.514 ms) | @@@@@@@@@@
[3.514 ms ; 4.034 ms) | @@@@@@@
[4.034 ms ; 4.266 ms) |
[4.266 ms ; 4.754 ms) | @@@@@
[4.754 ms ; 4.972 ms) | @
[4.972 ms ; 5.461 ms) | @@@@@@@
---------------------------------------------------

QueryBenchmarks.ProjectionDtoCompiled: DefaultJob [Take=50]
Runtime = .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 3.156 ms, StdErr = 0.118 ms (3.74%), N = 98, StdDev = 1.168 ms
Min = 2.084 ms, Q1 = 2.348 ms, Median = 2.585 ms, Q3 = 3.757 ms, Max = 6.213 ms
IQR = 1.408 ms, LowerFence = 0.236 ms, UpperFence = 5.869 ms
ConfidenceInterval = [2.755 ms; 3.556 ms] (CI 99.9%), Margin = 0.400 ms (12.69% of Mean)
Skewness = 1.22, Kurtosis = 3.16, MValue = 2.32
-------------------- Histogram --------------------
[2.070 ms ; 2.735 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[2.735 ms ; 3.382 ms) | @@@@@@@@@@@@@
[3.382 ms ; 4.105 ms) | @@@@@
[4.105 ms ; 4.967 ms) | @@@@@@@@@@
[4.967 ms ; 5.632 ms) | @@@@@@@@
[5.632 ms ; 6.306 ms) | @@@@@
---------------------------------------------------

QueryBenchmarks.SplitQuery: DefaultJob [Take=50]
Runtime = .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 4.885 ms, StdErr = 0.110 ms (2.26%), N = 100, StdDev = 1.103 ms
Min = 3.434 ms, Q1 = 3.884 ms, Median = 4.844 ms, Q3 = 5.567 ms, Max = 8.024 ms
IQR = 1.683 ms, LowerFence = 1.359 ms, UpperFence = 8.092 ms
ConfidenceInterval = [4.511 ms; 5.259 ms] (CI 99.9%), Margin = 0.374 ms (7.66% of Mean)
Skewness = 0.63, Kurtosis = 2.81, MValue = 3.27
-------------------- Histogram --------------------
[3.430 ms ; 4.054 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[4.054 ms ; 4.480 ms) | @@@@@@@
[4.480 ms ; 5.139 ms) | @@@@@@@@@@@@@@@@@@
[5.139 ms ; 5.763 ms) | @@@@@@@@@@@@@@@@@@@@@@@@
[5.763 ms ; 6.512 ms) | @@@@@@@@@@@
[6.512 ms ; 7.179 ms) | @@@
[7.179 ms ; 7.424 ms) |
[7.424 ms ; 8.048 ms) | @@@@
---------------------------------------------------

QueryBenchmarks.NoTrackingIdentityResolution: DefaultJob [Take=50]
Runtime = .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 9.020 ms, StdErr = 0.198 ms (2.20%), N = 100, StdDev = 1.980 ms
Min = 6.836 ms, Q1 = 7.325 ms, Median = 8.384 ms, Q3 = 10.249 ms, Max = 14.184 ms
IQR = 2.924 ms, LowerFence = 2.939 ms, UpperFence = 14.635 ms
ConfidenceInterval = [8.348 ms; 9.691 ms] (CI 99.9%), Margin = 0.672 ms (7.45% of Mean)
Skewness = 0.83, Kurtosis = 2.5, MValue = 2.23
-------------------- Histogram --------------------
[ 6.276 ms ;  6.881 ms) | @
[ 6.881 ms ;  8.000 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[ 8.000 ms ;  9.091 ms) | @@@@@@@@@@@@@@@@
[ 9.091 ms ; 10.280 ms) | @@@@@@@@@@@@@@
[10.280 ms ; 11.660 ms) | @@@@@@@@@@@@@
[11.660 ms ; 12.497 ms) | @@@
[12.497 ms ; 13.617 ms) | @@@@@@@@
[13.617 ms ; 14.744 ms) | @
---------------------------------------------------

QueryBenchmarks.BaselineTrackingInclude: DefaultJob [Take=50]
Runtime = .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 151.915 ms, StdErr = 1.365 ms (0.90%), N = 96, StdDev = 13.374 ms
Min = 134.921 ms, Q1 = 142.887 ms, Median = 146.386 ms, Q3 = 158.265 ms, Max = 188.658 ms
IQR = 15.377 ms, LowerFence = 119.821 ms, UpperFence = 181.331 ms
ConfidenceInterval = [147.280 ms; 156.550 ms] (CI 99.9%), Margin = 4.635 ms (3.05% of Mean)
Skewness = 1.12, Kurtosis = 3.25, MValue = 2.19
-------------------- Histogram --------------------
[131.088 ms ; 140.141 ms) | @@@@@@@@@
[140.141 ms ; 147.808 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[147.808 ms ; 157.458 ms) | @@@@@@@@@@@@@@@@
[157.458 ms ; 165.761 ms) | @@@@@@
[165.761 ms ; 173.428 ms) | @@@@@@@@@@
[173.428 ms ; 183.694 ms) | @@@@@@
[183.694 ms ; 192.492 ms) | @@@
---------------------------------------------------

QueryBenchmarks.AsNoTracking: DefaultJob [Take=50]
Runtime = .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 153.712 ms, StdErr = 1.821 ms (1.18%), N = 85, StdDev = 16.789 ms
Min = 133.785 ms, Q1 = 141.852 ms, Median = 148.572 ms, Q3 = 158.185 ms, Max = 221.132 ms
IQR = 16.333 ms, LowerFence = 117.353 ms, UpperFence = 182.684 ms
ConfidenceInterval = [147.502 ms; 159.922 ms] (CI 99.9%), Margin = 6.210 ms (4.04% of Mean)
Skewness = 1.48, Kurtosis = 5.15, MValue = 2.32
-------------------- Histogram --------------------
[128.773 ms ; 138.986 ms) | @@@@@@@@@
[138.986 ms ; 149.009 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[149.009 ms ; 158.740 ms) | @@@@@@@@@@@@@@@@@@@
[158.740 ms ; 163.786 ms) | @@
[163.786 ms ; 173.675 ms) | @@@@@
[173.675 ms ; 183.698 ms) | @@@@@@@@@
[183.698 ms ; 194.871 ms) | @@
[194.871 ms ; 204.553 ms) | @
[204.553 ms ; 216.120 ms) |
[216.120 ms ; 226.143 ms) | @
---------------------------------------------------

QueryBenchmarks.AggregateNaive: DefaultJob [Take=50]
Runtime = .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 226.456 ms, StdErr = 3.456 ms (1.53%), N = 96, StdDev = 33.862 ms
Min = 182.341 ms, Q1 = 202.491 ms, Median = 213.842 ms, Q3 = 246.136 ms, Max = 321.533 ms
IQR = 43.645 ms, LowerFence = 137.023 ms, UpperFence = 311.603 ms
ConfidenceInterval = [214.719 ms; 238.192 ms] (CI 99.9%), Margin = 11.736 ms (5.18% of Mean)
Skewness = 0.86, Kurtosis = 2.73, MValue = 2.88
-------------------- Histogram --------------------
[179.476 ms ; 198.369 ms) | @@@@@@@@@@@@@@@@@@
[198.369 ms ; 217.782 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[217.782 ms ; 226.487 ms) | @@@
[226.487 ms ; 245.899 ms) | @@@@@@@@@@@@@@@@@
[245.899 ms ; 266.828 ms) | @@@@@@@@@
[266.828 ms ; 291.546 ms) | @@@@@@@@@@
[291.546 ms ; 309.686 ms) | @@@@
[309.686 ms ; 331.239 ms) | @
---------------------------------------------------

QueryBenchmarks.AggregateServer: DefaultJob [Take=50]
Runtime = .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 279.978 ms, StdErr = 1.727 ms (0.62%), N = 93, StdDev = 16.655 ms
Min = 249.354 ms, Q1 = 267.180 ms, Median = 278.102 ms, Q3 = 292.085 ms, Max = 318.524 ms
IQR = 24.905 ms, LowerFence = 229.823 ms, UpperFence = 329.442 ms
ConfidenceInterval = [274.108 ms; 285.849 ms] (CI 99.9%), Margin = 5.871 ms (2.10% of Mean)
Skewness = 0.53, Kurtosis = 2.4, MValue = 2
-------------------- Histogram --------------------
[244.529 ms ; 251.615 ms) | @
[251.615 ms ; 260.475 ms) | @@@@@@
[260.475 ms ; 272.275 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[272.275 ms ; 281.924 ms) | @@@@@@@@@@@@@@@@@@@@@
[281.924 ms ; 296.066 ms) | @@@@@@@@@@@@@@@@@@@@
[296.066 ms ; 310.148 ms) | @@@@@@@@@@@
[310.148 ms ; 320.705 ms) | @@@@@
---------------------------------------------------

QueryBenchmarks.ProjectionDtoCompiled: DefaultJob [Take=500]
Runtime = .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 20.852 ms, StdErr = 0.230 ms (1.10%), N = 91, StdDev = 2.193 ms
Min = 18.647 ms, Q1 = 19.350 ms, Median = 20.062 ms, Q3 = 21.444 ms, Max = 27.259 ms
IQR = 2.094 ms, LowerFence = 16.208 ms, UpperFence = 24.585 ms
ConfidenceInterval = [20.070 ms; 21.634 ms] (CI 99.9%), Margin = 0.782 ms (3.75% of Mean)
Skewness = 1.44, Kurtosis = 4.08, MValue = 2.13
-------------------- Histogram --------------------
[18.007 ms ; 18.976 ms) | @@@@@@
[18.976 ms ; 20.256 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[20.256 ms ; 21.549 ms) | @@@@@@@@@@@@@@@@@@
[21.549 ms ; 22.840 ms) | @@@@@@
[22.840 ms ; 24.544 ms) | @@@@@@
[24.544 ms ; 26.154 ms) | @@@@@@
[26.154 ms ; 27.899 ms) | @@@
---------------------------------------------------

QueryBenchmarks.SplitQuery: DefaultJob [Take=500]
Runtime = .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 31.446 ms, StdErr = 0.254 ms (0.81%), N = 91, StdDev = 2.424 ms
Min = 27.816 ms, Q1 = 29.756 ms, Median = 31.165 ms, Q3 = 32.644 ms, Max = 38.349 ms
IQR = 2.888 ms, LowerFence = 25.423 ms, UpperFence = 36.976 ms
ConfidenceInterval = [30.581 ms; 32.310 ms] (CI 99.9%), Margin = 0.864 ms (2.75% of Mean)
Skewness = 0.95, Kurtosis = 3.62, MValue = 2.23
-------------------- Histogram --------------------
[27.772 ms ; 29.224 ms) | @@@@@@@@@@@@@@
[29.224 ms ; 30.639 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@@
[30.639 ms ; 32.560 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@
[32.560 ms ; 34.372 ms) | @@@@@@@@@@@@@
[34.372 ms ; 35.787 ms) | @@@
[35.787 ms ; 37.724 ms) | @@@@@
[37.724 ms ; 39.056 ms) | @@
---------------------------------------------------

QueryBenchmarks.ProjectionDto: DefaultJob [Take=500]
Runtime = .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 32.898 ms, StdErr = 0.999 ms (3.04%), N = 97, StdDev = 9.840 ms
Min = 19.744 ms, Q1 = 24.284 ms, Median = 30.228 ms, Q3 = 40.285 ms, Max = 53.723 ms
IQR = 16.001 ms, LowerFence = 0.284 ms, UpperFence = 64.286 ms
ConfidenceInterval = [29.506 ms; 36.290 ms] (CI 99.9%), Margin = 3.392 ms (10.31% of Mean)
Skewness = 0.53, Kurtosis = 2.03, MValue = 3.16
-------------------- Histogram --------------------
[16.933 ms ; 20.035 ms) | @
[20.035 ms ; 25.657 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@@@
[25.657 ms ; 32.783 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[32.783 ms ; 36.416 ms) | @@@
[36.416 ms ; 42.038 ms) | @@@@@@@@@@@@@@
[42.038 ms ; 46.167 ms) | @@@@@@
[46.167 ms ; 51.789 ms) | @@@@@@@@@@@@@
[51.789 ms ; 56.534 ms) | @@
---------------------------------------------------

QueryBenchmarks.NoTrackingIdentityResolution: DefaultJob [Take=500]
Runtime = .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 71.702 ms, StdErr = 0.875 ms (1.22%), N = 91, StdDev = 8.350 ms
Min = 59.522 ms, Q1 = 65.676 ms, Median = 70.184 ms, Q3 = 75.659 ms, Max = 95.516 ms
IQR = 9.983 ms, LowerFence = 50.702 ms, UpperFence = 90.633 ms
ConfidenceInterval = [68.724 ms; 74.680 ms] (CI 99.9%), Margin = 2.978 ms (4.15% of Mean)
Skewness = 0.91, Kurtosis = 3.35, MValue = 3.25
-------------------- Histogram --------------------
[57.085 ms ; 60.112 ms) | @@
[60.112 ms ; 65.506 ms) | @@@@@@@@@@@@@@@@@@@
[65.506 ms ; 71.659 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[71.659 ms ; 76.532 ms) | @@@@@@@@@@@@@@@@@@@@
[76.532 ms ; 81.169 ms) | @@@@@@@@
[81.169 ms ; 83.420 ms) | @
[83.420 ms ; 88.293 ms) | @@@@@@@
[88.293 ms ; 91.726 ms) |
[91.726 ms ; 96.599 ms) | @@@@
---------------------------------------------------

QueryBenchmarks.BaselineTrackingInclude: DefaultJob [Take=500]
Runtime = .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 224.497 ms, StdErr = 5.086 ms (2.27%), N = 89, StdDev = 47.980 ms
Min = 176.098 ms, Q1 = 189.779 ms, Median = 209.904 ms, Q3 = 233.067 ms, Max = 377.381 ms
IQR = 43.288 ms, LowerFence = 124.848 ms, UpperFence = 297.998 ms
ConfidenceInterval = [207.182 ms; 241.812 ms] (CI 99.9%), Margin = 17.315 ms (7.71% of Mean)
Skewness = 1.51, Kurtosis = 4.57, MValue = 3.08
-------------------- Histogram --------------------
[161.993 ms ; 180.936 ms) | @@@@@@@
[180.936 ms ; 209.146 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[209.146 ms ; 237.651 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@
[237.651 ms ; 256.985 ms) | @@
[256.985 ms ; 285.195 ms) | @@@@@@@
[285.195 ms ; 313.310 ms) | @@@@
[313.310 ms ; 336.503 ms) | @
[336.503 ms ; 364.713 ms) | @@@@@
[364.713 ms ; 391.486 ms) | @
---------------------------------------------------

QueryBenchmarks.AggregateNaive: DefaultJob [Take=500]
Runtime = .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 236.064 ms, StdErr = 4.098 ms (1.74%), N = 96, StdDev = 40.156 ms
Min = 184.245 ms, Q1 = 204.319 ms, Median = 223.785 ms, Q3 = 260.334 ms, Max = 336.971 ms
IQR = 56.014 ms, LowerFence = 120.298 ms, UpperFence = 344.355 ms
ConfidenceInterval = [222.147 ms; 249.982 ms] (CI 99.9%), Margin = 13.918 ms (5.90% of Mean)
Skewness = 0.8, Kurtosis = 2.62, MValue = 2.94
-------------------- Histogram --------------------
[172.735 ms ; 191.936 ms) | @@@@@@
[191.936 ms ; 214.957 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[214.957 ms ; 238.714 ms) | @@@@@@@@@@@@@@@@@@@
[238.714 ms ; 255.264 ms) | @@@@
[255.264 ms ; 278.285 ms) | @@@@@@@@@@@@@@@@
[278.285 ms ; 287.659 ms) | @@
[287.659 ms ; 310.680 ms) | @@@@@@@
[310.680 ms ; 340.712 ms) | @@@@@@
---------------------------------------------------

QueryBenchmarks.AggregateServer: DefaultJob [Take=500]
Runtime = .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 275.910 ms, StdErr = 1.941 ms (0.70%), N = 93, StdDev = 18.721 ms
Min = 248.169 ms, Q1 = 261.499 ms, Median = 273.876 ms, Q3 = 287.831 ms, Max = 328.136 ms
IQR = 26.331 ms, LowerFence = 222.002 ms, UpperFence = 327.328 ms
ConfidenceInterval = [269.311 ms; 282.510 ms] (CI 99.9%), Margin = 6.599 ms (2.39% of Mean)
Skewness = 0.75, Kurtosis = 2.92, MValue = 2.5
-------------------- Histogram --------------------
[242.745 ms ; 255.100 ms) | @@@@@@@@@@
[255.100 ms ; 265.947 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@
[265.947 ms ; 278.249 ms) | @@@@@@@@@@@@@@@@
[278.249 ms ; 289.096 ms) | @@@@@@@@@@@@@@@@@@@@
[289.096 ms ; 301.324 ms) | @@@@@@@@@@@
[301.324 ms ; 311.061 ms) | @
[311.061 ms ; 321.908 ms) | @@@@@@
[321.908 ms ; 333.559 ms) | @
---------------------------------------------------

QueryBenchmarks.AsNoTracking: DefaultJob [Take=500]
Runtime = .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 343.353 ms, StdErr = 17.088 ms (4.98%), N = 99, StdDev = 170.021 ms
Min = 79.877 ms, Q1 = 206.423 ms, Median = 270.608 ms, Q3 = 515.906 ms, Max = 586.642 ms
IQR = 309.483 ms, LowerFence = -257.800 ms, UpperFence = 980.130 ms
ConfidenceInterval = [285.381 ms; 401.325 ms] (CI 99.9%), Margin = 57.972 ms (16.88% of Mean)
Skewness = -0, Kurtosis = 1.29, MValue = 3.68
-------------------- Histogram --------------------
[ 65.069 ms ; 174.206 ms) | @@@@@@@@@@@@@@@@@
[174.206 ms ; 270.683 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[270.683 ms ; 384.537 ms) | @@@@
[384.537 ms ; 478.220 ms) | @
[478.220 ms ; 574.696 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[574.696 ms ; 634.880 ms) | @
---------------------------------------------------

QueryBenchmarks.ProjectionDto: DefaultJob [Take=5000]
Runtime = .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 227.577 ms, StdErr = 4.002 ms (1.76%), N = 98, StdDev = 39.616 ms
Min = 171.911 ms, Q1 = 194.938 ms, Median = 216.946 ms, Q3 = 256.869 ms, Max = 334.298 ms
IQR = 61.931 ms, LowerFence = 102.041 ms, UpperFence = 349.766 ms
ConfidenceInterval = [213.996 ms; 241.158 ms] (CI 99.9%), Margin = 13.581 ms (5.97% of Mean)
Skewness = 0.74, Kurtosis = 2.49, MValue = 3.67
-------------------- Histogram --------------------
[160.633 ms ; 179.178 ms) | @@
[179.178 ms ; 201.734 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[201.734 ms ; 210.172 ms) | @@@@@
[210.172 ms ; 232.727 ms) | @@@@@@@@@@@@@@@@@@@
[232.727 ms ; 249.219 ms) | @@@@@@
[249.219 ms ; 271.775 ms) | @@@@@@@@@@@@@@@@
[271.775 ms ; 292.038 ms) | @@@@
[292.038 ms ; 314.594 ms) | @@@@@@@@@
[314.594 ms ; 323.020 ms) |
[323.020 ms ; 345.576 ms) | @
---------------------------------------------------

QueryBenchmarks.ProjectionDtoCompiled: DefaultJob [Take=5000]
Runtime = .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 240.339 ms, StdErr = 4.205 ms (1.75%), N = 97, StdDev = 41.417 ms
Min = 175.284 ms, Q1 = 209.679 ms, Median = 225.993 ms, Q3 = 269.773 ms, Max = 357.972 ms
IQR = 60.094 ms, LowerFence = 119.538 ms, UpperFence = 359.914 ms
ConfidenceInterval = [226.063 ms; 254.615 ms] (CI 99.9%), Margin = 14.276 ms (5.94% of Mean)
Skewness = 0.84, Kurtosis = 2.93, MValue = 3.41
-------------------- Histogram --------------------
[174.524 ms ; 201.457 ms) | @@@@@@@@@@@
[201.457 ms ; 225.119 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[225.119 ms ; 236.286 ms) | @@@@@
[236.286 ms ; 259.948 ms) | @@@@@@@@@@@@@@@@@@
[259.948 ms ; 268.685 ms) | @
[268.685 ms ; 292.347 ms) | @@@@@@@@@@@@@
[292.347 ms ; 316.292 ms) | @@@@@
[316.292 ms ; 345.946 ms) | @@@@@@
[345.946 ms ; 369.803 ms) | @
---------------------------------------------------

QueryBenchmarks.AggregateNaive: DefaultJob [Take=5000]
Runtime = .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 241.300 ms, StdErr = 3.946 ms (1.64%), N = 98, StdDev = 39.067 ms
Min = 186.354 ms, Q1 = 208.821 ms, Median = 229.468 ms, Q3 = 261.432 ms, Max = 333.121 ms
IQR = 52.612 ms, LowerFence = 129.903 ms, UpperFence = 340.350 ms
ConfidenceInterval = [227.908 ms; 254.693 ms] (CI 99.9%), Margin = 13.393 ms (5.55% of Mean)
Skewness = 0.8, Kurtosis = 2.72, MValue = 2.39
-------------------- Histogram --------------------
[175.232 ms ; 199.259 ms) | @@@@@@@@
[199.259 ms ; 221.502 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[221.502 ms ; 243.856 ms) | @@@@@@@@@@@@@@@@@@@@
[243.856 ms ; 271.127 ms) | @@@@@@@@@@@@@@@@@@@@
[271.127 ms ; 294.870 ms) | @@@@@@@
[294.870 ms ; 312.742 ms) | @@@
[312.742 ms ; 334.986 ms) | @@@@@@@@@
---------------------------------------------------

QueryBenchmarks.AggregateServer: DefaultJob [Take=5000]
Runtime = .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 287.868 ms, StdErr = 3.547 ms (1.23%), N = 94, StdDev = 34.387 ms
Min = 245.560 ms, Q1 = 262.352 ms, Median = 274.666 ms, Q3 = 308.449 ms, Max = 372.779 ms
IQR = 46.097 ms, LowerFence = 193.206 ms, UpperFence = 377.595 ms
ConfidenceInterval = [275.815 ms; 299.920 ms] (CI 99.9%), Margin = 12.053 ms (4.19% of Mean)
Skewness = 0.9, Kurtosis = 2.88, MValue = 2.44
-------------------- Histogram --------------------
[235.634 ms ; 250.567 ms) | @@@@@
[250.567 ms ; 270.420 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[270.420 ms ; 286.818 ms) | @@@@@@@@@@
[286.818 ms ; 306.671 ms) | @@@@@@@@@@@@@@@@@@
[306.671 ms ; 330.578 ms) | @@@@@@@@@@@
[330.578 ms ; 353.053 ms) | @@@@@@@
[353.053 ms ; 372.905 ms) | @@@@@@@
---------------------------------------------------

QueryBenchmarks.SplitQuery: DefaultJob [Take=5000]
Runtime = .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 554.638 ms, StdErr = 7.154 ms (1.29%), N = 91, StdDev = 68.246 ms
Min = 469.122 ms, Q1 = 507.096 ms, Median = 533.015 ms, Q3 = 590.997 ms, Max = 743.528 ms
IQR = 83.901 ms, LowerFence = 381.244 ms, UpperFence = 716.849 ms
ConfidenceInterval = [530.300 ms; 578.976 ms] (CI 99.9%), Margin = 24.338 ms (4.39% of Mean)
Skewness = 1.1, Kurtosis = 3.48, MValue = 2.4
-------------------- Histogram --------------------
[449.208 ms ; 489.753 ms) | @@@@@@@@@@
[489.753 ms ; 529.581 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[529.581 ms ; 575.911 ms) | @@@@@@@@@@@@@@@@@@@
[575.911 ms ; 615.740 ms) | @@@@@@@@@@@@@
[615.740 ms ; 653.963 ms) | @@@@@@
[653.963 ms ; 696.426 ms) | @@@@
[696.426 ms ; 750.013 ms) | @@@@@
---------------------------------------------------

QueryBenchmarks.BaselineTrackingInclude: DefaultJob [Take=5000]
Runtime = .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 667.695 ms, StdErr = 6.344 ms (0.95%), N = 84, StdDev = 58.142 ms
Min = 587.485 ms, Q1 = 622.486 ms, Median = 658.655 ms, Q3 = 699.794 ms, Max = 870.263 ms
IQR = 77.308 ms, LowerFence = 506.523 ms, UpperFence = 815.756 ms
ConfidenceInterval = [646.053 ms; 689.338 ms] (CI 99.9%), Margin = 21.643 ms (3.24% of Mean)
Skewness = 1.23, Kurtosis = 4.85, MValue = 2.64
-------------------- Histogram --------------------
[570.060 ms ; 595.882 ms) | @@
[595.882 ms ; 630.732 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@@
[630.732 ms ; 665.616 ms) | @@@@@@@@@@@@@@@@
[665.616 ms ; 700.466 ms) | @@@@@@@@@@@@@@@@@@@@@@
[700.466 ms ; 739.118 ms) | @@@@@@@@@@@
[739.118 ms ; 777.780 ms) | @@@
[777.780 ms ; 794.299 ms) |
[794.299 ms ; 829.148 ms) | @@
[829.148 ms ; 847.471 ms) |
[847.471 ms ; 887.687 ms) | @@
---------------------------------------------------

QueryBenchmarks.NoTrackingIdentityResolution: DefaultJob [Take=5000]
Runtime = .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 815.865 ms, StdErr = 5.470 ms (0.67%), N = 95, StdDev = 53.312 ms
Min = 734.380 ms, Q1 = 772.908 ms, Median = 806.708 ms, Q3 = 848.094 ms, Max = 966.990 ms
IQR = 75.186 ms, LowerFence = 660.128 ms, UpperFence = 960.874 ms
ConfidenceInterval = [797.284 ms; 834.446 ms] (CI 99.9%), Margin = 18.581 ms (2.28% of Mean)
Skewness = 0.74, Kurtosis = 2.96, MValue = 3.04
-------------------- Histogram --------------------
[719.045 ms ; 750.389 ms) | @@@@@@@
[750.389 ms ; 781.059 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@
[781.059 ms ; 817.850 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@
[817.850 ms ; 850.956 ms) | @@@@@@@@@@@@@@@@@@
[850.956 ms ; 898.819 ms) | @@@@@@@@@@@@@@
[898.819 ms ; 938.120 ms) | @@
[938.120 ms ; 968.790 ms) | @@@@
---------------------------------------------------

QueryBenchmarks.AsNoTracking: DefaultJob [Take=5000]
Runtime = .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 994.061 ms, StdErr = 15.050 ms (1.51%), N = 96, StdDev = 147.462 ms
Min = 795.363 ms, Q1 = 878.704 ms, Median = 953.407 ms, Q3 = 1,102.437 ms, Max = 1,430.555 ms
IQR = 223.733 ms, LowerFence = 543.105 ms, UpperFence = 1,438.036 ms
ConfidenceInterval = [942.952 ms; 1,045.170 ms] (CI 99.9%), Margin = 51.109 ms (5.14% of Mean)
Skewness = 0.76, Kurtosis = 2.72, MValue = 2.2
-------------------- Histogram --------------------
[  753.094 ms ;   829.113 ms) | @@@@@@@@
[  829.113 ms ;   913.651 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[  913.651 ms ; 1,009.544 ms) | @@@@@@@@@@@@@@@@@@@@@@
[1,009.544 ms ; 1,115.076 ms) | @@@@@@@@@@@@
[1,115.076 ms ; 1,199.614 ms) | @@@@@@@@@@@@@@@
[1,199.614 ms ; 1,297.838 ms) | @@@@@@
[1,297.838 ms ; 1,373.791 ms) | @@
[1,373.791 ms ; 1,472.824 ms) | @
---------------------------------------------------

QueryBenchmarks.AggregateNaive: DefaultJob [Take=50000]
Runtime = .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 207.712 ms, StdErr = 1.714 ms (0.83%), N = 96, StdDev = 16.793 ms
Min = 178.632 ms, Q1 = 194.218 ms, Median = 205.725 ms, Q3 = 219.012 ms, Max = 255.605 ms
IQR = 24.794 ms, LowerFence = 157.028 ms, UpperFence = 256.203 ms
ConfidenceInterval = [201.892 ms; 213.533 ms] (CI 99.9%), Margin = 5.820 ms (2.80% of Mean)
Skewness = 0.71, Kurtosis = 3.01, MValue = 2.55
-------------------- Histogram --------------------
[177.598 ms ; 187.274 ms) | @@@@
[187.274 ms ; 196.902 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[196.902 ms ; 205.465 ms) | @@@@@@@@@@@@@
[205.465 ms ; 216.212 ms) | @@@@@@@@@@@@@@@@@@@@@
[216.212 ms ; 225.839 ms) | @@@@@@@@@@@@@@@@
[225.839 ms ; 235.738 ms) | @@@@@@
[235.738 ms ; 245.365 ms) | @@@@
[245.365 ms ; 255.985 ms) | @@@
---------------------------------------------------

QueryBenchmarks.AggregateServer: DefaultJob [Take=50000]
Runtime = .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 301.828 ms, StdErr = 2.980 ms (0.99%), N = 95, StdDev = 29.048 ms
Min = 263.159 ms, Q1 = 279.025 ms, Median = 295.261 ms, Q3 = 320.162 ms, Max = 387.812 ms
IQR = 41.137 ms, LowerFence = 217.320 ms, UpperFence = 381.867 ms
ConfidenceInterval = [291.704 ms; 311.952 ms] (CI 99.9%), Margin = 10.124 ms (3.35% of Mean)
Skewness = 0.94, Kurtosis = 3.34, MValue = 2.58
-------------------- Histogram --------------------
[254.804 ms ; 266.808 ms) | @@@
[266.808 ms ; 285.412 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[285.412 ms ; 302.123 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@
[302.123 ms ; 310.207 ms) | @@@@
[310.207 ms ; 326.918 ms) | @@@@@@@@@@@@@@@
[326.918 ms ; 344.712 ms) | @@@@@@@@
[344.712 ms ; 363.589 ms) | @@@@
[363.589 ms ; 371.535 ms) |
[371.535 ms ; 388.246 ms) | @@@@
---------------------------------------------------

QueryBenchmarks.ProjectionDto: DefaultJob [Take=50000]
Runtime = .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 415.985 ms, StdErr = 3.267 ms (0.79%), N = 93, StdDev = 31.504 ms
Min = 366.916 ms, Q1 = 391.424 ms, Median = 408.547 ms, Q3 = 434.409 ms, Max = 502.047 ms
IQR = 42.985 ms, LowerFence = 326.947 ms, UpperFence = 498.886 ms
ConfidenceInterval = [404.880 ms; 427.090 ms] (CI 99.9%), Margin = 11.105 ms (2.67% of Mean)
Skewness = 0.86, Kurtosis = 2.92, MValue = 2.71
-------------------- Histogram --------------------
[364.906 ms ; 383.453 ms) | @@@@@@@@
[383.453 ms ; 401.705 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[401.705 ms ; 422.330 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@
[422.330 ms ; 434.112 ms) | @@@@
[434.112 ms ; 452.365 ms) | @@@@@@@@@@@@
[452.365 ms ; 470.885 ms) | @@
[470.885 ms ; 489.138 ms) | @@@@@@@@
[489.138 ms ; 507.102 ms) | @@
---------------------------------------------------

QueryBenchmarks.ProjectionDtoCompiled: DefaultJob [Take=50000]
Runtime = .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 431.568 ms, StdErr = 3.338 ms (0.77%), N = 96, StdDev = 32.705 ms
Min = 383.327 ms, Q1 = 406.326 ms, Median = 426.788 ms, Q3 = 447.076 ms, Max = 520.210 ms
IQR = 40.750 ms, LowerFence = 345.201 ms, UpperFence = 508.201 ms
ConfidenceInterval = [420.233 ms; 442.903 ms] (CI 99.9%), Margin = 11.335 ms (2.63% of Mean)
Skewness = 0.81, Kurtosis = 3.09, MValue = 2.25
-------------------- Histogram --------------------
[373.952 ms ; 394.492 ms) | @@@@@@@
[394.492 ms ; 413.241 ms) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@
[413.241 ms ; 429.520 ms) | @@@@@@@@@@@@@@
[429.520 ms ; 448.269 ms) | @@@@@@@@@@@@@@@@@@@@@@@@
[448.269 ms ; 472.093 ms) | @@@@@@@@@@@@
[472.093 ms ; 496.689 ms) | @@@@@@@
[496.689 ms ; 507.366 ms) |
[507.366 ms ; 529.584 ms) | @@@@
---------------------------------------------------

QueryBenchmarks.BaselineTrackingInclude: DefaultJob [Take=50000]
Runtime = .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 1.266 s, StdErr = 0.012 s (0.92%), N = 97, StdDev = 0.114 s
Min = 1.106 s, Q1 = 1.171 s, Median = 1.244 s, Q3 = 1.332 s, Max = 1.548 s
IQR = 0.162 s, LowerFence = 0.928 s, UpperFence = 1.574 s
ConfidenceInterval = [1.227 s; 1.306 s] (CI 99.9%), Margin = 0.039 s (3.12% of Mean)
Skewness = 0.68, Kurtosis = 2.5, MValue = 2.97
-------------------- Histogram --------------------
[1.074 s ; 1.146 s) | @@@@@@@@@@
[1.146 s ; 1.211 s) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[1.211 s ; 1.267 s) | @@@@@@@@@@@@
[1.267 s ; 1.333 s) | @@@@@@@@@@@@@@@@@@@@
[1.333 s ; 1.419 s) | @@@@@@@@@@@@@@
[1.419 s ; 1.469 s) | @
[1.469 s ; 1.534 s) | @@@@@@@@
[1.534 s ; 1.581 s) | @
---------------------------------------------------

QueryBenchmarks.SplitQuery: DefaultJob [Take=50000]
Runtime = .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 1.550 s, StdErr = 0.023 s (1.50%), N = 80, StdDev = 0.208 s
Min = 0.587 s, Q1 = 1.472 s, Median = 1.546 s, Q3 = 1.597 s, Max = 2.221 s
IQR = 0.125 s, LowerFence = 1.285 s, UpperFence = 1.784 s
ConfidenceInterval = [1.471 s; 1.630 s] (CI 99.9%), Margin = 0.080 s (5.14% of Mean)
Skewness = -1.11, Kurtosis = 9.81, MValue = 3.04
-------------------- Histogram --------------------
[0.523 s ; 0.650 s) | @
[0.650 s ; 0.777 s) |
[0.777 s ; 0.869 s) |
[0.869 s ; 0.996 s) | @@
[0.996 s ; 1.123 s) |
[1.123 s ; 1.250 s) |
[1.250 s ; 1.352 s) |
[1.352 s ; 1.462 s) | @@@@@@@@@@@@@@@
[1.462 s ; 1.589 s) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[1.589 s ; 1.738 s) | @@@@@@@@@@
[1.738 s ; 1.865 s) | @@@@@@@
[1.865 s ; 2.002 s) | @@@
[2.002 s ; 2.129 s) |
[2.129 s ; 2.284 s) | @
---------------------------------------------------

QueryBenchmarks.AsNoTracking: DefaultJob [Take=50000]
Runtime = .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 1.892 s, StdErr = 0.024 s (1.27%), N = 95, StdDev = 0.234 s
Min = 1.586 s, Q1 = 1.719 s, Median = 1.805 s, Q3 = 2.013 s, Max = 2.570 s
IQR = 0.294 s, LowerFence = 1.278 s, UpperFence = 2.453 s
ConfidenceInterval = [1.811 s; 1.974 s] (CI 99.9%), Margin = 0.082 s (4.31% of Mean)
Skewness = 1.19, Kurtosis = 3.59, MValue = 2.4
-------------------- Histogram --------------------
[1.518 s ; 1.672 s) | @@@@@@@@
[1.672 s ; 1.806 s) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[1.806 s ; 1.961 s) | @@@@@@@@@@@@@@@@@@@
[1.961 s ; 2.040 s) | @@@@
[2.040 s ; 2.175 s) | @@@@@@@@@@@
[2.175 s ; 2.333 s) | @@@@
[2.333 s ; 2.468 s) | @@@@@
[2.468 s ; 2.615 s) | @@@
---------------------------------------------------

QueryBenchmarks.NoTrackingIdentityResolution: DefaultJob [Take=50000]
Runtime = .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 1.907 s, StdErr = 0.028 s (1.49%), N = 100, StdDev = 0.285 s
Min = 1.547 s, Q1 = 1.680 s, Median = 1.780 s, Q3 = 2.111 s, Max = 2.724 s
IQR = 0.431 s, LowerFence = 1.034 s, UpperFence = 2.757 s
ConfidenceInterval = [1.810 s; 2.003 s] (CI 99.9%), Margin = 0.097 s (5.06% of Mean)
Skewness = 0.93, Kurtosis = 2.85, MValue = 2.74
-------------------- Histogram --------------------
[1.467 s ; 1.620 s) | @@@@@
[1.620 s ; 1.781 s) | @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
[1.781 s ; 1.922 s) | @@@@@@@@@@@@
[1.922 s ; 2.004 s) | @@
[2.004 s ; 2.165 s) | @@@@@@@@@@@@@@@
[2.165 s ; 2.351 s) | @@@@@@@@@
[2.351 s ; 2.512 s) | @@@@@@@@
[2.512 s ; 2.603 s) | @
[2.603 s ; 2.764 s) | @@
---------------------------------------------------

// * Summary *

BenchmarkDotNet v0.15.2, Windows 10 (10.0.19045.6216/22H2/2022Update)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.300
  [Host]     : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2


| Method                       | Take  | Mean         | Error      | StdDev      | Median       | Ratio | RatioSD | Rank | Gen0       | Gen1      | Gen2      | Allocated   | Alloc Ratio |
|----------------------------- |------ |-------------:|-----------:|------------:|-------------:|------:|--------:|-----:|-----------:|----------:|----------:|------------:|------------:|
| ProjectionDto                | 50    |     3.146 ms |  0.2993 ms |   0.8343 ms |     2.790 ms |  0.02 |    0.01 |    1 |    31.2500 |         - |         - |   147.87 KB |        0.92 |
| ProjectionDtoCompiled        | 50    |     3.156 ms |  0.4004 ms |   1.1679 ms |     2.585 ms |  0.02 |    0.01 |    1 |    15.6250 |         - |         - |   137.95 KB |        0.86 |
| SplitQuery                   | 50    |     4.885 ms |  0.3741 ms |   1.1030 ms |     4.844 ms |  0.03 |    0.01 |    2 |    23.4375 |         - |         - |   123.52 KB |        0.77 |
| NoTrackingIdentityResolution | 50    |     9.020 ms |  0.6716 ms |   1.9803 ms |     8.384 ms |  0.06 |    0.01 |    3 |    78.1250 |   15.6250 |         - |   373.31 KB |        2.32 |
| BaselineTrackingInclude      | 50    |   151.915 ms |  4.6353 ms |  13.3739 ms |   146.386 ms |  1.01 |    0.12 |    4 |          - |         - |         - |   160.61 KB |        1.00 |
| AsNoTracking                 | 50    |   153.712 ms |  6.2099 ms |  16.7889 ms |   148.572 ms |  1.02 |    0.14 |    4 |          - |         - |         - |   324.33 KB |        2.02 |
| AggregateNaive               | 50    |   226.456 ms | 11.7363 ms |  33.8620 ms |   213.842 ms |  1.50 |    0.25 |    5 |  2000.0000 | 1000.0000 |         - | 11137.41 KB |       69.34 |
| AggregateServer              | 50    |   279.978 ms |  5.8708 ms |  16.6545 ms |   278.102 ms |  1.86 |    0.19 |    6 |  4000.0000 |         - |         - | 20729.57 KB |      129.07 |
|                              |       |              |            |             |              |       |         |      |            |           |           |             |             |
| ProjectionDtoCompiled        | 500   |    20.852 ms |  0.7821 ms |   2.1931 ms |    20.062 ms |  0.10 |    0.02 |    1 |   250.0000 |   31.2500 |         - |   1271.8 KB |        0.94 |
| SplitQuery                   | 500   |    31.446 ms |  0.8643 ms |   2.4237 ms |    31.165 ms |  0.15 |    0.03 |    2 |   230.7692 |   76.9231 |         - |  1168.35 KB |        0.86 |
| ProjectionDto                | 500   |    32.898 ms |  3.3918 ms |   9.8404 ms |    30.228 ms |  0.15 |    0.05 |    2 |   166.6667 |         - |         - |  1281.85 KB |        0.94 |
| NoTrackingIdentityResolution | 500   |    71.702 ms |  2.9778 ms |   8.3501 ms |    70.184 ms |  0.33 |    0.07 |    3 |   500.0000 |         - |         - |  3361.17 KB |        2.47 |
| BaselineTrackingInclude      | 500   |   224.497 ms | 17.3151 ms |  47.9801 ms |   209.904 ms |  1.04 |    0.29 |    4 |          - |         - |         - |  1358.77 KB |        1.00 |
| AggregateNaive               | 500   |   236.064 ms | 13.9179 ms |  40.1562 ms |   223.785 ms |  1.09 |    0.26 |    4 |  2000.0000 | 1000.0000 |         - | 11137.41 KB |        8.20 |
| AggregateServer              | 500   |   275.910 ms |  6.5994 ms |  18.7213 ms |   273.876 ms |  1.27 |    0.23 |    5 |  4000.0000 |         - |         - | 20729.67 KB |       15.26 |
| AsNoTracking                 | 500   |   343.353 ms | 57.9719 ms | 170.0214 ms |   270.608 ms |  1.59 |    0.84 |    5 |   500.0000 |         - |         - |  2853.36 KB |        2.10 |
|                              |       |              |            |             |              |       |         |      |            |           |           |             |             |
| ProjectionDto                | 5000  |   227.577 ms | 13.5809 ms |  39.6160 ms |   216.946 ms |  0.34 |    0.07 |    1 |  2000.0000 |         - |         - | 12612.87 KB |        0.92 |
| ProjectionDtoCompiled        | 5000  |   240.339 ms | 14.2759 ms |  41.4171 ms |   225.993 ms |  0.36 |    0.07 |    1 |  2000.0000 |         - |         - | 12602.23 KB |        0.91 |
| AggregateNaive               | 5000  |   241.300 ms | 13.3927 ms |  39.0671 ms |   229.468 ms |  0.36 |    0.07 |    1 |  2000.0000 | 1000.0000 |         - | 11137.41 KB |        0.81 |
| AggregateServer              | 5000  |   287.868 ms | 12.0528 ms |  34.3872 ms |   274.666 ms |  0.43 |    0.06 |    2 |  4000.0000 |         - |         - | 20729.56 KB |        1.50 |
| SplitQuery                   | 5000  |   554.638 ms | 24.3380 ms |  68.2465 ms |   533.015 ms |  0.84 |    0.12 |    3 |  3000.0000 | 1000.0000 |         - | 21586.18 KB |        1.57 |
| BaselineTrackingInclude      | 5000  |   667.695 ms | 21.6429 ms |  58.1423 ms |   658.655 ms |  1.01 |    0.12 |    4 |  3000.0000 |         - |         - | 13776.15 KB |        1.00 |
| NoTrackingIdentityResolution | 5000  |   815.865 ms | 18.5808 ms |  53.3119 ms |   806.708 ms |  1.23 |    0.13 |    5 |  5000.0000 | 2000.0000 | 1000.0000 | 33895.72 KB |        2.46 |
| AsNoTracking                 | 5000  |   994.061 ms | 51.1093 ms | 147.4620 ms |   953.407 ms |  1.50 |    0.25 |    6 |  4000.0000 | 1000.0000 |         - | 29085.19 KB |        2.11 |
|                              |       |              |            |             |              |       |         |      |            |           |           |             |             |
| AggregateNaive               | 50000 |   207.712 ms |  5.8205 ms |  16.7934 ms |   205.725 ms |  0.17 |    0.02 |    1 |  2000.0000 | 1000.0000 |         - | 11137.41 KB |        0.40 |
| AggregateServer              | 50000 |   301.828 ms | 10.1240 ms |  29.0476 ms |   295.261 ms |  0.24 |    0.03 |    2 |  4000.0000 |         - |         - | 20729.83 KB |        0.75 |
| ProjectionDto                | 50000 |   415.985 ms | 11.1052 ms |  31.5035 ms |   408.547 ms |  0.33 |    0.04 |    3 |  5000.0000 | 1000.0000 |         - | 25276.57 KB |        0.92 |
| ProjectionDtoCompiled        | 50000 |   431.568 ms | 11.3352 ms |  32.7046 ms |   426.788 ms |  0.34 |    0.04 |    3 |  5000.0000 | 1000.0000 |         - | 25265.79 KB |        0.92 |
| BaselineTrackingInclude      | 50000 | 1,266.500 ms | 39.4627 ms | 114.4886 ms | 1,243.969 ms |  1.01 |    0.13 |    4 |  5000.0000 |         - |         - | 27554.42 KB |        1.00 |
| SplitQuery                   | 50000 | 1,550.119 ms | 79.6127 ms | 208.3325 ms | 1,546.133 ms |  1.23 |    0.20 |    5 | 10000.0000 | 2000.0000 |         - | 65991.26 KB |        2.39 |
| AsNoTracking                 | 50000 | 1,892.387 ms | 81.5212 ms | 233.8995 ms | 1,805.061 ms |  1.51 |    0.23 |    6 |  9000.0000 | 2000.0000 |         - | 58195.08 KB |        2.11 |
| NoTrackingIdentityResolution | 50000 | 1,906.653 ms | 96.5333 ms | 284.6307 ms | 1,780.205 ms |  1.52 |    0.26 |    6 | 11000.0000 | 5000.0000 | 2000.0000 | 68129.83 KB |        2.47 |

// * Warnings *
Environment
  Summary -> Benchmark was executed with attached debugger
MultimodalDistribution
  QueryBenchmarks.SplitQuery: Default                   -> It seems that the distribution is bimodal (mValue = 3.27)
  QueryBenchmarks.AggregateNaive: Default               -> It seems that the distribution can have several modes (mValue = 2.88)
  QueryBenchmarks.ProjectionDto: Default                -> It seems that the distribution can have several modes (mValue = 3.16)
  QueryBenchmarks.NoTrackingIdentityResolution: Default -> It seems that the distribution is bimodal (mValue = 3.25)
  QueryBenchmarks.BaselineTrackingInclude: Default      -> It seems that the distribution can have several modes (mValue = 3.08)
  QueryBenchmarks.AggregateNaive: Default               -> It seems that the distribution can have several modes (mValue = 2.94)
  QueryBenchmarks.AsNoTracking: Default                 -> It seems that the distribution is bimodal (mValue = 3.68)
  QueryBenchmarks.ProjectionDto: Default                -> It seems that the distribution is bimodal (mValue = 3.67)
  QueryBenchmarks.ProjectionDtoCompiled: Default        -> It seems that the distribution is bimodal (mValue = 3.41)
  QueryBenchmarks.NoTrackingIdentityResolution: Default -> It seems that the distribution can have several modes (mValue = 3.04)
  QueryBenchmarks.BaselineTrackingInclude: Default      -> It seems that the distribution can have several modes (mValue = 2.97)

// * Hints *
Outliers
  QueryBenchmarks.ProjectionDto: Default                -> 10 outliers were removed (6.05 ms..8.75 ms)
  QueryBenchmarks.ProjectionDtoCompiled: Default        -> 2 outliers were removed (7.16 ms, 8.34 ms)
  QueryBenchmarks.BaselineTrackingInclude: Default      -> 4 outliers were removed (192.86 ms..299.67 ms)
  QueryBenchmarks.AsNoTracking: Default                 -> 15 outliers were removed (237.83 ms..302.23 ms)
  QueryBenchmarks.AggregateNaive: Default               -> 4 outliers were removed (355.45 ms..397.55 ms)
  QueryBenchmarks.AggregateServer: Default              -> 7 outliers were removed (340.99 ms..436.40 ms)
  QueryBenchmarks.ProjectionDtoCompiled: Default        -> 9 outliers were removed (27.48 ms..32.33 ms)
  QueryBenchmarks.SplitQuery: Default                   -> 9 outliers were removed (38.77 ms..52.42 ms)
  QueryBenchmarks.ProjectionDto: Default                -> 3 outliers were removed (89.44 ms..145.45 ms)
  QueryBenchmarks.NoTrackingIdentityResolution: Default -> 9 outliers were removed (97.12 ms..301.47 ms)
  QueryBenchmarks.BaselineTrackingInclude: Default      -> 11 outliers were removed (381.32 ms..467.88 ms)
  QueryBenchmarks.AggregateNaive: Default               -> 4 outliers were removed (365.73 ms..519.62 ms)
  QueryBenchmarks.AggregateServer: Default              -> 7 outliers were removed (334.56 ms..462.53 ms)
  QueryBenchmarks.AsNoTracking: Default                 -> 1 outlier  was  removed (1.08 h)
  QueryBenchmarks.ProjectionDto: Default                -> 2 outliers were removed (383.73 ms, 531.78 ms)
  QueryBenchmarks.ProjectionDtoCompiled: Default        -> 3 outliers were removed (373.35 ms..495.59 ms)
  QueryBenchmarks.AggregateNaive: Default               -> 2 outliers were removed (346.96 ms, 374.20 ms)
  QueryBenchmarks.AggregateServer: Default              -> 6 outliers were removed (384.47 ms..519.54 ms)
  QueryBenchmarks.SplitQuery: Default                   -> 9 outliers were removed (778.51 ms..937.48 ms)
  QueryBenchmarks.BaselineTrackingInclude: Default      -> 16 outliers were removed (879.48 ms..1.05 s)
  QueryBenchmarks.NoTrackingIdentityResolution: Default -> 5 outliers were removed (1.00 s..1.38 s)
  QueryBenchmarks.AsNoTracking: Default                 -> 4 outliers were removed (1.54 s..1.82 s)
  QueryBenchmarks.AggregateNaive: Default               -> 4 outliers were removed (260.33 ms..356.86 ms)
  QueryBenchmarks.AggregateServer: Default              -> 5 outliers were removed (392.51 ms..469.58 ms)
  QueryBenchmarks.ProjectionDto: Default                -> 7 outliers were removed (523.88 ms..700.18 ms)
  QueryBenchmarks.ProjectionDtoCompiled: Default        -> 4 outliers were removed (529.84 ms..601.11 ms)
  QueryBenchmarks.BaselineTrackingInclude: Default      -> 3 outliers were removed (1.79 s..2.05 s)
  QueryBenchmarks.SplitQuery: Default                   -> 20 outliers were removed, 23 outliers were detected (586.50 ms..994.46 ms, 2.40 s..40.57 m)
  QueryBenchmarks.AsNoTracking: Default                 -> 5 outliers were removed (2.80 s..4.02 s)

// * Legends *
  Take        : Value of the 'Take' parameter
  Mean        : Arithmetic mean of all measurements
  Error       : Half of 99.9% confidence interval
  StdDev      : Standard deviation of all measurements
  Median      : Value separating the higher half of all measurements (50th percentile)
  Ratio       : Mean of the ratio distribution ([Current]/[Baseline])
  RatioSD     : Standard deviation of the ratio distribution ([Current]/[Baseline])
  Rank        : Relative position of current benchmark mean among all benchmarks (Arabic style)
  Gen0        : GC Generation 0 collects per 1000 operations
  Gen1        : GC Generation 1 collects per 1000 operations
  Gen2        : GC Generation 2 collects per 1000 operations
  Allocated   : Allocated memory per single operation (managed only, inclusive, 1KB = 1024B)
  Alloc Ratio : Allocated memory ratio distribution ([Current]/[Baseline])
  1 ms        : 1 Millisecond (0.001 sec)

// * Diagnostic Output - MemoryDiagnoser *


// ***** BenchmarkRunner: End *****
Run time: 03:31:01 (12661.62 sec), executed benchmarks: 32

Global total time: 03:32:26 (12746.69 sec), executed benchmarks: 32
// * Artifacts cleanup *
Artifacts cleanup is finished
