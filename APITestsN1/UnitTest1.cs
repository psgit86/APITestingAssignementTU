using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using APITesting;

namespace APITestsN1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void VerifyNames()
        {
            var obj1 = new APIAssign();
            var response = obj1.GetUsers();
            Assert.AreEqual("Luke Skywalker", response.Results[0].Name);
            //Assert.AreEqual("C-3PO", response.Results[1].Name);
           // Assert.AreEqual("R2-D2", response.Results[2].Name);
        }
    }
}
