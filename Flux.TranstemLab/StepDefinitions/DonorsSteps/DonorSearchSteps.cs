using Flux.TranstemLab.StepHelper.Base;
using Flux.TranstemLab.StepHelper.Pages.Donors;
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

        [Given(@"I have selected a status from the drop down")]
        public void GivenIHaveSelectedAStatusFromTheDropDown()
        {
            Application.NewPage<DonorSearchPage>().SearchByRandomStatus();

        }

        [When(@"I click search")]
        public void WhenIClickSearch()
        {
            Application.NewPage<DonorSearchPage>().ClickSearch();
        }
        [Then(@"the expected donor based on status should be displayed")]
        public void ThenTheExpeectDonorBasedOnSatusShouldBeDisplayed()
        {
            Application.NewPage<DonorSearchPage>().ValidateGridStatus();
        }
        [Then(@"I record donor information")]
        public void ThenIRecordDonorInformation()
        {
            Application.NewPage<AddDonorPage>().GetDonorInfo();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I enter Donor Last Name")]
        public void ThenIEnterDonorLastName()
        {
            Application.NewPage<DonorSearchPage>().SearchDonorByLastName(pages.addDonorPage.GetLastName());
            pages.commonMethodsPage.TakeScreenShot();
        }
        [Then(@"I verify Donor with Last Name is returned")]
        public void ThenIVerifyDonorWithLastNameIsReturned()
        {
            Application.NewPage<DonorSearchPage>().ValidateLastName();
            pages.commonMethodsPage.TakeScreenShot();
        }

    }
}
