using PostboyConsole.Utilities;

namespace PostboyConsole.UI;

public class ConsoleApp
{
    private string title = "Welcome to Postboy Console UI!";
    private List<string> options = new List<string>()
    {
        "Call Menu", "Collection Menu (coming soon...)"
    };

    private readonly ViewModels.CallMenu _callMenu;

    public ConsoleApp(ViewModels.CallMenu mainMenu)
    {
        _callMenu = mainMenu;
    }

    public async Task RunAsync(CancellationToken cancellationToken)
    {
        while (!cancellationToken.IsCancellationRequested)
        {
            PrintUtility.PrintMenu(title, options);
            var input = InputUtility.InputMenu();

            if(int.TryParse(input, out int choice))
            {
                try
                {
                    switch(choice)
                    {
                        case 1:
                            PrintUtility.PrintOptionSelected(options[0]);
                            await _callMenu.ShowAsync();
                            // Handle POST logic
                            break;
                        case 2:
                            PrintUtility.PrintOptionSelected(options[1], false);
                            // Handle GET logic
                            break;
                        case 3:
                            PrintUtility.PrintOptionSelected("Exit");
                            Console.WriteLine("Exiting...");
                            return;
                        default:
                            PrintUtility.PrintOptionSelected();
                            break;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
            else
            {
                PrintUtility.PrintOptionSelected();
            }
        }
    }
}
