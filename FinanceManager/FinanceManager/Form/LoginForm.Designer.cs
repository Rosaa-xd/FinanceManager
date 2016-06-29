namespace FinanceManager
{
    partial class LoginForm
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
            this.btn_LogIn = new System.Windows.Forms.Button();
            this.lbl_ShowLogIn = new System.Windows.Forms.Label();
            this.lbl_ShowUsername = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.lbl_ShowPassword = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.llbl_ForgotPassword = new System.Windows.Forms.LinkLabel();
            this.llbl_Register = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_LogIn.Location = new System.Drawing.Point(102, 209);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(76, 40);
            this.btn_LogIn.TabIndex = 0;
            this.btn_LogIn.Text = "Log In";
            this.btn_LogIn.UseVisualStyleBackColor = true;
            this.btn_LogIn.Click += new System.EventHandler(this.btn_LogIn_Click);
            // 
            // lbl_ShowLogIn
            // 
            this.lbl_ShowLogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ShowLogIn.AutoSize = true;
            this.lbl_ShowLogIn.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ShowLogIn.Location = new System.Drawing.Point(90, 9);
            this.lbl_ShowLogIn.Name = "lbl_ShowLogIn";
            this.lbl_ShowLogIn.Size = new System.Drawing.Size(99, 32);
            this.lbl_ShowLogIn.TabIndex = 1;
            this.lbl_ShowLogIn.Text = "Log In";
            // 
            // lbl_ShowUsername
            // 
            this.lbl_ShowUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ShowUsername.AutoSize = true;
            this.lbl_ShowUsername.Location = new System.Drawing.Point(41, 89);
            this.lbl_ShowUsername.Name = "lbl_ShowUsername";
            this.lbl_ShowUsername.Size = new System.Drawing.Size(55, 13);
            this.lbl_ShowUsername.TabIndex = 2;
            this.lbl_ShowUsername.Text = "Username";
            // 
            // tb_Username
            // 
            this.tb_Username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Username.Location = new System.Drawing.Point(102, 86);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(141, 20);
            this.tb_Username.TabIndex = 3;
            // 
            // lbl_ShowPassword
            // 
            this.lbl_ShowPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ShowPassword.AutoSize = true;
            this.lbl_ShowPassword.Location = new System.Drawing.Point(41, 134);
            this.lbl_ShowPassword.Name = "lbl_ShowPassword";
            this.lbl_ShowPassword.Size = new System.Drawing.Size(53, 13);
            this.lbl_ShowPassword.TabIndex = 4;
            this.lbl_ShowPassword.Text = "Password";
            // 
            // tb_Password
            // 
            this.tb_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_Password.Location = new System.Drawing.Point(102, 131);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(141, 20);
            this.tb_Password.TabIndex = 5;
            // 
            // llbl_ForgotPassword
            // 
            this.llbl_ForgotPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.llbl_ForgotPassword.AutoSize = true;
            this.llbl_ForgotPassword.Location = new System.Drawing.Point(99, 154);
            this.llbl_ForgotPassword.Name = "llbl_ForgotPassword";
            this.llbl_ForgotPassword.Size = new System.Drawing.Size(92, 13);
            this.llbl_ForgotPassword.TabIndex = 6;
            this.llbl_ForgotPassword.TabStop = true;
            this.llbl_ForgotPassword.Text = "Forgot Password?";
            this.llbl_ForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_ForgotPassword_LinkClicked);
            // 
            // llbl_Register
            // 
            this.llbl_Register.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.llbl_Register.AutoSize = true;
            this.llbl_Register.Location = new System.Drawing.Point(202, 236);
            this.llbl_Register.Name = "llbl_Register";
            this.llbl_Register.Size = new System.Drawing.Size(70, 13);
            this.llbl_Register.TabIndex = 7;
            this.llbl_Register.TabStop = true;
            this.llbl_Register.Text = "Register here";
            this.llbl_Register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_Register_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.llbl_Register);
            this.Controls.Add(this.llbl_ForgotPassword);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.lbl_ShowPassword);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.lbl_ShowUsername);
            this.Controls.Add(this.lbl_ShowLogIn);
            this.Controls.Add(this.btn_LogIn);
            this.Name = "LoginForm";
            this.Text = "Finance Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_LogIn;
        private System.Windows.Forms.Label lbl_ShowLogIn;
        private System.Windows.Forms.Label lbl_ShowUsername;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Label lbl_ShowPassword;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.LinkLabel llbl_ForgotPassword;
        private System.Windows.Forms.LinkLabel llbl_Register;
    }
}

