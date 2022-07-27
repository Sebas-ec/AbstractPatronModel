using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_DesignPatron
{
    public class WinIcon : Icon
    {
        string type;

        public WinIcon(string type)
        {
            this.type = type;
        }

        public override string Paint()
        {

            string resultado = "";
            switch (type)
            {
                case "Alerta":
                    resultado = "** ALERT **";
                    break;

                case "Peligro":

                    break;
            }

            return resultado;
        }
    }
}
