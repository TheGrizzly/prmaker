namespace prmaker
{
    partial class FrmEditPlayer
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.cboChars = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblTagText = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(115, 158);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 22);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "Editar Jugador";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cboChars
            // 
            this.cboChars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChars.FormattingEnabled = true;
            this.cboChars.Location = new System.Drawing.Point(93, 110);
            this.cboChars.Name = "cboChars";
            this.cboChars.Size = new System.Drawing.Size(153, 21);
            this.cboChars.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Main:";
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(93, 73);
            this.txtTag.MaxLength = 30;
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(153, 20);
            this.txtTag.TabIndex = 19;
            this.txtTag.TextChanged += new System.EventHandler(this.txtTag_TextChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(224, 227);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 22);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblTagText
            // 
            this.lblTagText.AutoSize = true;
            this.lblTagText.Location = new System.Drawing.Point(58, 76);
            this.lblTagText.Name = "lblTagText";
            this.lblTagText.Size = new System.Drawing.Size(29, 13);
            this.lblTagText.TabIndex = 17;
            this.lblTagText.Text = "Tag:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(88, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(158, 25);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.Text = "Nuevo Jugador";
            // 
            // FrmEditPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 261);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cboChars);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTag);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblTagText);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmEditPlayer";
            this.Text = "Editar Jugador";
            this.Load += new System.EventHandler(this.FrmEditPlayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cboChars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblTagText;
        private System.Windows.Forms.Label lblTitle;
    }
}