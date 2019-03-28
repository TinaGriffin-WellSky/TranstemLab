using Flux.TranstemLab.StepHelper.Base;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace Flux.TranstemLab.StepDefinitions.ProductSteps
{
    [Binding]
    public class CreateKitWithNewDonorSteps : TranstemLabTestBase
    {
        private readonly Pages pages;

        public CreateKitWithNewDonorSteps(Pages pages)
        {
            this.pages = pages;
        }

        [Then(@"I click on Scan/enter existing kit ID or create a new kit radio, and click on Create New Kit")]
        public void ThenIClickOnScanEnterExistingKitIDOrCreateANewKitRadioAndClickOnCreateNewKit()
        {
            pages.addNewProductPage.SelectExistingKitIDRadio();
            pages.addNewProductPage.ClickOnCreateNewKitBtn();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I fill out the required fields in Add New Kit\(s\) page")]
        public void ThenIFillOutTheRequiredFieldsInAddNewKitSPage()
        {
            pages.commonMethodsPage = pages.transtemLabHomePage.ReferenceForCommonMethods();
            string RandomNumber = pages.commonMethodsPage.GetRandomNumber(1, 99999).ToString();
            string KitExpirationDate = pages.commonMethodsPage.GetFutureDate(10);
            pages.addNewProductPage.EnterAllFields(RandomNumber, RandomNumber, RandomNumber, KitExpirationDate);
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on the save button from Add New Kits\(s\) page")]
        public void ThenIClickOnTheSaveButtonFromAddNewKitsSPage()
        {
            pages.addNewProductPage.ClickOnSaveButton();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I verify the information and click on Load Kit \# button")]
        public void ThenIVerifyTheInformationAndClickOnLoadKitButton()
        {
            pages.addNewProductPage.ClickOnLoadKitButton();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I fill out donor information")]
        public void ThenIFillOutDonorInformation()
        {
            string FirstName = pages.addDonorPage.GetFirstName();
            string Lastname = pages.addDonorPage.GetLastName();
            string BirthDate = pages.addDonorPage.GetBirthDate();

            Console.WriteLine("First name is: " + FirstName +
                ", and the Last name is: " + Lastname +
                ", and the Date of birth is: " + BirthDate);
            pages.addNewProductPage.EnterDonorInfo(FirstName, Lastname, BirthDate);
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on the sync button from Add New Product page")]
        public void ThenIClickOnTheSyncButtonFromAddNewProductPage()
        {
            pages.addNewProductPage.ClickOnSyncButton();
            pages.commonMethodsPage.TakeScreenShot();
            pages.addNewProductPage.SelectRadioButtonAndAcceptPopUp();
        }

        [Then(@"I click on Create Collection Event button from Add New Product page")]
        public void ThenIClickOnCreateCollectionEventButtonFromAddNewProductPage()
        {
            bool checkOnCollectionEvent = pages.addNewProductPage.ClickOnCreateCollectionEvent();
            Assert.True(checkOnCollectionEvent, "The Collection events is present");
            Console.WriteLine("The Collection events is present");
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I fill out the required fields to Add a new kit")]
        public void ThenIFillOutTheRequiredFieldsToAddANewKit()
        {
            int randomNumber = pages.commonMethodsPage.GetRandomNumber(0, 9999);
            int volume = pages.commonMethodsPage.GetRandomNumber(68, 200);
            string randomName = pages.commonMethodsPage.GenerateName(5);
            string CollectionTime = pages.commonMethodsPage.GetRandomNumber(0, 23).ToString() + pages.commonMethodsPage.GetRandomNumber(0, 59).ToString();
            string startDate = pages.commonMethodsPage.GetFutureDate(5);

            pages.addNewProductPage.FillInCollectionEventForm(randomNumber, randomName, startDate, CollectionTime, volume);
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on the Create Product button")]
        public void ThenIClickOnTheCreateProductButton()
        {
            pages.addNewProductPage.ClickOnCreateProduct();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I verify the information")]
        public void ThenIVerifyTheInformation()
        {
            bool checkOnSuccesfulCreationOfProduct = pages.addNewProductPage.CheckDonorInfo();
            Assert.True(checkOnSuccesfulCreationOfProduct, "The Kit is being created");
            Console.WriteLine("Product Division Grid Label is being displayed, kit created");
        }

        [Then(@"I start to add a new kit")]
        public void ThenIStartToAddANewKit()
        {
            pages.addKitPage = pages.addNewProductPage.CreateAddKitPage();
            pages.commonMethodsPage.TakeScreenShot();
        }
    }
}
