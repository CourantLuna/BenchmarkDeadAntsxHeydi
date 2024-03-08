namespace src;
using System;

class Program
{   
        static void Main(string[] args)
        {
           Console.WriteLine(DeadAntsCounter.CountDeadAntsOpt("ant....ant..a..t..a..a..a"));
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
