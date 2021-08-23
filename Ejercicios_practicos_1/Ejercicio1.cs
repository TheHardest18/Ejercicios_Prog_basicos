using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_practicos_1
{
    public class Ejercicio1 : Program
    {
        //1.Crear 3 variables numericas con el valor que tu quieras y en otra variable númerica guardar el valor de
        //la suma de las 3 anteriores.Mostrar por consola.
        public int n1 { get; set; }
        public int n2 { get; set; }
        public int n3 { get; set; }
        public int suma { get; set; }
        public void Suma()
        {

           
            Console.WriteLine("Introduzca primer numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca segundo numero: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca tercer numero: ");
            n3 = int.Parse(Console.ReadLine());
            suma = n1 + n2 + n3;
            Console.WriteLine(suma);
            
        }
    }
}
