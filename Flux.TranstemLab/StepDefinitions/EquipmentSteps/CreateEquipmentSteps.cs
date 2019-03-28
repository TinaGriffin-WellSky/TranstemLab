using Flux.TranstemLab.StepHelper.Base;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Flux.TranstemLab.StepDefinitions.EquipmentSteps
{
    [Binding]
    public class CreateEquipmentSteps : TranstemLabTestBase
    {
        private readonly Pages pages;
        public CreateEquipmentSteps(Pages pages)
        {
            this.pages = pages;
        }

        [Then(@"I click on Add Equipment button")]
        public void ThenIClickOnAddEquipmentButton()
        {
            pages.equipmentCreation = pages.equipmentSearchPage.ClickOnAddEquipmentBtn();
        }

        [Then(@"I enter (.*) (.*) (.*) (.*) (.*) EquipmentType Location and Disposition in in the page")]
        public void ThenIEnterAIDD_MMNEquipmentTypeLocationAndDispositionInInThePage(string AID, string Description, string Manufacturer, string MN, string SN)
        {
            //pages.commonMethodsPage = pages.transtemLabHomePage.ReferenceForCommonMethods();
            string RandomNames = pages.commonMethodsPage.GenerateName(2);
            int RandomNumbers = pages.commonMethodsPage.GetRandomNumber(1, 100000);
            pages.equipmentCreation.EnterAllField(AID + RandomNumbers, Description + RandomNames, Manufacturer + RandomNames, MN + RandomNumbers, SN + RandomNumbers);
            pages.equipmentCreation.SelectFromDDL();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on the Save button to Save the New Equipment")]
        public void ThenIClickOnTheSaveButtonToSaveTheNewEquipment()
        {
            pages.equipmentHomePage = pages.equipmentCreation.ClickOnSaveBtn();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I record equipment information")]
        public void ThenIRecordEquipmentInformation()
        {
            pages.equipmentHomePage.SetID();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I should be Navigated to the Equipment Home Page")]
        public void ThenIShouldBeNavigatedToTheEquipmentHomePage()
        {
            Assert.True(pages.equipmentHomePage.IsSaveSuccessfulDisplayed(), "Equipment was not saved successfuly");
        }

        [Then(@"I click on Add Document button for file upload and I enter Values in Description as Testing and choose a file")]
        public void ThenIClickOnAddDocumentButtonForFileUploadAndIEnterValuesInDescriptionAsTestingAndChooseAFile()
        {
            pages.equipmentHomePage.CreateFileUpload();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on Add Note button and fill out as Testing")]
        public void ThenIClickOnAddNoteButtonAndFillOutAsTesting()
        {
            pages.equipmentHomePage.CreateNote();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on Add Preventive Maintenance and I enter a date in Date Scheduled and values in Notes as Testing")]
        public void ThenIClickOnAddPreventiveMaintenanceAndIEnterADateInDateScheduledAndValuesInNotesAsTesting()
        {
            pages.equipmentHomePage.CreateMaintenance(pages.commonMethodsPage.GetFutureDate(2));
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on the Save button in Equipment Home Page")]
        public void ThenIClickOnTheSaveButtonInEquipmentHomePage()
        {
            pages.equipmentHomePage.ClickOnSaveBtnInEquipmentHomePage();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I navigate to Transtem Home page frpm Equipment Home page")]
        public void ThenINavigateToTranstemHomePageFrpmEquipmentHomePage()
        {
            pages.equipmentHomePage.ClickOnHomeIcon();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I enter Equipment information")]
        public void ThenIEnterEquipmentInformation()
        {
            pages.equipmentSearchPage.FillInIDField(pages.equipmentHomePage.GetID());
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on Search and select correct equipment")]
        public void ThenIClickOnSearchAndSelectCorrectEquipment()
        {
            pages.equipmentSearchPage.ClickOnSearchBtn();
            pages.equipmentSearchPage.SelectEquipmentFromTable(pages.equipmentHomePage.GetID());
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click the Preventive Maintenance and I enter a date in Date Performed")]
        public void ThenIClickThePreventiveMaintenanceAndIEnterADateInDatePerformed()
        {
            pages.equipmentHomePage.OpenPM();
            pages.equipmentHomePage.FillInDatePerformedInMaintenance(pages.commonMethodsPage.GetFutureDate(3));
            pages.equipmentHomePage.ClickOnSaveBtnInAddMaintenanceSchedule();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I verify the information of the equipment")]
        public void ThenIVerifyTheInformationOfTheEquipment()
        {
            Assert.True(pages.equipmentHomePage.IsHomePageOpened(), "Home page is not opened");
        }
    }
}
