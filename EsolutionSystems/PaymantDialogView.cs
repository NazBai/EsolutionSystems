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
    public partial class PaymantDialogView : Form
    {
        public Rezerwacja rezerwacja;
        public PaymantDialogView(Rezerwacja rezerwacja)
        {
            this.rezerwacja = rezerwacja;
            InitializeComponent();
        }

        private void YesPaymentButton_Click(object sender, EventArgs e)
        {
            new PaymantDialogView(rezerwacja);
        }

        private void NoPaymentButton_Click(object sender, EventArgs e)
        {

        }
    }
}
