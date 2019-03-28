using Flux.Web;
using OpenQA.Selenium;
using System;

namespace Flux.TranstemLab.StepHelper.Pages.Administrator
{
    public class ProcessingDetailsPage : WebPageBase
    {
        private readonly By _elementAddRecord = By.Id("btnAddProcessingDetail");
        private readonly By _elementEdit = By.Id("EditLink");
        private readonly By _elementDelete = By.CssSelector("img[title='Delete']");
        private readonly By _elementUpdate = By.ClassName("UpdateLink");
        private readonly By _elementCancel = By.ClassName("CancelLink");

        public void ClickOnAddRecord()
        {
            Actions.Click(_elementAddRecord);
            Console.WriteLine("Clicked on Add new record");
            Waits.WaitForPageLoad();
        }
        
        public void ClickOnEdit()
        {
            Actions.Click(_elementEdit);
            Console.WriteLine("Clicked on Edit");
        }

        public void ClickOnDelete()
        {
            Actions.Click(_elementDelete);
            Console.WriteLine("Clicked on Delete");
            Actions.AcceptAlert();
            Console.WriteLine("Confirmed warning pop-up");
            Waits.WaitForPageLoad();
        }

        public void TypeInDescription(string rowNum, string description)
        {
            string id = "ProcessingDetails_" + rowNum + "__Description";
            Actions.SendKeys(By.Id(id), description);
            Console.WriteLine("Typed in description");
        }

        public void ClickOnUpdate()
        {
            Actions.Click(_elementUpdate);
            Console.WriteLine("Clicked on Update");
            
            if (Actions.IsAlertPresent())
            {
                Actions.AcceptAlert();
                Console.WriteLine("Confirmed warning pop-up");
                Waits.WaitForPageLoad();
            }
        }

        public void ClickOnCancel()
        {
            Actions.Click(_elementCancel);
            Console.WriteLine("Clicked on Cancel");
            Waits.WaitForPageLoad();
        }
    }
}
