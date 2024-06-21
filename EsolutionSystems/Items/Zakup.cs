using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsolutionSystems.Items
{
    [Serializable]
    public class Zakup
    {
        public List<Towar> Towary { get; set; }
        public MagazynSklep Place { get; set; }
        public Klient Klient { get; set; }

        public Zakup(List<Towar> Towary, Klient Klient, MagazynSklep Place)
        {
            this.Klient = Klient;
            this.Place = Place;
            this.Towary = Towary;
            Klient.AddZakup(this);
            Place.AddZakup(this);
        }

        public int GetPrice()
        {
            int price = 0;

            foreach (var item in Towary)
            {
                price += item.Price;
            }

            return price;
        }
    }
}
