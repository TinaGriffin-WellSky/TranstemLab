using Flux.TranstemLab.StepHelper.Base;
using System;
using TechTalk.SpecFlow;


namespace Flux.TranstemLab.StepDefinitions.ProductSteps
{
    [Binding]
    public class CreateProductWithDonorIDSteps : TranstemLabTestBase
    {
        private readonly Pages pages;

        public CreateProductWithDonorIDSteps(Pages pages)
        {
            this.pages = pages;
        }

        [Then(@"I record the system generated donor ID")]
        public void ThenIRecordTheSystemGeneratedDonorID()
        {
            pages.donorHomePage.SetDonorID();
        }

        [Then(@"I click on the Product link to add a new product")]
        public void ThenIClickOnTheProductLinkToAddANewProduct()
        {
            pages.addNewProductPage = pages.productSearchPage.ClickOnAddProduct();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I select radio button to enter system generated donor ID and enter the ID")]
        public void ThenISelectRadioButtonToEnterSystemGeneratedDonorIDAndEnterTheID()
        {
            pages.addNewProductPage.SelectExistingDonorIDRadio();
            pages.addNewProductPage.EnterDonorId();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on the Load Donor ID and check the patient information")]
        public void ThenIClickOnTheLoadDonorIDAndCheckThePatientInformation()
        {
            pages.addNewProductPage.ClickOnLoadDonorIdBtn(pages.donorHomePage.GetDonorID());
            pages.commonMethodsPage.TakeScreenShot();
            bool checkDonor = pages.addNewProductPage.CheckDonorInformation();
        }

        [Then(@"I click on the sync button")]
        public void ThenIClickOnTheSyncButton()
        {
            pages.addNewProductPage.ClickOnSyncBtn();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on the radio button to select donor and press enter key in the keyboard")]
        public void ThenIClickOnTheRadioButtonToSelectDonorAndPressEnterKeyInTheKeyboard()
        {
            pages.addNewProductPage.ClickOnRadioButtonToSelectDonor();
            pages.addNewProductPage.PressEnterKey();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on Create Collection Event button")]
        public void ThenIClickOnCreateCollectionEventButton()
        {
            pages.addNewProductPage.ClickOnCreateCollectionEventBtn();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on the Create Product")]
        public void ThenIClickOnTheCreateProduct()
        {
            int randomVolume = pages.commonMethodsPage.GetRandomNumber(1, 15);
            pages.addNewProductPage.ClickonCreateProduct(randomVolume);
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click LogOut")]
        public void ThenIClickLogOut()
        {
            Console.WriteLine("Not implemented");
        }

        [Then(@"I note down the Product ID")]
        public void ThenINoteDownTheProductID()
        {
            pages.addNewProductPage.SetProductID();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"go to home page from Add New Product page")]
        public void ThenGoToHomePageFromAddNewProductPage()
        {
            pages.addNewProductPage.NavigateToHomePage();
            pages.commonMethodsPage.TakeScreenShot();
        }
    }
}
