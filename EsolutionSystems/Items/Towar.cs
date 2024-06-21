using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsolutionSystems.Items
{
    [Serializable]
    public class Towar
    {
        public static List<Towar> towary { set; get; } = new List<Towar>();
        public string Name { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        [JsonIgnore]
        public List<MagazynSklep> Places { get; set; } = new List<MagazynSklep>();

        public Towar()
        {
            
        }

        public Towar(string Name, int Quantity, string Description, MagazynSklep Place, int Price)
        {
            this.Name = Name;
            this.Quantity = Quantity;
            this.Description = Description;
            this.Price = Price;
            AddPlace(Place);
        }

        public void AddPlace(MagazynSklep Place)
        {
            if (!Places.Contains(Place))
            {
                Places.Add(Place);
                Place.AddTowar(this);
            }
        }

        
    }
}
