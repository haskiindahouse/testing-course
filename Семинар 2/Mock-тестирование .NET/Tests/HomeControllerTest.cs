using Microsoft.AspNetCore.Mvc;
using testMoq.Controllers;
using Xunit.Sdk;
using Moq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Tests
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void IndexViewModelNotNull()
        {
            //Moq предназначен для имитации объектов.
            //В данном случае имитируется функциональность репозитория.
            var mock = new Mock<IRepository>();
            //Настройка mock объекта. имитируем возвращение методом GetComputerList()
            mock.Setup(a => a.GetComputerList()).Returns(new List<Computer>());
            HomeController controller = new HomeController(mock.Object);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result.Model);
        }
    }
}