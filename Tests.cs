using System;
using NUnit.Framework;

namespace SeeSawChallenge.Incomplete
{
    public class Tests
    {
        private SeeSaw _seeSaw;

        [SetUp]
        public void SetUp()
        {
            _seeSaw = new SeeSaw();
        }

        [Test]
        public void Guess_Correctly()
        {
            var guessLogic = new Logic(_seeSaw);

            var guess = guessLogic.Guess();

            Assert.That(_seeSaw.Guess(guess.Person, guess.IsHeavier));
        }
    }
}
