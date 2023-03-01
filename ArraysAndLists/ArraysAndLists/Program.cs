using System.Text;
using System.Threading.Channels;
using ArraysAndLists;

// var arr = new int[5]{1,3,4,5,6};
// var arr1 = new int[5];
//
// Array.Copy(arr, arr1,3);
// Console.WriteLine("Copied array " + GetArrayString(arr1));
// Array.Clear(arr1);
//
// Array.Copy(arr, 2, arr1, 0, 2);
// Console.WriteLine("Copied array " + GetArrayString(arr1));
//
// Array.Clear(arr, 0, 2);
// Console.WriteLine(GetArrayString(arr));
//
// Array.Clear(arr);
// Console.WriteLine(GetArrayString(arr));
//
//
// List<int> list = new List<int>() { 1, 5, 3, 6, 2, 6, 1, 6, 4, 23, 1, 5 };
//
//
// for (int i = 0; i < list.Count; i++)
// {
//     if (list[i] == 1)
//         list.Remove(list[i]);
// }
// Console.WriteLine("The list is: ");
// foreach (var num in list)
// {
//     Console.WriteLine(num);
// }
//
//
// Console.ReadLine();
//
// string GetArrayString(int[] array)
// {
//     StringBuilder builder = new StringBuilder();
//     builder.Append("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i > 0)
//         {
//             builder.Append(", ");
//         }
//         builder.Append(array[i].ToString());
//     }
//     builder.Append("]");
//     return builder.ToString();
// }

// new FriendLikes().Execute();
// new NameReverse().Execute();
// new NumberSorter().Execute();
// new UniqueNumbers().Execute();
new SmallestNumbers().Execute();

Console.ReadLine();