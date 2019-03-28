using Flux.Web;
using Flux.Core;
using OpenQA.Selenium;
using System;

namespace Flux.TranstemLab.StepHelper.Pages.Administrator
{
    public class EnvironmentalMonitorMgmtPage : WebPageBase
    {
        private readonly By _elementAddTaskBtn = By.Id("btnAddTask");
        private readonly By _elementSortByDateDESC = By.CssSelector("a[href='/EnvironmentalMonitoring?sort=CreateDatetime&sortdir=DESC']");
        private readonly By _elementFirstTaskInTable = By.CssSelector("a[href^='/EnvironmentalMonitoring/ShowTaskDetail?taskid=']");

        //this method is to click on the add task button
        public EnvironmentalMonitoringTaskDetail ClickOnAddTaskButton()
        {
            Actions.Click(_elementAddTaskBtn);
            Console.WriteLine("Add task button is being clicked");
            return CreateInstance<EnvironmentalMonitoringTaskDetail>();
        }

        //this method is to click on sort by date/time created
        public void ClickOnDateCreatedToSort()
        {
            Actions.Click(_elementSortByDateDESC);
            Console.WriteLine("The task is desplayed by date in desending order");
        }

        //this method is to click on the first task in the table
        public void ClickOnFirstTaskInTable()
        {
            Waits.WaitForPageLoad();
            Actions.Click(_elementFirstTaskInTable);
            Console.WriteLine("The first task in the tale is being clicked");
        }
    }
}
