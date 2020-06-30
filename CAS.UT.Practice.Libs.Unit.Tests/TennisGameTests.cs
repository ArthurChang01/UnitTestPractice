using FluentAssertions;
using NUnit.Framework;

namespace CAS.UT.Practice.Libs.Unit.Tests
{
    [TestFixture]
    public class TennisGameTests
    {
        [Test]
        public void Should_ScoreIsFifteenLove_WhenPlayer1Win()
        {
            //TODO: Arrange
            var expected = "FifteenLove";
            var game = new TennisGame("game", new ScoreCal());

            //TODO: Action
            game.Win();
            var actual = game.Score;

            //TODO: Assertion
            actual.Should().Be(expected);
        }

        //Case: Score is ThirtyLove, when player1 win twice continuously.
        [Test]
        public void Should_ScoreIsThirtyLove_When_Player1WinTwice()
        {
            var expected = "ThirtyLove";
            var game = new TennisGame("game", new ScoreCal());

            game.Win();
            game.Win();
            var actual = game.Score;

            actual.Should().Be(expected);
        }

        //Case: Score is FortyLove, when player1 win thrice continuously.
        [Test]
        public void Should_ScoreIsFortyLove_When_Player1WinThrice()
        {
            var expected = "FortyLove";
            var game = new TennisGame("game", new ScoreCal());

            game.Win();
            game.Win();
            game.Win();
            var actual = game.Score;

            actual.Should().Be(expected);
        }

        //Case: Score is Player1Win, when player1 score is 4 and player2 score is 0.
        [Test]
        public void Should_ScoreIsPlayer1Win_When_Player1ScoreIs4_And_Player2ScoreIs0()
        {
            var expected = "Player1Win";
            var game = new TennisGame("game", new ScoreCal());

            game.Win();
            game.Win();
            game.Win();
            game.Win();
            var actual = game.Score;

            actual.Should().Be(expected);
        }
    }
}