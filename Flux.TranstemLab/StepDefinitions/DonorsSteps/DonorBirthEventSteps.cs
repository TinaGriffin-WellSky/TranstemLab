using Flux.TranstemLab.StepHelper.Base;
using TechTalk.SpecFlow;

namespace Flux.TranstemLab.StepDefinitions.DonorsSteps
{
    [Binding]
    public class DonorBirthEventSteps : TranstemLabTestBase
    {
        private readonly Pages pages;

        public DonorBirthEventSteps(Pages pages)
        {
            this.pages = pages;
        }

        [Then(@"I click on Add Birth Event link from the Donor Detail page and fill out the required fields (.*) (.*) (.*)")]
        public void ThenIClickOnAddBirthEventLinkFromTheDonorDetailPage(string OtherPhysician, string Location, string OtherReferralType)
        {
            //pages.commonMethodsPage = pages.transtemLabHomePage.ReferenceForCommonMethods();
            string RandomNames = pages.commonMethodsPage.GenerateName(4);
            pages.donorBirthEventPage = pages.transtemLabHomePage.ClickOnAddBirthEvent();
            pages.donorBirthEventPage.EnterDetailsInAddBirthEvent(OtherPhysician + "_" + RandomNames, Location + "_" + RandomNames, OtherReferralType + "_" + RandomNames);
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I Click on Save button on Add Birth Event page")]
        public void ThenIClickOnSaveButtonOnAddBirthEventPage()
        {
            pages.donorBirthEventPage.DrBeClickOnSaveButton();
            pages.commonMethodsPage.TakeScreenShot();
        }
    }
}
