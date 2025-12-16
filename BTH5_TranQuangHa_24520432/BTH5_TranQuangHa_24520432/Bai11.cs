using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH5_TranQuangHa_24520432
{
    public partial class Bai11 : Form
    {
        Point startPoint;   
        Point endPoint;     
        bool isDrawing = false; 

        Color currentPenColor = Color.Black; 
        Bitmap drawingBitmap;
        public Bai11()
        {
            InitializeComponent();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.ShowDialog();
            if(dlg.ShowDialog() == DialogResult.OK )
            {
                currentPenColor = dlg.Color;
                btnColor.BackColor = dlg.Color;
            }
        }

        private void Bai11_Load(object sender, EventArgs e)
        {
            drawingBitmap = new Bitmap(mainPictureBox.Width, mainPictureBox.Height);
            using(Graphics g = Graphics.FromImage(drawingBitmap))
            {
                g.Clear(Color.White);
            }

            rbLine.Checked = true;
            rbSolid.Checked = true;
            txtWidth.Text = "2";
        }

        private void mainPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                isDrawing = false;
                endPoint = e.Location;
                using (Graphics g = Graphics.FromImage(drawingBitmap))
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    DrawShape(g);
                }
                mainPictureBox.Refresh();
            }
        }

        private void DrawShape(Graphics g)
        {
            float penWidth = 1;
            float.TryParse(txtWidth.Text, out penWidth);
            Pen pen = new Pen(currentPenColor, penWidth);

            // Tính toán hình chữ nhật bao quanh (cho Rect và Ellipse)
            // Phải dùng Math.Min/Abs để vẽ được kể cả khi kéo chuột ngược từ dưới lên
            Rectangle rect = new Rectangle(
                Math.Min(startPoint.X, endPoint.X),
                Math.Min(startPoint.Y, endPoint.Y),
                Math.Abs(startPoint.X - endPoint.X),
                Math.Abs(startPoint.Y - endPoint.Y)
            );

            // Xử lý vẽ theo lựa chọn hình
            if (rbLine.Checked)
            {
                g.DrawLine(pen, startPoint, endPoint);
            }
            else
            {
                // Chọn loại Brush
                Brush b = null;

                if (rbSolid.Checked)
                {
                    b = new SolidBrush(Color.Green); // Đề bài: Green
                }
                else if (rbHatch.Checked)
                {
                    // Đề bài: Horizontal, Blue & Green
                    b = new HatchBrush(HatchStyle.Horizontal, Color.Blue, Color.Green);
                }
                else if (rbTexture.Checked)
                {
                    // Đề bài: Texture từ file ảnh
                    try
                    {
                        Image img = Image.FromFile("texture.jpg"); // Nhớ copy 1 file ảnh vào bin/Debug
                        b = new TextureBrush(img);
                    }
                    catch
                    {
                        // Nếu không có ảnh thì fallback về solid
                        b = new SolidBrush(Color.Gray);
                    }
                }
                else if (rbGradient.Checked)
                {
                    // Đề bài: Vertical, Red & Green (Lưu ý: Rect không được width/height = 0)
                    if (rect.Width > 0 && rect.Height > 0)
                        b = new LinearGradientBrush(rect, Color.Red, Color.Green, LinearGradientMode.Vertical);
                }

                // Thực hiện vẽ Rectangle hoặc Ellipse
                if (b != null)
                {
                    if (rbRect.Checked)
                        g.FillRectangle(b, rect);
                    else if (rbEllipse.Checked)
                        g.FillEllipse(b, rect);
                }
            }
        }

        private void mainPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;       
                startPoint = e.Location; 
            }
        }

        private void mainPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if(isDrawing)
            {
                endPoint = e.Location;
                mainPictureBox.Refresh();
            }
        }

        private void mainPictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(drawingBitmap, 0, 0);
            if (isDrawing)
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                DrawShape(e.Graphics);
            }
        }
    }
}
