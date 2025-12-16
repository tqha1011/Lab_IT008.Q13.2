namespace BTH5_TranQuangHa_24520432
{
    partial class Bai4
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
            this.lblFont = new System.Windows.Forms.Label();
            this.cboFont = new System.Windows.Forms.ComboBox();
            this.chkInDam = new System.Windows.Forms.CheckBox();
            this.chkInNghieng = new System.Windows.Forms.CheckBox();
            this.chkUnderline = new System.Windows.Forms.CheckBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkRight = new System.Windows.Forms.CheckBox();
            this.chkCenter = new System.Windows.Forms.CheckBox();
            this.chkLeft = new System.Windows.Forms.CheckBox();
            this.lblDraw = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFont.Location = new System.Drawing.Point(51, 55);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(72, 38);
            this.lblFont.TabIndex = 0;
            this.lblFont.Text = "Font";
            // 
            // cboFont
            // 
            this.cboFont.FormattingEnabled = true;
            this.cboFont.Location = new System.Drawing.Point(129, 65);
            this.cboFont.Name = "cboFont";
            this.cboFont.Size = new System.Drawing.Size(150, 24);
            this.cboFont.TabIndex = 1;
            this.cboFont.SelectedIndexChanged += new System.EventHandler(this.cboFont_SelectedIndexChanged);
            // 
            // chkInDam
            // 
            this.chkInDam.AutoSize = true;
            this.chkInDam.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInDam.Location = new System.Drawing.Point(66, 116);
            this.chkInDam.Name = "chkInDam";
            this.chkInDam.Size = new System.Drawing.Size(57, 42);
            this.chkInDam.TabIndex = 2;
            this.chkInDam.Text = "B";
            this.chkInDam.UseVisualStyleBackColor = true;
            this.chkInDam.CheckedChanged += new System.EventHandler(this.ChangeStyle);
            // 
            // chkInNghieng
            // 
            this.chkInNghieng.AutoSize = true;
            this.chkInNghieng.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInNghieng.Location = new System.Drawing.Point(129, 116);
            this.chkInNghieng.Name = "chkInNghieng";
            this.chkInNghieng.Size = new System.Drawing.Size(46, 42);
            this.chkInNghieng.TabIndex = 3;
            this.chkInNghieng.Text = "I";
            this.chkInNghieng.UseVisualStyleBackColor = true;
            this.chkInNghieng.CheckedChanged += new System.EventHandler(this.ChangeStyle);
            // 
            // chkUnderline
            // 
            this.chkUnderline.AutoSize = true;
            this.chkUnderline.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUnderline.Location = new System.Drawing.Point(181, 116);
            this.chkUnderline.Name = "chkUnderline";
            this.chkUnderline.Size = new System.Drawing.Size(59, 42);
            this.chkUnderline.TabIndex = 4;
            this.chkUnderline.Text = "U";
            this.chkUnderline.UseVisualStyleBackColor = true;
            this.chkUnderline.CheckedChanged += new System.EventHandler(this.ChangeStyle);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(304, 55);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(67, 38);
            this.lblSize.TabIndex = 5;
            this.lblSize.Text = "Size";
            // 
            // cboSize
            // 
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Location = new System.Drawing.Point(377, 65);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(121, 24);
            this.cboSize.TabIndex = 6;
            this.cboSize.SelectedIndexChanged += new System.EventHandler(this.cboSize_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 38);
            this.label3.TabIndex = 7;
            this.label3.Text = "Color";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(401, 121);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(42, 37);
            this.btnColor.TabIndex = 8;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkRight);
            this.groupBox1.Controls.Add(this.chkCenter);
            this.groupBox1.Controls.Add(this.chkLeft);
            this.groupBox1.Location = new System.Drawing.Point(58, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 154);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Align text";
            // 
            // chkRight
            // 
            this.chkRight.AutoSize = true;
            this.chkRight.Location = new System.Drawing.Point(8, 103);
            this.chkRight.Name = "chkRight";
            this.chkRight.Size = new System.Drawing.Size(60, 20);
            this.chkRight.TabIndex = 2;
            this.chkRight.Text = "Right";
            this.chkRight.UseVisualStyleBackColor = true;
            this.chkRight.CheckedChanged += new System.EventHandler(this.chkRight_CheckedChanged);
            // 
            // chkCenter
            // 
            this.chkCenter.AutoSize = true;
            this.chkCenter.Location = new System.Drawing.Point(8, 63);
            this.chkCenter.Name = "chkCenter";
            this.chkCenter.Size = new System.Drawing.Size(68, 20);
            this.chkCenter.TabIndex = 1;
            this.chkCenter.Text = "Center";
            this.chkCenter.UseVisualStyleBackColor = true;
            this.chkCenter.CheckedChanged += new System.EventHandler(this.chkCenter_CheckedChanged);
            // 
            // chkLeft
            // 
            this.chkLeft.AutoSize = true;
            this.chkLeft.Location = new System.Drawing.Point(8, 27);
            this.chkLeft.Name = "chkLeft";
            this.chkLeft.Size = new System.Drawing.Size(50, 20);
            this.chkLeft.TabIndex = 0;
            this.chkLeft.Text = "Left";
            this.chkLeft.UseVisualStyleBackColor = true;
            this.chkLeft.CheckedChanged += new System.EventHandler(this.chkLeft_CheckedChanged);
            // 
            // lblDraw
            // 
            this.lblDraw.BackColor = System.Drawing.Color.White;
            this.lblDraw.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDraw.Location = new System.Drawing.Point(207, 251);
            this.lblDraw.Name = "lblDraw";
            this.lblDraw.Size = new System.Drawing.Size(340, 115);
            this.lblDraw.TabIndex = 10;
            this.lblDraw.Text = "Hello";
            this.lblDraw.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 450);
            this.Controls.Add(this.lblDraw);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboSize);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.chkUnderline);
            this.Controls.Add(this.chkInNghieng);
            this.Controls.Add(this.chkInDam);
            this.Controls.Add(this.cboFont);
            this.Controls.Add(this.lblFont);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.ComboBox cboFont;
        private System.Windows.Forms.CheckBox chkInDam;
        private System.Windows.Forms.CheckBox chkInNghieng;
        private System.Windows.Forms.CheckBox chkUnderline;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.ComboBox cboSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDraw;
        private System.Windows.Forms.CheckBox chkRight;
        private System.Windows.Forms.CheckBox chkCenter;
        private System.Windows.Forms.CheckBox chkLeft;
    }
}

