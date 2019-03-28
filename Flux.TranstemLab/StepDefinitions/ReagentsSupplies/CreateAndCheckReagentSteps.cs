using Flux.TranstemLab.StepHelper.Base;
using TechTalk.SpecFlow;

namespace Flux.TranstemLab.StepDefinitions.ReagentsSupplies
{
    [Binding]
    public class CreateAndCheckReagentSteps : TranstemLabTestBase
    {
        private readonly Pages pages;
        private string reagentID;

        public CreateAndCheckReagentSteps(Pages pages)
        {
            this.pages = pages;
        }

        [Then(@"I click on Equipment/Consumables and select Reagents/Supplies")]
        public void ThenIClickOnEquipmentConsumablesAndSelectReagentsSupplies()
        {
            pages.searchReagentPage = pages.transtemLabHomePage.ClickOnReagents();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on Add Reagent")]
        public void ThenIClickOnAddReagent()
        {
            pages.addReagentPage = pages.searchReagentPage.ClickOnAddReagent();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I fill out necessary fields with random data on Add Reagent")]
        public void ThenIFillOutNecessaryFieldsWithRandomDataOnAddReagent()
        {
            // pages.commonMethodsPage = pages.transtemLabHomePage.ReferenceForCommonMethods();
            string receiptDate = pages.commonMethodsPage.GetFutureDate(0);
            string expDate = pages.commonMethodsPage.GetFutureDate(pages.commonMethodsPage.GetRandomNumber(1, 365));
            string quantity = pages.commonMethodsPage.GetRandomNumber(1, 20).ToString();
            string lotNum = pages.commonMethodsPage.GetRandomNumber(1, 20).ToString();
            pages.addReagentPage.EnterNecessaryData(receiptDate, expDate, quantity, lotNum);
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click Save on Add Reagent")]
        public void ThenIClickSaveOnAddReagent()
        {
            pages.reagentDetailsPage = pages.addReagentPage.ClickOnSave();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I record the reagent ID")]
        public void ThenIRecordTheReagentID()
        {
            reagentID = pages.reagentDetailsPage.ReadReagentID();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I add a document")]
        public void ThenIAddADocument()
        {
            string description = "Test description";
            pages.reagentDetailsPage.CreateDoc(description);
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I add a note")]
        public void ThenIAddANote()
        {
            string text = "Test text";
            pages.reagentDetailsPage.CreateNote(text);
            pages.commonMethodsPage.TakeScreenShot();
        }
    }
}
