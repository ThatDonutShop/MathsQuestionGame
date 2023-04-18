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
            ThirdCard = new PictureBox();
            SecondCard = new PictureBox();
            FirstCard = new PictureBox();
            label1 = new Label();
            AttemptsMade = new Label();
            CorrectlyAnswered = new Label();
            Guess = new NumericUpDown();
            QuestionDescription = new Label();
            ((System.ComponentModel.ISupportInitialize)ThirdCard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SecondCard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FirstCard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Guess).BeginInit();
            SuspendLayout();
            // 
            // lblAnsweredCorrect
            // 
            lblAnsweredCorrect.AutoSize = true;
            lblAnsweredCorrect.Location = new Point(42, 380);
            lblAnsweredCorrect.Name = "lblAnsweredCorrect";
            lblAnsweredCorrect.Size = new Size(113, 15);
            lblAnsweredCorrect.TabIndex = 47;
            lblAnsweredCorrect.Text = "Answered Correctly:";
            // 
            // lblAttempts
            // 
            lblAttempts.AutoSize = true;
            lblAttempts.Location = new Point(42, 355);
            lblAttempts.Name = "lblAttempts";
            lblAttempts.Size = new Size(59, 15);
            lblAttempts.TabIndex = 46;
            lblAttempts.Text = "Attempts:";
            // 
            // SubmitAnswer
            // 
            SubmitAnswer.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            SubmitAnswer.Location = new Point(42, 311);
            SubmitAnswer.Name = "SubmitAnswer";
            SubmitAnswer.Size = new Size(173, 31);
            SubmitAnswer.TabIndex = 45;
            SubmitAnswer.Text = "Submit";
            SubmitAnswer.UseVisualStyleBackColor = true;
            SubmitAnswer.Click += SubmitAnswer_Click;
            // 
            // ThirdCard
            // 
            ThirdCard.Location = new Point(259, 119);
            ThirdCard.Name = "ThirdCard";
            ThirdCard.Size = new Size(100, 140);
            ThirdCard.TabIndex = 42;
            ThirdCard.TabStop = false;
            // 
            // SecondCard
            // 
            SecondCard.Location = new Point(151, 119);
            SecondCard.Name = "SecondCard";
            SecondCard.Size = new Size(100, 140);
            SecondCard.TabIndex = 41;
            SecondCard.TabStop = false;
            // 
            // FirstCard
            // 
            FirstCard.Location = new Point(43, 119);
            FirstCard.Name = "FirstCard";
            FirstCard.Size = new Size(100, 140);
            FirstCard.TabIndex = 40;
            FirstCard.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(133, 45);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 33;
            label1.Text = "Maths Game";
            // 
            // AttemptsMade
            // 
            AttemptsMade.AutoSize = true;
            AttemptsMade.Location = new Point(107, 353);
            AttemptsMade.Name = "AttemptsMade";
            AttemptsMade.Size = new Size(0, 15);
            AttemptsMade.TabIndex = 48;
            // 
            // CorrectlyAnswered
            // 
            CorrectlyAnswered.AutoSize = true;
            CorrectlyAnswered.Location = new Point(172, 380);
            CorrectlyAnswered.Name = "CorrectlyAnswered";
            CorrectlyAnswered.Size = new Size(0, 15);
            CorrectlyAnswered.TabIndex = 49;
            // 
            // Guess
            // 
            Guess.Location = new Point(166, 284);
            Guess.Maximum = new decimal(new int[] { 110, 0, 0, 0 });
            Guess.Name = "Guess";
            Guess.Size = new Size(49, 23);
            Guess.TabIndex = 50;
            // 
            // QuestionDescription
            // 
            QuestionDescription.AutoSize = true;
            QuestionDescription.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            QuestionDescription.Location = new Point(43, 278);
            QuestionDescription.Name = "QuestionDescription";
            QuestionDescription.Size = new Size(0, 30);
            QuestionDescription.TabIndex = 51;
            // 
            // MathsGameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 449);
            Controls.Add(QuestionDescription);
            Controls.Add(Guess);
            Controls.Add(CorrectlyAnswered);
            Controls.Add(AttemptsMade);
            Controls.Add(lblAnsweredCorrect);
            Controls.Add(lblAttempts);
            Controls.Add(SubmitAnswer);
            Controls.Add(ThirdCard);
            Controls.Add(SecondCard);
            Controls.Add(FirstCard);
            Controls.Add(label1);
            Name = "MathsGameForm";
            Text = "Maths Game";
            Load += LoadGame;
            ((System.ComponentModel.ISupportInitialize)ThirdCard).EndInit();
            ((System.ComponentModel.ISupportInitialize)SecondCard).EndInit();
            ((System.ComponentModel.ISupportInitialize)FirstCard).EndInit();
            ((System.ComponentModel.ISupportInitialize)Guess).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAnsweredCorrect;
        private Label lblAttempts;
        private Button SubmitAnswer;
        private PictureBox ThirdCard;
        private PictureBox SecondCard;
        private PictureBox FirstCard;
        private Label label1;
        private Label AttemptsMade;
        private Label CorrectlyAnswered;
        private NumericUpDown Guess;
        private Label QuestionDescription;
    }
}