using Flux.TranstemLab.StepHelper.Base;
using TechTalk.SpecFlow;

namespace Flux.TranstemLab.StepDefinitions
{
    [Binding]
    public class DocumentsRecipientSteps : TranstemLabTestBase
    {
        private readonly Pages pages;
        public DocumentsRecipientSteps(Pages pages)
        {
            this.pages = pages;
        }

        [Then(@"I click on Documents for file upload")]
        public void ThenIClickOnDocumentsForFileUpload()
        {
            //Thread.Sleep(1000);
            pages.documentsRecipientPage = pages.transtemLabHomePage.ClickOnAddDocumentsBtnRecipient("Document");
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I enter Values in Description as (.*) & for Category & for File")]
        public void ThenIEnterValuesInDescriptionAsTestingForCategoryForFile(string TextForDescription)
        {
            // pages.commonMethodsPage = pages.transtemLabHomePage.ReferenceForCommonMethods();
            string textFromCategory = pages.documentsRecipientPage.SelectValuesFromCategory("FileUpload");
            int NumbersRandom = pages.commonMethodsPage.GetRandomNumber(1, 100);
            pages.documentsRecipientPage.EnterTextInDescriptionBox(TextForDescription, NumbersRandom);
            object directoryName = pages.documentsRecipientPage.ChooseFileUpload();
            pages.commonMethodsPage.TakeScreenShot();
            pages.documentsRecipientPage.ClickOnUploadButtonFromFileUploadPage();
            //Verification 
            pages.documentsRecipientPage.DocumentsVerification(textFromCategory, directoryName);
            pages.commonMethodsPage.TakeScreenShot();

        }
    }
}
