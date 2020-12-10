using System;

namespace Operaciones
{
    public class Logica
    {
        /*Suma*/
        public int Sumar(int sumando1, int sumando2)
        {
            return sumando1 + sumando2;
        }

        /*Resta*/
        public int Restar(int minuendo, int sustraendo)
        {
            return minuendo - sustraendo;
        }

        /*Multiplicacion*/
        public int Multiplicar(int factor1, int factor2)
        {
            return factor1 * factor2;
        }

        /*Division*/
        public int Dividir(int dividendo, int divisor)
        {
            return dividendo / divisor;
        }

        /*Operacion inversa*/
        public double Inversa( double numero)
        {
            return  1 / numero;
        }

        /*Elevacion al cuadrado de un numero */
        public int Cuadrado( int numero)
        {

            return numero * numero;
        }

        /*Raiz cuadrada*/
        public double Raiz ( double numero)
        {
            return Math.Sqrt(numero);

            
            
        }
    }
}