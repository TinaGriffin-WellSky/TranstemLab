using Flux.TranstemLab.StepHelper.Base;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using Flux.Web;

namespace Flux.TranstemLab.StepDefinitions.ProductSteps.BatchProcessingSteps
{
    [Binding]
    public class UserSystemFlowSteps : TranstemLabTestBase
    {
        private readonly Pages pages;

        public UserSystemFlowSteps(Pages pages)
        {
            this.pages = pages;
        }

        [Then(@"I click on Receipt tab on the side")]
        public void ThenIClickOnReceiptTabOnTheSide()
        {
            pages.processingProcedurePage.ClickOnReceipt();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on Receipt Details tab to open Receipt Details page")]
        public void ThenIClickOnReceiptDetailsTabToOpenReceiptDetailsPage()
        {
            pages.processingProcedurePage.ClickOnReceiptDetail();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I fill in the details in the Receipt Details")]
        public void ThenIFillInTheDetailsInTheReceiptDetails()
        {
            string date = pages.commonMethodsPage.GetFutureDate(3);
            int temp = pages.commonMethodsPage.GetRandomNumber(20, 60);
            pages.processingProcedurePage.FillInDetailsInReceiptDetailPage(temp.ToString(), date);
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on Label Review tab to open Label Review page")]
        public void ThenIClickOnLabelReviewTabToOpenLabelReviewPage()
        {
            pages.processingProcedurePage.ClickOnLabelReview();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I fill in the details in the Label Review page")]
        public void ThenIFillInTheDetailsInTheLabelReviewPage()
        {
            pages.processingProcedurePage.SelectRadiosInLabelReview();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on Other Facility to Open Other Facility page")]
        public void ThenIClickOnOtherFacilityToOpenOtherFacilityPage()
        {
            pages.processingProcedurePage.ClickOnOtherFacility();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I fill the details in the Other Facility page")]
        public void AndIFillTheDetailsInTheOtherFacilityPage()
        {
            pages.processingProcedurePage.FillInDetailsInOtherFacility();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on Reviewer (.*)")]
        public void ThenIClickOnReviewer(int p0)
        {
            pages.processingProcedurePage.ClickOnReviewer1();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I sign in with credential")]
        public void ThenISignInWithCredential()
        {
            string username = WebEnvironment.AppSettings["Username"];
            string password = WebEnvironment.AppSettings["Password"];
            pages.processingProcedurePage.SignInWithCredential(username, password);
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click done on Other Facility page")]
        public void ThenIClickDoneOnOtherFacilityPage()
        {
            pages.processingProcedurePage.ClickOnDoneOnOtherFacilityPage();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on ABO/Rh Check tab to open ABO/Rh Check page")]
        public void ThenIClickOnABORhCheckTabToOpenABORhCheckPage()
        {
            pages.processingProcedurePage.ClickOnABORhCheck();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I fill in the details in the ABO/Rh Check page")]
        public void ThenIFillInTheDetailsInTheABORhCheckPage()
        {
            pages.processingProcedurePage.FillInDetailsInABORhCheck();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on Reviewer check mark to sign")]
        public void ThenIClickOnReviewerCheckMarkToSign()
        {
            pages.processingProcedurePage.ClickOnReviewerToSignInABORhCheckPage();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click done on ABO/Rh Check page")]
        public void ThenIClickDoneOnABORhCheckPage()
        {
            pages.processingProcedurePage.ClickOnDoneBtnOnABORhCheckPage();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on the Sampling to open Sampling page")]
        public void ThenIClickOnTheSamplingToOpenSamplingPage()
        {
            pages.processingProcedurePage.ClickOnSamplingPage();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I fill in the details in the Sampling page")]
        public void ThenIFillInTheDetailsInTheSamplingPage()
        {
            pages.processingProcedurePage.FillInDetailsInSamplingPage();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on Label Verification to open Label Verification page")]
        public void ThenIClickOnLabelVerificationToOpenLabelVerificationPage()
        {
            pages.processingProcedurePage.ClickOnLabelVerificationpage();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I fill in the details in the Label Verification page")]
        public void ThenIFillInTheDetailsInTheLabelVerificationPage()
        {
            pages.processingProcedurePage.FillInDetailsInLabelVerification();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I sign all three signatures in Label Verification page")]
        public void ThenISignAllThreeSignaturesInLabelVerificationPage()
        {
            string username = WebEnvironment.AppSettings["Username"];
            string password = WebEnvironment.AppSettings["Password"];
            pages.processingProcedurePage.SignatureInLabelVerificationPage(username, password);
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on Processing Review tab to open Processing Review page")]
        public void ThenIClickOnProcessingReviewTabToOpenProcessingReviewPage()
        {
            pages.processingProcedurePage.ClickOnProcessingReview();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I sign the Processing Review \#(.*) in the Processing Review page")]
        public void ThenISignTheProcessingReviewInTheProcessingReviewPage(int p0)
        {
            string username = WebEnvironment.AppSettings["Username"];
            string password = WebEnvironment.AppSettings["Password"];
            pages.processingProcedurePage.ClickOnProcessingReview1CheckMark(username, password);
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on Cryopreservation tab on the side")]
        public void ThenIClickOnCryopreservationTabOnTheSide()
        {
            pages.processingProcedurePage.ClickOnCryopreservation();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I fill in the details in Cryopreservation page")]
        public void ThenIFillInTheDetailsInCryopreservationPage()
        {
            pages.processingProcedurePage.FillInDetailsInCryopreservationPage(pages.commonMethodsPage.GetRandomNumber(2, 10));
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I sign all two signatures in Cryopreservation page")]
        public void ThenISignAllTwoSignaturesInCryopreservationPage()
        {
            string username = WebEnvironment.AppSettings["Username"];
            string password = WebEnvironment.AppSettings["Password"];
            pages.processingProcedurePage.SignatureInCryopreservationPage(username, password);
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on RBC Depletion tab on the side")]
        public void ThenIClickOnRBCDepletionTabOnTheSide()
        {
            pages.processingProcedurePage.ClickOnRBCDepletion();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on HES-1 to open HES-1 page")]
        public void ThenIClickOnHES1ToOpenHES1Page()
        {
            pages.processingProcedurePage.ClickOnHES1();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I fill in (.*) (.*) (.*) (.*) and verify (.*) in the first section")]
        public void ThenIFillInAndVerifyInTheFirstSection(string totalVolume, string nucleatedCellCount, string HCTPercentage, string RBCVolume, string totalNucleatedCells)
        {
            bool verifyCalculation;
            pages.processingProcedurePage.FillInFirstSectionHES1AndVerify(Convert.ToDouble(totalVolume), Convert.ToDouble(nucleatedCellCount),
                Convert.ToDouble(HCTPercentage), Convert.ToDouble(RBCVolume));
            pages.commonMethodsPage.TakeScreenShot();
            verifyCalculation = pages.processingProcedurePage.VerifyFirstSection(Convert.ToDouble(totalNucleatedCells));
            Assert.True(verifyCalculation, "Calculation failed");
        }

        [Then(@"I fill in details in third section")]
        public void ThenIFillInDetailsInThirdSection()
        {
            pages.processingProcedurePage.FillInSecondSectionHES1();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I fill in (.*) and verify (.*) in the third section")]
        public void ThenIFillInAndVerifyInTheThirdSection(string totalVolume, double hetastarch)
        {
            bool verifyCalculation;
            string date = pages.commonMethodsPage.GetFutureDate(5);
            string ReagentID = pages.commonMethodsPage.GetRandomNumber(1, 99999).ToString();
            pages.processingProcedurePage.FillInThirdSectionHES1(Convert.ToDouble(totalVolume), date, ReagentID);
            pages.commonMethodsPage.TakeScreenShot();
            verifyCalculation = pages.processingProcedurePage.VerifyThirdSection(hetastarch);
            Assert.True(verifyCalculation, "Calculation failed");
        }

        [Then(@"I fill in (.*) (.*) and (.*) in the fourth section and verify the total volume")]
        public void ThenIFillInAndInTheFourthSectionAndVerifyTheTotalVolume(string plasmalyte, string totalVolume, string hetastarch)
        {
            Console.WriteLine(totalVolume + " | " + hetastarch + " | " + plasmalyte);
            bool verifyCalculation;
            pages.processingProcedurePage.FillinFourthSectionHES1(Convert.ToDouble(totalVolume), Convert.ToDouble(hetastarch),
               Convert.ToDouble(plasmalyte));
            pages.commonMethodsPage.TakeScreenShot();
            verifyCalculation = pages.processingProcedurePage.VerifyFourthSection(Convert.ToDouble(totalVolume), Convert.ToDouble(hetastarch),
               Convert.ToDouble(plasmalyte));
            Assert.True(verifyCalculation, "Calculation failed");
        }

        [Then(@"I fill in (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*) and (.*) to the table in the fifth section")]
        public void ThenIFillInAndToTheTableInTheFifthSection(string PreHes1SedimentationVolume, string PreHes1SedimentationNC, string PreHes1SedimentationTNC,
            string PreHes1SedimentationHCT, string PreHes1SedimentationRBC, string PostHes1SedimentationVolume, string PostHes1SedimentationNC,
            string PostHes1SedimentationTNC, string PostHes1SedimentationHCT, string PostHes1SedimentationRBC, string PostHes1RemovalVolume,
            string PostHes1RemovalNC, string PostHes1RemovalTNC, string PostHes1RemovalHCT, string PostHes1RemovalRBC)
        {
            string stopDate = pages.commonMethodsPage.GetFutureDate(1);
            pages.processingProcedurePage.FillInFifthSectionHES1(PreHes1SedimentationVolume, PreHes1SedimentationNC, PreHes1SedimentationTNC,
            PreHes1SedimentationHCT, PreHes1SedimentationRBC, PostHes1SedimentationVolume, PostHes1SedimentationNC,
            PostHes1SedimentationTNC, PostHes1SedimentationHCT, PostHes1SedimentationRBC, PostHes1RemovalVolume,
            PostHes1RemovalNC, PostHes1RemovalTNC, PostHes1RemovalHCT, PostHes1RemovalRBC, stopDate);
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I verify the table in the fifth section with (.*), (.*), (.*), (.*), (.*), (.*), (.*) and (.*)")]
        public void ThenIVerifyTheTableInTheFifthSectionWithAnd(double initialProductVolume, double initialProductNC, double initialProductTNC,
            double initialproductHCT, double initialProductRBC, double PreHes1SedimentationTNC, double PostHes1SedimentationTNC,
            double PostHes1RemovalTNC)
        {
            bool verifyCalculation;
            verifyCalculation = pages.processingProcedurePage.VerifyFifthSection(initialProductVolume, initialProductNC, initialProductTNC,
                initialproductHCT, initialProductRBC, PreHes1SedimentationTNC, PostHes1SedimentationTNC, PostHes1RemovalTNC);
            Assert.True(verifyCalculation, "Calculation failed");
        }

        [Then(@"I click on Folder Tracking")]
        public void ThenIClickOnFolderTracking()
        {
            pages.processingProcedurePage.CickOnFolderTracking();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I fill out details in Folder Tracking")]
        public void ThenIFillOutDetailsInFolderTracking()
        {
            pages.processingProcedurePage.FillInDetailsInFolderTracking(pages.commonMethodsPage.GetFutureDate(-1));
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on Processing Step (.*)")]
        public void ThenIClickOnProcessingStep(int p0)
        {
            pages.processingProcedurePage.ClickOnProcessingStep1();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I fill in (.*), (.*), (.*) and (.*) to First Processing Step")]
        public void ThenIFillInAndToFirstProcessingStep(string productGrossWeight, string bagTareWeight, string totalVolume, string nucleatedCellCount)
        {
            pages.processingProcedurePage.FillInProcessingStep1Form(productGrossWeight, bagTareWeight, totalVolume, nucleatedCellCount);
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I verify the information in the First processing Step and sign in as Tech")]
        public void ThenIVerifyTheInformationInTheFirstProcessingStepAndSignInAsTech()
        {
            string username = WebEnvironment.AppSettings["Username"];
            string password = WebEnvironment.AppSettings["Password"];
            bool verifyCalculation;
            verifyCalculation = pages.processingProcedurePage.VerifyProcessingStep1Form();
            Assert.True(verifyCalculation, "Calculation failed");
            pages.commonMethodsPage.TakeScreenShot();
            pages.processingProcedurePage.SignProcessingStep("1", username, password);
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on Processing Step two")]
        public void ThenIClickOnProcessingStepTwo()
        {
            pages.processingProcedurePage.ClickOnProcessingStep2();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I fill in (.*), (.*), (.*) and (.*) to Second Processing Step")]
        public void ThenIFillInAndToSecondProcessingStep(string totalVolume, string nucleatedCellCount, string cd34, string cd3)
        {
            pages.processingProcedurePage.FillInProcessingStep2Form(totalVolume, nucleatedCellCount, cd34, cd3);
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I verify the information in the Second processing Step and sign in as Tech")]
        public void ThenIVerifyTheInformationInTheSecondProcessingStepAndSignInAsTech()
        {
            string username = WebEnvironment.AppSettings["Username"];
            string password = WebEnvironment.AppSettings["Password"];
            bool verifyCalculation;
            verifyCalculation = pages.processingProcedurePage.VerifyProcessingStep2Form();
            Assert.True(verifyCalculation, "Calculation failed");
            pages.commonMethodsPage.TakeScreenShot();
            pages.processingProcedurePage.SignProcessingStep("2", username, password);
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I navigate to CD34\+ Section A")]
        public void ThenINavigateToCD34PositiveSectionA()
        {
            pages.processingProcedurePage.ClickOnCD34Selection();
            pages.commonMethodsPage.TakeScreenShot();
            pages.processingProcedurePage.ClickOnCD34SectionA();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I fill in Transfer of Leukapheresis Product into Cell Preparation Bag section with (.*), (.*), (.*), (.*), (.*), (.*)")]
        public void ThenIFillInTransferOfLeukapheresisProductIntoCellPreparationBagSection(string p0, int p1, double p2, double p3, int p4, double p5)
        {
            string date = pages.commonMethodsPage.GetFutureDate(pages.commonMethodsPage.GetRandomNumber(-365, 0));
            pages.processingProcedurePage.FillInTransferOfLeukapheresisIntoCPB(date, p0, Convert.ToBoolean(p1), p2, p3, Convert.ToBoolean(p4), p5);
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I fill in Diluting Leukapheresis Product section with (.*), (.*)")]
        public void ThenIFillInDilutingLeukapheresisProductSection(double p0, double p1)
        {
            pages.processingProcedurePage.FillInDilutingLeukapheresis(p0, p1);
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I fill in Centrifugation Conditions with (.*), (.*), (.*), (.*)")]
        public void ThenIFillInCentrifugationConditions(string p0, double p1, double p2, int p3)
        {
            pages.processingProcedurePage.FillInCentrifugationConditions(p0, p1, p2, Convert.ToBoolean(p3));
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I fill in Calculate the Amount of Supernatant to be Removed to give a Final Volume section with (.*), (.*)")]
        public void ThenIFillInCalculateTheAmountOfSupernatantToBeRemovedToGiveAFinalVolumeSection(string p0, string p1)
        {
            pages.processingProcedurePage.FillInCalculatingSupernatantToBeRemoved(p0, p1);
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I verify Section A using (.*), (.*), (.*), (.*)")]
        public void ThenIVerifySectionA(double p0, double p1, double p2, double p3)
        {
            pages.processingProcedurePage.VerifyCD34SectionA(p0, p1, p2, p3);
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I navigate to CD34\+ Section B")]
        public void ThenINavigateToCD34PositiveSectionB()
        {
            pages.processingProcedurePage.ClickOnCD34Selection();
            pages.commonMethodsPage.TakeScreenShot();
            pages.processingProcedurePage.ClickOnCD34SectionB();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I fill in Magnetic Labeling of CD34 Positive Cells with (.*), (.*)")]
        public void ThenIFillInMagneticLabelingOfCD34PositiveCells(string p1, string p2)
        {
            pages.processingProcedurePage.FillInMagneticLabeling(p1, p2);
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I fill in Incubation with (.*), (.*), (.*), test comment, (.*)")]
        public void ThenIFillInIncubationWithTestComment(string p0, int p1, int p2, string p3)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I fill in Incubation with (.*), (.*), (.*), (.*), (.*)")]
        public void ThenIFillInIncubation(string p0, int p1, int p2, string p3, string p4)
        {
            pages.processingProcedurePage.FillInIncubation(p0, p4, Convert.ToBoolean(p1), Convert.ToBoolean(p2), p3);
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I fill in Wash Number One with (.*), (.*), (.*), (.*), (.*)")]
        public void ThenIFillInWashNumberOne(double p0, string p1, string p2, double p3, double p4)
        {
            pages.processingProcedurePage.FillInWash1(p0.ToString(), p1, p2, p3.ToString(), p4.ToString());
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I fill in Wash Number Two with (.*), (.*), (.*), (.*), (.*), (.*)")]
        public void ThenIFillInWashNumberTwo(double p0, string p1, string p2, double p3, double p4, double p5)
        {
            pages.processingProcedurePage.FillInWash2(p0.ToString(), p1, p2, p3.ToString(), p4.ToString(), p5.ToString());
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I fill in Final Sample Preparation with (.*), (.*), (.*)")]
        public void ThenIFillInFinalSamplePreparation(int p0, int p1, double p2)
        {
            pages.processingProcedurePage.FillInFinalSamplePreparation(Convert.ToBoolean(p0), Convert.ToBoolean(p1), p2.ToString());
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I verify Section B using (.*)")]
        public void ThenIVerifySectionBUsing(double p0)
        {
            pages.processingProcedurePage.VerifyCD34SectionB(p0);
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I navigate to CD34\+ Section C")]
        public void ThenINavigateToCD34PositiveSectionC()
        {
            pages.processingProcedurePage.ClickOnCD34Selection();
            pages.commonMethodsPage.TakeScreenShot();
            pages.processingProcedurePage.ClickOnCD34SectionC();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I fill in CliniMACS Separation \(Run\) with (.*), (.*), (.*), (.*), (.*)")]
        public void ThenIFillInCliniMACSSeparationRun(string p0, string p1, string p2, string p3, string p4)
        {
            pages.processingProcedurePage.FillInCliniMACSSeparation(p0, p1, p2, p3, p4);
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I fill in Calculate the Amount of Positive Fraction with (.*), (.*), (.*)")]
        public void ThenIFillInCalculateTheAmountOfPositiveFraction(string p0, string p1, string p2)
        {
            pages.processingProcedurePage.FillInCalculateAmountOfPositiveFraction(p0, p1, p2);
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I verify Section C")]
        public void ThenIVerifySectionC()
        {
            pages.processingProcedurePage.VerifyCD34SectionC();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I navigate to Data Analysis Unselected Processing")]
        public void ThenINavigateToDataAnalysisUnselectedProcessing()
        {
            pages.processingProcedurePage.ClickOnCD34Selection();
            pages.commonMethodsPage.TakeScreenShot();
            pages.processingProcedurePage.ClickOnDataAnalysisUnselectedProcessing();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I fill in HPC Product Aliquot for Unselected Processing with (.*), (.*), (.*), (.*), (.*), (.*)")]
        public void ThenIFillInHPCProductAliquotForUnselectedProcessing(int p0, string p1, string p2, string p3, string p4, string p5)
        {
            string username = WebEnvironment.AppSettings["Username"];
            string password = WebEnvironment.AppSettings["Password"];
            pages.processingProcedurePage.FillInHPCProductAliquotForUnselectedProcessing(Convert.ToBoolean(p0), p1, p2, p3, p4, p5);
            //pages.processingProcedurePage.SignHPCProductAliquotForUnselectedProcessing(username, password);
        }

        [Then(@"I fill in T-Cell Aliquot with (.*), (.*), (.*), (.*), (.*), (.*)")]
        public void ThenIFillInT_CellAliquot(int p0, string p1, string p2, string p3, string p4, string p5)
        {
            string username = WebEnvironment.AppSettings["Username"];
            string password = WebEnvironment.AppSettings["Password"];
            pages.processingProcedurePage.FillInTCellAliquot(Convert.ToBoolean(p0), p1, p2, p3, p4, p5);
            //pages.processingProcedurePage.SignTCellAliquot(username, password);
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I fill in Pre-Spin \(After Removal of T-Cell Aliquots\) with (.*), (.*), (.*), (.*), (.*)")]
        public void ThenIFillInPre_SpinAfterRemovalOfT_CellAliquots(int p0, string p1, string p2, string p3, string p4)
        {
            string username = WebEnvironment.AppSettings["Username"];
            string password = WebEnvironment.AppSettings["Password"];
            pages.processingProcedurePage.FillInPreSpin(Convert.ToBoolean(p0), p1, p2, p3, p4);
            //pages.processingProcedurePage.SignPreSpin(username, password);
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I fill in Post-Spin with (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*)")]
        public void ThenIFillInPost_Spin(int p0, string p1, string p2, string p3, string p4, string p5, string p6, string p7, string p8, string p9, string p10, string p11)
        {
            string username = WebEnvironment.AppSettings["Username"];
            string password = WebEnvironment.AppSettings["Password"];
            pages.processingProcedurePage.FillInPostSpin(Convert.ToBoolean(p0), p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11);
            //pages.processingProcedurePage.SignPostSpin(username, password);
        }

        [Then(@"I verify Data Analysis Unselected Processing")]
        public void ThenIVerifyDataAnalysisUnselectedProcessing()
        {
            pages.processingProcedurePage.VerifyDataAnalysisUnselectedProcessing();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I navigate to Data Analysis CD34 Selection")]
        public void ThenINavigateToDataAnalysisCDSelection()
        {
            pages.processingProcedurePage.ClickOnCD34Selection();
            pages.commonMethodsPage.TakeScreenShot();
            pages.processingProcedurePage.ClickOnDataAnalysisCD34Selection();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I fill in HPC Product Aliquot for CD34 Selection \(Before Prep/Magnetic Labeling\) with (.*), (.*), (.*), (.*), (.*)")]
        public void ThenIFillInHPCProductAliquotForCDSelectionBeforePrepMagneticLabeling(string p0, string p1, string p2, string p3, string p4)
        {
            string username = WebEnvironment.AppSettings["Username"];
            string password = WebEnvironment.AppSettings["Password"];
            pages.processingProcedurePage.FillInHPCBeforePrep(p0, p1, p2, p3, p4);
            pages.commonMethodsPage.TakeScreenShot();
            pages.processingProcedurePage.SignHPCBeforePrep(username, password);
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I fill in HPC Product Aliquot for CD34 Selection \(After Prep/Magnetic Labeling\) with (.*), (.*), (.*), (.*), (.*)")]
        public void ThenIFillInHPCProductAliquotForCDSelectionAfterPrepMagneticLabeling(string p0, string p1, string p2, string p3, string p4)
        {
            string username = WebEnvironment.AppSettings["Username"];
            string password = WebEnvironment.AppSettings["Password"];
            pages.processingProcedurePage.FillInHPCAfterPrep(p0, p1, p2, p3, p4);
            pages.commonMethodsPage.TakeScreenShot();
            pages.processingProcedurePage.SignHPCAfterePrep(username, password);
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I fill in CD34 Selected Positive Fraction \(Cell Collection Bag\) with (.*), (.*), (.*), (.*), (.*), (.*)")]
        public void ThenIFillInCDSelectedPositiveFractionCellCollectionBag(string p0, string p1, string p2, string p3, string p4, string p5)
        {
            string username = WebEnvironment.AppSettings["Username"];
            string password = WebEnvironment.AppSettings["Password"];
            pages.processingProcedurePage.FillInCD34SelectedPositiveFraction(p0, p1, p2, p3, p4, p5);
            pages.commonMethodsPage.TakeScreenShot();
            pages.processingProcedurePage.SignPositiveFraction(username, password);
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I fill in CD34 Selected Negative Fraction \(Negative Fraction Bag\) with (.*), (.*), (.*), (.*), (.*)")]
        public void ThenIFillInCDSelectedNegativeFractionNegativeFractionBag(string p0, string p1, string p2, string p3, string p4)
        {
            string username = WebEnvironment.AppSettings["Username"];
            string password = WebEnvironment.AppSettings["Password"];
            pages.processingProcedurePage.FillInCD34SelectedNegativeFraction(p0, p1, p2, p3, p4);
            pages.commonMethodsPage.TakeScreenShot();
            pages.processingProcedurePage.SignNegativeFraction(username, password);
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I verify the calculations in Data Analysis CD34 Selection")]
        public void ThenIVerifyTheCalculationsInDataAnalysisCDSelection()
        {
            pages.processingProcedurePage.VerifyBeforePrep();
            pages.commonMethodsPage.TakeScreenShot();
            pages.processingProcedurePage.VerifyAfterPrep();
            pages.commonMethodsPage.TakeScreenShot();
            pages.processingProcedurePage.VerifyPositiveFraction();
            pages.commonMethodsPage.TakeScreenShot();
            pages.processingProcedurePage.VerifyNegativeFraction();
            pages.commonMethodsPage.TakeScreenShot();
        }
    }
}
