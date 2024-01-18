// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Reading and Writing data from and to files

// Make sure the example file exists
const string filename = "TestFile.txt";

// WriteAllText overwrites a file with the given content
if (!File.Exists(filename))
{
    File.WriteAllText(filename, "This is a text file.");
}

// AppendAllText adds text to an existing file
File.AppendAllText(filename, "This text should be appended to the end of the file.");

// A FileStream can be opened and written to until closed
using (StreamWriter sw = File.AppendText(filename))
{
    sw.WriteLine("Line 1");
    sw.WriteLine("Line 2");
    sw.WriteLine("Line 3");
}

// ReadAllText reads all the content from a file
string content = File.ReadAllText(filename);
Console.WriteLine(content);