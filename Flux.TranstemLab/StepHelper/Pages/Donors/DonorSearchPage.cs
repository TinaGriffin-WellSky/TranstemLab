using Flux.Core;
using Flux.Web;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace Flux.TranstemLab.StepHelper.Pages.Donors
{
    public class DonorSearchPage : WebPageBase
    {
        readonly string DonorSearchURL = "/DonorMgmt/DonorSearch.aspx";
        public override string URL => DonorSearchURL;

        public readonly By _elementLastNameField = By.Id("ContentPlaceHolder1_txtDonorLastName");
        public readonly By _elementFirstnameField = By.Id("ContentPlaceHolder1_txtDonorFirstName");
        public readonly By _elementSearchBtn = By.Id("ContentPlaceHolder1_btnSearch");
        public readonly By _elementDonorLinkInTable = By.CssSelector("a[href^='DonorDetail']");
        public readonly By _elementStatusList = By.Id("ContentPlaceHolder1_dd_Disposition");
        public readonly By _elementDonorResultsTable = By.ClassName("EntitySearchGrid");

        //this method is used to search for a specific donor by first name and last name
        public DonorHomePage SearchDonorByFirstNameAndLastName(string firstName, string lastName)
        {
            Assert.True(Actions.IsDisplayed(_elementFirstnameField), "FirstName field is not being displayed");
            Actions.SendKeys(_elementFirstnameField, firstName);
            Actions.SendKeys(_elementLastNameField, lastName);
            Console.WriteLine("The first name entered is " + firstName + " and the last name entered is " + lastName);
            Actions.Click(_elementSearchBtn);
            Waits.WaitForElementToBePresent(_elementDonorLinkInTable, WaitType.Small);
            Actions.Click(_elementDonorLinkInTable);
            Console.WriteLine("Page is being directed to donor home page");
            return CreateInstance<DonorHomePage>();
        }

        //this method is used to search for a random By Status
        public void SearchByRandomStatus()
        {
            Random rnd = new Random();
            int option = rnd.Next(1, 4);
            Actions.SelectByIndex(_elementStatusList, option);
            Console.WriteLine(Actions.GetSelectedOption(_elementStatusList));

        }
        // this method is used to Click donor search for a result
        public void ClickSearch()
        {
            Actions.Click(_elementSearchBtn);
            Waits.WaitForPageLoad();
            if (Actions.IsDisplayed(_elementDonorResultsTable))
            {
                Report.TakeScreenshot();
                Report.LogInfo("Donor search returened results.");
            }
            else
            {
                Report.TakeScreenshot();
                Report.LogFailedTest("Donor search failed.");
            }
        }
        // this method is to validate the result of a donor search by status 
        public void ValidateGridStatus()
        {
            string selectedStatus = Actions.GetSelectedOption(_elementStatusList);
            var table = Actions.FindElement(By.XPath("//*[@id='ContentPlaceHolder1_gv1']/tbody"));
            string returnedStatus = table.FindElement(By.XPath("//*[@id='ContentPlaceHolder1_gv1']/tbody/tr[2]/td[7]")).GetAttribute("innerText");
            Console.WriteLine(returnedStatus);
            Assert.AreEqual(selectedStatus, returnedStatus, "Search results returned by Status do not match.");
            Report.TakeScreenshot();
        }
        //this method is to search donor by last name from donor add
        public void SearchDonorByLastName(string GetLastName )
        {

            Actions.SendKeys(_elementLastNameField, GetLastName);
            Actions.Click(_elementSearchBtn);
        }

        //this method is validate Donor last name search
        public void ValidateLastName()
        {
            string LastName  = Actions.GetSelectedOption(_elementStatusList);
            var table = Actions.FindElement(By.XPath("//*[@id='ContentPlaceHolder1_gv1']/tbody"));
            string returnedLastName = table.FindElement(By.XPath("//*[@id='ContentPlaceHolder1_gv1']/tbody/tr[2]/td[2]")).GetAttribute("innerText");
            Console.WriteLine(returnedLastName);
            Assert.AreEqual(LastName, returnedLastName, "Search results returned Last Name do not match.");
            Report.TakeScreenshot();
        }
    }

    



}
