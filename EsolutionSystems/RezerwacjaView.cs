using EsolutionSystems.Items;
using System.Text.RegularExpressions;

namespace EsolutionSystems
{
    public partial class RezerwacjaView : Form
    {
        public Towar towar { set; get; }
        Rezerwacja rezerwacja { set; get; }

        MainView mainView { set; get; }
        public RezerwacjaView(Rezerwacja rezerwacja)
        {
            this.towar = towar;
            InitializeComponent();
            this.rezerwacja = rezerwacja;
            UpdateRezerwacjaInfo();
        }

        public void UpdateRezerwacjaInfo()
        {
            nrRezerwacjiTextBox.Text = rezerwacja.reserwacjaId + "";
            nrRezerwacjiTextBox.ReadOnly = true;

            towarTextBox.Text = rezerwacja.towar.name;
            towarTextBox.ReadOnly = true;
        }


        private void RezerwacjaView_Load(object sender, EventArgs e)
        {

        }

        private void OKRezerwacjaButton_Click(object sender, EventArgs e)
        {
            string pattern = @"^(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/[0-9]{4}$";

            if (Regex.IsMatch(dataOdbioruTexBox.Text, pattern))
            {
                try
                {
                    string[] data = dataOdbioruTexBox.Text.Split("/");
                    int day = int.Parse(data[0]);
                    int month = int.Parse(data[1]);
                    int year = int.Parse(data[2]);


                    rezerwacja.dataOdbioru = new DateTime(year, month, day);
                    rezerwacja.status = Rezerwacja.Status.NIE_OPLACONA;
                    new RezerwacjaConfirmationView(rezerwacja, this).Show();
                    this.Hide();


                }
                catch (FormatException)
                {
                    Console.WriteLine("Input string is not a valid number.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Number is too large or too small for an Int32.");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CancellRezerwacjaButton_Click(object sender, EventArgs e)
        {
            rezerwacja.towar.quantity++;
            Rezerwacja.rezerwacje.Remove(rezerwacja);
            mainView.selectedSklep.rezerwacje.Remove(rezerwacja);
            mainView.logInKlient.rezerwacje.Remove(rezerwacja);
            this.Hide();
        }
    }
}
