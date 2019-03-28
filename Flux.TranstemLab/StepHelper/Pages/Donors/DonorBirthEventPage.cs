using Flux.Web;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;

namespace Flux.TranstemLab.StepHelper.Pages.Donors
{
    public class DonorBirthEventPage : WebPageBase
    {
        private readonly By _elementAddBirthEventHeader = By.XPath("//span[@id='ui-id-1'][text()='Add Birth Event']");
        private readonly By _elementDrBeSaveButton = By.XPath("//div[@class='ui-dialog-buttonset']//button//span[text()='Save']");

        //This method is for getting Future Date
        public string GetFutureDate(int noOfDays)
        {
            DateTime today = DateTime.Now;
            DateTime futureDate = today.AddDays(noOfDays);
            string strDate = futureDate.ToString("MM/dd/yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("Date is " + strDate);
            return strDate;
        }

        //This method is for Enter details in Add Birth Event Page
        public string[] dropDownListOptionsFromAddBirthEventPage = new string[] { "Hospital", "Survey", "Physician", "ReferralType" };

        public DonorBirthEventPage EnterDetailsInAddBirthEvent(string OtherPhysician, string Location, string OtherReferralType)
        {
            //Thread.Sleep(8000);
            if (Actions.IsEnabled(_elementAddBirthEventHeader))
            {
                Console.WriteLine("Navigated to Add Birth Event Page successfully");
            }

            //This method is for selcting value from DDL from Add Birth Event Page for "Hospital", "Survey", "Physician", "ReferralType" 
            for (int i = 0; i < dropDownListOptionsFromAddBirthEventPage.Length; i++)
            {
                By _elementsDDLFromAddBirthEventPage = By.XPath("//select[@id='ContentPlaceHolder1_ddl" + dropDownListOptionsFromAddBirthEventPage[i] + "']//option");
                Console.WriteLine("Now clicking on Drop Down List of : " + dropDownListOptionsFromAddBirthEventPage[i] + "======");

                ReadOnlyCollection<IWebElement> ListDrBeDDLOfAddBirthEventPage = Actions.FindElements(_elementsDDLFromAddBirthEventPage);
                IList<string> strList = new List<string>();

                for (int j = 0; j < ListDrBeDDLOfAddBirthEventPage.Count(); j++)
                {
                    strList.Add(ListDrBeDDLOfAddBirthEventPage[j].Text);
                }
                string[] valuesFromDropDown = strList.ToArray();

                Console.WriteLine("Values present in drop drop list are :");
                foreach (string strValues in valuesFromDropDown)
                {
                    Console.Write(strValues + " , ");
                    Log.Debug(strValues + " , ");
                }
                for (int j = 0; j < ListDrBeDDLOfAddBirthEventPage.Count; j++)
                {
                    if (j == 1)
                    {
                        //Thread.Sleep(2000);
                        ListDrBeDDLOfAddBirthEventPage[j].Click();
                        Console.WriteLine(ListDrBeDDLOfAddBirthEventPage[j].Text + " is selected from the " + dropDownListOptionsFromAddBirthEventPage[i] + " dropDown");
                    }
                }
            }
            //This method is for Entering the value from DDL from Add Birth Event Page for "DueDate", "DeliveryDate","OtherPhysician","Location","OtherReferralType"
            IList<string> strFields = new List<string>();
            strFields.Add("DueDate");
            strFields.Add("DeliveryDate");
            strFields.Add("OtherPhysician");
            strFields.Add("Location");
            strFields.Add("OtherReferralType");

            string strDueDate = GetFutureDate(1);
            string strDeliveryDate = GetFutureDate(10);

            List<object> mylist = new List<object> { strDueDate, strDeliveryDate, OtherPhysician, Location, OtherReferralType };

            for (int j = 0; j < strFields.Count; j++)
            {
                By _elementFileds = By.XPath("//input[@id='txt" + strFields[j] + "']");
                //Thread.Sleep(2000);
                if (Actions.IsDisplayed(_elementFileds))
                {
                    Actions.FindElement(_elementFileds).SendKeys(mylist[j].ToString());

                    if (strFields[j] == "DueDate" || strFields[j] == "DeliveryDate")
                    {
                        Actions.FindElement(_elementFileds).SendKeys(Keys.Enter);

                    }
                }
            }
            return CreateInstance<DonorBirthEventPage>();
        }

        //This method is for clicking on SAVE Button for BirthEvent  from Donor page
        public DonorBirthEventPage DrBeClickOnSaveButton()
        {
            if (Actions.IsEnabled(_elementDrBeSaveButton))
            {
                Actions.Click(_elementDrBeSaveButton);
            }
            Console.WriteLine("Clicked on Save button succesfully");
            return CreateInstance<DonorBirthEventPage>();
        }
    }
}

