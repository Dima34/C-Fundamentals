using System.IO;
using System.Reflection.Metadata;

const string FILE_PATH = "/Users/macbook/Documents/C-Fundamentals/FileManipulation/FileManipulation/"; 

// var file = File.CreateText(FILE_PATH + "example.txt");
// file.WriteLine("Hello world!");
// file.Close(); // !Each filestream should be closed

// File.Copy(FILE_PATH + "example.txt", FILE_PATH + "copiedFile.txt");
// File.Delete(FILE_PATH + "copiedFile.txt"); // deletes the file

// File info examples
// FileInfo fi = new FileInfo(FILE_PATH + "example.txt");
// fi.CopyTo(FILE_PATH + "copiedFile.txt");

// DirectoryInfo di = Directory.CreateDirectory(FILE_PATH + "testDirectory");
// foreach (var directoryInfo in di.Parent.GetFiles("*.txt"))
// {
//     Console.WriteLine(directoryInfo.Name);
// }


// searches the longest one
var strings = File.ReadLines(FILE_PATH + "example.txt");

int wordAmount = 0;
string longestWord = "";
foreach (var s in strings)
{
    List<string> stringWords = s.Split(' ').ToList();
    
    foreach (var stringWord in stringWords)
    {
        if (stringWord.Length > longestWord.Length)
            longestWord = stringWord;
    }

    wordAmount += stringWords.Count;

}

Console.WriteLine($"Words in that file {wordAmount}");
Console.WriteLine($"The longest word is \"{longestWord}\" and its lenght {longestWord.Length}");

Console.WriteLine();


// ! Using File and Directory better when we need to  make one operation because it`s no need to 
//   create an instance. But if we need to make bunch of operations static classes will be worst because
//   it contains lots of checkings inside. In that case we should use FileInfo or DirectoryInfo 