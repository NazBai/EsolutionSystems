using EsolutionSystems.Items;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsolutionSystems
{
    public partial class RezerwacjaConfirmationView : Form
    {
        public Rezerwacja rezerwacja;
        public RezerwacjaConfirmationView(Rezerwacja rezerwacja)
        {
            this.rezerwacja = rezerwacja;
            InitializeComponent();
            UpdateViewData();
        }

        public void UpdateViewData()
        {
            rezervationNumberLabel.Text = rezerwacja.ReserwacjaId + "";
            towarTexBox.Text = rezerwacja.Towar.Name;
            towarTexBox.ReadOnly = true;
            priceTexBox.Text = rezerwacja.Towar.Price + "";
            dateTexBox.Text = rezerwacja.DataOdbioru.ToString();

        }

        private void RezerwacjaConfirmationView_Load(object sender, EventArgs e)
        {

        }

        private void RezerwacjaConfirmationOKButton_Click(object sender, EventArgs e)
        {
            if (RadioButtons.Controls[0] is RadioButton radioButton && radioButton.Checked)
            {
                new DostawaView(rezerwacja).Show();
            }
            else
            {
                new PaymantDialogView(rezerwacja).Show();
            }

            this.Hide();
        }
    }
}
