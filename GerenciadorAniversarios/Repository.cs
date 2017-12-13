using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorAniversarios
{
    public class Repository
    {
        private static List<Person> Persons = new List<Person>();

        public void AddPerson(Person person)
        {
            Persons.Add(person);   
        }

        public int ConsultBirthday(string name)
        {
            //foreach(var choosePerson in Persons)
            //{
            //    if(name === choosePerson)
            //    {

            //    }
            //}
            return 0; 
        }

        public void ResultList()
        {
            foreach(var list in Persons)
            {
                Console.WriteLine(list);
            }
        }
    }
}
