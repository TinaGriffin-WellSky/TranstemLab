using Flux.Core;
using Flux.Web;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Flux.TranstemLab.StepHelper.Pages.Recipient
{
    public class TransplantEventPage : WebPageBase
    {

        private readonly By _elementSaveBtnFromEditTransplantEvent = By.XPath("//div[@id='dlgTransplantEvent']/following-sibling::div//span[text()='Save']");
        private readonly By _ElementRecipientID = By.XPath("//span[@id='ContentPlaceHolder1_spnPatientId'][text()]");

        public string[] dropDownListOptionsFromAddaTransplantEventPage = new string[] { "transplantStatus", "ContentPlaceHolder1_ddlDonorType", "ddlTransplantABORh", "transplantCMVStatus", "transplantEBVStatus", "ContentPlaceHolder1_ddlTransplantDisease", "ContentPlaceHolder1_ddlSpecificDisease", "ContentPlaceHolder1_ddlDiseaseStatusAtTransplant" };

        public TransplantEventPage EnterFieldsInAddaTransplantEvent(String DateOfNeedOrTransplantDate, int WeightKg, String LastContact)
        {

            for (int j = 0; j < dropDownListOptionsFromAddaTransplantEventPage.Length; j++)
            {
                Console.WriteLine("Performing the selection on : " + dropDownListOptionsFromAddaTransplantEventPage[j] + " drop down");
                By _elementListOptionsFromAddaTransplantEventPage = By.XPath("//select[@id='" + dropDownListOptionsFromAddaTransplantEventPage[j] + "']//option");
                Waits.WaitForPageLoad();
                ReadOnlyCollection<IWebElement> lstFromAddaTransplantEventPage = Actions.FindElements(_elementListOptionsFromAddaTransplantEventPage);
                IList<string> strList = new List<string>();

                for (int i = 0; i < lstFromAddaTransplantEventPage.Count; i++)
                {
                    strList.Add(lstFromAddaTransplantEventPage[i].Text);
                }
                Console.Write("Values present in drop drop list : " + strList + ",");

                string[] valuesFromDropDown = strList.ToArray();
                foreach (string strValues in valuesFromDropDown)
                {
                    Console.Write("Values present in drop drop list : " + strValues + ",");
                }
                Console.WriteLine();
                for (int i = 0; i < lstFromAddaTransplantEventPage.Count; i++)
                {
                    string strCheck = lstFromAddaTransplantEventPage[i].Text;
                    //Thread.Sleep(1000);
                    if (strCheck == "-None-" || strCheck == "Unknown")
                    {
                        lstFromAddaTransplantEventPage[i + 1].Click();
                        Console.WriteLine(lstFromAddaTransplantEventPage[i + 1].Text + " is selected from the " + dropDownListOptionsFromAddaTransplantEventPage[j] + " dropDown");
                        break;
                    }
                    else
                    {
                        lstFromAddaTransplantEventPage[i].Click();
                        Console.WriteLine(lstFromAddaTransplantEventPage[i].Text + " is selected from the " + dropDownListOptionsFromAddaTransplantEventPage[j] + " dropDown");
                        break;
                    }
                }

            }
            // Enter the value "Date of Need / Transplant Date: ",  "Weight(kg):", "Last Contact:"
            string[] valuesOfAddaTransplantEventPage = new string[] { "transplantDate", "transplantWeight", "transplantLastContact" };
            object[] ValuesToEnter = new object[] { DateOfNeedOrTransplantDate, WeightKg, LastContact };
            for (int j = 0; j < valuesOfAddaTransplantEventPage.Length; j++)
            {
                By _elementOfAddaTransplantEventPage = By.Id(valuesOfAddaTransplantEventPage[j]);

                if (Actions.IsDisplayed(_elementOfAddaTransplantEventPage))
                {
                    Actions.Click(_elementOfAddaTransplantEventPage);
                    Actions.FindElement(_elementOfAddaTransplantEventPage).SendKeys(Convert.ToString(ValuesToEnter[j]));
                }
            }
            return CreateInstance<TransplantEventPage>();

        }

        //This Method is for Click On Save Btn From Edit Transplant Event page
        public TransplantEventPage ClickOnSaveBtnFromEditTransplantEvent()
        {
            Actions.Click(_elementSaveBtnFromEditTransplantEvent);
            Console.WriteLine("Clicked on SAVE Button from Edit Transplant Event ");
            Waits.WaitForPageLoad();
            //Waits.WaitForElementToBeInvisible(_elementSaveBtnFromEditTransplantEvent, WaitType.Medium);
            //Thread.Sleep(3000);
            return CreateInstance<TransplantEventPage>();
        }

        //This method will return the created RecipientID
        public int GetTheCreatedRecipientID()
        {
            int RecipientID = 0;

            string PatientID = Actions.FindElement(_ElementRecipientID).Text;
            RecipientID = Convert.ToInt32(PatientID);
            return RecipientID;
        }
    }
}
