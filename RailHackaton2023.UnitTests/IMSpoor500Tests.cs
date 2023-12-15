using IMSpoorHelper;
using System.Reflection;

namespace RailHackaton2023.UnitTests
{
    [TestClass]
    public class IMSpoor500Tests
    {
        [TestMethod]
        public void IMX500_serialize_deserialize_roundtripTest()
        {
            //Arrange
            var baseDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var testFile = Path.Combine(baseDir, "TestFiles", "Case 1", "Init1\\init1.xml");
            //Assert: Check if the created file exists in the deployment directory
            Assert.IsTrue(File.Exists(testFile), "deployment failed: " + testFile + " did not get deployed");
            //Act
            var imSpoor500 = SerializeHelper.ReadImx500(testFile);
            //Assert
            Assert.IsNotNull(imSpoor500);


            //Writing IMX500 to temp directory:
            //Arrange
            var testWriteFile = Path.Combine("C:/Temp/", "roundtripNewIMSpoorModel.xml");
            //Act
            SerializeHelper.WriteImx500(imSpoor500, testWriteFile);
            //Assert
            Assert.IsTrue(File.Exists(testWriteFile));
        }
    }
}