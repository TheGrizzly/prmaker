namespace prmaker
{
    partial class FrmRanking
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
            this.MSRanking = new System.Windows.Forms.MenuStrip();
            this.rankingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarRankingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRanking = new System.Windows.Forms.Label();
            this.btnJugadores = new System.Windows.Forms.Button();
            this.lblTextoNum = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.btnPersonajes = new System.Windows.Forms.Button();
            this.btnTorneo = new System.Windows.Forms.Button();
            this.btnPr = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.MSRanking.SuspendLayout();
            this.SuspendLayout();
            // 
            // MSRanking
            // 
            this.MSRanking.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rankingToolStripMenuItem});
            this.MSRanking.Location = new System.Drawing.Point(0, 0);
            this.MSRanking.Name = "MSRanking";
            this.MSRanking.Size = new System.Drawing.Size(383, 24);
            this.MSRanking.TabIndex = 0;
            this.MSRanking.Text = "menuStrip1";
            // 
            // rankingToolStripMenuItem
            // 
            this.rankingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarNombreToolStripMenuItem,
            this.eliminarRankingToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.rankingToolStripMenuItem.Name = "rankingToolStripMenuItem";
            this.rankingToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.rankingToolStripMenuItem.Text = "Ranking";
            // 
            // cambiarNombreToolStripMenuItem
            // 
            this.cambiarNombreToolStripMenuItem.Name = "cambiarNombreToolStripMenuItem";
            this.cambiarNombreToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.cambiarNombreToolStripMenuItem.Text = "Cambiar Nombre";
            this.cambiarNombreToolStripMenuItem.Click += new System.EventHandler(this.cambiarNombreToolStripMenuItem_Click);
            // 
            // eliminarRankingToolStripMenuItem
            // 
            this.eliminarRankingToolStripMenuItem.Name = "eliminarRankingToolStripMenuItem";
            this.eliminarRankingToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.eliminarRankingToolStripMenuItem.Text = "Eliminar Ranking";
            this.eliminarRankingToolStripMenuItem.Click += new System.EventHandler(this.eliminarRankingToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // lblRanking
            // 
            this.lblRanking.AutoSize = true;
            this.lblRanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRanking.Location = new System.Drawing.Point(61, 38);
            this.lblRanking.Name = "lblRanking";
            this.lblRanking.Size = new System.Drawing.Size(91, 25);
            this.lblRanking.TabIndex = 1;
            this.lblRanking.Text = "Ranking";
            // 
            // btnJugadores
            // 
            this.btnJugadores.Location = new System.Drawing.Point(33, 88);
            this.btnJugadores.Name = "btnJugadores";
            this.btnJugadores.Size = new System.Drawing.Size(95, 22);
            this.btnJugadores.TabIndex = 2;
            this.btnJugadores.Text = "Jugadores";
            this.btnJugadores.UseVisualStyleBackColor = true;
            // 
            // lblTextoNum
            // 
            this.lblTextoNum.AutoSize = true;
            this.lblTextoNum.Location = new System.Drawing.Point(204, 47);
            this.lblTextoNum.Name = "lblTextoNum";
            this.lblTextoNum.Size = new System.Drawing.Size(117, 13);
            this.lblTextoNum.TabIndex = 3;
            this.lblTextoNum.Text = "Numero de Jugadores -";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(327, 47);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(13, 13);
            this.lblNum.TabIndex = 4;
            this.lblNum.Text = "0";
            // 
            // btnPersonajes
            // 
            this.btnPersonajes.Location = new System.Drawing.Point(33, 116);
            this.btnPersonajes.Name = "btnPersonajes";
            this.btnPersonajes.Size = new System.Drawing.Size(95, 22);
            this.btnPersonajes.TabIndex = 5;
            this.btnPersonajes.Text = "Personajes";
            this.btnPersonajes.UseVisualStyleBackColor = true;
            // 
            // btnTorneo
            // 
            this.btnTorneo.Location = new System.Drawing.Point(33, 144);
            this.btnTorneo.Name = "btnTorneo";
            this.btnTorneo.Size = new System.Drawing.Size(95, 22);
            this.btnTorneo.TabIndex = 6;
            this.btnTorneo.Text = "Torneos";
            this.btnTorneo.UseVisualStyleBackColor = true;
            // 
            // btnPr
            // 
            this.btnPr.Location = new System.Drawing.Point(33, 172);
            this.btnPr.Name = "btnPr";
            this.btnPr.Size = new System.Drawing.Size(95, 22);
            this.btnPr.TabIndex = 7;
            this.btnPr.Text = "Power Ranking";
            this.btnPr.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(276, 210);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 22);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmRanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 244);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnPr);
            this.Controls.Add(this.btnTorneo);
            this.Controls.Add(this.btnPersonajes);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblTextoNum);
            this.Controls.Add(this.btnJugadores);
            this.Controls.Add(this.lblRanking);
            this.Controls.Add(this.MSRanking);
            this.MainMenuStrip = this.MSRanking;
            this.Name = "FrmRanking";
            this.Text = "FrmRanking";
            this.Load += new System.EventHandler(this.FrmRanking_Load);
            this.MSRanking.ResumeLayout(false);
            this.MSRanking.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MSRanking;
        private System.Windows.Forms.ToolStripMenuItem rankingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarRankingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label lblRanking;
        private System.Windows.Forms.Button btnJugadores;
        private System.Windows.Forms.Label lblTextoNum;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Button btnPersonajes;
        private System.Windows.Forms.Button btnTorneo;
        private System.Windows.Forms.Button btnPr;
        private System.Windows.Forms.Button btnSalir;
    }
}