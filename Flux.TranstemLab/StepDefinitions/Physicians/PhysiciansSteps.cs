using Flux.TranstemLab.StepHelper.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Flux.TranstemLab.StepDefinitions.Physicians
{
    [Binding]
    public  class PhysiciansSteps : TranstemLabTestBase
    {

        private readonly Pages pages;
        public PhysiciansSteps(Pages pages)
        {
            this.pages = pages;
        }

        [Given(@"I click on Entity Management option from Home page for Physicians")]
        public void GivenIClickOnEntityManagementOptionFromHomePageForPhysicians()
        {
            pages.createPhysiciansPage = pages.transtemLabHomePage.ClickOnEntityManagementForPhysicians();
        }

        [Then(@"I click on Physicians option from Home page")]
        public void ThenIClickOnPhysiciansOptionFromHomePage()
        {
            pages.createPhysiciansPage.ClickOnPhysicians();

        }

        [Then(@"I click on Add Physicians button")]
        public void ThenIClickOnAddPhysiciansButton()
        {
            Thread.Sleep(5000);
            pages.createPhysiciansPage.ClickOnAddPhysiciansButton();
        }

        public List<string> DataFromTableforPhysicians = new List<string>();
        [Then(@"I enter values First Name Last Name Address city Postal Code Primary Phone Fax Number Email in page")]
        public void ThenIEnterValuesFirstNameLastNameAddressCityPostalCodePrimaryPhoneFaxNumberEmailInPage(Table table)
        {
            pages.commonMethodsPage = pages.transtemLabHomePage.ReferenceForCommonMethods();
            string RandomNames = pages.commonMethodsPage.GenerateName(4);
            int RandomNumbers = pages.commonMethodsPage.GetRandomNumber(1, 9);
            var details = table.CreateSet<PhysiciansDetails>();
            foreach (PhysiciansDetails userData in details)
            {
                DataFromTableforPhysicians.Add(userData.FirstName+ RandomNames);
                DataFromTableforPhysicians.Add(userData.LastName + RandomNames);
                DataFromTableforPhysicians.Add(userData.Address + RandomNames + "_Landmark_" + RandomNumbers);
                DataFromTableforPhysicians.Add(userData.city + RandomNames+"_Street_"+ RandomNumbers);
                DataFromTableforPhysicians.Add(userData.PostalCode + pages.commonMethodsPage.GetRandomNumber(111111,999999));
                DataFromTableforPhysicians.Add(userData.PrimaryPhone +pages.commonMethodsPage.GeneratePhoneNumbers());
                DataFromTableforPhysicians.Add(userData.FaxNumber + pages.commonMethodsPage.GeneratePhoneNumbers());
                DataFromTableforPhysicians.Add(RandomNames + userData.Email);
                
            }
            pages.createPhysiciansPage.EnterAllTheValuesForCreatingPhysicians(DataFromTableforPhysicians);
            }

        [Then(@"I Click on Save Button from Physicians page")]
        public void ThenIClickOnSaveButtonFromPhysiciansPage()
        {
            pages.createPhysiciansPage.ClickOnPhysiciansSaveButton();

        }


    }
}
