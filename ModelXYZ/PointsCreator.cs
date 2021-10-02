using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ModelXYZ
{
    class PointsCreator
    {
        public List<PointXyz> PointsXYZ { get; set; }
        float A { get; set; }
        float B { get; set; }
        float R { get; set; }   
        float H { get; set; }
        public int Approx { get; set; }
        const int Resolution = 15;

        public PointsCreator(string a, string b, string r, string h, string n)
        {
            A = float.Parse(a);
            B = float.Parse(b);
            R = float.Parse(r);
            H = float.Parse(h);
            Approx = int.Parse(n);
            PointsXYZ = InitPointsModel();
        }

        private List<PointXyz> InitPointsModel()
        {
            List<PointXyz> pointsModel = new List<PointXyz>();
            float angleRad = 0;
            float deltaAngleGrad = 360f / Approx;

            pointsModel.Add(new PointXyz(0, 0, 0));
            pointsModel.Add(new PointXyz(B, 0, 0));
            pointsModel.Add(new PointXyz(B, 0, A));
            pointsModel.Add(new PointXyz(0, 0, A));
            pointsModel.Add(new PointXyz(0, H, 0));
            pointsModel.Add(new PointXyz(B, H, 0));
            pointsModel.Add(new PointXyz(B, H, A));
            pointsModel.Add(new PointXyz(0, H, A));

            for (var i = 0; i < Approx; ++i)
            {
                pointsModel.Add(new PointXyz(R * (float)Math.Cos(angleRad) + B / 2f, 0f, R * (float)Math.Sin(angleRad) + A / 2f));
                angleRad += deltaAngleGrad * (float)(Math.PI / 180);
            }

            angleRad = 0;
            for (var i = 0; i < Approx; ++i)
            {
                pointsModel.Add(new PointXyz(R * (float)Math.Cos(angleRad) + B / 2f, H, R * (float)Math.Sin(angleRad) + A / 2f));
                angleRad += deltaAngleGrad * (float)(Math.PI / 180);
            }
            return pointsModel;
        }

        public string ShowAllPoints()
        {
            StringBuilder result = new StringBuilder();
            for (var i = 0; i < PointsXYZ.Count; ++i)
            {
                result.Append(PointsXYZ[i].GetStrPoint());
                if ((i + 1) % 8 == 0)
                {
                    result.Append(Environment.NewLine);
                }
            }
            return result.ToString();
        }

        public List<PointF> GetPointsXY()
        {
            List<PointF> pointsXY = new List<PointF>();
            foreach (PointXyz p in PointsXYZ)
            {
                pointsXY.Add(new PointF(p.X * Resolution, p.Y * Resolution));
            }
            return pointsXY;
        }

        public List<PointF> GetPointsZY()
        {
            List<PointF> pointsXY = new List<PointF>();
            foreach (PointXyz p in PointsXYZ)
            {
                pointsXY.Add(new PointF(p.Z * Resolution, p.Y * Resolution));
            }
            return pointsXY;
        }

        public List<PointF> GetPointsXZ()
        {
            List<PointF> pointsXY = new List<PointF>();
            foreach (PointXyz p in PointsXYZ)
            {
                pointsXY.Add(new PointF(p.X * Resolution, p.Z * Resolution));
            }
            return pointsXY;
        }
    }
}
