using Flux.Core;
using Flux.Web;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace Flux.TranstemLab.StepHelper.Pages.Equipment
{
    public class EquipmentSearchPage : WebPageBase
    {
        private readonly By _elementAddEquipmentBtn = By.Id("ContentPlaceHolder1_imgAdd");
        private readonly By _elementEquipmentIDField = By.Id("ContentPlaceHolder1_txt_ID");
        private readonly By _elementAssetIDField = By.Id("ContentPlaceHolder1_txtAssetID");
        private readonly By _elementDescriptionField = By.Id("ContentPlaceHolder1_txtDescription");
        private readonly By _elementDispositionDDL = By.Id("ContentPlaceHolder1_dd_Disposition");
        private readonly By _elementManufacturerField = By.Id("ContentPlaceHolder1_txt_Mfg");
        private readonly By _elementModelNumberField = By.Id("ContentPlaceHolder1_txtModelNumber");
        private readonly By _elementSearchBtn = By.Id("ContentPlaceHolder1_btnSearch");
        private readonly By _elementClearBtn = By.Id("ContentPlaceHolder1_btnClear");

        //this method is for click on the add equipment button
        public EquipmentCreation ClickOnAddEquipmentBtn()
        {
            Assert.True(Actions.IsDisplayed(_elementAddEquipmentBtn), "Add Equipment button is not shown");
            Actions.Click(_elementAddEquipmentBtn);
            Console.WriteLine("Add Equipment button is being clicked");
            return CreateInstance<EquipmentCreation>();
        }

        //this method is used to fill in ID field 
        public void FillInIDField(string ID)
        {
            Actions.FindElement(_elementEquipmentIDField).SendKeys(ID);
            Console.WriteLine(ID + " is being entered to ID field");
        }

        //this method is used to click on search button
        public void ClickOnSearchBtn()
        {
            Actions.Click(_elementSearchBtn);
            Console.WriteLine("Search button is being clicked");
        }

        //this method is used to select the correct equipment by ID
        public void SelectEquipmentFromTable(string ID)
        {
            ID = ID.Substring(1);
            Console.WriteLine("ID is " + ID);
            By _elementEquipment = By.CssSelector("a[href = 'EquipmentDetail.aspx?eid=" + ID + "']");
            Console.WriteLine("a[href = 'EquipmentDetail.aspx?eid" + ID + "']");
            Actions.Click(_elementEquipment);
            Console.WriteLine("Correct equipment home page has been open");
        }
    }
}
