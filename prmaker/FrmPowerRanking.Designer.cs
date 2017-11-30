namespace prmaker
{
    partial class FrmPowerRanking
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvPowerRanking = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Main = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WinRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoseRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSets = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPowerRanking)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(215, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(163, 25);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Power Ranking ";
            // 
            // dgvPowerRanking
            // 
            this.dgvPowerRanking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPowerRanking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.tag,
            this.Main,
            this.WinRate,
            this.LoseRate,
            this.Wins,
            this.Loses,
            this.TotalSets,
            this.Rating});
            this.dgvPowerRanking.Location = new System.Drawing.Point(13, 51);
            this.dgvPowerRanking.Name = "dgvPowerRanking";
            this.dgvPowerRanking.Size = new System.Drawing.Size(674, 150);
            this.dgvPowerRanking.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(592, 227);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 22);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.No.HeaderText = "No.";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 49;
            // 
            // tag
            // 
            this.tag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tag.HeaderText = "Player";
            this.tag.Name = "tag";
            this.tag.ReadOnly = true;
            this.tag.Width = 61;
            // 
            // Main
            // 
            this.Main.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Main.HeaderText = "Main";
            this.Main.Name = "Main";
            this.Main.ReadOnly = true;
            this.Main.Width = 55;
            // 
            // WinRate
            // 
            this.WinRate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.WinRate.HeaderText = "WinRate";
            this.WinRate.Name = "WinRate";
            this.WinRate.ReadOnly = true;
            this.WinRate.Width = 74;
            // 
            // LoseRate
            // 
            this.LoseRate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.LoseRate.HeaderText = "LoseRate";
            this.LoseRate.Name = "LoseRate";
            this.LoseRate.ReadOnly = true;
            this.LoseRate.Width = 78;
            // 
            // Wins
            // 
            this.Wins.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Wins.HeaderText = "Wins";
            this.Wins.Name = "Wins";
            this.Wins.ReadOnly = true;
            this.Wins.Width = 56;
            // 
            // Loses
            // 
            this.Loses.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Loses.HeaderText = "Loses";
            this.Loses.Name = "Loses";
            this.Loses.ReadOnly = true;
            this.Loses.Width = 60;
            // 
            // TotalSets
            // 
            this.TotalSets.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.TotalSets.HeaderText = "Total Sets";
            this.TotalSets.Name = "TotalSets";
            this.TotalSets.ReadOnly = true;
            this.TotalSets.Width = 80;
            // 
            // Rating
            // 
            this.Rating.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Rating.HeaderText = "Rating";
            this.Rating.Name = "Rating";
            this.Rating.ReadOnly = true;
            this.Rating.Width = 63;
            // 
            // FrmPowerRanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 261);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvPowerRanking);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmPowerRanking";
            this.Text = "Power Ranking";
            this.Load += new System.EventHandler(this.FrmPowerRanking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPowerRanking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvPowerRanking;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Main;
        private System.Windows.Forms.DataGridViewTextBoxColumn WinRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoseRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wins;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loses;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSets;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
    }
}