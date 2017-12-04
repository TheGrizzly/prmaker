namespace prmaker
{
    partial class FrmSearchSet
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboSets = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(177, 182);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 22);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AllowDrop = true;
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(87, 98);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Buscar Set";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboSets
            // 
            this.cboSets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSets.FormattingEnabled = true;
            this.cboSets.Location = new System.Drawing.Point(31, 59);
            this.cboSets.Name = "cboSets";
            this.cboSets.Size = new System.Drawing.Size(220, 21);
            this.cboSets.TabIndex = 12;
            this.cboSets.SelectedIndexChanged += new System.EventHandler(this.cboSets_SelectedIndexChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(73, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(125, 25);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Select a set";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // FrmSearchSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 216);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboSets);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmSearchSet";
            this.Text = "Search Sete";
            this.Load += new System.EventHandler(this.FrmSearchSet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboSets;
        private System.Windows.Forms.Label lblTitle;
    }
}