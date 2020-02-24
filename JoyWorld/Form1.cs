using System;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Input;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Drawing.Drawing2D;

namespace JoyWorld {
    public partial class Form1 : Form {
        private DateTime timeOld;
        private BufferedGraphicsContext bfrdC;
        private BufferedGraphics bfrdG;
        private string keyInfo;
        private string fpsInfo;
        private float fpsRefreshTime = 0;

        // game contents
        private List<BouncingBall> balls = new List<BouncingBall>();

        public Form1() {
            InitializeComponent();
            this.InitGame();                       // 초기화
        }

        // 초기화
        private void InitGame() {
            this.bfrdC = BufferedGraphicsManager.Current;
            this.RegenBuffer();
            this.GenerateBalls();
            this.timeOld = DateTime.Now;        // 최초 시간 측정
        }

        // 정리
        private void FreeGame() {
            if (this.bfrdG != null)
                this.bfrdG.Dispose();
            this.bfrdC.Dispose();
        }

        // 입력 처리
        private void ProcessInput() {
            this.keyInfo = string.Empty;
            if (Keyboard.IsKeyDown(Key.W))
                this.keyInfo += "W ";
            if (Keyboard.IsKeyDown(Key.S))
                this.keyInfo += "S ";
            if (Keyboard.IsKeyDown(Key.A))
                this.keyInfo += "A ";
            if (Keyboard.IsKeyDown(Key.D))
                this.keyInfo += "D ";
        }

        // 프레임 갱신
        private void UpdateFrame(float timeDelta) {
            this.fpsRefreshTime += timeDelta;
            if (fpsRefreshTime >= 0.1) {
                float fps = 1.0f / timeDelta;
                this.fpsInfo = string.Format("{0:0000.0} (FPS)", fps);
                fpsRefreshTime = 0;
            }

            this.balls.ForEach(ball => ball.UpdateTime(timeDelta));
        }

        // 렌더
        private void Render() {
            this.DrawBuffer(this.bfrdG.Graphics, this.balls);  // 버퍼에 게임 컨텐츠 드로우       
            this.bfrdG.Render();
        }

        // 버퍼에 드로우
        private void DrawBuffer(Graphics g, List<BouncingBall> balls) {
            g.Clear(Color.White);
            balls.ForEach(
               ball => {
                   if (ball.ellipseOrRect)
                       g.FillEllipse(ball.brush, ball.pos.X - ball.radius.X, ball.pos.Y - ball.radius.Y, 2 * ball.radius.X, 2 * ball.radius.Y);
                   else
                       g.FillRectangle(ball.brush, ball.pos.X - ball.radius.X, ball.pos.Y - ball.radius.Y, 2 * ball.radius.X, 2 * ball.radius.Y);
               });
            g.DrawString(this.fpsInfo, SystemFonts.DefaultFont, Brushes.Black, 0, 0);
            g.DrawString(this.keyInfo, SystemFonts.DefaultFont, Brushes.Black, 0, 20);
        }

        // 버퍼 재생성
        private void RegenBuffer() {
            BouncingBall.WindowSize = this.pbxDraw.ClientSize;
            this.bfrdC.MaximumBuffer = new Size(BouncingBall.WindowSize.Width, BouncingBall.WindowSize.Height);

            if (this.bfrdG != null)
                this.bfrdG.Dispose();
            this.bfrdG = this.bfrdC.Allocate(this.pbxDraw.CreateGraphics(), new Rectangle(0, 0, BouncingBall.WindowSize.Width, BouncingBall.WindowSize.Height));
        }

        // 볼 생성
        private void GenerateBalls() {
            int ballNum = (int)this.numBallCount.Value;
            this.balls = Enumerable.Range(0, ballNum).Select(i => new BouncingBall()).ToList();
        }

        // event handler
        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            this.FreeGame();
        }

        private void btnGenerate_Click(object sender, EventArgs e) {
            this.GenerateBalls();
        }

        private void pbxDraw_Layout(object sender, LayoutEventArgs e) {
            this.RegenBuffer();
        }

        private void Form1_Shown(object sender, EventArgs e) {
            while (true) {
                Application.DoEvents();

                DateTime timeNow = DateTime.Now; // 시간 측정
                float timeDelta = (float)(timeNow - this.timeOld).TotalSeconds;   // 경과시간 계산
                this.timeOld = timeNow;          // 측정 시간 보관

                this.ProcessInput();             // 입력 처리
                this.UpdateFrame(timeDelta);     // 프레임 갱신
                this.Render();                   // 화면 드로우

                //Thread.Sleep(1);                 // CPU 휴식
            }
        }
    }
}