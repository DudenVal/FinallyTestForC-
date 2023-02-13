// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] array =
{
    "a", "bb", "ccc", "dddd", "ee2ee", "z"
};

var result = new string[array.Length];
var i = 0;
foreach (var value in array)
{
    if (value.Length <= 3)
    {
        result[i] = value;
        i++;
    }
}

Console.WriteLine(string.Join(Environment.NewLine, result, 0, i));