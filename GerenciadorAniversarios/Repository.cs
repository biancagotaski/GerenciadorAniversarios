using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorAniversarios
{
    class Repository
    {
        private List<Person> Persons = new List<Person>();

        private void addPerson(Person person)
        {
            Persons.Add(person);
        }

        public int consultBirthday(string name)
        {
            foreach(var choosePerson in Persons)
            {
                if(name === choosePerson)
                {

                }
            }
            return 
        }

        public string consultName(string name)
        {
            foreach (string p in Persons)
            {
                if (p == name)
                {
                    return name;
                }
            }
        }
    }
}
