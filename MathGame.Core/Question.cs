
namespace MathGame.Core;

public class Question
{
    public int FirstNumber { get; set; }

    public int SecondNumber { get; set; }

    public int ThirdNumber { get; set; }

    /// <summary>
    /// Returns the answer for the question
    /// </summary>
    public int Answer
    {
        get
        {
            return (SecondNumber * ThirdNumber) + FirstNumber;
        }
    }

    /// <summary>
    /// Checks if the answer is correct
    /// </summary>
    /// <param name="guess"></param>
    /// <returns></returns>
    public bool IsCorrectAnswer(int guess)
    {
        return Answer == guess;
    }

    /// <summary>
    /// Combines the randomly generated numbers into a easir to read format
    /// </summary>
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
