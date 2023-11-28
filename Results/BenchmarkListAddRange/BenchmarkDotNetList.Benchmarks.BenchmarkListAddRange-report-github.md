```

BenchmarkDotNet v0.13.10, Windows 10 (10.0.19045.3570/22H2/2022Update)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.103
  [Host]     : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT AVX2


```
| Method         | count | Mean      | Error     | StdDev    | Median    |
|--------------- |------ |----------:|----------:|----------:|----------:|
| **AddToList**      | **5000**  | **12.149 μs** | **0.0911 μs** | **0.0852 μs** | **12.113 μs** |
| AddRangeToList | 5000  |  1.158 μs | 0.0195 μs | 0.0163 μs |  1.156 μs |
| **AddToList**      | **20000** | **88.814 μs** | **1.7588 μs** | **2.9866 μs** | **88.671 μs** |
| AddRangeToList | 20000 |  5.731 μs | 0.1134 μs | 0.2316 μs |  5.642 μs |
