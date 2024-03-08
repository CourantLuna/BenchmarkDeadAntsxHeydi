# DeadAntsCounter

This project contains two implementations for counting the maximum number of 'a', 'n', and 't' in a string, excluding consecutive 'ant' letters. Both a basic and an optimized implementation are provided.

## Video
If the author of the code is Heydi García with ID 1107303 at INTEC, you can find an explanatory video at this link: [Tutorial - Benchmarking DeadAnts](https://www.youtube.com/watch?v=VIDEO_ID)


## Implementation

Two implementations are provided:

1. `CountDeadAnts`: This implementation performs a simple count of the letters 'a', 'n', and 't', excluding 'ant' sequences.
2. `CountDeadAntsOpt`: This optimized implementation avoids counting 'a', 'n', and 't' within 'ant' sequences.

## Execution

To execute the benchmark and compare the performance of both implementations:

```bash
dotnet run -c Release
```

## Benchmark
Benchmarks for both implementations are included using BenchmarkDotNet. This allows comparing the performance of the two implementations.

## Dependencies
Ensure you have the following dependencies installed:

-  .NET SDK: The .NET Software Development Kit (SDK) is required to build and run the C# project. You can download it from here: [.NET SDK](https://dotnet.microsoft.com/download)
-  BenchmarkDotNet: BenchmarkDotNet is a powerful .NET library for benchmarking. It is used to compare the performance of different implementations. You can install it via NuGet using the following command:
```bash
   dotnet add package BenchmarkDotNet
```

