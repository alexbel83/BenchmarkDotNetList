```

BenchmarkDotNet v0.13.10, Windows 10 (10.0.19045.3570/22H2/2022Update)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.103
  [Host]     : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT AVX2


```
| Method                | count | Mean        | Error       | StdDev      |
|---------------------- |------ |------------:|------------:|------------:|
| **AddToList**             | **100**   |    **242.0 ns** |     **4.14 ns** |     **3.87 ns** |
| AddToListWithCapacity | 100   |    181.9 ns |     3.51 ns |     3.28 ns |
| **AddToList**             | **5000**  | **11,632.7 ns** |   **209.36 ns** |   **185.59 ns** |
| AddToListWithCapacity | 5000  |  9,730.4 ns |   123.87 ns |   103.44 ns |
| **AddToList**             | **20000** | **86,717.7 ns** | **1,232.79 ns** | **1,029.44 ns** |
| AddToListWithCapacity | 20000 | 39,083.6 ns |   407.91 ns |   340.63 ns |
