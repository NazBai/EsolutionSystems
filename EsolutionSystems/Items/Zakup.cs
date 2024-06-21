

namespace EsolutionSystems.Items
{
    [Serializable]
    public class Zakup
    {
        public List<Towar> towary { get; set; }
        public MagazynSklep place { get; set; }
        public Klient klient { get; set; }

        public Zakup(List<Towar> towary, Klient klient, MagazynSklep place)
        {
            this.klient = klient;
            this.place = place;
            this.towary = towary;
            klient.AddZakup(this);
            place.AddZakup(this);
        }

        public int GetPrice()
        {
            int price = 0;

            foreach (var item in towary)
            {
                price += item.price;
            }

            return price;
        }
    }
}
