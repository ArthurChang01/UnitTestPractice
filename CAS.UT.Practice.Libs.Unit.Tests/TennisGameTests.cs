using System;
using FluentAssertions;
using NSubstitute;
using NUnit.Framework;
using Pose;

namespace CAS.UT.Practice.Libs.Unit.Tests
{
    [TestFixture]
    public class TennisGameTests
    {
        [Test]
        public void Should_ScoreIsLoveAll_When_Initialization()
        {
            //TODO: Arrange
            const string expected = "LoveAll";
            var svc = Substitute.For<IScoreCal>();
            var game = new TennisGame("game", svc);
            svc.CalculateScore(Arg.Any<TennisGame>()).Returns(expected);

            //TODO: Action
            var actual = game.Score;

            //TODO: Assertion
            actual.Should().Be(expected);
            svc.Received(1).CalculateScore(game);
        }

        //Case: When initial game, name is g3me and don't give any occuredDate, then DisplayName should be the string that is game plus the current date{yyyyMMdd}.
        [Test]
        public void Should_DisplayNameIsg3me_Plus_CurrentDate_When_InitialGame_And_NameIsg3me_But_DoNotGiveOccuredDate()
        {
            TennisGame game;
            var currentDate = DateTimeOffset.Now;
            var actual = string.Empty;
            Shim.Replace(() => DateTimeOffset.Now).With(() => currentDate);

            PoseContext.Isolate(() =>
            {
                game = new TennisGame("g3me");
                actual = game.DisplayName;
            });

            actual.Should().Be($"g3me{currentDate:yyyyMMdd}");
        }

        //Case: No matter service is injected or not, score should be LoveAll
        [Test]
        public void Should_ScoreIsLoveAll_When_Initialization_And_DoNotInjectScoreCal()
        {
            var expected = "LoveAll";
            var game = new TennisGame("game");

            var actual = game.Score;

            actual.Should().Be(expected);
        }
    }
}