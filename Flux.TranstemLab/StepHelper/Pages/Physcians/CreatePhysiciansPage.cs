using Flux.Core;
using Flux.Web;
using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Flux.TranstemLab.StepHelper.Pages.Physicians
{
    public class CreatePhysiciansPage : WebPageBase
    {
        private readonly By _elementEntityManagement = By.XPath("//li/a[text()='Entity Management']");
        private readonly By _elementPhysicians = By.XPath("//div[@id='cssmenu']//a[text()= 'Entity Management']/following-sibling::ul//li[2]/a/span");
        //div[@id='cssmenu']//a[text()= 'Entity Management']/following-sibling::ul//li[2]/a/span
        //By.XPath("//*[@id='cssmenu']/ul/li[6]/ul/li[2]/a/span[text()='Physicians']");
        private readonly By _elementPhysiciansSearchHeading = By.XPath("//div//fieldset//legend[text()='Physician Search']");
        private readonly By _elementAddPhyButton = By.XPath("//*[@id='AddPhysButton']");
        private readonly By _elementPhysiciansSaveButton = By.XPath("//input[@type='image'][@src='../../Content/images/ctimssave.jpg']");

        public CreatePhysiciansPage ClickOnAddPhysiciansButton()
        {
            if (Actions.IsDisplayed(_elementAddPhyButton))
            {
                Waits.WaitForElementToBeClickable(_elementAddPhyButton, WaitType.Large);
                Actions.Click(_elementAddPhyButton);
                if (Actions.IsDisplayed(_elementPhysiciansSaveButton))
                {
                    Console.WriteLine("Clicked on Add Facility Button ");
                }
            }
            return CreateInstance<CreatePhysiciansPage>();
        }

        //This method is for entering the values for CreatingPhysicians
        public CreatePhysiciansPage EnterAllTheValuesForCreatingPhysicians(List<string> userdata)
        {
            //Entering the Values for First Name, Last Name, Address, city, Postal Code, Primary Phone, Fax Number, Email in page
            ArrayList allFieldsNameID = new ArrayList() { "FirstName", "LastName", "Address", "City", "PostalCode", "PrimaryPhone", "FaxNumber", "Email" };

            for (int i = 0; i < allFieldsNameID.Count; i++)
            {
                By _elementFieldsName = By.Id("" + allFieldsNameID[i] + "");
                //Thread.Sleep(2000);
                Actions.FindElement(_elementFieldsName).SendKeys(userdata[i]);
            }

            //Selecting the values from Drop-Down List for "Type" and "State"

            string[] dropDownListOptionsFromPhysicians = new string[] { "PhysicianTypes", "States" };

            for (int j = 0; j < dropDownListOptionsFromPhysicians.Length; j++)
            {
                By _elementListOptionsFromPhysicians = By.XPath("//select[@id='" + dropDownListOptionsFromPhysicians[j] + "_SelectedId']//option");

                ReadOnlyCollection<IWebElement> lstFromPhysicians = Actions.FindElements(_elementListOptionsFromPhysicians);
                IList<string> strList = new List<string>();


                for (int i = 0; i < lstFromPhysicians.Count; i++)
                {
                    strList.Add(lstFromPhysicians[i].Text);
                }

                String[] valuesFromDropDown = strList.ToArray();
                foreach (string strValues in valuesFromDropDown)
                {
                    Console.Write("Values present in drop drop list : " + strValues + ",");
                }
                Console.WriteLine();

                for (int i = 0; i < lstFromPhysicians.Count; i++)
                {
                    if (lstFromPhysicians.Count > 1)
                    {
                        lstFromPhysicians[2].Click();
                        break;
                    }
                    else
                    {
                        lstFromPhysicians[1].Click();
                        break;
                    }

                    Console.WriteLine(lstFromPhysicians[i].Text + " is selected from the " + dropDownListOptionsFromPhysicians[j] + " dropDown");

                }
            }
            return CreateInstance<CreatePhysiciansPage>();
        }


        //This method is for clicking on save button on Physicians page while creating Physicians
        public void ClickOnPhysiciansSaveButton()
        {
            Actions.Click(_elementPhysiciansSaveButton);
            if (Actions.IsDisplayed(_elementPhysiciansSaveButton))
            {
                Console.WriteLine("Clicked on SAVE Button");
                Console.WriteLine("Facility created successfully");
            }
        }
    }
}
