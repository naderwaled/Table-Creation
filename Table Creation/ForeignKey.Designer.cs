namespace Table_Creation
{
    partial class ForeignKey
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FkTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RColCBox = new System.Windows.Forms.ComboBox();
            this.CurrCol = new System.Windows.Forms.ComboBox();
            this.AddFkBtn = new System.Windows.Forms.Button();
            this.RTableCBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FkTxt
            // 
            this.FkTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FkTxt.Location = new System.Drawing.Point(360, 110);
            this.FkTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FkTxt.Name = "FkTxt";
            this.FkTxt.Size = new System.Drawing.Size(172, 24);
            this.FkTxt.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(357, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 24);
            this.label4.TabIndex = 25;
            this.label4.Text = "Foreign Key Table";
            // 
            // RColCBox
            // 
            this.RColCBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RColCBox.FormattingEnabled = true;
            this.RColCBox.Location = new System.Drawing.Point(21, 168);
            this.RColCBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RColCBox.Name = "RColCBox";
            this.RColCBox.Size = new System.Drawing.Size(166, 24);
            this.RColCBox.TabIndex = 24;
            // 
            // CurrCol
            // 
            this.CurrCol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CurrCol.FormattingEnabled = true;
            this.CurrCol.Location = new System.Drawing.Point(360, 167);
            this.CurrCol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CurrCol.Name = "CurrCol";
            this.CurrCol.Size = new System.Drawing.Size(172, 24);
            this.CurrCol.TabIndex = 23;
            // 
            // AddFkBtn
            // 
            this.AddFkBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddFkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(219)))), ((int)(((byte)(213)))));
            this.AddFkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddFkBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFkBtn.Location = new System.Drawing.Point(227, 241);
            this.AddFkBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddFkBtn.Name = "AddFkBtn";
            this.AddFkBtn.Size = new System.Drawing.Size(97, 39);
            this.AddFkBtn.TabIndex = 22;
            this.AddFkBtn.Text = "Add";
            this.AddFkBtn.UseVisualStyleBackColor = false;
            this.AddFkBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddFKBtn_MouseClick);
            // 
            // RTableCBox
            // 
            this.RTableCBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RTableCBox.FormattingEnabled = true;
            this.RTableCBox.Location = new System.Drawing.Point(21, 111);
            this.RTableCBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RTableCBox.Name = "RTableCBox";
            this.RTableCBox.Size = new System.Drawing.Size(161, 24);
            this.RTableCBox.TabIndex = 21;
            this.RTableCBox.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Primary Key Table";
            // 
            // ForeignKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(141)))), ((int)(((byte)(158)))));
            this.Controls.Add(this.FkTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RColCBox);
            this.Controls.Add(this.CurrCol);
            this.Controls.Add(this.AddFkBtn);
            this.Controls.Add(this.RTableCBox);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ForeignKey";
            this.Size = new System.Drawing.Size(548, 347);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FkTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox RColCBox;
        private System.Windows.Forms.ComboBox CurrCol;
        private System.Windows.Forms.Button AddFkBtn;
        private System.Windows.Forms.ComboBox RTableCBox;
        private System.Windows.Forms.Label label2;
    }
}
