using System;
using System.Drawing;
using System.Windows.Forms;

namespace ModelXYZ
{
    public partial class MainForm : Form
    {
        private Graphics Graphics { get; set; }
        private PointsCreator ModelPoints { get; set; }
        private ModelDrawer ModelDraw { get; set; }
        byte ChoosenAxis { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void btCreateModel_Click(object sender, EventArgs e)
        {
            pbMain.Invalidate();
            ModelPoints = new PointsCreator(tbA.Text, tbB.Text, tbR.Text, tbH.Text, tbN.Text);
            InitGraphics();
            lbPoints.Text = ModelPoints.ShowAllPoints();
        }

        private void InitGraphics()
        {
            Graphics = pbMain.CreateGraphics();
            Graphics.TranslateTransform(pbMain.Width / 2f, pbMain.Height / 2f);
            Graphics.ScaleTransform(1, -1);
        }

        private void btFrontView_Click(object sender, EventArgs e)
        {
            ChoosenAxis = 0;
            ModelDraw = new ModelDrawer(ModelPoints.GetPointsXY(), ChoosenAxis);
            ModelDraw.DrawModel2D(cbOnlyPoints.Checked, ModelPoints.Approx, Graphics);
        }

        private void btSideView_Click(object sender, EventArgs e)
        {
            ChoosenAxis = 1;
            ModelDraw = new ModelDrawer(ModelPoints.GetPointsZY(), ChoosenAxis);
            ModelDraw.DrawModel2D(cbOnlyPoints.Checked, ModelPoints.Approx, Graphics);
        }

        private void btTopView_Click(object sender, EventArgs e)
        {
            ChoosenAxis = 2;
            ModelDraw = new ModelDrawer(ModelPoints.GetPointsXZ(), ChoosenAxis);
            ModelDraw.DrawModel2D(cbOnlyPoints.Checked, ModelPoints.Approx, Graphics);
        }

        private void btAction_Click(object sender, EventArgs e)
        {
            DrawActions();
        }

        private void btAction_KeyPress(object sender, KeyPressEventArgs e)
        {
            DrawActions();
        }

        private void btAction_KeyDown(object sender, KeyEventArgs e)
        {
            DrawActions();
        }

        private void DrawActions()
        {
            foreach (var p in ModelPoints.PointsXYZ)
            {
                p.MovePoint(tbMoveX.Text, tbMoveY.Text, tbMoveZ.Text);
            }

            foreach (var p in ModelPoints.PointsXYZ)
            {
                p.ScalePoint(tbScaleX.Text, tbScaleY.Text, tbScaleZ.Text);
            }

            if (clbXYZ.GetSelected(0) || clbXYZ.GetSelected(1) || clbXYZ.GetSelected(2)) foreach (var p in ModelPoints.PointsXYZ)
            {
                p.RotatePoint(tbRotate.Text, clbXYZ);
            }

            switch (ChoosenAxis)
            {
                case 0:
                    ModelDraw = new ModelDrawer(ModelPoints.GetPointsXY(), ChoosenAxis);
                    break;
                case 1:
                    ModelDraw = new ModelDrawer(ModelPoints.GetPointsZY(), ChoosenAxis);
                    break;
                default:
                    ModelDraw = new ModelDrawer(ModelPoints.GetPointsXZ(), ChoosenAxis);
                    break;
            }
            ModelDraw.DrawModel2D(cbOnlyPoints.Checked, ModelPoints.Approx, Graphics);
            lbPoints.Text = ModelPoints.ShowAllPoints();
        }
    }
}