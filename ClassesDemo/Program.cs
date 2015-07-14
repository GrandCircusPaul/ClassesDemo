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
}
