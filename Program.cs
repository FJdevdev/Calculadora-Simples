using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)     // Inicia um loop infinito para permitir operações contínuas
            {
                Console.WriteLine("Qual operação deseja fazer?");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão\n");


                int operação;
                // Lê a escolha do usuário e valida a entrada
                if(!int.TryParse(Console.ReadLine(),out operação)|| operação< 1|| operação > 4 )    
                {
                    Console.WriteLine("ERRO: Opção inválida. Por favor, digite um número ente 1 e 4");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Digite o primeiro número: ");
                decimal n1 = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número: ");
                decimal n2 = decimal.Parse(Console.ReadLine());

            

                decimal resultado = 0;
                bool resultadoValido = true;        // Marca se o resultado é válido

                switch(operação)                    // Realiza a operação com base na escolha do usuário
                {
                    case 1:
                    {
                        resultado = Adição (n1, n2);
                        break;
                    }
                    case 2:
                    {
                        resultado = Subtração (n1, n2);
                        break;
                    }
                    case 3:
                    {
                        resultado = Multiplicação (n1,n2);
                        break;
                    }
                    case 4:
                    {
                        if(n2==0)                   // Verifica se o divisor é zero antes de realizar a divisão
                        {
                            Console.WriteLine("ERRO: Divisão por ZERO não é permitida");
                            resultadoValido=false;  // Marca como resultado inválido
                        }
                        else
                        {
                            resultado = Divisão (n1,n2);
                            
                        }   
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Número inválido. Digite outro número.");
                        continue;               // Reinicia o loop para nova entrada
                    }
                 
                }
                if(resultadoValido)
                {
                Console.WriteLine($"O resultado da operação com os números {n1} e {n2} é: {resultado}" );
                }

            
                    Console.WriteLine("Digite 1 para realizar nova operação e 2 para sair da calculadora.");
                    string saida = Console.ReadLine();

                if(saida=="1")
                {
                    Console.WriteLine("Você escolheu realizar uma nova operação.");
                    continue;
                }
                else if (saida=="2")
                {
                    Console.WriteLine("Você escolheu sair da calculadora. Até logo!");
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida. Tente Novamente.");
                    break;
                }
            }


        }


            // Função para realizar adição
        public static decimal Adição ( decimal num1, decimal num2)
        {
            decimal result = num1 + num2;
            return result;
            
        }

            // Função para realizar subtração
        public static decimal Subtração ( decimal num1, decimal num2)
        {
            decimal result = num1 - num2;
            return result;
        }

            // Função para realizar multiplicação
        public static decimal Multiplicação ( decimal num1, decimal num2)
        {
            decimal result = num1 * num2;
            return result;
        }

            // Função para realizar divisão
        public static decimal Divisão ( decimal num1, decimal num2)
        {
            decimal result = num1 / num2;
            return result;

        }
    }
}