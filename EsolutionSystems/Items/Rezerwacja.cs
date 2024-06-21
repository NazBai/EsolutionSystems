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
    public class Rezerwacja
    {
        public static List<Rezerwacja> rezerwacje {  get; set; } = new List<Rezerwacja>();
        public enum Status
        {
            W_TRAKCIE_TWORZENIA, 
            OPLACONA, 
            NIE_OPLACONA, 
            ANULOWANO, 
            ODEBRANO
        }
        public Status status { get; set; } = Status.W_TRAKCIE_TWORZENIA;
        public DateTime DataOdbioru { get; set; }
        public int ReserwacjaId { get; set; }
        public Towar Towar { get; set; }
        public MagazynSklep Place { get; set; }
        public Klient Klient { get; set; }

        private Dostawa Delivery;



        public Rezerwacja(Towar Towar, MagazynSklep Place, Klient Klient)
        {
            this.DataOdbioru = DataOdbioru;
            this.ReserwacjaId = GetHighestRezerwacjaNumber() + 1;
            this.Towar = Towar;
            this.Place = Place;
            this.Klient = Klient;
            Place.AddRezerwacja(this);
            Klient.AddRezerwacja(this);
            rezerwacje.Add(this);
        }

        public void addDostawa(string Adres)
        {
            Delivery = new Dostawa(Adres);
        }

        private class Dostawa
        {
            private string Adres { get; set; }

            public Dostawa(string Adres)
            {
                this.Adres = Adres;
            }
        }

        public int GetHighestRezerwacjaNumber()
        {
            if (rezerwacje.Count() == 0)
            {
                return 0;
            }

            return rezerwacje.OrderByDescending(p => p.ReserwacjaId).FirstOrDefault().ReserwacjaId;
        }

        public static void Save()
        {
            try
            {
                string solutionDir = AppDomain.CurrentDomain.BaseDirectory;
                string filePath = Path.Combine(solutionDir, "rezerwacje.dat");

#pragma warning disable SYSLIB0011 // Type or member is obsolete
                BinaryFormatter formatter = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // Type or member is obsolete
                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    formatter.Serialize(stream, rezerwacje);
                }
                Console.WriteLine("Data saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving data: {ex.Message}");
            }
        }

        public static List<Rezerwacja> Load()
        {
            List<Rezerwacja> loadedData = new List<Rezerwacja>();
            try
            {
                string solutionDir = AppDomain.CurrentDomain.BaseDirectory;
                string filePath = Path.Combine(solutionDir, "rezerwacje.dat");

                if (File.Exists(filePath))
                {
#pragma warning disable SYSLIB0011 // Type or member is obsolete
                    BinaryFormatter formatter = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // Type or member is obsolete
                    using (FileStream stream = new FileStream(filePath, FileMode.Open))
                    {
                        loadedData = (List<Rezerwacja>)formatter.Deserialize(stream);
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
