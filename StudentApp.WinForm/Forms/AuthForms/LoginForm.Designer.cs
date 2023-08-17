namespace StudentApp.WinForm
{
    partial class LoginForm
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
            btnLogin = new Button();
            btnClose = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(60, 123);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(435, 45);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Giriş Yap";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(60, 225);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(435, 45);
            btnClose.TabIndex = 4;
            btnClose.Text = "Kapat";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(225, 77);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(270, 30);
            txtPassword.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(225, 26);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(270, 30);
            txtUsername.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 29);
            label1.Name = "label1";
            label1.Size = new Size(160, 22);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 80);
            label2.Name = "label2";
            label2.Size = new Size(80, 22);
            label2.TabIndex = 2;
            label2.Text = "Şifre :";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(60, 174);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(435, 45);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Kayıt Ol";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 339);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(btnClose);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button btnClose;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label1;
        private Label label2;
        private Button btnRegister;
    }
}