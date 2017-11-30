namespace prmaker
{
    partial class FrmTourneys
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
            this.dgvTourneys = new System.Windows.Forms.DataGridView();
            this.btnEliminateTourney = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnNewTournament = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.id_tourney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tourney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TourneyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumOfPlayers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourneys)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTourneys
            // 
            this.dgvTourneys.AllowUserToOrderColumns = true;
            this.dgvTourneys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTourneys.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_tourney,
            this.Tourney,
            this.Rating,
            this.TourneyDate,
            this.NumOfPlayers});
            this.dgvTourneys.Location = new System.Drawing.Point(139, 62);
            this.dgvTourneys.Name = "dgvTourneys";
            this.dgvTourneys.Size = new System.Drawing.Size(357, 150);
            this.dgvTourneys.TabIndex = 21;
            // 
            // btnEliminateTourney
            // 
            this.btnEliminateTourney.Location = new System.Drawing.Point(12, 134);
            this.btnEliminateTourney.Name = "btnEliminateTourney";
            this.btnEliminateTourney.Size = new System.Drawing.Size(95, 22);
            this.btnEliminateTourney.TabIndex = 19;
            this.btnEliminateTourney.Text = "Eliminar Torneo";
            this.btnEliminateTourney.UseVisualStyleBackColor = true;
            this.btnEliminateTourney.Click += new System.EventHandler(this.btnEliminateTourney_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(12, 106);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 22);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnNewTournament
            // 
            this.btnNewTournament.Location = new System.Drawing.Point(12, 78);
            this.btnNewTournament.Name = "btnNewTournament";
            this.btnNewTournament.Size = new System.Drawing.Size(95, 22);
            this.btnNewTournament.TabIndex = 17;
            this.btnNewTournament.Text = "Nuevo Torneo";
            this.btnNewTournament.UseVisualStyleBackColor = true;
            this.btnNewTournament.Click += new System.EventHandler(this.btnNewTournament_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(401, 232);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 22);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(198, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(91, 25);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "Torneos";
            // 
            // id_tourney
            // 
            this.id_tourney.HeaderText = "id_tourney";
            this.id_tourney.Name = "id_tourney";
            this.id_tourney.ReadOnly = true;
            this.id_tourney.Visible = false;
            // 
            // Tourney
            // 
            this.Tourney.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Tourney.HeaderText = "Torneo";
            this.Tourney.Name = "Tourney";
            this.Tourney.ReadOnly = true;
            this.Tourney.Width = 66;
            // 
            // Rating
            // 
            this.Rating.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Rating.HeaderText = "KValue";
            this.Rating.Name = "Rating";
            this.Rating.ReadOnly = true;
            this.Rating.Width = 66;
            // 
            // TourneyDate
            // 
            this.TourneyDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TourneyDate.HeaderText = "Fecha";
            this.TourneyDate.Name = "TourneyDate";
            this.TourneyDate.ReadOnly = true;
            this.TourneyDate.Width = 62;
            // 
            // NumOfPlayers
            // 
            this.NumOfPlayers.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NumOfPlayers.HeaderText = "No. Jugadores";
            this.NumOfPlayers.Name = "NumOfPlayers";
            this.NumOfPlayers.ReadOnly = true;
            this.NumOfPlayers.Width = 101;
            // 
            // FrmTourneys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 266);
            this.Controls.Add(this.dgvTourneys);
            this.Controls.Add(this.btnEliminateTourney);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnNewTournament);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmTourneys";
            this.Text = "Tournaments";
            this.Load += new System.EventHandler(this.FrmTourneys_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourneys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTourneys;
        private System.Windows.Forms.Button btnEliminateTourney;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnNewTournament;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_tourney;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tourney;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn TourneyDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumOfPlayers;
    }
}