```

BenchmarkDotNet v0.13.10, Windows 10 (10.0.19045.3570/22H2/2022Update)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.103
  [Host]     : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT AVX2


```
| Method            | count | Mean          | Error        | StdDev        |
|------------------ |------ |--------------:|-------------:|--------------:|
| CheckBinarySearch | 50000 |      32.87 ns |     0.904 ns |      2.549 ns |
| CheckFirst        | 50000 | 375,814.04 ns | 6,929.736 ns | 10,788.764 ns |
