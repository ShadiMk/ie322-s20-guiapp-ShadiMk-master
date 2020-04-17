namespace FORM1
{
    partial class FrmCheck
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
            this.BtnShow = new System.Windows.Forms.Button();
            this.ChkCoff = new System.Windows.Forms.CheckBox();
            this.ChkBro = new System.Windows.Forms.CheckBox();
            this.ChkDou = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnShow
            // 
            this.BtnShow.Location = new System.Drawing.Point(95, 63);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(75, 23);
            this.BtnShow.TabIndex = 0;
            this.BtnShow.Text = "Show";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // ChkCoff
            // 
            this.ChkCoff.AutoSize = true;
            this.ChkCoff.Location = new System.Drawing.Point(95, 112);
            this.ChkCoff.Name = "ChkCoff";
            this.ChkCoff.Size = new System.Drawing.Size(59, 17);
            this.ChkCoff.TabIndex = 1;
            this.ChkCoff.Text = "Coffee";
            this.ChkCoff.UseVisualStyleBackColor = true;
            this.ChkCoff.CheckedChanged += new System.EventHandler(this.ChkCoff_CheckedChanged);
            // 
            // ChkBro
            // 
            this.ChkBro.AutoSize = true;
            this.ChkBro.Location = new System.Drawing.Point(95, 158);
            this.ChkBro.Name = "ChkBro";
            this.ChkBro.Size = new System.Drawing.Size(64, 17);
            this.ChkBro.TabIndex = 2;
            this.ChkBro.Text = "Brownie";
            this.ChkBro.UseVisualStyleBackColor = true;
            this.ChkBro.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // ChkDou
            // 
            this.ChkDou.AutoSize = true;
            this.ChkDou.Location = new System.Drawing.Point(95, 135);
            this.ChkDou.Name = "ChkDou";
            this.ChkDou.Size = new System.Drawing.Size(55, 17);
            this.ChkDou.TabIndex = 3;
            this.ChkDou.Text = "Dount";
            this.ChkDou.UseVisualStyleBackColor = true;
            this.ChkDou.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // FrmCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ChkDou);
            this.Controls.Add(this.ChkBro);
            this.Controls.Add(this.ChkCoff);
            this.Controls.Add(this.BtnShow);
            this.Name = "FrmCheck";
            this.Text = "Frm2";
            this.Load += new System.EventHandler(this.FrmCheck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.CheckBox ChkCoff;
        private System.Windows.Forms.CheckBox ChkBro;
        private System.Windows.Forms.CheckBox ChkDou;
    }
}