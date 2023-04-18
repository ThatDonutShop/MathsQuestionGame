using MathGame.Core;

namespace MathGame.WindowsForm
{
    public partial class MathsGameForm : Form
    {
        private readonly Game _game;

        public MathsGameForm(Game game)
        {
            _game = game;
            InitializeComponent();
            Guess.Text = string.Empty;
        }

        private void LoadGame(object sender, EventArgs e)
        {
            ShowQuestion(_game.AskForNewQuestion());
        }

        private void ShowQuestion(Question question)
        {
            AssignQuestion(question.FirstNumber, FirstNumber, FirstCard);
            AssignQuestion(question.SecondNumber, SecondNumber, SecondCard);
            AssignQuestion(question.ThirdNumber, ThirdNumber, ThirdCard);
        }

        private static void AssignQuestion(int number, Label questionNumber, PictureBox card)
        {
            questionNumber.Text = number.ToString();
            card.Image = Image.FromFile($"cards/card{number}.jpg");
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

                Guess.Value = Guess.Minimum;
                Guess.Text = string.Empty;
                AttemptsMade.Text = _game.Attempts.ToString();
                CorrectlyAnswered.Text = _game.CorrectlyGuessed.ToString();

                var newQuestion = _game.AskForNewQuestion();

                ShowQuestion(newQuestion);
            }
        }
    }
}