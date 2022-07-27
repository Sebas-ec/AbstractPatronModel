using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_DesignPatron
{
    public class MacLabel : Label
    {
        string type;

        public MacLabel(string label)
        {
            this.type = label;
        }

        public override string Paint()
        {
            return "**** " + type + " ****" + "\n";
        }
    }
}
