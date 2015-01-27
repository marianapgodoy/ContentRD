using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleNUnit.WebObjects;
using NUnit.Framework;

namespace SeleNUnit.ContentRD.Suites
{
    [TestFixture]
    public abstract class SuiteBase
    {
        public TestContext TestContext { get; set; }

        [SetUp]
        public void TestInitialize()
        {
            Browser.Start("http://localhost:4444/wd/hub");
        }

        [TearDown]
        public void TestCleanup()
        {
            Browser.Quit();
        }
    }
}
