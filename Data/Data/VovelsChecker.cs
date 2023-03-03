using System;

public class VovelsChecker
{
	public VovelsChecker()
	{
		char[] vovels = new char[] { 'a', 'e', 'o', 'u', 'i' };

		Console.WriteLine("Enter word:");
		string inputString = Console.ReadLine();

		int vovelsAmount = 0;
		foreach (var ch in inputString)
		{
			if (vovels.Contains(ch))
				vovelsAmount++;
        }

		Console.WriteLine($"That word has {vovelsAmount} vovels");
    }
}


