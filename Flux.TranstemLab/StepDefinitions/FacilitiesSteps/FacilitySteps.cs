using Flux.TranstemLab.StepHelper.Base;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Flux.TranstemLab.StepDefinitions.Facilities
{
    [Binding]
    public class FacilitySteps : TranstemLabTestBase
    {

        private readonly Pages pages;
        public FacilitySteps(Pages pages)
        {
            this.pages = pages;
        }

        [Given(@"I click on Entity Management option from Home page")]
        public void GivenIClickOnEntityManagementOptionFromHomePage()
        {
            pages.createFacilityPage = pages.transtemLabHomePage.ClickOnEntityManagementForFacilities();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Given(@"I click on Add Facility button")]
        public void GivenIClickOnAddFacilityButton()
        {
            pages.createFacilityPage.ClickOnAddFacilityButton();
            pages.commonMethodsPage.TakeScreenShot();
        }

        public List<string> DataFromTable = new List<string>();
        [Then(@"I enter values Name Address city PostalCode & Type status Region state in page")]
        public void ThenIEnterValuesNameAddressCityPostalCodeTypeStatusRegionStateInPage(Table table)
        {
            pages.commonMethodsPage = pages.transtemLabHomePage.ReferenceForCommonMethods();
            string RandomNames = pages.commonMethodsPage.GenerateName(2);
            int RandomNumbers = pages.commonMethodsPage.GetRandomNumber(1, 9);
            var details = table.CreateSet<FacilityDetails>();
            foreach (FacilityDetails userData in details)
            {
                DataFromTable.Add(userData.Name + "_" + RandomNames);
                DataFromTable.Add(userData.Address + "_" + RandomNames + "_Street" + RandomNumbers);
                DataFromTable.Add(userData.City + "_" + RandomNames + "_Landmark" + RandomNumbers);
                DataFromTable.Add(userData.PostalCode + pages.commonMethodsPage.GetRandomNumber(111111, 999999));
            }
            pages.createFacilityPage.EnterAllTheValuesForCreatingFacility(DataFromTable);
            pages.createFacilityPage.SelectDDL();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I Click on Save Button from Facility page")]
        public void ThenIClickOnSaveButtonFromFacilityPage()
        {
            pages.createFacilityPage.ClickOnFacilitySaveButton();
            pages.commonMethodsPage.TakeScreenShot();
        }
    }
}
