namespace prmaker
{
    partial class FrmPlayers
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNewPlayer = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminatePlayer = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.dgvPlayers = new System.Windows.Forms.DataGridView();
            this.Player = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_player = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(210, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(113, 25);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Jugadores";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(393, 227);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 22);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNewPlayer
            // 
            this.btnNewPlayer.Location = new System.Drawing.Point(12, 50);
            this.btnNewPlayer.Name = "btnNewPlayer";
            this.btnNewPlayer.Size = new System.Drawing.Size(95, 22);
            this.btnNewPlayer.TabIndex = 10;
            this.btnNewPlayer.Text = "Nuevo Jugador";
            this.btnNewPlayer.UseVisualStyleBackColor = true;
            this.btnNewPlayer.Click += new System.EventHandler(this.btnNewPlayer_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(12, 78);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 22);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminatePlayer
            // 
            this.btnEliminatePlayer.Location = new System.Drawing.Point(12, 106);
            this.btnEliminatePlayer.Name = "btnEliminatePlayer";
            this.btnEliminatePlayer.Size = new System.Drawing.Size(95, 22);
            this.btnEliminatePlayer.TabIndex = 12;
            this.btnEliminatePlayer.Text = "Eliminar Jugador";
            this.btnEliminatePlayer.UseVisualStyleBackColor = true;
            this.btnEliminatePlayer.Click += new System.EventHandler(this.btnEliminatePlayer_Click);
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(12, 134);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(95, 22);
            this.btnStats.TabIndex = 13;
            this.btnStats.Text = "Player Record";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // dgvPlayers
            // 
            this.dgvPlayers.AllowUserToOrderColumns = true;
            this.dgvPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Player,
            this.Rating,
            this.id_player});
            this.dgvPlayers.Location = new System.Drawing.Point(157, 50);
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.Size = new System.Drawing.Size(249, 150);
            this.dgvPlayers.TabIndex = 14;
            // 
            // Player
            // 
            this.Player.HeaderText = "Jugador";
            this.Player.Name = "Player";
            this.Player.ReadOnly = true;
            // 
            // Rating
            // 
            this.Rating.HeaderText = "Rating";
            this.Rating.Name = "Rating";
            this.Rating.ReadOnly = true;
            // 
            // id_player
            // 
            this.id_player.HeaderText = "id_player";
            this.id_player.Name = "id_player";
            this.id_player.ReadOnly = true;
            this.id_player.Visible = false;
            // 
            // FrmPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 261);
            this.Controls.Add(this.dgvPlayers);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnEliminatePlayer);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnNewPlayer);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmPlayers";
            this.Text = "Jugadores";
            this.Load += new System.EventHandler(this.FrmPlayers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNewPlayer;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminatePlayer;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.DataGridView dgvPlayers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Player;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_player;
    }
}