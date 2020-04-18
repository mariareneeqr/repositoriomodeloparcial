using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using modeloparcial.Controllers;

namespace modeloparcial.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddGet1()
        {
            //Arrange=preparacion
            FriendsController friend = new FriendsController();
            int numa = 3;
            int numb = 4;
            int numres = 7;

            //Act=ejecucion
            int result = friend.Add(numa, numb);

            //Assert=verificacion 
            Assert.AreEqual(numres, result);

        }
    }
}
