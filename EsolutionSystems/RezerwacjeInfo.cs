using EsolutionSystems.Items;

namespace EsolutionSystems
{
    public partial class RezerwacjeInfo : Form
    {
        public Klient klient;
        public RezerwacjeInfo(Klient klient)
        {
            this.klient = klient;
            InitializeComponent();
            FillRezerwacjaData();
        }

        private void FillRezerwacjaData()
        {
            listView1.Items.Clear();
            if (klient != null)
            {
                

                foreach (Rezerwacja rezerwacja in klient.rezerwacje)
                {
                    string dostawa = "Brak";
                    string adressDostawy = "-";
                    if(rezerwacja.dostawa != null)
                    {
                        dostawa = "Tak";
                        adressDostawy = rezerwacja.dostawa.Adres;
                    }
                    string[] row = { rezerwacja.reserwacjaId.ToString(), rezerwacja.status.ToString(), rezerwacja.place.name, rezerwacja.dataOdbioru.ToString(), rezerwacja.towar.name, dostawa, adressDostawy};

                    ListViewItem item = new ListViewItem(row);

                    listView1.Items.Add(item);
                }
            }
        }

        private void RezerwacjeInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
