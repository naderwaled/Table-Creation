namespace Table_Creation
{
    partial class AddTable
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
            this.ConsTxt = new System.Windows.Forms.TextBox();
            this.ConsLbl = new System.Windows.Forms.Label();
            this.ConsCBox = new System.Windows.Forms.ComboBox();
            this.TConsLbl = new System.Windows.Forms.Label();
            this.AddColBtn = new System.Windows.Forms.Button();
            this.PKCheckBox = new System.Windows.Forms.CheckBox();
            this.DTypeCBox = new System.Windows.Forms.ComboBox();
            this.DTypeLbl = new System.Windows.Forms.Label();
            this.CNameTxt = new System.Windows.Forms.TextBox();
            this.CNameLbl = new System.Windows.Forms.Label();
            this.TblNameTxt = new System.Windows.Forms.TextBox();
            this.TblNameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConsTxt
            // 
            this.ConsTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConsTxt.Location = new System.Drawing.Point(143, 268);
            this.ConsTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConsTxt.Name = "ConsTxt";
            this.ConsTxt.Size = new System.Drawing.Size(123, 20);
            this.ConsTxt.TabIndex = 25;
            // 
            // ConsLbl
            // 
            this.ConsLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConsLbl.AutoSize = true;
            this.ConsLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsLbl.Location = new System.Drawing.Point(3, 268);
            this.ConsLbl.Name = "ConsLbl";
            this.ConsLbl.Size = new System.Drawing.Size(88, 19);
            this.ConsLbl.TabIndex = 24;
            this.ConsLbl.Text = "Constraints";
            // 
            // ConsCBox
            // 
            this.ConsCBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ConsCBox.FormattingEnabled = true;
            this.ConsCBox.Items.AddRange(new object[] {
            "Greater than ",
            "Smaller than",
            "Not NULL",
            "None"});
            this.ConsCBox.Location = new System.Drawing.Point(143, 201);
            this.ConsCBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ConsCBox.Name = "ConsCBox";
            this.ConsCBox.Size = new System.Drawing.Size(123, 21);
            this.ConsCBox.TabIndex = 23;
            // 
            // TConsLbl
            // 
            this.TConsLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TConsLbl.AutoSize = true;
            this.TConsLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TConsLbl.Location = new System.Drawing.Point(3, 201);
            this.TConsLbl.Name = "TConsLbl";
            this.TConsLbl.Size = new System.Drawing.Size(128, 19);
            this.TConsLbl.TabIndex = 22;
            this.TConsLbl.Text = "Type Constraints";
            // 
            // AddColBtn
            // 
            this.AddColBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddColBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(219)))), ((int)(((byte)(213)))));
            this.AddColBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddColBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddColBtn.Location = new System.Drawing.Point(143, 373);
            this.AddColBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddColBtn.Name = "AddColBtn";
            this.AddColBtn.Size = new System.Drawing.Size(83, 32);
            this.AddColBtn.TabIndex = 21;
            this.AddColBtn.Text = "Add";
            this.AddColBtn.UseVisualStyleBackColor = false;
            this.AddColBtn.Click += new System.EventHandler(this.AddColBtn_Click);
            // 
            // PKCheckBox
            // 
            this.PKCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PKCheckBox.AutoSize = true;
            this.PKCheckBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PKCheckBox.Location = new System.Drawing.Point(7, 318);
            this.PKCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PKCheckBox.Name = "PKCheckBox";
            this.PKCheckBox.Size = new System.Drawing.Size(113, 23);
            this.PKCheckBox.TabIndex = 20;
            this.PKCheckBox.Text = "Primary Key";
            this.PKCheckBox.UseVisualStyleBackColor = true;
            // 
            // DTypeCBox
            // 
            this.DTypeCBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DTypeCBox.FormattingEnabled = true;
            this.DTypeCBox.Items.AddRange(new object[] {
            "Int64",
            "Decimal",
            "Char",
            "String",
            "Boolean",
            "DateTime"});
            this.DTypeCBox.Location = new System.Drawing.Point(143, 132);
            this.DTypeCBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTypeCBox.Name = "DTypeCBox";
            this.DTypeCBox.Size = new System.Drawing.Size(123, 21);
            this.DTypeCBox.TabIndex = 19;
            // 
            // DTypeLbl
            // 
            this.DTypeLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DTypeLbl.AutoSize = true;
            this.DTypeLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTypeLbl.Location = new System.Drawing.Point(3, 132);
            this.DTypeLbl.Name = "DTypeLbl";
            this.DTypeLbl.Size = new System.Drawing.Size(81, 19);
            this.DTypeLbl.TabIndex = 18;
            this.DTypeLbl.Text = "Data Type";
            // 
            // CNameTxt
            // 
            this.CNameTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CNameTxt.Location = new System.Drawing.Point(143, 70);
            this.CNameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CNameTxt.Name = "CNameTxt";
            this.CNameTxt.Size = new System.Drawing.Size(123, 20);
            this.CNameTxt.TabIndex = 17;
            // 
            // CNameLbl
            // 
            this.CNameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CNameLbl.AutoSize = true;
            this.CNameLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNameLbl.Location = new System.Drawing.Point(3, 70);
            this.CNameLbl.Name = "CNameLbl";
            this.CNameLbl.Size = new System.Drawing.Size(110, 19);
            this.CNameLbl.TabIndex = 16;
            this.CNameLbl.Text = "Column Name";
            // 
            // TblNameTxt
            // 
            this.TblNameTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TblNameTxt.Location = new System.Drawing.Point(143, 10);
            this.TblNameTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TblNameTxt.Name = "TblNameTxt";
            this.TblNameTxt.Size = new System.Drawing.Size(123, 20);
            this.TblNameTxt.TabIndex = 15;
            // 
            // TblNameLbl
            // 
            this.TblNameLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TblNameLbl.AutoSize = true;
            this.TblNameLbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TblNameLbl.Location = new System.Drawing.Point(3, 10);
            this.TblNameLbl.Name = "TblNameLbl";
            this.TblNameLbl.Size = new System.Drawing.Size(94, 19);
            this.TblNameLbl.TabIndex = 14;
            this.TblNameLbl.Text = "Table Name";
            // 
            // AddTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(141)))), ((int)(((byte)(158)))));
            this.Controls.Add(this.ConsTxt);
            this.Controls.Add(this.ConsLbl);
            this.Controls.Add(this.ConsCBox);
            this.Controls.Add(this.TConsLbl);
            this.Controls.Add(this.AddColBtn);
            this.Controls.Add(this.PKCheckBox);
            this.Controls.Add(this.DTypeCBox);
            this.Controls.Add(this.DTypeLbl);
            this.Controls.Add(this.CNameTxt);
            this.Controls.Add(this.CNameLbl);
            this.Controls.Add(this.TblNameTxt);
            this.Controls.Add(this.TblNameLbl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddTable";
            this.Size = new System.Drawing.Size(280, 422);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ConsTxt;
        private System.Windows.Forms.Label ConsLbl;
        private System.Windows.Forms.ComboBox ConsCBox;
        private System.Windows.Forms.Label TConsLbl;
        private System.Windows.Forms.Button AddColBtn;
        public System.Windows.Forms.CheckBox PKCheckBox;
        private System.Windows.Forms.ComboBox DTypeCBox;
        private System.Windows.Forms.Label DTypeLbl;
        private System.Windows.Forms.TextBox CNameTxt;
        private System.Windows.Forms.Label CNameLbl;
        public System.Windows.Forms.TextBox TblNameTxt;
        public System.Windows.Forms.Label TblNameLbl;
    }
}
