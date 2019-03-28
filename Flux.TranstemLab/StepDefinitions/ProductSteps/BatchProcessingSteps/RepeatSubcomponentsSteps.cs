using Flux.TranstemLab.StepHelper.Base;
using TechTalk.SpecFlow;

namespace Flux.TranstemLab.StepDefinitions.ProductSteps.BatchProcessingSteps
{
    [Binding]
    public class RepeatSubcomponentsSteps
    {
        private readonly Pages pages;

        public RepeatSubcomponentsSteps(Pages pages)
        {
            this.pages = pages;
        }

        [Then(@"I click on Processing")]
        public void ThenIClickOnProcessing()
        {
            pages.processingProcedurePage.ClickOnProcessing();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I repeat Processing Step (.*)")]
        public void ThenIRepeatProcessingStep(int p0)
        {
            pages.processingProcedurePage.RepeatProcessingComponentCount(p0);
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on CD34 Selection")]
        public void ThenIClickOnCDSelection()
        {
            pages.processingProcedurePage.ClickOnCD34Selection();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I repeat Data Analysis Unselected Processing")]
        public void ThenIRepeatDataAnalysisUnselectedProcessing()
        {
            pages.processingProcedurePage.RepeatDataAnalysisUnselectedProcessingComponentCount();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I repeat Data Analysis CD34 Selection")]
        public void ThenIRepeatDataAnalysisCD34Selection()
        {
            pages.processingProcedurePage.RepeatDataAnalysisCD34SelectionComponentCount();
            pages.commonMethodsPage.TakeScreenShot();
        }
    }
}
