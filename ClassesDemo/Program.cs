using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Box myBox = new Box(3, 3);
            Box myBox2 = new Box(3, 3, 3);
            Box myBox3 = new Box(3, 3, 3, true);
            Box myBox4 = new Box();
            Box myBox5 = new Box();
            Box myBox6 = new Box();
            Box myBox7 = new Box();
            myBox.Print();
            // Console.WriteLine(myBox.length);

            myBox.Full = true;
            myBox.Print();
            
            
            Console.ReadLine();



        }
    }

    class Box
    {
        private static int boxCount;
        private int length;
        private int width;
        private int height;
        private bool full;

        public bool Full
        {
            get
            {
                return full;
            }
            set
            {
                full = value;
            }
        }

        public Box() // The DEFAULT CONSTRUCTOR
        {
            boxCount++;
            this.length = 1;
            this.width = 2;
            this.height = 3;
            this.full = false;

            Console.WriteLine("Created Box Number " + boxCount);
        }

        public Box(int _length, int _width, int _height, bool _full) // An OVERLOADED CONSTRUCTOR
        {
            boxCount++;
            this.length = _length;
            this.width = _width;
            this.height = _height;
            this.full = _full;

            Console.WriteLine("Created Box Number " + boxCount);
        }
        public Box(int _length, int _width)//, int _height) // An OVERLOADED CONSTRUCTOR
        {
            boxCount++;
            this.length = _length;
            this.width = _width;
            //            this.height = _height;
            this.full = false;

            Console.WriteLine("Created Box Number " + boxCount);
        }
        public Box(int _length, int _width, int _height) // An OVERLOADED CONSTRUCTOR
        {
            boxCount++;
            this.length = _length;
            this.width = _width;
            this.height = _height;
            this.full = false;

            Console.WriteLine("Created Box Number " + boxCount);
        }

        public void Print()
        {
            Console.WriteLine("( l , w , h ) == (\t" + this.length + ",\t" + width + ",\t" + height + ")");
            Console.WriteLine("Volume: " + computeVolume());
            Console.WriteLine("Full: " + full);
        }

        private int computeVolume()
        {
            return length*width*height;  // Does not use "this" keyword
        }

    }
}
