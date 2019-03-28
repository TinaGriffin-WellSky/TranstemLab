using Flux.Core;
using Flux.Web;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Flux.TranstemLab.StepHelper.Pages.Recipient
{
    public class RecipientSearchpage : WebPageBase
    {
        private readonly By _elementLastNameField = By.Id("ContentPlaceHolder1_txt_lastName");
        private readonly By _elementFirstNameField = By.Id("ContentPlaceHolder1_txt_firstName");
        private readonly By _elementMRNField = By.Id("ContentPlaceHolder1_txt_MRN");
        private readonly By _elementSearchBtn = By.Id("ContentPlaceHolder1_btnSearch");
        private readonly By _elementRecipientDetail = By.CssSelector("a[href*='RecipientDetail']");

        //this method is used to enter Firstname
        public void EnterFirstName(string firstName)
        {
            if (Actions.IsDisplayed(_elementFirstNameField))
            {
                Actions.SendKeys(_elementFirstNameField, firstName);
            }
        }

        //this method is used to enter lastname
        public void EnterLastName(string lastName)
        {
            if (Actions.IsDisplayed(_elementLastNameField))
            {
                Actions.SendKeys(_elementLastNameField, lastName);
            }
        }

        //this method is used to enter Firstname
        public void EnterMRN(string mRN)
        {
            if (Actions.IsDisplayed(_elementMRNField))
            {
                Actions.SendKeys(_elementMRNField, mRN);
            }
        }

        //this method is used to click on search button
        public void clickOnSearchBtn()
        {
            if (Actions.IsDisplayed(_elementSearchBtn))
            {
                Actions.Click(_elementSearchBtn);
                //Thread.Sleep(1000);
            }
        }

        //this method is used to click on the recipient ID in the table to check
        public void ClickOnRecipientId(string recipientId, string id)
        {
            System.Console.WriteLine(recipientId + "=" + id);
            Assert.True(Actions.IsDisplayed(_elementRecipientDetail), "The recipient search failed");
            Actions.Click(_elementRecipientDetail);
            //Thread.Sleep(3000);
        }
    }
}
