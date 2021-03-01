using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace Render
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            var canvas = e.Graphics;
            var pen = new Pen(Color.Red);
            Vector startPoint = new Vector(0, 0);
            Vector endPoint = new Vector(300, 10);
            canvas.DrawLine(pen, startPoint.ToPoint(), endPoint.ToPoint());
            canvas.DrawLine(pen, startPoint.ToPoint(), Rotate(endPoint, (float)Math.PI/4));
        }

        private Point Rotate(Vector point, float angle)
        {
            Point result = new Point();
            result.X = (int)Math.Round(point.X * Math.Cos(angle) - point.Y * Math.Sin(angle));
            result.Y = (int)Math.Round(point.X * Math.Sin(angle) + point.Y * Math.Cos(angle));
            return result;
        }
    }
}
