using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using Formatting = Newtonsoft.Json.Formatting;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;


namespace EsolutionSystems.Items
{
    [Serializable]
    public class MagazynSklep
    {
        public static List<MagazynSklep> magazynySklepy { get; set; } = new List<MagazynSklep>();
        public enum TypPomieszczenia
        {
            Magazyn,
            Sklep
        }
        public List<TypPomieszczenia> TypyPomieszczenia { get; set; } = new List<TypPomieszczenia>();
        public string Name { get; set; }
        public string Adres { get; set; }
        public int Area { get; set; }
        public List<string> MashineryNames { get; set; } = new List<string>();
        public List<Magazynier> Magazynierzy { get; set; } = new List<Magazynier>();
        public List<Sprzedawca> Sprzedawcy { get; set; } = new List<Sprzedawca>();
        public List<Naprawa> Naprawy { get; set; } = new List<Naprawa>();
        public List<Towar> Towary { get; set; } = new List<Towar>();
        public List<PracownikTechniczny> PracownicyTechniczni { get; set; } = new List<PracownikTechniczny>();
        public List<Zakup> Zakupy { get; set; } = new List<Zakup>();
        public List<Rezerwacja> Rezerwacje { get; set; } = new List<Rezerwacja>();

        
        public MagazynSklep()
        {
            
        }

        public MagazynSklep(string Name, string Adres, int Area, List<string> MashineryNames, TypPomieszczenia typPomieszczenia)
        {
            this.Name = Name;
            this.Adres = Adres;
            this.Area = Area;
            this.MashineryNames = MashineryNames;
            this.TypyPomieszczenia.Add(typPomieszczenia);
            magazynySklepy.Add(this);
        }

        public void AddMagazynier(Magazynier Magazynier)
        {
            if (!Magazynierzy.Contains(Magazynier))
            {
                Magazynierzy.Add(Magazynier);
                Magazynier.WorkingPlace = this;
            }
        }
        public void AddSprzedawca(Sprzedawca Sprzedawca)
        {
            if (!Sprzedawcy.Contains(Sprzedawca))
            {
                Sprzedawcy.Add(Sprzedawca);
                Sprzedawca.WorkingPlace = this;
            }
        }

        public void AddPracownikTechniczny(PracownikTechniczny PracownikTechniczny)
        {
            if (!PracownicyTechniczni.Contains(PracownikTechniczny))
            {
                PracownicyTechniczni.Add(PracownikTechniczny);
                PracownikTechniczny.WorkingPlace = this;
            }
        }

        public void AddNaprawa(Naprawa Naprawa)
        {
            if (!Naprawy.Contains(Naprawa))
            {
                Naprawy.Add(Naprawa);
                Naprawa.Place = this;
            }
        }

        public void AddTowar(Towar Towar)
        {
            if (!Towary.Contains(Towar))
            {
                Towary.Add(Towar);
                Towar.AddPlace(this);
            }
        }

        public void AddZakup(Zakup Zakup)
        {
            if (!Zakupy.Contains(Zakup))
            {
                Zakupy.Add(Zakup);
                Zakup.Place = this;
            }
        }

        public void AddRezerwacja(Rezerwacja Rezerwacja)
        {
            if (!Rezerwacje.Contains(Rezerwacja))
            {
                Rezerwacje.Add(Rezerwacja);
                Rezerwacja.Place = this;
            }
        }

        public static void Save()
        {
            try
            {
                string solutionDir = AppDomain.CurrentDomain.BaseDirectory;
                string filePath = Path.Combine(solutionDir, "magazyny.dat");

#pragma warning disable SYSLIB0011 // Type or member is obsolete
                BinaryFormatter formatter = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // Type or member is obsolete
                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    formatter.Serialize(stream, magazynySklepy);
                }
                Console.WriteLine("Data saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving data: {ex.Message}");
            }
        }

        public static List<MagazynSklep> Load()
        {
            List<MagazynSklep> loadedData = new List<MagazynSklep>();
            try
            {
                string solutionDir = AppDomain.CurrentDomain.BaseDirectory;
                string filePath = Path.Combine(solutionDir, "magazyny.dat");

                if (File.Exists(filePath))
                {
#pragma warning disable SYSLIB0011 // Type or member is obsolete
                    BinaryFormatter formatter = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // Type or member is obsolete
                    using (FileStream stream = new FileStream(filePath, FileMode.Open))
                    {
                        loadedData = (List<MagazynSklep>)formatter.Deserialize(stream);
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
