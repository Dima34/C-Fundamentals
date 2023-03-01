using System.Text;

StringBuilder builder = new StringBuilder();
builder.Append('-', 10);
builder.AppendLine();
builder.Append("Header");
builder.AppendLine();
builder.Append('-', 10);
builder.AppendLine();
Console.WriteLine(builder);

builder.Replace('-', '+')
                .Remove(0,10)
                .Insert(0, new string('-', 10));
Console.WriteLine(builder);


Console.ReadLine();
