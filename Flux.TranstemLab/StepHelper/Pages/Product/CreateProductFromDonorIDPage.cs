using Flux.Core;
using Flux.TranstemLab.StepHelper.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace Flux.TranstemLab.StepHelper.Pages.Product
{
    public class CreateProductFromDonorIDPage : PageBase
    {
        public override string Url => "/Home";
        //Strings used to store information
        public string donorIDText = string.Empty;
        public string donorLastName = string.Empty;
        public string donorFirstName = string.Empty;

        private readonly By _elementDonorIDField = By.Id("ContentPlaceHolder1_spnDonorId");
        private readonly By _elementProductIcon = By.Name("ctl00$searchBlock1$ctl03");
        private readonly By _elementProductLink = By.XPath("(//SPAN[text()='Products'][text()='Products'])[1]");
        private readonly By _elementProductSearch = By.XPath("(//SPAN[text()='Search'][text()='Search'])[1]");
        private readonly By _elementSaveCollectionEvent = By.Id("ContentPlaceHolder1_ctrlCollectionEvent_btnSave");
        private readonly By _elementAddProduct = By.Id("ContentPlaceHolder1_btnAdd");
        private readonly By _elementExistingDonorIDRadio = By.Id("rdExistingDonorID");
        private readonly By _elementLoadDonorInField = By.Id("txt_LoadDonorIN");
        private readonly By _elementLoadDonorBtn = By.Id("btnLoadDonorIN");
        private readonly By _elementDonorLastNameField = By.Id("DonorLastName");
        private readonly By _elementDonorFirstNameField = By.Id("DonorFirstName");
        private readonly By _elementSyncBtn = By.Id("btnSync");
        private readonly By _elementRadioBtn = By.Id("ListMatchedDonor_0__DonorSelected");
        private readonly By _elementCreateCollectionEventBtn = By.Id("btnCollectionEvent");
        private readonly By _elementClickOnCreateProduct = By.Id("btnCreateProduct");
        private readonly By _elementVolumeFiled = By.Id("UnitCollectionDatas_0__CordBloodVolume");

        //Get the DonorID to create product
        public void GetDonorID()
        {
            donorIDText = Actions.GetText(_elementDonorIDField);
        }

        //Navigate to search product page
        public void NavigateToProduct()
        {
            Thread.Sleep(500);
            Actions.MouseHover(_elementProductIcon);
            Thread.Sleep(500);
            Actions.Click(_elementProductLink);
            Thread.Sleep(500);
            Actions.Click(_elementProductSearch);
            Thread.Sleep(500);

        }

        //Click on add product link
        public void ClickOnAddProductLink()
        {
            if (Actions.IsDisplayed(_elementAddProduct))
            {
                Console.WriteLine("Navigated to Product page");
                Actions.Click(_elementAddProduct);
            }
        }

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
        public void ClickOnLoadDonorIdBtn()
        {
            if (Actions.IsDisplayed(_elementLoadDonorBtn))
            {
                Actions.SendKeys(_elementLoadDonorInField, donorIDText);
                Thread.Sleep(1000);
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

            Thread.Sleep(1000);
        }

        //Click on the radio button to select
        public void ClickOnRadioButtonToSelectDonor()
        {
            Actions.Click(_elementRadioBtn);
            Thread.Sleep(1000);

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
            Thread.Sleep(1000);

        }

        //enter a random volumn, and create product
        public void ClickonCreateProduct(int randomNumber)
        {

            Actions.SendKeys(_elementVolumeFiled, randomNumber.ToString());
            Actions.Click(_elementClickOnCreateProduct);

            Thread.Sleep(5000);
        }



    }


}
