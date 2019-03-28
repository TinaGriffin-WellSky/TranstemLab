using Flux.TranstemLab.StepHelper.Base;
using TechTalk.SpecFlow;

namespace Flux.TranstemLab.StepDefinitions.ProductSteps.BatchProcessingSteps
{
    [Binding]
    public class SampleStorageSteps : TranstemLabTestBase
    {
        private readonly Pages pages;

        public SampleStorageSteps(Pages pages)
        {
            this.pages = pages;
        }

        [Then(@"I select the first product in the table")]
        public void ThenISelectTheFirstProductInTheTable()
        {
            pages.setBatchPage.ClickOnFirstProductCheckbox();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on the Title Arrow")]
        public void ThenIClickOnTheTitleArrow()
        {
            pages.processingProcedurePage.ClickOnHighestTitleArrow();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on Storage")]
        public void ThenIClickOnStorage()
        {
            pages.processingProcedurePage.ClickOnStorage();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on Sample Storage")]
        public void ThenIClickOnSampleStorage()
        {
            pages.processingProcedurePage.ClickOnSampleStorage();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I fill out the sample storage information")]
        public void ThenIFillOutTheSampleStorageInformation()
        {
            int quantity = pages.commonMethodsPage.GetRandomNumber(1, 99);
            int freezerNumber = pages.commonMethodsPage.GetRandomNumber(1, 99);
            pages.processingProcedurePage.FillSampleStorage(quantity.ToString(), freezerNumber.ToString());
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on Create Sample")]
        public void ThenIClickOnCreateSample()
        {
            pages.processingProcedurePage.ClickOnCreateSample();
            pages.commonMethodsPage.TakeScreenShot();
        }

    }
}
