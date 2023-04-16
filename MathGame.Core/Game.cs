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
