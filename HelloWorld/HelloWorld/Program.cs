using System.Reflection.Metadata.Ecma335;

class Program
{
    public static void Main(string[] args)
    {
        // string _userInput = Console.ReadLine();
        //
        // if(int.TryParse(_userInput, out int result) && result > 1 && result < 10)
        // {
        //     Console.WriteLine("Yeah! you entered the number between 1 and 10!");
        // }
        // else
        // {
        //     Console.WriteLine("Bad writing...");
        // }

        // string str = "ageOfandpirate";
        //
        // for (int i = 0; i < str.Length; i++)
        // {
        //     if (str[i] == 'a')
        //     {
        //         Console.WriteLine("Here is an 'a'!");
        //     }
        //     else
        //     {
        //         continue;
        //     }
        //
        //     Console.WriteLine("I will tell you when I find something");
        // }
        //
        // Console.WriteLine("Whoooh, ended");
        //
        // int j = 0;
        // while (true)
        // {
        //     if(j >= str.Length)
        //         break;
        //
        //     if (str[j] == 'f')
        //     {
        //         Console.WriteLine("here is an 'j'!");
        //         break;
        //     }
        //
        //     j++;
        // }


        // int counter = 0;
        // for (int i = 0; i <= 100; i++)
        // {
        //     if (i % 3 == 0)
        //         counter++;
        // }
        //
        // Console.WriteLine($"There is {counter} numbers which devides by 3 without remainder");

        // int summ = 0;
        // while (true)
        // {
        //     string enteredValue = Console.ReadLine();
        //
        //     if (int.TryParse(enteredValue, out int enteredNum))
        //     {
        //         summ += enteredNum;
        //     }
        //     else if (enteredValue == "Ok")
        //     {
        //         Console.WriteLine($"Summary of all numbers you entered is {summ}");
        //         break;
        //     }
        // }


        // Console.WriteLine("Enter a num to get it`s factiroal: ");
        // int.TryParse(Console.ReadLine(), out int enteredNum);
        // float numToMakeFacrotial = enteredNum;
        //
        // for (int i = enteredNum - 1; i > 0; i--)
        // {
        //     numToMakeFacrotial *= i;
        // }
        //
        // Console.WriteLine($"{enteredNum}! = {numToMakeFacrotial}");


        // int randomNumber = new Random().Next(1, 10);
        // Console.WriteLine("That \"random\" number is " + randomNumber);
        //
        // int tries = 4;
        // while (true)
        // {
        //     int.TryParse(Console.ReadLine(), out int guessNum);
        //     if (guessNum == randomNumber)
        //     {
        //         Console.WriteLine("Congratulations!! You guessed the word!");
        //     }
        //     else
        //     {
        //         if (tries <= 1)
        //         {
        //             Console.WriteLine("No tries. You lose.");
        //             break;
        //         }
        //         
        //         tries--;
        //         Console.WriteLine($"No! Not that num. You have {tries} Try again");
        //     }
        // }
        //
        // Console.ReadLine();


        Console.WriteLine("Enter the line like 5,3,8,1,4");
        string enteredString = Console.ReadLine();
        List<string> splittedString = enteredString.Split(',').ToList();

        int maxNum = 0;

        for (int i = 0; i < splittedString.Count; i++)
        {
            int convertedString = int.Parse(splittedString[i]);
            
            if (i == 0)
            {
                maxNum = convertedString;
                continue;
            }

            if (maxNum < convertedString)
            {
                maxNum = convertedString;
            }
        }

        Console.WriteLine($"Max num is = {maxNum}");
        Console.ReadLine();
    }
}