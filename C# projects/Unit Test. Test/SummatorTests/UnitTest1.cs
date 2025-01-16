using ConsoleAppSumator;

namespace SummatorTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int sum = Sumator.Sum(new int[] { 1, 2});
            Assert.That(sum, Is.EqualTo(3));
        }
    }
}