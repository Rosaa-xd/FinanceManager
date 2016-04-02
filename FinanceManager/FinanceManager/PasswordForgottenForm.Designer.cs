namespace FinanceManager
{
    partial class PasswordForgottenForm
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
            this.lbl_ShowPasswordForgotten = new System.Windows.Forms.Label();
            this.lbl_ShowEMail = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_SendPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ShowPasswordForgotten
            // 
            this.lbl_ShowPasswordForgotten.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ShowPasswordForgotten.AutoSize = true;
            this.lbl_ShowPasswordForgotten.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ShowPasswordForgotten.Location = new System.Drawing.Point(12, 9);
            this.lbl_ShowPasswordForgotten.Name = "lbl_ShowPasswordForgotten";
            this.lbl_ShowPasswordForgotten.Size = new System.Drawing.Size(257, 32);
            this.lbl_ShowPasswordForgotten.TabIndex = 0;
            this.lbl_ShowPasswordForgotten.Text = "Forgot Password?";
            // 
            // lbl_ShowEMail
            // 
            this.lbl_ShowEMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ShowEMail.AutoSize = true;
            this.lbl_ShowEMail.Location = new System.Drawing.Point(13, 65);
            this.lbl_ShowEMail.Name = "lbl_ShowEMail";
            this.lbl_ShowEMail.Size = new System.Drawing.Size(65, 13);
            this.lbl_ShowEMail.TabIndex = 1;
            this.lbl_ShowEMail.Text = "E-Mailadres:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(84, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btn_SendPassword
            // 
            this.btn_SendPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_SendPassword.Location = new System.Drawing.Point(98, 88);
            this.btn_SendPassword.Name = "btn_SendPassword";
            this.btn_SendPassword.Size = new System.Drawing.Size(75, 23);
            this.btn_SendPassword.TabIndex = 3;
            this.btn_SendPassword.Text = "Send";
            this.btn_SendPassword.UseVisualStyleBackColor = true;
            // 
            // PasswordForgottenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 119);
            this.Controls.Add(this.btn_SendPassword);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_ShowEMail);
            this.Controls.Add(this.lbl_ShowPasswordForgotten);
            this.Name = "PasswordForgottenForm";
            this.Text = "Retrieve Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ShowPasswordForgotten;
        private System.Windows.Forms.Label lbl_ShowEMail;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_SendPassword;
    }
}