using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsolutionSystems.Items
{
    [Serializable]
    public class PracownikTechniczny : Pracownik
    {
        public string SkillsDescription { get; set; }
        public MagazynSklep WorkingPlace;
        public List<Naprawa> Naprawy { get; set; }
        public PracownikTechniczny(string Name, string Surname, DateTime DateOfBirth, string PhoneNumber, int Salary, int YearsOfYearsOfExpiriance, string SkillsDescription, MagazynSklep WorkingPlace) 
            : base(Name, Surname, DateOfBirth, PhoneNumber, Salary, YearsOfYearsOfExpiriance)
        {
            this.WorkingPlace = WorkingPlace;
            this.SkillsDescription = SkillsDescription;
        }

        public PracownikTechniczny(string Name, string Surname, DateTime DateOfBirth, string PhoneNumber, string Sex, int Salary, int YearsOfYearsOfExpiriance, string SkillsDescription, MagazynSklep WorkingPlace) 
            : base(Name, Surname, DateOfBirth, PhoneNumber, Sex, Salary, YearsOfYearsOfExpiriance)
        {
            this.WorkingPlace = WorkingPlace;
            this.SkillsDescription = SkillsDescription;
        }

        public void AddNaprawa(Naprawa Naprawa)
        {
            if (!Naprawy.Contains(Naprawa))
            {
                Naprawy.Add(Naprawa);
                Naprawa.AddPracownikTechniczny(this);
            }
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
    }
}
