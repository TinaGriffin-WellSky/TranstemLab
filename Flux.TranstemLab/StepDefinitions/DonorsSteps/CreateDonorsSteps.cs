using Flux.TranstemLab.StepHelper.Base;
using System;
using TechTalk.SpecFlow;

namespace Flux.TranstemLab.StepDefinitions
{
    [Binding]
    public class CreateDonorsSteps : TranstemLabTestBase
    {
        private readonly Pages pages;
        private string FirstName;
        private string LastName;
        private string MaidenName;
        private string MRN;
        private string InternalDonorId;
        private string RegistryID;
        private string Email;
        private string BirthDate;
        private string Weight;
        private string Height;
        private string SSNLastFour;
        private string Address;
        private string Apartment;
        private string City;
        private string ZipCode;
        private string HomePhone;
        private string WorkPhone;
        private string CellPhone;

        public CreateDonorsSteps(Pages pages)
        {
            this.pages = pages;
        }

        [Then(@"I click on Donors Link to create a Donor")]
        public void ThenIClickOnDonorLinktocreateADonor()
        {
            //  pages.donorCollectionEventsPage = pages.transtemLabHomePage.ClickOnDonorLink();
            //  Console.WriteLine("Donor Page opened successfully");

            pages.addDonorPage = pages.transtemLabHomePage.ClickOnDonorLinkToAdd();
            pages.commonMethodsPage.TakeScreenShot();
            Console.WriteLine("Donor Page opened successfully");
        }

        [Then(@"I click on Add donor button")]
        public void ThenIClickOnAddDonorButton()
        {
            pages.addDonorPage.ClickOnAddDonorBtn();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I enter donor personal information (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*) in to the page")]
        public void ThenIEnterDonorPersonalInformationFNLNMNMRNIIDRIDMail_ComInToThePage(string firstName, string lastName, string maidenName, string mRN, string internalDonorID, string registryID, string email, string birthDate, string weight, string height, string sSNLastFour)
        {
            pages.commonMethodsPage = pages.transtemLabHomePage.ReferenceForCommonMethods();
            string Randomnames = pages.commonMethodsPage.GenerateName(3);
            int RandomNumbers = pages.commonMethodsPage.GetRandomNumber(1, 100);
            BirthDate = pages.commonMethodsPage.GetFutureDate(2);
            Weight = pages.commonMethodsPage.GetRandomNumber(50, 200).ToString();
            SSNLastFour = pages.commonMethodsPage.GetRandomNumber(1000, 9999).ToString();
            Height = pages.commonMethodsPage.GetRandomNumber(90, 230).ToString();
            String RandomEmail = Randomnames + email;

            FirstName = firstName + "_" + Randomnames;
            LastName = lastName + "_" + Randomnames;
            MaidenName = maidenName + "_" + Randomnames;
            MRN = mRN + "_" + Randomnames + "_" + RandomNumbers;
            InternalDonorId = internalDonorID + "_" + RandomNumbers;
            RegistryID = registryID + "_" + RandomNumbers;
            Email = RandomEmail;
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I enter donor demographic information (.*), (.*), (.*), (.*), (.*), (.*) and (.*) in to the page")]
        public void ThenIEnterDonorDemographicInformationAddCityAndInToThePage(string address, string apartment, string city, string zipCode, string homePhone, string workPhone, string cellPhone)
        {
            string Randomnames = pages.commonMethodsPage.GenerateName(3);
            int RandomNumbers = pages.commonMethodsPage.GetRandomNumber(1, 100);
            Address = address + "_" + Randomnames + "_" + RandomNumbers;
            Apartment = apartment + "_" + Randomnames + "_" + RandomNumbers;
            City = city + "_" + Randomnames;
            ZipCode = pages.commonMethodsPage.GetRandomNumber(10000, 99999).ToString();
            HomePhone = pages.commonMethodsPage.GeneratePhoneNumbers().ToString();
            WorkPhone = pages.commonMethodsPage.GeneratePhoneNumbers().ToString();
            CellPhone = pages.commonMethodsPage.GeneratePhoneNumbers().ToString();
            pages.addDonorPage.EnterAllFileds(FirstName, LastName, MaidenName, MRN, InternalDonorId, RegistryID, Email, BirthDate, Weight, Height, SSNLastFour, Address, Apartment, City, ZipCode, HomePhone, WorkPhone, CellPhone);
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on the Save Button from page")]
        public void ThenIClickOnTheSaveButtonFromPage()
        {
            pages.donorHomePage = pages.addDonorPage.ClickOnSaveButton();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I will create collection event")]
        public void ThenIWillCreateCollectionEvent()
        {
            pages.donorCollectionEventsPage = pages.addDonorPage.CreateDonorCollectionPage();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I Start to Add a Product")]
        public void ThenIStartToAddAProduct()
        {
            pages.productSearchPage = pages.addDonorPage.NavigateToProduct();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I Start to Add a Product from Donor home page")]
        public void ThenIStartToAddAProductFromDonorHomePage()
        {
            pages.productSearchPage = pages.donorHomePage.NavigateToProduct();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I save donor information")]
        public void ThenISaveDonorInformation()
        {
            pages.addDonorPage.GetDonorInfo();
            pages.commonMethodsPage.TakeScreenShot();
        }
    }
}
