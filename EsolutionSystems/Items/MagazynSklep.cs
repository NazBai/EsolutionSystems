
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;



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
        public List<TypPomieszczenia> typyPomieszczenia { get; set; } = new List<TypPomieszczenia>();
        public string name { get; set; }
        public string adres { get; set; }
        public int area { get; set; }
        public List<string> mashineryNames { get; set; } = new List<string>();
        public List<Magazynier> magazynierzy { get; set; } = new List<Magazynier>();
        public List<Sprzedawca> sprzedawcy { get; set; } = new List<Sprzedawca>();
        public List<Naprawa> naprawy { get; set; } = new List<Naprawa>();
        public List<Towar> towary { get; set; } = new List<Towar>();
        public List<PracownikTechniczny> pracownicyTechniczni { get; set; } = new List<PracownikTechniczny>();
        public List<Zakup> zakupy { get; set; } = new List<Zakup>();
        public List<Rezerwacja> rezerwacje { get; set; } = new List<Rezerwacja>();

        
        public MagazynSklep()
        {
            
        }

        public MagazynSklep(string name, string adres, int area, List<string> mashineryNames, TypPomieszczenia typPomieszczenia)
        {
            this.name = name;
            this.adres = adres;
            this.area = area;
            this.mashineryNames = mashineryNames;
            this.typyPomieszczenia.Add(typPomieszczenia);
            magazynySklepy.Add(this);
        }

        public void AddMagazynier(Magazynier magazynier)
        {
            if (!magazynierzy.Contains(magazynier))
            {
                magazynierzy.Add(magazynier);
                magazynier.workingplace = this;
            }
        }
        public void AddSprzedawca(Sprzedawca sprzedawca)
        {
            if (!sprzedawcy.Contains(sprzedawca))
            {
                sprzedawcy.Add(sprzedawca);
                sprzedawca.workingplace = this;
            }
        }

        public void AddPracownikTechniczny(PracownikTechniczny pracownikTechniczny)
        {
            if (!pracownicyTechniczni.Contains(pracownikTechniczny))
            {
                pracownicyTechniczni.Add(pracownikTechniczny);
                pracownikTechniczny.workingplace = this;
            }
        }

        public void AddNaprawa(Naprawa naprawa)
        {
            if (!naprawy.Contains(naprawa))
            {
                naprawy.Add(naprawa);
                naprawa.place = this;
            }
        }

        public void AddTowar(Towar towar)
        {
            if (!towary.Contains(towar))
            {
                towary.Add(towar);
                towar.Addplace(this);
            }
        }

        public void AddZakup(Zakup zakup)
        {
            if (!zakupy.Contains(zakup))
            {
                zakupy.Add(zakup);
                zakup.place = this;
            }
        }

        public void AddRezerwacja(Rezerwacja rezerwacja)
        {
            if (!rezerwacje.Contains(rezerwacja))
            {
                rezerwacje.Add(rezerwacja);
                rezerwacja.place = this;
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
                Debug.WriteLine("Data saved successfully.");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error saving data: {ex.Message}");
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
