using MathGame.Core;

namespace MathGame.Tests
{
    public class QuestionTests
    {
        [Fact]
        public void TheQuestionProvidesTheCorrectAnswer()
        {
            var question = new Question
            {
                FirstNumber = 10,
                SecondNumber = 5,
                ThirdNumber = 7
            };

            Assert.Equal(45, question.Answer);
        }

        [Fact]
        public void WeCanProvideAGuessToVerifyTheAnswer()
        {
            var question = new Question
            {
                FirstNumber = 5,
                SecondNumber = 5,
                ThirdNumber = 7
            };

            Assert.True(question.IsCorrectAnswer(40));
        }
    }
}