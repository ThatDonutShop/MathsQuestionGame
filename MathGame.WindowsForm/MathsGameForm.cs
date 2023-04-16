using MathGame.Core;

namespace MathGame.WindowsForm
{
    public partial class MathsGameForm : Form
    {
        private readonly Game _game;
        private Question _currentQuestion;

        public MathsGameForm()
        {
            _game = new Game();
            _currentQuestion = _game.AskForNewQuestion();

            InitializeComponent();
        }

        private void LoadGame(object sender, EventArgs e)
        {
            ShowQuestion(_currentQuestion);
        }

        private void ShowQuestion(Question question)
        {
            AssignQuestion(question.FirstNumber, lblNum1, pictureBox1);
            AssignQuestion(question.SecondNumber, lblNum2, pictureBox2);
            AssignQuestion(question.ThirdNumber, lblNum3, pictureBox3);
        }

        private static void AssignQuestion(int number, Label label, PictureBox picture)
        {
            label.Text = number.ToString();
            picture.Image = Image.FromFile($"cards/card{number}.jpg");
        }

        private void SubmitAnswer_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbxAnswer.Text, out int guess))
            {
                if (_game.AttemptGuess(guess))
                {
                    MessageBox.Show("You answered that correctly.", "Question answered");
                }

                AttemptsMade.Text = _game.Attempts.ToString();
            }

            _currentQuestion = _game.AskForNewQuestion();
            ShowQuestion(_currentQuestion);
        }
    }
}