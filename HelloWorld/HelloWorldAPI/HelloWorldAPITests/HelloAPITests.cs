using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldAPI.Tests
{
    [TestClass()]
    public class HelloAPITests
    {
        HelloAPI api = new HelloAPI();

        [TestMethod()]
        public void ConsoleWriteTest()
        {
            var result = api.ConsoleWrite();

            Assert.IsNotNull(result);
            Assert.AreEqual("Console", result);
        }

        [TestMethod()]
        public void DatabaseWriteTest()
        {
            var result = api.DatabaseWrite();

            Assert.IsNotNull(result);
            Assert.AreEqual("Database", result);
        }

        [TestMethod()]
        public void MobileWriteTest()
        {
            var result = api.MobileWrite();

            Assert.IsNotNull(result);
            Assert.AreEqual("Mobile", result);
        }

        [TestMethod()]
        public void WebWriteTest()
        {
            var result = api.WebWrite();

            Assert.IsNotNull(result);
            Assert.AreEqual("Web", result);
        }

        [TestMethod()]
        public void WinServiceWriteTest()
        {
            var result = api.WinServiceWrite();

            Assert.IsNotNull(result);
            Assert.AreEqual("Win Service", result);
        }
    }
}