

namespace EsolutionSystems.Items
{
    [Serializable]
    public abstract class Pracownik : Osoba
    {
        public int salary { get; set; }
        public static int minimalSalary { get; set; } = 5000;
        public int yearsOfExpiriance { get; set; }
        public int bonus { get; set; } = 500;
        public Pracownik(string name, string surname, DateTime dateOfBirth, string phoneNumber, string sex, int salary, int yearsOfYearsOfExpiriance) 
            : base(name, surname, dateOfBirth, phoneNumber, sex)
        {
            this.salary = salary;
            this.yearsOfExpiriance = yearsOfExpiriance;
        }

        public Pracownik(string name, string surname, DateTime dateOfBirth, string phoneNumber, int salary, int yearsOfYearsOfExpiriance) 
            : base(name, surname, dateOfBirth, phoneNumber)
        {
            this.salary = salary;
            this.yearsOfExpiriance = yearsOfExpiriance;
        }

        public abstract bool IsExpiriensed();
        
    }
}
