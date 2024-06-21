namespace EsolutionSystems
{
    partial class PaymantDialogView
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
            NoPaymentButton = new Button();
            YesPaymentButton = new Button();
            label1 = new Label();
            PowrotButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(56, 182, 255);
            panel1.Controls.Add(PowrotButton);
            panel1.Controls.Add(NoPaymentButton);
            panel1.Controls.Add(YesPaymentButton);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1012, 314);
            panel1.TabIndex = 0;
            // 
            // NoPaymentButton
            // 
            NoPaymentButton.Location = new Point(651, 202);
            NoPaymentButton.Name = "NoPaymentButton";
            NoPaymentButton.Size = new Size(320, 81);
            NoPaymentButton.TabIndex = 2;
            NoPaymentButton.Text = "Zapłata przy odbiorze";
            NoPaymentButton.UseVisualStyleBackColor = true;
            NoPaymentButton.Click += NoPaymentButton_Click;
            // 
            // YesPaymentButton
            // 
            YesPaymentButton.Location = new Point(82, 202);
            YesPaymentButton.Name = "YesPaymentButton";
            YesPaymentButton.Size = new Size(320, 81);
            YesPaymentButton.TabIndex = 1;
            YesPaymentButton.Text = "Tak";
            YesPaymentButton.UseVisualStyleBackColor = true;
            YesPaymentButton.Click += YesPaymentButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(983, 81);
            label1.TabIndex = 0;
            label1.Text = "Czy chcesz dokonsć płatności teraz?";
            // 
            // PowrotButton
            // 
            PowrotButton.Location = new Point(448, 200);
            PowrotButton.Name = "PowrotButton";
            PowrotButton.Size = new Size(175, 83);
            PowrotButton.TabIndex = 3;
            PowrotButton.Text = "Powrót";
            PowrotButton.UseVisualStyleBackColor = true;
            PowrotButton.Click += PowrotButton_Click;
            // 
            // PaymantDialogView
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 314);
            Controls.Add(panel1);
            Name = "PaymantDialogView";
            Text = "PaymantDialogView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button NoPaymentButton;
        private Button YesPaymentButton;
        private Label label1;
        private Button PowrotButton;
    }
}