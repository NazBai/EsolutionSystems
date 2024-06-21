using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public FormaZatrudnienia ContractType { get; set; }
        public MagazynSklep WorkingPlace { get; set; }


        public Sprzedawca(string Name, string Surname, DateTime DateOfBirth, string PhoneNumber, string Sex, int Salary, int YearsOfYearsOfExpiriance, FormaZatrudnienia ContractType, MagazynSklep WorkingPlace) 
            : base(Name, Surname, DateOfBirth, PhoneNumber, Sex, Salary, YearsOfYearsOfExpiriance)
        {
            this.WorkingPlace = WorkingPlace;
            this.ContractType = ContractType;
        }

        public Sprzedawca(string Name, string Surname, DateTime DateOfBirth, string PhoneNumber, int Salary, int YearsOfYearsOfExpiriance, FormaZatrudnienia ContractType, MagazynSklep WorkingPlace) 
            : base(Name, Surname, DateOfBirth, PhoneNumber, Salary, YearsOfYearsOfExpiriance)
        {
            this.WorkingPlace = WorkingPlace;
            this.ContractType = ContractType;
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
