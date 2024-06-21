using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;

namespace EsolutionSystems.Items
{
    [Serializable]
    public class Klient : Osoba
    {
        public List<Zakup> zakupy { get; set; }
        public static List<Klient> allKlients { get; set; } = new List<Klient>();
        public List<Rezerwacja> rezerwacje { get; set; } = new List<Rezerwacja>();
        public Klient(string Name, string Surname, DateTime DateOfBirth, string PhoneNumber) : base(Name, Surname, DateOfBirth, PhoneNumber)
        {
            allKlients.Add(this);
        }

        public Klient(string Name, string Surname, DateTime DateOfBirth, string PhoneNumber, string Sex) : base(Name, Surname, DateOfBirth, PhoneNumber, Sex)
        {
            allKlients.Add(this);
        }

        public override int GetAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dateOfBirth.Year;

            if (dateOfBirth.Date > today.AddYears(-age))
                age--;

            return age;
        }

        public void AddZakup(Zakup Zakup)
        {
            if (!zakupy.Contains(Zakup))
            {
                zakupy.Add(Zakup);
                Zakup.klient = this;
            }
        }

        public void AddRezerwacja(Rezerwacja rezerwacja)
        {
            if (!rezerwacje.Contains(rezerwacja))
            {
                rezerwacje.Add(rezerwacja);
                rezerwacja.klient = this;
            }
        }

        public static void Save()
        {

            try
            {
                string solutionDir = AppDomain.CurrentDomain.BaseDirectory;
                string filePath = Path.Combine(solutionDir, "klienci.dat");

#pragma warning disable SYSLIB0011 // Type or member is obsolete
                BinaryFormatter formatter = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // Type or member is obsolete
                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    formatter.Serialize(stream, allKlients);
                }
                Debug.WriteLine("Data saved successfully.");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error saving data: {ex.Message}");
            }
        }

        public static List<Klient> Load()
        {
            List<Klient> loadedData = new List<Klient>();
            try
            {
                string solutionDir = AppDomain.CurrentDomain.BaseDirectory;
                string filePath = Path.Combine(solutionDir, "klienci.dat");

                if (File.Exists(filePath))
                {
#pragma warning disable SYSLIB0011 // Type or member is obsolete
                    BinaryFormatter formatter = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // Type or member is obsolete
                    using (FileStream stream = new FileStream(filePath, FileMode.Open))
                    {
                        loadedData = (List<Klient>)formatter.Deserialize(stream);
                    }
                    Debug.WriteLine("Data loaded successfully.");
                }
                else
                {
                    Debug.WriteLine("File not found. No data loaded.");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error loading data: {ex.Message}");
            }
            return loadedData;
        }
    }
}
