using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsolutionSystems.Items
{
    [Serializable]
    public abstract class Pracownik : Osoba
    {
        public int Salary { get; set; }
        public static int MinimalSalary { get; set; } = 5000;
        public int YearsOfExpiriance { get; set; }
        public int Bonus { get; set; } = 500;
        public Pracownik(string Name, string Surname, DateTime DateOfBirth, string PhoneNumber, string Sex, int Salary, int YearsOfYearsOfExpiriance) 
            : base(Name, Surname, DateOfBirth, PhoneNumber, Sex)
        {
            this.Salary = Salary;
            this.YearsOfExpiriance = YearsOfExpiriance;
        }

        public Pracownik(string Name, string Surname, DateTime DateOfBirth, string PhoneNumber, int Salary, int YearsOfYearsOfExpiriance) 
            : base(Name, Surname, DateOfBirth, PhoneNumber)
        {
            this.Salary = Salary;
            this.YearsOfExpiriance = YearsOfExpiriance;
        }

        public abstract bool IsExpiriensed();
        
    }
}
