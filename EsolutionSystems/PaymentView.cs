using EsolutionSystems.Items;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsolutionSystems
{
    public partial class PaymentView : Form
    {
        public Rezerwacja rezerwacja;
        public PaymentView(Rezerwacja rezerwacja)
        {
            this.rezerwacja = rezerwacja;
            InitializeComponent();
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
            }
            else
            {
                MessageBox.Show("Niepoprawne dane do transakcji, spróbój ponownie", "Błąd transakcji", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
