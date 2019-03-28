using Flux.Core;
using Flux.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;

namespace Flux.TranstemLab.StepHelper.Pages.Recipient
{
    public class DocumentsRecipientPage : WebPageBase
    {

        private readonly By _ElementDescriptionBox = By.Id("ContentPlaceHolder1_ctrlFileUpload_txtFileCaption");
        private readonly By _elementChooseAFile = By.Id("ContentPlaceHolder1_ctrlFileUpload_filSelect");
        private readonly By _ElementUploadButtonFromFileUploadPage = By.Id("ContentPlaceHolder1_ctrlFileUpload_btnUpload");
        private readonly By _elementCategoryTextVrfy = By.XPath("//div//table[@id='ContentPlaceHolder1_ctrlFileUpload_gvDocs']//td[text()][2]");
        private readonly By _elementUploadedFileName = By.XPath("//div//table[@id='ContentPlaceHolder1_ctrlFileUpload_gvDocs']//td//a[text()]");

        public DocumentsRecipientPage EnterTextInDescriptionBox(string TextForDescription, int NumbersRandom)
        {
            Waits.WaitForElementToBePresent(_ElementDescriptionBox, WaitType.Medium);
            if (Actions.IsEnabled(_ElementDescriptionBox))
            {
                Actions.Click(_ElementDescriptionBox);
                Actions.FindElement(_ElementDescriptionBox).SendKeys(TextForDescription + "_" + NumbersRandom);
            }
            Console.WriteLine("Clciked on AddDocuments plus sign from the RecipientDetail page");
            return CreateInstance<DocumentsRecipientPage>();
        }

        //This Method is for selecting a values from category drop down list
        public string SelectValuesFromCategory(String CategoryType)
        {
            string testFromCategory = "";
            //ContentPlaceHolder1_ctrlFileUpload_ddlFileCategory
            //Notes, FileUpload, ContentPlaceHolder1_ctrlNotes_ddlFileCategory, ContentPlaceHolder1_ctrlFileUpload_ddlFileCategory
            By _ElementsCategory = By.XPath("//select[@id='ContentPlaceHolder1_ctrl" + CategoryType + "_ddlFileCategory']//option");
            ReadOnlyCollection<IWebElement> lstFromCategory = Actions.FindElements(_ElementsCategory);
            IList<string> strList = new List<string>();

            for (int i = 0; i < lstFromCategory.Count; i++)
            {
                strList.Add(lstFromCategory[i].Text);
            }
            Console.Write("Values present in drop drop list : " + strList + ",");

            string[] valuesFromDropDown = strList.ToArray();
            foreach (string strValues in valuesFromDropDown)
            {
                Console.Write("Values present in drop drop list : " + strValues + ",");
            }
            Console.WriteLine();
            for (int j = 0; j < lstFromCategory.Count; j++)
            {
                if (lstFromCategory[j].Text != "Select a category...")
                {
                    //Thread.Sleep(1000);
                    lstFromCategory[j].Click();
                    testFromCategory = lstFromCategory[j].Text;
                    break;
                }
            }
            return testFromCategory;
        }

        public object ChooseFileUpload()
        {
            object directoryName = "";
            Console.WriteLine("Current Path is " + AppContext.BaseDirectory);
            string filePath = AppContext.BaseDirectory;
            filePath = filePath.Replace(@"\Flux.TranstemLab\bin\Debug\", "\\Attachment\\Test Attachment.xlsx");
            Waits.WaitForElementToBePresent(_elementChooseAFile, WaitType.Large);
            if (Actions.IsDisplayed(_elementChooseAFile))
            {
                Actions.FindElement(_elementChooseAFile);
                Actions.SendKeys(_elementChooseAFile, filePath);
            }
            directoryName = new DirectoryInfo(filePath).Name;
            Console.WriteLine("File has been uploaded successsgully");

            return directoryName;
        }

        //This Method is for clicking on Upload Button From File Upload Page
        public DocumentsRecipientPage ClickOnUploadButtonFromFileUploadPage()
        {
            Waits.WaitForElementToBePresent(_ElementUploadButtonFromFileUploadPage, WaitType.Medium);
            if (Actions.IsEnabled(_ElementUploadButtonFromFileUploadPage))
            {
                Actions.Click(_ElementUploadButtonFromFileUploadPage);
            }
            Console.WriteLine("Clicked on Upload Button From File Upload Page");
            return CreateInstance<DocumentsRecipientPage>();
        }

        //Verication
        public DocumentsRecipientPage DocumentsVerification(string textFromCategory, object directoryName)
        {
            string TextCategoryTextVrfy = Actions.FindElement(_elementCategoryTextVrfy).Text;
            string TextUploadedFileName = Actions.FindElement(_elementUploadedFileName).Text;

            string[] valuesFromElements = new string[] { TextCategoryTextVrfy, TextUploadedFileName };
            string[] EnteredValues = new string[] { textFromCategory, Convert.ToString(directoryName) };

            for (int i = 0; i < valuesFromElements.Length; i++)
            {
                Assert.AreEqual(valuesFromElements[i], EnteredValues[i]);
            }
            return CreateInstance<DocumentsRecipientPage>();
        }
    }
}
