using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_DesignPatron
{
    public class OSMacintosh : SOS
    {
        public Button CreateButton(string text)
        {
            return new MacButton(text);
        }

        public Label CreateLabel(string label)
        {
            return new MacLabel(label);
        }

        public Icon CreateIcon(string  type)
        {
            return new MacIcon(type);
        }

    }
}
