using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT2
{
    class Program
    {
        class Calculadora
        {

            public float num1 { get; set; }
            public float num2 { get; set; }
            public float resultado { get; set; }

            public Calculadora()
            {
                num1 = num2 = 0;
            }

            public float soma()
            {
                return num1 + num2;
            }

            public float subtrair()
            {
                return num1 - num2;
            }

            public float multiplicar()
            {
                return num1 * num2;
            }

            public float dividir()
            {
                return num1 / num2;
            }

            public float Media()
            {
                return (num1 + (num2 * 2)) / 3;
            }

        }


        static void Main(string[] args)
        {

            int opcao;

            Calculadora calc = new Calculadora();

            do
            {
                Console.Clear();
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Media");
                Console.WriteLine("6 - Opção");
                opcao = int.Parse(Console.ReadLine());

                if (opcao != 6)
                {
                    Console.Write("Digite o 1o. termo : ");
                    calc.num1 = float.Parse(Console.ReadLine());
                    Console.Write("Digite o 2o. termo : ");
                    calc.num2 = float.Parse(Console.ReadLine());
                    switch (opcao)
                    {
                        case 1:
                            calc.resultado = calc.soma();
                            break;
                        case 2:
                            calc.resultado = calc.subtrair();
                            break;
                        case 3:
                            calc.resultado = calc.multiplicar();
                            break;
                        case 4:
                            calc.resultado = calc.dividir();
                            break;
                        case 5:
                            calc.resultado = calc.Media();
                            break;
                    }

                    Console.WriteLine("O resultado é: {0}",
                    calc.resultado);
                    Console.ReadKey();
                }
            } while (opcao != 6);
        }

    }
}