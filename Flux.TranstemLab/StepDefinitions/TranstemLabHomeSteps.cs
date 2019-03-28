using Flux.TranstemLab.StepHelper.Base;
using System;
using TechTalk.SpecFlow;

namespace Flux.TranstemLab.StepDefinitions
{
    [Binding]
    public sealed class TranstemLabHomeSteps : TranstemLabTestBase
    {
        private readonly Pages pages;
        public TranstemLabHomeSteps(Pages pages)
        {
            this.pages = pages;
        }

        [Then(@"I should be navigated to TranstemLab home page")]
        public void ThenIShouldBeNavigatedToTranstemLabDashboardPage()
        {
            pages.transtemLabHomePage.VerificationOfHomePage();
        }

        [Then(@"I click on Donors Link")]
        public void ThenIClickOnDonorsLink()
        {
            pages.donorCollectionEventsPage = pages.transtemLabHomePage.ClickOnDonorLink();
            pages.commonMethodsPage.TakeScreenShot();
            Console.WriteLine("Donor Page opened successfully");
        }

        [Then(@"I click on Recipients Link")]
        public void ThenIClickOnRecipientsLink()
        {
            pages.recipientPage = pages.transtemLabHomePage.ClickOnRecipientLink();
            pages.commonMethodsPage.TakeScreenShot();
            Console.WriteLine("Recipient Page opened successfully");
        }

        [Then(@"I click on product link to add")]
        public void ThenIClickOnProductLinkToAdd()
        {
            pages.productSearchPage = pages.transtemLabHomePage.ClickOnProductToAdd();
            Console.WriteLine("Product page opened successfully");
        }

        [Then(@"I start to do a Recipient search")]
        public void ThenIStartToDoARecipientSearch()
        {
            pages.recipientSearchpage = pages.transtemLabHomePage.SearchForRecipient();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I start to do a Donor search")]
        public void ThenIStartToDoADonorSearch()
        {
            pages.donorSearchPage = pages.transtemLabHomePage.ClickOnDonorLinkToSearch();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on Equipment Link")]
        public void ThenIClickOnEquipmentLink()
        {
            pages.equipmentSearchPage = pages.transtemLabHomePage.ClickOnEquipment();
            pages.commonMethodsPage.TakeScreenShot();
        }
        [Given(@"I navigated to Environmental Monitoring")]
        public void GivenINavigatedToEnvironmentalMonitoring()
        {
            pages.environmentalMonitoringHomePage = pages.transtemLabHomePage.ClickOnEnvironmentalMonitoring();
            pages.commonMethodsPage.TakeScreenShot();
        }
        [Given(@"I navigated to Admin Home page")]
        public void GivenINavigatedToAdminHomePage()
        {
            pages.adminHomePage = pages.transtemLabHomePage.ClickOnAdminLink();
            pages.commonMethodsPage.TakeScreenShot();
        }
    }
}
