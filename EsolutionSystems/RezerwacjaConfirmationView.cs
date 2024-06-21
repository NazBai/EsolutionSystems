using EsolutionSystems.Items;

namespace EsolutionSystems
{
    public partial class RezerwacjaConfirmationView : Form
    {
        public Rezerwacja rezerwacja;
        private RezerwacjaView rezerwacjaView;
        public RezerwacjaConfirmationView(Rezerwacja rezerwacja, RezerwacjaView rezerwacjaView)
        {
            this.rezerwacjaView = rezerwacjaView;
            this.rezerwacja = rezerwacja;
            InitializeComponent();
            UpdateViewData();
        }

        public void UpdateViewData()
        {
            rezervationNumberLabel.Text = rezerwacja.reserwacjaId + "";
            towarTexBox.Text = rezerwacja.towar.name;
            towarTexBox.ReadOnly = true;
            priceTexBox.Text = rezerwacja.towar.price + "";
            dateTexBox.Text = rezerwacja.dataOdbioru.ToString();

        }

        private void RezerwacjaConfirmationView_Load(object sender, EventArgs e)
        {

        }

        private void RezerwacjaConfirmationOKButton_Click(object sender, EventArgs e)
        {
            if (RadioButtons.Controls[0] is RadioButton radioButton && radioButton.Checked)
            {
                new DostawaView(rezerwacja, this).Show();
            }
            else
            {
                new PaymantDialogView(rezerwacja, this).Show();
            }

            this.Hide();
        }

        private void RezerwacjaConfirmationCancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            rezerwacjaView.Show();
        }
    }
}
