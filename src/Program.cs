namespace src;
using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

class Program
{   
        static void Main(string[] args)
        {
           Console.WriteLine(DeadAntsCounter.CountDeadAntsOpt("ant....ant..a..t..a..a..a"));
           BenchmarkRunner.Run<DeadAntsBenchmark>();
        }

}

public static class DeadAntsCounter
    {
            public static int CountDeadAnts(string input)
        {
            if (string.IsNullOrEmpty(input)) return 0;

            var cleanedInput = input.Replace("ant", string.Empty);
            var countA = cleanedInput.Count(c => c == 'a');
            var countN = cleanedInput.Count(c => c == 'n');
            var countT = cleanedInput.Count(c => c == 't');

            return new[] { countA, countN, countT }.Max();
        }

        public static int CountDeadAntsOpt(string input)
        {
            var count = new Dictionary<char, int> { { 'a', 0 }, { 'n', 0 }, { 't', 0 } };
            for (int i = 0; i < input.Length; i++)
            {
                if (i + 2 < input.Length && input[i] == 'a' && input[i + 1] == 'n' && input[i + 2] == 't')
                {
                    i += 2;
                }
                else if ("ant".Contains(input[i]))
                {
                    count[input[i]]++;
                }
            }
            return Math.Max(count['a'], Math.Max(count['n'], count['t']));
        }

    }

[MemoryDiagnoser] //Habilitar diagnostico de memoria
public class DeadAntsBenchmark 
{
    private string input = "...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t".Repeat(10000);

    [Benchmark]
    public void BenchmarkCountDeadAnts() => DeadAntsCounter.CountDeadAnts(input);

     [Benchmark]
    public void BenchmarkCountDeadAntsOpt() => DeadAntsCounter.CountDeadAntsOpt(input);
}


public static class Extensions{
    public static string Repeat (this string s, int n)
    {
        return new System.Text.StringBuilder(s.Length * n).Insert(0,s,n).ToString();
    }
}