using Flux.Core;
using Flux.Web;
using Flux.TranstemLab.StepHelper.Pages.Product;
using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Flux.TranstemLab.StepHelper.Pages.Donors
{
    public class AddDonorPage : WebPageBase
    {
        private string firstName;
        private string lastName;
        private string birthDate;
        public string donorIDText = string.Empty;

        private readonly By _elementDrAddDonorBtn = By.Id("ContentPlaceHolder1_btnAdd");
        private readonly By _elementDrSaveBtn = By.Id("ContentPlaceHolder1_btnSave");
        private readonly By _elementDrSaveSuccessfulMsg = By.Id("ContentPlaceHolder1_lblError");
        private readonly By _elementLogOutLink = By.Id("lnkLogout");
        private readonly By _elementLogOutButton = By.LinkText("Log Out");
        private readonly By _elementLogOutName = By.Name("ctl00$searchBlock1$ctl02");
        private readonly By _elementLogOut = By.Id("crtlLogInOut_lnkLogout");
        private readonly By _elementFirstNameField = By.Id("ContentPlaceHolder1_txtDonorFirstName");
        private readonly By _elementLastNameField = By.Id("ContentPlaceHolder1_txtDonorLastName");
        private readonly By _elementBirthDateField = By.Id("ContentPlaceHolder1_txtBirthDate");
        private readonly By _elementProductIcon = By.Name("ctl00$searchBlock1$ctl03");
        private readonly By _elementProductLink = By.XPath("(//SPAN[text()='Products'][text()='Products'])[1]");
        private readonly By _elementProductSearch = By.Id("searchBlock1_pnlProductSearchCollapse");
        private readonly By _elementDonorIDField = By.Id("ContentPlaceHolder1_spnDonorId");

        //This method is for click on Add Donor Button form Add Donor page
        public void ClickOnAddDonorBtn()
        {
            if (Actions.IsDisplayed(_elementDrAddDonorBtn))
            {
                Actions.Click(_elementDrAddDonorBtn);
            }
        }
        //This method is for entering all the values for creating Donor from Donor management page
        public void EnterAllFileds(string FirstName, string LastName, string MaidenName, string MRN, string InternalDonorID,
            string RegistryID, string Email, string BirthDate, string Weight, string Height, string SSN, string Address,
            string Apartment, string City, string ZipCode, string HomePhone, string WorkPhone, string CellPhone)
        {
            ArrayList allFieldsName = new ArrayList();
            allFieldsName.Add(FirstName);
            allFieldsName.Add(LastName);
            allFieldsName.Add(MaidenName);
            allFieldsName.Add(MRN);
            allFieldsName.Add(InternalDonorID);
            allFieldsName.Add(RegistryID);
            allFieldsName.Add(Email);
            allFieldsName.Add(Weight);
            allFieldsName.Add(Height);
            allFieldsName.Add(SSN);
            allFieldsName.Add(Address);
            allFieldsName.Add(Apartment);
            allFieldsName.Add(City);
            allFieldsName.Add(ZipCode);
            allFieldsName.Add(HomePhone);
            allFieldsName.Add(WorkPhone);
            allFieldsName.Add(CellPhone);
            allFieldsName.Add(BirthDate);

            ArrayList allFieldsNameID = new ArrayList() {"DonorFirstName", "DonorLastName", "DonorMaidenName", "DonorMrn",
                "InternalDonorID", "RegistryID", "Email", "Weight","Height","SSNLastFour","Address","AptSuite","City",
                "ZipCode","HomePhone", "WorkPhone","CellPhone","BirthDate"};

            for (int i = 0; i < allFieldsNameID.Count; i++)
            {
                By _elementFieldsName = By.Id("ContentPlaceHolder1_txt" + allFieldsNameID[i] + "");
                if (Convert.ToString(allFieldsNameID[i]) == "ZipCode" || Convert.ToString(allFieldsNameID[i]) == "WorkPhone" || Convert.ToString(allFieldsNameID[i]) == "CellPhone" || Convert.ToString(allFieldsNameID[i]) == "HomePhone")
                {
                    string clickLeftNineTimes = string.Empty;
                    for (int j = 0; j < 12; j++)
                    {
                        clickLeftNineTimes += Keys.Left;
                    }
                    Actions.FindElement(_elementFieldsName).SendKeys(clickLeftNineTimes + Convert.ToString(allFieldsName[i]));
                }
                else
                {
                    Actions.Click(_elementFieldsName);
                    Actions.FindElement(_elementFieldsName).SendKeys(Convert.ToString(allFieldsName[i]));
                }

                Console.WriteLine("Entered value : " + Convert.ToString(allFieldsName[i]) + " to " + allFieldsNameID[i] + " Field");
            }

            //Below method is for entering the values in dropdown box for "Gender", "ABORhType", "State", "Country", "DispositionID"
            string[] dropDownListOptionsFromDonor = new string[] { "Gender", "ABORhType", "State", "Country", "DispositionID" };

            for (int j = 0; j < dropDownListOptionsFromDonor.Length; j++)
            {
                By _elementListOptionsFromDonor = By.Id("ContentPlaceHolder1_ddl" + dropDownListOptionsFromDonor[j]);
                ReadOnlyCollection<IWebElement> lstFromDonor = Actions.FindElements(_elementListOptionsFromDonor);
                Console.WriteLine("The count is " + lstFromDonor.Count);
                IList<string> strList = new List<string>();

                for (int i = 0; i < lstFromDonor.Count; i++)
                {
                    strList.Add(lstFromDonor[i].Text);
                    Console.WriteLine("The value is " + lstFromDonor[i].Text + "The count is " + i);
                }

                String[] valuesFromDropDown = strList.ToArray();
                foreach (string strValues in valuesFromDropDown)
                {
                    Console.Write("Values present in drop drop list : " + strValues + ",");
                }

                Actions.SelectByRandoxIndex(_elementListOptionsFromDonor);
                Console.WriteLine(Actions.GetAttributeValue(_elementListOptionsFromDonor, "value") + " is selected for " + dropDownListOptionsFromDonor[j]);

            }
        }

        //This method is for clicking on save button on donor management page while creating donor
        public DonorHomePage ClickOnSaveButton()
        {
            Actions.Click(_elementDrSaveBtn);
            if (Actions.IsDisplayed(_elementDrSaveSuccessfulMsg))
            {
                Console.WriteLine("Donor created successfully");
            }
            return CreateInstance<DonorHomePage>();
        }

        public int GetTheCreatedDonorID()
        {
            By _elementDonorID = By.XPath("//span[@id='ContentPlaceHolder1_spnDonorId'][text()]");
            String DonorID = Actions.FindElement(_elementDonorID).Text;
            return Convert.ToInt32(DonorID);
        }

        //This Method is for clicking on Document plus sign from donor page
        public void ClickOnAddDocumentsBtn(String TypeButton)
        {
            //Note, Document,ContentPlaceHolder1_btnAddNote,ContentPlaceHolder1_btnAddDocument
            By _elementDocuments = By.Id("ContentPlaceHolder1_btnAdd" + TypeButton + "");

            if (Actions.IsEnabled(_elementDocuments))
            {

                Waits.WaitForElementToBePresent(_elementDocuments, WaitType.Large);
                Actions.Click(_elementDocuments);
            }
            Console.WriteLine("Clicked on Add" + TypeButton + " plus sign from the RecipientDetail page");
        }

        //Navigate to search product page
        public ProductSearchPage NavigateToProduct()
        {
            Actions.MouseHover(_elementProductIcon);
            Actions.Click(_elementProductLink);
            Actions.Click(_elementProductSearch);

            return CreateInstance<ProductSearchPage>();
        }

        public DonorCollectionEventsPage CreateDonorCollectionPage()
        {
            return CreateInstance<DonorCollectionEventsPage>();
        }

        //This method is to get the donor information
        public void GetDonorInfo()
        {
            firstName = Actions.GetAttributeValue(_elementFirstNameField, "value");
            lastName = Actions.GetAttributeValue(_elementLastNameField, "value");
            birthDate = Actions.GetAttributeValue(_elementBirthDateField, "value");
            Console.WriteLine("First name is: " + firstName +
                ", and the Last name is: " + lastName +
                ", and the Date of birth is: " + birthDate);
        }

        public string GetFirstName() { return firstName; }
        public string GetLastName() { return lastName; }
        public string GetBirthDate() { return birthDate; }
        public string GetDonorID() { return donorIDText; }

        //Get the DonorID to create product
        public void SetDonorID()
        {
            donorIDText = Actions.GetText(_elementDonorIDField);
        }

        /* Logout
          public TranstemLabLoginPage ClickLogOut()
          {
              if (Actions.IsDisplayed(_elementLogOutLink))
              {
                  Actions.Click(_elementLogOutLink);
                  Console.WriteLine("Log Out Successful");
              }
              else if (Actions.IsDisplayed(_elementLogOutName))
              {
                  Actions.Click(_elementLogOutName);
                  Console.WriteLine("Log Out Successful");
              }
              else
              {
                  Actions.Click(_elementLogOut);
                  Console.WriteLine("Log Out Successful");
              }
              return CreateInstance<TranstemLabLoginPage>();
          }*/
    }       
           
    
}
