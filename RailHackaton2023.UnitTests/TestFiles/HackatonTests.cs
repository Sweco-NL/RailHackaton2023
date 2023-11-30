using IMSpoorHelper;

namespace RailHackaton2023.UnitTests.TestFiles
{
    [TestClass]
    public class HackatonTests
    {

        [TestMethod]
        public void IsMyHackatonCodeWorkingTest()
        {
            //Arrange
            //Act
            //Assert
            Assert.Fail("Not working");
        }

        [TestMethod]
        public void IsMyHackatonCodeWorkingTest2()
        {
            //Arrange
            var hackatonCode = new Class1();
            //Act
            //Assert
            Assert.IsTrue(hackatonCode.TestFunction());
        }


    }
}
