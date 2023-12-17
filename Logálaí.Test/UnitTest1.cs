using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logalai.Core;

namespace Logálaí.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);

                // Act
                Log.Info("Hello, world!");

                // Assert
                string output = sw.ToString();
                Assert.IsTrue(output.Contains("Hello, world!"));
            }
        }
    }
}