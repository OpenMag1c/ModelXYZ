using System.Collections.Generic;
using System.Drawing;

namespace ModelXYZ
{
    class ModelDrawer
    {
        List<PointF> Points { get; set; }
        byte ChoosenAxis { get; set; }

        public ModelDrawer(List<PointF> p, byte i)
        {
            Points = p;
            ChoosenAxis = i;
        }

        public void DrawModel2D(bool onlyPoints, int approx, Graphics g)
        {
            var i = 0;
            g.Clear(Color.FromArgb(255, 225, 255));
            foreach (PointF p in Points)
            {
                g.DrawEllipse(new Pen(Brushes.Red, 5), p.X - 1, p.Y - 1, 2, 2);
            }
            if (onlyPoints)
            {
                return;
            }
            for (i = 0; i < 4; ++i)
            {
                if (i < 3) g.DrawLine(new Pen(Brushes.Black, 2), Points[i], Points[i + 1]);
                g.DrawLine(new Pen(Brushes.Black, 2), Points[i], Points[i + 4]);
                if (i < 3) g.DrawLine(new Pen(Brushes.Black, 2), Points[i + 4], Points[i + 5]);
            }
            g.DrawLine(new Pen(Brushes.Black, 2), Points[3], Points[0]);
            g.DrawLine(new Pen(Brushes.Black, 2), Points[7], Points[4]);

            if (Points.Count <= 8)
            {
                return;
            }

            for (i = 8; i < 7 + approx; ++i)
            {
                g.DrawLine(new Pen(Brushes.Black, 2), Points[i], Points[i + 1]);
                g.DrawLine(new Pen(Brushes.Black, 2), Points[i], Points[i + approx]);
                g.DrawLine(new Pen(Brushes.Black, 2), Points[i + approx], Points[i + approx + 1]);
            }
            g.DrawLine(new Pen(Brushes.Black, 2), Points[8], Points[i]);
            g.DrawLine(new Pen(Brushes.Black, 2), Points[i], Points[i + approx]);
            i++;
            g.DrawLine(new Pen(Brushes.Black, 2), Points[i], Points[i + approx - 1]);
        }
    }
}
