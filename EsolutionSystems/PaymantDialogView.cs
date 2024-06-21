using EsolutionSystems.Items;

namespace EsolutionSystems
{
    public partial class PaymantDialogView : Form
    {
        private Rezerwacja rezerwacja;
        private Form callingForm;
        public PaymantDialogView(Rezerwacja rezerwacja, Form callingForm)
        {
            this.callingForm = callingForm;
            this.rezerwacja = rezerwacja;
            InitializeComponent();
        }

        private void YesPaymentButton_Click(object sender, EventArgs e)
        {
            new PaymentView(rezerwacja, this).Show();
            this.Hide();
        }

        private void NoPaymentButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dane rezerwacji zostały zapisane pomyślnie", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);


            Klient.Save();
            this.Hide();
        }

        private void PowrotButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            callingForm.Show();

        }
    }
}
