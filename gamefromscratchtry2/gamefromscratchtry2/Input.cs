using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace gamefromscratchtry2
{
    class Input
    {

        private static Hashtable keyTable = new Hashtable();

        public static bool KeyPressed(Keys key)
        {
            if (keyTable[key] == null)
            {
                return false;
            }
            return (bool)keyTable[key];
        }

        //ugotovi če je prtisnen gumb za gor dol levo desno je v form1.cs
        public static void ChangeState(Keys key, bool state)
        {
            keyTable[key] = state;
        }
    }
}
