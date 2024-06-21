namespace EsolutionSystems
{
    partial class PaymentView
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
            EXDateTexBox = new TextBox();
            CVVTexBox = new TextBox();
            cardNumberTexBox = new TextBox();
            PaymentCancelButton = new Button();
            PaymentOkButton = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(56, 182, 255);
            panel1.Controls.Add(EXDateTexBox);
            panel1.Controls.Add(CVVTexBox);
            panel1.Controls.Add(cardNumberTexBox);
            panel1.Controls.Add(PaymentCancelButton);
            panel1.Controls.Add(PaymentOkButton);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(876, 703);
            panel1.TabIndex = 0;
            // 
            // EXDateTexBox
            // 
            EXDateTexBox.Location = new Point(563, 378);
            EXDateTexBox.Name = "EXDateTexBox";
            EXDateTexBox.Size = new Size(225, 43);
            EXDateTexBox.TabIndex = 8;
            // 
            // CVVTexBox
            // 
            CVVTexBox.Location = new Point(563, 272);
            CVVTexBox.Name = "CVVTexBox";
            CVVTexBox.Size = new Size(225, 43);
            CVVTexBox.TabIndex = 7;
            // 
            // cardNumberTexBox
            // 
            cardNumberTexBox.Location = new Point(563, 158);
            cardNumberTexBox.Name = "cardNumberTexBox";
            cardNumberTexBox.Size = new Size(225, 43);
            cardNumberTexBox.TabIndex = 6;
            // 
            // PaymentCancelButton
            // 
            PaymentCancelButton.Location = new Point(587, 538);
            PaymentCancelButton.Name = "PaymentCancelButton";
            PaymentCancelButton.Size = new Size(211, 88);
            PaymentCancelButton.TabIndex = 5;
            PaymentCancelButton.Text = "Powrót";
            PaymentCancelButton.UseVisualStyleBackColor = true;
            PaymentCancelButton.Click += PaymentCancelButton_Click;
            // 
            // PaymentOkButton
            // 
            PaymentOkButton.Location = new Point(38, 540);
            PaymentOkButton.Name = "PaymentOkButton";
            PaymentOkButton.Size = new Size(200, 86);
            PaymentOkButton.TabIndex = 4;
            PaymentOkButton.Text = "OK";
            PaymentOkButton.UseVisualStyleBackColor = true;
            PaymentOkButton.Click += PaymentOkButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(38, 360);
            label4.Name = "label4";
            label4.Size = new Size(469, 61);
            label4.TabIndex = 3;
            label4.Text = "Termin Ważności karty";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(38, 254);
            label3.Name = "label3";
            label3.Size = new Size(111, 61);
            label3.TabIndex = 2;
            label3.Text = "CVV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(38, 140);
            label2.Name = "label2";
            label2.Size = new Size(191, 61);
            label2.TabIndex = 1;
            label2.Text = "Nr Karty";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(191, 21);
            label1.Name = "label1";
            label1.Size = new Size(514, 81);
            label1.TabIndex = 0;
            label1.Text = "Dane do płatności";
            // 
            // PaymentView
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 703);
            Controls.Add(panel1);
            Name = "PaymentView";
            Text = "PaymentView";
            Load += PaymentView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox EXDateTexBox;
        private TextBox CVVTexBox;
        private TextBox cardNumberTexBox;
        private Button PaymentCancelButton;
        private Button PaymentOkButton;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}