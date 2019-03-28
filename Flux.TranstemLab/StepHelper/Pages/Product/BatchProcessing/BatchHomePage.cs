using Flux.Core;
using Flux.Web;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace Flux.TranstemLab.StepHelper.Pages.Product.BatchProcessing
{
    public class BatchHomePage : WebPageBase
    {
        // product link here
        private readonly By _elementTechnicianName = By.Id("dd_TechnicianName");
        private readonly By _elementEquipmentId = By.Id("EquipmentId");
        private readonly By _elementAddEquipment = By.ClassName("AddEquipment GrayButton ButtonText");
        private readonly By _elementReagentsId = By.Id("ReagentsId");
        private readonly By _elementAddReagents = By.ClassName("AddReagents GrayButton ButtonText");
        private readonly By _elementSave = By.Id("btnSave");
        private readonly By _elementCancelBatch = By.Id("btnClose");
        private readonly By _elementProductList = By.Id("btnProductList");

        // Processing Tasks
        // Test
        private readonly By _elementProcessingTasksTestCheckbox = By.Id("ProcessingTasks_0__Completed");
        private readonly By _elementProcesssingTaskTestCompletionDate = By.Id("ProcessingTasks_0__CompletionDate");
        private readonly By _elementProcessingTaskTestCompletionDatepickerTrigger = By.XPath("(//IMG[@class='ui-datepicker-trigger'])[1]");
        private readonly By _elementProcessingTaskTestCompletionTime = By.Id("ProcessingTasks_0__CompletionTime");
        // Take Cell Counts
        private readonly By _elementProcessingTasksTakeCellCountCheckbox = By.Id("ProcessingTasks_1__Completed");
        private readonly By _elementProcesssingTaskTakeCellCountCompletionDate = By.Id("ProcessingTasks_1__CompletionDate");
        private readonly By _elementProcessingTaskTakeCellCountCompletionDatepickerTrigger = By.XPath("(//IMG[@class='ui-datepicker-trigger'])[2]");
        private readonly By _elementProcessingTaskTakeCellCountCompletionTime = By.Id("ProcessingTasks_1__CompletionTime");
        // Label Verification
        private readonly By _elementProcessingTasksLabelVerificationCheckbox = By.Id("ProcessingTasks_2__Completed");
        private readonly By _elementProcesssingTaskLabelVerificationCompletionDate = By.Id("ProcessingTasks_2__CompletionDate");
        private readonly By _elementProcessingTaskLabelVerificationCompletionDatepickerTrigger = By.XPath("(//IMG[@class='ui-datepicker-trigger'])[3]");
        private readonly By _elementProcessingTaskLabelVerificationCompletionTime = By.Id("ProcessingTasks_2__CompletionTime");
        // Print Label
        private readonly By _elementProcessingTasksPrintLabelsCheckbox = By.Id("ProcessingTasks_3__Completed");
        private readonly By _elementProcesssingTaskPrintLabelsCompletionDate = By.Id("ProcessingTasks_3__CompletionDate");
        private readonly By _elementProcessingTaskPrintLabelsCompletionDatepickerTrigger = By.XPath("(//IMG[@class='ui-datepicker-trigger'])[4]");
        private readonly By _elementProcessingTaskPrintLabelsCompletionTime = By.Id("ProcessingTasks_3__CompletionTime");
        // Processing Complete
        private readonly By _elementProcessingTasksProcessingCompleteCheckbox = By.Id("ProcessingTasks_4__Completed");
        private readonly By _elementProcesssingTaskProcessingCompleteCompletionDate = By.Id("ProcessingTasks_4__CompletionDate");
        private readonly By _elementProcessingTaskProcessingCompleteCompletionDatepickerTrigger = By.XPath("(//IMG[@class='ui-datepicker-trigger'])[5]");
        private readonly By _elementProcessingTaskProcessingCompleteCompletionTime = By.Id("ProcessingTasks_4__CompletionTime");

        /*
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

        public void SelectRandomTechnician()
        {
            Assert.True(Actions.IsDisplayed(_elementTechnicianName), "Could not find Technologist Name");
            Actions.SelectByRandoxIndex(_elementTechnicianName);
            Console.WriteLine("Selected random technician name");
        }

        public void ClickOnSave()
        {
            Assert.True(Actions.IsDisplayed(_elementSave), "Could not find Save or do not meet conditions to save");
            Actions.Click(_elementSave);
            Console.WriteLine("Clicked on Save");
        }

        public ProcessingProcedurePage ClickOnProductList()
        {
            Assert.True(Actions.IsDisplayed(_elementProductList), "Could not find Product List");
            Actions.Click(_elementProductList);
            Console.WriteLine("Clicked on Product List");
            return CreateInstance<ProcessingProcedurePage>();
        }
    }
}
