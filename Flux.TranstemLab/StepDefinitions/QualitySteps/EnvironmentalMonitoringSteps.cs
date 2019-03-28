using Flux.TranstemLab.StepHelper.Base;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Flux.TranstemLab.StepDefinitions.QualitySteps
{
    [Binding]
    public class EnvironmentalMonitoringSteps : TranstemLabTestBase
    {
        private readonly Pages pages;

        public EnvironmentalMonitoringSteps(Pages pages)
        {
            this.pages = pages;
        }

        [Then(@"I select task '(.*)'")]
        public void ThenISelectTask(string task)
        {
            pages.taskAssignmentDetailsPage = pages.environmentalMonitoringHomePage.SelectFromTasksDDL(task);
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I will click on add button to add a task")]
        public void ThenIWillClickOnAddButtonToAddATask()
        {
            pages.taskAssignmentDetailsPage.ClickOnAddTaskBtn();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I fill in the detail on the Task Response")]
        public void ThenIFillInTheDetailOnTheTaskResponse()
        {
            pages.taskAssignmentDetailsPage.FillInPopUpWindow(pages.commonMethodsPage.GetFutureDate(-3));
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on Save button in the Task Response Pop Up")]
        public void ThenIClickOnSaveButtonInTheTaskResponsePopUp()
        {
            pages.taskAssignmentDetailsPage.ClickOnSaveBtnFromTaskResponse();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on the Edit link")]
        public void ThenIClickOnTheEditLink()
        {
            pages.taskAssignmentDetailsPage.ClickOnEditLink();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I fill in the table")]
        public void ThenIFillInTheTable()
        {
            pages.taskAssignmentDetailsPage.FillInTable(pages.commonMethodsPage.GetFutureDate(2));
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on the Update link in Environmental Monitoring Home Page")]
        public void ThenIClickOnTheUpdateLinkInEnvironmentalMonitoringHomePage()
        {
            pages.taskAssignmentDetailsPage.ClickOnUpdateLink();
            pages.commonMethodsPage.TakeScreenShot();
        }

    }
}
