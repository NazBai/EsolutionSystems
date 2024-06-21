namespace EsolutionSystems
{
    partial class RezerwacjaConfirmationView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            RezerwacjaConfirmationCancelButton = new Button();
            RezerwacjaConfirmationOKButton = new Button();
            dateTexBox = new TextBox();
            priceTexBox = new TextBox();
            towarTexBox = new TextBox();
            RadioButtons = new GroupBox();
            DeliveryRadioButton = new RadioButton();
            TakeAwayRadioButton = new RadioButton();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            rezervationNumberLabel = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            RadioButtons.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(56, 182, 255);
            panel1.Controls.Add(RezerwacjaConfirmationCancelButton);
            panel1.Controls.Add(RezerwacjaConfirmationOKButton);
            panel1.Controls.Add(dateTexBox);
            panel1.Controls.Add(priceTexBox);
            panel1.Controls.Add(towarTexBox);
            panel1.Controls.Add(RadioButtons);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(rezervationNumberLabel);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(878, 881);
            panel1.TabIndex = 0;
            // 
            // RezerwacjaConfirmationCancelButton
            // 
            RezerwacjaConfirmationCancelButton.Location = new Point(621, 738);
            RezerwacjaConfirmationCancelButton.Name = "RezerwacjaConfirmationCancelButton";
            RezerwacjaConfirmationCancelButton.Size = new Size(211, 86);
            RezerwacjaConfirmationCancelButton.TabIndex = 15;
            RezerwacjaConfirmationCancelButton.Text = "Powrót";
            RezerwacjaConfirmationCancelButton.UseVisualStyleBackColor = true;
            RezerwacjaConfirmationCancelButton.Click += RezerwacjaConfirmationCancelButton_Click;
            // 
            // RezerwacjaConfirmationOKButton
            // 
            RezerwacjaConfirmationOKButton.Location = new Point(70, 738);
            RezerwacjaConfirmationOKButton.Name = "RezerwacjaConfirmationOKButton";
            RezerwacjaConfirmationOKButton.Size = new Size(196, 86);
            RezerwacjaConfirmationOKButton.TabIndex = 14;
            RezerwacjaConfirmationOKButton.Text = "OK";
            RezerwacjaConfirmationOKButton.UseVisualStyleBackColor = true;
            RezerwacjaConfirmationOKButton.Click += RezerwacjaConfirmationOKButton_Click;
            // 
            // dateTexBox
            // 
            dateTexBox.Location = new Point(565, 408);
            dateTexBox.Name = "dateTexBox";
            dateTexBox.Size = new Size(225, 43);
            dateTexBox.TabIndex = 13;
            // 
            // priceTexBox
            // 
            priceTexBox.Location = new Point(565, 281);
            priceTexBox.Name = "priceTexBox";
            priceTexBox.Size = new Size(225, 43);
            priceTexBox.TabIndex = 12;
            // 
            // towarTexBox
            // 
            towarTexBox.Location = new Point(565, 177);
            towarTexBox.Name = "towarTexBox";
            towarTexBox.Size = new Size(225, 43);
            towarTexBox.TabIndex = 11;
            // 
            // RadioButtons
            // 
            RadioButtons.Controls.Add(DeliveryRadioButton);
            RadioButtons.Controls.Add(TakeAwayRadioButton);
            RadioButtons.Location = new Point(120, 571);
            RadioButtons.Name = "RadioButtons";
            RadioButtons.Size = new Size(656, 126);
            RadioButtons.TabIndex = 10;
            RadioButtons.TabStop = false;
            RadioButtons.Text = "Sposób Odbioru";
            // 
            // DeliveryRadioButton
            // 
            DeliveryRadioButton.AutoSize = true;
            DeliveryRadioButton.Location = new Point(406, 52);
            DeliveryRadioButton.Name = "DeliveryRadioButton";
            DeliveryRadioButton.Size = new Size(151, 41);
            DeliveryRadioButton.TabIndex = 9;
            DeliveryRadioButton.TabStop = true;
            DeliveryRadioButton.Text = "Dostawa";
            DeliveryRadioButton.UseVisualStyleBackColor = true;
            // 
            // TakeAwayRadioButton
            // 
            TakeAwayRadioButton.AutoSize = true;
            TakeAwayRadioButton.Location = new Point(30, 52);
            TakeAwayRadioButton.Name = "TakeAwayRadioButton";
            TakeAwayRadioButton.Size = new Size(238, 41);
            TakeAwayRadioButton.TabIndex = 8;
            TakeAwayRadioButton.TabStop = true;
            TakeAwayRadioButton.Text = "Odbiór osobisty";
            TakeAwayRadioButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(70, 390);
            label6.Name = "label6";
            label6.Size = new Size(289, 61);
            label6.TabIndex = 5;
            label6.Text = "Data odbioru";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(84, 497);
            label5.Name = "label5";
            label5.Size = new Size(775, 37);
            label5.TabIndex = 4;
            label5.Text = "Żeby zakończyć Rezerwacje wybierz sposób odbioru zamówienia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(70, 265);
            label4.Name = "label4";
            label4.Size = new Size(366, 61);
            label4.TabIndex = 3;
            label4.Text = "Kwota do zapłaty";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(70, 159);
            label3.Name = "label3";
            label3.Size = new Size(244, 61);
            label3.TabIndex = 2;
            label3.Text = "Twoj towar";
            // 
            // rezervationNumberLabel
            // 
            rezervationNumberLabel.AutoSize = true;
            rezervationNumberLabel.Font = new Font("Segoe UI", 20F);
            rezervationNumberLabel.Location = new Point(565, 39);
            rezervationNumberLabel.Name = "rezervationNumberLabel";
            rezervationNumberLabel.Size = new Size(194, 81);
            rezervationNumberLabel.TabIndex = 1;
            rezervationNumberLabel.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(70, 39);
            label1.Name = "label1";
            label1.Size = new Size(422, 81);
            label1.TabIndex = 0;
            label1.Text = "Rezerwacja Nr:";
            // 
            // RezerwacjaConfirmationView
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 881);
            Controls.Add(panel1);
            Name = "RezerwacjaConfirmationView";
            Text = "RezerwacjaConfirmationView";
            Load += RezerwacjaConfirmationView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            RadioButtons.ResumeLayout(false);
            RadioButtons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label rezervationNumberLabel;
        private Label label1;
        private RadioButton DeliveryRadioButton;
        private RadioButton TakeAwayRadioButton;
        private GroupBox RadioButtons;
        private Button RezerwacjaConfirmationCancelButton;
        private Button RezerwacjaConfirmationOKButton;
        private TextBox dateTexBox;
        private TextBox priceTexBox;
        private TextBox towarTexBox;
    }
}