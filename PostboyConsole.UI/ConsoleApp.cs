namespace PostboyConsole.UI;

public class ConsoleApp
{
    private readonly ViewModels.MainMenu _mainMenu;

    public ConsoleApp(ViewModels.MainMenu mainMenu)
    {
        _mainMenu = mainMenu;
    }

    public async Task RunAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("Welcome to Postboy Console UI!");
        while (!cancellationToken.IsCancellationRequested)
        {
            Console.WriteLine("Choose from the options below:");
            Console.WriteLine("1. POST  2. GET  3. Exit");
            var input = Console.ReadLine();

            if(int.TryParse(input, out int choice))
            {
                try
                {
                    switch(choice)
                    {
                        case 1:
                            Console.WriteLine("You selected POST.");
                            await _mainMenu.ShowAsync();
                            // Handle POST logic
                            break;
                        case 2:
                            Console.WriteLine("You selected GET.");
                            await _mainMenu.ShowAsync();
                            // Handle GET logic
                            break;
                        case 3:
                            Console.WriteLine("Exiting...");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
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
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }


        await _mainMenu.ShowAsync();
    }
}
