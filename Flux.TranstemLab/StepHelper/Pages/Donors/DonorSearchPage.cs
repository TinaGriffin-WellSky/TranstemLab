using Flux.Core;
using Flux.Web;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace Flux.TranstemLab.StepHelper.Pages.Donors
{
    public class DonorSearchPage : WebPageBase
    {

        public readonly By _elementLastNameField = By.Id("ContentPlaceHolder1_txtDonorLastName");
        public readonly By _elementFirstnameField = By.Id("ContentPlaceHolder1_txtDonorFirstName");
        public readonly By _elementSearchBtn = By.Id("ContentPlaceHolder1_btnSearch");
        public readonly By _elementDonorLinkInTable = By.CssSelector("a[href^='DonorDetail']");

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
    }
}
