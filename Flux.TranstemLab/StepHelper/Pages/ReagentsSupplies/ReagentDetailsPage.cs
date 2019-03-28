using Flux.Core;
using Flux.Web;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;

namespace Flux.TranstemLab.StepHelper.Pages.ReagentsSupplies
{
    public class ReagentDetailsPage : WebPageBase
    {

        // Actions
        private readonly By _elementScanVerification = By.Id("ContentPlaceHolder1_ctrlScanVerify_btnScanVerifyLaunch");
        private readonly By _elementSave = By.Id("ContentPlaceHolder1_btnSave");
        private readonly By _elementNewItem = By.Id("ContentPlaceHolder1_btnNew");
        private readonly By _elementDeleteItem = By.Id("ContentPlaceHolder1_btnDelete");
        private readonly By _elementLabelLaunch = By.Id("ContentPlaceHolder1_ctrlPrintLabel_btnLabelLaunch");

        // Reagent Info
        private readonly By _elementID = By.Id("ContentPlaceHolder1_ctrlEditReagent_lblClientID");
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
        private readonly By _elementAvailableForUse = By.Id("ContentPlaceHolder1_ctrlEditReagent_chkAvailable");

        // Documents
        private readonly By _elementAddDocument = By.Id("ContentPlaceHolder1_btnAddDocument");
        // Pop-up
        private readonly By _elementDocClose = By.Id("ContentPlaceHolder1_ctrlFileUpload_btn_cancel");
        private readonly By _elementDocDescription = By.Id("ContentPlaceHolder1_ctrlFileUpload_txtFileCaption");
        private readonly By _elementDocCategory = By.Id("ContentPlaceHolder1_ctrlFileUpload_ddlFileCategory");
        private readonly By _elementDocChooseFile = By.Id("ContentPlaceHolder1_ctrlFileUpload_filSelect");
        private readonly By _elementDocUpload = By.Id("ContentPlaceHolder1_ctrlFileUpload_btnUpload");
        private readonly By _elementDocCancel = By.Id("ContentPlaceHolder1_ctrlFileUpload_btnClose");

        // Notes
        private readonly By _elementAddNote = By.Id("ContentPlaceHolder1_btnAddNote");
        // Pop-up
        private readonly By _elementNoteClose = By.Id("ContentPlaceHolder1_ctrlNotes_btn_cancel");
        private readonly By _elementNoteCategory = By.Id("ContentPlaceHolder1_ctrlNotes_ddlFileCategory");
        private readonly By _elementNoteText = By.Id("ContentPlaceHolder1_ctrlNotes_txtNote");
        private readonly By _elementNoteSave = By.Id("ContentPlaceHolder1_ctrlNotes_btnSave");
        private readonly By _elementNoteCancel = By.Id("ContentPlaceHolder1_ctrlNotes_btnClose");

        public string ReadReagentID()
        {
            return Actions.GetText(_elementID);
        }

        // Documents =====

        public void ClickOnAddDocument()
        {
            Actions.Click(_elementAddDocument);
            Console.WriteLine("Clicked on Add Document button");
        }

        public void ClickOnDocUpload()
        {
            Actions.Click(_elementDocUpload);
            Console.WriteLine("Clicked on Upload button");
            //WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5000));
            //Waits.WaitForElementToBeInvisible(_elementDocUpload, WaitType.ImplicitWaitTime);
            //wait.Until(ExpectedConditions.InvisibilityOfElementLocated(_elementDocUpload));
            Waits.WaitForBrowserLoad();
        }

        // Type entry in Description
        public void TypeDocDescription(string text)
        {
            Waits.WaitForElementToBeVisible(_elementDocDescription, WaitType.Medium);
            Actions.SendKeys(_elementDocDescription, text);
            Console.WriteLine("Typed document description");
        }

        public void SelectRandomDocCategory()
        {
            Actions.SelectByRandoxIndex(_elementDocCategory);
            Console.WriteLine("Selected random document category");
        }

        // REVISE METHOD to be more generic
        public void UploadDocFile()
        {
            object directoryName = "";
            Console.WriteLine("Current Path is " + AppContext.BaseDirectory);
            string filePath = AppContext.BaseDirectory;
            filePath = filePath.Replace(@"\Flux.TranstemLab\bin\Debug\", "\\Attachment\\Test Attachment.xlsx");
            if (Actions.IsDisplayed(_elementDocChooseFile))
            {
                Actions.FindElement(_elementDocChooseFile);
                Actions.SendKeys(_elementDocChooseFile, filePath);
            }
            directoryName = new DirectoryInfo(filePath).Name;
            Console.WriteLine("File has been uploaded successfully");
        }

        // REVISE METHOD to optionally take in arg for category and for filepath
        public void CreateDoc(string description)
        {
            ClickOnAddDocument();
            TypeDocDescription(description);
            SelectRandomDocCategory();
            UploadDocFile();
            ClickOnDocUpload();
        }

        // Notes =====

        public void ClickOnAddNote()
        {
            Actions.Click(_elementAddNote);
            Console.WriteLine("Clicked on Add Note button");
        }

        public void ClickOnNoteSave()
        {
            Actions.Click(_elementNoteSave);
            Console.WriteLine("Clicked on Save button in Note pop-up");
            // WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5000));
            //Waits.WaitForElementToBeInvisible(_elementNoteSave, WaitType.ImplicitWaitTime);
            Waits.WaitForPageLoad();
            //wait.Until(ExpectedConditions.InvisibilityOfElementLocated(_elementNoteSave));
            //Waits.WaitForElementToBeInvisible(_elementNoteSave, WaitType.Large);
        }

        public void TypeNoteText(string text)
        {
            //WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            //wait.Until(ExpectedConditions.ElementIsVisible(_elementNoteText));
            Waits.WaitForElementToBeVisible(_elementNoteText, WaitType.Medium);
            Actions.SendKeys(_elementNoteText, text);
            Console.WriteLine("Typed text body for Note pop-up");
        }

        // REVISE METHOD by overloading to take index or category name
        public void SelectNoteCategory(int index = 1)
        {
            Actions.SelectByIndex(_elementNoteCategory, index);
            Console.WriteLine("Selected category with index " + index);
        }

        public void CreateNote(string text, int categoryIndex = 1)
        {
            ClickOnAddNote();
            TypeNoteText(text);
            SelectNoteCategory(categoryIndex);
            ClickOnNoteSave();
        }
    }
}
