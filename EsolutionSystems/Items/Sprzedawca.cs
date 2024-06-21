

namespace EsolutionSystems.Items
{
    [Serializable]
    public class Sprzedawca : Pracownik
    {
        public enum FormaZatrudnienia
        {
            PEWIEN_ETAT,
            POW_ETATU
        };

        public FormaZatrudnienia contractType { get; set; }
        public MagazynSklep workingplace { get; set; }


        public Sprzedawca(string name, string surname, DateTime dateOfBirth, string phoneNumber, string sex, int salary, int yearsOfYearsOfExpiriance, FormaZatrudnienia contractType, MagazynSklep workingplace) 
            : base(name, surname, dateOfBirth, phoneNumber, sex, salary, yearsOfYearsOfExpiriance)
        {
            this.workingplace = workingplace;
            this.contractType = contractType;
        }

        public Sprzedawca(string name, string surname, DateTime dateOfBirth, string phoneNumber, int salary, int yearsOfYearsOfExpiriance, FormaZatrudnienia contractType, MagazynSklep workingplace) 
            : base(name, surname, dateOfBirth, phoneNumber, salary, yearsOfYearsOfExpiriance)
        {
            this.workingplace = workingplace;
            this.contractType = contractType;
        }

        public override int GetAge()
        {

            DateTime today = DateTime.Today;
            int age = today.Year - dateOfBirth.Year;

            if (dateOfBirth.Date > today.AddYears(-age))
                age--;

            return age;

        }

        public override bool IsExpiriensed()
        {
            return yearsOfExpiriance >= 3;
        }

        public class Uprawnienia
        {
            public string IdNumber { get; set; }
            public string Description { get; set; }

            public Uprawnienia(string IdNumber, string Description)
            {
                this.IdNumber = IdNumber;
                this.Description = Description;

            }
        }
    }
}
