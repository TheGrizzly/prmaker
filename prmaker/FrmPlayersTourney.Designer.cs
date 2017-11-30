namespace prmaker
{
    partial class FrmPlayersTourney
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
            this.btnSelectPlayers = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lbPlayers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSelectPlayers
            // 
            this.btnSelectPlayers.Location = new System.Drawing.Point(104, 226);
            this.btnSelectPlayers.Name = "btnSelectPlayers";
            this.btnSelectPlayers.Size = new System.Drawing.Size(75, 23);
            this.btnSelectPlayers.TabIndex = 0;
            this.btnSelectPlayers.Text = "Añadir";
            this.btnSelectPlayers.UseVisualStyleBackColor = true;
            this.btnSelectPlayers.Click += new System.EventHandler(this.btnSelectPlayers_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(243, 50);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Elije los jugadores para \r\n  añadir a este torneo";
            // 
            // lbPlayers
            // 
            this.lbPlayers.FormattingEnabled = true;
            this.lbPlayers.Location = new System.Drawing.Point(27, 62);
            this.lbPlayers.Name = "lbPlayers";
            this.lbPlayers.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbPlayers.Size = new System.Drawing.Size(228, 147);
            this.lbPlayers.TabIndex = 18;
            // 
            // FrmPlayersTourney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbPlayers);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSelectPlayers);
            this.Name = "FrmPlayersTourney";
            this.Text = "FrmPlayersTourney";
            this.Load += new System.EventHandler(this.FrmPlayersTourney_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectPlayers;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lbPlayers;
    }
}