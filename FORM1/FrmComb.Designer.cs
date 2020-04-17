namespace FORM1
{
    partial class FrmComb
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
            this.BtnSSM1 = new System.Windows.Forms.Button();
            this.BtnSSM2 = new System.Windows.Forms.Button();
            this.BtnR1I = new System.Windows.Forms.Button();
            this.BtnR2I = new System.Windows.Forms.Button();
            this.Cmbdays = new System.Windows.Forms.ComboBox();
            this.BtnRBName = new System.Windows.Forms.Button();
            this.BtnRBIndex = new System.Windows.Forms.Button();
            this.BtnBack1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSSM1
            // 
            this.BtnSSM1.Location = new System.Drawing.Point(74, 57);
            this.BtnSSM1.Name = "BtnSSM1";
            this.BtnSSM1.Size = new System.Drawing.Size(166, 23);
            this.BtnSSM1.TabIndex = 0;
            this.BtnSSM1.Text = "Show Selected Method1";
            this.BtnSSM1.UseVisualStyleBackColor = true;
            this.BtnSSM1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnSSM2
            // 
            this.BtnSSM2.Location = new System.Drawing.Point(74, 86);
            this.BtnSSM2.Name = "BtnSSM2";
            this.BtnSSM2.Size = new System.Drawing.Size(166, 23);
            this.BtnSSM2.TabIndex = 1;
            this.BtnSSM2.Text = "Show Selected Method2";
            this.BtnSSM2.UseVisualStyleBackColor = true;
            // 
            // BtnR1I
            // 
            this.BtnR1I.Location = new System.Drawing.Point(293, 58);
            this.BtnR1I.Name = "BtnR1I";
            this.BtnR1I.Size = new System.Drawing.Size(141, 51);
            this.BtnR1I.TabIndex = 2;
            this.BtnR1I.Text = "Remove last Item";
            this.BtnR1I.UseVisualStyleBackColor = true;
            this.BtnR1I.Click += new System.EventHandler(this.BtnR1I_Click);
            // 
            // BtnR2I
            // 
            this.BtnR2I.Location = new System.Drawing.Point(293, 115);
            this.BtnR2I.Name = "BtnR2I";
            this.BtnR2I.Size = new System.Drawing.Size(141, 50);
            this.BtnR2I.TabIndex = 3;
            this.BtnR2I.Text = "Remove 2nd Item";
            this.BtnR2I.UseVisualStyleBackColor = true;
            // 
            // Cmbdays
            // 
            this.Cmbdays.FormattingEnabled = true;
            this.Cmbdays.Location = new System.Drawing.Point(90, 115);
            this.Cmbdays.Name = "Cmbdays";
            this.Cmbdays.Size = new System.Drawing.Size(121, 21);
            this.Cmbdays.TabIndex = 4;
            this.Cmbdays.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BtnRBName
            // 
            this.BtnRBName.Location = new System.Drawing.Point(74, 262);
            this.BtnRBName.Name = "BtnRBName";
            this.BtnRBName.Size = new System.Drawing.Size(120, 23);
            this.BtnRBName.TabIndex = 6;
            this.BtnRBName.Text = "Remove By Name";
            this.BtnRBName.UseVisualStyleBackColor = true;
            // 
            // BtnRBIndex
            // 
            this.BtnRBIndex.Location = new System.Drawing.Point(74, 220);
            this.BtnRBIndex.Name = "BtnRBIndex";
            this.BtnRBIndex.Size = new System.Drawing.Size(120, 23);
            this.BtnRBIndex.TabIndex = 5;
            this.BtnRBIndex.Text = "Remove By Index";
            this.BtnRBIndex.UseVisualStyleBackColor = true;
            // 
            // BtnBack1
            // 
            this.BtnBack1.Location = new System.Drawing.Point(293, 243);
            this.BtnBack1.Name = "BtnBack1";
            this.BtnBack1.Size = new System.Drawing.Size(75, 23);
            this.BtnBack1.TabIndex = 7;
            this.BtnBack1.Text = "Back";
            this.BtnBack1.UseVisualStyleBackColor = true;
            // 
            // FrmComb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBack1);
            this.Controls.Add(this.BtnRBName);
            this.Controls.Add(this.BtnRBIndex);
            this.Controls.Add(this.Cmbdays);
            this.Controls.Add(this.BtnR2I);
            this.Controls.Add(this.BtnR1I);
            this.Controls.Add(this.BtnSSM2);
            this.Controls.Add(this.BtnSSM1);
            this.Name = "FrmComb";
            this.Text = "FrmComb";
            this.Load += new System.EventHandler(this.FrmComb_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSSM1;
        private System.Windows.Forms.Button BtnSSM2;
        private System.Windows.Forms.Button BtnR1I;
        private System.Windows.Forms.Button BtnR2I;
        private System.Windows.Forms.ComboBox Cmbdays;
        private System.Windows.Forms.Button BtnRBName;
        private System.Windows.Forms.Button BtnRBIndex;
        private System.Windows.Forms.Button BtnBack1;
    }
}