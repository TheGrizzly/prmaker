namespace prmaker
{
    partial class FrmNewSet
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
            this.cboPlayer1 = new System.Windows.Forms.ComboBox();
            this.cboPlayer2 = new System.Windows.Forms.ComboBox();
            this.nudScoreP1 = new System.Windows.Forms.NumericUpDown();
            this.nudScoreP2 = new System.Windows.Forms.NumericUpDown();
            this.lblRatingP1 = new System.Windows.Forms.Label();
            this.lblRatingText1 = new System.Windows.Forms.Label();
            this.lblMainP1 = new System.Windows.Forms.Label();
            this.lblMainText1 = new System.Windows.Forms.Label();
            this.lblRatingP2 = new System.Windows.Forms.Label();
            this.lblRatingText2 = new System.Windows.Forms.Label();
            this.lblMainP2 = new System.Windows.Forms.Label();
            this.lblMainText2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAddMatch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudScoreP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScoreP2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(188, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(92, 25);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "New Set";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboPlayer1
            // 
            this.cboPlayer1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlayer1.FormattingEnabled = true;
            this.cboPlayer1.Location = new System.Drawing.Point(11, 58);
            this.cboPlayer1.Name = "cboPlayer1";
            this.cboPlayer1.Size = new System.Drawing.Size(111, 21);
            this.cboPlayer1.TabIndex = 4;
            this.cboPlayer1.SelectedIndexChanged += new System.EventHandler(this.cboPlayer1_SelectedIndexChanged);
            // 
            // cboPlayer2
            // 
            this.cboPlayer2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlayer2.FormattingEnabled = true;
            this.cboPlayer2.Location = new System.Drawing.Point(361, 58);
            this.cboPlayer2.Name = "cboPlayer2";
            this.cboPlayer2.Size = new System.Drawing.Size(111, 21);
            this.cboPlayer2.TabIndex = 5;
            this.cboPlayer2.SelectedIndexChanged += new System.EventHandler(this.cboPlayer2_SelectedIndexChanged);
            // 
            // nudScoreP1
            // 
            this.nudScoreP1.Location = new System.Drawing.Point(128, 59);
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
            this.nudScoreP1.TabIndex = 6;
            this.nudScoreP1.ValueChanged += new System.EventHandler(this.nudScoreP1_ValueChanged);
            // 
            // nudScoreP2
            // 
            this.nudScoreP2.Location = new System.Drawing.Point(309, 58);
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
            this.nudScoreP2.TabIndex = 7;
            this.nudScoreP2.ValueChanged += new System.EventHandler(this.nudScoreP2_ValueChanged);
            // 
            // lblRatingP1
            // 
            this.lblRatingP1.AutoSize = true;
            this.lblRatingP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRatingP1.Location = new System.Drawing.Point(55, 96);
            this.lblRatingP1.Name = "lblRatingP1";
            this.lblRatingP1.Size = new System.Drawing.Size(41, 16);
            this.lblRatingP1.TabIndex = 11;
            this.lblRatingP1.Text = "X000";
            // 
            // lblRatingText1
            // 
            this.lblRatingText1.AutoSize = true;
            this.lblRatingText1.Location = new System.Drawing.Point(8, 96);
            this.lblRatingText1.Name = "lblRatingText1";
            this.lblRatingText1.Size = new System.Drawing.Size(41, 13);
            this.lblRatingText1.TabIndex = 10;
            this.lblRatingText1.Text = "Rating:";
            // 
            // lblMainP1
            // 
            this.lblMainP1.AutoSize = true;
            this.lblMainP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainP1.Location = new System.Drawing.Point(55, 122);
            this.lblMainP1.Name = "lblMainP1";
            this.lblMainP1.Size = new System.Drawing.Size(75, 16);
            this.lblMainP1.TabIndex = 9;
            this.lblMainP1.Text = "Character";
            // 
            // lblMainText1
            // 
            this.lblMainText1.AutoSize = true;
            this.lblMainText1.Location = new System.Drawing.Point(8, 124);
            this.lblMainText1.Name = "lblMainText1";
            this.lblMainText1.Size = new System.Drawing.Size(33, 13);
            this.lblMainText1.TabIndex = 8;
            this.lblMainText1.Text = "Main:";
            // 
            // lblRatingP2
            // 
            this.lblRatingP2.AutoSize = true;
            this.lblRatingP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRatingP2.Location = new System.Drawing.Point(394, 96);
            this.lblRatingP2.Name = "lblRatingP2";
            this.lblRatingP2.Size = new System.Drawing.Size(41, 16);
            this.lblRatingP2.TabIndex = 15;
            this.lblRatingP2.Text = "X000";
            // 
            // lblRatingText2
            // 
            this.lblRatingText2.AutoSize = true;
            this.lblRatingText2.Location = new System.Drawing.Point(347, 96);
            this.lblRatingText2.Name = "lblRatingText2";
            this.lblRatingText2.Size = new System.Drawing.Size(41, 13);
            this.lblRatingText2.TabIndex = 14;
            this.lblRatingText2.Text = "Rating:";
            // 
            // lblMainP2
            // 
            this.lblMainP2.AutoSize = true;
            this.lblMainP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainP2.Location = new System.Drawing.Point(394, 122);
            this.lblMainP2.Name = "lblMainP2";
            this.lblMainP2.Size = new System.Drawing.Size(75, 16);
            this.lblMainP2.TabIndex = 13;
            this.lblMainP2.Text = "Character";
            // 
            // lblMainText2
            // 
            this.lblMainText2.AutoSize = true;
            this.lblMainText2.Location = new System.Drawing.Point(347, 124);
            this.lblMainText2.Name = "lblMainText2";
            this.lblMainText2.Size = new System.Drawing.Size(33, 13);
            this.lblMainText2.TabIndex = 12;
            this.lblMainText2.Text = "Main:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(377, 163);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 22);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAddMatch
            // 
            this.btnAddMatch.Enabled = false;
            this.btnAddMatch.Location = new System.Drawing.Point(192, 56);
            this.btnAddMatch.Name = "btnAddMatch";
            this.btnAddMatch.Size = new System.Drawing.Size(95, 22);
            this.btnAddMatch.TabIndex = 19;
            this.btnAddMatch.Text = "Add Match";
            this.btnAddMatch.UseVisualStyleBackColor = true;
            this.btnAddMatch.Click += new System.EventHandler(this.btnAddMatch_Click);
            // 
            // FrmNewSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 197);
            this.Controls.Add(this.btnAddMatch);
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
            this.Controls.Add(this.cboPlayer2);
            this.Controls.Add(this.cboPlayer1);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmNewSet";
            this.Text = "Nuevo Set";
            this.Load += new System.EventHandler(this.FrmNewSet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudScoreP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScoreP2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cboPlayer1;
        private System.Windows.Forms.ComboBox cboPlayer2;
        private System.Windows.Forms.NumericUpDown nudScoreP1;
        private System.Windows.Forms.NumericUpDown nudScoreP2;
        private System.Windows.Forms.Label lblRatingP1;
        private System.Windows.Forms.Label lblRatingText1;
        private System.Windows.Forms.Label lblMainP1;
        private System.Windows.Forms.Label lblMainText1;
        private System.Windows.Forms.Label lblRatingP2;
        private System.Windows.Forms.Label lblRatingText2;
        private System.Windows.Forms.Label lblMainP2;
        private System.Windows.Forms.Label lblMainText2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAddMatch;
    }
}