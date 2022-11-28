namespace Program
{
    class Program
    {
        static void StartGame()
        {
            Console.WriteLine("Welcome to the 9/11 Dispatch simulator!");
            Console.WriteLine("SELECT from three available gamemodes: SOLO - You vs Reality | COOP - You vs Trainer");
            string answer = "";
            while (answer != "SOLO" && answer != "COOP")
            {
                Console.Write("Choose wisely: ");
                answer = Console.ReadLine();
            }
            switch (answer)
            {
                case "SOLO":
                    GamePVE gamePVE = new();
                    break;
                case "COOP":
                    GamePVP gamePVP = new();
                    break;
            }

        }
        static void Main()
        {
            StartGame();
        }
    }
}