using Microsoft.VisualStudio.TestTools.UnitTesting;
using HWApi.Controllers;

namespace HWApiTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGet()
        {
            var controller = new MessageController();
            var result = controller.Get();
            Assert.AreEqual("Hello World!", result);
        }
        [TestMethod]
        public void TestGetName()
        {
            var controller = new MessageController();
            var result = controller.Get("Jeff");
            Assert.AreEqual("Hello Jeff!", result);
        }
        [TestMethod]
        public void TestPost()
        {
            var controller = new MessageController();
            var result = controller.Post("Fred");
            Assert.AreEqual("Hello Fred!", result);
        }
    }
}
