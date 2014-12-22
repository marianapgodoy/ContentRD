using SeleNUnit.WebObjects;
using SeleNUnit.WebObjects.WebElement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleNUnit.ContentRD.WebObjects.Pages.LifePipe
{
    public class LTAllQuotes
    {

        #region Elements
        private static readonly WebElement headerQuoteResults_tbl = new WebElement().ByXPath("//tr[@id='trHeaderQuoteResults']//table");

        #endregion Elements


        public string getTermQuoteInformation() 
        {
            string table=headerQuoteResults_tbl.InnerHtml;
            return table;
            
        
        }

    }


   
}
