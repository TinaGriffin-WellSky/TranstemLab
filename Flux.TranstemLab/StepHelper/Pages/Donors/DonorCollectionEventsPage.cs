using Flux.Core;
using Flux.Web;
using OpenQA.Selenium;
using System.Threading;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;

namespace Flux.TranstemLab.StepHelper.Pages.Donors
{
    public class DonorCollectionEventsPage : WebPageBase
    {
        public string donorIDText;
        private readonly By _elementSearchBlock = By.Name("ctl00$searchBlock1$ctl03");
        private readonly By _elementDonorsLink = By.XPath("//div[@id='cssmenu']//li/a[text()='Donors']");
        private readonly By _elementSearchButton = By.Id("ContentPlaceHolder1_btnSearch");
        private readonly By _elementIdentifier = By.LinkText("//*[text()='Last Name']");
        private readonly By _elementListIdentifier = By.CssSelector("a[href^='Donor']");
        private readonly By _elementAddCollectionEvent = By.Id("ContentPlaceHolder1_btnAddCollectionEvent");
        private readonly By _elementDonorID = By.Id("ContentPlaceHolder1_lblDonorId");
        private readonly By _elementDrCollEvntsHeader = By.XPath("//div[@class='ui-dialog-title']");
        private readonly By _elementDrCEHospitalArrowBtn = By.Id("ContentPlaceHolder1_ctrlCollectionEvent_ddlHostpitalCE");
        private readonly By _elementDrCeCollDataPlusSign = By.Id("ContentPlaceHolder1_ctrlCollectionEvent_btnAddCollectionDate");
        private readonly By _elementDrCeUpdateBtn = By.Id("ContentPlaceHolder1_ctrlCollectionEvent_gvEventDate_lnkUpdate_0");
        private readonly By _elementDrCeSaveButton = By.Id("ContentPlaceHolder1_ctrlCollectionEvent_btnSave");
        private readonly By _elementDrCeEditButton = By.Id("ContentPlaceHolder1_ctrlCollectionEvent_gvEventDate_lnkEdit_0");
        private readonly By _elementDrCeDonorIDText = By.XPath("//span[@id='ContentPlaceHolder1_spnDonorId'][text()]");
        public readonly By _elementIdentifierLink = By.XPath("(//A[text()='Identifier'])[1]");


        public bool ClickOnSearchButtonFromDonorPage()
        {
            bool chkSearchButton = false;

            Actions.Click(_elementSearchButton);

            if (Actions.IsDisplayed(_elementSearchButton))
            {
                chkSearchButton = true;
                Console.WriteLine("Identifier link is visible ======");
            }
            return chkSearchButton;
        }

        public string ClickOnIdentifier(int identifier)
        {
            //   ReadOnlyCollection<IWebElement> lstIdentifier = Actions.FindElements(_elementListIdentifier);
            //   for (int i = 0; i < lstIdentifier.Count; i++)
            //   {
            //       IWebElement str = lstIdentifier[i];
            //       Console.WriteLine(str);

            //      if (i == identifier)
            //       {
            //           Thread.Sleep(2000);

            //           String strelem = lstIdentifier[i].Text;
            //           lstIdentifier[i].Click();
            //          Thread.Sleep(5000);
            Actions.Click(_elementIdentifierLink);
            Thread.Sleep(500);
            Waits.WaitForElementToBeVisible(_elementListIdentifier, WaitType.Large);
            Actions.Click(_elementListIdentifier);
            //Thread.Sleep(1000);
            if (Actions.IsDisplayed(_elementDrCeDonorIDText))
            {
                donorIDText = Actions.GetText(_elementDrCeDonorIDText);
            }

            // Console.WriteLine("TEXT name is on first identifir here" + strelem);

            return donorIDText;
        }

        public bool ClickOnAddCollectionEvent()
        {
            bool chkAddCollEvnts = false;
            //Thread.Sleep(2000);

            if (Actions.IsDisplayed(_elementDonorID))
            {
                Waits.WaitForElementToBeClickable(_elementDonorID, WaitType.Small);
                Actions.Click(_elementAddCollectionEvent);
                chkAddCollEvnts = true;
            }
            if (Actions.IsDisplayed(_elementDrCollEvntsHeader))
            {
                Console.WriteLine("Verifcation of Add Collection Event page is successful");
            }
            return chkAddCollEvnts;
        }

        //Below method is for selecting values from Add Collection Event page for "HostpitalCE", "DonorType", "StemCellSource"
        public string[] dropDownListOptionsFromDrCe = new string[] { "ddlHostpitalCE", "ddlDonorType", "ddlStemCellSource" };

        public DonorCollectionEventsPage ClickOnDropDownOptionsFromDrCe()
        {
            for (int j = 0; j < dropDownListOptionsFromDrCe.Length; j++)
            {
                Console.WriteLine("Now clicking on Drop Down List of : " + dropDownListOptionsFromDrCe[j] + "======");
                By _elementDrCeHospitalDDList = By.XPath("//select[@id='ContentPlaceHolder1_ctrlCollectionEvent_" + dropDownListOptionsFromDrCe[j] + "']//option[text()]");
                //Thread.Sleep(1000);
                Console.WriteLine(dropDownListOptionsFromDrCe[j] + "Drop Down Arrow is expaneded for clicking the value");
                ReadOnlyCollection<IWebElement> lstHospital = Actions.FindElements(_elementDrCeHospitalDDList);
                IList<string> strList = new List<string>();

                for (int i = 0; i < lstHospital.Count; i++)
                {
                    strList.Add(lstHospital[i].Text);
                }

                String[] valuesFromDropDown = strList.ToArray();
                foreach (string strValues in valuesFromDropDown)
                {
                    Console.Write("Values present in drop drop list : " + strValues + ",");
                    Console.WriteLine();
                }
                for (int i = 0; i < lstHospital.Count; i++)
                {
                    if (i == 0)
                    {
                        lstHospital[i].Click();
                        Console.WriteLine(lstHospital[i].Text + " is selected from the " + dropDownListOptionsFromDrCe[j] + " dropDown");
                    }
                }
            }
            return CreateInstance<DonorCollectionEventsPage>();
        }

        //This method is for getting Future Date
        public string GetFutureDate(int noOfDays)
        {
            DateTime today = DateTime.Now;
            DateTime futureDate = today.AddDays(noOfDays);
            string strDate = futureDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("Date is " + strDate);
            return strDate;
        }

        public string[] DrCeDDLOfCollectionData = new string[] { "TimeZone", "Collector", "ProductDescriptionCode", "DonationType" };
        public string[] DrCeTextFieldsOfCollectionData = new string[] { "CollectionID", "StartDate", "StartTime", "EndDate", "EndTime" };

        public DonorCollectionEventsPage EnterValuesInCollectionDataFields(int RandomNumbers, string RandomNames)
        {
            String strdonorIDText = string.Empty;
            String StartDate = GetFutureDate(1);
            String EndDate = GetFutureDate(2);

            List<object> mylist = new List<object> { strdonorIDText, StartDate, "0000", EndDate, "0001" };
            Actions.Click(_elementDrCeCollDataPlusSign);
            Waits.WaitForElementToBeVisible(By.Id("ContentPlaceHolder1_ctrlCollectionEvent_gvEventDate_txtCollectionID_0"), WaitType.Medium);
            //Thread.Sleep(4000);
            Actions.Click(By.Id("ContentPlaceHolder1_ctrlCollectionEvent_gvEventDate_txtCollectionID_0"));
            Actions.FindElement(By.Id("ContentPlaceHolder1_ctrlCollectionEvent_gvEventDate_txtCollectionID_0")).SendKeys(mylist[0].ToString());

            //Below method is for selecting values from Add Collection Event page for "CollectionID", "StartDate", "StartTime", "EndDate", "EndTime"
            for (int i = 0; i < DrCeTextFieldsOfCollectionData.Length - 1; i++)
            {
                By _elementDrCeTextFields = By.Id("ContentPlaceHolder1_ctrlCollectionEvent_gvEventDate_txt" + DrCeTextFieldsOfCollectionData[i] + "_0");

                By _elementDrCeTextFieldsNext = By.Id("ContentPlaceHolder1_ctrlCollectionEvent_gvEventDate_txt" + DrCeTextFieldsOfCollectionData[i + 1] + "_0");

                //Thread.Sleep(2000);
                if (Actions.FindElement(_elementDrCeTextFields).Displayed)
                {
                    Actions.FindElement(_elementDrCeTextFields).SendKeys(Keys.Tab);
                    Waits.WaitForElementToBeVisible(_elementDrCeTextFields, WaitType.Small);
                    //Thread.Sleep(1000);
                    Actions.FindElement(_elementDrCeTextFieldsNext).SendKeys(mylist[i + 1].ToString());
                }
            }
            /*
            //Below method is for selecting values from Add Collection Event page for "TimeZone", "Collector", "ProductDescriptionCode", "DonationType"
            for (int j = 0; j < DrCeDDLOfCollectionData.Length; j++)
            {
                Console.WriteLine("Now clicking on Drop Down List of : " + DrCeDDLOfCollectionData[j] + "======");
                By _elementDrCeDDLOfCollectionDataFields = By.XPath("//select[@id='ContentPlaceHolder1_ctrlCollectionEvent_gvEventDate_ddl" + DrCeDDLOfCollectionData[j] + "_0']//option[text()]");

                ReadOnlyCollection<IWebElement> ListDrCeDDLOfCollectionDataFields = Actions.FindElements(_elementDrCeDDLOfCollectionDataFields);
                IList<string> strList = new List<string>();
                //Thread.Sleep(1000);
                for (int i = 0; i < ListDrCeDDLOfCollectionDataFields.Count; i++)
                {
                    strList.Add(ListDrCeDDLOfCollectionDataFields[i].Text);
                }
                string[] valuesFromDropDown = strList.ToArray();
                foreach (string strValues in valuesFromDropDown)
                {
                    Console.Write("Values present in drop drop list : " + strValues + ",");
                    Console.WriteLine();
                }
                for (int i = 0; i < ListDrCeDDLOfCollectionDataFields.Count; i++)
                {
                    if (i == 0)
                    {
                        ListDrCeDDLOfCollectionDataFields[i].Click();

                        Console.WriteLine(ListDrCeDDLOfCollectionDataFields[i].Text + " is selected from the " + DrCeDDLOfCollectionData[j] + " dropDown");
                    }
                }
            }
            */
            //Below method is for selecting values from Add Collection Event page for "TimeZone", "Collector", "ProductDescriptionCode", "DonationType"
            for (int j = 0; j < DrCeDDLOfCollectionData.Length; j++)
            {
                Console.WriteLine("Now clicking on Drop Down List of : " + DrCeDDLOfCollectionData[j] + "======");
                By _elementDrCeDDLOfCollectionDataFields = By.Id("ContentPlaceHolder1_ctrlCollectionEvent_gvEventDate_ddl" + DrCeDDLOfCollectionData[j] + "_0");
                Actions.SelectByRandoxIndex(_elementDrCeDDLOfCollectionDataFields);
                Console.WriteLine(Actions.GetAttributeValue(_elementDrCeDDLOfCollectionDataFields, "value") + " is selected from " + DrCeDDLOfCollectionData[j]);
            }
            return CreateInstance<DonorCollectionEventsPage>();
        }

        //This method is for click on Save Button
        public DonorCollectionEventsPage ClickOnSaveButton()
        {
            Actions.Click(_elementDrCeUpdateBtn);
            if (Actions.IsDisplayed(_elementDrCeEditButton))
            {
                Console.WriteLine("Update Button is clicked successfully");
                Actions.Click(_elementDrCeSaveButton);
                //Thread.Sleep(5000);
            }
            //WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5000));
            //Waits.WaitForElementToBeInvisible(_elementDrCeSaveButton, WaitType.ImplicitWaitTime);
            //wait.Until(ExpectedConditions.InvisibilityOfElementLocated(_elementDrCeSaveButton));
            Thread.Sleep(8000);
            Waits.WaitForElementToBeClickable(_elementAddCollectionEvent, WaitType.ImplicitWaitTime);
            //Waits.WaitForElementToBeInvisible(_elementDrCeSaveButton, WaitType.ImplicitWaitTime);
            return CreateInstance<DonorCollectionEventsPage>();
        }
    }
}
