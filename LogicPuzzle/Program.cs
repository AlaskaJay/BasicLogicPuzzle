using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicPuzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            Model switches = new Model();
            char input = '0';

            Console.WriteLine("Hello, press any key besides n to play.");
            while(input != 'n' && !switches.solved()) {
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switches.flip(input);
                for(int i = 0; i < switches.getSwitches().Length; i++)
                {
                    Console.Write(switches.getSwitches()[i] + "\t");
                }
                Console.WriteLine();
            }
            if(switches.solved())
                Console.WriteLine("You won! Press any key to exit!");
            else
                Console.WriteLine("You left! Press any key to exit!");
            input = Console.ReadKey().KeyChar;
        }
        /*
        static void flip(char input, bool[] switches)
        {
            if (input == '0')
            {
                switches[0] = !switches[0];
                switches[1] = !switches[1];
            }
            if (input == '1')
            {
                switches[1] = !switches[1];
                switches[2] = switches[1];
            }
            if (input == '2')
            {
                switches[2] = !switches[2];
                switches[3] = !switches[3];
            }
            if (input == '3')
            {
                switches[1] = !switches[1];
                switches[3] = !switches[3];
            }
        }    

        static bool solved(bool[] switches)
        {
            for (int i = 0; i < switches.Length; i++)
                if (!switches[i])
                    return false;
            return true;
        }
        */
    }
}
