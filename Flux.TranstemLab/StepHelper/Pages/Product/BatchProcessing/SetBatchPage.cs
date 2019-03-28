using Flux.Core;
using Flux.Web;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace Flux.TranstemLab.StepHelper.Pages.Product.BatchProcessing
{
    public class SetBatchPage : WebPageBase
    {

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

        /*
        //this method is used to check on correct check box for the product
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
        */

        //this method is used to parse each line come our from the table, and deternmind if that line consist of first parent
        public bool ParseProductCode(string line)
        {
            Console.WriteLine("Each line is " + line);
            string[] words = line.Split(' ');
            foreach (var word in words)
            {
                Console.WriteLine(word);
                if (word.StartsWith("S1") || word.StartsWith("S2") || word.StartsWith("E2"))
                {
                    Console.WriteLine(word);
                    string productCode = word.Substring(1);
                    long number = 0;
                    bool isAllNum = long.TryParse(productCode, out number);
                    if (isAllNum)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //this method is used to parse the entire table
        public int FindFirstParentBatch()
        {
            By _elementProductCode = By.ClassName("LabSearchGrid");
            //i was set to -2 is because first line is the header of table, and first index start at 0
            int i = -2;
            Assert.True(Actions.IsDisplayed(_elementProductCode), "Table not being displayed");
            string cellText = string.Empty;
            IList<IWebElement> allElement = Actions.FindElements(By.ClassName("LabSearchGrid"));
            foreach (IWebElement element in allElement)
            {
                cellText = element.Text;
            }
            string[] lines = cellText.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                i++;
                Console.WriteLine(i);
                //function call to deternmind if first parentwas found
                if (ParseProductCode(line))
                    break;
            }
            //return the index for select check box function
            Console.WriteLine("The Final i is " + i);
            return i;
        }

        //this method is to select the last element
        public int FindNewBatch()
        {
            By _elementProductCode = By.ClassName("LabSearchGrid");
            int i = -2;
            Assert.True(Actions.IsDisplayed(_elementProductCode), "Table not being displayed");
            string cellText = string.Empty;
            IList<IWebElement> allElement = Actions.FindElements(By.ClassName("LabSearchGrid"));
            foreach (IWebElement element in allElement)
            {
                cellText = element.Text;
            }
            string[] lines = cellText.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                i++;

            }
            return i;
        }

        //this method is used to click on Set bactch and create a batch home page
        public BatchHomePage CheckParentAndClickOnSetBatch(int index)
        {
            string firstParentString = "BatchProductModelList_" + index + "__IncludeInBatch";
            By _elementFirstParent = By.Id(firstParentString);
            Assert.True(Actions.IsDisplayed(_elementFirstParent), "First check box is not shown");
            Actions.Click(_elementFirstParent);
            Assert.True(Actions.IsDisplayed(_elementSetBatch), "Set Batch button is not shown");
            Actions.Click(_elementSetBatch);
            return CreateInstance<BatchHomePage>();
        }

        public void ClickOnFirstProductCheckbox()
        {
            By checkboxElement = By.Id("BatchProductModelList_0__IncludeInBatch");
            Assert.True(Actions.IsDisplayed(checkboxElement), "Could not find checkbox");
            Actions.Click(checkboxElement);
            Console.WriteLine("Clicked on checkbox");
        }
    }
}
