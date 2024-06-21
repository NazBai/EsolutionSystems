using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsolutionSystems.Items
{
    [Serializable]
    public class Naprawa
    {

        public string NameOfDevice { get; set; }
        public int Price { get; set; }
        public int NumberOfDaysToEnd { get; set; }
        public List<PracownikTechniczny> PracownicyTechniczni { get; set; }
        public Klient Klient { get; }
        public MagazynSklep Place { get; set; }

        public Naprawa(string NameOfDevice, int Price, int NumberOfDaysToEnd, Klient Klient, MagazynSklep Place)
        {
            this.NameOfDevice = NameOfDevice;
            this.Price = Price;
            this.NumberOfDaysToEnd = NumberOfDaysToEnd;
            this.Klient = Klient;
            this.Place = Place;
            Place.AddNaprawa(this);
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
