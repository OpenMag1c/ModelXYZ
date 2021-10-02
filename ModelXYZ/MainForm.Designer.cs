
namespace ModelXYZ
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbH = new System.Windows.Forms.TextBox();
            this.tbR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btCreateModel = new System.Windows.Forms.Button();
            this.lbPoints = new System.Windows.Forms.Label();
            this.btFrontView = new System.Windows.Forms.Button();
            this.btSideView = new System.Windows.Forms.Button();
            this.btTopView = new System.Windows.Forms.Button();
            this.cbOnlyPoints = new System.Windows.Forms.CheckBox();
            this.clbXYZ = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbRotate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbMoveX = new System.Windows.Forms.TextBox();
            this.tbMoveY = new System.Windows.Forms.TextBox();
            this.tbMoveZ = new System.Windows.Forms.TextBox();
            this.tbScaleZ = new System.Windows.Forms.TextBox();
            this.tbScaleY = new System.Windows.Forms.TextBox();
            this.tbScaleX = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btAction = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMain
            // 
            this.pbMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMain.BackColor = System.Drawing.Color.FloralWhite;
            this.pbMain.BackgroundImage = global::_3Dmodel.Properties.Resources.sakura_part21;
            this.pbMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMain.Location = new System.Drawing.Point(39, 46);
            this.pbMain.MaximumSize = new System.Drawing.Size(1259, 799);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(1259, 799);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMain.TabIndex = 0;
            this.pbMain.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabel1.Location = new System.Drawing.Point(1662, 22);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(124, 25);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "СВОЙСТВА";
            // 
            // tbB
            // 
            this.tbB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbB.Location = new System.Drawing.Point(1792, 95);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(71, 27);
            this.tbB.TabIndex = 11;
            this.tbB.Text = "3";
            this.tbB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbA
            // 
            this.tbA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbA.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbA.Location = new System.Drawing.Point(1792, 56);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(71, 27);
            this.tbA.TabIndex = 10;
            this.tbA.Text = "2";
            this.tbA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1746, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "b - ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1746, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "a - ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1563, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Параллелепипед:";
            // 
            // tbH
            // 
            this.tbH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbH.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbH.Location = new System.Drawing.Point(1792, 170);
            this.tbH.Name = "tbH";
            this.tbH.Size = new System.Drawing.Size(71, 27);
            this.tbH.TabIndex = 16;
            this.tbH.Text = "10";
            this.tbH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbR
            // 
            this.tbR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbR.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbR.Location = new System.Drawing.Point(1792, 131);
            this.tbR.Name = "tbR";
            this.tbR.Size = new System.Drawing.Size(71, 27);
            this.tbR.TabIndex = 15;
            this.tbR.Text = "5";
            this.tbR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1746, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "h - ";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(1746, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "R - ";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1669, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Конус:";
            // 
            // tbN
            // 
            this.tbN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbN.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbN.Location = new System.Drawing.Point(1792, 204);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(71, 27);
            this.tbN.TabIndex = 19;
            this.tbN.Text = "8";
            this.tbN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(1746, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "n - ";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(1584, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Апроксимация:";
            // 
            // btCreateModel
            // 
            this.btCreateModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCreateModel.BackColor = System.Drawing.Color.LightGray;
            this.btCreateModel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCreateModel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btCreateModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCreateModel.Location = new System.Drawing.Point(1524, 942);
            this.btCreateModel.Name = "btCreateModel";
            this.btCreateModel.Size = new System.Drawing.Size(127, 66);
            this.btCreateModel.TabIndex = 20;
            this.btCreateModel.Text = "Create\r\nmodel";
            this.btCreateModel.UseVisualStyleBackColor = false;
            this.btCreateModel.Click += new System.EventHandler(this.btCreateModel_Click);
            // 
            // lbPoints
            // 
            this.lbPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbPoints.BackColor = System.Drawing.Color.Transparent;
            this.lbPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPoints.ForeColor = System.Drawing.Color.Black;
            this.lbPoints.Location = new System.Drawing.Point(35, 862);
            this.lbPoints.Name = "lbPoints";
            this.lbPoints.Size = new System.Drawing.Size(1263, 146);
            this.lbPoints.TabIndex = 21;
            // 
            // btFrontView
            // 
            this.btFrontView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btFrontView.BackColor = System.Drawing.Color.LightGray;
            this.btFrontView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFrontView.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btFrontView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btFrontView.Location = new System.Drawing.Point(1657, 972);
            this.btFrontView.Name = "btFrontView";
            this.btFrontView.Size = new System.Drawing.Size(75, 36);
            this.btFrontView.TabIndex = 23;
            this.btFrontView.Text = "Front";
            this.btFrontView.UseVisualStyleBackColor = false;
            this.btFrontView.Click += new System.EventHandler(this.btFrontView_Click);
            // 
            // btSideView
            // 
            this.btSideView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSideView.BackColor = System.Drawing.Color.LightGray;
            this.btSideView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSideView.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btSideView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSideView.Location = new System.Drawing.Point(1738, 972);
            this.btSideView.Name = "btSideView";
            this.btSideView.Size = new System.Drawing.Size(75, 36);
            this.btSideView.TabIndex = 24;
            this.btSideView.Text = "Side";
            this.btSideView.UseVisualStyleBackColor = false;
            this.btSideView.Click += new System.EventHandler(this.btSideView_Click);
            // 
            // btTopView
            // 
            this.btTopView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btTopView.BackColor = System.Drawing.Color.LightGray;
            this.btTopView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTopView.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btTopView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btTopView.Location = new System.Drawing.Point(1819, 972);
            this.btTopView.Name = "btTopView";
            this.btTopView.Size = new System.Drawing.Size(75, 36);
            this.btTopView.TabIndex = 25;
            this.btTopView.Text = "Top";
            this.btTopView.UseVisualStyleBackColor = false;
            this.btTopView.Click += new System.EventHandler(this.btTopView_Click);
            // 
            // cbOnlyPoints
            // 
            this.cbOnlyPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbOnlyPoints.AutoSize = true;
            this.cbOnlyPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.cbOnlyPoints.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbOnlyPoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbOnlyPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbOnlyPoints.Location = new System.Drawing.Point(1787, 942);
            this.cbOnlyPoints.Name = "cbOnlyPoints";
            this.cbOnlyPoints.Size = new System.Drawing.Size(107, 24);
            this.cbOnlyPoints.TabIndex = 27;
            this.cbOnlyPoints.Text = "only points";
            this.cbOnlyPoints.UseVisualStyleBackColor = false;
            // 
            // clbXYZ
            // 
            this.clbXYZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clbXYZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.clbXYZ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbXYZ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clbXYZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clbXYZ.FormattingEnabled = true;
            this.clbXYZ.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clbXYZ.Items.AddRange(new object[] {
            "ось X",
            "ось Y",
            "ось Z"});
            this.clbXYZ.Location = new System.Drawing.Point(1808, 476);
            this.clbXYZ.Name = "clbXYZ";
            this.clbXYZ.Size = new System.Drawing.Size(82, 100);
            this.clbXYZ.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(1556, 475);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 25);
            this.label9.TabIndex = 29;
            this.label9.Text = "Поворот на угол:";
            // 
            // tbRotate
            // 
            this.tbRotate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRotate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbRotate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRotate.Location = new System.Drawing.Point(1731, 476);
            this.tbRotate.Name = "tbRotate";
            this.tbRotate.Size = new System.Drawing.Size(71, 27);
            this.tbRotate.TabIndex = 31;
            this.tbRotate.Text = "0";
            this.tbRotate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(1644, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 25);
            this.label10.TabIndex = 32;
            this.label10.Text = "Перенос:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(1747, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 25);
            this.label11.TabIndex = 33;
            this.label11.Text = "x - ";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(1747, 290);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 25);
            this.label12.TabIndex = 34;
            this.label12.Text = "y - ";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(1747, 321);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 25);
            this.label13.TabIndex = 35;
            this.label13.Text = "z - ";
            // 
            // tbMoveX
            // 
            this.tbMoveX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMoveX.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbMoveX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMoveX.Location = new System.Drawing.Point(1792, 255);
            this.tbMoveX.Name = "tbMoveX";
            this.tbMoveX.Size = new System.Drawing.Size(71, 27);
            this.tbMoveX.TabIndex = 36;
            this.tbMoveX.Text = "0";
            this.tbMoveX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbMoveY
            // 
            this.tbMoveY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMoveY.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbMoveY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMoveY.Location = new System.Drawing.Point(1792, 288);
            this.tbMoveY.Name = "tbMoveY";
            this.tbMoveY.Size = new System.Drawing.Size(71, 27);
            this.tbMoveY.TabIndex = 37;
            this.tbMoveY.Text = "0";
            this.tbMoveY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbMoveZ
            // 
            this.tbMoveZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMoveZ.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbMoveZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMoveZ.Location = new System.Drawing.Point(1792, 321);
            this.tbMoveZ.Name = "tbMoveZ";
            this.tbMoveZ.Size = new System.Drawing.Size(71, 27);
            this.tbMoveZ.TabIndex = 38;
            this.tbMoveZ.Text = "0";
            this.tbMoveZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbScaleZ
            // 
            this.tbScaleZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbScaleZ.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbScaleZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbScaleZ.Location = new System.Drawing.Point(1791, 428);
            this.tbScaleZ.Name = "tbScaleZ";
            this.tbScaleZ.Size = new System.Drawing.Size(71, 27);
            this.tbScaleZ.TabIndex = 45;
            this.tbScaleZ.Text = "1";
            this.tbScaleZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbScaleY
            // 
            this.tbScaleY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbScaleY.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbScaleY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbScaleY.Location = new System.Drawing.Point(1791, 395);
            this.tbScaleY.Name = "tbScaleY";
            this.tbScaleY.Size = new System.Drawing.Size(71, 27);
            this.tbScaleY.TabIndex = 44;
            this.tbScaleY.Text = "1";
            this.tbScaleY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbScaleX
            // 
            this.tbScaleX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbScaleX.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbScaleX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbScaleX.Location = new System.Drawing.Point(1791, 362);
            this.tbScaleX.Name = "tbScaleX";
            this.tbScaleX.Size = new System.Drawing.Size(71, 27);
            this.tbScaleX.TabIndex = 43;
            this.tbScaleX.Text = "1";
            this.tbScaleX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(1746, 428);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 25);
            this.label15.TabIndex = 42;
            this.label15.Text = "z - ";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(1746, 397);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 25);
            this.label16.TabIndex = 41;
            this.label16.Text = "y - ";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(1746, 364);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 25);
            this.label17.TabIndex = 40;
            this.label17.Text = "x - ";
            // 
            // btAction
            // 
            this.btAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAction.BackColor = System.Drawing.Color.LightGray;
            this.btAction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAction.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btAction.Location = new System.Drawing.Point(1524, 883);
            this.btAction.Name = "btAction";
            this.btAction.Size = new System.Drawing.Size(68, 53);
            this.btAction.TabIndex = 46;
            this.btAction.Text = "Action";
            this.btAction.UseVisualStyleBackColor = false;
            this.btAction.Click += new System.EventHandler(this.btAction_Click);
            this.btAction.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btAction_KeyDown);
            this.btAction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btAction_KeyPress);
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(1638, 364);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(103, 25);
            this.label25.TabIndex = 54;
            this.label25.Text = "Масштаб:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Pink;
            this.BackgroundImage = global::_3Dmodel.Properties.Resources.sakura_part11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.btAction);
            this.Controls.Add(this.tbScaleZ);
            this.Controls.Add(this.tbScaleY);
            this.Controls.Add(this.tbScaleX);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tbMoveZ);
            this.Controls.Add(this.tbMoveY);
            this.Controls.Add(this.tbMoveX);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbRotate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.clbXYZ);
            this.Controls.Add(this.cbOnlyPoints);
            this.Controls.Add(this.btTopView);
            this.Controls.Add(this.btSideView);
            this.Controls.Add(this.btFrontView);
            this.Controls.Add(this.lbPoints);
            this.Controls.Add(this.btCreateModel);
            this.Controls.Add(this.tbN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbH);
            this.Controls.Add(this.tbR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pbMain);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "3D Model";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbH;
        private System.Windows.Forms.TextBox tbR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btCreateModel;
        private System.Windows.Forms.Label lbPoints;
        private System.Windows.Forms.Button btFrontView;
        private System.Windows.Forms.Button btSideView;
        private System.Windows.Forms.Button btTopView;
        private System.Windows.Forms.CheckBox cbOnlyPoints;
        private System.Windows.Forms.CheckedListBox clbXYZ;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbRotate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbMoveX;
        private System.Windows.Forms.TextBox tbMoveY;
        private System.Windows.Forms.TextBox tbMoveZ;
        private System.Windows.Forms.TextBox tbScaleZ;
        private System.Windows.Forms.TextBox tbScaleY;
        private System.Windows.Forms.TextBox tbScaleX;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btAction;
        private System.Windows.Forms.Label label25;
    }
}

