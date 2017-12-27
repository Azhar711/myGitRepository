using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcApplication1;
using MvcApplication1.Controllers;
using System.Web.Mvc;

namespace MvcApplication1.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMemberController()
        {
            MemberController ControllerUnderTest = new MemberController();
            var result = ControllerUnderTest.step2() as ViewResult;
            Assert.AreEqual("step2", result.ViewName);
        }
    }
}
