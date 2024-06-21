

namespace EsolutionSystems.Items
{
    [Serializable]
    public class Towar
    {
        public static List<Towar> towary { set; get; } = new List<Towar>();
        public string name { get; set; }
        public int quantity { get; set; }
        public string description { get; set; }
        public int price { get; set; }
        public List<MagazynSklep> places { get; set; } = new List<MagazynSklep>();

        public Towar()
        {
            
        }

        public Towar(string name, int quantity, string description, MagazynSklep place, int price)
        {
            this.name = name;
            this.quantity = quantity;
            this.description = description;
            this.price = price;
            Addplace(place);
        }

        public void Addplace(MagazynSklep place)
        {
            if (!places.Contains(place))
            {
                places.Add(place);
                place.AddTowar(this);
            }
        }

        
    }
}
