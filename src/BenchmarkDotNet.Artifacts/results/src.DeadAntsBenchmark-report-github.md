```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.3155/22H2/2022Update/SunValley2)
Intel Core i5-8250U CPU 1.60GHz (Kaby Lake R), 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.100
  [Host]     : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2


```
| Method                    | Mean     | Error    | StdDev   | Allocated |
|-------------------------- |---------:|---------:|---------:|----------:|
| BenchmarkCountDeadAnts    | 20.79 ms | 0.853 ms | 2.514 ms |  580283 B |
| BenchmarkCountDeadAntsOpt | 10.45 ms | 0.220 ms | 0.648 ms |     198 B |
