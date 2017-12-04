namespace prmaker
{
    partial class FrmSet
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblRatingP2 = new System.Windows.Forms.Label();
            this.lblRatingText2 = new System.Windows.Forms.Label();
            this.lblMainP2 = new System.Windows.Forms.Label();
            this.lblMainText2 = new System.Windows.Forms.Label();
            this.lblRatingP1 = new System.Windows.Forms.Label();
            this.lblRatingText1 = new System.Windows.Forms.Label();
            this.lblMainP1 = new System.Windows.Forms.Label();
            this.lblMainText1 = new System.Windows.Forms.Label();
            this.nudScoreP2 = new System.Windows.Forms.NumericUpDown();
            this.nudScoreP1 = new System.Windows.Forms.NumericUpDown();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblTagP1 = new System.Windows.Forms.Label();
            this.lblTagP2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudScoreP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScoreP1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(194, 57);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 22);
            this.btnEdit.TabIndex = 34;
            this.btnEdit.Text = "Edit Match";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(379, 164);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 22);
            this.btnSalir.TabIndex = 33;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblRatingP2
            // 
            this.lblRatingP2.AutoSize = true;
            this.lblRatingP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRatingP2.Location = new System.Drawing.Point(396, 97);
            this.lblRatingP2.Name = "lblRatingP2";
            this.lblRatingP2.Size = new System.Drawing.Size(41, 16);
            this.lblRatingP2.TabIndex = 32;
            this.lblRatingP2.Text = "X000";
            this.lblRatingP2.Click += new System.EventHandler(this.lblRatingP2_Click);
            // 
            // lblRatingText2
            // 
            this.lblRatingText2.AutoSize = true;
            this.lblRatingText2.Location = new System.Drawing.Point(349, 97);
            this.lblRatingText2.Name = "lblRatingText2";
            this.lblRatingText2.Size = new System.Drawing.Size(41, 13);
            this.lblRatingText2.TabIndex = 31;
            this.lblRatingText2.Text = "Rating:";
            // 
            // lblMainP2
            // 
            this.lblMainP2.AutoSize = true;
            this.lblMainP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainP2.Location = new System.Drawing.Point(396, 123);
            this.lblMainP2.Name = "lblMainP2";
            this.lblMainP2.Size = new System.Drawing.Size(75, 16);
            this.lblMainP2.TabIndex = 30;
            this.lblMainP2.Text = "Character";
            // 
            // lblMainText2
            // 
            this.lblMainText2.AutoSize = true;
            this.lblMainText2.Location = new System.Drawing.Point(349, 125);
            this.lblMainText2.Name = "lblMainText2";
            this.lblMainText2.Size = new System.Drawing.Size(33, 13);
            this.lblMainText2.TabIndex = 29;
            this.lblMainText2.Text = "Main:";
            // 
            // lblRatingP1
            // 
            this.lblRatingP1.AutoSize = true;
            this.lblRatingP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRatingP1.Location = new System.Drawing.Point(57, 97);
            this.lblRatingP1.Name = "lblRatingP1";
            this.lblRatingP1.Size = new System.Drawing.Size(41, 16);
            this.lblRatingP1.TabIndex = 28;
            this.lblRatingP1.Text = "X000";
            // 
            // lblRatingText1
            // 
            this.lblRatingText1.AutoSize = true;
            this.lblRatingText1.Location = new System.Drawing.Point(10, 97);
            this.lblRatingText1.Name = "lblRatingText1";
            this.lblRatingText1.Size = new System.Drawing.Size(41, 13);
            this.lblRatingText1.TabIndex = 27;
            this.lblRatingText1.Text = "Rating:";
            // 
            // lblMainP1
            // 
            this.lblMainP1.AutoSize = true;
            this.lblMainP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainP1.Location = new System.Drawing.Point(57, 123);
            this.lblMainP1.Name = "lblMainP1";
            this.lblMainP1.Size = new System.Drawing.Size(75, 16);
            this.lblMainP1.TabIndex = 26;
            this.lblMainP1.Text = "Character";
            // 
            // lblMainText1
            // 
            this.lblMainText1.AutoSize = true;
            this.lblMainText1.Location = new System.Drawing.Point(10, 125);
            this.lblMainText1.Name = "lblMainText1";
            this.lblMainText1.Size = new System.Drawing.Size(33, 13);
            this.lblMainText1.TabIndex = 25;
            this.lblMainText1.Text = "Main:";
            // 
            // nudScoreP2
            // 
            this.nudScoreP2.Location = new System.Drawing.Point(311, 59);
            this.nudScoreP2.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudScoreP2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudScoreP2.Name = "nudScoreP2";
            this.nudScoreP2.Size = new System.Drawing.Size(46, 20);
            this.nudScoreP2.TabIndex = 24;
            this.nudScoreP2.ValueChanged += new System.EventHandler(this.nudScoreP2_ValueChanged);
            // 
            // nudScoreP1
            // 
            this.nudScoreP1.Location = new System.Drawing.Point(130, 60);
            this.nudScoreP1.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudScoreP1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudScoreP1.Name = "nudScoreP1";
            this.nudScoreP1.Size = new System.Drawing.Size(46, 20);
            this.nudScoreP1.TabIndex = 23;
            this.nudScoreP1.ValueChanged += new System.EventHandler(this.nudScoreP1_ValueChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(215, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(55, 25);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "Sets";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(195, 87);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 22);
            this.btnDelete.TabIndex = 35;
            this.btnDelete.Text = "Delete Match";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblTagP1
            // 
            this.lblTagP1.AutoSize = true;
            this.lblTagP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagP1.Location = new System.Drawing.Point(12, 57);
            this.lblTagP1.Name = "lblTagP1";
            this.lblTagP1.Size = new System.Drawing.Size(79, 24);
            this.lblTagP1.TabIndex = 36;
            this.lblTagP1.Text = "Player1";
            // 
            // lblTagP2
            // 
            this.lblTagP2.AutoSize = true;
            this.lblTagP2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTagP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTagP2.Location = new System.Drawing.Point(375, 57);
            this.lblTagP2.Name = "lblTagP2";
            this.lblTagP2.Size = new System.Drawing.Size(79, 24);
            this.lblTagP2.TabIndex = 37;
            this.lblTagP2.Text = "Player2";
            this.lblTagP2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FrmSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 197);
            this.Controls.Add(this.lblTagP2);
            this.Controls.Add(this.lblTagP1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblRatingP2);
            this.Controls.Add(this.lblRatingText2);
            this.Controls.Add(this.lblMainP2);
            this.Controls.Add(this.lblMainText2);
            this.Controls.Add(this.lblRatingP1);
            this.Controls.Add(this.lblRatingText1);
            this.Controls.Add(this.lblMainP1);
            this.Controls.Add(this.lblMainText1);
            this.Controls.Add(this.nudScoreP2);
            this.Controls.Add(this.nudScoreP1);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmSet";
            this.Text = "Set";
            this.Load += new System.EventHandler(this.FrmSet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudScoreP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScoreP1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblRatingP2;
        private System.Windows.Forms.Label lblRatingText2;
        private System.Windows.Forms.Label lblMainP2;
        private System.Windows.Forms.Label lblMainText2;
        private System.Windows.Forms.Label lblRatingP1;
        private System.Windows.Forms.Label lblRatingText1;
        private System.Windows.Forms.Label lblMainP1;
        private System.Windows.Forms.Label lblMainText1;
        private System.Windows.Forms.NumericUpDown nudScoreP2;
        private System.Windows.Forms.NumericUpDown nudScoreP1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblTagP1;
        private System.Windows.Forms.Label lblTagP2;
    }
}