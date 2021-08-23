using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_practicos_1
{
    public class Ejercicio3 : Program
    {
        //3.Pedir por consola tu nombre y tu edad y mostrar el siguiente mensaje:
        //"Te llamas " nombre " y tienes " años " años"
        public string name;
        public int age;
        public void ejercicio3()
        {
            Console.WriteLine("Ingrese Su nombre: ");
            name = Console.ReadLine();
            Console.WriteLine("Ingrese Su Edad: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Te llamas {0} y tienes {1} años", name, age);
        }
    }
}
