using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorAniversarios
{
    public class Person
    {
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public string Birthday { get; private set; }

        public Person(string name, string lastName, string birthday)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Birthday = birthday;
        }

        public override string ToString()
        {
            return $"Nome: {Name} \nSobrenome: {LastName} \nData de Nascimento: {Birthday}";
        }
    }
}
