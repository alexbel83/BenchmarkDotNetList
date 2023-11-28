```

BenchmarkDotNet v0.13.10, Windows 10 (10.0.19045.3570/22H2/2022Update)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.103
  [Host]     : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT AVX2


```
| Method       | count   | Mean     | Error     | StdDev    |
|------------- |-------- |---------:|----------:|----------:|
| CheckForeach | 2000000 | 5.021 ms | 0.0993 ms | 0.2340 ms |
| CheckFor     | 2000000 | 4.976 ms | 0.0956 ms | 0.2535 ms |
