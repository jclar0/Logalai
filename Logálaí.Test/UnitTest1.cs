using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logalai.Core;

namespace Logálaí.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestError()
        {
            // Arrange
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            Log instance = new Log();

            // Act
            instance.Error("This is an error test!");

            // Assert
            string output = sw.ToString();
            Assert.IsTrue(output.Contains("[ERROR] This is an error test!"));
        }

        [TestMethod]
        public void TestWarning()
        {
            // Arrange
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            Log instance = new Log();

            // Act
            instance.Warning("This is a warning test!");

            // Assert
            string output = sw.ToString();
            Assert.IsTrue(output.Contains("[WARNING] This is a warning test!"));
        }

        [TestMethod]
        public void TestInfo()
        {
            // Arrange
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            Log instance = new Log();

            // Act
            instance.Info("This is an info test!");

            // Assert
            string output = sw.ToString();
            Assert.IsTrue(output.Contains("[INFO] This is an info test!"));
        }
    }
}