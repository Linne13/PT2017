using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace SnakeS
{
    class Program
    {
        static void Serialize(Game q)
        {

            XmlSerializer xs = new XmlSerializer(typeof(Game));

            FileStream fs = new FileStream("complex.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            xs.Serialize(fs, q);
            fs.Close();
        }
        static Game Deserialize()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Game));
            FileStream fs2 = new FileStream("complex.txt", FileMode.Open, FileAccess.Read);
            Game h = new Game();
            h = xs.Deserialize(fs2) as Game;
            fs2.Close();
            return h;

        }
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(60, 40);
            Snake snake = new Snake();
            Food food = new Food();
            Wall wall = new Wall(1);
            snake.Start();
            while (snake.isAlive)
            {
                Console.Clear();
                snake.Draw();
                food.Draw();

                int currx = snake.Getheadx();
                int curry = snake.Getheady();
                int k = wall.Draw(currx, curry);
                if (k == 1) { break; }
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                switch (pressedKey.Key)
                {
                    case ConsoleKey.F8:
                        Game q = new Game(snake, wall, food);
                        Serialize(q);
                        break;
                    case ConsoleKey.F9:

                        Game h = Deserialize();
                        snake = h.snake;
                        food = h.food;
                        wall = h.wall;

                        break;
                    case ConsoleKey.UpArrow:
                        snake.Move(0, -1);
                        break;
                    case ConsoleKey.DownArrow:
                        snake.Move(0, 1);
                        break;
                    case ConsoleKey.LeftArrow:
                        snake.Move(-1, 0);
                        break;
                    case ConsoleKey.RightArrow:
                        snake.Move(1, 0);
                        break;
                    case ConsoleKey.Escape:
                        snake.isAlive = false;
                        break;
                }

                if (snake.CanEat(food))
                {
                    food = new Food();
                }
            }
            Console.Clear();
            Console.WriteLine("YOU LOSE");
        }
    }
}
