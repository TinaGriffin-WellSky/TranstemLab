using Flux.Web;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace Flux.TranstemLab.StepHelper.Pages.Administrator
{
    public class ReferenceTablesPage : WebPageBase
    {
        private readonly By _elementSystemButton = By.CssSelector("a[href='#']");
        private readonly By _elementLookUpTable = By.Id("LookupRecordsTable");
        private readonly By _elementAddBtn = By.CssSelector("input[value='Add']");
        private readonly By _elementCancelBtn = By.CssSelector("input[value='Cancel']");
        private readonly By _elementSaveBtn = By.CssSelector("input[value='Save']");
        private readonly By _elementTable = By.Id("rtmTreeviewTable");
        private readonly By _elementCellViabilityMethod = By.XPath("//*[@id=\"rtmTreeBranchesTd\"]/div/fieldset/div/ul/li[5]/a");
        private readonly By _elementSortShortDesc = By.Id("ShortDesc");
        private readonly By _elementSortLongDesc = By.Id("LongDesc");
        private readonly By _elementSortIsActive = By.Id("IsActive");
        private readonly By _elementSortIsDefault = By.Id("IsDefault");
        private readonly By _elementSortValue = By.Id("SortValue");
        private readonly By _elementHomePageIcon = By.Name("ctl00$searchBlock1$ctl00");

        public void ClickOnSystemButton()
        {
            Actions.Click(_elementSystemButton);
            Waits.WaitForPageLoad();
            Console.WriteLine("List of table appeared");
        }

        //function used to loop throught the entire list
        public void ClickOnAllTables()
        {
            //Actions.Click(By.XPath("//*[@id=\"rtmTreeBranchesTd\"]/div/fieldset/div/ul/li[5]/a"));
            //Actions.Click(By.CssSelector("a[data-table-id='40012']"));

            for (int i = 40001; i <= 40005; i++)
            {
                string cssSelector = "a[data-table-id='"+ i.ToString() + "']";
                Console.WriteLine("css selector is " + cssSelector);
                By _elementTable = By.CssSelector(cssSelector);
                //Waits.WaitForElementToBeClickable(_elementTable, WaitType.Small);
                Actions.Click(_elementTable);
                PrintLookUpTable();
            }
        }

        //function used to print look up tables
        public void PrintLookUpTable()
        {
            IList<IWebElement> allElement = Actions.FindElements(_elementLookUpTable);
            string cellText = string.Empty;
            foreach (IWebElement element in allElement)
            {
                cellText = element.Text;
                Console.WriteLine("values in the cells are " + cellText);
            }
        }

        public void ClickOnCellViabilityMethod()
        {
            Actions.Click(_elementCellViabilityMethod);
            Console.WriteLine("cell viability method table is displayed");
            PrintLookUpTable();
        }

        public void ClickOnAddBtn()
        {
            Actions.Click(_elementAddBtn);
            Console.WriteLine("Add button is clicked");
        }

        public void EnterValueInFirstRow(string randomValue)
        {
            By _elementShortDesc = By.CssSelector("#LookupRecordsTable > tbody > tr:nth-child(1) > td:nth-child(2)");
            By _elementLongDesc = By.CssSelector("#LookupRecordsTable > tbody > tr:nth-child(1) > td:nth-child(3)");
            Console.WriteLine("Value before change:");
            PrintCell(_elementLongDesc);
            PrintCell(_elementShortDesc);
            Actions.Click(_elementShortDesc);
            Actions.PressKey(randomValue);
            Actions.Click(_elementLongDesc);
            Actions.PressKey(randomValue);
            Console.WriteLine("Value after change:");
            PrintCell(_elementLongDesc);
            PrintCell(_elementShortDesc);
        }

        public void PrintCell(By _elementCell)
        {
            Console.WriteLine(" value in the cell is " + Actions.GetAttributeValue(_elementCell, "value"));
        }

        public void SortTableAndPrint(By _elementSort)
        {
            Actions.Click(_elementSort);
            Console.WriteLine("Table after " + _elementSort.ToString() + " clicked once");
            PrintLookUpTable();
            Actions.Click(_elementSort);
            Console.WriteLine("Table after " + _elementSort.ToString() + " clicked again");
            PrintLookUpTable();
        }

        public void ClickOnAllSort()
        {
            SortTableAndPrint(_elementSortShortDesc);
            SortTableAndPrint(_elementSortLongDesc);
            SortTableAndPrint(_elementSortIsActive);
            SortTableAndPrint(_elementSortIsDefault);
            SortTableAndPrint(_elementSortValue);
        }

        public void ClickOnSaveBtn()
        {
            Actions.Click(_elementSaveBtn);
            Console.WriteLine("Save button is clicked");
        }

        //this method is used for click on the home page
        public void NavigateToHomePage()
        {
            Actions.Click(_elementHomePageIcon);
        }
    }
}
