using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace SimplePaint
{

    public partial class Form1 : Form
    {
        enum ToolType { Line, Rectangle, Circle }  // 사용할 도형타입
        private Bitmap canvasBitmap;          // 실제 그림이 저장되는 비트맵
        private Graphics canvasGraphics;      // 비트맵 위에 그리기 위한 객체
        private bool isDrawing = false;       // 현재 드래그 중인지 여부
        private Point startPoint;             // 드래그 시작점
        private Point endPoint;               // 드래그 끝점
        private ToolType currentTool = ToolType.Line;  // 현재 선택된 도형
        private Color currentColor = Color.Black;      // 현재 색상
        private int currentLineWidth = 2;              // 현재선두께
        ToolType currentToolType = ToolType.Line;
        private double zoomFactor = 1.0; // 확대/축소 비율 (1.0 = 100%)

        public Form1()
        {
            InitializeComponent();

            //캔버스 초기화

            canvasBitmap = new Bitmap(picCanvas.Width, picCanvas.Height);
            canvasGraphics = Graphics.FromImage(canvasBitmap);
            canvasGraphics.Clear(Color.White);   // 캔버스를 흰색으로 초기화

            picCanvas.Image = canvasBitmap;   // 그린 그림을 화면(PictureBox)에 표시

            picCanvas.MouseDown += PicCanvas_MouseDown;
            picCanvas.MouseMove += picCanvas_MouseMove;
            picCanvas.MouseUp += PicCanvas_MouseUp;

            picCanvas.Paint += PicCanvas_Paint;

            btnLine.Click += btnLine_Click;
            btnRectangle.Click += btnRectangle_Click;
            btnCircle.Click += btnCircle_Click;

            cmbColor.SelectedIndexChanged += cmbColor_SelectedIndexChanged;
            cmbColor.SelectedIndex = 0;

            trbLineWidth.Minimum = 1;
            trbLineWidth.Maximum = 10;
            trbLineWidth.Value = 2;
            trbLineWidth.ValueChanged += trbLineWidth_ValueChanged;

            btnSaveFile.Click += btnSaveFile_Click;
            btnOpenFile.Click += btnOpenFile_Click;

        }

        private void TrbLineWidth_ValueChanged(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnRectangle_Click(object? sender, EventArgs e)
        {
            currentTool = ToolType.Rectangle;
        }

        private void PicCanvas_Paint(object? sender, PaintEventArgs e)
        {
            if (!isDrawing) return;
            
            // 점선펜(미리보기용)
            using (Pen previewPen = new Pen(currentColor, currentLineWidth))

            {
                previewPen.DashStyle = DashStyle.Dash;
                DrawShape(e.Graphics, previewPen, startPoint, endPoint);
            }
        }

        private void btnLine_Click(object? sender, EventArgs e)
        {
            currentTool = ToolType.Line;
        }

        private void PicCanvas_MouseUp(object? sender, MouseEventArgs e)
        {
            if (!isDrawing) return;     // 그림그리기와상관없는마우스움직임은무시
            isDrawing = false;          // 드래그종료
            endPoint = e.Location;// 실제비트맵에도형그리기(확정)

            using (Pen pen = new Pen(currentColor, currentLineWidth))
            {
                DrawShape(canvasGraphics, pen, startPoint, endPoint);
            }
            picCanvas.Invalidate();     // 다시그려서결과반영, Paint 이벤트발생
        }

        private void DrawShape(Graphics g, Pen pen, Point p1, Point p2)
        {
            Rectangle rect = GetRectangle(p1, p2);
            switch (currentTool)
            {
                case ToolType.Line:
                    g.DrawLine(pen, p1, p2);
                    break;
                case ToolType.Rectangle:
                    g.DrawRectangle(pen, rect);
                    break;
                case ToolType.Circle:
                    g.DrawEllipse(pen, rect);
                    break;
            }
        }

        private Rectangle GetRectangle(Point p1, Point p2)
        {
            return new Rectangle(
                Math.Min(p1.X, p2.X),
                Math.Min(p1.Y, p2.Y),
                Math.Abs(p1.X - p2.X),
                Math.Abs(p1.Y - p2.Y));
        }

        private void picCanvas_MouseMove(object? sender, MouseEventArgs e)
        {
            if (!isDrawing) return;       // 그림그리기와상관없는마우스움직임은무시
            endPoint = e.Location;        // 현재위치갱신

            // picCanvas를다시그려라(Paint 이벤트를발생시킨다)
            picCanvas.Invalidate();       // 화면다시그리기(미리보기)
        }

        private void PicCanvas_MouseDown(object? sender, MouseEventArgs e)
        {
            isDrawing = true;             // 드래그시작
            startPoint = e.Location;      // 시작점저장
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbColor.SelectedIndex)
            {
                case 0: // Black 검정
                    currentColor = Color.Black;
                    break;
                case 1: // Red 빨강
                    currentColor = Color.Red;
                    break;
                case 2: // Blue 파랑
                    currentColor = Color.Blue;
                    break;
                case 3: // Green 녹색
                    currentColor = Color.Green;
                    break;
                default:
                    currentColor = Color.Black;
                    break;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void picCanvas_Click(object sender, EventArgs e)
        {

        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            currentTool = ToolType.Circle;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // 1. 기존 리소스 안전하게 해제
                    picCanvas.Image = null; // PictureBox 연결 끊기
                    if (canvasGraphics != null) canvasGraphics.Dispose();
                    if (canvasBitmap != null) canvasBitmap.Dispose();

                    // 2. 파일로부터 이미지 로드 (파일 잠금 방지를 위해 복사본 사용 추천)
                    using (Image tempImg = Image.FromFile(openFileDialog.FileName))
                    {
                        // 원본 크기의 새 비트맵 생성
                        canvasBitmap = new Bitmap(tempImg.Width, tempImg.Height);
                        canvasGraphics = Graphics.FromImage(canvasBitmap);

                        // 캔버스에 그리기
                        canvasGraphics.DrawImage(tempImg, 0, 0);
                    }

                    // 3. 배율 초기화 및 캔버스 크기 업데이트
                    zoomFactor = 1.0;

                    // 크기 변경 메서드 호출 전 비트맵이 확실히 있는지 체크
                    if (canvasBitmap != null)
                    {
                        UpdateCanvasSize(); // 여기서 picCanvas.Width/Height가 변경됨
                        picCanvas.Image = canvasBitmap;
                    }
                }
            }
        }

        private void UpdateCanvasSize()
        {
            if (canvasBitmap == null) return;

            // 1. 계산된 크기를 변수에 먼저 담습니다.
            int newWidth = (int)(canvasBitmap.Width * zoomFactor);
            int newHeight = (int)(canvasBitmap.Height * zoomFactor);

            // 2. 컨트롤의 크기가 최소 1 이상이 되도록 보장합니다. (0이 되면 오류 발생 가능)
            if (newWidth < 1) newWidth = 1;
            if (newHeight < 1) newHeight = 1;

            // 3. GDI+ 컨트롤의 최대 크기 제한 (보통 32,767픽셀)을 넘지 않도록 제한합니다.
            const int MaxSize = 30000;
            if (newWidth > MaxSize) newWidth = MaxSize;
            if (newHeight > MaxSize) newHeight = MaxSize;

            // 4. 안전하게 적용
            picCanvas.Width = newWidth;
            picCanvas.Height = newHeight;

            picCanvas.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void trbLineWidth_ValueChanged(object sender, EventArgs e)
        {
            currentLineWidth = trbLineWidth.Value;
        }
        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                // 파일 형식 선택창을 없애고, 파일 이름만 입력받도록 설정
                saveFileDialog.Title = "이미지 3종 세트(PNG, JPG, BMP)로 저장하기";
                saveFileDialog.FileName = "MyDrawing"; // 기본 파일명
                saveFileDialog.Filter = "All Files|*.*"; // 모든 파일로 표시

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // 사용자가 입력한 경로에서 확장자를 뺀 순수 파일 경로와 이름을 가져옵니다.
                        // 예: C:\Photos\Test.png -> C:\Photos\Test
                        string filePathWithoutExt = System.IO.Path.ChangeExtension(saveFileDialog.FileName, null);

                        // 1. PNG 저장
                        canvasBitmap.Save(filePathWithoutExt + ".png", ImageFormat.Png);

                        // 2. JPG 저장
                        canvasBitmap.Save(filePathWithoutExt + ".jpg", ImageFormat.Jpeg);

                        // 3. BMP 저장
                        canvasBitmap.Save(filePathWithoutExt + ".bmp", ImageFormat.Bmp);

                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("저장 중 오류가 발생했습니다: " + ex.Message);
                    }
                }
            }
        }
       

        // 확대 버튼 예시
        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            zoomFactor += 0.1; // 10%씩 확대
            UpdateCanvasSize();
        }

        // 축소 버튼 예시
        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            if (zoomFactor > 0.2) // 최소 크기 제한
            {
                zoomFactor -= 0.1;
                UpdateCanvasSize();
            }
        }


    }
    }

   

