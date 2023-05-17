using System;
using System.Diagnostics;

class Test
{
	static void Main()
	{
        Console.Clear();

		Console.WriteLine("Enter to start!");
		var start = Console.ReadLine();

		Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

		int correct = 0;
		int wrong = 0;

		int i = 0;
		while (i < 5) 
		{
			Random randomGenerator = new Random();
			int f1 = randomGenerator.Next(0,10);
			int f2 = randomGenerator.Next(0,10);

			int sum = f1 * f2;
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(f1 + "*" + f2);
			var input = Console.ReadLine();
			int result = Int32.Parse(input);

			if (sum == result) {
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Rätt!");
				correct++;
			} else {
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Fel!");
				wrong++;
			}
  			i++;
		}

		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("Antal rätt: " + correct);
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine("Antal fel: " + wrong);

		Console.ForegroundColor = ConsoleColor.Yellow;

		Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);

	}

}


