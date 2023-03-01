using System.Text;

namespace ArraysAndLists;

public class NumberSorter
{
    public void Execute()
    {
        List<int> numbers = new List<int>();

        while (numbers.Count < 5)
        {
            Console.Write("Enter number: ");
            string numberString = Console.ReadLine();

            int convertedNum = Int32.Parse(numberString);
            if (numbers.Contains(convertedNum))
            {
                Console.WriteLine("That number you have been already enteder! Try something new.");
                continue;
            }

            numbers.Add(convertedNum);
        }
        
        numbers.Sort();

        StringBuilder sb = new StringBuilder();
        sb.Append("Sorted array is [");
        foreach (var number in numbers)
        {
            sb.Append($"{number},");
        }

        sb.Remove(sb.Length - 1,1);
        sb.Append("]");

        Console.WriteLine(sb);
    }
}