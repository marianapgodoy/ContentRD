using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleNUnit.WebObjects;

namespace SeleNUnit.ContentRD.Suites
{
    [TestClass]
    public abstract class SuiteBase
    {
        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void TestInitialize()
        {
            Browser.Start("http://localhost:4444/wd/hub");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Browser.Quit();
        }
    }
}
