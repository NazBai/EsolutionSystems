using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace EsolutionSystems.Items
{
    [Serializable]
    public class Klient : Osoba
    {
        public List<Zakup> Zakupy { get; set; }
        public static List<Klient> AllKlients { get; set; } = new List<Klient>();
        public List<Rezerwacja> Rezerwacje { get; set; } = new List<Rezerwacja>();
        public Klient(string Name, string Surname, DateTime DateOfBirth, string PhoneNumber) : base(Name, Surname, DateOfBirth, PhoneNumber)
        {
            AllKlients.Add(this);
        }

        public Klient(string Name, string Surname, DateTime DateOfBirth, string PhoneNumber, string Sex) : base(Name, Surname, DateOfBirth, PhoneNumber, Sex)
        {
            AllKlients.Add(this);
        }

        public override int GetAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - DateOfBirth.Year;

            if (DateOfBirth.Date > today.AddYears(-age))
                age--;

            return age;
        }

        public void AddZakup(Zakup Zakup)
        {
            if (!Zakupy.Contains(Zakup))
            {
                Zakupy.Add(Zakup);
                Zakup.Klient = this;
            }
        }

        public void AddRezerwacja(Rezerwacja Rezerwacja)
        {
            if (!Rezerwacje.Contains(Rezerwacja))
            {
                Rezerwacje.Add(Rezerwacja);
                Rezerwacja.Klient = this;
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
                    formatter.Serialize(stream, AllKlients);
                }
                Console.WriteLine("Data saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving data: {ex.Message}");
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
                    Console.WriteLine("Data loaded successfully.");
                }
                else
                {
                    Console.WriteLine("File not found. No data loaded.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading data: {ex.Message}");
            }
            return loadedData;
        }
    }
}
