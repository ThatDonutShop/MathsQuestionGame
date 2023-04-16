using MathGame.Core;

namespace MathGame.Tests
{
    public class GameTests
    {    
        [Fact]
        public void WhenAnsweringQuestionsWeTrackAttemptsAndCorrectlyGuessed()
        {
            var game = new Game();

            var question = game.AskForNewQuestion();

            var invalidAnswer = question.Answer + 1;

            Assert.False(game.AttemptGuess(invalidAnswer));
            Assert.False(game.AttemptGuess(invalidAnswer));
            Assert.False(game.AttemptGuess(invalidAnswer));            
            Assert.True(game.AttemptGuess(question.Answer));

            var secondQuestion = game.AskForNewQuestion();

            Assert.False(game.AttemptGuess(secondQuestion.Answer + 2));
            Assert.True(game.AttemptGuess(secondQuestion.Answer));

            Assert.Equal(6, game.Attempts);
            Assert.Equal(2, game.CorrectlyGuessed);
        }
    }
}