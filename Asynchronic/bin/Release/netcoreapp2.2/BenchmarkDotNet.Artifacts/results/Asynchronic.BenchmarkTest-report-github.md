``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 7 SP1 (6.1.7601.0)
Intel Core i5-5300U CPU 2.30GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
Frequency=2240976 Hz, Resolution=446.2341 ns, Timer=TSC
.NET Core SDK=2.2.104
  [Host]     : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), X64 RyuJIT
  DefaultJob : .NET Core 2.2.2 (CoreCLR 4.6.27317.07, CoreFX 4.6.27318.02), X64 RyuJIT


```
|              Method |            Mean |          Error |         StdDev |          Median |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------- |----------------:|---------------:|---------------:|----------------:|-------:|------:|------:|----------:|
|          PlaneUsage |       0.2283 ns |      0.0596 ns |      0.1758 ns |       0.1824 ns |      - |     - |     - |         - |
| ExecuteOnThreadPool |   6,822.9664 ns |    129.2295 ns |    126.9206 ns |   6,782.9533 ns | 0.1221 |     - |     - |     200 B |
|       ExecuteOnTask |   1,359.4584 ns |     21.2832 ns |     18.8670 ns |   1,356.6237 ns | 0.0954 |     - |     - |     152 B |
|     ExecuteOnThread | 407,056.7588 ns | 18,829.5764 ns | 54,327.6332 ns | 380,958.0171 ns | 4.8828 |     - |     - |     448 B |
