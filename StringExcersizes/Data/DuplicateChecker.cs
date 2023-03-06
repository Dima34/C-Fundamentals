
using System;

public class DuplicateChecker
{
	public DuplicateChecker()
	{
        Console.WriteLine("Write a sequence separated by '-'");
        string inputLine = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(inputLine)) {
            Console.WriteLine("Input is null! Ending.");
            return;
        }
        

        string[] splittedInput = inputLine.Split("-");
        List<int> splittedIntInput = new List<int>();

        foreach (var value in splittedInput)
        {
            int.TryParse(value, out int res);
            splittedIntInput.Add(res);
        }

        var inputSet = splittedInput.ToHashSet();

        if (inputSet.Count != splittedIntInput.Count) {
            Console.WriteLine("there are repeats!");
        }
        else
        {
            Console.WriteLine("All right! there are no repeats!");
        }


        Console.ReadLine();
    }
}


