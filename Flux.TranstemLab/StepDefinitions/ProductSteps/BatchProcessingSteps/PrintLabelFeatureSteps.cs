using Flux.TranstemLab.StepHelper.Base;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace Flux.TranstemLab.StepDefinitions.ProductSteps.BatchProcessingSteps
{
    [Binding]
    public class PrintLabelFeatureSteps : TranstemLabTestBase
    {
        private readonly Pages pages;

        public PrintLabelFeatureSteps(Pages pages)
        {
            this.pages = pages;
        }

        [Then(@"I click on Label button to open Print Processing labels pop up")]
        public void ThenIClickOnLabelButtonToOpenPrintProcessingLabelsPopUp()
        {
            pages.processingProcedurePage.ClickOnLabelBtn();
            pages.commonMethodsPage.TakeScreenShot();
        }
        
        [Then(@"I fill in the information in the Print processing Labels pop up")]
        public void ThenIFillInTheInformationInThePrintProcessingLabelsPopUp()
        {
            pages.processingProcedurePage.FillOutPrintProcessingLabelPopUp();
            pages.commonMethodsPage.TakeScreenShot();
        }
    }
}
