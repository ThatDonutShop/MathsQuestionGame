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
    /// Makes the attempts go up by one each guess
    /// if the answer is correct itll increase correctly answered by 1
    /// </summary>
    /// <param name="guess"></param>
    /// <returns></returns>
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
    /// <returns></returns>
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
