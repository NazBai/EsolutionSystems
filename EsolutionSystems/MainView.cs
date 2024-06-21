
using EsolutionSystems.Items;

namespace EsolutionSystems
{
    public partial class MainView : Form
    {
        bool isZalogowany = false;
        public List<MagazynSklep> magazyny = new List<MagazynSklep>();
        public List<Klient> klienci = new List<Klient>();
        public MagazynSklep selectedSklep = new MagazynSklep();
        public Towar selectedTowar = new Towar();
        public LogInView logInView;
        public RezerwacjaView rezerwacjaView { get; set; }
        public Klient logInKlient { get; set; }
        Rezerwacja rezerwacja { get; set; }
        public bool inReserwationProcess { get; set; } = false;
        public MainView()
        {
            List<string> ls = new List<string>();
            var m1 = new MagazynSklep("Sklep 1 ", "Sobieskiego 11", 120, ls, MagazynSklep.TypPomieszczenia.Sklep);
            var m2 = new MagazynSklep("Sklep 2", "Czerniakowska 12", 121, ls, MagazynSklep.TypPomieszczenia.Sklep);

            var t1 = new Towar("Telewizor", 200, "Poznaj nową przestrzeń koloru", m1, 11);
            var t2 = new Towar("Telefon", 122, "Połącz się ze światem", m1, 1);
            var t3 = new Towar("Pendrajw", 1121, "O niczym nie zapominaj", m1, 1);


            var t4 = new Towar("Komputer", 12, "Otwieraj nowe możliwości", m2, 1);
            var t5 = new Towar("Drukarka", 12, "Ciesz się realnością", m2, 1);
            var t6 = new Towar("Konsola", 12, "Grajcie całą rodziną", m2, 1);

            var k1 = new Klient("Nazar", "Bai", new DateTime(), "576615194");

            //Klient.Save();

            MagazynSklep.magazynySklepy = MagazynSklep.Load();



            
            InitializeComponent();

            this.logInView = new LogInView(nameLable, zalogowanyLable, this);
            FillSklepyData();

        }

        public void FillSklepyData()
        {
            foreach (MagazynSklep sklep in MagazynSklep.magazynySklepy)
            {
                Sklepy.Items.Add(sklep.Name);
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
                    if (sklepName == sklep.Name)
                    {
                        selectedSklep = sklep;
                    }
                }

                foreach (Towar towar in selectedSklep.Towary)
                {
                    string[] row = { towar.Name, towar.Quantity.ToString(), towar.Description, towar.Price.ToString() };

                    ListViewItem item = new ListViewItem(row);

                    Towary.Items.Add(item);
                }
            }


        }

        private void Towary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Towary.SelectedItems.Count > 0)
            {
                string selectedTowarName = Towary.SelectedItems[0].Text;

            foreach (Towar towar in selectedSklep.Towary)
            {
                if (selectedTowarName == towar.Name)
                {
                    selectedTowar = towar;
                }
            }
            }
            
        }

        public void RezerwacjaButton_Click(object sender, EventArgs e)
        {
            if (isZalogowany)
            {
                rezerwacja = new Rezerwacja(selectedTowar, selectedSklep, logInKlient);
                this.rezerwacjaView = new RezerwacjaView(rezerwacja);
                rezerwacjaView.Show();
            }
            else
            {
                inReserwationProcess = true;
                logInView.Show();
            }

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            logInView.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void nameLable_TextChanged(object sender, EventArgs e)
        {
            isZalogowany = true;
        }

        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            MagazynSklep.Save();
            Rezerwacja.Save();
            Klient.Save();
        }
    }
}
