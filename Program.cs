using ExercicioAula60Tentativa1ConstrutoresThisSobrecargaEncapsulamento;
using System;
using System.Globalization;

namespace MyApp //ExercicioAula60Tentativa1ConstrutoresThisSobrecargaEncapsulamento.
{
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;


            Console.Write("Digite o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            
            Console.Write("Digite o titular da conta: ");
            string titularConta = Console.ReadLine();
            
            Console.Write("Haverá depósito inicial (s / n) ? ");
            char haveraDeposito = char.Parse(Console.ReadLine());

            double depositoInicial = 0;
            if (haveraDeposito == 's') {
                Console.Write("Digite o valor de depósito inicial: ");
                depositoInicial = double.Parse(Console.ReadLine(), CI);
            }

            double saldo = depositoInicial;



            Cliente cli = new Cliente(numeroConta, titularConta, haveraDeposito, depositoInicial, saldo);



            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(cli.ToString());


            Console.WriteLine();
            Console.Write("Digite um valor para deposito: ");
            double dep = double.Parse(Console.ReadLine(), CI);
            cli.Deposito(dep);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(cli.ToString());


            Console.WriteLine();
            Console.Write("Digite um valor para saque: ");
            double saq = double.Parse(Console.ReadLine(), CI);
            cli.Saque(saq);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(cli.ToString());


        }
    }
}




