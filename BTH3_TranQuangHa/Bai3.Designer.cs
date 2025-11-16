namespace BTH3_TranQuangHa
{
    partial class Bai3
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
            this.btnChangeColor = new Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Location = new System.Drawing.Point(276, 180);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(216, 46);
            this.btnChangeColor.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnChangeColor.StateCommon.Back.Color2 = System.Drawing.Color.Silver;
            this.btnChangeColor.StateCommon.Border.Rounding = 12F;
            this.btnChangeColor.TabIndex = 0;
            this.btnChangeColor.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnChangeColor.Values.Text = "Change color";
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 436);
            this.Controls.Add(this.btnChangeColor);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Form3";
            this.Text = "Bai 3";
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnChangeColor;
    }
}