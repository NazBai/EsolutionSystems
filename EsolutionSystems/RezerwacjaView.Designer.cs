namespace EsolutionSystems
{
    partial class RezerwacjaView
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label5 = new Label();
            CancellRezerwacjaButton = new Button();
            OKRezerwacjaButton = new Button();
            dataOdbioruTexBox = new TextBox();
            nrRezerwacjiTextBox = new TextBox();
            towarTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(56, 182, 255);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(CancellRezerwacjaButton);
            panel1.Controls.Add(OKRezerwacjaButton);
            panel1.Controls.Add(dataOdbioruTexBox);
            panel1.Controls.Add(nrRezerwacjiTextBox);
            panel1.Controls.Add(towarTextBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(954, 804);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(573, 527);
            label5.MinimumSize = new Size(300, 70);
            label5.Name = "label5";
            label5.Size = new Size(300, 70);
            label5.TabIndex = 9;
            label5.Text = "dd/mm/yyyy";
            // 
            // CancellRezerwacjaButton
            // 
            CancellRezerwacjaButton.Location = new Point(617, 630);
            CancellRezerwacjaButton.Name = "CancellRezerwacjaButton";
            CancellRezerwacjaButton.Size = new Size(225, 93);
            CancellRezerwacjaButton.TabIndex = 8;
            CancellRezerwacjaButton.Text = "Powrót";
            CancellRezerwacjaButton.UseVisualStyleBackColor = true;
            CancellRezerwacjaButton.Click += CancellRezerwacjaButton_Click;
            // 
            // OKRezerwacjaButton
            // 
            OKRezerwacjaButton.Location = new Point(122, 630);
            OKRezerwacjaButton.Name = "OKRezerwacjaButton";
            OKRezerwacjaButton.Size = new Size(213, 93);
            OKRezerwacjaButton.TabIndex = 7;
            OKRezerwacjaButton.Text = "OK";
            OKRezerwacjaButton.UseVisualStyleBackColor = true;
            OKRezerwacjaButton.Click += OKRezerwacjaButton_Click;
            // 
            // dataOdbioruTexBox
            // 
            dataOdbioruTexBox.Location = new Point(617, 481);
            dataOdbioruTexBox.Name = "dataOdbioruTexBox";
            dataOdbioruTexBox.Size = new Size(225, 43);
            dataOdbioruTexBox.TabIndex = 6;
            // 
            // nrRezerwacjiTextBox
            // 
            nrRezerwacjiTextBox.Location = new Point(617, 344);
            nrRezerwacjiTextBox.Name = "nrRezerwacjiTextBox";
            nrRezerwacjiTextBox.Size = new Size(225, 43);
            nrRezerwacjiTextBox.TabIndex = 5;
            // 
            // towarTextBox
            // 
            towarTextBox.Location = new Point(617, 187);
            towarTextBox.Name = "towarTextBox";
            towarTextBox.Size = new Size(225, 43);
            towarTextBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(64, 465);
            label4.MinimumSize = new Size(300, 70);
            label4.Name = "label4";
            label4.Size = new Size(415, 70);
            label4.TabIndex = 3;
            label4.Text = "Wpisz daté odbioru";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(64, 317);
            label3.MinimumSize = new Size(300, 70);
            label3.Name = "label3";
            label3.Size = new Size(300, 70);
            label3.TabIndex = 2;
            label3.Text = "Nr Rezerwacji";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(64, 171);
            label2.MinimumSize = new Size(300, 70);
            label2.Name = "label2";
            label2.Size = new Size(300, 70);
            label2.TabIndex = 1;
            label2.Text = "Twój Towar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(12, 24);
            label1.MinimumSize = new Size(400, 100);
            label1.Name = "label1";
            label1.Size = new Size(400, 100);
            label1.TabIndex = 0;
            label1.Text = "Rezerwacja";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(36, 36);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // RezerwacjaView
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 804);
            Controls.Add(panel1);
            Name = "RezerwacjaView";
            Text = "RezerwacjaView";
            Load += RezerwacjaView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Button CancellRezerwacjaButton;
        private Button OKRezerwacjaButton;
        private TextBox dataOdbioruTexBox;
        private TextBox nrRezerwacjiTextBox;
        private TextBox towarTextBox;
        private Label label4;
        private ContextMenuStrip contextMenuStrip1;
        private Label label5;
    }
}