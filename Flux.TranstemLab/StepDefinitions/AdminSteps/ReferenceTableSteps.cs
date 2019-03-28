using Flux.TranstemLab.StepHelper.Base;
using TechTalk.SpecFlow;

namespace Flux.TranstemLab.StepDefinitions.AdminSteps
{
    [Binding]
    public class ReferenceTableSteps : TranstemLabTestBase
    {
        private readonly Pages pages;
        private string newOption;
        public ReferenceTableSteps(Pages pages)
        {
            this.pages = pages;
        }

        [Then(@"I navigate to Reference Table page Administrator homepage")]
        public void ThenINavigateToReferenceTablePageAdministratorHomepage()
        {
            pages.referenceTablesPage = pages.adminHomePage.ClickOnReferneceTableLink();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I select every item in the list to very that they are all working properly")]
        public void ThenISelectEveryItemInTheListToVeryThatTheyAreAllWorkingProperly()
        {
            pages.referenceTablesPage.ClickOnAllTables();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on the plus button to expend the all of the Reference Tables in the list")]
        public void ThenIClickOnThePlusButtonToExpendTheAllOfTheReferenceTablesInTheList()
        {
            pages.referenceTablesPage.ClickOnSystemButton();
            pages.commonMethodsPage.TakeScreenShot();
        }
        
        [Then(@"I select '(.*)' from the list")]
        public void ThenISelectFromTheList(string p0)
        {
            pages.referenceTablesPage.ClickOnCellViabilityMethod();
            pages.commonMethodsPage.TakeScreenShot();
        }
        
        [Then(@"I add new row to the look up table")]
        public void ThenIAddNewRowToTheLookUpTable()
        {
            pages.referenceTablesPage.ClickOnAddBtn();
            pages.commonMethodsPage.TakeScreenShot();
        }
        
        [Then(@"I verify that all of the sorting method works properly")]
        public void ThenIVerifyThatAllOfTheSortingMethodWorksProperly()
        {
            pages.referenceTablesPage.ClickOnAllSort();
            pages.commonMethodsPage.TakeScreenShot();
        }
        
        [Then(@"I click on the Save button in the reference table page")]
        public void ThenIClickOnTheSaveButtonInTheReferenceTablePage()
        {
            pages.referenceTablesPage.ClickOnSaveBtn();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on Add button in the reference table page")]
        public void ThenIClickOnAddButtonInTheReferenceTablePage()
        {
            pages.referenceTablesPage.ClickOnAddBtn();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I enter the string to the newly generated cell")]
        public void ThenIEnterTheStringToTheNewlyGeneratedCell()
        {
            newOption = pages.commonMethodsPage.GenerateName(6);
            pages.referenceTablesPage.EnterValueInFirstRow(newOption);
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I navigate to Transtem Home page from Reference table page")]
        public void ThenINavigateToTranstemHomePageFromReferenceTablePage()
        {
            pages.referenceTablesPage.NavigateToHomePage();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on processing step (.*)")]
        public void ThenIClickOnProcessingStep(int p0)
        {
            pages.processingProcedurePage.ClickOnProcessingStep1();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I check on the value in the Viability Method")]
        public void ThenICheckOnTheValueInTheViabilityMethod()
        {
            pages.processingProcedurePage.SelectFromCellViabilityDDL(newOption);
            pages.commonMethodsPage.TakeScreenShot();
        }
    }
}
