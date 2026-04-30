namespace SimplePaint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAppName = new Label();
            groupBox1 = new GroupBox();
            btnCircle = new Button();
            btnRectangle = new Button();
            btnLine = new Button();
            groupBox2 = new GroupBox();
            cmbColor = new ComboBox();
            groupBox3 = new GroupBox();
            trbLineWidth = new TrackBar();
            btnOpenFile = new Button();
            btnSaveFile = new Button();
            picCanvas = new PictureBox();
            pnlScroll = new Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trbLineWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
            pnlScroll.SuspendLayout();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("한컴 말랑말랑 Bold", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.ForeColor = Color.DodgerBlue;
            lblAppName.Location = new Point(21, 19);
            lblAppName.Margin = new Padding(2, 0, 2, 0);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(246, 49);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Simple Paint";
            lblAppName.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCircle);
            groupBox1.Controls.Add(btnRectangle);
            groupBox1.Controls.Add(btnLine);
            groupBox1.Location = new Point(31, 81);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(246, 109);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "도형 선택";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnCircle
            // 
            btnCircle.Font = new Font("한컴 말랑말랑 Regular", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnCircle.Image = Properties.Resources.KakaoTalk_20260430_100205471_01;
            btnCircle.ImageAlign = ContentAlignment.TopCenter;
            btnCircle.Location = new Point(156, 25);
            btnCircle.Margin = new Padding(2);
            btnCircle.Name = "btnCircle";
            btnCircle.Size = new Size(68, 63);
            btnCircle.TabIndex = 6;
            btnCircle.Text = "원";
            btnCircle.TextAlign = ContentAlignment.BottomCenter;
            btnCircle.UseVisualStyleBackColor = true;
            btnCircle.Click += btnCircle_Click;
            // 
            // btnRectangle
            // 
            btnRectangle.Font = new Font("한컴 말랑말랑 Regular", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnRectangle.Image = Properties.Resources.KakaoTalk_20260430_100205471;
            btnRectangle.ImageAlign = ContentAlignment.TopCenter;
            btnRectangle.Location = new Point(84, 25);
            btnRectangle.Margin = new Padding(2);
            btnRectangle.Name = "btnRectangle";
            btnRectangle.Size = new Size(68, 63);
            btnRectangle.TabIndex = 5;
            btnRectangle.Text = "사각형";
            btnRectangle.TextAlign = ContentAlignment.BottomCenter;
            btnRectangle.UseVisualStyleBackColor = true;
            btnRectangle.Click += button2_Click_1;
            // 
            // btnLine
            // 
            btnLine.Font = new Font("한컴 말랑말랑 Regular", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnLine.Image = Properties.Resources.KakaoTalk_20260430_100205471_02;
            btnLine.ImageAlign = ContentAlignment.TopCenter;
            btnLine.Location = new Point(12, 25);
            btnLine.Margin = new Padding(2);
            btnLine.Name = "btnLine";
            btnLine.Size = new Size(68, 63);
            btnLine.TabIndex = 4;
            btnLine.Text = "직선";
            btnLine.TextAlign = ContentAlignment.BottomCenter;
            btnLine.UseVisualStyleBackColor = true;
            btnLine.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbColor);
            groupBox2.Location = new Point(291, 84);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(153, 94);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "색 선택";
            // 
            // cmbColor
            // 
            cmbColor.FormattingEnabled = true;
            cmbColor.Items.AddRange(new object[] { "Black 검정", "Red 빨강", "Blue 파랑", "Green 녹색" });
            cmbColor.Location = new Point(15, 37);
            cmbColor.Margin = new Padding(2);
            cmbColor.Name = "cmbColor";
            cmbColor.Size = new Size(119, 23);
            cmbColor.TabIndex = 7;
            cmbColor.SelectedIndexChanged += cmbColor_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(trbLineWidth);
            groupBox3.Location = new Point(458, 84);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(162, 94);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "선 두께";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // trbLineWidth
            // 
            trbLineWidth.Location = new Point(4, 37);
            trbLineWidth.Margin = new Padding(2);
            trbLineWidth.Name = "trbLineWidth";
            trbLineWidth.Size = new Size(154, 45);
            trbLineWidth.TabIndex = 8;
            // 
            // btnOpenFile
            // 
            btnOpenFile.BackColor = SystemColors.Desktop;
            btnOpenFile.Font = new Font("한컴 말랑말랑 Regular", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnOpenFile.Location = new Point(634, 103);
            btnOpenFile.Margin = new Padding(2);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(82, 75);
            btnOpenFile.TabIndex = 0;
            btnOpenFile.Tag = "";
            btnOpenFile.Text = "열기";
            btnOpenFile.UseVisualStyleBackColor = false;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // btnSaveFile
            // 
            btnSaveFile.BackColor = Color.LightGoldenrodYellow;
            btnSaveFile.Font = new Font("한컴 말랑말랑 Regular", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnSaveFile.Location = new Point(720, 103);
            btnSaveFile.Margin = new Padding(2);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(83, 75);
            btnSaveFile.TabIndex = 3;
            btnSaveFile.Text = "저장";
            btnSaveFile.UseVisualStyleBackColor = false;
            btnSaveFile.Click += button2_Click;
            // 
            // picCanvas
            // 
            picCanvas.BackColor = Color.White;
            picCanvas.Location = new Point(21, 194);
            picCanvas.Margin = new Padding(2);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(786, 350);
            picCanvas.SizeMode = PictureBoxSizeMode.AutoSize;
            picCanvas.TabIndex = 7;
            picCanvas.TabStop = false;
            picCanvas.Click += picCanvas_Click;
            picCanvas.MouseDown += picCanvas_MouseDown;
            // 
            // pnlScroll
            // 
            pnlScroll.AutoScroll = true;
            pnlScroll.Controls.Add(picCanvas);
            pnlScroll.Dock = DockStyle.Fill;
            pnlScroll.Location = new Point(0, 0);
            pnlScroll.Name = "pnlScroll";
            pnlScroll.Size = new Size(828, 555);
            pnlScroll.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 555);
            Controls.Add(btnSaveFile);
            Controls.Add(btnOpenFile);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblAppName);
            Controls.Add(pnlScroll);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Sinple Paint v1.0";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trbLineWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            pnlScroll.ResumeLayout(false);
            pnlScroll.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnOpenFile;
        private Button btnSaveFile;
        private Button btnLine;
        private PictureBox picCanvas;
        private ComboBox cmbColor;
        private TrackBar trbLineWidth;
        private Button btnCircle;
        private Button btnRectangle;
        private Panel pnlScroll;
    }
}
