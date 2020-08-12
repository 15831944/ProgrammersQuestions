sing System;

class GFG
{
	static int getMissingNumber(int[] a, int n)
	{
		int total = (n + 1) * (n + 2) / 2;
		for (int i = 0; i < n; i++)
			total -= a[i];

		return total;
	}
	static void Main(string[] args)
	{
		int[] a = {  2, 3, 4, 5, 6 };
		int miss = getMissingNumber(a, 5);
		Console.Write($"missing number is {miss}");
	}
}

