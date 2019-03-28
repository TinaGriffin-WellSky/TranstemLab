using Flux.Web;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections;

namespace Flux.TranstemLab.StepHelper.Pages.EnvironmentalMonitoring
{
    public class EnvironmentalMonitoringHomePage : WebPageBase
    {
        private readonly By _elementEnvironmentalMonitoringTasksDDL = By.Id("ddlTasks");


        //this method is to select specific task
        public TaskAssignmentDetailsPage SelectFromTasksDDL(string task)
        {
            Actions.SelectByVisibleText(_elementEnvironmentalMonitoringTasksDDL, task);
            Console.WriteLine(task + " is beind selected in the drop down list");
            return CreateInstance<TaskAssignmentDetailsPage>();
        }
    }
}
