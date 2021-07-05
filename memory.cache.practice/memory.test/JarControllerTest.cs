using Coin.Jar.Controllers;
using jar.api.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace memory.test
{
    [TestClass]
    public class JarControllerTest
    {
        [TestMethod]
        public  JarControllerTest()
        {
            var coinMock = new Mock<ICoinJar>();

            var coinController = new JarController(coinMock.Object);


            coinMock.Setup(k => k.GetTotalAmount()).Returns(new decimal());

            var response = coinController.Get();

            Assert.NotNull(response);

            var okObjectResult = response as OkObjectResult;
            Assert.NotNull(okObjectResult);
            Assert.AreEqual(200, okObjectResult.StatusCode);
        }

    }
}
