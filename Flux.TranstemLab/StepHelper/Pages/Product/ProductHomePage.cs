using Flux.Core;
using OpenQA.Selenium;
using System;
using Flux.Web;

namespace Flux.TranstemLab.StepHelper.Pages.Product
{
    public class ProductHomePage : WebPageBase
    {
        private readonly By _elementUnitIdentifier = By.Id("UnitIdentifier");
        private readonly By _elementIsbtID = By.Id("ISBTIdentifier");
        private readonly By _elementConvertToIsbt = By.Id("btnConvert");
        private readonly By _elementSaveBtn = By.Id("btnSave");
        private readonly By _elementUnitTesting = By.LinkText("Unit Testing");
        private readonly By _elementAddDocument = By.Id("assetFilesAddButton");
        private readonly By _elementAddNotes = By.Id("noteAddButton");
        private readonly By _elementConvertIsbt = By.Id("btnConvert");
        private readonly By _elementExpirationDate = By.CssSelector("DatePicker dateField hasDatepicker");
        private readonly By _elementExpirationTime = By.Name("ProductDivisionList[0].ExpirationTime");

        /*
        public void IsbtNumber()
        {
            if (Actions.IsDisplayed(_elementIsbtID))
            {
                Waits.WaitForElementToBePresent(_elementIsbtID, WaitType.Small);
                Console.WriteLine("ISBT Created");
            }
        }
        */

        public void ClickOnSaveOnProductHomePage()
        {
            if (Actions.IsDisplayed(_elementSaveBtn))
            {
                //Thread.Sleep(500);
                Actions.Click(_elementSaveBtn);
                //Thread.Sleep(500);
                Console.WriteLine("ISBT saved");
                Waits.WaitForPageLoad();
            }
        }
    }
}
