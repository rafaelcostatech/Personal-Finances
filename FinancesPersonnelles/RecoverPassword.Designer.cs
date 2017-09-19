namespace FinancesPersonnelles
{
    partial class RecoverPassword
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
            this.recoverBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // recoverBtn
            // 
            this.recoverBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recoverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recoverBtn.ForeColor = System.Drawing.Color.Black;
            this.recoverBtn.Location = new System.Drawing.Point(113, 159);
            this.recoverBtn.Name = "recoverBtn";
            this.recoverBtn.Size = new System.Drawing.Size(109, 50);
            this.recoverBtn.TabIndex = 7;
            this.recoverBtn.Text = "Recover";
            this.recoverBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email";
            // 
            // emailTxtBox
            // 
            this.emailTxtBox.Location = new System.Drawing.Point(142, 57);
            this.emailTxtBox.Name = "emailTxtBox";
            this.emailTxtBox.PasswordChar = '*';
            this.emailTxtBox.Size = new System.Drawing.Size(180, 20);
            this.emailTxtBox.TabIndex = 5;
            // 
            // RecoverPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(334, 269);
            this.Controls.Add(this.recoverBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailTxtBox);
            this.MaximizeBox = false;
            this.Name = "RecoverPassword";
            this.Text = "Recover your Username and Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button recoverBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailTxtBox;
    }
}