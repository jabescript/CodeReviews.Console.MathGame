namespace MathGame.jabescript;
public class Program
{
    public static void Main(string[] args)
    {
        var date = DateTime.UtcNow;
        Console.Write("Please enter your name: ");
        string? username = Console.ReadLine();
        while (true)
        {
            Console.WriteLine($"\nWelcome to Math Game Console, {username}! Today is {date.DayOfWeek}. Please enter an option from the list below:\n"
              + "1 - Start Game\n"
              + "2 - Exit\n");
            System.Console.Write($"{username}: ");
            switch (Console.ReadLine())
            {
                case "1": break;
                case "2": Console.WriteLine("Goodbye!"); break;
                default: Console.WriteLine("Please enter a number."); break;
            }
        }
    }
}
