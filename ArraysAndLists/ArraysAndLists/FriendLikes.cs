namespace ArraysAndLists;

public class FriendLikes
{
    public void Execute()
    {
        List<string> friendNames = new List<string>();

        while (true)
        {
            Console.WriteLine("Enter a friend name: ");
            string inputLine = Console.ReadLine();

            if (inputLine == String.Empty)
            {
                if (friendNames.Count == 0)
                    break;

                if (friendNames.Count == 1)
                {
                    Console.WriteLine($"{friendNames[0]} likes your post");
                    break;
                }

                if (friendNames.Count == 2)
                {
                    Console.WriteLine($"{friendNames[0]} and {friendNames[1]} like your post");
                    break;
                }
                
                Console.WriteLine($"{friendNames[0]}, {friendNames[1]} and {friendNames.Count-2} others like your post");
                break;
            }
            
            friendNames.Add(inputLine);
        }

        Console.WriteLine("Friend typing ended");
    }
}