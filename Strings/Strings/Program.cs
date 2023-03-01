using System.Globalization;

int number = 1235;
CultureInfo ci = new CultureInfo("en-us");
Console.WriteLine($"Currency {number.ToString("c01", ci)}");

float floatNumber = 123.2231f;

Console.WriteLine($"{floatNumber.ToString("F")}");

float price = 123.95f;
Console.WriteLine($"price {price.ToString("C0")}");

string name = "Dima Vavilov  ";
Console.WriteLine($"Trimmed Name - '{name.Trim()}'");
Console.WriteLine($"Uppered Name - '{name.ToUpper()}'");

int whiteSpaceIndex = name.IndexOf(' ');

Console.WriteLine($"Name {name.Substring(0, whiteSpaceIndex)}");
Console.WriteLine($"Surname {name.Substring(whiteSpaceIndex + 1)}");

Console.ReadLine();
