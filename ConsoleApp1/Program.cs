
using System.Xml;

namespace MedindoIMC
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("===== Calculadora de IMC =====");
            Console.Write("\ndigite seu peso: ");
            double peso = double.Parse(Console.ReadLine());
            Console.Write("\nDigite sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            double imc = resultadoIMC(peso, altura);

            Console.WriteLine($"\nseu imc é {imc:F2}\n");

            Console.WriteLine($"{classeIMC(imc)}");

        }

        static double resultadoIMC(double peso, double altura)
        {
            return peso / (altura * altura);

        }

        static string classeIMC(double imc)
        {
            if (imc < 20)
            {
                return "Seu IMC está a baixo!!";
            }
            else if (imc > 20 && imc <= 25)
            {
                return "Seu IMC está bom!!";
            }
            else if (imc > 25 && imc <= 30)
            {
                return "Seu IMC está alto";
            }
            else
            {

                return "Você está Obeso";

            }


        }

    }
}