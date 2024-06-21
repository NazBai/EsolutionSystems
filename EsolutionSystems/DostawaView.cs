using EsolutionSystems.Items;

namespace EsolutionSystems
{
    public partial class DostawaView : Form
    {
        private Rezerwacja rezerwacja;
        private RezerwacjaConfirmationView rezerwacjaConfirmation;
        public DostawaView(Rezerwacja rezerwacja, RezerwacjaConfirmationView rezerwacjaConfirmation)
        {
            this.rezerwacjaConfirmation = rezerwacjaConfirmation;
            this.rezerwacja = rezerwacja;
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DostawaOKButton_Click(object sender, EventArgs e)
        {
            rezerwacja.addDostawa(adresTextBox.Text);
            new PaymantDialogView(rezerwacja, this).Show();
            this.Hide();
        }

        private void DostawaCancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            rezerwacjaConfirmation.Show();
        }

        private void DostawaView_Load(object sender, EventArgs e)
        {

        }
    }
}
