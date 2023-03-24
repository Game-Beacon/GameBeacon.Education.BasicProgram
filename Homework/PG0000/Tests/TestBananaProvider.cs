using NUnit.Framework;
using PG0000.Questions;

namespace PG0000.Tests
{
    public class TestBananaProvider
    {
        [Test]
        public void GiveMeABanana_ReturnBanana()
        {
            Assert.AreEqual("Banana", BananaProvider.GiveMeABanana());
        }

    }
}