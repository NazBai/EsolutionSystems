using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsolutionSystems.Items
{
    [Serializable]
    public abstract class Osoba
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Sex { get; set; }

        protected Osoba(string Name, string Surname, DateTime DateOfBirth, string PhoneNumber, string Sex)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.DateOfBirth = DateOfBirth;
            this.PhoneNumber = PhoneNumber;
            this.Sex = Sex;
        }

        protected Osoba(string Name, string Surname, DateTime DateOfBirth, string PhoneNumber)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.DateOfBirth = DateOfBirth;
            this.PhoneNumber = PhoneNumber;
        }

        public abstract int GetAge();

    }
}
