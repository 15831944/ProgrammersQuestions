using System;

class getMissingAllNums{
	static void findMissingNumbers(int[] a, int first, int last){
		for (int i = 1; i < a.[0]; i++)
			Console.WriteLine(i);
		for (int i = 1; i < a.Length; i++){
			for (int j = 1 + a[i - 1]; j < a[i]; j++)
				Console.WriteLine(j);
		}
		for (int i = 1 + a[a.Length - 1]; i <= last; i++)
			Console.WriteLine(i);
	}

	public static void Main(string[] arg)
	{
		int[] a = {2, 3, 4, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 18, 20, 21, 23};
		findMissingNumbers(a, 0, 25);
	}
}


