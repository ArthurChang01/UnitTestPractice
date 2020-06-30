namespace CAS.UT.Practice.Libs.Unit.Tests
{
    using System;
    using FluentAssertions;
    using NUnit.Framework;

    namespace CAS.UT.Practice.Libs.Unit.Tests
    {
        [TestFixture]
        public class TennisGameTests
        {
            [Test]
            public void Should_IsEndIsTrue_When_ForceTerminateIsCalled()
            {
                //TODO: Arrange
                var game = new TennisGame("game");

                //TODO: Action
                game.ForceTerminate();
                var actual = game.IsEnd;

                //TODO: Assertion
                Assert.IsTrue(actual);
            }

            //Case: If IsEnd is true, client call ForceTerminate method would throw an Exception: IllegalOperationException.
            [Test]
            public void Should_IsEndIsTrue_And_ThrowIllegalOperationException_When_IsEndIsTrue_And_ForceTerminateIsCalled()
            {
                var game = new TennisGame("game");

                game.ForceTerminate();
                Action action = () => game.ForceTerminate();

                action.Should().Throw<IllegalOperationException>();
                game.IsEnd.Should().BeTrue();
            }

            //Case: When occuredDate is future time, client should not call ForceTerminate.
            [Test]
            public void Should_ThrowIllegalOperationException_When_OccuredDateIsFutureDate()
            {
                var occuredDate = DateTimeOffset.Now.AddDays(23);
                var game = new TennisGame("game", occuredDate);

                Action action = () => game.ForceTerminate();

                action.Should().Throw<IllegalOperationException>();
            }
        }
    }
}