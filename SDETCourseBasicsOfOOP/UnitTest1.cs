using SDETCourseBasicsOfOOP.Humano;

namespace SDETCourseBasicsOfOOP
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
            Organos organo = new Organos();

            organo.Pulmon();

            Assert.Pass();
        }
    }
}