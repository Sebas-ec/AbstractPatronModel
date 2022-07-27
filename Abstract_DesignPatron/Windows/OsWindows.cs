using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_DesignPatron
{
    public class OsWindows : SOS
    {
        public Button CreateButton(string text)
        {
            return new WinButton(text);
        }

        public Label CreateLabel(string label)
        {
            return new WinLabel(label);
        }

        public Icon CreateIcon(string type)
        {
            return new WinIcon(type);
        }
    }
}
