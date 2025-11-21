using System;
using System.Collections.Generic;
using System.Text;

namespace Person.Library2
{
    public class PersonList
    {
        private readonly List<Person> _people = new();

        public void AddPerson()
        {
            Person p = new();
            p.Create();
            _people.Add(p);
        }

        public void AddPerson(Person p)
        {
            _people.Add(p);
        }

        public void outputAll()
        {
            if(_people.Count == 0)
            {
                Console.WriteLine("No people in the list!");
                return;
            }

            Console.WriteLine(_people[0].Heading);
            Console.WriteLine(_people[0].getBar('-'));

            foreach (var person in _people)
                Console.WriteLine(person.Info);

            Console.WriteLine(_people[0].getBar('-'));
        }

        public int count => _people.Count;

        public Person? FindById(int id)
        {
            return _people.Find(p => p.Id == id);
        }

        public void SearchById(int id)
        {
            var p = FindById(id);
            if (p == null)
            {
                Console.WriteLine($"People With {id} not found!");
            }
            Console.WriteLine(p.Heading);
            Console.WriteLine(p.getBar('-'));
            Console.WriteLine(p.Info);
            Console.WriteLine(p.getBar('-'));
        }

        public bool RemoveById(int id)
        {
            var p = FindById(id);
            if (p != null) { _people.Remove(p); return true; }

            return false;
        }

        public List<Person> GetAll()
        {
            return new List<Person>(_people);
        }
    }
}
