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
            //Moq ������������ ��� �������� ��������.
            //� ������ ������ ����������� ���������������� �����������.
            var mock = new Mock<IRepository>();
            //��������� mock �������. ��������� ����������� ������� GetComputerList()
            mock.Setup(a => a.GetComputerList()).Returns(new List<Computer>());
            HomeController controller = new HomeController(mock.Object);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result.Model);
        }
    }
}