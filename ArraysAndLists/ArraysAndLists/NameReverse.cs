namespace ArraysAndLists;

public class NameReverse
{
    public void Execute()
    {
        Console.Write("Enter a name to rewerse: ");
        string enteredUsername = Console.ReadLine();
        string reversedName = "";

        char[] nameArray = enteredUsername.ToArray();
        for (int i = nameArray.Length - 1; i >= 0; i--)
        {
            reversedName += enteredUsername[i];
        }

        Console.WriteLine($"rewersed name {reversedName}");
    }
}