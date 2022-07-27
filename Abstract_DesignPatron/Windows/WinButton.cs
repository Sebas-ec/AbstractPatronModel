using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_DesignPatron
{
    public class WinButton:Button
    {
        string text;
        public WinButton(string text)
        {
            this.text = text;
        }

        public override string Paint()
        {
            return "**************" + "\n"
                 + "*** " + text + " ***" + "\n"
                 + "**************";
        }

    }
}
