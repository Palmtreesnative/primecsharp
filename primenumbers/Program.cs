using System;

namespace primenumbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			DateTime starttime = DateTime.Now;
			int max = 10000000;
			int b = 2;
			for (int i = 1; i < max; i += b) {
				int c = 0;
				for (int j = 1; j != Math.Round(Math.Sqrt(i)) + 1; j++) {
					if (i % j == 0) {
						c++;
					}
					if (c > 1) {
						break;
					}
				}
				//if (c == 1) {
				//	Console.WriteLine (i);
				//}
				b = 6 - b;
			}
			TimeSpan tempsecoule = DateTime.Now - starttime;
			Console.WriteLine (tempsecoule);
		}
	}
}
