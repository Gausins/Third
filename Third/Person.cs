using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Hobby { get; set; }
        public bool Gender { get; set; }

        public int GetAge(string birthDateText)
        {
            return DateTime.Now.Year - BirthDate.Year;
        }

        internal int GetAge(DateTime now)
        {
            throw new NotImplementedException();
        }
    }
}
