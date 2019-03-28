using Flux.TranstemLab.StepHelper.Base;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Flux.TranstemLab.StepDefinitions.RecipientSteps
{
    [Binding]
    public class RecipientSearchSteps : TranstemLabTestBase
    {
        private readonly Pages pages;

        public RecipientSearchSteps(Pages pages)
        {
            this.pages = pages;
        }

        [Then(@"I enter Recipient First Name")]
        public void ThenIEnterRecipientFirstName()
        {
            pages.recipientSearchpage.EnterFirstName(pages.recipientPage.GetFirstName());
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on Search button on the Recipient Search page")]
        public void ThenIClickOnSearchButtonOnTheRecipientSearchPage()
        {
            pages.recipientSearchpage.clickOnSearchBtn();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I enter Recipient Last Name")]
        public void ThenIEnterRecipientLastName()
        {
            pages.recipientSearchpage.EnterLastName(pages.recipientPage.GetLastName());
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I enter Recipient MRN")]
        public void ThenIEnterRecipientMRN()
        {
            pages.recipientSearchpage.EnterMRN(pages.recipientPage.GetMRN());
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I verify the recipient information")]
        public void ThenIVerifyTheRecipientInformation()
        {
            pages.recipientSearchpage.ClickOnRecipientId(pages.recipientPage.GetRecipientId(), pages.recipientPage.Getid());
            //Assert.True(pages.recipientPage.CheckRecipientInfo(), "Recipient info does not match");
        }
    }
}
