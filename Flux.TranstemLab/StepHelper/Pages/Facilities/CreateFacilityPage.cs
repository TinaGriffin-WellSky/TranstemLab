using Flux.Core;
using Flux.Web;
using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Flux.TranstemLab.StepHelper.Pages.Facilities
{
    public class CreateFacilityPage : WebPageBase
    {
        private readonly By _elementEntityManagement = By.XPath("//li/a[text()='Entity Management']");
        private readonly By _elementFacilities = By.XPath("//div[@id='cssmenu']//a[text()= 'Entity Management']/following-sibling::ul//li[1]/a/span");
        //By.XPath("//*[@id='cssmenu']/ul/li[6]/ul/li[1]/a/span");
        //div[@id='cssmenu']//a[text()= 'Entity Management']/following-sibling::ul//li[1]/a/span
        private readonly By _elementFacilitySearchHeading = By.XPath("//div//fieldset//legend[text()='Facility Search']");
        private readonly By _elementAddFacButton = By.XPath("//td[@id='AddFacButton']//a//img");
        private readonly By _elementfacilitySaveButton = By.XPath(" //div[@id='facilitySave']");
        private readonly By _elementTypeDDL = By.Id("FacilityTypes_SelectedId");
        private readonly By _elementStatusDDL = By.Id("SelectedActive");
        private readonly By _elementRegionDDL = By.Id("Region_SelectedId");
        private readonly By _elementStateDDL = By.Id("States_SelectedId");

        public CreateFacilityPage ClickOnAddFacilityButton()
        {
            if (Actions.IsDisplayed(_elementAddFacButton))
            {
                Waits.WaitForElementToBeClickable(_elementAddFacButton, WaitType.Large);
                Actions.Click(_elementAddFacButton);
                if (Actions.IsDisplayed(_elementfacilitySaveButton))
                {
                    Console.WriteLine("Clicked on Add Facility Button ");
                }
            }
            return CreateInstance<CreateFacilityPage>();
        }

        //This method is for entering the values for CreatingFacility
        public CreateFacilityPage EnterAllTheValuesForCreatingFacility(List<string> userdata)
        {
            //Entering the Values for "Name", "Address", "City", "PostalCode"
            ArrayList allFieldsNameID = new ArrayList() { "Name", "Address", "City", "PostalCode" };

            for (int i = 0; i < allFieldsNameID.Count; i++)
            {
                By _elementFieldsName = By.Id("" + allFieldsNameID[i] + "");
                Actions.FindElement(_elementFieldsName).SendKeys(userdata[i]);
            }
            return CreateInstance<CreateFacilityPage>();
        }

        //this method is for select ddl in the add facility page
        public void SelectDDL()
        {
            Actions.SelectByRandoxIndex(_elementTypeDDL);
            Console.WriteLine(Actions.GetAttributeValue(_elementTypeDDL, "value") + " is being selected for Type dropdown");
            Actions.SelectByIndex(_elementStateDDL,1);
            Console.WriteLine(Actions.GetAttributeValue(_elementStateDDL, "value") + " is being selected for Status dropdown");
            Actions.SelectByRandoxIndex(_elementRegionDDL);
            Console.WriteLine(Actions.GetAttributeValue(_elementRegionDDL, "value") + " is being selected for region dropdown");
            Actions.SelectByRandoxIndex(_elementStateDDL);
            Console.WriteLine(Actions.GetAttributeValue(_elementStateDDL, "value") + " is being selected for state dropdown");
        }
        //This method is for clicking on save button on Facility page while creating Facility
        public void ClickOnFacilitySaveButton()
        {
            Actions.Click(_elementfacilitySaveButton);
            if (Actions.IsDisplayed(_elementfacilitySaveButton))
            {
                Console.WriteLine("Clicked on SAVE Button");
                Console.WriteLine("Facility created successfully");
            }
        }
    }
}
