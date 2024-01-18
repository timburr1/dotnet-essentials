DateTime today = DateTime.Today;

while (true)
{
    Console.WriteLine("Which date? (Or 'exit' to quit)");
    string input = Console.ReadLine();

    if ("exit" == input.Trim().ToLower())
    {
        Console.WriteLine("Goodbye");
        break;
    }

    DateTime test;
    if (DateTime.TryParse(input, out test))
    {
        //Console.WriteLine(test);
        TimeSpan diff;

        if (test < today)
        {
            diff = today - test;
            Console.WriteLine($"That was {diff.Days} days ago");
        }
        else if (test > today)
        {
            diff = test - today;
            Console.WriteLine($"That is {diff.Days} days from now");
        }
        else
        {
            Console.WriteLine("That is today!");
        }

    }
    else
    {
        Console.WriteLine($"Could not parse {input}");
    }
}