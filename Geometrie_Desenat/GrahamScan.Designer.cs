
namespace Geometrie_Desenat
{
    partial class GrahamScan
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textNumarPuncte = new System.Windows.Forms.TextBox();
            this.drawPoints = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1264, 681);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textNumarPuncte
            // 
            this.textNumarPuncte.Location = new System.Drawing.Point(1081, 44);
            this.textNumarPuncte.Name = "textNumarPuncte";
            this.textNumarPuncte.Size = new System.Drawing.Size(100, 22);
            this.textNumarPuncte.TabIndex = 1;
            // 
            // drawPoints
            // 
            this.drawPoints.Location = new System.Drawing.Point(1081, 87);
            this.drawPoints.Name = "drawPoints";
            this.drawPoints.Size = new System.Drawing.Size(100, 36);
            this.drawPoints.TabIndex = 2;
            this.drawPoints.Text = "Draw";
            this.drawPoints.UseVisualStyleBackColor = true;
            this.drawPoints.Click += new System.EventHandler(this.drawPoints_Click);
            // 
            // GrahamScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.drawPoints);
            this.Controls.Add(this.textNumarPuncte);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GrahamScan";
            this.Text = "GrahamScan";
            this.Load += new System.EventHandler(this.GrahamScan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textNumarPuncte;
        private System.Windows.Forms.Button drawPoints;
    }
}