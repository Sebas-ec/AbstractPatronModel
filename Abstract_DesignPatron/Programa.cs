using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_DesignPatron
{
    public  class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here Start Windows " + "\n");

            Aplication app = new Aplication(new OsWindows());
            app.CrearIU();
            app.Paint();

            Console.WriteLine("Here Start MAC "+"\n");

            Aplication app1 = new Aplication(new OSMacintosh());
            app1.CrearIU();
            app1.Paint();

        }
    }
}
