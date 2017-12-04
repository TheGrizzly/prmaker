namespace prmaker
{
    partial class FrmEditTourney
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
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpTourneyDate = new System.Windows.Forms.DateTimePicker();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblKvalue = new System.Windows.Forms.Label();
            this.txtTName = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblNameText = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblKv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(54, 122);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(40, 13);
            this.lblDate.TabIndex = 34;
            this.lblDate.Text = "Fecha:";
            // 
            // dtpTourneyDate
            // 
            this.dtpTourneyDate.Location = new System.Drawing.Point(100, 116);
            this.dtpTourneyDate.Name = "dtpTourneyDate";
            this.dtpTourneyDate.Size = new System.Drawing.Size(200, 20);
            this.dtpTourneyDate.TabIndex = 33;
            this.dtpTourneyDate.ValueChanged += new System.EventHandler(this.dtpTourneyDate_ValueChanged);
            // 
            // btnNew
            // 
            this.btnNew.Enabled = false;
            this.btnNew.Location = new System.Drawing.Point(131, 167);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(95, 22);
            this.btnNew.TabIndex = 31;
            this.btnNew.Text = "Editar Torneo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblKvalue
            // 
            this.lblKvalue.AutoSize = true;
            this.lblKvalue.Location = new System.Drawing.Point(52, 92);
            this.lblKvalue.Name = "lblKvalue";
            this.lblKvalue.Size = new System.Drawing.Size(42, 13);
            this.lblKvalue.TabIndex = 30;
            this.lblKvalue.Text = "kvalue:";
            // 
            // txtTName
            // 
            this.txtTName.Location = new System.Drawing.Point(100, 64);
            this.txtTName.MaxLength = 30;
            this.txtTName.Name = "txtTName";
            this.txtTName.Size = new System.Drawing.Size(200, 20);
            this.txtTName.TabIndex = 29;
            this.txtTName.TextChanged += new System.EventHandler(this.txtTName_TextChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(255, 207);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 22);
            this.btnSalir.TabIndex = 28;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblNameText
            // 
            this.lblNameText.AutoSize = true;
            this.lblNameText.Location = new System.Drawing.Point(47, 67);
            this.lblNameText.Name = "lblNameText";
            this.lblNameText.Size = new System.Drawing.Size(47, 13);
            this.lblNameText.TabIndex = 27;
            this.lblNameText.Text = "Nombre:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(114, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(148, 25);
            this.lblTitle.TabIndex = 26;
            this.lblTitle.Text = "Nuevo Torneo";
            // 
            // lblKv
            // 
            this.lblKv.AutoSize = true;
            this.lblKv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKv.Location = new System.Drawing.Point(100, 92);
            this.lblKv.Name = "lblKv";
            this.lblKv.Size = new System.Drawing.Size(16, 16);
            this.lblKv.TabIndex = 35;
            this.lblKv.Text = "0";
            // 
            // FrmEditTourney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 241);
            this.Controls.Add(this.lblKv);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpTourneyDate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lblKvalue);
            this.Controls.Add(this.txtTName);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblNameText);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmEditTourney";
            this.Text = "FrmEditTourney";
            this.Load += new System.EventHandler(this.FrmEditTourney_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpTourneyDate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblKvalue;
        private System.Windows.Forms.TextBox txtTName;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblNameText;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblKv;
    }
}