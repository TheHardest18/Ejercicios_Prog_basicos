using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_practicos_1
{
    public class Ejercicio2 : Program
    {
        //2.Pedir por consola un nombre de persona y el nombre de una ciudad(no hace falta que sean reales o comprobarlos)
        //y mostrar por pantalla, el siguiente mensaje "Hola " nombre " bienvenido a " ciudad
        public string name;
        public string ciudad;
        public void ejercicio2()
        {
            Console.WriteLine("Ingrese Su nombre: ");
            name = Console.ReadLine();
            Console.WriteLine("Ingrese Su Ciudad: ");
            ciudad = Console.ReadLine();
            Console.WriteLine("Hola {0} bienvenido a {1}", name,ciudad);
        }
    }
}
