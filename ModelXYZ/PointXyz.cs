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

namespace ModelXYZ
{
    class PointXyz
    {
        public float[] Vector { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public const float W = 1;

        public PointXyz(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
            Vector = new float[] { X, Y, Z, W };
        }

        public string GetStrPoint()
        {
            return $"({Math.Round(X, 1)}; {Math.Round(Y, 1)}; {Math.Round(Z, 1)})  ";
        }

        public void MatrixMultiplication(float[,] inputMatrix)
        {
            float[] resultVector = new float[4];

            for (int i = 0; i < 4; ++i)
            {
                resultVector[i] = 0;

                for (int k = 0; k < 4; ++k)
                {
                    resultVector[i] += inputMatrix[k,i] * Vector[k];
                }
            }

            Vector = resultVector;
            X = Vector[0];
            Y = Vector[1];
            Z = Vector[2];
        }

        public void MovePoint(string movetbX, string movetbY, string movetbZ)
        {
            float moveX = float.Parse(movetbX);
            float moveY = float.Parse(movetbY);
            float moveZ = float.Parse(movetbZ);
            float[,] T = { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 1, 0 }, { moveX, moveY, moveZ, 1 } };
            MatrixMultiplication(T);
        }

        public void ScalePoint(string scaletbX, string scaletbY, string scaletbZ)
        {
            float scaleX = float.Parse(scaletbX);
            float scaleY = float.Parse(scaletbY);
            float scaleZ = float.Parse(scaletbZ);
            float[,] S = { { scaleX, 0, 0, 0 }, { 0, scaleY, 0, 0 }, { 0, 0, scaleZ, 0 }, {0, 0, 0, 1 } };
            MatrixMultiplication(S);
        }

        public void RotatePoint(string tbRotate, CheckedListBox clbXYZ)
        {
            float rotateAngle = float.Parse(tbRotate);
            float[,] RR;
            float sinR = (float)Math.Sin(rotateAngle * Math.PI / 180);
            float cosR = (float)Math.Cos(rotateAngle * Math.PI / 180);
            switch (clbXYZ.SelectedIndex)
            {
                case 0:
                    RR = new float[,] { { 1, 0, 0, 0 }, { 0, cosR, sinR, 0 }, { 0, -sinR, cosR, 0 }, { 0, 0, 0, 1 } };
                    break;
                case 1:
                    RR = new float[,] { { cosR, 0, -sinR, 0 }, { 0, 1, 0, 0 }, { sinR, 0, cosR, 0 }, { 0, 0, 0, 1 } };
                    break;
                case 2:
                    RR = new float[,] { { cosR, sinR, 0, 0 }, { -sinR, cosR, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };
                    break;
                default:
                    RR = new float[0,0];
                    break;
            }
            MatrixMultiplication(RR);
        }
    }
}