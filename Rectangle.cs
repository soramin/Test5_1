using System;
using System.Collections.Generic;
using System.Text;

namespace Test5_1
{
    class Rectangle
    {
        private int height = new int();
        private int width = new int();

        private int Height
        {
            get
            {
                return height;
            }
            set
            {
                this.height = (value < 10 ? 10 : value);
            }
        }

        private int Width
        {
            get
            {
                return width;
            }
            set
            {
                this.width = (value < 10 ? 10 : value);
            }
        }

        public int Menseki()
        {
           height = 3;
           width = 3;

            return height * width;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("$長方形の面積は{Menseki}です。");
        }
    }
}
