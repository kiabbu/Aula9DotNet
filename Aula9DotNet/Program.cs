using System;

namespace Aula9DotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            Console.WriteLine("Digite o nome: ");
            pessoa.nome = Console.ReadLine();
            Console.WriteLine("Digite a idade: ");
            pessoa.idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o RG: ");
            pessoa.rg = Console.ReadLine();
            Console.WriteLine("Digite o CPF: ");
            pessoa.cpf = Console.ReadLine();

            Console.WriteLine("Nome: {0}", pessoa.nome);
            Console.WriteLine("Idade: {0}", pessoa.idade);
            Console.WriteLine("RG: {0}", pessoa.rg);
            Console.WriteLine("CPF: {0}", pessoa.cpf);

            Pessoa pessoa1 = new Pessoa();

            pessoa1.nome = "Silvia";
            pessoa1.idade = 39;
            pessoa1.rg = "111111111";
            pessoa.cpf = "222222222";

            pessoa.Acenar(pessoa1);

            pessoa.PerguntaIdade(pessoa1);
        }
    }
}
