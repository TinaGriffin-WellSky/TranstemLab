using Flux.TranstemLab.StepHelper.Base;
using TechTalk.SpecFlow;

namespace Flux.TranstemLab.StepDefinitions.RecipientSteps
{
    [Binding]
    public class RecipientSteps : TranstemLabTestBase
    {
        private readonly Pages pages;
        public int RecipientID;

        public RecipientSteps(Pages pages)
        {
            this.pages = pages;
        }

        [Then(@"I click on Add Recipient button from Recipient Search Page")]
        public void ThenIClickOnAddRecipientButtonFromRecipientSearchPage()
        {
            pages.recipientPage.ClickOnAddRecipientBtn();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I enter (.*) (.*) (.*) (.*) (.*) (.*) (.*) Gender Ethnicity and Client Status in the page")]
        public void ThenIEnterTestTestCheckTAMABCPOGenderEthnicityAndClientStatusInThePage(string RecipientID, string FirstName, string LastName, string MedicalRecord, string CRID, string RegistryID, string BirthDate)
        {
            pages.commonMethodsPage = pages.transtemLabHomePage.ReferenceForCommonMethods();
            string RandomNames = pages.commonMethodsPage.GenerateName(4);
            int RandomNumbers = pages.commonMethodsPage.GetRandomNumber(1, 100);
            BirthDate = pages.commonMethodsPage.GetFutureDate(2);
            pages.recipientPage.EnterAllFields(RecipientID + "_" + RandomNumbers + "_" + RandomNames, FirstName + "_" + RandomNames, LastName + "_" + RandomNames, MedicalRecord + "_" + RandomNumbers, CRID + "_" + RandomNumbers, RegistryID + "_" + RandomNumbers, BirthDate);
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on Save button from page")]
        public void ThenIClickOnSaveButtonFromPage()
        {
            pages.recipientPage.ClickOnSaveButton();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click LogOutName")]


        public void ThenIClickLogOutName()
        {
            pages.transtemLabHomePage = pages.transtemLabHomePage.ClickLogOutName();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I record recipient information")]
        public void ThenIRecordRecipientInformation()
        {
            pages.recipientPage.setRecipientInfo();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"go to home page from Recipient page")]
        public void ThenGoToHomePageFromRecipientPage()
        {
            pages.recipientPage.navigateToHomePage();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I edit the transplant event to add product")]
        public void ThenIEditTheTransplantEventToAddProduct()
        {
            pages.recipientPage.EditTransplantEvent();
            pages.commonMethodsPage.TakeScreenShot();
            pages.recipientPage.FillInRequestedUnitField(pages.addNewProductPage.ProductId);
            pages.commonMethodsPage.TakeScreenShot();
            pages.recipientPage.ClickAddbtn();
            pages.commonMethodsPage.TakeScreenShot();
        }
    }
}
