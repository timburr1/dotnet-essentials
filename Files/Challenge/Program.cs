
const string inputDir = "FileCollection";
const string resultFile = "results.txt";

int excelFiles = 0, wordFiles = 0, powerpointFiles = 0;
long excelFileSize = 0, wordFileSize = 0, powerpointFileSize = 0;

List<string> filenames = new List<string>(Directory.EnumerateFiles(inputDir));
foreach (string f in filenames)
{
    //Console.WriteLine(f);
    if (f.EndsWith(".docx"))
    {
        wordFiles += 1;

        FileInfo fi = new FileInfo(f);
        wordFileSize += fi.Length;
    }
    else if (f.EndsWith(".xlsx"))
    {
        excelFiles += 1;

        FileInfo fi = new FileInfo(f);
        excelFileSize += fi.Length;
    }
    else if (f.EndsWith(".pptx"))
    {
        powerpointFiles += 1;

        FileInfo fi = new FileInfo(f);
        powerpointFileSize += fi.Length;
    }
    else
    {
        // NO OP
    }
}

if (File.Exists(resultFile))
{
    File.Delete(resultFile);
}
else
{
    File.Create(resultFile);
}

using (StreamWriter sw = File.AppendText(resultFile))
{
    sw.WriteLine("~~~~ Results ~~~~");
    sw.WriteLine($"Total Files: {wordFiles + excelFiles + powerpointFiles}");
    sw.WriteLine($"Excel Count: {excelFiles}");
    sw.WriteLine($"Word Count: {wordFiles}");
    sw.WriteLine($"PowerPoint Count: {powerpointFiles}");
    sw.WriteLine("----");
    sw.WriteLine($"Total Size: {wordFileSize + excelFileSize + powerpointFileSize:N0}");
    sw.WriteLine($"Excel Size: {excelFileSize:N0}");
    sw.WriteLine($"Word Size: {wordFileSize:N0}");
    sw.WriteLine($"PowerPoint Size: {powerpointFileSize:N0}");
}