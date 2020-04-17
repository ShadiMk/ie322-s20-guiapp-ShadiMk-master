namespace FORM1
{
    partial class FrmImage
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
            this.PicTry = new System.Windows.Forms.PictureBox();
            this.BtnImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicTry)).BeginInit();
            this.SuspendLayout();
            // 
            // PicTry
            // 
            this.PicTry.Location = new System.Drawing.Point(180, 39);
            this.PicTry.Name = "PicTry";
            this.PicTry.Size = new System.Drawing.Size(608, 287);
            this.PicTry.TabIndex = 0;
            this.PicTry.TabStop = false;
            // 
            // BtnImage
            // 
            this.BtnImage.Location = new System.Drawing.Point(40, 39);
            this.BtnImage.Name = "BtnImage";
            this.BtnImage.Size = new System.Drawing.Size(134, 100);
            this.BtnImage.TabIndex = 1;
            this.BtnImage.Text = "Load Image";
            this.BtnImage.UseVisualStyleBackColor = true;
            this.BtnImage.Click += new System.EventHandler(this.BtnImage_Click);
            // 
            // FrmImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnImage);
            this.Controls.Add(this.PicTry);
            this.Name = "FrmImage";
            this.Text = "FrmImage";
            ((System.ComponentModel.ISupportInitialize)(this.PicTry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicTry;
        private System.Windows.Forms.Button BtnImage;
    }
}