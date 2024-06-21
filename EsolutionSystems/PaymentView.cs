using EsolutionSystems.Items;
using System.Text.RegularExpressions;

namespace EsolutionSystems
{
    public partial class PaymentView : Form
    {
        public Rezerwacja rezerwacja;
        private PaymantDialogView paymantDialogView;
        public PaymentView(Rezerwacja rezerwacja, PaymantDialogView paymantDialogView)
        {
            this.rezerwacja = rezerwacja;
            InitializeComponent();
            this.paymantDialogView = paymantDialogView;
        }

        private void PaymentOkButton_Click(object sender, EventArgs e)
        {
            string cardNumberPattern = @"^\d{16}$";
            string CVVPattern = @"^\d{3}$";
            string datePattern = @"^(0[1-9]|1[0-2])/[0-9]{4}$";

            if (Regex.IsMatch(cardNumberTexBox.Text, cardNumberPattern) && Regex.IsMatch(CVVTexBox.Text, CVVPattern) && Regex.IsMatch(EXDateTexBox.Text, datePattern))
            {
                MessageBox.Show("Dane rezerwacji zostały zapisane pomyślnie", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rezerwacja.status = Rezerwacja.Status.OPLACONA;
                this.Hide();

                Klient.Save();
            }
            else
            {
                MessageBox.Show("Niepoprawne dane do transakcji, spróbój ponownie", "Błąd transakcji", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PaymentCancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            paymantDialogView.Show();
        }

        private void PaymentView_Load(object sender, EventArgs e)
        {

        }
    }
}
