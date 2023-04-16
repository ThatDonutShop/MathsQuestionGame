using MathGame.Core;
using System.Windows.Forms;

namespace MathGame.WindowsForm
{
    public partial class MathsGameForm : Form
    {
        private readonly Game _game;

        public MathsGameForm()
        {
            _game = new Game();
            InitializeComponent();
            Guess.Text = string.Empty;
        }

        private void LoadGame(object sender, EventArgs e)
        {
            ShowQuestion(_game.AskForNewQuestion());
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
            if (string.IsNullOrWhiteSpace(Guess.Text))
            {
                MessageBox.Show("You must enter a actual guess.", "Invalid guess");
            }
            else
            {
                if (_game.AttemptGuess(int.Parse(Guess.Text)))
                {
                    MessageBox.Show("You answered that correctly.", "Question answered");
                }

                Guess.Text = string.Empty;
                AttemptsMade.Text = _game.Attempts.ToString();
                CorrectlyAnswered.Text = _game.CorrectlyGuessed.ToString();

                ShowQuestion(_game.AskForNewQuestion());
            }
        }
    }
}