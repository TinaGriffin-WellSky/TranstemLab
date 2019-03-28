using Flux.Core;
using Flux.Web;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;

namespace Flux.TranstemLab.StepHelper.Pages.Recipient
{
    public class NotesRecipientPage : WebPageBase
    {

        private readonly By _elementCategoryTextVrfy = By.XPath("//div//table[@id='ContentPlaceHolder1_ctrlFileUpload_gvDocs']//td[text()][2]");
        private readonly By _elementUploadedFileName = By.XPath("//div//table[@id='ContentPlaceHolder1_ctrlFileUpload_gvDocs']//td//a[text()]");
        private readonly By _ElementDescriptionBoxForNotes = By.Id("ContentPlaceHolder1_ctrlNotes_txtNote");
        private readonly By _elementSavBtnFromNotePage = By.Id("ContentPlaceHolder1_ctrlNotes_btnSave");
        private readonly By _elementSaveConfirm = By.Id("ContentPlaceHolder1_lblError");

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

        //This Method is for Entering text in Note Box from Note page
        public NotesRecipientPage EnterTextInDescriptionBoxForNotes(String TextForDescription, int NumbersRandom)
        {
            Waits.WaitForElementToBePresent(_ElementDescriptionBoxForNotes, WaitType.Medium);
            if (Actions.IsEnabled(_ElementDescriptionBoxForNotes))
            {
                Actions.Click(_ElementDescriptionBoxForNotes);
                Actions.FindElement(_ElementDescriptionBoxForNotes).SendKeys(TextForDescription + "_" + NumbersRandom);
            }
            Console.WriteLine("Text entered");
            return CreateInstance<NotesRecipientPage>();
        }
        
        public NotesRecipientPage ClickOnSaveButtonFromNotePage()
        {
            Waits.WaitForElementToBePresent(_elementSavBtnFromNotePage, WaitType.Small);
            Actions.Click(_elementSavBtnFromNotePage);
            Console.WriteLine("Clicked on Save Button from Note Page successfully");
            Thread.Sleep(500);
            return CreateInstance<NotesRecipientPage>();
        }
    }
}
