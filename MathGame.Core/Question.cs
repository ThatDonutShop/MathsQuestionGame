
namespace MathGame.Core;

public class Question
{
    public int FirstNumber { get; set; }

    public int SecondNumber { get; set; }

    public int ThirdNumber { get; set; }

    public int Answer => (SecondNumber * ThirdNumber) + FirstNumber;

    public bool IsCorrectAnswer(int guess) => Answer == guess;
}
