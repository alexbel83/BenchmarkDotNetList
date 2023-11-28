```

BenchmarkDotNet v0.13.10, Windows 10 (10.0.19045.3570/22H2/2022Update)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.103
  [Host]     : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT AVX2


```
| Method            | count | Mean      | Error     | StdDev    |
|------------------ |------ |----------:|----------:|----------:|
| CheckEmptyByCount | 20000 |  4.956 μs | 0.0571 μs | 0.0534 μs |
| CheckEmptyByAny   | 20000 | 95.696 μs | 1.8916 μs | 4.4215 μs |
