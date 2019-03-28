using Flux.Core;
using Flux.TranstemLab.StepHelper.Base;
using Flux.TranstemLab.StepHelper.Pages.Product;
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

namespace Flux.TranstemLab.StepHelper.Pages.Recipient.BatchProcessing
{
    public class BatchSearchPage : PageBase
    {
        public override string Url => "/Home";

        private readonly By _elementStartAccessioningDate = By.Id("txt_startAccessioningDate");
        private readonly By _elementEndAccessioningDate = By.Id("txt_endAccessioningDate");
        private readonly By _elementProcessingProcedure = By.Id("dd_ProcessingProcedure");
        private readonly By _elementSearch = By.Id("btnSearch");
        private readonly By _elementStartDatepickerTrigger = By.XPath("(//IMG[@class='ui-datepicker-trigger'])[1]");
        private readonly By _elementEndDatepickerTrigger = By.XPath("(//IMG[@class='ui-datepicker-trigger'])[2]");
        private readonly By _elementSetBatch = By.Id("btnSetBatch");
        private readonly By _elementSelectAll = By.Id("btnSelectAll");
        private readonly By _elementClearAll = By.Id("btnClearAll");

        private readonly By _elementSidebarTranstemMenuExpand = By.XPath("//INPUT[@type='image']");
        private readonly By _elementSidebarHome = By.XPath("(//IMG[@class='menuIcon'])[1]");
        private readonly By _elementSidebarAccount = By.XPath("(//IMG[@class='menuIcon'])[2]");
        private readonly By _elementSidebarLogout = By.XPath("(//IMG[@class='menuIcon'])[3]");

        private readonly By _elementNavMenu = By.Id("cssmenuCollapse");
        private readonly By _elementNavMenuProducts = By.LinkText("Products");
        private readonly By _elementNavMenuProductsSearch = By.XPath("(//A[@href='/Laboratory/UnitSearch.aspx'])[1]");
        private readonly By _elementNavMenuProductsBatchSearch = By.XPath("(//A[@href='/BatchProcessing/Search?Area='])[1]");
        private readonly By _elementNavMenuDonors = By.XPath("(//A[@href='/DonorMgmt/DonorSearch.aspx'][text()='Donors'][text()='Donors'])[1]");
        private readonly By _elementNavMenuRecipients = By.XPath("(//A[@href='/RecipientMgmt/RecipientSearch.aspx'][text()='Recipients'][text()='Recipients'])[1]");
        private readonly By _elementNavMenuEntityManagement = By.LinkText("Entity Management");
        private readonly By _elementNavMenuEntityManagementFacilities = By.XPath("(//SPAN[text()='Facilities'][text()='Facilities'])[1]");
        private readonly By _elementNavMenuEntityManagementPhysicians = By.XPath("(//SPAN[text()='Physicians'][text()='Physicians'])[1]");
        private readonly By _elementNavMenuEquipmentConsumables = By.LinkText("Equipment/Consumables");
        private readonly By _elementNavMenuEquipmentConsumablesEquipment = By.XPath("(//SPAN[text()='Equipment'][text()='Equipment'])[1]");
        private readonly By _elementNavMenuEquipmentConsumablesReagents = By.XPath("(//SPAN[text()='Reagents'][text()='Reagents'])[1]");
        private readonly By _elementNavMenuEquipmentConsumablesKits = By.XPath("(//A[@href='/SupplyMan/KitSearch.aspx'])[1]");
        private readonly By _elementNavMenuQuality = By.LinkText("Quality");
        private readonly By _elementNavMenuQualityEnvironmentalMonitoring = By.XPath("(//SPAN[text()='Environmental Monitoring'])[1]");
        private readonly By _elementNavMenuQualityCT = By.XPath("(//A[@href='/Laboratory/ConfirmatoryTyping.aspx'])[1]");
        private readonly By _elementNavMenuQualityRegistry = By.XPath("(//SPAN[text()='Registry Listing'][text()='Registry Listing'])[1]");
        private readonly By _elementNavMenuReporting = By.XPath("(//A[@href='/Reporting/Reports.aspx'][text()='Reporting'][text()='Reporting'])[1]");
        private readonly By _elementNavMenuAdministrator = By.XPath("(//A[@href='/HomePages/AdministratorHome.aspx'][text()='Administrator'][text()='Administrator'])[1]");

        public void CheckProductByIndex(int index = 0)
        {
            string checkboxId = "BatchProductModelList_" + index.ToString() + "__IncludeInBatch";
            By elementCheckbox = By.Id(checkboxId);
            if (Actions.IsDisplayed(elementCheckbox))
            {
                Actions.Click(elementCheckbox);
                Console.WriteLine("Clicked on checkbox with ID" + checkboxId);
            }
            else
            {
                Console.WriteLine("Could not find checkbox with ID" + checkboxId);
            }
        }
    }
}
