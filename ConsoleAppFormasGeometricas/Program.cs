using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFormasGeometricas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha a forma geométrica que deseja saber a área(Q,R,T,L)");
            string fg = Console.ReadLine().ToUpper();

            switch (fg)
            {
                case "Q":
                    Console.WriteLine("Digite a altura do quadrado: ");
                    double quadrado = double.Parse(Console.ReadLine());

                    double res = quadrado * quadrado;
                    Console.WriteLine("A área do quadrado é: " + res);
                    break;
                case "R":
                    Console.WriteLine("Digite a altura do retângulo: ");
                    double rh = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a base do retângulo: ");
                    double rb = double.Parse(Console.ReadLine());

                    res = rh * rb;
                    Console.WriteLine("A área do retângulo é:" + res);
                    break;
                case "T":
                    Console.WriteLine("Digite o tamanho da base maior do trapezio: ");
                    double tB = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o tamanho da base menor do trapezio: ");
                    double tb = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a altura do trapezio: ");
                    double th = double.Parse(Console.ReadLine());

                    res = (tB + tb) * th / 2;
                    Console.WriteLine("A área do trapezio é: " + res);
                    break;
                case "L":
                    Console.WriteLine("Qual o tamanho da diagonal maior do losango: ");
                    double lD = double.Parse(Console.ReadLine());
                    Console.WriteLine("Qual o tamanho da diagonal menor do losango: ");
                    double ld = double.Parse(Console.ReadLine());

                    res = lD * ld /2;

                    Console.WriteLine("A área do losango é: " +res);
                    break;
                default: 
                    Console.WriteLine("Opção inválida");
                    break;
            }
            Console.ReadKey();
        }
    }
}
