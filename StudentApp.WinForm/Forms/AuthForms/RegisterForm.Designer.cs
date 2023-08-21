namespace StudentApp.WinForm.Forms.AuthForms
{
    partial class RegisterForm
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
            label2 = new Label();
            label1 = new Label();
            txtName = new TextBox();
            txtLastName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtPhoneNumber = new TextBox();
            label5 = new Label();
            txtUsername = new TextBox();
            label6 = new Label();
            cmbGender = new ComboBox();
            txtPassword = new TextBox();
            label7 = new Label();
            btnRegister = new Button();
            btnCancel = new Button();
            txtStudentNumber = new TextBox();
            label8 = new Label();
            label9 = new Label();
            cmbInstructor = new ComboBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 105);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 22);
            label2.TabIndex = 5;
            label2.Text = "Soyadı :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 67);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 22);
            label1.TabIndex = 6;
            label1.Text = "Adı :";
            // 
            // txtName
            // 
            txtName.Location = new Point(221, 64);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.Size = new Size(480, 30);
            txtName.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(221, 102);
            txtLastName.Margin = new Padding(4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(480, 30);
            txtLastName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(297, 24);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(230, 22);
            label3.TabIndex = 6;
            label3.Text = "Kullanıcı Kayıt Ekranı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 143);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(120, 22);
            label4.TabIndex = 5;
            label4.Text = "Cinsiyeti :";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(221, 178);
            txtPhoneNumber.Margin = new Padding(4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(480, 30);
            txtPhoneNumber.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 181);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(200, 22);
            label5.TabIndex = 5;
            label5.Text = "Telefon Numarası : ";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(221, 216);
            txtUsername.Margin = new Padding(4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(480, 30);
            txtUsername.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 219);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(160, 22);
            label6.TabIndex = 5;
            label6.Text = "Kullanıcı Adı :";
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(221, 140);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(480, 30);
            cmbGender.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(221, 254);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(480, 30);
            txtPassword.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(119, 257);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(80, 22);
            label7.TabIndex = 5;
            label7.Text = "Şifre :";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(119, 380);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(582, 41);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Kayıt Ol";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(119, 427);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(582, 41);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Vazgeç";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtStudentNumber
            // 
            txtStudentNumber.Location = new Point(221, 292);
            txtStudentNumber.Margin = new Padding(4);
            txtStudentNumber.Name = "txtStudentNumber";
            txtStudentNumber.Size = new Size(480, 30);
            txtStudentNumber.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 295);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(190, 22);
            label8.TabIndex = 5;
            label8.Text = "Öğrenci Numarası :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(79, 332);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(130, 22);
            label9.TabIndex = 5;
            label9.Text = "Danışmanı : ";
            // 
            // cmbInstructor
            // 
            cmbInstructor.FormattingEnabled = true;
            cmbInstructor.Location = new Point(221, 329);
            cmbInstructor.Name = "cmbInstructor";
            cmbInstructor.Size = new Size(480, 30);
            cmbInstructor.TabIndex = 7;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 557);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Controls.Add(cmbInstructor);
            Controls.Add(cmbGender);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(txtPassword);
            Controls.Add(txtStudentNumber);
            Controls.Add(txtUsername);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtLastName);
            Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Kayıt Formu";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txtName;
        private TextBox txtLastName;
        private Label label3;
        private Label label4;
        private TextBox txtPhoneNumber;
        private Label label5;
        private TextBox txtUsername;
        private Label label6;
        private ComboBox cmbGender;
        private TextBox txtPassword;
        private Label label7;
        private Button btnRegister;
        private Button btnCancel;
        private TextBox txtStudentNumber;
        private Label label8;
        private Label label9;
        private ComboBox cmbInstructor;
    }
}