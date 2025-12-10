namespace PostboyConsole.Utilities;

public static class PrintUtility
{
    private static TextWriter _errorWriter = Console.Error;

    public static void PrintMenu(string text, List<string> options)
    {
        Console.WriteLine($"\n --- {text} --- \n");
        Console.WriteLine("Choose from the options below");

        for (int i = 0; i < options.Count(); i++)
        {
            Console.WriteLine($"{i+1}. {options[i]}");
        }

        Console.WriteLine($"{options.Count() + 1}. Exit");
        Console.WriteLine();

    }

    public static void PrintOptionSelected(string text = "", bool avail = true)
    {
        string reply = "";
        switch (text.ToLower())
        {
            case "exit":
                reply = "Exiting";
                Console.WriteLine("Exiting...");
                break;
            case "":
                reply = "No choice was picked, please choose a valid number...";
                Console.WriteLine("No choice was picked, please choose a valid number...");
                break;
            default:
                reply = $"Picked {text} option!";
                Console.WriteLine($"Picked {text} option!");

                if (!avail)
                {
                    reply = $"{text} option is not ready... please pick a different number";
                    Console.WriteLine($"{text} option is not ready... please pick a different number");
                }
                break;
        }

        for (int i = 0; i < reply.Count() + 10; i++)
        {
            Console.Write("-");
        }

        Console.WriteLine();
    }

    public static void PrintError(Exception ex)
    {
        _errorWriter.WriteLine($"An error occurred: {ex.Message}");
        _errorWriter.WriteLine($"Error was caught in trace: {ex.StackTrace}");
    }
}
