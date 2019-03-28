using Flux.TranstemLab.StepHelper.Base;
using TechTalk.SpecFlow;

namespace Flux.TranstemLab.StepDefinitions.ProductHomePage
{
    [Binding]
    public class ConvertUnitIdToIsbtSteps : TranstemLabTestBase
    {
        private readonly Pages pages;
        public ConvertUnitIdToIsbtSteps(Pages pages)
        {
            this.pages = pages;
        }

        [Then(@"I Click on Save button")]
        public void ThenIClickOnSaveButton()
        {
            pages.donorCollectionEventsPage.ClickOnSaveButton();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on Convert to ISBT button Unit Id is converted to ISBT")]
        public void ThenIClickOnConvertToISBTButtonUnitIdIsConvertedToISBT()
        {
            pages.productHomePage = pages.transtemLabHomePage.ClickOnIsbtBtn();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on Save Button for Product Home Page")]
        public void ThenIClickOnSaveButtonForProductHomePage()
        {
            pages.productHomePage.ClickOnSaveOnProductHomePage();
            pages.commonMethodsPage.TakeScreenShot();
        }
    }
}
