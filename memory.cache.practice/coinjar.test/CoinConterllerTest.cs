using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coinjar.test
{
   public class CoinControllerTest
    {
        [Test]
        public void  Get_Amount_When()
        {
            var _coilJar = new Mock<ICoilJar>();


            var coinJarController = new JarController(_coilJar.Object);
        
        }

        //var addressHandlerMock = new Mock<IAddressHandler>();

        //var addressController = new AddressController(addressHandlerMock.Object);

        //// Given an existing persons address
        //var personId = 1;

        //// When we get the address by the person's id
        //addressHandlerMock.Setup(mock => mock.GetAddressByPersonIdAsync(It.IsAny<int>())).ReturnsAsync(new Address());

        //    var response = await addressController.Person(personId);

        //// Then a successful response should be returned
        //Assert.NotNull(response);

        //    var okObjectResult = response as OkObjectResult;
        //Assert.NotNull(okObjectResult);
        //    Assert.AreEqual(200, okObjectResult.StatusCode);
}
