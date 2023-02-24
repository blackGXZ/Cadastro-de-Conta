using System;
namespace Course{
    class Program{
        static void Main(string[]args){

            Hospede [] quartos = new Hospede[10];
            Console.WriteLine("Seja bem vindo ao hotel!");

            while(true){

                Console.Write("Digite o numero de quarto que deseja:");

                 int n = int.Parse(Console.ReadLine());

            if(n == 22){break;}

            if(n > 10 || n < 0){
                Console.WriteLine("\nEsse quarto não é valido!Escolha um quarto valido de 1 a 10!");
            }
            else {
                if(quartos[n] == null){
                    Console.WriteLine("\nEsse quarto esta disponivel!");

                    Console.Write("Dige o nome para cadastro: ");
                    string nome = Console.ReadLine();
                    Console.Write("Digite o seu email: ");
                    string email = Console.ReadLine();

                    quartos[n]= new Hospede( nome, email, n);
                    Console.Write($"\nSeu cadastro foi realizado com sucesso {nome}!!\n");
                }
                else{
                    Console.WriteLine($"\nEsse quarto não esta disponivel! ESta ocupado por {quartos[n].Name}");
                }
            }

            }
            
        }
    }
}