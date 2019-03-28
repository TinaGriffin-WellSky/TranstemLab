using Flux.Core;
using Flux.Web;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace Flux.TranstemLab.StepHelper.Pages.ReagentsSupplies
{
    public class AddReagentPage : WebPageBase
    {
        private readonly By _elementSave = By.Id("ContentPlaceHolder1_btnSave");
        private readonly By _elementReceiptDate = By.Id("ContentPlaceHolder1_ctrlEditReagent_txtReceiptDate");
        private readonly By _elementExpDate = By.Id("ContentPlaceHolder1_ctrlEditReagent_txtExpirationDate");
        private readonly By _elementType = By.Id("ContentPlaceHolder1_ctrlEditReagent_ddType");
        private readonly By _elementManufacturer = By.Id("ContentPlaceHolder1_ctrlEditReagent_ddMfg");
        private readonly By _elementStatus = By.Id("ContentPlaceHolder1_ctrlEditReagent_ddDisposition");
        private readonly By _elementLotNumber = By.Id("ContentPlaceHolder1_ctrlEditReagent_txtLotNumber");
        private readonly By _elementLocation = By.Id("ContentPlaceHolder1_ctrlEditReagent_ddlLocation");
        private readonly By _elementPkgInsertID = By.Id("ContentPlaceHolder1_ctrlEditReagent_txtPkgInsertID");
        private readonly By _elementQuantity = By.Id("ContentPlaceHolder1_ctrlEditReagent_txtQuantity");
        private readonly By _elementUOM = By.Id("ContentPlaceHolder1_ctrlEditReagent_ddUOM");
        private readonly By _elementCofAPresentYes = By.Id("ContentPlaceHolder1_ctrlEditReagent_radCofAPresent_0");
        private readonly By _elementCofAPresentNo = By.Id("ContentPlaceHolder1_ctrlEditReagent_radCofAPresent_1");
        private readonly By _elementCofAPresentNA = By.Id("ContentPlaceHolder1_ctrlEditReagent_radCofAPresent_2");

        public ReagentDetailsPage ClickOnSave()
        {
            Actions.Click(_elementSave);
            Console.WriteLine("Clicked on Save button");
            return CreateInstance<ReagentDetailsPage>();
        }

        public void SelectRandomType()
        {
            Actions.SelectByRandoxIndex(_elementType);
            Console.WriteLine("Chose random entry from Type drop-down list");
        }

        public void TypeReceiptDate(string date)
        {
            Actions.SendKeys(_elementReceiptDate, date);
            Console.WriteLine("Typed date in Receipt Date text field");
        }

        public void TypeExpirationDate(string date)
        {
            Actions.SendKeys(_elementExpDate, date);
            Console.WriteLine("Typed date in Exp. Date text field");
        }

        public void TypeQuantity(string quantity)
        {
            Actions.SendKeys(_elementQuantity, quantity);
            Console.WriteLine("Typed entry in Quantity text field");
        }

        public void TypeLotNumber(string lotNum)
        {
            Actions.SendKeys(_elementLotNumber, lotNum);
            Console.WriteLine("Typed entry in Lot Number text field");
        }

        // Types data in required fields only and saves
        public void EnterNecessaryData(string receiptDate, string expDate, string quantity, string lotNum)
        {
            SelectRandomType();
            TypeReceiptDate(receiptDate);
            TypeExpirationDate(expDate);
            TypeQuantity(quantity);
            TypeLotNumber(lotNum);
        }
    }
}
