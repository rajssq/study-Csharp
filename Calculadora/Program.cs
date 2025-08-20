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
           
            int operacao;

            // loop até o usuário escolher entre 1 e 4
            do
            {
                Console.WriteLine("Qual operação você deseja realizar?");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão \n");

                operacao = int.Parse(Console.ReadLine());

                if (operacao < 1 || operacao > 4)
                {
                    Console.WriteLine("Operação inválida. Escolha entre 1 e 4.\n");
                }

            } while (operacao < 1 || operacao > 4);

            // só chega aqui se for válido
            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = 0;

            switch (operacao)
            {
                case 1:
                    resultado = Adicao(num1, num2);
                    break;

                case 2:
                    resultado = Subtracao(num1, num2);
                    break;

                case 3:
                    resultado = Multiplicacao(num1, num2);
                    break;

                case 4:
                    resultado = Divisao(num1, num2);
                    break;
            }

            Console.WriteLine($"O resultado da operação com os números {num1} e {num2} é: {resultado}");
            Console.ReadLine();
        }

        public static int Adicao (int num1, int num2)
        {
            int resultado = num1 + num2;
            return resultado;
        }

        public static int Subtracao(int num1, int num2)
        {
            int resultado = num1 - num2;
            return resultado;
        }

        public static int Multiplicacao(int num1, int num2)
        {
            int resultado = num1 * num2;
            return resultado;
        }

        public static int Divisao(int num1, int num2)
        {
            int resultado = num1 / num2;
            return resultado;
        }

    }
}
