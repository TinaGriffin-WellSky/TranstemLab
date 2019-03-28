using Flux.TranstemLab.StepHelper.Base;
using TechTalk.SpecFlow;

namespace Flux.TranstemLab.StepDefinitions.DonorsSteps
{
    [Binding]
    public class DocumentsDonorSteps : TranstemLabTestBase
    {
        private readonly Pages pages;

        public DocumentsDonorSteps(Pages pages)
        {
            this.pages = pages;
        }

        [Then(@"I click on Documents for file upload for Donor page")]
        public void ThenIClickOnDocumentsForFileUploadForDonorPage()
        {
            pages.documentDonorPage = pages.transtemLabHomePage.ClickOnAddDocumentsBtnDonor("Document");
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I enter Values in Description as (.*) & for Category & for File on Donor page")]
        public void ThenIEnterValuesInDescriptionAsTestingForCategoryForFileOnDonorPage(string TextForDescription)
        {
            // pages.commonMethodsPage = pages.transtemLabHomePage.ReferenceForCommonMethods();
            string textFromCategory = pages.documentDonorPage.SelectValuesFromCategory("FileUpload");
            int NumbersRandom = pages.commonMethodsPage.GetRandomNumber(1, 100);
            pages.documentDonorPage.EnterTextInDescriptionBox(TextForDescription, NumbersRandom);
            object directoryName = pages.documentDonorPage.ChooseFileUploadDocsDonor();
            pages.commonMethodsPage.TakeScreenShot();
            pages.documentDonorPage.ClickOnUploadButtonFromFileUploadPage();
            //Verification 
            //pages.documentDonorPage.DocumentsVerification(textFromCategory, directoryName);
            pages.commonMethodsPage.TakeScreenShot();
        }
    }
}
