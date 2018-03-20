using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JustTypes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
         * Some information about types and what value they can storage
         * Most common:
         * 
         *32bit     int -> integer from - 2.1 mln~~ to 2.1 mln
         *xbit      string -> can storage string of characters
         *16bit     char -> can storage any sign
         *8bit      bool -> logical value which can storage true or false value only
         *64 bit    double -> one of biggest, can storage ALL real numbers from +- 5.0 * 10^ -324 to +- 1.7 * 10^308
         * 
         * Good to know:
         *8bit      byte -> integer from 0  to 255
         *          sbyte -> integer with minus value from -128 to 127. "s" is shortcut from signed which mean that it allows to use sign "-"(minus)
         *16bit     short -> integer from - 32 768 to 32767
         *          ushort -> integer from 0 to 65 535. "u" is shortcut from unsigned
         *          uint -> integer number from 0 to  4 294 967 295
         *64bit     long -> integer from -9 MLD to 9 mld
         *          ulong -> integer from 0 to 18 MLD
         *
         * For really big numbers we use:
         * 
         *32bit     float -> from +- 1.5 * 10^-45 to +- 3.4 * 10^38
         *64bit     double -> already showed
         *128bit    decimal -> from +- 1.0 * 10-28 to +-7.9 * 10^28 // used in bank systems etc.
         */

        // int myInt = 14.7 // we gotta get error Error CS0266  Cannot implicitly convert type 'double' to 'int'. An explicit conversion exists (are you missing a cast?)
        // so we have to use double type

        double myInt = 14.7F; //by adding char "F" we can change it to float and by adding char "M" we can change it for decimal M -> MONEY :)

        int biggerCup = 20000;
        short smallerCup = biggerCup; //It won't work because we try to put our int which is bigger then short type, even if value 20000 is included in short storage possibilities
    }
}
