using System.Text;

namespace ArraysAndLists;

public class UniqueNumbers
{
    public void Execute()
    {
        List<int> numbers = new List<int>();

        while (true)
        {
            Console.Write("Enter number: ");
            string inputString = Console.ReadLine();

            if(inputString == "Quit")
                break;
            
            int convertedNum = Int32.Parse(inputString);
            numbers.Add(convertedNum);
        }

        List<int> uniqueNumbers = numbers.Where(num => numbers.FindAll(x => x == num).Count == 1).ToList();
        StringBuilder sb = new StringBuilder();
        sb.Append("uniqueNumbers is [");
        foreach (var number in uniqueNumbers)
        {
            sb.Append($"{number},");
        }

        sb.Remove(sb.Length - 1,1);
        sb.Append("]");
        Console.WriteLine(sb);
    }
}