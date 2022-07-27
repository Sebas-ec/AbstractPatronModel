using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_DesignPatron
{
    public class MacIcon : Icon
    {
        string label;
        public MacIcon(string type)
        {
            this.label = type;
        }

        public override string Paint()
        {

            string resultado = "";
            switch (label)
            {
                case "Alerta":
                    resultado = "*****  ALERT  *****";
                    break;

                case "Peligro":

                    break;
            }

            return resultado;
        }
    }
}
