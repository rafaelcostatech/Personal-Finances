namespace FinancesPersonnelles.Accounts
{
    partial class AccountsSetup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.accountsSetupExclusionButton = new System.Windows.Forms.Button();
            this.accountsSetupUpdateButton = new System.Windows.Forms.Button();
            this.accountsSetupGridView = new System.Windows.Forms.DataGridView();
            this.accountsSetupRichText = new System.Windows.Forms.RichTextBox();
            this.accountsSetupTypeCBox = new System.Windows.Forms.ComboBox();
            this.accountsSetupInsertButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.accountsSetupDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.accountsSetupBalanceTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.accountsSetupGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // accountsSetupExclusionButton
            // 
            this.accountsSetupExclusionButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.accountsSetupExclusionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accountsSetupExclusionButton.Enabled = false;
            this.accountsSetupExclusionButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.accountsSetupExclusionButton.FlatAppearance.BorderSize = 5;
            this.accountsSetupExclusionButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.accountsSetupExclusionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountsSetupExclusionButton.ForeColor = System.Drawing.Color.Red;
            this.accountsSetupExclusionButton.Location = new System.Drawing.Point(493, 497);
            this.accountsSetupExclusionButton.Name = "accountsSetupExclusionButton";
            this.accountsSetupExclusionButton.Size = new System.Drawing.Size(139, 40);
            this.accountsSetupExclusionButton.TabIndex = 57;
            this.accountsSetupExclusionButton.Text = "Delete";
            this.accountsSetupExclusionButton.UseVisualStyleBackColor = false;
            this.accountsSetupExclusionButton.Click += new System.EventHandler(this.accountsSetupExclusionButton_Click);
            // 
            // accountsSetupUpdateButton
            // 
            this.accountsSetupUpdateButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.accountsSetupUpdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accountsSetupUpdateButton.Enabled = false;
            this.accountsSetupUpdateButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.accountsSetupUpdateButton.FlatAppearance.BorderSize = 5;
            this.accountsSetupUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.accountsSetupUpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountsSetupUpdateButton.ForeColor = System.Drawing.Color.Blue;
            this.accountsSetupUpdateButton.Location = new System.Drawing.Point(331, 497);
            this.accountsSetupUpdateButton.Name = "accountsSetupUpdateButton";
            this.accountsSetupUpdateButton.Size = new System.Drawing.Size(139, 40);
            this.accountsSetupUpdateButton.TabIndex = 56;
            this.accountsSetupUpdateButton.Text = "Update";
            this.accountsSetupUpdateButton.UseVisualStyleBackColor = false;
            this.accountsSetupUpdateButton.Click += new System.EventHandler(this.accountsSetupUpdateButton_Click);
            // 
            // accountsSetupGridView
            // 
            this.accountsSetupGridView.AllowUserToResizeColumns = false;
            this.accountsSetupGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.accountsSetupGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.accountsSetupGridView.BackgroundColor = System.Drawing.Color.White;
            this.accountsSetupGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.accountsSetupGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.accountsSetupGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountsSetupGridView.Location = new System.Drawing.Point(11, 94);
            this.accountsSetupGridView.MultiSelect = false;
            this.accountsSetupGridView.Name = "accountsSetupGridView";
            this.accountsSetupGridView.RowHeadersVisible = false;
            this.accountsSetupGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.accountsSetupGridView.Size = new System.Drawing.Size(483, 364);
            this.accountsSetupGridView.TabIndex = 55;
            this.accountsSetupGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.accountsSetupGridView_MouseClick);
            // 
            // accountsSetupRichText
            // 
            this.accountsSetupRichText.Location = new System.Drawing.Point(616, 136);
            this.accountsSetupRichText.Name = "accountsSetupRichText";
            this.accountsSetupRichText.Size = new System.Drawing.Size(140, 103);
            this.accountsSetupRichText.TabIndex = 54;
            this.accountsSetupRichText.Text = "";
            // 
            // accountsSetupTypeCBox
            // 
            this.accountsSetupTypeCBox.FormattingEnabled = true;
            this.accountsSetupTypeCBox.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "8"});
            this.accountsSetupTypeCBox.Location = new System.Drawing.Point(616, 99);
            this.accountsSetupTypeCBox.Name = "accountsSetupTypeCBox";
            this.accountsSetupTypeCBox.Size = new System.Drawing.Size(140, 21);
            this.accountsSetupTypeCBox.TabIndex = 53;
            // 
            // accountsSetupInsertButton
            // 
            this.accountsSetupInsertButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.accountsSetupInsertButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accountsSetupInsertButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.accountsSetupInsertButton.FlatAppearance.BorderSize = 5;
            this.accountsSetupInsertButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.accountsSetupInsertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountsSetupInsertButton.ForeColor = System.Drawing.Color.Blue;
            this.accountsSetupInsertButton.Location = new System.Drawing.Point(153, 497);
            this.accountsSetupInsertButton.Name = "accountsSetupInsertButton";
            this.accountsSetupInsertButton.Size = new System.Drawing.Size(139, 40);
            this.accountsSetupInsertButton.TabIndex = 52;
            this.accountsSetupInsertButton.Text = "Insert";
            this.accountsSetupInsertButton.UseVisualStyleBackColor = false;
            this.accountsSetupInsertButton.Click += new System.EventHandler(this.accountsSetupInsertButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(500, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 51;
            this.label1.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(500, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 50;
            this.label6.Text = "Type";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(-1, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(780, 50);
            this.label2.TabIndex = 49;
            this.label2.Text = "Accounts Setup";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(500, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 58;
            this.label3.Text = "Start date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(500, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 59;
            this.label4.Text = "Balance on Start";
            // 
            // accountsSetupDateTimePicker
            // 
            this.accountsSetupDateTimePicker.Location = new System.Drawing.Point(556, 280);
            this.accountsSetupDateTimePicker.Name = "accountsSetupDateTimePicker";
            this.accountsSetupDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.accountsSetupDateTimePicker.TabIndex = 60;
            // 
            // accountsSetupBalanceTextBox
            // 
            this.accountsSetupBalanceTextBox.Location = new System.Drawing.Point(616, 350);
            this.accountsSetupBalanceTextBox.Name = "accountsSetupBalanceTextBox";
            this.accountsSetupBalanceTextBox.Size = new System.Drawing.Size(139, 20);
            this.accountsSetupBalanceTextBox.TabIndex = 61;
            this.accountsSetupBalanceTextBox.TextChanged += new System.EventHandler(this.accountsSetupBalanceTextBox_TextChanged);
            // 
            // AccountsSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.accountsSetupBalanceTextBox);
            this.Controls.Add(this.accountsSetupDateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.accountsSetupExclusionButton);
            this.Controls.Add(this.accountsSetupUpdateButton);
            this.Controls.Add(this.accountsSetupGridView);
            this.Controls.Add(this.accountsSetupRichText);
            this.Controls.Add(this.accountsSetupTypeCBox);
            this.Controls.Add(this.accountsSetupInsertButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "AccountsSetup";
            this.Text = "AccountsSetup";
            this.Load += new System.EventHandler(this.AccountsSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountsSetupGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button accountsSetupExclusionButton;
        private System.Windows.Forms.Button accountsSetupUpdateButton;
        private System.Windows.Forms.DataGridView accountsSetupGridView;
        private System.Windows.Forms.RichTextBox accountsSetupRichText;
        private System.Windows.Forms.ComboBox accountsSetupTypeCBox;
        private System.Windows.Forms.Button accountsSetupInsertButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker accountsSetupDateTimePicker;
        private System.Windows.Forms.TextBox accountsSetupBalanceTextBox;
    }
}