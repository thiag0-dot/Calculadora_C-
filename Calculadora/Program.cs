using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite outro numero:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("1 = adição");
            Console.WriteLine("2 = subtração");
            Console.WriteLine("3 = Multiplicação");
            Console.WriteLine("4 = divisão");
            Console.WriteLine("Qual operação deseja fazer?");
            int op = Convert.ToInt32(Console.ReadLine());
            if (op == 1)
            {
                double resultado = num1 + num2;
                Console.WriteLine("O valor da operação é de:" + resultado);
            }
            else if (op == 2)
            {
                double resultado = num2 - num1;
                Console.WriteLine("O valor da operação é de:" + resultado);
            }
            else if (op == 3)
            {
                double resultado = num1 * num2;
                Console.WriteLine("O valor da operação é de:" + resultado);
            }
            else if (op == 4)
            {
                double resultado = num1 / num2;
                Console.WriteLine("O valor da operação é de:" + resultado);
            }
            else 
            {
            }
        }
    }
}
