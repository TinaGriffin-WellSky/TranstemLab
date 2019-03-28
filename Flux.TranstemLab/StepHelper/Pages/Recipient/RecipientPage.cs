using Flux.Core;
using Flux.Web;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Flux.TranstemLab.StepHelper.Pages.Recipient
{
    public class RecipientPage : WebPageBase
    {
        private string firstName;
        private string lastName;
        private string mRN;
        private string id;
        private string recipientId;

        private readonly By _elementRcpAddRecipientBtn = By.Id("ContentPlaceHolder1_btnAdd");
        private readonly By _elementRcpSaveBtn = By.Id("ContentPlaceHolder1_btnSave");
        private readonly By _elementRcpSaveSuccessfulMsg = By.Id("ContentPlaceHolder1_lblError");
        private readonly By _ElementUploadButtonFromFileUploadPage = By.Id("ContentPlaceHolder1_ctrlFileUpload_btnUpload");
        private readonly By _elementFirstNameField = By.Id("ContentPlaceHolder1_txtPatientFirstName");
        private readonly By _elementLasrNameField = By.Id("ContentPlaceHolder1_txtPatientLastName");
        private readonly By _elementMRNField = By.Id("ContentPlaceHolder1_txtMedRecordNum");
        private readonly By _elementHomePageIcon = By.Name("ctl00$searchBlock1$ctl00");
        private readonly By _elementRecipientIdField = By.Id("ContentPlaceHolder1_txtPatientCode");
        private readonly By _elementIdField = By.Id("ContentPlaceHolder1_spnPatientId");
        private readonly By _elementEditTransplantEvent = By.CssSelector("span[title='Edit Transplant Event']");
        private readonly By _elementRequestUnitField = By.Id("txtRequestedUnit");
        private readonly By _elementAddRequestedUnitBtn = By.Id("btnAddRequestedUnit");
        private readonly By _elementCheckbox = By.CssSelector("input[type='checkbox']");
        private readonly By _elementSaveBtnFromEditTransplantEvent = By.XPath("//div[@id='dlgTransplantEvent']/following-sibling::div//span[text()='Save']");

        //This method is for clicking on ADD button from Recipient page
        public RecipientPage ClickOnAddRecipientBtn()
        {
            if (Actions.IsDisplayed(_elementRcpAddRecipientBtn))
            {
                Actions.Click(_elementRcpAddRecipientBtn);
            }
            return CreateInstance<RecipientPage>();
        }

        //This method is for entering the values in all the fields in RecipientPage
        public RecipientPage EnterAllFields(string RecipientID, string FirstName, string LastName, string MedicalRecord, string CRID, string RegistryID, string BirthDate)
        {
            ArrayList allFieldsName = new ArrayList();
            allFieldsName.Add(RecipientID);
            allFieldsName.Add(FirstName);
            allFieldsName.Add(LastName);
            allFieldsName.Add(MedicalRecord);
            allFieldsName.Add(CRID);
            allFieldsName.Add(RegistryID);
            allFieldsName.Add(BirthDate);
            int count = allFieldsName.Count;
            ArrayList allFieldsNameID = new ArrayList() { "PatientCode", "PatientFirstName", "PatientLastName", "MedRecordNum", "CRID", "RegistryId", "DOB" };
            for (int i = 0; i < allFieldsNameID.Count; i++)
            {
                By _elementFieldsName = By.Id("ContentPlaceHolder1_txt" + allFieldsNameID[i] + "");
                //Thread.Sleep(2000);
                Actions.Click(_elementFieldsName);
                Actions.FindElement(_elementFieldsName).SendKeys(Convert.ToString(allFieldsName[i]));
                Console.WriteLine("Entered value : " + Convert.ToString(allFieldsName[i]) + " to " + allFieldsNameID[i] + " Field");
            }

            string[] dropDownListOptionsFromRecipient = new string[] { "Gender", "Ethnicity", "RecipientStatus" };

            for (int j = 0; j < dropDownListOptionsFromRecipient.Length; j++)
            {
                By _elementListOptionsFromRecipient = By.XPath("//select[@id='ContentPlaceHolder1_ddl" + dropDownListOptionsFromRecipient[j] + "']//option");
                ReadOnlyCollection<IWebElement> lstFromRecipient = Actions.FindElements(_elementListOptionsFromRecipient);
                IList<string> strList = new List<string>();

                for (int i = 0; i < lstFromRecipient.Count; i++)
                {
                    strList.Add(lstFromRecipient[i].Text);
                }

                string[] valuesFromDropDown = strList.ToArray();
                foreach (string strValues in valuesFromDropDown)
                {
                    Console.Write("Values present in drop drop list : " + strValues + ",");
                }
                Console.WriteLine();
                for (int i = 0; i < lstFromRecipient.Count; i++)
                {
                    if (lstFromRecipient.Count > 1)
                    {
                        //Thread.Sleep(2000);
                        lstFromRecipient[2].Click();
                    }
                    else
                    {
                        //Thread.Sleep(2000);
                        lstFromRecipient[1].Click();
                    }
                    Console.WriteLine(lstFromRecipient[i].Text + " is selected from the " + dropDownListOptionsFromRecipient[j] + " dropDown");
                }
            }
            return CreateInstance<RecipientPage>();
        }

        //This method is for Clicking on SAVE Button for creating the Recipent 
        public RecipientPage ClickOnSaveButton()
        {
            Actions.Click(_elementRcpSaveBtn);
            if (Actions.IsDisplayed(_elementRcpSaveSuccessfulMsg))
            {
                Console.WriteLine("Recipient created successfully");
            }
            Waits.WaitForPageLoad();
            return CreateInstance<RecipientPage>();
        }

        public void setRecipientInfo()
        {
            firstName = Actions.GetAttributeValue(_elementFirstNameField, "value");
            lastName = Actions.GetAttributeValue(_elementLasrNameField, "value");
            mRN = Actions.GetAttributeValue(_elementMRNField, "value");
            id = Actions.GetAttributeValue(_elementIdField, "value");
            recipientId = Actions.GetAttributeValue(_elementRecipientIdField, "value");
        }

        public string GetFirstName() { return firstName; }
        public string GetLastName() { return lastName; }
        public string GetMRN() { return mRN; }
        public string Getid() { return id; }
        public string GetRecipientId() { return recipientId; }

        //this method is used for click on the home page
        public void navigateToHomePage()
        {
            //Thread.Sleep(3000);
            if (Actions.IsDisplayed(_elementHomePageIcon))
            {
                Actions.Click(_elementHomePageIcon);
            }
        }

        public bool CheckRecipientInfo()
        {
            if (Actions.GetAttributeValue(_elementFirstNameField, "value") == firstName)
            {
                Console.WriteLine("Test passed!");
                return true;
            }
            else return false;
        }

        //this method is used to click on edit transplant event
        public void EditTransplantEvent()
        {
            Assert.True(Actions.IsDisplayed(_elementEditTransplantEvent), "Edit transplant button is not shown");
            Actions.Click(_elementEditTransplantEvent);
            Console.WriteLine("edit transplant event pop window is open");
        }

        //this method is used to fill in the product ID to the Requested unit field
        public void FillInRequestedUnitField(string productId)
        {
            Assert.True(Actions.IsDisplayed(_elementRequestUnitField), "Requested unit field is not shown");
            Actions.SendKeys(_elementRequestUnitField, productId);
            Console.WriteLine(productId + " is entered in Requested Unit field");
        }

        //this method is used to click on the add button in the edit transplant event popup
        public void ClickAddbtn()
        {
            Assert.True(Actions.IsDisplayed(_elementAddRequestedUnitBtn), "Add button is not shown");
            Actions.Click(_elementAddRequestedUnitBtn);
            //  Waits.WaitForElementToBeInvisible(_elementCheckbox, WaitType.Medium);
            Console.WriteLine("Check box is present");
            Actions.Click(_elementCheckbox);
            Console.WriteLine("check box is clicked");
            Actions.Click(_elementSaveBtnFromEditTransplantEvent);
            //Waits.WaitForElementToBeInvisible(_elementSaveBtnFromEditTransplantEvent, WaitType.Large);
            //Thread.Sleep(2000);
            Waits.WaitForPageLoad();
        }
    }
}
