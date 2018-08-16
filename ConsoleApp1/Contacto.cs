using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrácticaObjetos
{
    class Contacto
    {
        public string Nombre { get; set; }
        public string TelefonoCelular { get; set; }
        public string TelefonodeCasa { get; set; }
        public string Dirección { get; set; }
        public string CorreoElectronico { get; set; }

        public Contacto()
        {
            Nombre = "Nuevo Contacto";
            TelefonodeCasa = "(000) 000 - 0000";

        }

        public Contacto(string nombre)
        {
            Nombre = nombre;

        }
        public Contacto(string telefonocasa, string nombre,  string telefonoCelular, string dirección, string correoElectronico)
        {
            Nombre = nombre;
            TelefonodeCasa = telefonocasa;
            TelefonoCelular = telefonoCelular;
            Dirección = dirección;
            CorreoElectronico = correoElectronico;
        }

    }
}
