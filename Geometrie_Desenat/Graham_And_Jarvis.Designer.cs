
namespace Geometrie_Desenat
{
    partial class Graham_And_Jarvis
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
            this.drawJarvis = new System.Windows.Forms.Button();
            this.drawGraham = new System.Windows.Forms.Button();
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
            // drawJarvis
            // 
            this.drawJarvis.Location = new System.Drawing.Point(1081, 129);
            this.drawJarvis.Name = "drawJarvis";
            this.drawJarvis.Size = new System.Drawing.Size(100, 36);
            this.drawJarvis.TabIndex = 3;
            this.drawJarvis.Text = "Draw Jarvis";
            this.drawJarvis.UseVisualStyleBackColor = true;
            this.drawJarvis.Click += new System.EventHandler(this.drawJarvis_Click);
            // 
            // drawGraham
            // 
            this.drawGraham.Location = new System.Drawing.Point(1081, 87);
            this.drawGraham.Name = "drawGraham";
            this.drawGraham.Size = new System.Drawing.Size(100, 36);
            this.drawGraham.TabIndex = 4;
            this.drawGraham.Text = "Draw Graham";
            this.drawGraham.UseVisualStyleBackColor = true;
            this.drawGraham.Click += new System.EventHandler(this.drawGraham_Click);
            // 
            // Graham_And_Jarvis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.drawGraham);
            this.Controls.Add(this.drawJarvis);
            this.Controls.Add(this.textNumarPuncte);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Graham_And_Jarvis";
            this.Text = "GrahamScan";
            this.Load += new System.EventHandler(this.GrahamScan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textNumarPuncte;
        private System.Windows.Forms.Button drawJarvis;
        private System.Windows.Forms.Button drawGraham;
    }
}