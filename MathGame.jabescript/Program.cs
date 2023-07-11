namespace MathGame.jabescript;
public class Program
{
    public static void Main(string[] args)
    {
        bool isQuit = true;
        var date = DateTime.UtcNow;
        Console.Write("Please enter your name: ");
        string? username = Console.ReadLine();

        do
        {
            Console.WriteLine($"\nWelcome to Math Game Console, {username}! Today is {date.DayOfWeek}. Please enter an option from the list below:\n"
              + "1 - Start Game\n"
              + "2 - Exit\n");
<<<<<<< HEAD
            Console.Write($"{username}: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Game g = new();
                    break;
                case "2": Console.WriteLine("Goodbye!"); isQuit = false; break;
=======
            System.Console.Write($"{username}: ");

            switch (Console.ReadLine())
            {
                case "1": break;
                case "2": Console.WriteLine("Goodbye!"); Environment.Exit(0); break;
>>>>>>> 79ba90a4b79c8a654f9b10c1c736fa148cd8f403
                default: Console.WriteLine("Please enter a number."); break;
            }
        } while (isQuit);
    }
}
