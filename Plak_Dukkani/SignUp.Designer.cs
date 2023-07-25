namespace Plak_Dukkani
{
    partial class SignUp
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
            txtSUPassword = new TextBox();
            txtSUUserName = new TextBox();
            btnSignUp = new Button();
            btnHome = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 109);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 7;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 51);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 6;
            label1.Text = "User Name:";
            // 
            // txtSUPassword
            // 
            txtSUPassword.Location = new Point(166, 106);
            txtSUPassword.Name = "txtSUPassword";
            txtSUPassword.PasswordChar = '*';
            txtSUPassword.Size = new Size(100, 23);
            txtSUPassword.TabIndex = 5;
            // 
            // txtSUUserName
            // 
            txtSUUserName.Location = new Point(166, 48);
            txtSUUserName.Name = "txtSUUserName";
            txtSUUserName.Size = new Size(100, 23);
            txtSUUserName.TabIndex = 4;
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(166, 170);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(75, 23);
            btnSignUp.TabIndex = 10;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(26, 170);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(95, 23);
            btnHome.TabIndex = 11;
            btnHome.Text = "Back Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 235);
            Controls.Add(btnHome);
            Controls.Add(btnSignUp);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSUPassword);
            Controls.Add(txtSUUserName);
            Name = "SignUp";
            Text = "Sign Up Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txtSUPassword;
        private TextBox txtSUUserName;
        private Button btnSignUp;
        private Button btnHome;
    }
}