namespace BTH3_TranQuangHa
{
    partial class Bai1
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblLoad = new Krypton.Toolkit.KryptonLabel();
            this.lblActivated = new Krypton.Toolkit.KryptonLabel();
            this.lblShow = new Krypton.Toolkit.KryptonLabel();
            this.lblClose = new Krypton.Toolkit.KryptonLabel();
            this.lblClosed = new Krypton.Toolkit.KryptonLabel();
            this.txtLoad = new Krypton.Toolkit.KryptonTextBox();
            this.txtShow = new Krypton.Toolkit.KryptonTextBox();
            this.txtActivated = new Krypton.Toolkit.KryptonTextBox();
            this.txtClosing = new Krypton.Toolkit.KryptonTextBox();
            this.txtClosed = new Krypton.Toolkit.KryptonTextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblLoad);
            this.flowLayoutPanel1.Controls.Add(this.lblActivated);
            this.flowLayoutPanel1.Controls.Add(this.lblShow);
            this.flowLayoutPanel1.Controls.Add(this.lblClose);
            this.flowLayoutPanel1.Controls.Add(this.lblClosed);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(124, 172);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblLoad
            // 
            this.lblLoad.Location = new System.Drawing.Point(3, 3);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.Size = new System.Drawing.Size(88, 24);
            this.lblLoad.TabIndex = 0;
            this.lblLoad.Values.Text = "Form Load: ";
            // 
            // lblActivated
            // 
            this.lblActivated.Location = new System.Drawing.Point(3, 33);
            this.lblActivated.Name = "lblActivated";
            this.lblActivated.Size = new System.Drawing.Size(118, 24);
            this.lblActivated.TabIndex = 1;
            this.lblActivated.Values.Text = "Form Activated: ";
            // 
            // lblShow
            // 
            this.lblShow.Location = new System.Drawing.Point(3, 63);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(88, 24);
            this.lblShow.TabIndex = 2;
            this.lblShow.Values.Text = "Form Show";
            // 
            // lblClose
            // 
            this.lblClose.Location = new System.Drawing.Point(3, 93);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(105, 24);
            this.lblClose.TabIndex = 3;
            this.lblClose.Values.Text = "Form Closing: ";
            this.lblClose.Click += new System.EventHandler(this.kryptonLabel4_Click);
            // 
            // lblClosed
            // 
            this.lblClosed.Location = new System.Drawing.Point(3, 123);
            this.lblClosed.Name = "lblClosed";
            this.lblClosed.Size = new System.Drawing.Size(100, 24);
            this.lblClosed.TabIndex = 4;
            this.lblClosed.Values.Text = "Form Closed: ";
            // 
            // txtLoad
            // 
            this.txtLoad.Location = new System.Drawing.Point(131, 1);
            this.txtLoad.Name = "txtLoad";
            this.txtLoad.ReadOnly = true;
            this.txtLoad.Size = new System.Drawing.Size(145, 27);
            this.txtLoad.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.txtLoad.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.txtLoad.TabIndex = 4;
            // 
            // txtShow
            // 
            this.txtShow.Location = new System.Drawing.Point(131, 61);
            this.txtShow.Name = "txtShow";
            this.txtShow.ReadOnly = true;
            this.txtShow.Size = new System.Drawing.Size(145, 27);
            this.txtShow.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.txtShow.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.txtShow.TabIndex = 5;
            this.txtShow.TextChanged += new System.EventHandler(this.txtShow_TextChanged);
            // 
            // txtActivated
            // 
            this.txtActivated.Location = new System.Drawing.Point(131, 31);
            this.txtActivated.Name = "txtActivated";
            this.txtActivated.ReadOnly = true;
            this.txtActivated.Size = new System.Drawing.Size(145, 27);
            this.txtActivated.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtActivated.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.txtActivated.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.txtActivated.TabIndex = 6;
            // 
            // txtClosing
            // 
            this.txtClosing.Location = new System.Drawing.Point(131, 94);
            this.txtClosing.Name = "txtClosing";
            this.txtClosing.ReadOnly = true;
            this.txtClosing.Size = new System.Drawing.Size(145, 27);
            this.txtClosing.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.txtClosing.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.txtClosing.TabIndex = 7;
            // 
            // txtClosed
            // 
            this.txtClosed.Location = new System.Drawing.Point(132, 128);
            this.txtClosed.Name = "txtClosed";
            this.txtClosed.ReadOnly = true;
            this.txtClosed.Size = new System.Drawing.Size(145, 27);
            this.txtClosed.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.txtClosed.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.txtClosed.TabIndex = 8;
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 422);
            this.Controls.Add(this.txtClosed);
            this.Controls.Add(this.txtClosing);
            this.Controls.Add(this.txtActivated);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.txtLoad);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Bai1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai 1";
            this.Activated += new System.EventHandler(this.Bai1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Krypton.Toolkit.KryptonLabel lblLoad;
        private Krypton.Toolkit.KryptonLabel lblActivated;
        private Krypton.Toolkit.KryptonLabel lblShow;
        private Krypton.Toolkit.KryptonLabel lblClose;
        private Krypton.Toolkit.KryptonTextBox txtLoad;
        private Krypton.Toolkit.KryptonTextBox txtShow;
        private Krypton.Toolkit.KryptonTextBox txtActivated;
        private Krypton.Toolkit.KryptonTextBox txtClosing;
        private Krypton.Toolkit.KryptonLabel lblClosed;
        private Krypton.Toolkit.KryptonTextBox txtClosed;
    }
}

