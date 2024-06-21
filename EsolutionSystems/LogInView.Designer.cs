namespace EsolutionSystems
{
    partial class LogInView
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
            hasloTexBox = new TextBox();
            loginTextBox = new TextBox();
            CancelLogInButton = new Button();
            OKLoginButton = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(56, 182, 255);
            panel1.Controls.Add(hasloTexBox);
            panel1.Controls.Add(loginTextBox);
            panel1.Controls.Add(CancelLogInButton);
            panel1.Controls.Add(OKLoginButton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(870, 865);
            panel1.TabIndex = 0;
            // 
            // hasloTexBox
            // 
            hasloTexBox.Location = new Point(384, 468);
            hasloTexBox.Name = "hasloTexBox";
            hasloTexBox.Size = new Size(398, 43);
            hasloTexBox.TabIndex = 6;
            // 
            // loginTextBox
            // 
            loginTextBox.Location = new Point(384, 303);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(398, 43);
            loginTextBox.TabIndex = 5;
            // 
            // CancelLogInButton
            // 
            CancelLogInButton.Location = new Point(557, 659);
            CancelLogInButton.Name = "CancelLogInButton";
            CancelLogInButton.Size = new Size(225, 93);
            CancelLogInButton.TabIndex = 4;
            CancelLogInButton.Text = "Powrót";
            CancelLogInButton.UseVisualStyleBackColor = true;
            CancelLogInButton.Click += CancelLogInButton_Click;
            // 
            // OKLoginButton
            // 
            OKLoginButton.Location = new Point(106, 659);
            OKLoginButton.Name = "OKLoginButton";
            OKLoginButton.Size = new Size(225, 93);
            OKLoginButton.TabIndex = 3;
            OKLoginButton.Text = "OK";
            OKLoginButton.UseVisualStyleBackColor = true;
            OKLoginButton.Click += OKLoginButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(106, 450);
            label3.Name = "label3";
            label3.Size = new Size(139, 61);
            label3.TabIndex = 2;
            label3.Text = "Hasło";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(106, 287);
            label2.Name = "label2";
            label2.Size = new Size(137, 61);
            label2.TabIndex = 1;
            label2.Text = "Login";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(182, 89);
            label1.Name = "label1";
            label1.Size = new Size(480, 120);
            label1.TabIndex = 0;
            label1.Text = "Zaloguj się";
            // 
            // LogInView
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 865);
            Controls.Add(panel1);
            Name = "LogInView";
            Text = "LogInView";
            Load += LogInView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox hasloTexBox;
        private TextBox loginTextBox;
        private Button CancelLogInButton;
        private Button OKLoginButton;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}