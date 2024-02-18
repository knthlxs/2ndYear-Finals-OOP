namespace FinalsOOP {
    partial class ExerciseForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExerciseForm));
            this.pbQuestion = new System.Windows.Forms.PictureBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAnswer1 = new System.Windows.Forms.Button();
            this.btnAnswer2 = new System.Windows.Forms.Button();
            this.btnAnswer3 = new System.Windows.Forms.Button();
            this.btnAnswer4 = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblCurrentScore = new System.Windows.Forms.Label();
            this.lblCurrentScoreVal = new System.Windows.Forms.Label();
            this.lblTimeRemainingVal = new System.Windows.Forms.Label();
            this.lblTimeRemaining = new System.Windows.Forms.Label();
            this.lblPassingScoreVal = new System.Windows.Forms.Label();
            this.lblPassingScore = new System.Windows.Forms.Label();
            this.lblNumTryVal = new System.Windows.Forms.Label();
            this.lblNumTry = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // pbQuestion
            // 
            this.pbQuestion.BackColor = System.Drawing.Color.White;
            this.pbQuestion.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbQuestion.ErrorImage")));
            this.pbQuestion.Image = ((System.Drawing.Image)(resources.GetObject("pbQuestion.Image")));
            this.pbQuestion.Location = new System.Drawing.Point(76, 120);
            this.pbQuestion.Name = "pbQuestion";
            this.pbQuestion.Size = new System.Drawing.Size(680, 318);
            this.pbQuestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQuestion.TabIndex = 4;
            this.pbQuestion.TabStop = false;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.Blue;
            this.lblQuestion.Location = new System.Drawing.Point(72, 488);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(680, 31);
            this.lblQuestion.TabIndex = 5;
            this.lblQuestion.Text = "Question";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(66, 53);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(690, 55);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "CHECK YOUR KNOWLEDGE";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAnswer1
            // 
            this.btnAnswer1.Location = new System.Drawing.Point(76, 553);
            this.btnAnswer1.Name = "btnAnswer1";
            this.btnAnswer1.Size = new System.Drawing.Size(291, 47);
            this.btnAnswer1.TabIndex = 0;
            this.btnAnswer1.Text = "button1";
            this.btnAnswer1.UseVisualStyleBackColor = true;
            this.btnAnswer1.Click += new System.EventHandler(this.checkAnswer);
            // 
            // btnAnswer2
            // 
            this.btnAnswer2.Location = new System.Drawing.Point(76, 653);
            this.btnAnswer2.Name = "btnAnswer2";
            this.btnAnswer2.Size = new System.Drawing.Size(291, 47);
            this.btnAnswer2.TabIndex = 1;
            this.btnAnswer2.Text = "button2";
            this.btnAnswer2.UseVisualStyleBackColor = true;
            this.btnAnswer2.Click += new System.EventHandler(this.checkAnswer);
            // 
            // btnAnswer3
            // 
            this.btnAnswer3.Location = new System.Drawing.Point(465, 553);
            this.btnAnswer3.Name = "btnAnswer3";
            this.btnAnswer3.Size = new System.Drawing.Size(291, 47);
            this.btnAnswer3.TabIndex = 2;
            this.btnAnswer3.Text = "button3";
            this.btnAnswer3.UseVisualStyleBackColor = true;
            this.btnAnswer3.Click += new System.EventHandler(this.checkAnswer);
            // 
            // btnAnswer4
            // 
            this.btnAnswer4.Location = new System.Drawing.Point(465, 653);
            this.btnAnswer4.Name = "btnAnswer4";
            this.btnAnswer4.Size = new System.Drawing.Size(291, 47);
            this.btnAnswer4.TabIndex = 3;
            this.btnAnswer4.Text = "button4";
            this.btnAnswer4.UseVisualStyleBackColor = true;
            this.btnAnswer4.Click += new System.EventHandler(this.checkAnswer);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(72, 454);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(51, 20);
            this.lblNumber.TabIndex = 11;
            this.lblNumber.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblCurrentScore
            // 
            this.lblCurrentScore.AutoSize = true;
            this.lblCurrentScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentScore.Location = new System.Drawing.Point(559, 741);
            this.lblCurrentScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentScore.Name = "lblCurrentScore";
            this.lblCurrentScore.Size = new System.Drawing.Size(142, 24);
            this.lblCurrentScore.TabIndex = 12;
            this.lblCurrentScore.Text = "Current Score : ";
            // 
            // lblCurrentScoreVal
            // 
            this.lblCurrentScoreVal.AutoSize = true;
            this.lblCurrentScoreVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentScoreVal.ForeColor = System.Drawing.Color.Green;
            this.lblCurrentScoreVal.Location = new System.Drawing.Point(724, 741);
            this.lblCurrentScoreVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentScoreVal.Name = "lblCurrentScoreVal";
            this.lblCurrentScoreVal.Size = new System.Drawing.Size(20, 24);
            this.lblCurrentScoreVal.TabIndex = 13;
            this.lblCurrentScoreVal.Text = "0";
            // 
            // lblTimeRemainingVal
            // 
            this.lblTimeRemainingVal.AutoSize = true;
            this.lblTimeRemainingVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeRemainingVal.ForeColor = System.Drawing.Color.Red;
            this.lblTimeRemainingVal.Location = new System.Drawing.Point(213, 741);
            this.lblTimeRemainingVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimeRemainingVal.Name = "lblTimeRemainingVal";
            this.lblTimeRemainingVal.Size = new System.Drawing.Size(60, 24);
            this.lblTimeRemainingVal.TabIndex = 14;
            this.lblTimeRemainingVal.Text = "label1";
            // 
            // lblTimeRemaining
            // 
            this.lblTimeRemaining.AutoSize = true;
            this.lblTimeRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeRemaining.Location = new System.Drawing.Point(34, 741);
            this.lblTimeRemaining.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimeRemaining.Name = "lblTimeRemaining";
            this.lblTimeRemaining.Size = new System.Drawing.Size(164, 24);
            this.lblTimeRemaining.TabIndex = 15;
            this.lblTimeRemaining.Text = "Time Remaining : ";
            // 
            // lblPassingScoreVal
            // 
            this.lblPassingScoreVal.AutoSize = true;
            this.lblPassingScoreVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassingScoreVal.ForeColor = System.Drawing.Color.Orange;
            this.lblPassingScoreVal.Location = new System.Drawing.Point(724, 776);
            this.lblPassingScoreVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassingScoreVal.Name = "lblPassingScoreVal";
            this.lblPassingScoreVal.Size = new System.Drawing.Size(20, 24);
            this.lblPassingScoreVal.TabIndex = 17;
            this.lblPassingScoreVal.Text = "7";
            // 
            // lblPassingScore
            // 
            this.lblPassingScore.AutoSize = true;
            this.lblPassingScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassingScore.Location = new System.Drawing.Point(494, 776);
            this.lblPassingScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassingScore.Name = "lblPassingScore";
            this.lblPassingScore.Size = new System.Drawing.Size(210, 24);
            this.lblPassingScore.TabIndex = 16;
            this.lblPassingScore.Text = "Score needed to pass : ";
            // 
            // lblNumTryVal
            // 
            this.lblNumTryVal.AutoSize = true;
            this.lblNumTryVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumTryVal.ForeColor = System.Drawing.Color.Black;
            this.lblNumTryVal.Location = new System.Drawing.Point(209, 776);
            this.lblNumTryVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumTryVal.Name = "lblNumTryVal";
            this.lblNumTryVal.Size = new System.Drawing.Size(20, 24);
            this.lblNumTryVal.TabIndex = 19;
            this.lblNumTryVal.Text = "3";
            // 
            // lblNumTry
            // 
            this.lblNumTry.AutoSize = true;
            this.lblNumTry.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumTry.Location = new System.Drawing.Point(34, 776);
            this.lblNumTry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumTry.Name = "lblNumTry";
            this.lblNumTry.Size = new System.Drawing.Size(157, 24);
            this.lblNumTry.TabIndex = 18;
            this.lblNumTry.Text = " No. of tries left    :";
            // 
            // ExerciseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(827, 859);
            this.Controls.Add(this.lblNumTryVal);
            this.Controls.Add(this.lblNumTry);
            this.Controls.Add(this.lblPassingScoreVal);
            this.Controls.Add(this.lblPassingScore);
            this.Controls.Add(this.lblTimeRemaining);
            this.Controls.Add(this.lblTimeRemainingVal);
            this.Controls.Add(this.lblCurrentScoreVal);
            this.Controls.Add(this.lblCurrentScore);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnAnswer4);
            this.Controls.Add(this.btnAnswer3);
            this.Controls.Add(this.btnAnswer2);
            this.Controls.Add(this.btnAnswer1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.pbQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExerciseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExerciseForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbQuestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbQuestion;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAnswer1;
        private System.Windows.Forms.Button btnAnswer2;
        private System.Windows.Forms.Button btnAnswer3;
        private System.Windows.Forms.Button btnAnswer4;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblCurrentScore;
        private System.Windows.Forms.Label lblCurrentScoreVal;
        private System.Windows.Forms.Label lblTimeRemainingVal;
        private System.Windows.Forms.Label lblTimeRemaining;
        private System.Windows.Forms.Label lblPassingScoreVal;
        private System.Windows.Forms.Label lblPassingScore;
        private System.Windows.Forms.Label lblNumTryVal;
        private System.Windows.Forms.Label lblNumTry;
    }
}