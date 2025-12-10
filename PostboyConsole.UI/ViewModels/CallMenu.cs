using System;
using PostboyConsole.Utilities;
using static PostboyConsole.Utilities.PrintUtility;

namespace PostboyConsole.UI.ViewModels;

public class CallMenu
{
    private string title = "Call Menu";
    private List<string> options = new List<string>()
    {
        "Get", "Post"
    };

    public async Task ShowAsync()
    {
        bool loadMenu = true;
        
        while (loadMenu)
        {
            PrintUtility.PrintMenu(title, options);
            var input = InputUtility.InputMenu();

            if (int.TryParse(input, out int choice))
            {
                try
                {
                    switch (choice)
                    {
                        case 1:
                            PrintUtility.PrintOptionSelected(options[0]);
                            break;
                        case 2:
                            PrintUtility.PrintOptionSelected(options[1]);
                            break;
                        case 3:
                            PrintUtility.PrintOptionSelected("Exit");
                            loadMenu = false;
                            break;
                        default:
                            PrintUtility.PrintOptionSelected();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    PrintUtility.PrintError(ex);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }

    }
}
