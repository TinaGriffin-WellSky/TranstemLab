using Flux.TranstemLab.StepHelper.Base;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Flux.TranstemLab.StepDefinitions.AdminSteps
{
    class EnvironmentalMonitorMgmtSteps : TranstemLabTestBase
    {
        private readonly Pages pages;

        public EnvironmentalMonitorMgmtSteps(Pages pages)
        {
            this.pages = pages;
        }

        [Then(@"I click on Environmental Monitoring Link")]
        public void ThenIClickOnEnvironmentalMonitoringLink()
        {
            pages.environmentalMonitorMgmtPage = pages.adminHomePage.ClickOnEnvironmentalMonitoringLink();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on Add button to add a new task")]
        public void ThenIClickOnAddButtonToAddANewTask()
        {
            pages.environmentalMonitoringTaskDetail = pages.environmentalMonitorMgmtPage.ClickOnAddTaskButton();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I enter a name in Task Name field")]
        public void ThenIEnterANameInTaskNameField()
        {
            pages.environmentalMonitoringTaskDetail.EnterTaskName(pages.commonMethodsPage.GenerateName(5));
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on the save button")]
        public void ThenIClickOnTheSaveButton()
        {
            pages.environmentalMonitoringTaskDetail.ClickOnSaveBtn();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I sort the table to view tasks in DESC order")]
        public void ThenISortTheTableToViewTasksInDESCOrder()
        {
            pages.environmentalMonitorMgmtPage.ClickOnDateCreatedToSort();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on the task just created")]
        public void ThenIClickOnTheTaskJustCreated()
        {
            pages.environmentalMonitorMgmtPage.ClickOnFirstTaskInTable();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I want to create '(.*)' columns")]
        public void ThenIWantToCreateColumns(int numCol)
        {
            pages.environmentalMonitoringTaskDetail.ClickOnAddColumn(numCol);
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I fill out those columns")]
        public void ThenIFillOutThoseColumns()
        {
            pages.environmentalMonitoringTaskDetail.FillInColumns(pages.commonMethodsPage.GenerateName(10));
            pages.commonMethodsPage.TakeScreenShot();
        }
    }
}
