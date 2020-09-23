using System;

namespace Metodos3
{
    class Program
    {
        int numero1 = 5;

        int numero2 = 7;

        static void Main(string[] args)
        {

            Console.WriteLine(suma(7,5));
            //por los parametros llama al primero ya que son de tipo entero.

            Console.WriteLine(suma(7,5.3));
            //aca esta llamando al segundo ya que es de tipo decimal.

        }
        void primerMetodo()
        {

            Console.WriteLine(numero1 + numero2);

        }
        void segundoMetodo() 
        {

            Console.WriteLine(numero1+numero2);

        }
        static int suma(int operador1, int operador2)=>operador1+operador2;

        static double suma(int numero1, double numero2) => numero1+numero2;

        static int suma(int numero1, int numero2, int numero3, int numero4) => numero1 + numero2;
    }
}
