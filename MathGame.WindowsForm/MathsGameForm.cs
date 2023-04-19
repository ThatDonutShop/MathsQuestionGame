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

        /// <summary>
        /// Loads the game with a brand new question.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadGame(object sender, EventArgs e)
        
            ShowQuestion(_game.AskForNewQuestion());
        }

        /// <summary>
        /// Shows the question on the form.
        /// </summary>
        /// <param name="question">The random question to show.</param>
        private void ShowQuestion(Question question)
        {
            QuestionDescription.Text = question.Description;

            FirstCard.Image = Image.FromFile($"cards/card{question.FirstNumber}.jpg");
            SecondCard.Image = Image.FromFile($"cards/card{question.SecondNumber}.jpg");
            ThirdCard.Image = Image.FromFile($"cards/card{question.ThirdNumber}.jpg");
        }

        /// <summary>
        /// Submit the users guess for the answer to the question.
        /// If the guess is correct, we display a message box to inform the user that it was correct.
        /// The number of attempts is increased each time we guess is made.
        /// If the guess is correct we increase the total count of correctly answered questions.
        /// Regardless (correct or not) we present a new question.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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