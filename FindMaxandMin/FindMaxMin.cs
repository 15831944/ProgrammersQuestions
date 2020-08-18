class FindMaxMin
{
	static void FindMaxMinNum(int[] a)
	{
		int minint = a[0];
		int maxint = a[0];

		foreach (int value in a)
		{
			if (value < minint)
				minint = value;
			if (value > maxint)
				maxint = value;
		}
		Console.WriteLine("Max {0} \n Min {1}",maxint, minint);
	}

	public static void Main(string[] args)
	{
		int[] array = {2, 3, 4, 9, 10, 32, 123};
		FindMaxMinNum(array);
	}
}
