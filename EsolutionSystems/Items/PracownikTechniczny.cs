

namespace EsolutionSystems.Items
{
    [Serializable]
    public class PracownikTechniczny : Pracownik
    {
        public string skillsDescription { get; set; }
        public MagazynSklep workingplace;
        public List<Naprawa> naprawy { get; set; }
        public PracownikTechniczny(string name, string surname, DateTime dateOfBirth, string phoneNumber, int salary, int yearsOfYearsOfExpiriance, string skillsDescription, MagazynSklep workingplace) 
            : base(name, surname, dateOfBirth, phoneNumber, salary, yearsOfYearsOfExpiriance)
        {
            this.workingplace = workingplace;
            this.skillsDescription = skillsDescription;
        }

        public PracownikTechniczny(string name, string surname, DateTime dateOfBirth, string phoneNumber, string sex, int salary, int yearsOfYearsOfExpiriance, string skillsDescription, MagazynSklep workingplace) 
            : base(name, surname, dateOfBirth, phoneNumber, sex, salary, yearsOfYearsOfExpiriance)
        {
            this.workingplace = workingplace;
            this.skillsDescription = skillsDescription;
        }

        public void AddNaprawa(Naprawa naprawa)
        {
            if (!naprawy.Contains(naprawa))
            {
                naprawy.Add(naprawa);
                naprawa.AddPracownikTechniczny(this);
            }
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
    }
}
