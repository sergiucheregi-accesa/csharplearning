using EntityFrameworkLibrary.Models;
using EntityFrameworkLibrary.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace EsportManagementAppTests
{
    [TestClass]
    public class PlayerOperationsTests
    {
        [TestMethod]
        public void AddingPlayer_AddsNewPlayerA()
        {
            //Arrange
            var dbcontext = new Mock<IDataService<Player>>();

            //Act

            //Assert
        }
    }
}
