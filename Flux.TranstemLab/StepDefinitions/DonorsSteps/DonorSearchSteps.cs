using Flux.TranstemLab.StepHelper.Base;
using TechTalk.SpecFlow;

namespace Flux.TranstemLab.StepDefinitions.DonorsSteps
{
    [Binding]
    public class DonorSearchSteps : TranstemLabTestBase
    {
        private readonly Pages pages;
        public DonorSearchSteps(Pages pages)
        {
            this.pages = pages;
        }

        [Then(@"I enter donor information and select that Donor")]
        public void ThenIEnterDonorInformationAndSelectThatDonor()
        {
            pages.donorHomePage = pages.donorSearchPage.SearchDonorByFirstNameAndLastName(pages.recipientPage.GetFirstName(), pages.recipientPage.GetLastName());
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I start to Add collection")]
        public void ThenIStartToAddCollection()
        {
            pages.donorCollectionEventsPage = pages.donorHomePage.CreateCollectionEventPage();
            pages.commonMethodsPage.TakeScreenShot();
        }
    }
}
