using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsolutionSystems.Items
{
    [Serializable]
    public class Magazynier : Pracownik
    {
        public MagazynSklep WorkingPlace { get; set; }
        public List<Uprawnienia> MashineryLicenses { get; set; }
        public Magazynier(string Name, string Surname, DateTime DateOfBirth, string PhoneNumber, int Salary, int YearsOfYearsOfExpiriance, MagazynSklep WorkingPlace) 
            : base(Name, Surname, DateOfBirth, PhoneNumber, Salary, YearsOfYearsOfExpiriance)
        {
            this.WorkingPlace = WorkingPlace;
            WorkingPlace.AddMagazynier(this);
        }

        public Magazynier(string Name, string Surname, DateTime DateOfBirth, string PhoneNumber, string Sex, int Salary, int YearsOfYearsOfExpiriance, MagazynSklep WorkingPlace) 
            : base(Name, Surname, DateOfBirth, PhoneNumber, Sex, Salary, YearsOfYearsOfExpiriance)
        {
        }

        public void addUprawnienia(string IdNumber, string Description)
        {
            MashineryLicenses.Add(new Uprawnienia(IdNumber, Description));
        }

        public override int GetAge()
        {

            DateTime today = DateTime.Today;
            int age = today.Year - DateOfBirth.Year;

            if (DateOfBirth.Date > today.AddYears(-age)) 
                age--;

            return age;

        }

        public override bool IsExpiriensed()
        {
            return YearsOfExpiriance >= 3;
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
