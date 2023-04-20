
namespace MathGame.Core;

public class Question
{
    public int FirstNumber { get; set; }

    public int SecondNumber { get; set; }

    public int ThirdNumber { get; set; }

    public int Answer
    {
        get
        {
            return (SecondNumber * ThirdNumber) + FirstNumber;
        }
    }

    public bool IsCorrectAnswer(int guess)
    {
        return Answer == guess;
    }

    public string Description
    {
        get
        {
            return $"{FirstNumber} + {SecondNumber} x {ThirdNumber} = ";
        }
    }

    public override string ToString()
    {
        return Description;
    }
}
