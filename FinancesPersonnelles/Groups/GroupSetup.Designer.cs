namespace FinancesPersonnelles
{
    partial class GroupSetup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupInsertionInsertButton = new System.Windows.Forms.Button();
            this.groupInsertionComboBox = new System.Windows.Forms.ComboBox();
            this.groupInsertionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.groupMovementSetupGridView = new System.Windows.Forms.DataGridView();
            this.groupInsertionUpdateButton = new System.Windows.Forms.Button();
            this.groupExclusionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupMovementSetupGridView)).BeginInit();
            this.SuspendLayout();
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
            this.label2.TabIndex = 16;
            this.label2.Text = "Movement Groups Setup";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(500, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(500, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Description";
            // 
            // groupInsertionInsertButton
            // 
            this.groupInsertionInsertButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.groupInsertionInsertButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupInsertionInsertButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.groupInsertionInsertButton.FlatAppearance.BorderSize = 5;
            this.groupInsertionInsertButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupInsertionInsertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupInsertionInsertButton.ForeColor = System.Drawing.Color.Blue;
            this.groupInsertionInsertButton.Location = new System.Drawing.Point(153, 497);
            this.groupInsertionInsertButton.Name = "groupInsertionInsertButton";
            this.groupInsertionInsertButton.Size = new System.Drawing.Size(139, 40);
            this.groupInsertionInsertButton.TabIndex = 32;
            this.groupInsertionInsertButton.Text = "Insert";
            this.groupInsertionInsertButton.UseVisualStyleBackColor = false;
            this.groupInsertionInsertButton.Click += new System.EventHandler(this.groupInsertionInsertButton_Click);
            // 
            // groupInsertionComboBox
            // 
            this.groupInsertionComboBox.FormattingEnabled = true;
            this.groupInsertionComboBox.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "8"});
            this.groupInsertionComboBox.Location = new System.Drawing.Point(616, 99);
            this.groupInsertionComboBox.Name = "groupInsertionComboBox";
            this.groupInsertionComboBox.Size = new System.Drawing.Size(140, 21);
            this.groupInsertionComboBox.TabIndex = 33;
            // 
            // groupInsertionRichTextBox
            // 
            this.groupInsertionRichTextBox.Location = new System.Drawing.Point(616, 207);
            this.groupInsertionRichTextBox.Name = "groupInsertionRichTextBox";
            this.groupInsertionRichTextBox.Size = new System.Drawing.Size(140, 251);
            this.groupInsertionRichTextBox.TabIndex = 34;
            this.groupInsertionRichTextBox.Text = "";
            // 
            // groupMovementSetupGridView
            // 
            this.groupMovementSetupGridView.AllowUserToResizeColumns = false;
            this.groupMovementSetupGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupMovementSetupGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.groupMovementSetupGridView.BackgroundColor = System.Drawing.Color.White;
            this.groupMovementSetupGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.groupMovementSetupGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.groupMovementSetupGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupMovementSetupGridView.Location = new System.Drawing.Point(11, 94);
            this.groupMovementSetupGridView.MultiSelect = false;
            this.groupMovementSetupGridView.Name = "groupMovementSetupGridView";
            this.groupMovementSetupGridView.RowHeadersVisible = false;
            this.groupMovementSetupGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.groupMovementSetupGridView.Size = new System.Drawing.Size(483, 364);
            this.groupMovementSetupGridView.TabIndex = 35;
            this.groupMovementSetupGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.groupMovementSetupGridView_MouseClick);
            this.groupMovementSetupGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.groupMovementSetupGridView_MouseDoubleClick);
            // 
            // groupInsertionUpdateButton
            // 
            this.groupInsertionUpdateButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.groupInsertionUpdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupInsertionUpdateButton.Enabled = false;
            this.groupInsertionUpdateButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.groupInsertionUpdateButton.FlatAppearance.BorderSize = 5;
            this.groupInsertionUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupInsertionUpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupInsertionUpdateButton.ForeColor = System.Drawing.Color.Blue;
            this.groupInsertionUpdateButton.Location = new System.Drawing.Point(331, 497);
            this.groupInsertionUpdateButton.Name = "groupInsertionUpdateButton";
            this.groupInsertionUpdateButton.Size = new System.Drawing.Size(139, 40);
            this.groupInsertionUpdateButton.TabIndex = 36;
            this.groupInsertionUpdateButton.Text = "Update";
            this.groupInsertionUpdateButton.UseVisualStyleBackColor = false;
            this.groupInsertionUpdateButton.Click += new System.EventHandler(this.groupInsertionUpdateButton_Click);
            // 
            // groupExclusionButton
            // 
            this.groupExclusionButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.groupExclusionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupExclusionButton.Enabled = false;
            this.groupExclusionButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.groupExclusionButton.FlatAppearance.BorderSize = 5;
            this.groupExclusionButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupExclusionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupExclusionButton.ForeColor = System.Drawing.Color.Red;
            this.groupExclusionButton.Location = new System.Drawing.Point(493, 497);
            this.groupExclusionButton.Name = "groupExclusionButton";
            this.groupExclusionButton.Size = new System.Drawing.Size(139, 40);
            this.groupExclusionButton.TabIndex = 48;
            this.groupExclusionButton.Text = "Delete";
            this.groupExclusionButton.UseVisualStyleBackColor = false;
            this.groupExclusionButton.Click += new System.EventHandler(this.groupExclusionButton_Click);
            // 
            // GroupSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupExclusionButton);
            this.Controls.Add(this.groupInsertionUpdateButton);
            this.Controls.Add(this.groupMovementSetupGridView);
            this.Controls.Add(this.groupInsertionRichTextBox);
            this.Controls.Add(this.groupInsertionComboBox);
            this.Controls.Add(this.groupInsertionInsertButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "GroupSetup";
            this.Text = "Group Insertion";
            ((System.ComponentModel.ISupportInitialize)(this.groupMovementSetupGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button groupInsertionInsertButton;
        private System.Windows.Forms.ComboBox groupInsertionComboBox;
        private System.Windows.Forms.RichTextBox groupInsertionRichTextBox;
        private System.Windows.Forms.DataGridView groupMovementSetupGridView;
        private System.Windows.Forms.Button groupInsertionUpdateButton;
        private System.Windows.Forms.Button groupExclusionButton;
    }
}