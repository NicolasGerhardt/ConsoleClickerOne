using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleClickerOne
{
    public class Game
    {
        public int Clicks { get; set; }
        public bool GameOver { get; set; }

        public Game()
        {
            Clicks = 0;
            GameOver = false;
        }

        public void GameLoop()
        {
            while (!GameOver)
            {
                Console.Clear();
                Console.WriteLine($"Clicks: {Clicks}");
                Console.Write($"Press enter to click");
                string input = Console.ReadLine();
                if (input == "")
                {
                    click(1);
                }
            }

            Console.WriteLine("GameOver");
        }

        public void click(int n)
        {
            Clicks += n;
        }
    }
}
