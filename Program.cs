using System;

namespace Tarefa02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int escalao = 0;
            int qnt_horas = 0;            
            double resultado = 0;
            string resposta = "";
            

            Console.WriteLine("\nCalculadora de horas trabalhadas...");
            escalao = LerNumero("Digite o número do escalão salarial: ");
            qnt_horas = LerNumero("Digite a quantidade de horas trabalhadas: ");            

            switch (escalao)
            {
                case 1:
                    {
                        resultado = qnt_horas * 20;
                        break;
                    }
                case 2:
                    {
                        resultado = qnt_horas * 30;
                        break;
                    }
                case 3:
                    {
                        resultado = qnt_horas * 40;
                        break;
                    }
                default:
                    {
                        resposta = "Escalão informado está fora dos valores possíveis.";
                        break;
                    }
            }
            resposta += "\nO valor a receber é de : " + resultado + " euros.";

            Console.WriteLine(resposta);
            Console.WriteLine("****FIM DO PROGRAMA*** presssione qualquer tecla para sair");
        }

        private static int LerNumero(string mensagem)
        {
            int valor_informado = 0;
            bool incorreto = true;
            while (incorreto == true)
            {
                try
                {
                    Console.WriteLine(mensagem);
                    valor_informado = Convert.ToInt32(Console.ReadLine().Trim());
                    incorreto = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("O valor informado não é um número." + ex.Message);
                    incorreto = true;
                }
            }

            return valor_informado;
        }
    }
}
