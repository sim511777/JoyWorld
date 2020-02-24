using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace JoyWorld {
   public class BouncingBall {
      private static Random rnd = new Random();
      public static float rndSign() { return (rnd.Next(2) == 1) ? 1f : -1f; }
      public static int posSpeedMin       = 50;
      public static int posSpeedMax       = 200;
      public static int radiusMin         = 20;
      public static int radiusMid         = 60;
      public static int radiusMax         = 100;
      public static int radiusSpeedMin    = 20;
      public static int radiusSpeedMax    = 100;
      public static Size WindowSize { set; get; }
      public static List<BouncingBall> RegenerateBalls(int posSpeedMin, int posSpeedMax, int radiusMin, int radiusMax, int radiusSpeedMin, int radiusSpeedMax, int ballCount) {
         BouncingBall.posSpeedMin     = posSpeedMin;
         BouncingBall.posSpeedMax     = posSpeedMax;
         BouncingBall.radiusMin       = radiusMin  ;
         BouncingBall.radiusMax       = radiusMax  ;
         BouncingBall.radiusMid       = (BouncingBall.radiusMin+BouncingBall.radiusMax)/2;
         BouncingBall.radiusSpeedMin  = radiusSpeedMin;
         BouncingBall.radiusSpeedMax  = radiusSpeedMax;

         List<BouncingBall> ballList = new List<BouncingBall>();
         foreach (var i in Enumerable.Range(0, ballCount)) {
            if (rnd.Next() % 2 == 0) {
               ballList.Add(new BouncingBallRect());
            } else {
               ballList.Add(new BouncingBallEllipse());
            }
         }

         return ballList;
      }

      public PointF pos;            // 중심좌표
      public PointF posSpeed;         // 중심좌표 이동 속도
      public PointF radius;         // 반지름
      public PointF radiusStart;      // 시작반지름
      public PointF radiusEnd;        // 목표반지름
      public PointF radiusSpeed;      // 반지름 속도
      public Brush brush;           // 컬러
      public bool ellipseOrRect;    // 타원인지 사각형인지

      public BouncingBall() {
         // pos 생성
         this.pos = new PointF(rnd.Next(WindowSize.Width), rnd.Next(WindowSize.Height));
         // posSpeed 생성
         this.posSpeed = new PointF(rnd.Next(posSpeedMin, posSpeedMax)*rndSign(), rnd.Next(posSpeedMin, posSpeedMax)*rndSign());
         // radius 생성
         this.radius = new PointF(radiusMid, radiusMid);
         this.radiusStart = this.radius;
         // radiusTarget 생성
         this.radiusEnd = new PointF(rnd.Next(radiusMid,radiusMax), rnd.Next(radiusMid,radiusMax));
         // radisuSpeed 생성
         this.radiusSpeed = new PointF(rnd.Next(radiusSpeedMin, radiusSpeedMax), rnd.Next(radiusSpeedMin, radiusSpeedMax));
         // 컬러
         this.brush = new SolidBrush(Color.FromArgb(255, rnd.Next(256), rnd.Next(256), rnd.Next(256)));
      }

      virtual public void Draw(Graphics g) {
         g.FillEllipse(this.brush, this.pos.X - this.radius.X, this.pos.Y - this.radius.Y, 2 * this.radius.X, 2 * this.radius.Y);
      }

      // 시간 갱신
      public void UpdateTime(float dtime) {
         pos.X += posSpeed.X*dtime;
         if (pos.X < 0) {
            pos.X = -pos.X;
            posSpeed.X = rnd.Next(posSpeedMin, posSpeedMax);
         } else if (pos.X >= WindowSize.Width) {
            pos.X = WindowSize.Width*2-pos.X-2;
            posSpeed.X = rnd.Next(posSpeedMin, posSpeedMax)*-1;
         }

         pos.Y += posSpeed.Y*dtime;
         if (pos.Y < 0) {
            pos.Y = -pos.Y;
            posSpeed.Y = rnd.Next(posSpeedMin, posSpeedMax);
         } else if (pos.Y >= WindowSize.Height) {
            pos.Y = WindowSize.Height*2-pos.Y-2;
            posSpeed.Y = rnd.Next(posSpeedMin, posSpeedMax)*-1;
         }

         radius.X += radiusSpeed.X*dtime;
         if (radius.X < radiusEnd.X && radiusSpeed.X < 0) {
            radius.X = radiusEnd.X;
            radiusStart.X = radius.X;
            radiusEnd.X = rnd.Next(radiusMid,radiusMax);
            radiusSpeed.X = rnd.Next(radiusSpeedMin, radiusSpeedMax);
         } else if (radius.X > radiusEnd.X && radiusSpeed.X > 0) {
            radius.X = radiusEnd.X;
            radiusStart.X = radius.X;
            radiusEnd.X = rnd.Next(radiusMin, radiusMid);
            radiusSpeed.X = rnd.Next(radiusSpeedMin, radiusSpeedMax)*-1;
         }

         radius.Y += radiusSpeed.Y*dtime;
         if (radius.Y < radiusEnd.Y && radiusSpeed.Y < 0) {
            radius.Y = radiusEnd.Y;
            radiusStart.Y = radius.Y;
            radiusEnd.Y = rnd.Next(radiusMid,radiusMax);
            radiusSpeed.Y = rnd.Next(radiusSpeedMin, radiusSpeedMax);
         } else if (radius.Y > radiusEnd.Y && radiusSpeed.Y > 0) {
            radius.Y = radiusEnd.Y;
            radiusStart.Y = radius.Y;
            radiusEnd.Y = rnd.Next(radiusMin, radiusMid);
            radiusSpeed.Y = rnd.Next(radiusSpeedMin, radiusSpeedMax)*-1;
         }
      }
   }

   public class BouncingBallRect : BouncingBall {
      override public void Draw(Graphics g) {
         g.FillRectangle(this.brush, this.pos.X-this.radius.X, this.pos.Y-this.radius.Y, 2*this.radius.X, 2*this.radius.Y);
      }
   }
   public class BouncingBallEllipse : BouncingBall {
      override public void Draw(Graphics g) {
         g.FillEllipse(this.brush, this.pos.X-this.radius.X, this.pos.Y-this.radius.Y, 2*this.radius.X, 2*this.radius.Y);
      }
   }
}
