using System;

namespace Ejercicios_practicos_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int seleccion;
            do
            {
                //1.Crear 3 variables numericas con el valor que tu quieras y en otra variable númerica guardar el valor de
                //la suma de las 3 anteriores.Mostrar por consola.
                Ejercicio1 ejercicio1 = new Ejercicio1();

                //2.Pedir por consola un nombre de persona y el nombre de una ciudad(no hace falta que sean reales o comprobarlos)
                //y mostrar por pantalla, el siguiente mensaje "Hola " nombre " bienvenido a " ciudad
                Ejercicio2 ejercicio2 = new Ejercicio2();

                //3.Pedir por consola tu nombre y tu edad y mostrar el siguiente mensaje:
                //"Te llamas " nombre " y tienes " años " años"
                Ejercicio3 ejercicio3 = new Ejercicio3();

                Console.WriteLine("Seleccione Numero de Ejercicio:");
                Console.WriteLine("1. Ejercicio 1");
                Console.WriteLine("2. Ejercicio 2");
                Console.WriteLine("3. Ejercicio 3");
                seleccion=int.Parse(Console.ReadLine());
                


                switch (seleccion)
                {
                    case 1:
                        ejercicio1.Suma();
                        break;
                    case 2:
                        ejercicio2.ejercicio2();
                        break;
                    case 3:
                        ejercicio3.ejercicio3();
                        break;
                }
                Console.ReadKey();
            } while (seleccion <= 3);
         
        }
    }
}
