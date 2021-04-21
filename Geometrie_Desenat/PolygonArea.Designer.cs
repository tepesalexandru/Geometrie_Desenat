
namespace Geometrie_Desenat
{
    partial class PolygonArea
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
            this.drawRandomClick = new System.Windows.Forms.Button();
            this.drawPolygon = new System.Windows.Forms.Button();
            this.calculateArea = new System.Windows.Forms.Button();
            this.areaBox = new System.Windows.Forms.ListBox();
            this.numberOfPointsInput = new System.Windows.Forms.TextBox();
            this.manualInput = new System.Windows.Forms.TextBox();
            this.addPoint = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1067, 554);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // drawRandomClick
            // 
            this.drawRandomClick.BackColor = System.Drawing.SystemColors.HotTrack;
            this.drawRandomClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawRandomClick.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.drawRandomClick.Location = new System.Drawing.Point(891, 47);
            this.drawRandomClick.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drawRandomClick.Name = "drawRandomClick";
            this.drawRandomClick.Size = new System.Drawing.Size(160, 46);
            this.drawRandomClick.TabIndex = 1;
            this.drawRandomClick.Text = "Generate Points";
            this.drawRandomClick.UseVisualStyleBackColor = false;
            this.drawRandomClick.Click += new System.EventHandler(this.drawClick_Click);
            // 
            // drawPolygon
            // 
            this.drawPolygon.BackColor = System.Drawing.SystemColors.Highlight;
            this.drawPolygon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawPolygon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.drawPolygon.Location = new System.Drawing.Point(891, 309);
            this.drawPolygon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drawPolygon.Name = "drawPolygon";
            this.drawPolygon.Size = new System.Drawing.Size(160, 48);
            this.drawPolygon.TabIndex = 2;
            this.drawPolygon.Text = "Draw Polygon";
            this.drawPolygon.UseVisualStyleBackColor = false;
            this.drawPolygon.Click += new System.EventHandler(this.drawPolygon_Click);
            // 
            // calculateArea
            // 
            this.calculateArea.BackColor = System.Drawing.SystemColors.Highlight;
            this.calculateArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateArea.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.calculateArea.Location = new System.Drawing.Point(891, 364);
            this.calculateArea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calculateArea.Name = "calculateArea";
            this.calculateArea.Size = new System.Drawing.Size(160, 50);
            this.calculateArea.TabIndex = 3;
            this.calculateArea.Text = "Calculate Area";
            this.calculateArea.UseVisualStyleBackColor = false;
            this.calculateArea.Click += new System.EventHandler(this.calculateArea_Click);
            // 
            // areaBox
            // 
            this.areaBox.FormattingEnabled = true;
            this.areaBox.ItemHeight = 16;
            this.areaBox.Location = new System.Drawing.Point(891, 422);
            this.areaBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.areaBox.Name = "areaBox";
            this.areaBox.Size = new System.Drawing.Size(159, 116);
            this.areaBox.TabIndex = 4;
            // 
            // numberOfPointsInput
            // 
            this.numberOfPointsInput.Location = new System.Drawing.Point(891, 15);
            this.numberOfPointsInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numberOfPointsInput.Name = "numberOfPointsInput";
            this.numberOfPointsInput.Size = new System.Drawing.Size(159, 22);
            this.numberOfPointsInput.TabIndex = 5;
            // 
            // manualInput
            // 
            this.manualInput.Location = new System.Drawing.Point(891, 111);
            this.manualInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.manualInput.Name = "manualInput";
            this.manualInput.Size = new System.Drawing.Size(159, 22);
            this.manualInput.TabIndex = 6;
            this.manualInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.manualInput_KeyDown);
            // 
            // addPoint
            // 
            this.addPoint.BackColor = System.Drawing.SystemColors.Highlight;
            this.addPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPoint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addPoint.Location = new System.Drawing.Point(891, 143);
            this.addPoint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addPoint.Name = "addPoint";
            this.addPoint.Size = new System.Drawing.Size(160, 46);
            this.addPoint.TabIndex = 7;
            this.addPoint.Text = "Add Point";
            this.addPoint.UseVisualStyleBackColor = false;
            this.addPoint.Click += new System.EventHandler(this.addPoint_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.Highlight;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clear.Location = new System.Drawing.Point(891, 256);
            this.clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(160, 46);
            this.clear.TabIndex = 8;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // PolygonArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.addPoint);
            this.Controls.Add(this.manualInput);
            this.Controls.Add(this.numberOfPointsInput);
            this.Controls.Add(this.areaBox);
            this.Controls.Add(this.calculateArea);
            this.Controls.Add(this.drawPolygon);
            this.Controls.Add(this.drawRandomClick);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PolygonArea";
            this.Text = "PolygonArea";
            this.Load += new System.EventHandler(this.PolygonArea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button drawRandomClick;
        private System.Windows.Forms.Button drawPolygon;
        private System.Windows.Forms.Button calculateArea;
        private System.Windows.Forms.ListBox areaBox;
        private System.Windows.Forms.TextBox numberOfPointsInput;
        private System.Windows.Forms.TextBox manualInput;
        private System.Windows.Forms.Button addPoint;
        private System.Windows.Forms.Button clear;
    }
}