using System;
using System.Linq;

public class CameCaseWriter
{
	public CameCaseWriter()
	{
        Console.WriteLine("Write a few separated words");
		string inputLine = Console.ReadLine();

		List<string> inputArray = inputLine.Split(' ').ToList();
		List<string> resultArray = new List<string>();

		foreach (var elem in inputArray)
		{
			string resultString = elem.ToLower();
            resultString = char.ToUpper(resultString[0]) + resultString.Substring(1);
			resultArray.Add(resultString);
		}

        Console.WriteLine(String.Join("", resultArray));
	}
}
