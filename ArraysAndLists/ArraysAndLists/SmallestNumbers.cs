using System.Text;

namespace ArraysAndLists;

public class SmallestNumbers
{
    public void Execute()
    {
        List<int> numbers = new List<int>();

        while (true)
        {
            Console.Write("Write a string like 5, 1, 9, 2, 10: ");
            string inputString = Console.ReadLine();
            List<string> separatedString = inputString.Replace(" ", String.Empty).Split(",").ToList();

            if (separatedString.Count < 5)
            {
                Console.WriteLine("Invalid string");
                continue;
            }

            List<int> numbersList = new List<int>();
            separatedString.ForEach(x=> numbersList.Add(Int32.Parse(x)));
            
            numbersList.Sort();
            
            StringBuilder sb = new StringBuilder();
            sb.Append("smallest numbers is [");
            foreach (var number in numbersList.GetRange(0,3))
            {
                sb.Append($"{number},");
            }

            sb.Remove(sb.Length - 1,1);
            sb.Append("]");
            Console.WriteLine(sb);
            
            break;
        }

    }
}