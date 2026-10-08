using System.Diagnostics;

namespace Ejercicio1_Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== CALCULADORA =====");

            double pregunta1 = LeerNumero("Ingrese el primer número: ");
            double pregunta2 = LeerNumero("Ingresa el segundo numero: ");


            Console.WriteLine($"Sumar: {Sumar(pregunta1, pregunta2)}");
            Console.WriteLine($"Restar: {Restar(pregunta1, pregunta2)}");
            Console.WriteLine($"Multiplicar: {Multiplicar(pregunta1, pregunta2)}");
            Console.WriteLine($"Dividir: {Dividir(pregunta1, pregunta2)}");
            Console.WriteLine($"Potencia: {Potencia(pregunta1, pregunta2)}");

        }
        static double LeerNumero(string mensaje)
        {
            Console.Write(mensaje);
            return double.Parse(Console.ReadLine());
        }
        static double Sumar(double numero1, double numero2)
        {
            double resultado = numero1 + numero2;
            return resultado;
        }

        static double Restar(double numero1, double numero2)
        {
            double resultado = numero1 - numero2;
            return resultado;

        }

        static double Multiplicar(double numero1, double numero2)
        {
            double resultado = numero1 * numero2;
            return resultado;

        }
        static double Dividir(double numero1, double numero2)


        {
            double resultado = numero1 / numero2;
            return resultado;
        }

        static double Potencia(double numero1, double numero2)
        {
        double resultado = Math.Pow(numero1, numero2);
            return resultado;
        }







    }
}
