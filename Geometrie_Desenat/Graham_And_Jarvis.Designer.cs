
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
            this.button1 = new System.Windows.Forms.Button();
            this.generateRandom = new System.Windows.Forms.Button();
            this.textPuncteManual = new System.Windows.Forms.TextBox();
            this.addPoint = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
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
            this.textNumarPuncte.Location = new System.Drawing.Point(1000, 44);
            this.textNumarPuncte.Name = "textNumarPuncte";
            this.textNumarPuncte.Size = new System.Drawing.Size(181, 22);
            this.textNumarPuncte.TabIndex = 1;
            // 
            // drawJarvis
            // 
            this.drawJarvis.Location = new System.Drawing.Point(1081, 574);
            this.drawJarvis.Name = "drawJarvis";
            this.drawJarvis.Size = new System.Drawing.Size(100, 36);
            this.drawJarvis.TabIndex = 3;
            this.drawJarvis.Text = "Jarvis";
            this.drawJarvis.UseVisualStyleBackColor = true;
            this.drawJarvis.Click += new System.EventHandler(this.drawJarvis_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1081, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Graham";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // generateRandom
            // 
            this.generateRandom.Location = new System.Drawing.Point(1000, 72);
            this.generateRandom.Name = "generateRandom";
            this.generateRandom.Size = new System.Drawing.Size(181, 32);
            this.generateRandom.TabIndex = 8;
            this.generateRandom.Text = "Generate Random";
            this.generateRandom.UseVisualStyleBackColor = true;
            this.generateRandom.Click += new System.EventHandler(this.generateRandom_Click);
            // 
            // textPuncteManual
            // 
            this.textPuncteManual.Location = new System.Drawing.Point(1000, 138);
            this.textPuncteManual.Name = "textPuncteManual";
            this.textPuncteManual.Size = new System.Drawing.Size(181, 22);
            this.textPuncteManual.TabIndex = 9;
            // 
            // addPoint
            // 
            this.addPoint.Location = new System.Drawing.Point(1000, 166);
            this.addPoint.Name = "addPoint";
            this.addPoint.Size = new System.Drawing.Size(181, 32);
            this.addPoint.TabIndex = 10;
            this.addPoint.Text = "Add Point";
            this.addPoint.UseVisualStyleBackColor = true;
            this.addPoint.Click += new System.EventHandler(this.addPoint_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(1081, 220);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 36);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Graham_And_Jarvis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addPoint);
            this.Controls.Add(this.textPuncteManual);
            this.Controls.Add(this.generateRandom);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button generateRandom;
        private System.Windows.Forms.TextBox textPuncteManual;
        private System.Windows.Forms.Button addPoint;
        private System.Windows.Forms.Button clearButton;
    }
}