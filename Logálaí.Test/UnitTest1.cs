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
            Log log = new Log();

            log.Error("This is a test error.");
            log.Warning("This is a warning error.");
            log.Info("This is an informational message.");

            Assert.IsNotNull(log);
        }
    }
}