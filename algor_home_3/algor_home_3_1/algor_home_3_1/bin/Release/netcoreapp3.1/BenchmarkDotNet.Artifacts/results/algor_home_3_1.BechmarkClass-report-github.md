``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.746 (2004/?/20H1)
Intel Core i7-3930K CPU 3.20GHz (Ivy Bridge), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.200-preview.20601.7
  [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT


```
|                  Method |     Mean |    Error |   StdDev |
|------------------------ |---------:|---------:|---------:|
|       testPointDistance | 16.93 ns | 0.372 ns | 0.365 ns |
|    testPointDistanceRef | 16.30 ns | 0.340 ns | 0.301 ns |
|  testPointDistanceShort | 18.57 ns | 0.321 ns | 0.300 ns |
| testPointDistanceDouble | 20.60 ns | 0.403 ns | 0.377 ns |
