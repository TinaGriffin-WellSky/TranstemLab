using Flux.TranstemLab.StepHelper.Base;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Flux.TranstemLab.StepDefinitions.Donors
{
    [Binding]
    public class CollectionEventStep : TranstemLabTestBase
    {
        private readonly Pages pages;

        public CollectionEventStep(Pages pages)
        {
            this.pages = pages;
        }

        [Then(@"I click on search button from the Donor Search Page and I select an identifier")]
        public void ThenIClickOnSearchButtonFromTheDonorSearchPageAndISelectANIdentifier()
        {
            bool chkSearchBtnClk = pages.donorCollectionEventsPage.ClickOnSearchButtonFromDonorPage();
            Assert.True(chkSearchBtnClk, "Not clicked on SEARCH Button, Please try again");
            Console.WriteLine("Clicked on SEARCH button successfully");
            pages.commonMethodsPage.TakeScreenShot();
            pages.donorCollectionEventsPage.ClickOnIdentifier(5);
        }

        [Then(@"I click on Add collection Event link from the Donor Detail page and fill out the required fields")]
        public void ThenIClickOnAddCollectionEventLinkFromTheDonorDetailPage()
        {
            bool chkDrAddCollEvents = pages.donorCollectionEventsPage.ClickOnAddCollectionEvent();
            Assert.True(chkDrAddCollEvents, "Verifcation of Add Collection Event page is successful");
            Console.WriteLine("Clicked on Add Collection Event page is successful");

            pages.donorCollectionEventsPage.ClickOnDropDownOptionsFromDrCe();
            pages.commonMethodsPage.TakeScreenShot();

            //pages.commonMethodsPage = pages.transtemLabHomePage.ReferenceForCommonMethods();
            string RandomNames = pages.commonMethodsPage.GenerateName(2);
            int RandomNumbers = pages.commonMethodsPage.GetRandomNumber(1, 9);
            pages.donorCollectionEventsPage.EnterValuesInCollectionDataFields(RandomNumbers, RandomNames);
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on Save button")]
        public void ThenIClickOnSaveButton()
        {
            pages.donorCollectionEventsPage.ClickOnSaveButton();
            pages.commonMethodsPage.TakeScreenShot();
        }
    }
}
