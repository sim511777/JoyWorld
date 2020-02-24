namespace JoyWorld {
   partial class Form1 {
      /// <summary>
      /// 필수 디자이너 변수입니다.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// 사용 중인 모든 리소스를 정리합니다.
      /// </summary>
      /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
      protected override void Dispose(bool disposing) {
         if (disposing && (components != null)) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form 디자이너에서 생성한 코드

      /// <summary>
      /// 디자이너 지원에 필요한 메서드입니다.
      /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
      /// </summary>
      private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.numRadiusSpeedMax = new System.Windows.Forms.NumericUpDown();
            this.numRadiusSpeedMin = new System.Windows.Forms.NumericUpDown();
            this.numRadiusMax = new System.Windows.Forms.NumericUpDown();
            this.numRadiusMin = new System.Windows.Forms.NumericUpDown();
            this.numSpeedMax = new System.Windows.Forms.NumericUpDown();
            this.numSpeedMin = new System.Windows.Forms.NumericUpDown();
            this.numBallCount = new System.Windows.Forms.NumericUpDown();
            this.pbxDraw = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRadiusSpeedMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRadiusSpeedMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRadiusMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRadiusMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeedMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeedMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBallCount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Controls.Add(this.numRadiusSpeedMax);
            this.panel1.Controls.Add(this.numRadiusSpeedMin);
            this.panel1.Controls.Add(this.numRadiusMax);
            this.panel1.Controls.Add(this.numRadiusMin);
            this.panel1.Controls.Add(this.numSpeedMax);
            this.panel1.Controls.Add(this.numSpeedMin);
            this.panel1.Controls.Add(this.numBallCount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 591);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "반지름 속도 MAX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "반지름 속도 MIN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "반지름 MAX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "반지름 MIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "볼 속도 MAX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "볼 속도 MIN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "볼 개수";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(13, 200);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(166, 23);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Gen";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // numRadiusSpeedMax
            // 
            this.numRadiusSpeedMax.Location = new System.Drawing.Point(117, 173);
            this.numRadiusSpeedMax.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numRadiusSpeedMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRadiusSpeedMax.Name = "numRadiusSpeedMax";
            this.numRadiusSpeedMax.Size = new System.Drawing.Size(62, 21);
            this.numRadiusSpeedMax.TabIndex = 0;
            this.numRadiusSpeedMax.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numRadiusSpeedMin
            // 
            this.numRadiusSpeedMin.Location = new System.Drawing.Point(117, 146);
            this.numRadiusSpeedMin.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numRadiusSpeedMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRadiusSpeedMin.Name = "numRadiusSpeedMin";
            this.numRadiusSpeedMin.Size = new System.Drawing.Size(62, 21);
            this.numRadiusSpeedMin.TabIndex = 0;
            this.numRadiusSpeedMin.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // numRadiusMax
            // 
            this.numRadiusMax.Location = new System.Drawing.Point(117, 119);
            this.numRadiusMax.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numRadiusMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRadiusMax.Name = "numRadiusMax";
            this.numRadiusMax.Size = new System.Drawing.Size(62, 21);
            this.numRadiusMax.TabIndex = 0;
            this.numRadiusMax.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numRadiusMin
            // 
            this.numRadiusMin.Location = new System.Drawing.Point(117, 92);
            this.numRadiusMin.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numRadiusMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRadiusMin.Name = "numRadiusMin";
            this.numRadiusMin.Size = new System.Drawing.Size(62, 21);
            this.numRadiusMin.TabIndex = 0;
            this.numRadiusMin.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // numSpeedMax
            // 
            this.numSpeedMax.Location = new System.Drawing.Point(117, 65);
            this.numSpeedMax.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSpeedMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSpeedMax.Name = "numSpeedMax";
            this.numSpeedMax.Size = new System.Drawing.Size(62, 21);
            this.numSpeedMax.TabIndex = 0;
            this.numSpeedMax.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numSpeedMin
            // 
            this.numSpeedMin.Location = new System.Drawing.Point(117, 38);
            this.numSpeedMin.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSpeedMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSpeedMin.Name = "numSpeedMin";
            this.numSpeedMin.Size = new System.Drawing.Size(62, 21);
            this.numSpeedMin.TabIndex = 0;
            this.numSpeedMin.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // numBallCount
            // 
            this.numBallCount.Location = new System.Drawing.Point(117, 11);
            this.numBallCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBallCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBallCount.Name = "numBallCount";
            this.numBallCount.Size = new System.Drawing.Size(62, 21);
            this.numBallCount.TabIndex = 0;
            this.numBallCount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // pbxDraw
            // 
            this.pbxDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxDraw.Location = new System.Drawing.Point(194, 0);
            this.pbxDraw.Name = "pbxDraw";
            this.pbxDraw.Size = new System.Drawing.Size(664, 591);
            this.pbxDraw.TabIndex = 1;
            this.pbxDraw.Layout += new System.Windows.Forms.LayoutEventHandler(this.pbxDraw_Layout);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 591);
            this.Controls.Add(this.pbxDraw);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRadiusSpeedMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRadiusSpeedMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRadiusMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRadiusMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeedMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeedMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBallCount)).EndInit();
            this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Button btnGenerate;
      private System.Windows.Forms.NumericUpDown numBallCount;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.NumericUpDown numRadiusSpeedMax;
      private System.Windows.Forms.NumericUpDown numRadiusSpeedMin;
      private System.Windows.Forms.NumericUpDown numRadiusMax;
      private System.Windows.Forms.NumericUpDown numRadiusMin;
      private System.Windows.Forms.NumericUpDown numSpeedMax;
      private System.Windows.Forms.NumericUpDown numSpeedMin;
        private System.Windows.Forms.Panel pbxDraw;
    }
}

