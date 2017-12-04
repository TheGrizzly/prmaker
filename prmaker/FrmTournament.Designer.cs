namespace prmaker
{
    partial class FrmTournament
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
            this.btnEditTourney = new System.Windows.Forms.Button();
            this.btnBuscarMatch = new System.Windows.Forms.Button();
            this.btnNewSet = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDateTourney = new System.Windows.Forms.Label();
            this.lblDateText = new System.Windows.Forms.Label();
            this.lblNumPlayers = new System.Windows.Forms.Label();
            this.lblNoPlayerText = new System.Windows.Forms.Label();
            this.lblNumMatches = new System.Windows.Forms.Label();
            this.lblMatchesText = new System.Windows.Forms.Label();
            this.lblKText = new System.Windows.Forms.Label();
            this.lblKvalue = new System.Windows.Forms.Label();
            this.btnElimT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEditTourney
            // 
            this.btnEditTourney.Location = new System.Drawing.Point(12, 119);
            this.btnEditTourney.Name = "btnEditTourney";
            this.btnEditTourney.Size = new System.Drawing.Size(95, 22);
            this.btnEditTourney.TabIndex = 22;
            this.btnEditTourney.Text = "Editar Torneo";
            this.btnEditTourney.UseVisualStyleBackColor = true;
            this.btnEditTourney.Click += new System.EventHandler(this.btnEditTourney_Click);
            // 
            // btnBuscarMatch
            // 
            this.btnBuscarMatch.Location = new System.Drawing.Point(12, 91);
            this.btnBuscarMatch.Name = "btnBuscarMatch";
            this.btnBuscarMatch.Size = new System.Drawing.Size(95, 22);
            this.btnBuscarMatch.TabIndex = 21;
            this.btnBuscarMatch.Text = "Buscar Match";
            this.btnBuscarMatch.UseVisualStyleBackColor = true;
            this.btnBuscarMatch.Click += new System.EventHandler(this.btnBuscarMatch_Click);
            // 
            // btnNewSet
            // 
            this.btnNewSet.Location = new System.Drawing.Point(12, 63);
            this.btnNewSet.Name = "btnNewSet";
            this.btnNewSet.Size = new System.Drawing.Size(95, 22);
            this.btnNewSet.TabIndex = 20;
            this.btnNewSet.Text = "Nuevo Match";
            this.btnNewSet.UseVisualStyleBackColor = true;
            this.btnNewSet.Click += new System.EventHandler(this.btnNewSet_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(294, 173);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 22);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(125, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(148, 25);
            this.lblTitle.TabIndex = 24;
            this.lblTitle.Text = "Nuevo Torneo";
            // 
            // lblDateTourney
            // 
            this.lblDateTourney.AutoSize = true;
            this.lblDateTourney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTourney.Location = new System.Drawing.Point(229, 98);
            this.lblDateTourney.Name = "lblDateTourney";
            this.lblDateTourney.Size = new System.Drawing.Size(16, 16);
            this.lblDateTourney.TabIndex = 30;
            this.lblDateTourney.Text = "0";
            // 
            // lblDateText
            // 
            this.lblDateText.AutoSize = true;
            this.lblDateText.Location = new System.Drawing.Point(144, 100);
            this.lblDateText.Name = "lblDateText";
            this.lblDateText.Size = new System.Drawing.Size(40, 13);
            this.lblDateText.TabIndex = 29;
            this.lblDateText.Text = "Fecha:";
            // 
            // lblNumPlayers
            // 
            this.lblNumPlayers.AutoSize = true;
            this.lblNumPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPlayers.Location = new System.Drawing.Point(229, 48);
            this.lblNumPlayers.Name = "lblNumPlayers";
            this.lblNumPlayers.Size = new System.Drawing.Size(41, 16);
            this.lblNumPlayers.TabIndex = 28;
            this.lblNumPlayers.Text = "X000";
            // 
            // lblNoPlayerText
            // 
            this.lblNoPlayerText.AutoSize = true;
            this.lblNoPlayerText.Location = new System.Drawing.Point(144, 50);
            this.lblNoPlayerText.Name = "lblNoPlayerText";
            this.lblNoPlayerText.Size = new System.Drawing.Size(79, 13);
            this.lblNoPlayerText.TabIndex = 27;
            this.lblNoPlayerText.Text = "No. Jugadores:";
            // 
            // lblNumMatches
            // 
            this.lblNumMatches.AutoSize = true;
            this.lblNumMatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumMatches.Location = new System.Drawing.Point(229, 70);
            this.lblNumMatches.Name = "lblNumMatches";
            this.lblNumMatches.Size = new System.Drawing.Size(75, 16);
            this.lblNumMatches.TabIndex = 26;
            this.lblNumMatches.Text = "Character";
            // 
            // lblMatchesText
            // 
            this.lblMatchesText.AutoSize = true;
            this.lblMatchesText.Location = new System.Drawing.Point(144, 76);
            this.lblMatchesText.Name = "lblMatchesText";
            this.lblMatchesText.Size = new System.Drawing.Size(71, 13);
            this.lblMatchesText.TabIndex = 25;
            this.lblMatchesText.Text = "No. Matches:";
            // 
            // lblKText
            // 
            this.lblKText.AutoSize = true;
            this.lblKText.Location = new System.Drawing.Point(144, 122);
            this.lblKText.Name = "lblKText";
            this.lblKText.Size = new System.Drawing.Size(43, 13);
            this.lblKText.TabIndex = 31;
            this.lblKText.Text = "Kvalue:";
            // 
            // lblKvalue
            // 
            this.lblKvalue.AutoSize = true;
            this.lblKvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKvalue.Location = new System.Drawing.Point(229, 120);
            this.lblKvalue.Name = "lblKvalue";
            this.lblKvalue.Size = new System.Drawing.Size(16, 16);
            this.lblKvalue.TabIndex = 32;
            this.lblKvalue.Text = "0";
            // 
            // btnElimT
            // 
            this.btnElimT.Location = new System.Drawing.Point(12, 147);
            this.btnElimT.Name = "btnElimT";
            this.btnElimT.Size = new System.Drawing.Size(95, 22);
            this.btnElimT.TabIndex = 33;
            this.btnElimT.Text = "Eliminar Torneo";
            this.btnElimT.UseVisualStyleBackColor = true;
            this.btnElimT.Click += new System.EventHandler(this.btnElimT_Click);
            // 
            // FrmTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 207);
            this.Controls.Add(this.btnElimT);
            this.Controls.Add(this.lblKvalue);
            this.Controls.Add(this.lblKText);
            this.Controls.Add(this.lblDateTourney);
            this.Controls.Add(this.lblDateText);
            this.Controls.Add(this.lblNumPlayers);
            this.Controls.Add(this.lblNoPlayerText);
            this.Controls.Add(this.lblNumMatches);
            this.Controls.Add(this.lblMatchesText);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEditTourney);
            this.Controls.Add(this.btnBuscarMatch);
            this.Controls.Add(this.btnNewSet);
            this.Name = "FrmTournament";
            this.Text = "FrmTournament";
            this.Load += new System.EventHandler(this.FrmTournament_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditTourney;
        private System.Windows.Forms.Button btnBuscarMatch;
        private System.Windows.Forms.Button btnNewSet;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDateTourney;
        private System.Windows.Forms.Label lblDateText;
        private System.Windows.Forms.Label lblNumPlayers;
        private System.Windows.Forms.Label lblNoPlayerText;
        private System.Windows.Forms.Label lblNumMatches;
        private System.Windows.Forms.Label lblMatchesText;
        private System.Windows.Forms.Label lblKText;
        private System.Windows.Forms.Label lblKvalue;
        private System.Windows.Forms.Button btnElimT;
    }
}