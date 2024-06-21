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
    public partial class LogInView : Form
    {
        Label nameLabel;
        Label zalogowanyLabel;
        MainView mainView;
        public LogInView(Label nameLabel, Label zalogowanyLabel, MainView mainView)
        {
            this.nameLabel = nameLabel;
            this.zalogowanyLabel = zalogowanyLabel;
            InitializeComponent();
            this.mainView = mainView;
        }

        private void LogInView_Load(object sender, EventArgs e)
        {

        }

        private void OKLoginButton_Click(object sender, EventArgs e)
        {
            bool logInSucces = false;
            if (hasloTexBox.Text.Length > 0 && loginTextBox.Text.Length > 0)
            {
                foreach (Klient klient in Klient.AllKlients)
                {
                    if (klient.Name == loginTextBox.Text)
                    {
                        mainView.logInKlient = klient;
                        zalogowanyLabel.Text = "Zalogowany: ";
                        nameLabel.Text = loginTextBox.Text;
                        logInSucces = true;
                    }

                }

                if (mainView.inReserwationProcess)
                {
                    mainView.RezerwacjaButton_Click(this, null);
                }

                if (logInSucces)
                {
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Niepoprawne dane logowania, spróbój ponownie", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {

                MessageBox.Show("Niepoprawne dane logowania, spróbój ponownie", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void CancelLogInButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
