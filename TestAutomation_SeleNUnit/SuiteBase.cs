using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleNUnit.WebObjects;
using NUnit.Framework;
using Newtonsoft.Json;

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

#region AuxiliarMethods
        public static List<Dictionary<string, string>> JsonEnumerator(string file)
        {
            string json = System.IO.File.ReadAllText(file);
            return JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(json);
        }
#endregion
    }
}
