using Flux.Web;
using Flux.TranstemLab.StepHelper.Pages.Kit;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;

namespace Flux.TranstemLab.StepHelper.Pages.Product
{
    public class AddNewProductPage : WebPageBase
    {
        public string donorIDText = string.Empty;
        public string donorLastName = string.Empty;
        public string donorFirstName = string.Empty;
        public string ProductId = string.Empty;
        private readonly By _elementScanExistingKidIdRadioBtn = By.Id("rdExistingKitID");
        private readonly By _elementCreateNewKitBtn = By.Id("btnAddNewKit");
        private readonly By _elementKitSaveBtn = By.Id("ContentPlaceHolder1_btnSave");
        private readonly By _elementLoadBtn = By.Id("btnLoadKit");
        private readonly By _elementSyncBtn = By.Id("btnSync");
        private readonly By _elementLastNameField = By.Id("DonorLastName");
        private readonly By _elementFirstNameField = By.Id("DonorFirstName");
        private readonly By _elementBirthDateField = By.Id("DonorDateOfBirth");
        private readonly By _elementRadioBtn = By.Id("ListMatchedDonor_0__DonorSelected");
        private readonly By _elementCreateCollectionEventBtn = By.Id("btnCollectionEvent");
        private readonly By _elementCreateProduct = By.Id("btnCreateProduct");
        private readonly By _elementProductDivisionGridLabel = By.XPath("(//SPAN[text()='Product Division Grid'])[1]");
        private readonly By _elementBypassDonorKit = By.Id("rdBypassDonorKit");
        private readonly By _elementBypassSync = By.Id("btnBypassSync");
        private readonly By _elementCollectionID = By.Id("CollectionId");
        private readonly By _elementCollectionDate = By.Id("CollectionDate");
        private readonly By _elementCollectionTime = By.Id("CollectionTime");
        private readonly By _elementProductType = By.Id("ddlProductType");
        private readonly By _elementProductVol = By.Id("UnitCollectionDatas_0__CordBloofVolume");
        private readonly By _elementProductDescriptionCode = By.Id("ddlProductDescriptionCode");
        //private readonly By _elementProductLink = By.CssSelector("holder");
        private readonly By _elementProductSearch = By.Id("searchBlock1_pnlProductSearchCollapse");
        private readonly By _elementDonorIDField = By.Id("ContentPlaceHolder1_spnDonorId");
        private readonly By _elementProductIcon = By.Name("ctl00$searchBlock1$ctl03");
        private readonly By _elementProductLink = By.XPath("(//SPAN[text()='Products'][text()='Products'])[1]");
        // private readonly By _elementProductSearch = By.XPath("(//SPAN[text()='Search'][text()='Search'])[1]");
        private readonly By _elementSaveCollectionEvent = By.Id("ContentPlaceHolder1_ctrlCollectionEvent_btnSave");
        private readonly By _elementAddProduct = By.Id("ContentPlaceHolder1_btnAdd");
        private readonly By _elementExistingDonorIDRadio = By.Id("rdExistingDonorID");
        private readonly By _elementLoadDonorInField = By.Id("txt_LoadDonorIN");
        private readonly By _elementLoadDonorBtn = By.Id("btnLoadDonorIN");
        private readonly By _elementDonorLastNameField = By.Id("DonorLastName");
        private readonly By _elementDonorFirstNameField = By.Id("DonorFirstName");
        private readonly By _elementClickOnCreateProduct = By.Id("btnCreateProduct");
        private readonly By _elementVolumeFiled = By.Id("UnitCollectionDatas_0__CordBloodVolume");
        private readonly By _elementWeightField = By.Id("UnitCollectionDatas_0__TotalProductWeight");
        private readonly By _elementHomePageIcon = By.CssSelector("img[alt='Home']");

        //This method is to select the Scan/enter existing kit ID or create a new kit radio
        public void SelectExistingKitIDRadio()
        {
            if (Actions.IsDisplayed(_elementScanExistingKidIdRadioBtn))
            {
                Console.WriteLine("Navigated to product search page");
                Actions.Click(_elementScanExistingKidIdRadioBtn);
            }
        }

        //This method is to click on the Create New Kit button
        public void ClickOnCreateNewKitBtn()
        {
            if (Actions.IsDisplayed(_elementCreateNewKitBtn))
            {
                Console.WriteLine("Scan/enter existing kit ID or create a new kit radio selected");
                Actions.Click(_elementCreateNewKitBtn);
            }
        }

        //This method is used to enter the fields to create a new kit( having issue now)
        // MOVE TO CREATE KIT
        public void EnterAllFields(string InHouseID, string LotNumber, string LabelPerKit, string KitExpiration)
        {
            ArrayList allFieldsName = new ArrayList();
            allFieldsName.Add(InHouseID);
            allFieldsName.Add(LotNumber);
            allFieldsName.Add(LabelPerKit);
            allFieldsName.Add(KitExpiration);
            //WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2));

            //fill in all fields
            ArrayList allFieldsID = new ArrayList() { "ClientIdentifier", "LotNumber", "DINQuantity", "KitExpirationDate" };
            for (int i = 0; i < allFieldsID.Count; i++)
            {
                By _elementFieldsName = By.Id("ContentPlaceHolder1_ctrlEditKit_txt" + allFieldsID[i]);
                //Thread.Sleep(1000);
                Actions.Click(_elementFieldsName);
                Actions.FindElement(_elementFieldsName).SendKeys(Convert.ToString(allFieldsName[i]));
                Console.WriteLine("Value entered :" + Convert.ToString(allFieldsName[i]) + " to " + allFieldsID[i] + " Field");
            }

            //Thread.Sleep(1000);

            string[] dropDownListOptionsFromKit = new string[] { "lKitType", "Disposition", "lRegion" };

            for (int j = 0; j < dropDownListOptionsFromKit.Length; j++)
            {

                By _elementListoptionsFromKit = By.XPath("//SELECT[@id='ContentPlaceHolder1_ctrlEditKit_dd" + dropDownListOptionsFromKit[j] + "']");
                //Thread.Sleep(1000);
                ReadOnlyCollection<IWebElement> lstFromKit = Actions.FindElements(_elementListoptionsFromKit);
                IList<string> strList = new List<string>();

                for (int i = 0; i < lstFromKit.Count; i++)
                {
                    strList.Add(lstFromKit[i].Text);
                    Console.WriteLine(lstFromKit[i].Text);
                }

                String[] valuesFromDropDown = strList.ToArray();
                foreach (string strValues in valuesFromDropDown)
                {
                    Console.Write("Values present in drop drop list : " + strValues + ",");

                }
                //Console.WriteLine();
                //Waits.WaitForElementToBeClickable(_elementListoptionsFromKit, WaitType.Medium);
                Thread.Sleep(1000);
                //Waits.WaitForPageLoad();
                //Waits.WaitForPageLoad();
                //wait.Until(ExpectedConditions.ElementToBeClickable(_elementListoptionsFromKit));
                Actions.SelectByRandoxIndex(_elementListoptionsFromKit);
                //wait.Until(ExpectedConditions.ElementToBeSelected(_elementListoptionsFromKit));
                //wait.Until(ExpectedConditions.ElementSelectionStateToBe(_elementListoptionsFromKit, true));
                //wait.Until(ExpectedConditions.)
            }
        }

        //this method is to click on the save button from kit page
        // MOVE TO CREATE KIT
        public void ClickOnSaveButton()
        {
            Actions.Click(_elementKitSaveBtn);
            Waits.WaitForPageLoad();
            if (Actions.IsDisplayed(_elementCreateNewKitBtn))
            {
                Console.WriteLine("Kit created successfully");
            }
            Waits.WaitForPageLoad();
            Waits.WaitForPageLoad();
        }

        //this method is used for click on load button
        public void ClickOnLoadKitButton()
        {
            Actions.Click(_elementLoadBtn);
            if (Actions.IsDisplayed(_elementSyncBtn))
            {
                Console.WriteLine("Match donor information page is open");
            }
        }

        //this method is used to enter donor information for the kit
        public void EnterDonorInfo(string FirstName, string LastName, string BirthDate)
        {
            Actions.SendKeys(_elementFirstNameField, FirstName);
            Actions.SendKeys(_elementLastNameField, LastName);
            Actions.SendKeys(_elementBirthDateField, BirthDate);
        }

        //this method is used to click on sync button
        public void ClickOnSyncButton()
        {
            Actions.Click(_elementSyncBtn);
        }

        //this method is used to select the radio and accept the pop up window
        public void SelectRadioButtonAndAcceptPopUp()
        {
            if (Actions.IsDisplayed(_elementRadioBtn))
            {
                Console.WriteLine("Donor is being matched");
                Actions.Click(_elementRadioBtn);
                Actions.AcceptAlert();
            }
        }

        //this method is used to click on the Create Collection Event button
        public bool ClickOnCreateCollectionEvent()
        {
            Actions.Click(_elementCreateCollectionEventBtn);
            Waits.WaitForPageLoad();
            //Thread.Sleep(4000);
            if (Actions.IsDisplayed(_elementCreateProduct))
                return true;

            else return false;
        }

        //this method is ued to fill out the collectio event
        public void FillInCollectionEventForm(int RandomNumbers, string RandomNames, string StartDate, string CollectionTime, int volume)
        {
            string strdonorIDText = RandomNumbers + RandomNames;
            ArrayList allFieldsName = new ArrayList();
            allFieldsName.Add(strdonorIDText);
            allFieldsName.Add(StartDate);
            allFieldsName.Add(CollectionTime);
            allFieldsName.Add(volume);
            allFieldsName.Add(volume);

            ArrayList allFieldNameId = new ArrayList() { "CollectionId", "CollectionDate", "CollectionTime", "UnitCollectionDatas_0__TotalProductWeight", "UnitCollectionDatas_0__CordBloodVolume" };

            for (int i = 0; i < allFieldNameId.Count; i++)
            {
                By _elementFieldsName = By.Id(allFieldNameId[i].ToString());

                Actions.Click(_elementFieldsName);
                Actions.FindElement(_elementFieldsName).SendKeys(Convert.ToString(allFieldsName[i]));
                Console.WriteLine("Entered value : " + Convert.ToString(allFieldsName[i]) + " to " + allFieldNameId[i] + " Field");
            }

            string[] collectionEventFormDDL = new string[] { "TimeZone", "ProductType", "NumberOfDivisions", "Hospitals", "CollectorId", "ProductDescriptionCode", "DonationType" };

            for (int j = 0; j < collectionEventFormDDL.Length; j++)
            {
                By _elementListOptionFromCreateCollectionForm = By.Id("ddl" + collectionEventFormDDL[j]);
                ReadOnlyCollection<IWebElement> lstFromCreateCollectionForm = Actions.FindElements(_elementListOptionFromCreateCollectionForm);
                IList<string> strList = new List<string>();

                for (int i = 0; i < lstFromCreateCollectionForm.Count; i++)
                {
                    strList.Add(lstFromCreateCollectionForm[i].Text);
                    Console.WriteLine("The value is " + lstFromCreateCollectionForm[i].Text + "The count is " + lstFromCreateCollectionForm.Count);
                }

                string[] valuesFromDropDown = strList.ToArray();
                foreach (string strValues in valuesFromDropDown)
                {
                    Console.WriteLine("Values present in drop down list : " + strValues + ",");
                }

                Console.WriteLine();
                Actions.SelectByRandoxIndex(_elementListOptionFromCreateCollectionForm);
            }
            //Thread.Sleep(2000);
        }

        //This method is used for create product
        public void ClickOnCreateProduct()
        {
            Assert.True(Actions.IsDisplayed(_elementCreateProduct), "Could not locate Create Product button");
            Actions.Click(_elementCreateProduct);
            Waits.WaitForPageLoad();
            Console.WriteLine("Clicked on Create Product");
            //Thread.Sleep(12000);
        }

        //this method is to check if the donor match
        public bool CheckDonorInfo()
        {
            if (Actions.IsDisplayed(_elementProductDivisionGridLabel))
                return true;

            else return false;
        }

        /*//This method is to click on add product button
        public void ClickOnAddProduct()
        {
            Assert.True(Actions.IsDisplayed(_elementAddProduct), "Could not find Add Product icon");
            Actions.Click(_elementAddProduct);
            Console.WriteLine("Clicked on Add Product");
        }*/

        // Click on Bypass Donor/Kit
        public void ClickOnBypassDonorKit()
        {
            Assert.True(Actions.IsDisplayed(_elementBypassDonorKit), "Could not find Bypass Donor/Kit button");
            Actions.Click(_elementBypassDonorKit);
            Console.WriteLine("Clicked on Bypass Donor/Kit");
        }

        // Click on Bypass Sync
        public void ClickOnBypassSync()
        {
            Assert.True(Actions.IsDisplayed(_elementBypassSync), "Could not find Bypass Sync button");
            Actions.Click(_elementBypassSync);
            Console.WriteLine("Clicked on Bypass Sync");
        }

        /*
        //Get the DonorID to create product
        public void GetDonorID()
        {
            donorIDText = Actions.GetText(_elementDonorIDField);
        }
        */

        /*
        //Navigate to search product page
        public AddNewProductPage NavigateToProduct()
        {
            Thread.Sleep(500);
            Actions.MouseHover(_elementProductIcon);
            Thread.Sleep(500);
            Actions.Click(_elementProductLink);
            Thread.Sleep(500);
            Actions.Click(_elementProductSearch);
            Thread.Sleep(500);

            return CreateInstance<AddNewProductPage>();
        }
        */

        /*
        //Click on add product link
        public void ClickOnAddProductLink()
        {
            if (Actions.IsDisplayed(_elementAddProduct))
            {
                Console.WriteLine("Navigated to Product page");
                Actions.Click(_elementAddProduct);
            }
        }
        */

        //Select existing donor ID radio button
        public void SelectExistingDonorIDRadio()
        {
            if (Actions.IsDisplayed(_elementExistingDonorIDRadio))
            {
                Console.WriteLine("Add New Product page is open");
                Actions.Click(_elementExistingDonorIDRadio);
            }
        }

        //Enter Donor ID recorded earlier
        public void EnterDonorId()
        {
            if (Actions.IsDisplayed(_elementLoadDonorInField))
            {
                Console.WriteLine("Load donor Id filed found");
                Actions.Click(_elementLoadDonorInField);
            }
        }

        //Click on the load Donor ID button to load information
        public void ClickOnLoadDonorIdBtn(string donorID)
        {
            if (Actions.IsDisplayed(_elementLoadDonorBtn))
            {
                Actions.SendKeys(_elementLoadDonorInField, donorID);
                //Thread.Sleep(1000);
                Console.WriteLine("Load donor button appeared");
                Actions.Click(_elementLoadDonorBtn);
            }
        }

        //Check to make sure the donor information matches
        public bool CheckDonorInformation()
        {
            string firstName = Actions.GetText(_elementDonorFirstNameField);
            string lastName = Actions.GetText(_elementDonorLastNameField);
            Console.WriteLine("The first Name is " + firstName);
            Console.WriteLine("The last Name is " + lastName);
            Console.WriteLine("The donor first Name is " + donorFirstName);
            Console.WriteLine("The donor first Name is " + donorLastName);

            if (firstName == donorFirstName && lastName == donorLastName)
                return true;
            else return false;
        }

        //Click on Sync button
        public void ClickOnSyncBtn()
        {
            Actions.Click(_elementSyncBtn);
            //Thread.Sleep(1000);
        }

        //Click on the radio button to select
        public void ClickOnRadioButtonToSelectDonor()
        {
            Actions.Click(_elementRadioBtn);
            //Thread.Sleep(1000);
        }

        //Accept the pop up window
        public void PressEnterKey()
        {
            Actions.AcceptAlert();
        }

        //Click on the create collection event button
        public void ClickOnCreateCollectionEventBtn()
        {
            Actions.Click(_elementCreateCollectionEventBtn);
            //Thread.Sleep(1000);
        }

        //enter a random volumn, and create product
        public void ClickonCreateProduct(int randomNumber)
        {
            Actions.SendKeys(_elementVolumeFiled, randomNumber.ToString());
            Actions.SendKeys(_elementWeightField, randomNumber.ToString());
            Actions.Click(_elementClickOnCreateProduct);
            Waits.WaitForPageLoad();
            //Thread.Sleep(1000);
        }

        //this method is to create an instance of kit page
        public AddKitPage CreateAddKitPage()
        {
            return CreateInstance<AddKitPage>();
        }

        //this method is used to set the product ID
        public void SetProductID()
        {
            ProductId = Actions.GetAttributeValue(_elementCollectionID, "value");
            Console.WriteLine("The product ID is " + ProductId);
        }

        //this method is used for click on the home page
        public void NavigateToHomePage()
        {
            //Thread.Sleep(2000);
            Actions.Click(_elementHomePageIcon);
            //Waits.WaitForPageLoad();
        }
    }
}
