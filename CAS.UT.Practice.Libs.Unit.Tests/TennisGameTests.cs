using System;
using NUnit.Framework;

namespace CAS.UT.Practice.Libs.Unit.Tests
{
    [TestFixture]
    public class TennisGameTests
    {
        [Test]
        public void Should_DisplayNameIsGame20200703_When_NameIsGame_And_OccuredDateIsDefaultValue()
        {
            //TODO: Arrange
            var name = "Game";
            var occuredDate = new DateTimeOffset(2020, 07, 03, 0, 0, 0, TimeSpan.Zero);
            var game = new TennisGame(name, occuredDate);
            var expected = "Game20200703";

            //TODO: Action
            var actual = game.DisplayName;

            //TODO: Assertion
            Assert.AreEqual(expected, actual);
        }

        //Another Test Case: Name is "G2ame" And occuredDate is 1937/07/07
        [Test]
        public void Should_DisplayNameIsG2ame19370707_When_NameIsG2ame_And_OccuredDateIs19370707()
        {
            var name = "Game";
            var occuredDate = new DateTimeOffset(2020, 07, 03, 0, 0, 0, TimeSpan.Zero);
            var game = new TennisGame(name, occuredDate);
            var expected = "Game20200703";

            var actual = game.DisplayName;

            Assert.AreEqual(expected, actual);
        }
    }
}