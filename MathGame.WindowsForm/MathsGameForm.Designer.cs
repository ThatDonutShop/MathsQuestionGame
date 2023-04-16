namespace MathGame.WindowsForm
{
    partial class MathsGameForm
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
            lblAnsweredCorrect = new Label();
            lblAttempts = new Label();
            SubmitAnswer = new Button();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            lblNum3 = new Label();
            label3 = new Label();
            lblNum2 = new Label();
            label2 = new Label();
            lblNum1 = new Label();
            label1 = new Label();
            btnGenQuestion = new Button();
            AttemptsMade = new Label();
            CorrectlyAnswered = new Label();
            Guess = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Guess).BeginInit();
            SuspendLayout();
            // 
            // lblAnsweredCorrect
            // 
            lblAnsweredCorrect.AutoSize = true;
            lblAnsweredCorrect.Location = new Point(42, 437);
            lblAnsweredCorrect.Name = "lblAnsweredCorrect";
            lblAnsweredCorrect.Size = new Size(113, 15);
            lblAnsweredCorrect.TabIndex = 47;
            lblAnsweredCorrect.Text = "Answered Correctly:";
            // 
            // lblAttempts
            // 
            lblAttempts.AutoSize = true;
            lblAttempts.Location = new Point(42, 412);
            lblAttempts.Name = "lblAttempts";
            lblAttempts.Size = new Size(59, 15);
            lblAttempts.TabIndex = 46;
            lblAttempts.Text = "Attempts:";
            // 
            // SubmitAnswer
            // 
            SubmitAnswer.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            SubmitAnswer.Location = new Point(80, 358);
            SubmitAnswer.Name = "SubmitAnswer";
            SubmitAnswer.Size = new Size(173, 31);
            SubmitAnswer.TabIndex = 45;
            SubmitAnswer.Text = "Submit";
            SubmitAnswer.UseVisualStyleBackColor = true;
            SubmitAnswer.Click += SubmitAnswer_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(42, 308);
            label5.Name = "label5";
            label5.Size = new Size(209, 30);
            label5.TabIndex = 43;
            label5.Text = "What is the Answer: ";
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(259, 119);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 140);
            pictureBox3.TabIndex = 42;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(151, 119);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 140);
            pictureBox2.TabIndex = 41;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(43, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 140);
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(357, 91);
            label4.Name = "label4";
            label4.Size = new Size(64, 25);
            label4.TabIndex = 39;
            label4.Text = "=      ?";
            // 
            // lblNum3
            // 
            lblNum3.AutoSize = true;
            lblNum3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblNum3.Location = new Point(279, 91);
            lblNum3.Name = "lblNum3";
            lblNum3.Size = new Size(63, 25);
            lblNum3.TabIndex = 38;
            lblNum3.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(247, 91);
            label3.Name = "label3";
            label3.Size = new Size(21, 25);
            label3.TabIndex = 37;
            label3.Text = "x";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblNum2.Location = new Point(168, 91);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(63, 25);
            lblNum2.TabIndex = 36;
            lblNum2.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(135, 91);
            label2.Name = "label2";
            label2.Size = new Size(25, 25);
            label2.TabIndex = 35;
            label2.Text = "+";
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblNum1.Location = new Point(67, 91);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(63, 25);
            lblNum1.TabIndex = 34;
            lblNum1.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 33;
            label1.Text = "Maths Game";
            // 
            // btnGenQuestion
            // 
            btnGenQuestion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGenQuestion.Location = new Point(77, 88);
            btnGenQuestion.Name = "btnGenQuestion";
            btnGenQuestion.Size = new Size(0, 0);
            btnGenQuestion.TabIndex = 32;
            btnGenQuestion.Text = "Generate New Question";
            btnGenQuestion.UseVisualStyleBackColor = true;
            // 
            // AttemptsMade
            // 
            AttemptsMade.AutoSize = true;
            AttemptsMade.Location = new Point(107, 410);
            AttemptsMade.Name = "AttemptsMade";
            AttemptsMade.Size = new Size(0, 15);
            AttemptsMade.TabIndex = 48;
            // 
            // CorrectlyAnswered
            // 
            CorrectlyAnswered.AutoSize = true;
            CorrectlyAnswered.Location = new Point(161, 435);
            CorrectlyAnswered.Name = "CorrectlyAnswered";
            CorrectlyAnswered.Size = new Size(0, 15);
            CorrectlyAnswered.TabIndex = 49;
            // 
            // Guess
            // 
            Guess.Location = new Point(247, 315);
            Guess.Maximum = new decimal(new int[] { 110, 0, 0, 0 });
            Guess.Name = "Guess";
            Guess.Size = new Size(49, 23);
            Guess.TabIndex = 50;
            // 
            // MathsGameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 553);
            Controls.Add(Guess);
            Controls.Add(CorrectlyAnswered);
            Controls.Add(AttemptsMade);
            Controls.Add(lblAnsweredCorrect);
            Controls.Add(lblAttempts);
            Controls.Add(SubmitAnswer);
            Controls.Add(label5);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(lblNum3);
            Controls.Add(label3);
            Controls.Add(lblNum2);
            Controls.Add(label2);
            Controls.Add(lblNum1);
            Controls.Add(label1);
            Controls.Add(btnGenQuestion);
            Name = "MathsGameForm";
            Text = "Maths Game";
            Load += LoadGame;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Guess).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAnsweredCorrect;
        private Label lblAttempts;
        private Button SubmitAnswer;
        private Label label5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label4;
        private Label lblNum3;
        private Label label3;
        private Label lblNum2;
        private Label label2;
        private Label lblNum1;
        private Label label1;
        private Button btnGenQuestion;
        private Label AttemptsMade;
        private Label CorrectlyAnswered;
        private NumericUpDown Guess;
    }
}