// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Example file for parsing numerical data from strings

string[] NumStrs = { "  1 ", " 1.45  ", "-100", "5e+04 " };

int testint;
float testfloat;
bool result;

// The Parse method attempts to parse a string to a number and
// throws an exception if the parse is unsuccessful
foreach (string str in NumStrs)
{
    try
    {
        testfloat = float.Parse(str);
        Console.WriteLine($"Parsed as float: {testfloat}");

        testint = int.Parse(str);
        Console.WriteLine($"Parsed as int: {testint}");
    }
    catch (FormatException e)
    {
        Console.WriteLine($"Could not parse {str}: {e.Message}");
    }
}

// The TryParse method returns 'true' if the parse is successful
foreach (string str in NumStrs)
{
    result = float.TryParse(str, out testfloat);
    Console.WriteLine($"{result} -- {str}: {testfloat}");
    result = int.TryParse(str, out testint);
    Console.WriteLine($"{result} -- {str}: {testint}");
}