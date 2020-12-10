using System;
using Operaciones;

namespace CalculadoraApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\t\t\t\t\t-------Calculadora--------");
            Console.WriteLine("\t\t\t\t-------Desea realizar alguna operación--------");

            var respuesta = Console.ReadLine();

            while (respuesta != "no")
            {
                Console.WriteLine("\t Escoje una operación:" +
                "\n 1)Suma " +
                "\n 2)Resta" +
                "\n 3)Multiplicación " +
                "\n 4)División " +
                "\n 5)La inversa de un número " +
                "\n 6)El cuadrado de un número" +
                "\n 7)Raíz Cuadrada");

                var seleccion = Console.ReadLine();

                /*Suma*/

                if (seleccion == "1")
                {
                    Console.WriteLine("Ingrese el primer número");
                    var primerNumero1 = Console.ReadLine();

                    Console.WriteLine("Ingrese el segundo número");
                    var segundoNumero2 = Console.ReadLine();

                    var calculadora = new Logica();

                    var resultado = calculadora.Sumar(int.Parse(primerNumero1), int.Parse(segundoNumero2));

                    Console.WriteLine("La suma es: " + resultado);
                }

                /*Resta*/

                if (seleccion == "2")
                {
                    Console.WriteLine("Ingrese el primer número");
                    var primerNumero1 = Console.ReadLine();

                    Console.WriteLine("Ingrese el segundo número");
                    var segundoNumero2 = Console.ReadLine();

                    var calculadora = new Logica();

                    var diferencia = calculadora.Restar(int.Parse(primerNumero1), int.Parse(segundoNumero2));

                    Console.WriteLine("La resta es: " + diferencia);

                }

                /*Multiplicacion*/

                if (seleccion == "3")
                {
                    Console.WriteLine("Ingrese el primer número");
                    var primerNumero1 = Console.ReadLine();

                    Console.WriteLine("Ingrese el segundo número");
                    var segundoNumero2 = Console.ReadLine();

                    var calculadora = new Logica();

                    var resultado = calculadora.Multiplicar(int.Parse(primerNumero1), int.Parse(segundoNumero2));

                    Console.WriteLine("El multiplicación da como resultado: " + resultado);


                }

                /*Division*/

                if (seleccion == "4")
                {
                    Console.WriteLine("Ingrese el primer número");
                    var primerNumero1 = Console.ReadLine();

                    Console.WriteLine("Ingrese el segundo número");
                    var segundoNumero2 = Console.ReadLine();

                    var calculadora = new Logica();

                    var resultado = calculadora.Dividir(int.Parse(primerNumero1), int.Parse(segundoNumero2));

                    Console.WriteLine("La división da como resultado: " + resultado);
                }

                /*Operacion inversa*/

                if (seleccion == "5")
                {
                    Console.WriteLine("Ingresa el numero que quieres ver su inversa");

                    var numero = Console.ReadLine();

                    var calculadora = new Logica();

                    var resultado = calculadora.Inversa(double.Parse(numero));

                    Console.WriteLine("La inversa del número  " + numero + " es:  " + resultado);
                }

                /*Elevacion al cuadrado de un numero */

                if (seleccion == "6")
                {
                    Console.WriteLine("Ingrese el número que quiere ver su cuadrado");

                    var numero = Console.ReadLine();

                    var calculadora = new Logica();

                    var resultado = calculadora.Cuadrado(int.Parse(numero));

                    Console.WriteLine("El cuadrado del " + numero + " es " + resultado);

                }

                /*Raiz cuadrada*/

                if (seleccion == "7")
                {
                    Console.WriteLine("Ingrese el número al que desea obtener su raíz cuadrada");

                    var numero = Console.ReadLine();

                    var calculadora = new Logica();

                    var resultado = calculadora.Raiz(double.Parse(numero));

                    Console.WriteLine("La raíz del número " + numero + " es " + resultado);
                }


                Console.WriteLine("Desea realizar otra operación.?");
                respuesta = Console.ReadLine();
                Console.Clear();
            }



        }
    }
}