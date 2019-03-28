using Flux.Core;
using Flux.Web;
using NUnit.Framework;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;

namespace Flux.TranstemLab.StepHelper.Pages.Equipment
{
    public class EquipmentHomePage : WebPageBase
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
        private readonly By _elementAddPreventiveMaintenanceBtn = By.Id("ContentPlaceHolder1_btnAddPM");
        private readonly By _elementSaveSuccessfulMessage = By.Id("ContentPlaceHolder1_successMsg");
        private readonly By _elementAddDocumentBtn = By.Id("ContentPlaceHolder1_btnAddDocument");
        private readonly By _elementaddNoteBtn = By.Id("ContentPlaceHolder1_btnAddNote");
        private readonly By _elementDescriptionFieldInPopUpFileUpLoad = By.Id("ContentPlaceHolder1_ctrlFileUpload_txtFileCaption");
        private readonly By _elementCategoryDDLDocument = By.Id("ContentPlaceHolder1_ctrlFileUpload_ddlFileCategory");
        private readonly By _elementChooseAFile = By.Id("ContentPlaceHolder1_ctrlFileUpload_filSelect");
        private readonly By _elementUploadBtn = By.Id("ContentPlaceHolder1_ctrlFileUpload_btnUpload");
        private readonly By _elementCategoryDDLNote = By.Id("ContentPlaceHolder1_ctrlNotes_ddlFileCategory");
        private readonly By _elementNoteField = By.Id("ContentPlaceHolder1_ctrlNotes_txtNote");
        private readonly By _elementSaveBtnNote = By.Id("ContentPlaceHolder1_ctrlNotes_btnSave");
        private readonly By _elementDateScheduled = By.Id("ContentPlaceHolder1_ctrlEquipPM_txtDateScheduled");
        private readonly By _elementDatePerformed = By.Id("ContentPlaceHolder1_ctrlEquipPM_txtDatePerformed");
        private readonly By _elementNoteFieldAddPM = By.Id("ContentPlaceHolder1_ctrlEquipPM_txtNotes");
        private readonly By _elementSaveBtnAddPM = By.Id("ContentPlaceHolder1_ctrlEquipPM_btnSave");
        private readonly By _elementHomeIcon = By.Name("ctl00$searchBlock1$ctl00");
        private string ID;
        private string ScheduledDate;
        private readonly By _elementBackgroundLoad = By.Id("ContentPlaceHolder1_ctrlFileUpload_ModalPopupExtender1_backgroundElement");

        //this method is used to get the ID of the Equipment for searching
        public void SetID()
        {
            ID = Actions.GetText(_elementEquipmentIDField);
            Console.WriteLine("The id is " + ID);
        }

        //getter
        public string GetID() { return ID; }

        //this method is to deternmind if it create equipment was successful
        public bool IsSaveSuccessfulDisplayed()
        {
            if (Actions.IsDisplayed(_elementSaveSuccessfulMessage))
                return true;

            else return false;
        }

        //this method is used to open the Add Document Pop Window
        public void ClickOnAddDocument()
        {
            Assert.True(Actions.IsDisplayed(_elementAddDocumentBtn), "Add documents button is not shown");
            Actions.Click(_elementAddDocumentBtn);
            Console.WriteLine("Add document button is being clicked");
        }

        //this method is used to open the Add Note pop window
        public void ClickOnAddNote()
        {
            Assert.True(Actions.IsDisplayed(_elementaddNoteBtn), "Add documents button is not shown");
            Actions.Click(_elementaddNoteBtn);
            Console.WriteLine("Add document button is being clicked");
        }

        //this method is used to fill in the pop window and select a file path
        public void FillInFileUploadPopUp()
        {
            // Assert.True(Actions.IsDisplayed(_elementDescriptionFieldInPopUp), "Pop up window is not appeared");
            //Thread.Sleep(1000);
            //WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2));
            Waits.WaitForElementToBeClickable(_elementCategoryDDLDocument, WaitType.Medium);
            //wait.Until(ExpectedConditions.ElementToBeClickable(_elementCategoryDDLDocument));
            //Waits.WaitForPageLoad();
            //Waits.WaitForPageLoad();
            //Waits.WaitForElementToBePresent(_elementCategoryDDLDocument, WaitType.Medium);
            Actions.SendKeys(_elementCategoryDDLDocument, "Testing!");
            Console.WriteLine("Testing! was entered in description");
            Actions.SelectByRandoxIndex(_elementCategoryDDLDocument);

            object directoryName = "";
            Console.WriteLine("Current Path is " + AppContext.BaseDirectory);
            string filePath = AppContext.BaseDirectory;
            filePath = filePath.Replace(@"\Flux.TranstemLab\bin\Debug\", "\\Attachment\\Test Attachment.xlsx");
            //Waits.WaitForElementToBePresent(_elementChooseAFile, WaitType.Large);
            //Waits.WaitForPageLoad();
            Waits.WaitForElementToBeClickable(_elementChooseAFile, WaitType.Large);
            // wait.Until(ExpectedConditions.ElementToBeClickable(_elementChooseAFile));
            Actions.SendKeys(_elementChooseAFile, filePath);
            directoryName = new DirectoryInfo(filePath).Name;
            Console.WriteLine("File has been uploaded successfully");
        }

        public void CreateFileUpload()
        {
            ClickOnAddDocument();
            FillInFileUploadPopUp();
            Actions.Click(_elementUploadBtn);
            Console.WriteLine("Clicked on Upload in Document pop-up");
            Waits.WaitForPageLoad();
            Waits.WaitForPageLoad();
        }

        //this method is used to finn in the pop window to add note
        public void FillInNotePopUp()
        {
            //WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2));
            Waits.WaitForElementToBeClickable(_elementCategoryDDLNote, WaitType.Medium);
            //wait.Until(ExpectedConditions.ElementToBeClickable(_elementCategoryDDLNote));
            //Waits.WaitForElementToBeVisible(_elementCategoryDDLNote, WaitType.Medium);
            //Thread.Sleep(1000);
            Actions.SelectByIndex(_elementCategoryDDLNote, 1);
            Console.WriteLine(Actions.GetText(_elementCategoryDDLNote) + " is being selected in category dorp down ");
            Actions.SendKeys(_elementNoteField, "Testing!");
            Console.WriteLine("Testing! is being entered in the Note field");
        }

        public void CreateNote()
        {
            ClickOnAddNote();
            FillInNotePopUp();
            Actions.Click(_elementSaveBtnNote);
            //Waits.WaitForElementToBeInvisible(_elementSaveBtnNote,WaitType.Large);
            Thread.Sleep(500);//This needs to be removed later
            Waits.WaitForPageLoad();
            Console.WriteLine("Clicked on Save in Note pop-up");
            // WebDriverWait wait = new WebDriverWait(Actions, TimeSpan.FromSeconds(2));
            // wait.Until(ExpectedConditions.InvisibilityOfElementLocated(_elementSaveBtnNote));
            // Waits.WaitForElementToBeInvisible(_elementSaveBtnNote, WaitType.ImplicitWaitTime);

        }

        //this method is used to open Preventive Maintenance window
        public void ClickOnAddPreventiveMaintenance()
        {

            //Thread.Sleep(1000);
            //WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2));
            // wait.Until(ExpectedConditions.ElementIsVisible(_elementAddPreventiveMaintenanceBtn));
            Waits.WaitForPageLoad();
            Waits.WaitForElementToBeClickable(_elementAddPreventiveMaintenanceBtn, WaitType.Large);
            //Waits.WaitForPageLoad();
            Assert.True(Actions.IsDisplayed(_elementAddPreventiveMaintenanceBtn), "The add PM button is not shown");
            Actions.Click(_elementAddPreventiveMaintenanceBtn);
            Console.WriteLine("Add Preventive Maintenance button is clicked");
        }

        //this method is used to fill in Date Scheduled
        public void FillInDateScheduledInMaintenance(string date)
        {
            //Thread.Sleep(1000);
            Actions.SendKeys(_elementDateScheduled, date);
            Console.WriteLine("Date Scheduled entered was " + date);
            //ScheduledDate = date;
        }

        //this method is used to fill in Date Performed
        public void FillInDatePerformedInMaintenance(string date)
        {
            //Thread.Sleep(1000);
            Waits.WaitForElementToBeClickable(_elementDatePerformed, WaitType.Medium);
            //wait.Until(ExpectedConditions.ElementToBeClickable(_elementDatePerformed));
            Actions.FindElement(_elementDatePerformed).SendKeys(date);
            Console.WriteLine("Date Scheduled entered was " + date);
        }

        //this methoid is used to fill in note in add maintenance schedule
        public void FillNotesInAddMaintenanceSchedule()
        {
            Actions.FindElement(_elementNoteFieldAddPM).SendKeys("Testing!");
            Console.WriteLine("Testing! is being entered in the Note field");
        }

        //this method is used to click on the save button in add maintenance scheduler
        public void ClickOnSaveBtnInAddMaintenanceSchedule()
        {
            Actions.Click(_elementDateScheduled);
            Assert.True(Actions.IsDisplayed(_elementSaveBtnAddPM), "Save button is not being displayed");
            Actions.Click(_elementSaveBtnAddPM);
            Console.WriteLine("Save button is being click on Add Maintenance Schedule");

            for (int i = 0; i < 50; i++)
            {
                Waits.WaitForPageLoad();
            }
            //Thread.Sleep(1000);
        }

        public void CreateMaintenance(string date)
        {
            //WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2));
            //wait.Until(ExpectedConditions.ElementToBeClickable(_elementAddPreventiveMaintenanceBtn));
            ClickOnAddPreventiveMaintenance();
            Waits.WaitForElementToBeClickable(_elementDateScheduled, WaitType.Medium);
            //wait.Until(ExpectedConditions.ElementToBeClickable(_elementDateScheduled));
            FillInDateScheduledInMaintenance(date);
            Waits.WaitForElementToBeClickable(_elementDateScheduled, WaitType.Medium);
            //wait.Until(ExpectedConditions.ElementToBeClickable(_elementDateScheduled));
            FillNotesInAddMaintenanceSchedule();
            Waits.WaitForElementToBeClickable(_elementSaveBtnAddPM, WaitType.Medium);
            //wait.Until(ExpectedConditions.ElementToBeClickable(_elementSaveBtnAddPM));
            ClickOnSaveBtnInAddMaintenanceSchedule();
            Waits.WaitForPageLoad();
            //Waits.WaitForPageLoad();
        }

        //this method is used to click on the save button in equipment home page
        public void ClickOnSaveBtnInEquipmentHomePage()
        {
            // WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2));
            Waits.WaitForElementToBeClickable(_elementSaveBtn, WaitType.Medium);
            // wait.Until(ExpectedConditions.ElementToBeClickable(_elementSaveBtn));
            Assert.True(Actions.IsDisplayed(_elementSaveBtn), "Save button is not being displayed");
            //Thread.Sleep(3000);
            Actions.FindElement(_elementSaveBtn).Click();
            Console.WriteLine("Equipment is being saved");

            /*
            // The things we do to remove Thread.Sleep...
            for (int i = 0; i < 10; i++)
            {
                Waits.WaitForPageLoad();
            }*/
            //Thread.Sleep(3000);
        }

        //this method is used to clikc on the home icon to go to home page
        public void ClickOnHomeIcon()
        {
            Actions.Click(_elementHomeIcon);
            Console.WriteLine("Home page is being displayed");
        }

        //this method is to deternmind if home page being opened
        public bool IsHomePageOpened()
        {
            if (Actions.IsDisplayed(_elementEquipmentIDField))
                return true;

            else return false;
        }

        //this method is used to open a specific PM
        public void OpenPM()
        {
            By _elementSpecificPM = By.CssSelector("a[href ^=\"javascript:__doPostBack('ctl00$ContentPlaceHolder1$ctrlEquipPM$gvPM\"]");
            Console.WriteLine("//A[@class=''][text()='" + ScheduledDate + "']");
            Actions.Click(_elementSpecificPM);
        }
    }
}
