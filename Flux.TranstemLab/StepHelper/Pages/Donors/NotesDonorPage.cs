using Flux.Core;
using System.Threading;
using Flux.Web;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Flux.TranstemLab.StepHelper.Pages.Donors
{
    public class NotesDonorPage : WebPageBase
    {
        private readonly By _elementSavBtnFromNotePage = By.Id("ContentPlaceHolder1_ctrlNotes_btnSave");
        private readonly By _ElementDescriptionBox = By.Id("ContentPlaceHolder1_ctrlNotes_txtNote");
        private readonly By _elementAddCollectionEventBtn = By.Id("ContentPlaceHolder1_btnAddCollectionEvent");

        //This Method is for clicking on Document & Note plus sign from RecipientDetail page
        public NotesDonorPage clickOnAddDocumentsBtn(String TypeButton)
        {
            //Thread.Sleep(6000);
            //ContentPlaceHolder1_btnAddNote
            //Note, Document,ContentPlaceHolder1_btnAddNote,ContentPlaceHolder1_btnAddDocument
            By _ElementDocuments = By.Id("ContentPlaceHolder1_btnAdd" + TypeButton + "");

            if (Actions.IsEnabled(_ElementDocuments))
            {
                Waits.WaitForElementToBePresent(_ElementDocuments, WaitType.Large);
                Actions.Click(_ElementDocuments);
            }
            Console.WriteLine("Clciked on Add" + TypeButton + " plus sign from the RecipientDetail page");
            return CreateInstance<NotesDonorPage>();
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

        //This method is for Entering text in Description Box for Notes from Donor page
        public NotesDonorPage EnterTextInDescriptionBox(string TextForDescription, int NumbersRandom)
        {

            Waits.WaitForElementToBePresent(_ElementDescriptionBox, WaitType.Medium);
            if (Actions.IsEnabled(_ElementDescriptionBox))
            {
                Actions.Click(_ElementDescriptionBox);
                Actions.FindElement(_ElementDescriptionBox).SendKeys(TextForDescription + "_" + NumbersRandom);
            }
            Console.WriteLine("Clciked on AddDocuments plus sign from the RecipientDetail page");
            return CreateInstance<NotesDonorPage>();
        }

        //This method is for clicking on Save button from Note page
        public NotesDonorPage ClickOnSaveButtonFromNotePage()
        {
            if (Actions.IsDisplayed(_elementSavBtnFromNotePage))
            {
                Waits.WaitForElementToBePresent(_elementSavBtnFromNotePage, WaitType.Small);
                Actions.Click(_elementSavBtnFromNotePage);
                Console.WriteLine("Clicked on Save Button from Note Page successfully");
            }
            Thread.Sleep(1000);//this need to be removed later
            return CreateInstance<NotesDonorPage>();
        }
    }
}
