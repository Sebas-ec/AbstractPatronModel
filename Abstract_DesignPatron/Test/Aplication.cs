using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_DesignPatron
{
    public class Aplication
    {
        //create my object
        public SOS plataforma;
        List<GUI> giuObject;

        public Aplication(SOS plataforma)
        {
            this.plataforma = plataforma;
            giuObject = new List<GUI>();
        }

        public void CrearIU()
        {
            Label titulo = plataforma.CreateLabel("Are you sure ?");
            Label mensaje = plataforma.CreateLabel("One Deleted, will will not be able to recover this !");
            Icon IconoAlerta = plataforma.CreateIcon("Alerta");
            Button buttonOk = plataforma.CreateButton("OK");
            Button buttonCancelar = plataforma.CreateButton("Cancelar");

            giuObject.Add(titulo);
            giuObject.Add(mensaje);
            giuObject.Add(IconoAlerta);
            giuObject.Add(buttonOk);
            giuObject.Add(buttonCancelar);
        }

        public void Paint()
        {
            string pantalla = "";
            foreach (var obj in giuObject)
            {
                pantalla += obj.Paint() + "\n"; 
            }
            Console.WriteLine(pantalla);
        }
    }
}
