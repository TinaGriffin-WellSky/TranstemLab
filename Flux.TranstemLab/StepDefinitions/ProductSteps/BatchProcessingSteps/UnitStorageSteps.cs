using Flux.TranstemLab.StepHelper.Base;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace Flux.TranstemLab.StepDefinitions.ProductSteps.BatchProcessingSteps
{
    [Binding]
    public class UnitStorageSteps : TranstemLabTestBase
    {
        private readonly Pages pages;

        public UnitStorageSteps(Pages pages)
        {
            this.pages = pages;
        }

        [Then(@"I click on Unit Storage")]
        public void ThenIClickOnUnitStorage()
        {
            pages.processingProcedurePage.ClickOnUnitStorage();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I fill out the unit storage information")]
        public void ThenIFillOutTheUnitStorageInformation()
        {
            int freezerNum = pages.commonMethodsPage.GetRandomNumber(1, 99);
            int rack = pages.commonMethodsPage.GetRandomNumber(1, 99);
            int position = pages.commonMethodsPage.GetRandomNumber(1, 99);
            pages.processingProcedurePage.FillUnitStorage(freezerNum.ToString(), rack.ToString(), position.ToString());
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I verify that the storage action saves")]
        public void ThenIVerifyThatTheStorageActionSaves()
        {
            Assert.True(pages.processingProcedurePage.VerifyUnitStorageSave(), "No save message appeared");
            pages.commonMethodsPage.TakeScreenShot();
            Console.WriteLine("Storage action saved successfully");
        }
    }
}
