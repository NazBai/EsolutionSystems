

namespace EsolutionSystems.Items
{
    [Serializable]
    public class Magazynier : Pracownik
    {
        public MagazynSklep workingplace { get; set; }
        public List<Uprawnienia> mashineryLicenses { get; set; }
        public Magazynier(string Name, string Surname, DateTime DateOfBirth, string PhoneNumber, int Salary, int YearsOfYearsOfExpiriance, MagazynSklep Workingplace) 
            : base(Name, Surname, DateOfBirth, PhoneNumber, Salary, YearsOfYearsOfExpiriance)
        {
            this.workingplace = Workingplace;
            Workingplace.AddMagazynier(this);
        }

        public Magazynier(string Name, string Surname, DateTime DateOfBirth, string PhoneNumber, string Sex, int Salary, int YearsOfYearsOfExpiriance, MagazynSklep Workingplace) 
            : base(Name, Surname, DateOfBirth, PhoneNumber, Sex, Salary, YearsOfYearsOfExpiriance)
        {
        }

        public void addUprawnienia(string IdNumber, string Description)
        {
            mashineryLicenses.Add(new Uprawnienia(IdNumber, Description));
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
