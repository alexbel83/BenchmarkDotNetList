```

BenchmarkDotNet v0.13.10, Windows 10 (10.0.19045.3570/22H2/2022Update)
11th Gen Intel Core i7-1165G7 2.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 7.0.103
  [Host]     : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 7.0.14 (7.0.1423.51910), X64 RyuJIT AVX2


```
| Method                      | count | Mean        | Error     | StdDev    | Median      |
|---------------------------- |------ |------------:|----------:|----------:|------------:|
| **AddStructToList**             | **5000**  |    **64.53 μs** |  **1.387 μs** |  **4.002 μs** |    **63.43 μs** |
| AddStructToListWithCapacity | 5000  |    13.88 μs |  0.263 μs |  0.417 μs |    13.81 μs |
| AddClassToList              | 5000  |    41.10 μs |  0.729 μs |  1.761 μs |    41.03 μs |
| AddClassToListWithCapacity  | 5000  |    32.51 μs |  0.631 μs |  1.675 μs |    32.32 μs |
| **AddStructToList**             | **20000** |   **334.89 μs** |  **6.092 μs** |  **5.400 μs** |   **333.52 μs** |
| AddStructToListWithCapacity | 20000 |   149.86 μs |  2.972 μs |  6.647 μs |   149.20 μs |
| AddClassToList              | 20000 |   414.20 μs |  7.755 μs | 10.083 μs |   414.02 μs |
| AddClassToListWithCapacity  | 20000 | 1,005.57 μs | 19.031 μs | 33.827 μs | 1,001.24 μs |
