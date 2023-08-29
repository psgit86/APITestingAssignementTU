// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using APITesting;

namespace NUnit.Tests1
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void VerifyNames()
        {
            var obj1 = new APIAssign();
            var response = obj1.GetUsers();
            Assert.AreEqual("Luke Skywalker", response.Results[0].Name);
            //Assert.AreEqual("C-3PO", response.Results[1].Name);
            //Assert.AreEqual("R2-D2", response.Results[2].Name);
        }
    }
}
