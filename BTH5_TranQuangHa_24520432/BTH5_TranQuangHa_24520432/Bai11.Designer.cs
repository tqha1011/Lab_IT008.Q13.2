namespace BTH5_TranQuangHa_24520432
{
    partial class Bai11
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.rbLine = new System.Windows.Forms.RadioButton();
            this.rbRect = new System.Windows.Forms.RadioButton();
            this.rbEllipse = new System.Windows.Forms.RadioButton();
            this.rbSolid = new System.Windows.Forms.RadioButton();
            this.rbHatch = new System.Windows.Forms.RadioButton();
            this.rbTexture = new System.Windows.Forms.RadioButton();
            this.rbGradient = new System.Windows.Forms.RadioButton();
            this.mainPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 516);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEllipse);
            this.groupBox1.Controls.Add(this.rbRect);
            this.groupBox1.Controls.Add(this.rbLine);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shapes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnColor);
            this.groupBox2.Controls.Add(this.txtWidth);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(12, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pen";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbGradient);
            this.groupBox3.Controls.Add(this.rbTexture);
            this.groupBox3.Controls.Add(this.rbHatch);
            this.groupBox3.Controls.Add(this.rbSolid);
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(12, 269);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 191);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Brushes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width";
            // 
            // txtWidth
            // 
            this.txtWidth.ForeColor = System.Drawing.Color.Black;
            this.txtWidth.Location = new System.Drawing.Point(72, 22);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 22);
            this.txtWidth.TabIndex = 1;
            // 
            // btnColor
            // 
            this.btnColor.ForeColor = System.Drawing.Color.Black;
            this.btnColor.Location = new System.Drawing.Point(46, 65);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(97, 23);
            this.btnColor.TabIndex = 2;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // rbLine
            // 
            this.rbLine.AutoSize = true;
            this.rbLine.ForeColor = System.Drawing.Color.Black;
            this.rbLine.Location = new System.Drawing.Point(10, 21);
            this.rbLine.Name = "rbLine";
            this.rbLine.Size = new System.Drawing.Size(53, 20);
            this.rbLine.TabIndex = 3;
            this.rbLine.TabStop = true;
            this.rbLine.Text = "Line";
            this.rbLine.UseVisualStyleBackColor = true;
            // 
            // rbRect
            // 
            this.rbRect.AutoSize = true;
            this.rbRect.ForeColor = System.Drawing.Color.Black;
            this.rbRect.Location = new System.Drawing.Point(10, 48);
            this.rbRect.Name = "rbRect";
            this.rbRect.Size = new System.Drawing.Size(90, 20);
            this.rbRect.TabIndex = 4;
            this.rbRect.TabStop = true;
            this.rbRect.Text = "Rectangle";
            this.rbRect.UseVisualStyleBackColor = true;
            // 
            // rbEllipse
            // 
            this.rbEllipse.AutoSize = true;
            this.rbEllipse.ForeColor = System.Drawing.Color.Black;
            this.rbEllipse.Location = new System.Drawing.Point(10, 74);
            this.rbEllipse.Name = "rbEllipse";
            this.rbEllipse.Size = new System.Drawing.Size(69, 20);
            this.rbEllipse.TabIndex = 5;
            this.rbEllipse.TabStop = true;
            this.rbEllipse.Text = "Ellipse";
            this.rbEllipse.UseVisualStyleBackColor = true;
            // 
            // rbSolid
            // 
            this.rbSolid.AutoSize = true;
            this.rbSolid.ForeColor = System.Drawing.Color.Black;
            this.rbSolid.Location = new System.Drawing.Point(10, 22);
            this.rbSolid.Name = "rbSolid";
            this.rbSolid.Size = new System.Drawing.Size(93, 20);
            this.rbSolid.TabIndex = 0;
            this.rbSolid.TabStop = true;
            this.rbSolid.Text = "SolidBrush";
            this.rbSolid.UseVisualStyleBackColor = true;
            // 
            // rbHatch
            // 
            this.rbHatch.AutoSize = true;
            this.rbHatch.ForeColor = System.Drawing.Color.Black;
            this.rbHatch.Location = new System.Drawing.Point(10, 60);
            this.rbHatch.Name = "rbHatch";
            this.rbHatch.Size = new System.Drawing.Size(97, 20);
            this.rbHatch.TabIndex = 1;
            this.rbHatch.TabStop = true;
            this.rbHatch.Text = "HatchBrush";
            this.rbHatch.UseVisualStyleBackColor = true;
            // 
            // rbTexture
            // 
            this.rbTexture.AutoSize = true;
            this.rbTexture.ForeColor = System.Drawing.Color.Black;
            this.rbTexture.Location = new System.Drawing.Point(10, 103);
            this.rbTexture.Name = "rbTexture";
            this.rbTexture.Size = new System.Drawing.Size(107, 20);
            this.rbTexture.TabIndex = 2;
            this.rbTexture.TabStop = true;
            this.rbTexture.Text = "TextureBrush";
            this.rbTexture.UseVisualStyleBackColor = true;
            // 
            // rbGradient
            // 
            this.rbGradient.AutoSize = true;
            this.rbGradient.ForeColor = System.Drawing.Color.Black;
            this.rbGradient.Location = new System.Drawing.Point(10, 144);
            this.rbGradient.Name = "rbGradient";
            this.rbGradient.Size = new System.Drawing.Size(116, 20);
            this.rbGradient.TabIndex = 3;
            this.rbGradient.TabStop = true;
            this.rbGradient.Text = "LinearGradient";
            this.rbGradient.UseVisualStyleBackColor = true;
            // 
            // mainPictureBox
            // 
            this.mainPictureBox.BackColor = System.Drawing.Color.White;
            this.mainPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPictureBox.Location = new System.Drawing.Point(240, 0);
            this.mainPictureBox.Name = "mainPictureBox";
            this.mainPictureBox.Size = new System.Drawing.Size(610, 516);
            this.mainPictureBox.TabIndex = 1;
            this.mainPictureBox.TabStop = false;
            this.mainPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPictureBox_Paint);
            this.mainPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPictureBox_MouseDown);
            this.mainPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPictureBox_MouseMove);
            this.mainPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPictureBox_MouseUp);
            // 
            // Bai11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 516);
            this.Controls.Add(this.mainPictureBox);
            this.Controls.Add(this.panel1);
            this.Name = "Bai11";
            this.Text = "Bai11";
            this.Load += new System.EventHandler(this.Bai11_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbGradient;
        private System.Windows.Forms.RadioButton rbTexture;
        private System.Windows.Forms.RadioButton rbHatch;
        private System.Windows.Forms.RadioButton rbSolid;
        private System.Windows.Forms.RadioButton rbEllipse;
        private System.Windows.Forms.RadioButton rbRect;
        private System.Windows.Forms.RadioButton rbLine;
        private System.Windows.Forms.PictureBox mainPictureBox;
    }
}