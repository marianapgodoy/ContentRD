using System;
using SeleNUnit.WebObjects;
using SeleNUnit.ContentRD.WebObjects.Pages.LifePipe;
using NUnit.Framework;


namespace SeleNUnit.ContentRD.Suites.Regression.LifePipe
{
    [TestFixture]
    public class LifePipeRT:SuiteBase
    {
        
        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }
        

        /// <summary>
        /// Objective: Verify View All Quotes shows correct quote information when filling mandatory fields
        /// Author/Updated By: Mariana
        /// Date:11/2014
        /// Tags: LifePipe Possitive Regression
        /// </summary>
/*        [Test]
        [DataSource("System.Data.SqlClient", "Data Source=localhost\\MarianaDB;Database=local_db;Integrated Security=True;", "Quote_Criteria", DataAccessMethod.Sequential)]
        public void ViewAllQuotes_ValidInput_Results()
        { 

            #region TestData
            const string userName="LifePipe1581";
            const string password = "LifePipe1581";
            const string urlParams = "?GAID=1581";
            #endregion TestData

            #region TestSteps
            new RSALogin().DoLogin(urlParams, userName, password);
            var Quote=new LTSearch();

            Quote.SetClientName(Convert.ToString(TestContext.DataRow["Client First Name"]),Convert.ToString(TestContext.DataRow["Client Last Name"]));
            Quote.SetAmountOfInsurance((Convert.ToString(TestContext.DataRow["Ammount of Insurance"])));
            Quote.SetDOB(Convert.ToDateTime(TestContext.DataRow["DOB"]));
            Quote.SetState((Convert.ToString(TestContext.DataRow["State"])));
            Quote.setDesiredLength("6");
            Quote.setDesiredLength("8");
            Quote.setDesiredLength("9");
            Quote.ViewAllQuotes();
            #endregion TestSteps

            #region Assertions
            string termQuoteInfromation=new LTAllQuotes().getTermQuoteInformation();
            Assert.IsTrue(termQuoteInfromation.Contains(Convert.ToString(TestContext.DataRow["Client First Name"])+" "+Convert.ToString(TestContext.DataRow["Client Last Name"])));
            //Assert.IsTrue(termQuoteInfromation.Contains("34/34"));
            //Assert.IsTrue(termQuoteInfromation.Contains("Male"));
            //Assert.IsTrue(termQuoteInfromation.Contains("AL"));
            //Assert.IsTrue(termQuoteInfromation.Contains("$500,000"));
            //Assert.IsTrue(termQuoteInfromation.Contains("Preferred Best Non-Tobacco"));
            //Assert.IsTrue(termQuoteInfromation.Contains("Preferred Non-Tobacco"));
            #endregion Assertions
        }
*/
        // [Test]
        //public void ViewAllQuotes_ValidInput_Results()
        //{ 

        //    #region TestData
        //    const string userName="LifePipe1581";
        //    const string password = "LifePipe1581";
        //    const string urlParams = "?GAID=1581";
        //    #endregion TestData

        //    #region TestSteps
        //    new RSALogin().DoLogin(urlParams, userName, password);
        //    var Quote=new LTSearch();

        //    Quote.SetClientName("test", "test");
        //    Quote.SetAmountOfInsurance("500000");
        //    Quote.SetDOB("10","10","1980");
        //    Quote.SetState("Alabama");
        //    Quote.setDesiredLength("6");
        //    Quote.setDesiredLength("8");
        //    Quote.setDesiredLength("9");
        //    Quote.ViewAllQuotes();
        //    #endregion TestSteps

        //    #region Assertions
        //    string termQuoteInfromation=new LTAllQuotes().getTermQuoteInformation();
        //    Assert.IsTrue(termQuoteInfromation.Contains("test test"));
        //    Assert.IsTrue(termQuoteInfromation.Contains("34/34"));
        //    Assert.IsTrue(termQuoteInfromation.Contains("Male"));
        //    Assert.IsTrue(termQuoteInfromation.Contains("AL"));
        //    Assert.IsTrue(termQuoteInfromation.Contains("$500,000"));
        //    Assert.IsTrue(termQuoteInfromation.Contains("Preferred Best Non-Tobacco"));
        //    Assert.IsTrue(termQuoteInfromation.Contains("Preferred Non-Tobacco"));
        //    #endregion Assertions
        //}



        /// <summary>
        /// Objective: Verify ....
        /// Author: 
        /// Date:
        /// Tags: LifePipe Possitive
        /// </summary>
        [Test]
        public void ShowTopX_ValidInput_Results()
        {

            #region TestData
            const string userName = "LifePipe1581";
            const string password = "LifePipe1581";
            const string urlParams = "?GAID=1581";
            #endregion TestData

            #region TestSteps
            new RSALogin().DoLogin(urlParams, userName, password);
            var Quote = new LTSearch();

            Quote.SetClientName("test", "test");
            Quote.SetAmountOfInsurance("500000");
            Quote.SetDOB("10", "10", "1980");
            Quote.SetState("Alabama");
            Quote.setDesiredLength("6");
            Quote.setDesiredLength("8");
            Quote.setDesiredLength("9");
            Quote.ShowTopX();
            #endregion TestSteps

            #region Assertions
            string termQuoteInfromation = new LTAllQuotes().getTermQuoteInformation();
            Assert.IsTrue(termQuoteInfromation.Contains("test test"));
            Assert.IsTrue(termQuoteInfromation.Contains("34/34"));
            Assert.IsTrue(termQuoteInfromation.Contains("Male"));
            Assert.IsTrue(termQuoteInfromation.Contains("AL"));
            Assert.IsTrue(termQuoteInfromation.Contains("$500,000"));
            Assert.IsTrue(termQuoteInfromation.Contains("Preferred Best Non-Tobacco"));
            Assert.IsTrue(termQuoteInfromation.Contains("Preferred Non-Tobacco"));
            Assert.IsTrue(termQuoteInfromation.Contains("Annual"));
            #endregion Assertions
        }

        
        /// <summary>
        /// Objective: Verify ....
        /// Author: 
        /// Date:
        /// Tags: LifePipe Possitive
        /// </summary>
        [Test]
        public void NeedsAnalysis_ValidInput_Results()
        {

        }









    }
}
