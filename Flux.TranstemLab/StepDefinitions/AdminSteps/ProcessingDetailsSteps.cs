using Flux.TranstemLab.StepHelper.Base;
using TechTalk.SpecFlow;

namespace Flux.TranstemLab.StepDefinitions.AdminSteps
{
    [Binding]
    public class ProcessingDetailsSteps : TranstemLabTestBase
    {
        private readonly Pages pages;
        private string testDescription = "Test description";

        public ProcessingDetailsSteps(Pages pages)
        {
            this.pages = pages;
        }

        [Then(@"I navigate to Processing Details page")]
        public void ThenINavigateToProcessingDetailsPage()
        {
            pages.processingDetailsPage = pages.adminHomePage.ClickOnProcessingDetails();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on Add new record")]
        public void ThenIClickOnAddNewRecord()
        {
            pages.processingDetailsPage.ClickOnAddRecord();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I enter a description for record (.*)")]
        public void ThenIEnterADescriptionForRecord(int p0)
        {
            pages.processingDetailsPage.TypeInDescription((p0 - 1).ToString(), testDescription);
            pages.commonMethodsPage.TakeScreenShot();
        }
        
        [Then(@"I update the record")]
        public void ThenIUpdateTheRecord()
        {
            pages.processingDetailsPage.ClickOnUpdate();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on the Edit button for the last record")]
        public void ThenIClickOnTheEditButtonForTheLastRecord()
        {
            pages.processingDetailsPage.ClickOnEdit(); // NOTE: THIS IS NOT LAST RECORD
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I delete the last record")]
        public void ThenIDeleteTheLastRecord()
        {
            pages.processingDetailsPage.ClickOnDelete(); // NOTE: THIS IS NOT LAST RECORD
            pages.commonMethodsPage.TakeScreenShot();
        }
    }
}
