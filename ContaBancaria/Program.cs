using System;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============== Cadastro de Conta Bancária ===========");
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o nome do titular: ");
            string titular = Console.ReadLine();
            double deposito;

            Conta c = new Conta();

            Console.Write("Haverá deposito inicial ? (s/n): ");
            char r = char.Parse(Console.ReadLine());
            if (r == 's')
            {
                Console.Write("Entre o deposito: ");
                deposito = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));

                c = new Conta(numero, titular, deposito);
            }
            else if (r == 'n')
            {
                c = new Conta(numero, titular);
            }
            else
            {
                Console.WriteLine("Comando Inválido");
                Console.ReadKey();
            }
            Console.WriteLine("===============================");
            Console.WriteLine("Dados da Conta:");
            Console.WriteLine(c);
            Console.WriteLine("===============================");

            Console.Write("Entre um valor para deposito: ");
            deposito = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));

            c.Deposito(deposito);

            Console.WriteLine("===============================");
            Console.WriteLine("Dados da Conta:");
            Console.WriteLine(c);

            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine().ToString(CultureInfo.InvariantCulture));

            c.Saque(saque);

            Console.WriteLine("===============================");
            Console.WriteLine("Dados da Conta:");
            Console.WriteLine(c);

        }
    }
}
