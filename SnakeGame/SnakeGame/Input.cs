using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    class Input
    {
        private static Hashtable keyTable = new Hashtable();

        //perform a check see if a particular button is pressed
        public static bool KeyPressed(Keys key)
        {
            if(keyTable[key]==null)
            {
                return false;
            }
            return (bool)keyTable[key];
        }

        //detect if a keyboard button is pressed
        public static void changeState(Keys key,bool state)
        {
            keyTable[key] = state;
        }

    }
}
