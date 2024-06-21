
using EsolutionSystems.Items;

namespace EsolutionSystems
{
    public partial class MainView : Form
    {
        public bool isZalogowany = false;
        public MagazynSklep selectedSklep = new MagazynSklep();
        public Towar selectedTowar = new Towar();

        public Klient logInKlient { get; set; }
        public Rezerwacja rezerwacja { get; set; }
        public bool inReserwationProcess { get; set; } = false;
        public MainView()
        {

            

            LoadAllData();

            InitializeComponent();
            FillSklepyData();
        }

        private void LoadAllData()
        {
            Klient.allKlients = Klient.Load();
            MagazynSklep.magazynySklepy = MagazynSklep.Load();
            Rezerwacja.rezerwacje = Rezerwacja.Load();
        }

        private void SaveAallData()
        {

            MagazynSklep.Save();
            Rezerwacja.Save();
            Klient.Save();
        }

        public void FillSklepyData()
        {
            foreach (MagazynSklep sklep in MagazynSklep.magazynySklepy)
            {
                Sklepy.Items.Add(sklep.name);
            }
        }

        private void MainView_Load(object sender, EventArgs e)
        {
        }

        private void Sklepy_SelectedIndexChanged(object sender, EventArgs e)
        {

            Towary.Items.Clear();

            if (Sklepy.SelectedItem.ToString() != null)
            {
                string sklepName = Sklepy.SelectedItem.ToString();

                foreach (MagazynSklep sklep in MagazynSklep.magazynySklepy)
                {
                    if (sklepName == sklep.name)
                    {
                        selectedSklep = sklep;
                    }
                }

                foreach (Towar towar in selectedSklep.towary)
                {
                    string[] row = { towar.name, towar.quantity.ToString(), towar.description, towar.price.ToString() };

                    ListViewItem item = new ListViewItem(row);

                    Towary.Items.Add(item);
                }
            }


        }

        private void Towary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Towary.SelectedItems.Count > 0)
            {
                string selectedTowarName = Towary.SelectedItems[0].Text;

                foreach (Towar towar in selectedSklep.towary)
                {
                    if (selectedTowarName == towar.name)
                    {
                        selectedTowar = towar;
                    }
                }
            }

        }

        public void RezerwacjaButton_Click(object sender, EventArgs e)
        {
            if (isZalogowany && Sklepy.SelectedItem != null)
            {
                selectedTowar.quantity--;
                rezerwacja = new Rezerwacja(selectedTowar, selectedSklep, logInKlient);
                new RezerwacjaView(rezerwacja).Show();
                
            }
            else
            {
                inReserwationProcess = true;
                new LogInView(nameLable, zalogowanyLable, this).Show();
            }

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            new LogInView(nameLable, zalogowanyLable, this).Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void nameLable_TextChanged(object sender, EventArgs e)
        {
            isZalogowany = true;
        }

        

        private void nameLable_Click(object sender, EventArgs e)
        {
            if (nameLable.Text != "Zalogowano")
            {
                new RezerwacjeInfo(logInKlient).Show();
            }
        }

        private void MainView_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                System.Diagnostics.Debug.WriteLine("sawing");
                SaveAallData();
                this.Dispose();
            }
        }
    }
}
