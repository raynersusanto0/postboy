using System;

namespace PostboyConsole.Utilities;

public class InputUtility
{
    public static string? InputMenu()
    {
        var input = Console.ReadLine();
        Console.Clear();
        return input;
    }
}
