namespace FinanceManager
{
    partial class FinanceManagerForm
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
            this.tc_FinanceManager = new System.Windows.Forms.TabControl();
            this.tp_Account = new System.Windows.Forms.TabPage();
            this.tp_MainBankAccount = new System.Windows.Forms.TabPage();
            this.tc_FinanceManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_FinanceManager
            // 
            this.tc_FinanceManager.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tc_FinanceManager.Controls.Add(this.tp_Account);
            this.tc_FinanceManager.Controls.Add(this.tp_MainBankAccount);
            this.tc_FinanceManager.Location = new System.Drawing.Point(-2, -2);
            this.tc_FinanceManager.Name = "tc_FinanceManager";
            this.tc_FinanceManager.SelectedIndex = 0;
            this.tc_FinanceManager.Size = new System.Drawing.Size(857, 534);
            this.tc_FinanceManager.TabIndex = 0;
            // 
            // tp_Account
            // 
            this.tp_Account.Location = new System.Drawing.Point(4, 22);
            this.tp_Account.Name = "tp_Account";
            this.tp_Account.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Account.Size = new System.Drawing.Size(849, 508);
            this.tp_Account.TabIndex = 0;
            this.tp_Account.Text = "Account";
            this.tp_Account.UseVisualStyleBackColor = true;
            // 
            // tp_MainBankAccount
            // 
            this.tp_MainBankAccount.Location = new System.Drawing.Point(4, 22);
            this.tp_MainBankAccount.Name = "tp_MainBankAccount";
            this.tp_MainBankAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tp_MainBankAccount.Size = new System.Drawing.Size(849, 508);
            this.tp_MainBankAccount.TabIndex = 1;
            this.tp_MainBankAccount.Text = "<BankAccountNO>";
            this.tp_MainBankAccount.UseVisualStyleBackColor = true;
            // 
            // FinanceManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 528);
            this.Controls.Add(this.tc_FinanceManager);
            this.Name = "FinanceManagerForm";
            this.Text = "Finance Manager";
            this.tc_FinanceManager.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_FinanceManager;
        private System.Windows.Forms.TabPage tp_Account;
        private System.Windows.Forms.TabPage tp_MainBankAccount;
    }
}