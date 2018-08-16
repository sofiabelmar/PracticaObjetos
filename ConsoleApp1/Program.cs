using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrácticaObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Persona persona1 = new Persona();
            persona1.nombre = "Juan";
            persona1.apellidos = "Perez";
            persona1.edad = 20;
            Console.WriteLine(persona1.nombre + " " +persona1.apellidos + " tiene " + persona1.edad + " años");

            persona1.cumplirAños();

            Console.WriteLine("Ahora " + persona1.nombre + " tiene " + persona1.edad + " años.");

            persona1.altura = 1.5f;
            //sharp toma los numeros deciales los toma de tipo double y ocupa más memoria, solo se le agrega la f al numero para cambiar el tipo de dato"

            Console.WriteLine(persona1.nombre + " " + " mide " + persona1.altura + "m");

            persona1.crecer(0.12f);

            Console.WriteLine("Ahora " + persona1.nombre + " mide " + persona1.altura + "m");

            Console.ReadLine();*/

            Contacto contaco1 =
                new Contacto();

            contaco1.Nombre = "Pedro Lopez";
            contaco1.TelefonodeCasa = " (644) 131 605 ";
            contaco1.Dirección = "Cananea #410";

            Console.WriteLine("Contacto 1");
            Console.WriteLine("Nombre: " + contaco1.Nombre);
            Console.WriteLine("Telefono de Casa: " + contaco1.TelefonodeCasa);
            Console.WriteLine("Dirección: " + contaco1.Dirección);

            Contacto contacto2 =
                new Contacto("Juan Perez");
            Console.WriteLine("Contacto 2");
            Console.WriteLine("Nomnbre: " + contacto2.Nombre);

            Contacto contacto3 =
                new Contacto("64410399330", "Maria Mendoza", "6441039930", "Tlaxcala #316", " mariammm@hotmail.com");
            Console.WriteLine("Contacto 3");
            Console.WriteLine("Nombre: " + contacto3.Nombre);
            Console.WriteLine("Telefono de Casa: " + contacto3.TelefonodeCasa);
            Console.WriteLine("Dirección: " + contacto3.Dirección);
            Console.WriteLine("Telefono Celular: " + contacto3.TelefonoCelular);
            Console.WriteLine("Correo Electronico: " + contacto3.TelefonoCelular);


            Console.ReadLine();


        }
    }
}