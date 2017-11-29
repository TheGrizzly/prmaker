namespace prmaker
{
    partial class FrmCharacters
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
            this.lblTag = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnElim = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.cboChars = new System.Windows.Forms.ComboBox();
            this.txtChar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTag.Location = new System.Drawing.Point(119, 9);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(120, 25);
            this.lblTag.TabIndex = 3;
            this.lblTag.Text = "Personajes";
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(231, 75);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(95, 22);
            this.btnEditar.TabIndex = 22;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnElim
            // 
            this.btnElim.Enabled = false;
            this.btnElim.Location = new System.Drawing.Point(231, 103);
            this.btnElim.Name = "btnElim";
            this.btnElim.Size = new System.Drawing.Size(95, 22);
            this.btnElim.TabIndex = 21;
            this.btnElim.Text = "Eliminar";
            this.btnElim.UseVisualStyleBackColor = true;
            this.btnElim.Click += new System.EventHandler(this.btnElim_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(231, 183);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 22);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(231, 47);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(95, 22);
            this.btnNuevo.TabIndex = 23;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // cboChars
            // 
            this.cboChars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChars.FormattingEnabled = true;
            this.cboChars.Location = new System.Drawing.Point(24, 75);
            this.cboChars.Name = "cboChars";
            this.cboChars.Size = new System.Drawing.Size(153, 21);
            this.cboChars.TabIndex = 24;
            this.cboChars.SelectedIndexChanged += new System.EventHandler(this.cboChars_SelectedIndexChanged);
            // 
            // txtChar
            // 
            this.txtChar.Location = new System.Drawing.Point(24, 49);
            this.txtChar.MaxLength = 30;
            this.txtChar.Name = "txtChar";
            this.txtChar.Size = new System.Drawing.Size(153, 20);
            this.txtChar.TabIndex = 25;
            // 
            // FrmCharacters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 217);
            this.Controls.Add(this.txtChar);
            this.Controls.Add(this.cboChars);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnElim);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblTag);
            this.Name = "FrmCharacters";
            this.Text = "FrmCharacters";
            this.Load += new System.EventHandler(this.FrmCharacters_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTag;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnElim;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ComboBox cboChars;
        private System.Windows.Forms.TextBox txtChar;
    }
}