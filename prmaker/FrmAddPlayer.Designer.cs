namespace prmaker
{
    partial class FrmAddPlayer
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
            this.lblTagText = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboChars = new System.Windows.Forms.ComboBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(117, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(158, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Nuevo Jugador";
            // 
            // lblTagText
            // 
            this.lblTagText.AutoSize = true;
            this.lblTagText.Location = new System.Drawing.Point(87, 61);
            this.lblTagText.Name = "lblTagText";
            this.lblTagText.Size = new System.Drawing.Size(29, 13);
            this.lblTagText.TabIndex = 2;
            this.lblTagText.Text = "Tag:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(277, 201);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 22);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(122, 58);
            this.txtTag.MaxLength = 30;
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(153, 20);
            this.txtTag.TabIndex = 12;
            this.txtTag.TextChanged += new System.EventHandler(this.txtTag_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Main:";
            // 
            // cboChars
            // 
            this.cboChars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChars.FormattingEnabled = true;
            this.cboChars.Location = new System.Drawing.Point(122, 95);
            this.cboChars.Name = "cboChars";
            this.cboChars.Size = new System.Drawing.Size(153, 21);
            this.cboChars.TabIndex = 14;
            // 
            // btnNew
            // 
            this.btnNew.Enabled = false;
            this.btnNew.Location = new System.Drawing.Point(144, 143);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(95, 22);
            this.btnNew.TabIndex = 15;
            this.btnNew.Text = "Añadir Jugador";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // FrmAddPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 235);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.cboChars);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTag);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblTagText);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmAddPlayer";
            this.Text = "Añadir Jugador";
            this.Load += new System.EventHandler(this.FrmAddPlayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTagText;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboChars;
        private System.Windows.Forms.Button btnNew;
    }
}