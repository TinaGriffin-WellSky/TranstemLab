﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Flux.TranstemLab.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("User System Flow")]
    public partial class UserSystemFlowFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "UserSystemFlowFeature.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "User System Flow", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User System Flow")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        [NUnit.Framework.TestCaseAttribute("Test", "TF", "TL", "MR", "CR", "RID", "", "452", "5.02", "5", "22.6", "0", "22.69", "90.4", "542.4", "3.99", "21.64", "4", "21.7", "522", "4.37", "22.8", "2", "10.4", "166", "13.76", "22.84", "7", "11.6", "95.4", "105.4", "100.2", "419", "40", "4.88", "0.19", "10.9", "2/6/15", "09:15", "1", "327", "37", "0", "290", "340", "552", "123", "15", "838", "0", "325", "225", "6150106017", "6150106017", "11:13", "1", "0", "1337", "11:43", "353", "123", "15", "838", "465", "462", "456", "15", "838", "457", "115", "0", "1", "309", "6/2/15", "15:19", "6/2/15", "16:04", "2304", "104", "22.0", "M60F0004S4002N1", "1", "", "", "", "", "", "1", "", "", "", "", "", "1", "", "", "", "", "1", "", "", "", "", "", "", "", "", "", "", "", "290", "3.07", "0.68", "14.3", "99.0", "272", "2.95", "0.82", "17.5", "98.8", "A0", "82", "5.53", "90.57", "0.04", "99.2", "421", "1.72", "0.11", "19.2", "94.0", null)]
        public virtual void UserSystemFlow(
                    string recipientID, 
                    string firstName, 
                    string lastName, 
                    string medicalRecord, 
                    string cRID, 
                    string registryID, 
                    string birthDate, 
                    string totalVolume, 
                    string nucleatedCellCount, 
                    string hCT, 
                    string rBCVolume, 
                    string plasmalyte, 
                    string totalNucleatedCells, 
                    string hetastarch, 
                    string preHES_1SedimentationVolume, 
                    string preHES_1SedimentationNC, 
                    string preHES_1SedimentationTNC, 
                    string preHES_1SedimentationHCT, 
                    string preHES_1SedimentationRBC, 
                    string postHES_1SedimentationVolume, 
                    string postHES_1SedimentationNC, 
                    string postHES_1SedimentationTNC, 
                    string postHES_1SedimentationHCT, 
                    string postHES_1SedimentationRBC, 
                    string postHES_1RemovalVolume, 
                    string postHES_1RemovalNC, 
                    string postHES_1RemovalTNC, 
                    string postHES_1RemovalHCT, 
                    string postHES_1RemovalRBC, 
                    string preHES_1SedimentationTNCRecovery, 
                    string postHES_1SedimentationTNCRecovery, 
                    string postHES_1RemovalTNCRecovery, 
                    string productGrossWeight, 
                    string bagTareWeight, 
                    string nucleatedCellCountPP, 
                    string cD34, 
                    string cD3, 
                    string leukapheresisTransferIntoCellBagStartDate, 
                    string leukapheresisTransferIntoCellBagStartTime, 
                    string removeSampleForTesting, 
                    string weightOfBagWithLeukapheresis, 
                    string weightOfEmptyBag, 
                    string a4ReducedNA, 
                    string weightOfLeukapheresisAfterReduction, 
                    string actualDilutionBufferAdded, 
                    string bagWeightAfterAddingDilutionBuffer, 
                    string centrifugeID, 
                    string centrifugationTime, 
                    string centrifugationSpeed, 
                    string targetFinalVolumeIs95G, 
                    string actualAmountOfSupernatantRemoved, 
                    string totalWeightOfBagAfterCompleteDilution, 
                    string cD34ReagentID, 
                    string secondCD34ReagentID, 
                    string incubationStartTime, 
                    string airInjection, 
                    string placedOnRotator, 
                    string rotatorComment, 
                    string incubationStopTime, 
                    string wash1AmountOfBufferTransferredIntoBag, 
                    string wash1CentrifugeID, 
                    string wash1CentrifugationTime, 
                    string wash1CentrifugationSpeed, 
                    string wash1AmountOfSupernatantRemoved, 
                    string wash2AmountOfBufferTransferredIntoBag, 
                    string wash2CentrifugeID, 
                    string wash2CentrifugationTime, 
                    string wash2CentrifugationSpeed, 
                    string wash2AmountOfSupernatantRemoved, 
                    string weightOfBagAfterWashing, 
                    string volumeAdjustmentIsNormal, 
                    string removeProductSampleForAnalysis, 
                    string weightOfCellPreparationBagAfterBufferAddition, 
                    string cliniMACSSeparationDateStarted, 
                    string cliniMACSSeparationTimeStarted, 
                    string cliniMACSSeparationDateEnded, 
                    string cliniMACSSeparationTimeEnded, 
                    string tubingSetReagentID, 
                    string weightOfCellCollectionBagAfterRun, 
                    string weightOfEmptyCellCollectionBag, 
                    string processCode, 
                    string hPCNotApplicable, 
                    string hPCTotalVolume, 
                    string hPCNucleatedCellCount, 
                    string hPCPercentCD34Positive, 
                    string hPCPercentCD3Positive, 
                    string hPCCD34Viability, 
                    string t_CellNotApplicable, 
                    string t_CellAliquotID, 
                    string t_CellTotalVolume, 
                    string t_CellNucleatedCellCount, 
                    string t_CellPercentCD34Positive, 
                    string t_CellPercentCD3Positive, 
                    string pre_SpinNotApplicable, 
                    string pre_SpinTotalVolume, 
                    string pre_SpinNucleatedCellCount, 
                    string pre_SpinPercentCD34Positive, 
                    string pre_SpinPercentCD3Positive, 
                    string post_SpinNotApplicable, 
                    string post_SpinAliquotID, 
                    string post_SpinGrossWeight, 
                    string post_SpinCentrifugeID, 
                    string post_SpinRPMs, 
                    string post_SpinCentrifugeTemperature, 
                    string post_SpinGrossWt, 
                    string post_SpinBagWt, 
                    string post_SpinNucleatedCellCount, 
                    string post_SpinPercentCD34Positive, 
                    string post_SpinPercentCD3Positive, 
                    string post_SpinPercentRecovery, 
                    string hPCBeforePrepTotalVolume, 
                    string hPCBeforePrepNucleatedCellCount, 
                    string hPCBeforePrepPercentCD34Positve, 
                    string hPCBeforePrepPercentCD3Positive, 
                    string hPCBeforePrepCD34Viability, 
                    string hPCAfterPrepTotalVolume, 
                    string hPCAfterPrepNucleatedCellCount, 
                    string hPCAfterPrepPercentCD34Positve, 
                    string hPCAfterPrepPercentCD3Positive, 
                    string hPCAfterPrepCD34Viability, 
                    string cD34PositiveFractionAliquotID, 
                    string cD34PositiveFractionTotalVolume, 
                    string cD34PositiveFractionNucleatedCellCount, 
                    string cD34PositiveFractionPercentCD34Positve, 
                    string cD34PositiveFractionPercentCD3Positive, 
                    string cD34PositiveFractionCD34Viability, 
                    string cD34NegativeFractionTotalVolume, 
                    string cD34NegativeFractionNucleatedCellCount, 
                    string cD34NegativeFractionPercentCD34Positve, 
                    string cD34NegativeFractionPercentCD3Positive, 
                    string cD34NegativeFractionCD34Viability, 
                    string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "mytag"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User System Flow", @__tags);
#line 4
this.ScenarioSetup(scenarioInfo);
#line 5
 testRunner.Given("I navigate to TranstemLab application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
 testRunner.Then("I should be navigated to TranstemLab home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 7
 testRunner.Then("I click on Recipients Link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 8
 testRunner.Then("I click on Add Recipient button from Recipient Search Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 9
 testRunner.Then(string.Format("I enter {0} {1} {2} {3} {4} {5} {6} Gender Ethnicity and Client Status in the pag" +
                        "e", recipientID, firstName, lastName, medicalRecord, cRID, registryID, birthDate), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 10
 testRunner.Then("I click on Save button from page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 11
 testRunner.And("I Click on Add a transplant event for patient from RecipientDetail page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.Then("I enter value for all fields in Add Transplant Event page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 13
 testRunner.Then("I click on Save button form Add Tranplant Event Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 14
 testRunner.And("I record recipient information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.Then("go to home page from Recipient page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 16
 testRunner.And("I start to do a Donor search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.Then("I enter donor information and select that Donor", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 18
 testRunner.And("I start to Add collection", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.Then("I click on Add collection Event link from the Donor Detail page and fill out the " +
                    "required fields", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 20
 testRunner.Then("I click on Save button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
 testRunner.And("I record the system generated donor ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.Then("I Start to Add a Product from Donor home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
 testRunner.Then("I click on the Product link to add a new product", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 24
 testRunner.And("I select radio button to enter system generated donor ID and enter the ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.And("I click on the Load Donor ID and check the patient information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.Then("I click on the sync button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 27
 testRunner.And("I click on the radio button to select donor and press enter key in the keyboard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.Then("I click on Create Collection Event button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 29
 testRunner.And("I note down the Product ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.And("I click on the Create Product", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.Then("go to home page from Add New Product page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 32
 testRunner.And("I start to do a Recipient search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.And("I enter Recipient Last Name", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.Then("I click on Search button on the Recipient Search page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 35
 testRunner.And("I verify the recipient information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.And("I edit the transplant event to add product", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.Then("go to home page from Recipient page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 38
 testRunner.Then("I click on Product Link and select Batch Processing to Search page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 39
    testRunner.And("I click on Add Batch button to Add Batch page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
    testRunner.And("I select Cell Processing v1 20111 from the drop down list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
    testRunner.And("I click on Search button in the Add Batch page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.Then("I select the Product ID that was created", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 43
 testRunner.And("I click on the check box of the newly created product", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
 testRunner.Then("I select a Technologist from Technologist Name drop down", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 45
 testRunner.And("I click on Save button to save the Processing Procedure", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
 testRunner.Then("I click on Product List and navigate to Processing page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 47
 testRunner.And("I get the product ID from product home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
    testRunner.Then("I click on the parent title arrow", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 49
 testRunner.And("I verify the patient is in the drop down list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
 testRunner.Then("I click on Storage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 51
 testRunner.Then("I click on Unit Storage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 52
 testRunner.Then("I fill out the unit storage information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 53
 testRunner.Then("I click Save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 54
 testRunner.And("I verify that the storage action saves", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
 testRunner.Then("I click on Storage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 56
 testRunner.Then("I click on Sample Storage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 57
 testRunner.Then("I fill out the sample storage information", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 58
 testRunner.Then("I click on Create Sample", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 59
 testRunner.Then("I click on Storage", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 60
 testRunner.Then("I click on Folder Tracking", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 61
 testRunner.Then("I fill out details in Folder Tracking", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 62
 testRunner.Then("I click Save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 63
 testRunner.Then("I click on Processing", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 64
 testRunner.Then("I click on Processing Step 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 65
 testRunner.And(string.Format("I fill in {0}, {1}, {2} and {3} to First Processing Step", productGrossWeight, bagTareWeight, totalVolume, nucleatedCellCountPP), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
 testRunner.And("I verify the information in the First processing Step and sign in as Tech", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
 testRunner.Then("I click Save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 68
 testRunner.Then("I click on Processing Step two", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 69
 testRunner.And(string.Format("I fill in {0}, {1}, {2} and {3} to Second Processing Step", totalVolume, nucleatedCellCount, cD34, cD3), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
 testRunner.And("I verify the information in the Second processing Step and sign in as Tech", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
 testRunner.Then("I click on Label Verification to open Label Verification page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 72
 testRunner.And("I fill in the details in the Label Verification page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
 testRunner.Then("I sign all three signatures in Label Verification page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 74
 testRunner.Then("I click Save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 75
 testRunner.And("I click on RBC Depletion tab on the side", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
 testRunner.Then("I click on HES-1 to open HES-1 page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 77
 testRunner.And(string.Format("I fill in {0} {1} {2} {3} and verify {4} in the first section", totalVolume, nucleatedCellCount, hCT, rBCVolume, totalNucleatedCells), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
 testRunner.And("I fill in details in third section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
 testRunner.And(string.Format("I fill in {0} and verify {1} in the third section", totalVolume, hetastarch), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
 testRunner.And(string.Format("I fill in {0} {1} and {2}  in the fourth section and verify the total volume", plasmalyte, totalVolume, hetastarch), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
 testRunner.And(string.Format("I fill in {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13" +
                        "} and {14} to the table in the fifth section", preHES_1SedimentationVolume, preHES_1SedimentationNC, preHES_1SedimentationTNC, preHES_1SedimentationHCT, preHES_1SedimentationRBC, postHES_1SedimentationVolume, postHES_1SedimentationNC, postHES_1SedimentationTNC, postHES_1SedimentationHCT, postHES_1SedimentationRBC, postHES_1RemovalVolume, postHES_1RemovalNC, postHES_1RemovalTNC, postHES_1RemovalHCT, postHES_1RemovalRBC), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
 testRunner.And(string.Format("I verify the table in the fifth section with {0}, {1}, {2}, {3}, {4}, {5}, {6} an" +
                        "d {7}", totalVolume, nucleatedCellCount, totalNucleatedCells, hCT, rBCVolume, preHES_1SedimentationTNCRecovery, postHES_1SedimentationTNCRecovery, postHES_1RemovalTNCRecovery), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
 testRunner.Then("I click Save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 84
 testRunner.And("I click on Cryopreservation tab on the side", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 85
 testRunner.Then("I fill in the details in Cryopreservation page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 86
 testRunner.Then("I sign all two signatures in Cryopreservation page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 87
 testRunner.Then("I click Save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 88
 testRunner.And("I click on Receipt tab on the side", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
 testRunner.Then("I click on Receipt Details tab to open Receipt Details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 90
 testRunner.And("I fill in the details in the Receipt Details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
 testRunner.Then("I click Save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 92
 testRunner.Then("I click on Label Review tab to open Label Review page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 93
 testRunner.And("I fill in the details in the Label Review page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.Then("I click Save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 95
 testRunner.Then("I click on Other Facility to Open Other Facility page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 96
 testRunner.And("I fill the details in the Other Facility page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
 testRunner.And("I click on Reviewer 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 98
 testRunner.Then("I sign in with credential", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 99
 testRunner.And("I click done on Other Facility page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 100
 testRunner.Then("I click Save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 101
 testRunner.Then("I click on Processing Review tab to open Processing Review page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 102
 testRunner.And("I sign the Processing Review #1 in the Processing Review page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 103
 testRunner.Then("I click Save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 104
 testRunner.Then("I click on ABO/Rh Check tab to open ABO/Rh Check page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 105
 testRunner.And("I fill in the details in the ABO/Rh Check page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 106
 testRunner.And("I click on Reviewer check mark to sign", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 107
 testRunner.Then("I sign in with credential", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 108
 testRunner.And("I click done on ABO/Rh Check page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 109
 testRunner.Then("I click Save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 110
 testRunner.Then("I click on the Sampling to open Sampling page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 111
 testRunner.And("I fill in the details in the Sampling page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 112
 testRunner.Then("I click Save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 113
 testRunner.Then("I navigate to CD34+ Section A", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 114
 testRunner.And(string.Format("I fill in Transfer of Leukapheresis Product into Cell Preparation Bag section wit" +
                        "h {0}, {1}, {2}, {3}, {4}, {5}", leukapheresisTransferIntoCellBagStartTime, removeSampleForTesting, weightOfBagWithLeukapheresis, weightOfEmptyBag, a4ReducedNA, weightOfLeukapheresisAfterReduction), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 115
 testRunner.And(string.Format("I fill in Diluting Leukapheresis Product section with {0}, {1}", actualDilutionBufferAdded, bagWeightAfterAddingDilutionBuffer), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 116
 testRunner.And(string.Format("I fill in Centrifugation Conditions with {0}, {1}, {2}, {3}", centrifugeID, centrifugationTime, centrifugationSpeed, targetFinalVolumeIs95G), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 117
 testRunner.And(string.Format("I fill in Calculate the Amount of Supernatant to be Removed to give a Final Volum" +
                        "e section with {0}, {1}", actualAmountOfSupernatantRemoved, totalWeightOfBagAfterCompleteDilution), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 118
 testRunner.Then(string.Format("I verify Section A using {0}, {1}, {2}, {3}", weightOfBagWithLeukapheresis, weightOfEmptyBag, weightOfLeukapheresisAfterReduction, bagWeightAfterAddingDilutionBuffer), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 119
 testRunner.Then("I navigate to CD34+ Section B", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 120
 testRunner.And(string.Format("I fill in Magnetic Labeling of CD34 Positive Cells with {0}, {1}", cD34ReagentID, secondCD34ReagentID), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 121
 testRunner.And(string.Format("I fill in Incubation with {0}, {1}, {2}, {3}, {4}", incubationStartTime, airInjection, placedOnRotator, rotatorComment, incubationStopTime), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 122
 testRunner.And(string.Format("I fill in Wash Number One with {0}, {1}, {2}, {3}, {4}", wash1AmountOfBufferTransferredIntoBag, wash1CentrifugeID, wash1CentrifugationTime, wash1CentrifugationSpeed, wash1AmountOfSupernatantRemoved), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 123
 testRunner.And(string.Format("I fill in Wash Number Two with {0}, {1}, {2}, {3}, {4}, {5}", wash2AmountOfBufferTransferredIntoBag, wash2CentrifugeID, wash2CentrifugationTime, wash2CentrifugationSpeed, wash2AmountOfSupernatantRemoved, weightOfBagAfterWashing), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 124
 testRunner.And(string.Format("I fill in Final Sample Preparation with {0}, {1}, {2}", volumeAdjustmentIsNormal, removeProductSampleForAnalysis, weightOfCellPreparationBagAfterBufferAddition), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 125
 testRunner.And(string.Format("I verify Section B using {0}", weightOfEmptyBag), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 126
 testRunner.Then("I navigate to CD34+ Section C", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 127
 testRunner.And(string.Format("I fill in CliniMACS Separation (Run) with {0}, {1}, {2}, {3}, {4}", cliniMACSSeparationDateStarted, cliniMACSSeparationTimeStarted, cliniMACSSeparationDateEnded, cliniMACSSeparationTimeEnded, tubingSetReagentID), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 128
 testRunner.And(string.Format("I fill in Calculate the Amount of Positive Fraction with {0}, {1}, {2}", weightOfCellCollectionBagAfterRun, weightOfEmptyCellCollectionBag, processCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 129
 testRunner.And("I verify Section C", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 130
 testRunner.Then("I navigate to Data Analysis Unselected Processing", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 131
 testRunner.And(string.Format("I fill in HPC Product Aliquot for Unselected Processing with {0}, {1}, {2}, {3}, " +
                        "{4}, {5}", hPCNotApplicable, hPCTotalVolume, hPCNucleatedCellCount, hPCPercentCD34Positive, hPCPercentCD3Positive, hPCCD34Viability), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 132
 testRunner.And(string.Format("I fill in T-Cell Aliquot with {0}, {1}, {2}, {3}, {4}, {5}", t_CellNotApplicable, t_CellAliquotID, t_CellTotalVolume, t_CellNucleatedCellCount, t_CellPercentCD34Positive, t_CellPercentCD3Positive), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 133
 testRunner.And(string.Format("I fill in Pre-Spin (After Removal of T-Cell Aliquots) with {0}, {1}, {2}, {3}, {4" +
                        "}", pre_SpinNotApplicable, pre_SpinTotalVolume, pre_SpinNucleatedCellCount, pre_SpinPercentCD34Positive, pre_SpinPercentCD3Positive), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 134
 testRunner.And(string.Format("I fill in Post-Spin with {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, " +
                        "{11}", post_SpinNotApplicable, post_SpinAliquotID, post_SpinGrossWeight, post_SpinCentrifugeID, post_SpinRPMs, post_SpinCentrifugeTemperature, post_SpinGrossWt, post_SpinBagWt, post_SpinNucleatedCellCount, post_SpinPercentCD34Positive, post_SpinPercentCD3Positive, post_SpinPercentRecovery), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 135
 testRunner.And("I verify Data Analysis Unselected Processing", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 136
 testRunner.Then("I navigate to Data Analysis CD34 Selection", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 137
 testRunner.And(string.Format("I fill in HPC Product Aliquot for CD34 Selection (Before Prep/Magnetic Labeling) " +
                        "with {0}, {1}, {2}, {3}, {4}", hPCBeforePrepTotalVolume, hPCBeforePrepNucleatedCellCount, hPCBeforePrepPercentCD34Positve, hPCBeforePrepPercentCD3Positive, hPCBeforePrepCD34Viability), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 138
 testRunner.And(string.Format("I fill in HPC Product Aliquot for CD34 Selection (After Prep/Magnetic Labeling) w" +
                        "ith {0}, {1}, {2}, {3}, {4}", hPCAfterPrepTotalVolume, hPCAfterPrepNucleatedCellCount, hPCAfterPrepPercentCD34Positve, hPCAfterPrepPercentCD3Positive, hPCAfterPrepCD34Viability), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 139
 testRunner.And(string.Format("I fill in CD34 Selected Positive Fraction (Cell Collection Bag) with {0}, {1}, {2" +
                        "}, {3}, {4}, {5}", cD34PositiveFractionAliquotID, cD34PositiveFractionTotalVolume, cD34PositiveFractionNucleatedCellCount, cD34PositiveFractionPercentCD34Positve, cD34PositiveFractionPercentCD3Positive, cD34PositiveFractionCD34Viability), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 140
 testRunner.And(string.Format("I fill in CD34 Selected Negative Fraction (Negative Fraction Bag) with {0}, {1}, " +
                        "{2}, {3}, {4}", cD34NegativeFractionTotalVolume, cD34NegativeFractionNucleatedCellCount, cD34NegativeFractionPercentCD34Positve, cD34NegativeFractionPercentCD3Positive, cD34NegativeFractionCD34Viability), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 141
 testRunner.And("I verify the calculations in Data Analysis CD34 Selection", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 142
 testRunner.Then("I click LogOutLink", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 143
 testRunner.And("I should be navigated to TranstemLab login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 144
 testRunner.And("I Log Out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion