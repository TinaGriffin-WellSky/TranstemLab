using Flux.TranstemLab.StepHelper.Base;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace Flux.TranstemLab.StepDefinitions.ProductSteps.BatchProcessingSteps
{
    [Binding]
    public class DivideBatchAndCheckParentSteps : TranstemLabTestBase
    {
        private readonly Pages pages;

        public DivideBatchAndCheckParentSteps(Pages pages)
        {
            this.pages = pages;
        }

        [Then(@"I click on Product Link and select Batch Processing to Search page")]
        public void ThenIClickOnProductLinkAndSelectBatchProcessingToSearchPage()
        {
            pages.searchBatchPage = pages.transtemLabHomePage.ClickOnBatchProcessing();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on Add Batch button to Add Batch page")]
        public void ThenIClickOnAddBatchButtonToAddBatchPage()
        {
            pages.addBatchPage = pages.searchBatchPage.ClickOnAddBatch();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I change the Date Range")]
        public void ThenIChangeTheDateRange()
        {
            //pages.commonMethodsPage = pages.transtemLabHomePage.ReferenceForCommonMethods();
            string StartDate = pages.commonMethodsPage.GetFutureDate(-180);
            pages.addBatchPage.TypeAccessioningDateStart(StartDate);
        }

        [Then(@"I select Cell Processing v1 20111 from the drop down list")]
        public void ThenISelectCellProcessingV1_20111FromTheDropDownList()
        {
            pages.addBatchPage.SelectProcessingProcedure();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on Search button in the Add Batch page")]
        public void ThenIClickOnSearchButtonInTheAddBatchPage()
        {
            pages.setBatchPage = pages.addBatchPage.ClickOnSearch();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I select the first parent in the table")]
        public void ThenISelectTheFirstParentInTheTable()
        {
            pages.setBatchPage.FindFirstParentBatch();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on the check box of the parent and click on Set Batch button to navigate to Processing Procedure page")]
        public void ThenIClickOnTheCheckBoxOfTheParentAndClickOnSetBatchButtonToNavigateToProcessingProcedurePage()
        {
            int indexOfFirstParent = pages.setBatchPage.FindFirstParentBatch();
            pages.batchHomePage = pages.setBatchPage.CheckParentAndClickOnSetBatch(indexOfFirstParent);
        }

        [Then(@"I click on the check box of the newly created product")]
        public void ThenIClickOnTheCheckBoxOfTheNewlyCreatedProduct()
        {
            int indexOfNewProduct = pages.setBatchPage.FindNewBatch();
            pages.batchHomePage = pages.setBatchPage.CheckParentAndClickOnSetBatch(indexOfNewProduct);
        }

        [Then(@"I select a Technologist from Technologist Name drop down")]
        public void ThenISelectATechnologistFromTechnologistNameDropDown()
        {
            pages.batchHomePage.SelectRandomTechnician();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on Save button to save the Processing Procedure")]
        public void ThenIClickOnSaveButtonToSaveTheProcessingProcedure()
        {
            pages.batchHomePage.ClickOnSave();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on Product List and navigate to Processing page")]
        public void ThenIClickOnProductListAndNavigateToProcessingPage()
        {
            pages.processingProcedurePage = pages.batchHomePage.ClickOnProductList();
            pages.commonMethodsPage.TakeScreenShot();
        }


        [Then(@"I get the product ID from product home page")]
        public void ThenIGetTheProductIDFromProductHomePage()
        {
            pages.processingProcedurePage.RecordCurrentUrl();
            pages.commonMethodsPage.TakeScreenShot();
            pages.processingProcedurePage.ClickOnTitleArrow();
            pages.commonMethodsPage.TakeScreenShot();
            pages.processingProcedurePage.ClickOnUnitIdLink();
            pages.commonMethodsPage.TakeScreenShot();
            pages.processingProcedurePage.SetProductId(pages.processingProcedurePage.ParseProductIDFromUrl());
            pages.commonMethodsPage.TakeScreenShot();
            pages.processingProcedurePage.BackToPreviousPage();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on Divide button")]
        public void ThenIClickOnDivideButton()
        {
            pages.processingProcedurePage.ClickOnDivideBtn();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I select (.*) for number of divisions, and I click on Yes button for distributing product division counts evenly")]
        public void ThenISelectForNumberOfDivisionsAndIClickOnYesButtonForDistributingProductDivisionCountsEvenly(int p0)
        {
            pages.processingProcedurePage.ClickYesRadioBtn();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I select the Product ID that was created")]
        public void ThenISelectTheProductIDThatWasCreated()
        {
            pages.setBatchPage.FindNewBatch();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click Save")]
        public void ThenIClickSave()
        {
            pages.processingProcedurePage.ClickOnSaveBtn();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click Save on Pop window")]
        public void ThenIClickSaveOnPopWindow()
        {
            pages.processingProcedurePage.ClickOnSaveBtnFromPopUp();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on the parent title arrow")]
        public void ThenIClickOnTheParentTitleArrow()
        {
            pages.commonMethodsPage.TakeScreenShot();
            pages.processingProcedurePage.ClickOnParentTitleArrow();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I verify that the parent is read only")]
        public void ThenIVerifyThatTheParentIsReadOnly()
        {
            Assert.True(pages.processingProcedurePage.IsWeightAndVolumeVisible(), "Parent is still edible!");
            pages.commonMethodsPage.TakeScreenShot();
            Console.WriteLine("test passed, parent is not edible");
        }

        [Then(@"I verify the patient is in the drop down list")]
        public void ThenIVerifyThePatientIsInTheDropDownList()
        {
            Assert.True(pages.processingProcedurePage.IsRecipientInddl(), "Recipient is not in ddl");
            pages.processingProcedurePage.ClickOnSaveBtn();
            pages.commonMethodsPage.TakeScreenShot();
            Console.WriteLine("The processing procedure is saved, and the recipient is verified");
        }

        [Then(@"I record product information")]
        public void ThenIRecordProductInformation()
        {
            pages.processingProcedurePage.SetProcudeCode();
            pages.commonMethodsPage.TakeScreenShot();
            pages.processingProcedurePage.SetUnitId();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I open '(.*)' and I generate the HL7 message for testing")]
        public void ThenIOpenAndIGenerateTheHLMessageForTesting(string fileName)
        {
            string productId = pages.processingProcedurePage.GetUnitId();
            pages.commonMethodsPage.TakeScreenShot();
            string productCode = pages.processingProcedurePage.GetProductCode();
            pages.commonMethodsPage.TakeScreenShot();
            pages.commonMethodsPage.GenerateHL7(productId, productCode, fileName);
            pages.commonMethodsPage.TakeScreenShot();
        }
    }
}
