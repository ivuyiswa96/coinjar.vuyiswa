
using jar.api.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;
using jar.api.Models;
using NUnit.Framework;
using Jar.Controllers;
using memory.cache.practice.helper;

namespace CoinjarTest
{
    public class CoinJarControllerTest
    {


        [Test]
        public void Get()
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

        [Test]
        public void Post()
        {
            var coinMock = new Mock<ICoinJar>();
            var coinController = new JarController(coinMock.Object);

            var response = coinController.Post(CoinTypes.CoinType.ONE_CENT);

            Assert.NotNull(response);
            var okObjectResult = response as OkObjectResult;
            Assert.NotNull(okObjectResult);
            Assert.AreEqual(200, okObjectResult.StatusCode);
        }
        [Test]
        public void Reset()
        {
            var coinMock = new Mock<ICoinJar>();
            var coinController = new JarController(coinMock.Object);
          
            var response = coinController.Reset();

            Assert.NotNull(response);
            var okObjectResult = response as OkObjectResult;
            Assert.NotNull(okObjectResult);
            Assert.AreEqual(200, okObjectResult.StatusCode);
        }
    }
}