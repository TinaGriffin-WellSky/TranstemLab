using Flux.Core;
using Flux.Web;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace Flux.TranstemLab.StepHelper.Pages.Product.BatchProcessing
{
    public class SearchBatchPage : WebPageBase
    {

        private readonly By _elementAddBatch = By.Id("btnAddBatch");
        private readonly By _elementBatchID = By.Id("txtBatchID");
        private readonly By _elementStatus = By.Id("dd_Status");
        private readonly By _elementStartAccessioningDate = By.Id("txt_startAccessioningDate");
        private readonly By _elementEndAccessioningDate = By.Id("txt_endAccessioningDate");
        private readonly By _elementTechnicianName = By.Id("dd_TechnicianName");
        private readonly By _elementSearch = By.Id("btnSearch");
        private readonly By _elementClear = By.Id("btnClear");

        /*
         * MOVE TO SEPARATE COMMON FILE
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
        */

        //this method is used to click on add batch button
        public AddBatchPage ClickOnAddBatch()
        {
            Assert.True(Actions.IsDisplayed(_elementAddBatch), "Could not find Add Batch button");
            Actions.Click(_elementAddBatch);
            Console.WriteLine("Clicked on Add Batch button");
            return CreateInstance<AddBatchPage>();
        }
    }
}