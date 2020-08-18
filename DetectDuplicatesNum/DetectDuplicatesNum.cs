using System;
using System.Collections.Generic;

static void Main(string[] args)
{
	int[] array = {10, 5, 10, 2, 2, 4, 4, 5};
	var dict = new Dictionary<int, int>();

	foreach (var value in array)
	{
		if (dict.ContaisKey(value))
			dict[value]++;
		else
			dict[value] = 1;
	}
	foreach
		Console.WriteLine("Value {0} occured {1} times", pair.Key, pair.Value);
	Console.ReadKey();
}
