using System;

namespace ClickerOO
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 0;

            // flip
            int tmp = x;
            x = y;
            y = tmp;

            var point = new Point(5, 0);
            point.Flip();
        }

        static void Main2(string[] args)
        {
            var game = new ClickerGame();
            //game.SetPoints(100);
            //game.Points = 1000;
            Console.WriteLine(game.Points);
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Poeng: " + game.Points);
                var keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.A) game.Click();
                if (keyInfo.Key == ConsoleKey.U) game.Upgrade();
            }
        }

        static void Main3(string[] args)
        {
            var game1 = new ClickerGame();
            var game2 = new ClickerGame();
            //var game3 = new ClickerGame(1000, 1000);
            game1.Click();
            game1.Click();
            //game2.Click();
            //var logger = new Logger();
            //var logger = Logger.GetLogger();
            //logger.Log("jhgjhg");
            //logger.Log("kjh", new DateTime(2020, 10,10), "terje")
        }
    }
}
