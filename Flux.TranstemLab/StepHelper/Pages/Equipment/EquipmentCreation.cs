using Flux.Core;
using Flux.Web;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections;

namespace Flux.TranstemLab.StepHelper.Pages.Equipment
{
    public class EquipmentCreation : WebPageBase
    {
        private readonly By _elementSaveBtn = By.Id("ContentPlaceHolder1_btnSave");
        private readonly By _elementEquipmentIDField = By.Id("ContentPlaceHolder1_ctrlEditEquip_lblClientID");
        private readonly By _elementAssetIDField = By.Id("ContentPlaceHolder1_ctrlEditEquip_txtAssetID");
        private readonly By _elementDescriptionField = By.Id("ContentPlaceHolder1_ctrlEditEquip_txtDescription");
        private readonly By _elementManufacturerField = By.Id("ContentPlaceHolder1_ctrlEditEquip_txtManufacturer");
        private readonly By _elementModelNumberField = By.Id("ContentPlaceHolder1_ctrlEditEquip_txtModelNumber");
        private readonly By _elementSerialNumberField = By.Id("ContentPlaceHolder1_ctrlEditEquip_txtSerialNumber");
        private readonly By _elementEquipmentTypeDDL = By.Id("ContentPlaceHolder1_ctrlEditEquip_ddEquipmentType");
        private readonly By _elementLocationDDL = By.Id("ContentPlaceHolder1_ctrlEditEquip_ddlEquipmentLocation");
        private readonly By _elementEquipmentDispositionDDL = By.Id("ContentPlaceHolder1_ctrlEditEquip_ddStatus");

        public void EnterAllField(string AssetID, string EquipmentDescription, string Manufacturer, string ModelNumber, string SerialNumber)
        {
            ArrayList allFieldsValue = new ArrayList();
            allFieldsValue.Add(AssetID);
            allFieldsValue.Add(EquipmentDescription);
            allFieldsValue.Add(Manufacturer);
            allFieldsValue.Add(ModelNumber);
            allFieldsValue.Add(SerialNumber);

            ArrayList allFieldID = new ArrayList() { "AssetID", "Description", "Manufacturer", "ModelNumber", "SerialNumber" };
            for (int i = 0; i < allFieldID.Count; i++)
            {
                By _elementFieldsID = By.Id("ContentPlaceHolder1_ctrlEditEquip_txt" + allFieldID[i]);
                Actions.Click(_elementFieldsID);
                Actions.FindElement(_elementFieldsID).SendKeys(Convert.ToString(allFieldsValue[i]));
                Console.WriteLine("Values entered : " + allFieldsValue[i] + " to " + allFieldID[i] + " Fields");
            }
        }

        public void SelectFromDDL()
        {
            ArrayList allDDLID = new ArrayList() { "EquipmentType", "lEquipmentLocation", "Status" };
            for (int i = 0; i < allDDLID.Count; i++)
            {
                By _elementDDLID = By.Id("ContentPlaceHolder1_ctrlEditEquip_dd" + allDDLID[i]);
                Actions.Click(_elementDDLID);
                Actions.SelectByRandoxIndex(_elementDDLID);
                Console.WriteLine(Actions.GetText(_elementDDLID) + " was selected in " + allDDLID[i] + " drop down list");
            }
        }

        public EquipmentHomePage ClickOnSaveBtn()
        {
            Assert.True(Actions.IsDisplayed(_elementSaveBtn), "Save button is not shown");
            Actions.Click(_elementSaveBtn);
            return CreateInstance<EquipmentHomePage>();
        }
    }
}
