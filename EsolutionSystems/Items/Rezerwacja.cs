
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;

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
        public DateTime dataOdbioru { get; set; }
        public int reserwacjaId { get; set; }
        public Towar towar { get; set; }
        public MagazynSklep place { get; set; }
        public Klient klient { get; set; }

        public Dostawa dostawa { set; get; }



        public Rezerwacja(Towar towar, MagazynSklep place, Klient klient)
        {
            this.dataOdbioru = dataOdbioru;
            this.reserwacjaId = GetId();
            this.towar = towar;
            this.place = place;
            this.klient = klient;
            place.AddRezerwacja(this);
            klient.AddRezerwacja(this);
            rezerwacje.Add(this);
        }

        public void addDostawa(string Adres)
        {
            dostawa = new Dostawa(Adres);
        }

        [Serializable]
        public class Dostawa
        {
            public string Adres { get; set; }

            internal Dostawa(string Adres)
            {
                this.Adres = Adres;
            }
        }

        public int GetId()
        {
            return rezerwacje.Count + 1;
        }

        public static void Save()
        {
            try
            {
                string solutionDir = AppDomain.CurrentDomain.BaseDirectory;
                string filePath = Path.Combine(solutionDir, "Rezerwacje.dat");

#pragma warning disable SYSLIB0011 // Type or member is obsolete
                BinaryFormatter formatter = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // Type or member is obsolete
                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    formatter.Serialize(stream, rezerwacje);
                }
                Debug.WriteLine("Data saved successfully.");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error saving data: {ex.Message}");
            }
        }

        public static List<Rezerwacja> Load()
        {
            List<Rezerwacja> loadedData = new List<Rezerwacja>();
            try
            {
                string solutionDir = AppDomain.CurrentDomain.BaseDirectory;
                string filePath = Path.Combine(solutionDir, "Rezerwacje.dat");

                if (File.Exists(filePath))
                {
#pragma warning disable SYSLIB0011 // Type or member is obsolete
                    BinaryFormatter formatter = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // Type or member is obsolete
                    using (FileStream stream = new FileStream(filePath, FileMode.Open))
                    {
                        loadedData = (List<Rezerwacja>)formatter.Deserialize(stream);
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
