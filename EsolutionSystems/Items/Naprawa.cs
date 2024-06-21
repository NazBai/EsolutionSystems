

namespace EsolutionSystems.Items
{
    [Serializable]
    public class Naprawa
    {

        public string nameOfDevice { get; set; }
        public int Price { get; set; }
        public int NumberOfDaysToEnd { get; set; }
        public List<PracownikTechniczny> PracownicyTechniczni { get; set; }
        public Klient Klient { get; }
        public MagazynSklep place { get; set; }

        public Naprawa(string nameOfDevice, int price, int numberOfDaysToEnd, Klient klient, MagazynSklep place)
        {
            this.nameOfDevice = nameOfDevice;
            this.Price = price;
            this.NumberOfDaysToEnd = numberOfDaysToEnd;
            this.Klient = klient;
            this.place = place;
            place.AddNaprawa(this);
        }

        public void AddPracownikTechniczny(PracownikTechniczny PracownikTechniczny)
        {
            if (PracownicyTechniczni.Count <= 3 && !PracownicyTechniczni.Contains(PracownikTechniczny))
            {
                PracownicyTechniczni.Add(PracownikTechniczny);
                PracownikTechniczny.AddNaprawa(this);
            }
        }
    }
}
