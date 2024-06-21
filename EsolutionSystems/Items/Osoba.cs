
namespace EsolutionSystems.Items
{
    [Serializable]
    public abstract class Osoba
    {

        public string name { get; set; }
        public string surname { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string phoneNumber { get; set; }
        public string sex { get; set; }

        protected Osoba(string Name, string Surname, DateTime DateOfBirth, string PhoneNumber, string Sex)
        {
            this.name = Name;
            this.surname = Surname;
            this.dateOfBirth = DateOfBirth;
            this.phoneNumber = PhoneNumber;
            this.sex = Sex;
        }

        protected Osoba(string Name, string Surname, DateTime DateOfBirth, string PhoneNumber)
        {
            this.name = Name;
            this.surname = Surname;
            this.dateOfBirth = DateOfBirth;
            this.phoneNumber = PhoneNumber;
        }

        public abstract int GetAge();

    }
}
