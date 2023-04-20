namespace MathGame.Core;

public class Game
{
    private Question _question;

    public Game()
    {
        _question = AskForNewQuestion();
    }

    public int Attempts { get; private set; } = 0;
    
    public int CorrectlyGuessed { get; private set; } = 0;
    
    /// <summary>
    /// Gives the ability to guess the question.
    /// </summary>
    /// <remarks>
    /// Adds an attempt to the game each time this method is called.
    /// Adds to the number of correctly guessed questions everytime the guess is answered correctly.
    /// </remarks>
    /// <param name="guess">The guess.</param>
    /// <returns>True if the guess is correct. Otherwise, false.</returns>
    public bool AttemptGuess(int guess)
    {
        Attempts++;
        if (_question.IsCorrectAnswer(guess))
        {
            CorrectlyGuessed++;
            return true;
        }
        else
        {
            return false;
        }
    }

    public Question AskForNewQuestion()
    {
        _question = CreateNewQuestion();
        return _question;
    }

    /// <summary>
    /// Generates the random numbers for the question between 1 and 10 inclusive
    /// </summary>
    /// <returns>The new question.</returns>
    private static Question CreateNewQuestion()
    {
        var random = new Random();

        return new Question
        {
            FirstNumber = random.Next(1, 11),
            SecondNumber = random.Next(1, 11),
            ThirdNumber = random.Next(1, 11)
        };
    }   
}
