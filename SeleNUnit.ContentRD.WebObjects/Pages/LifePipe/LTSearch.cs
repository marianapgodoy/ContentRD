using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleNUnit.WebObjects.WebElement;

namespace SeleNUnit.ContentRD.WebObjects.Pages.LifePipe
{
    public class LTSearch
    {

        #region Elements

        private static readonly WebElement ClientFirstName = new WebElement().ById("ucClientTop_txtClientFirstName");
        private static readonly WebElement ClientLastName = new WebElement().ById("ucClientTop_txtClientLastName");
        private static readonly WebElement AgentInformation_lnk = new WebElement().ById("ucClientTop_lbnAgentInformation");
        private static readonly WebElement AgentInformation_AgentFirstName = new WebElement().ById("txtAgentFirstName");
        private static readonly WebElement AgentInformation_AgentLastName = new WebElement().ById("txtAgentLastName");
        private static readonly WebElement AgentInformation_AgentPhoneNumber = new WebElement().ById("txtPhoneNumber");
        private static readonly WebElement AgentInformation_AgentLicenseNumber = new WebElement().ById("txtLicenseNumber");
        private static readonly WebElement AgentInformation_SaveBtn = new WebElement().ById("btnSave");
        private static readonly WebElement AgentInformation_CloseBtn = new WebElement().ById("btnCancel");
        private static readonly WebElement DOBMonth = new WebElement().ById("ucBirthdayAge_txtDOBMonth");
        private static readonly WebElement DOBDay = new WebElement().ById("ucBirthdayAge_txtDOBDay");
        private static readonly WebElement DOBYear = new WebElement().ById("ucBirthdayAge_txtDOBYear");
        private static readonly WebElement AgeLast = new WebElement().ById("ucBirthdayAge_txtAgeLast");
        private static readonly WebElement AgeNearest = new WebElement().ById("ucBirthdayAge_txtAgeNearest");
        private static readonly WebElement GenderMale = new WebElement().ById("ucGender_rbnOption1");
        private static readonly WebElement GenderFemale = new WebElement().ById("ucGender_rbnOption2");
        private static readonly WebElement StateSelect = new WebElement().ById("ucState_ddlList");
        private static readonly WebElement AmountOfInsurance = new WebElement().ById("ucAmount_txtAmountofInsurance");
        private static readonly WebElement DetermineNeed_lnk = new WebElement().ByXPath("//div[@id='divNeedsAnalysis']/a[2]");
        private static readonly WebElement Business_lnk = new WebElement().ById("ucAmount_bizEquityLink_I");
        private static readonly WebElement PaymentOptionSelect = new WebElement().ById("ucPaymentOption_ddlList");
        private static readonly WebElement DesiredProductType_GuaranteedNonGuaranteedTerm = new WebElement().ById("ucTerm_rbnOption1");
        private static readonly WebElement DesiredProductType_SimplifiedIssue = new WebElement().ById("ucTerm_rbnOption3");
        private static readonly WebElement DesiredLenght_AllTermLength = new WebElement().ById("ucLength_chkOption1");
        private static readonly WebElement DesiredLenght_1YrART = new WebElement().ById("ucLength_chkOption2");
        private static readonly WebElement CarrierProduct_AllCarriersAndProducts = new WebElement().ById("ucCarrierProduct_rbnOption1");
        private static readonly WebElement Riders_AccidentalDeathBenefit = new WebElement().ById("ucRider_chkADB");
        private static readonly WebElement HealthClass_EnterHealthProfile = new WebElement().ById("ucHealthClass_rbnOption2");
        private static readonly WebElement EverUsedTobaccoSelect = new WebElement().ById("ucHealthClass_ddlXraeNicotine");
        private static readonly WebElement HeightSelect = new WebElement().ById("ucHealthClass_ddlHeight");
        private static readonly WebElement SelectHealthClass = new WebElement().ById("ucHealthClass_rbnOption1");
        private static readonly WebElement ShowTopBtn = new WebElement().ById("btnShowTop");
        private static readonly WebElement ViewAllQuotesBtn = new WebElement().ById("btnViewAllQuotes");
        private static readonly WebElement StartOverBtn = new WebElement().ById("btnStartOver");
        private static readonly WebElement SearchSavedQuotes = new WebElement().ById("txtSearchName");
        private static readonly WebElement SearchMyQuotesImg = new WebElement().ById("imgSearchMyQuotes");

        #endregion



        public void SetClientName(string first, string last)
        {
            ClientFirstName.SendKeys(first);
            ClientLastName.SendKeys(last);
        
        }

        public void SetDOB(string mm = "", string dd = "", string yyyy = "")
        {
            if (!string.IsNullOrEmpty(mm))
            { DOBMonth.SendKeys(mm); }
            if (!string.IsNullOrEmpty(dd))
            { DOBDay.SendKeys(dd); }
            if (!string.IsNullOrEmpty(yyyy))
            { DOBYear.SendKeys(yyyy); }
        }


        public void SetDOB(DateTime dob)
        {
            DOBMonth.SendKeys(Convert.ToString(dob.Month));
            DOBDay.SendKeys(Convert.ToString(dob.Day));
            DOBYear.SendKeys(Convert.ToString(dob.Year));
 
        }


        public void SetAgeLast( string ageLast = "")
        {
            if (!string.IsNullOrEmpty(ageLast))
            { AgeLast.SendKeys(ageLast); }
           
        }

        public void SetAgeNearest(string ageNearest = "")
        {

            if (!string.IsNullOrEmpty(ageNearest))
            { AgeNearest.SendKeys(ageNearest); }


        }

      


        public void SetGender(bool male)
        {
            if (male) { GenderMale.Click();} else {GenderFemale.Click();} 

        }


        public void SetAmountOfInsurance(string amount)
        {
            AmountOfInsurance.SendKeys(amount);
        }

        public void SetState(string state)
        {
            StateSelect.SelectByText(state);

        }


        public void SetDesiredTermLength(string option)
        {
            DesiredLenght_AllTermLength.Click();
        }


        public void ShowTopX()
        {
            ShowTopBtn.Click();
        }

        public void ViewAllQuotes()
        {
            ViewAllQuotesBtn.Click();
        }


        public void setDesiredLength(string checkBoxLocationOrder)
        { 
           WebElement desiredLength=new WebElement().ById("ucLength_chkOption"+checkBoxLocationOrder);
           desiredLength.Click();
        
        }

        #region helper for assertion

        public int getAge(DateTime dob, DateTime now)
        {
            int age = now.Year - dob.Year;
            if (now.Month < dob.Month || (now.Month == dob.Month && now.Day < dob.Day))
                age--;
            return age;
        }

        public string getStateAcronym(string state)
        {
            switch (state)
            {
                case "Alabama":
                   return "AL";
                case "Pennsylvania":
                   return "PA";
                default:
                   return "";
            }
          
        
        }

        #endregion helper for assertions


    }
}
