using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWinForm
{
    public class SeedCountry
    {
        static public List<Country> Countries { get; } = new List<Country>();
        static public List<Country>GetCountries()
        {
            var c1 = new Country() { Id = 1, Name = "Belgium" };
            var c2 = new Country() { Id = 2, Name = "France" };
            var c3 = new Country() { Id = 3, Name = "UK" };
            var c4 = new Country() { Id = 4, Name = "Germany" };

            Countries.Add(c1);Countries.Add(c2);Countries.Add(c3);Countries.Add(c4);
            return Countries;
        }
    }
}
