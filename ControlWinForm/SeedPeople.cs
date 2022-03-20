using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWinForm
{
    public class SeedPeople
    {
        static public List<Person> People { get; private set; } = new List<Person>();
        static public List<Person>GetPeople()
        {
            var p1 = new Person() { Id = 1, FirstName = "Anass", LastName = "El Lamzi", Age = 27, IsVIP = false, Country = 1 };
            var p2 = new Person() { Id = 2, FirstName = "Florian", LastName = "Esprit", Age = 22, IsVIP = true, Country = 2 };
            var p3 = new Person() { Id = 3, FirstName = "Wouter", LastName = "Van Laere", Age = 28, IsVIP = false, Country = 3 };
            var p4 = new Person() { Id = 4, FirstName = "Olga", LastName = "Kharchuk", Age = 24, IsVIP = true, Country = 1 };
            var p5 = new Person() { Id = 5, FirstName = "Serap", LastName = "Albayrak", Age = 28, IsVIP = false, Country = 2 };

            People.Add(p1); People.Add(p2); People.Add(p3); People.Add(p4); People.Add(p5);
            return People;
        }
    }
}
