using System;

namespace OperacoesComDelegate
{
    public delegate int OperacaoMatematica(int x, int y);

    class Program
    {
        public static int Soma(int x, int y)
        {
            return x + y;
        }

        public static int Subtracao(int x, int y)
        {
            return x - y;
        }

        public static int Multiplicacao(int x, int y)
        {
            return x * y;
        }

        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a operação que deseja realizar:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            int opcao = int.Parse(Console.ReadLine());

            OperacaoMatematica operacao = null;

            switch (opcao)
            {
                case 1:
                    operacao = Soma;
                    break;
                case 2:
                    operacao = Subtracao;
                    break;
                case 3:
                    operacao = Multiplicacao;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    return;
            }

            int resultado = operacao(numero1, numero2);
            Console.WriteLine($"O resultado da operação é: {resultado}");
        }
    }
}
