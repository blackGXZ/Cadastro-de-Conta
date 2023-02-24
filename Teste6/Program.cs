 using System;

 namespace Course{
    class Program{
        static void Main (string[]args){

            Conta conta1;

            Console.Write("Digite o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Digete o nome do titular da conta: ");
            string titular = Console.ReadLine();

            Console.WriteLine("Hávera deposito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());

            if(resp == 's' || resp == 'S'){
                Console.WriteLine("Informe o valor inicial para deposito: ");
                double depositoinicial = double.Parse(Console.ReadLine());
                conta1 = new Conta(numero, titular, depositoinicial);

            }
            else{
                conta1 = new Conta(numero, titular);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta1);

            Console.WriteLine();
            Console.WriteLine("Digite o valor do deposito: ");
            double quantia = double.Parse(Console.ReadLine());
            conta1.Deposito (quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta1);

            Console.WriteLine();
             Console.WriteLine("A cada saque realizado a um desconto no valor de R$ 5,00");
            Console.WriteLine("Digite o valor do saque: ");
            double quantia2 = double.Parse(Console.ReadLine());
            conta1.Saque (quantia2);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta1);

        }
    }
 }