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
    public partial class DostawaView : Form
    {
        public Rezerwacja rezerwacja;
        public DostawaView(Rezerwacja rezerwacja)
        {
            this.rezerwacja = rezerwacja;
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DostawaOKButton_Click(object sender, EventArgs e)
        {
            rezerwacja.addDostawa(adresTextBox.Text);
            new PaymantDialogView(rezerwacja).Show();
            this.Hide();
        }
    }
}
