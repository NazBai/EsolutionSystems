namespace EsolutionSystems
{
    partial class DostawaView
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
            DostawaOKButton = new Button();
            DostawaCancelButton = new Button();
            adresTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(56, 182, 255);
            panel1.Controls.Add(DostawaOKButton);
            panel1.Controls.Add(DostawaCancelButton);
            panel1.Controls.Add(adresTextBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(964, 532);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // DostawaOKButton
            // 
            DostawaOKButton.Location = new Point(75, 378);
            DostawaOKButton.Name = "DostawaOKButton";
            DostawaOKButton.Size = new Size(216, 105);
            DostawaOKButton.TabIndex = 5;
            DostawaOKButton.Text = "OK";
            DostawaOKButton.UseVisualStyleBackColor = true;
            DostawaOKButton.Click += DostawaOKButton_Click;
            // 
            // DostawaCancelButton
            // 
            DostawaCancelButton.Location = new Point(701, 369);
            DostawaCancelButton.Name = "DostawaCancelButton";
            DostawaCancelButton.Size = new Size(200, 105);
            DostawaCancelButton.TabIndex = 4;
            DostawaCancelButton.Text = "Powrót";
            DostawaCancelButton.UseVisualStyleBackColor = true;
            // 
            // adresTextBox
            // 
            adresTextBox.Location = new Point(592, 241);
            adresTextBox.Name = "adresTextBox";
            adresTextBox.Size = new Size(309, 43);
            adresTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(42, 225);
            label2.Name = "label2";
            label2.Size = new Size(443, 61);
            label2.TabIndex = 2;
            label2.Text = "Wpisz adres dostawy";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(357, 86);
            label1.Name = "label1";
            label1.Size = new Size(262, 81);
            label1.TabIndex = 1;
            label1.Text = "Dostawa";
            // 
            // DostawaView
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 532);
            Controls.Add(panel1);
            Name = "DostawaView";
            Text = "DostawaView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button DostawaOKButton;
        private Button DostawaCancelButton;
        private TextBox adresTextBox;
    }
}