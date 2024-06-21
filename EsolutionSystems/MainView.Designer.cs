namespace EsolutionSystems
{
    partial class MainView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            nameLable = new Label();
            zalogowanyLable = new Label();
            LogInButton = new Button();
            RezerwacjaButton = new Button();
            Towary = new ListView();
            Nazwa = new ColumnHeader();
            Ilosc_na_stanie = new ColumnHeader();
            Opis = new ColumnHeader();
            Price = new ColumnHeader();
            Sklepy = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(56, 182, 255);
            panel1.Controls.Add(nameLable);
            panel1.Controls.Add(zalogowanyLable);
            panel1.Controls.Add(LogInButton);
            panel1.Controls.Add(RezerwacjaButton);
            panel1.Controls.Add(Towary);
            panel1.Controls.Add(Sklepy);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1342, 896);
            panel1.TabIndex = 0;
            // 
            // nameLable
            // 
            nameLable.AutoSize = true;
            nameLable.Font = new Font("Segoe UI", 15F);
            nameLable.Location = new Point(28, 751);
            nameLable.MinimumSize = new Size(400, 75);
            nameLable.Name = "nameLable";
            nameLable.Size = new Size(400, 75);
            nameLable.TabIndex = 9;
            nameLable.Text = "Zalogowano";
            nameLable.TextChanged += nameLable_TextChanged;
            nameLable.Click += nameLable_Click;
            // 
            // zalogowanyLable
            // 
            zalogowanyLable.AutoSize = true;
            zalogowanyLable.Font = new Font("Segoe UI", 15F);
            zalogowanyLable.Location = new Point(28, 676);
            zalogowanyLable.MinimumSize = new Size(400, 75);
            zalogowanyLable.Name = "zalogowanyLable";
            zalogowanyLable.Size = new Size(400, 75);
            zalogowanyLable.TabIndex = 8;
            zalogowanyLable.Text = "Nie";
            zalogowanyLable.Click += label3_Click;
            // 
            // LogInButton
            // 
            LogInButton.Location = new Point(1109, 37);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(207, 114);
            LogInButton.TabIndex = 7;
            LogInButton.Text = "Log In";
            LogInButton.UseVisualStyleBackColor = true;
            LogInButton.Click += LogInButton_Click;
            // 
            // RezerwacjaButton
            // 
            RezerwacjaButton.Location = new Point(1109, 717);
            RezerwacjaButton.Name = "RezerwacjaButton";
            RezerwacjaButton.Size = new Size(207, 130);
            RezerwacjaButton.TabIndex = 6;
            RezerwacjaButton.Text = "Zarezerwuj";
            RezerwacjaButton.UseVisualStyleBackColor = true;
            RezerwacjaButton.Click += RezerwacjaButton_Click;
            // 
            // Towary
            // 
            Towary.Columns.AddRange(new ColumnHeader[] { Nazwa, Ilosc_na_stanie, Opis, Price });
            Towary.FullRowSelect = true;
            Towary.Location = new Point(3, 269);
            Towary.Name = "Towary";
            Towary.Size = new Size(1339, 355);
            Towary.TabIndex = 5;
            Towary.UseCompatibleStateImageBehavior = false;
            Towary.View = View.Details;
            Towary.SelectedIndexChanged += Towary_SelectedIndexChanged;
            // 
            // Nazwa
            // 
            Nazwa.Text = "Nazwa";
            Nazwa.Width = 250;
            // 
            // Ilosc_na_stanie
            // 
            Ilosc_na_stanie.Text = "Ilosc_na_stanie";
            Ilosc_na_stanie.Width = 200;
            // 
            // Opis
            // 
            Opis.Text = "Opis";
            Opis.Width = 750;
            // 
            // Price
            // 
            Price.Text = "Price";
            Price.Width = 110;
            // 
            // Sklepy
            // 
            Sklepy.FormattingEnabled = true;
            Sklepy.Location = new Point(571, 69);
            Sklepy.Name = "Sklepy";
            Sklepy.Size = new Size(405, 45);
            Sklepy.TabIndex = 4;
            Sklepy.SelectedIndexChanged += Sklepy_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(571, 29);
            label2.MinimumSize = new Size(300, 0);
            label2.Name = "label2";
            label2.Size = new Size(300, 37);
            label2.TabIndex = 1;
            label2.Text = "Wybierz sklep";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(28, 37);
            label1.MinimumSize = new Size(400, 150);
            label1.Name = "label1";
            label1.Size = new Size(537, 150);
            label1.TabIndex = 0;
            label1.Text = "E-Solution Systems";
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1342, 896);
            Controls.Add(panel1);
            Name = "MainView";
            Text = "E-Solution Systems";
            FormClosing += MainView_FormClosing_1;
            Load += MainView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ComboBox Sklepy;
        private Label label2;
        private Button LogInButton;
        private Button RezerwacjaButton;
        private ListView Towary;
        private ColumnHeader Nazwa;
        private ColumnHeader Ilosc_na_stanie;
        private ColumnHeader Opis;
        private ColumnHeader Price;
        private Label zalogowanyLable;
        private Label nameLable;
    }
}
