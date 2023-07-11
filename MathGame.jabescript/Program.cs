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
            Console.Write($"{username}: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Game g = new();
                    break;
                case "2": Console.WriteLine("Goodbye!"); isQuit = false; break;
                default: Console.WriteLine("Please enter a number."); break;
            }
        } while (isQuit);
    }
}
