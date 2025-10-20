using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppWeek2
{
    public partial class Form1 : Form
    {
        private bool drawShapes = true;  // keeps track of what to draw

        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);

            // Attach button click event
            btnChangeDrawing.Click += BtnChangeDrawing_Click;
        }

        private void BtnChangeDrawing_Click(object sender, EventArgs e)
        {
            drawShapes = !drawShapes; // flip the state
            this.Invalidate();        // forces the form to redraw
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White, this.ClientRectangle);

            if (drawShapes)
            {
                // Draw shapes
                using (Pen bluePen = new Pen(Color.Blue, 3))
                {
                    e.Graphics.DrawRectangle(bluePen, 50, 50, 200, 100);
                }

                using (Pen redPen = new Pen(Color.Red, 3))
                {
                    e.Graphics.DrawEllipse(redPen, 300, 50, 100, 100);
                }

                e.Graphics.DrawString("Shapes Mode",
                    new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 50, 200);
            }
            else
            {
                // Draw different graphics
                e.Graphics.FillEllipse(Brushes.Green, 100, 100, 200, 150);
                e.Graphics.DrawString("Alternative Drawing!",
                    new Font("Arial", 14, FontStyle.Italic), Brushes.DarkRed, 50, 300);
            }
        }

    }
}
