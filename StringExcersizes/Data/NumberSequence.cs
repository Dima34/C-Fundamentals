using System;

public class NumberSequence
{
	public NumberSequence()
	{
        Console.WriteLine("Write a sequence like 1-2-4-5-6");
        string inputLine = Console.ReadLine();

        string[] splittedInput = inputLine.Split("-");
        bool isLower = true;

        for (int i = 0; i < splittedInput.Length - 1; i++)
        {
            int firstNumber = int.Parse(splittedInput[i]);
            int secondNumber = int.Parse(splittedInput[i + 1]);
            bool isFirstGreater = firstNumber > secondNumber;


            if (i == 0)
            {
                if (isFirstGreater)
                    isLower = false;

                continue;
            }

            if (isFirstGreater == isLower)
            {
                Console.WriteLine("Bad sequence. Try to enter it again");
                break;
            }

            if (isFirstGreater != isLower && i == splittedInput.Length - 2)
            {
                Console.WriteLine("All right!");
            }
        }

        Console.ReadLine();
    }

}
