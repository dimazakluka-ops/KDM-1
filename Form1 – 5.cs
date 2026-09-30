using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace _5kd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Text = "Діаграма Ейлера-Венна: A Δ (B ∩ C)";
            Width = 800;
            Height = 600;
            BackColor = Color.White;

            Paint += Form1_Paint;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

          
            Point centerA = new Point(300, 270);
            Point centerB = new Point(450, 270);
            Point centerC = new Point(375, 380);

            int radius = 150;

            GraphicsPath pathA = new GraphicsPath();
            GraphicsPath pathB = new GraphicsPath();
            GraphicsPath pathC = new GraphicsPath();

            pathA.AddEllipse(
                centerA.X - radius,
                centerA.Y - radius,
                radius * 2,
                radius * 2);

            pathB.AddEllipse(
                centerB.X - radius,
                centerB.Y - radius,
                radius * 2,
                radius * 2);

            pathC.AddEllipse(
                centerC.X - radius,
                centerC.Y - radius,
                radius * 2,
                radius * 2);

            GraphicsPath areaA = new GraphicsPath();
            areaA.AddPath(pathA, false);

          
            Region regionA = new Region(pathA);

            using (Region regionBC = new Region(pathB))
            {
                regionBC.Intersect(pathC);
                regionA.Exclude(regionBC);

                using (SolidBrush brush = new SolidBrush(
                    Color.LightBlue))
                {
                    g.FillRegion(brush, regionA);
                }
            }

       

            Region regionBC2 = new Region(pathB);
            regionBC2.Intersect(pathC);

            using (Region regionA2 = new Region(pathA))
            {
                regionBC2.Exclude(regionA2);

                using (SolidBrush brush = new SolidBrush(
                    Color.LightGreen))
                {
                    g.FillRegion(brush, regionBC2);
                }
            }


            using (Pen pen = new Pen(Color.Black, 2))
            {
                g.DrawPath(pen, pathA);
                g.DrawPath(pen, pathB);
                g.DrawPath(pen, pathC);
            }


            using (Font font = new Font(
                "Arial", 16, FontStyle.Bold))
            {
                g.DrawString("A", font, Brushes.Black, 250, 150);
                g.DrawString("B", font, Brushes.Black, 485, 150);
                g.DrawString("C", font, Brushes.Black, 365, 505);
            }

           

            using (Font font = new Font("Arial", 14))
            {
                // A = {1, 2, 3, 4}
                g.DrawString("1", font, Brushes.Black, 200, 245);
                g.DrawString("2", font, Brushes.Black, 285, 370);
                g.DrawString("4", font, Brushes.Black, 370, 315);

                // B ∩ C
                g.DrawString("3", font, Brushes.Black, 370, 190);
                g.DrawString("5", font, Brushes.Black, 440, 355);

                // Тільки B
                g.DrawString("6", font, Brushes.Black, 510, 275);

                // Тільки C
                g.DrawString("7", font, Brushes.Black, 375, 420);
            }

      

            using (Font titleFont = new Font(
                "Arial", 18, FontStyle.Bold))
            {
                string title =
                    "A Δ (B ∩ C) = {1, 2, 4, 5}";

                g.DrawString(
                    title,
                    titleFont,
                    Brushes.Black,
                    230,
                    30);
            }

            // Звільнення ресурсів
            pathA.Dispose();
            pathB.Dispose();
            pathC.Dispose();
            regionA.Dispose();
            regionBC2.Dispose();
        }
    }
}