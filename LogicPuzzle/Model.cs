using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicPuzzle
{
    class Model
    {
        private bool[] switches;

        public Model()
        {
            switches = new bool[4];
        }

        public bool[] getSwitches()
        {
            return switches;
        }

        public void flip(char input)
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

        public bool solved()
        {
            for (int i = 0; i < switches.Length; i++)
                if (!switches[i])
                    return false;
            return true;
        }
    }
}
