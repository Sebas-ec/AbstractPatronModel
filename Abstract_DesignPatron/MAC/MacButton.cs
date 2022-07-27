using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_DesignPatron
{
    public class MacButton : Button
    {
        string text;

        public MacButton(string text)
        {
            this.text = text;
        }

        public override string Paint()
        {
            return "**************"+ "\n"
                 +"*** "+ text + " ***" + "\n"
                 + "**************";
        }
    }
}
