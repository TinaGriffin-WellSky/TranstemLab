using Flux.Web;
using Flux.Core;
using OpenQA.Selenium;
using System;

namespace Flux.TranstemLab.StepHelper.Pages.Administrator
{
    public class AdminHomePage : WebPageBase
    {
        private readonly By _elementUserMgmt = By.CssSelector("a[href='../Admin/access/users.aspx']");
        private readonly By _elementEnvirMonitorMgmt = By.CssSelector("a[href^='../Environmental']");
        private readonly By _elementReferenceTable = By.CssSelector("a[href^='../Admin/customize/ReferenceTableMaint.aspx#']");
        private readonly By _elementProcessingDetails = By.CssSelector("a[href='../CollectionProcessingOrder/ProcessingDetailAdmin']");

        public UserMgmtPage ClickOnUserMgmt()
        {
            Waits.WaitForElementToBeClickable(_elementUserMgmt, WaitType.Small);
            Actions.Click(_elementUserMgmt);
            Console.WriteLine("Clicked on User Management link");
            return CreateInstance<UserMgmtPage>();
        }

        //this method is used to create environmental monitoring management page
        public EnvironmentalMonitorMgmtPage ClickOnEnvironmentalMonitoringLink()
        {
            Actions.Click(_elementEnvirMonitorMgmt);
            Console.WriteLine("Clicked on Environmental Monitoring link");
            return CreateInstance<EnvironmentalMonitorMgmtPage>();
        }

        public ReferenceTablesPage ClickOnReferneceTableLink()
        {
            Actions.Click(_elementReferenceTable);
            Console.WriteLine("Clicked on Reference Table");
            return CreateInstance<ReferenceTablesPage>();
        }

        public ProcessingDetailsPage ClickOnProcessingDetails()
        {
            Actions.Click(_elementProcessingDetails);
            Console.WriteLine("Clicked on Processing Details link");
            return CreateInstance<ProcessingDetailsPage>();
        }
    }
}