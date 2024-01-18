// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Creating and Deleting Directories

const string dirname = "TestDir";

// Create a Directory if it doesn't already exist
if (!Directory.Exists(dirname))
{
    Directory.CreateDirectory(dirname);
}
else
{
    Directory.Delete(dirname);
}

// Get the path for the current directory
string path = Directory.GetCurrentDirectory();
// Console.WriteLine(path);

// Just like with files, you can retrieve info about a directory
DirectoryInfo di = new DirectoryInfo(path);
Console.WriteLine($"{di.Name}");
Console.WriteLine($"{di.Parent}");
Console.WriteLine($"{di.CreationTime}");

// Enumerate the contents of directories
Console.WriteLine("Just directories:");
List<string> dirs = new List<string>(Directory.EnumerateDirectories(path));
foreach (string dir in dirs)
{
    Console.WriteLine(dir);
}
Console.WriteLine("---------------");
Console.WriteLine("Just files:");
List<string> files = new List<string>(Directory.EnumerateFiles(path));
foreach (string file in files)
{
    Console.WriteLine(file);
}
Console.WriteLine("---------------");
Console.WriteLine("All directory contents:");
List<string> entries = new List<string>(Directory.EnumerateFileSystemEntries(path));
foreach (string entry in entries)
{
    Console.WriteLine(entry);
}