using Flux.Core;
using Flux.Web;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace Flux.TranstemLab.StepHelper.Pages.ReagentsSupplies
{
    public class SearchReagentPage : WebPageBase
    {
        private readonly By _elementAddReagent = By.Id("ContentPlaceHolder1_btnAdd");
        private readonly By _elementID = By.Id("ContentPlaceHolder1_txtID");
        private readonly By _elementAvailable = By.Id("ContentPlaceHolder1_chkAvailableForUse");
        private readonly By _elementStatus = By.Id("ContentPlaceHolder1_dd_Disposition");
        private readonly By _elementType = By.Id("ContentPlaceHolder1_dd_Type");
        private readonly By _elementManufacturer = By.Id("ContentPlaceHolder1_dd_mfg");
        private readonly By _elementLot = By.Id("ContentPlaceHolder1_txtLotNumber");
        private readonly By _elementDateReceivedStart = By.Id("ContentPlaceHolder1_txt_DateReceived_Begin");
        private readonly By _elementDateReceivedEnd = By.Id("ContentPlaceHolder1_txt_DateReceived_End");
        private readonly By _elementExpirationDateStart = By.Id("ContentPlaceHolder1_txtExpirationDate_Begin");
        private readonly By _elementExpirationDateEnd = By.Id("ContentPlaceHolder1_txtExpirationDate_End");
        private readonly By _elementSearch = By.Id("ContentPlaceHolder1_btnSearch");
        private readonly By _elementClear = By.Id("ContentPlaceHolder1_btnClear");

        public AddReagentPage ClickOnAddReagent()
        {
            Actions.Click(_elementAddReagent);
            Console.WriteLine("Clicked on Add Reagent button");
            return CreateInstance<AddReagentPage>();
        }

        /*
        public void ClickOnSearch()
        {
            Actions.Click(_elementSearch);
            Console.WriteLine("Clicked on Search button");
        }
        */

        /*
        public void SelectFirstReagent()
        {
            Actions.Click(By.CssSelector("a[href^='ReagentDetail.aspx?rid=']"));
            Console.WriteLine("Clicked on first reagent");
        }
        */
    }
}
