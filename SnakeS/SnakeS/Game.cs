using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace SnakeS
{
    public class Game
    {
        public Snake snake;
        public Wall wall;
        public Food food;

        public Game()
        { }

        public Game(Snake snake, Wall wall, Food food)
        {

            this.snake = snake;
            this.wall = wall;
            this.food = food;


        }

    }
}
