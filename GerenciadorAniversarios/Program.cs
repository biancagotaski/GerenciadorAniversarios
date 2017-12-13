using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorAniversarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do aniversariante:");
            string name = Console.ReadLine();

            Console.WriteLine("Digite o sobrenome do aniversariante:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Digite a data de nascimento:");
            string birthday = Console.ReadLine();

            Person newPerson = new Person(name, lastName, birthday);

            Repository Pessoa = new Repository();
            Pessoa.AddPerson(newPerson);

            Pessoa.ResultList();

            Console.ReadKey();
        }
    }
}
