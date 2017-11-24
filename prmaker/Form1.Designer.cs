namespace prmaker
{
    partial class FrmMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewRank = new System.Windows.Forms.Button();
            this.cboRankngs = new System.Windows.Forms.ComboBox();
            this.btnLoadRank = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRMaker";
            // 
            // btnNewRank
            // 
            this.btnNewRank.Location = new System.Drawing.Point(82, 68);
            this.btnNewRank.Name = "btnNewRank";
            this.btnNewRank.Size = new System.Drawing.Size(109, 40);
            this.btnNewRank.TabIndex = 1;
            this.btnNewRank.Text = "New Ranking";
            this.btnNewRank.UseVisualStyleBackColor = true;
            this.btnNewRank.Click += new System.EventHandler(this.btnNewRank_Click);
            // 
            // cboRankngs
            // 
            this.cboRankngs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRankngs.FormattingEnabled = true;
            this.cboRankngs.Location = new System.Drawing.Point(82, 137);
            this.cboRankngs.Name = "cboRankngs";
            this.cboRankngs.Size = new System.Drawing.Size(111, 21);
            this.cboRankngs.TabIndex = 2;
            this.cboRankngs.SelectedIndexChanged += new System.EventHandler(this.cboRankngs_SelectedIndexChanged);
            // 
            // btnLoadRank
            // 
            this.btnLoadRank.AllowDrop = true;
            this.btnLoadRank.Enabled = false;
            this.btnLoadRank.Location = new System.Drawing.Point(82, 176);
            this.btnLoadRank.Name = "btnLoadRank";
            this.btnLoadRank.Size = new System.Drawing.Size(111, 23);
            this.btnLoadRank.TabIndex = 3;
            this.btnLoadRank.Text = "Load Ranking";
            this.btnLoadRank.UseVisualStyleBackColor = true;
            this.btnLoadRank.Click += new System.EventHandler(this.btnLoadRank_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnLoadRank);
            this.Controls.Add(this.cboRankngs);
            this.Controls.Add(this.btnNewRank);
            this.Controls.Add(this.label1);
            this.Name = "FrmMenu";
            this.Text = "PRMaker";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewRank;
        private System.Windows.Forms.ComboBox cboRankngs;
        private System.Windows.Forms.Button btnLoadRank;
    }
}

