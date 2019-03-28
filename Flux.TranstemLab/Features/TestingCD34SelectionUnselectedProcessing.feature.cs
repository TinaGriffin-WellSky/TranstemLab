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
    [NUnit.Framework.DescriptionAttribute("TestingCD34SelectionUnselectedProcessing")]
    public partial class TestingCD34SelectionUnselectedProcessingFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "TestingCD34SelectionUnselectedProcessing.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "TestingCD34SelectionUnselectedProcessing", "\tIn order to ensure methods and steps are working properly while saving time\r\n\tAs" +
                    " an SQA intern\r\n\tI want to run a test with steps only for CD34 Selection - Data " +
                    "Analysis Unselected Processing", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Data Analysis Unselected Processing")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        [NUnit.Framework.TestCaseAttribute("1", "", "", "", "", "", "1", "", "", "", "", "", "1", "", "", "", "", "1", "", "", "", "", "", "", "", "", "", "", "", null)]
        public virtual void DataAnalysisUnselectedProcessing(
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
                    string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "mytag"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Data Analysis Unselected Processing", @__tags);
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
    testRunner.Given("I navigate to TranstemLab application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
    testRunner.Then("I click on Product Link and select Batch Processing to Search page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 10
    testRunner.And("I click on Add Batch button to Add Batch page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
    testRunner.Then("I change the Date Range", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
    testRunner.And("I select Cell Processing v1 20111 from the drop down list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
    testRunner.And("I click on Search button in the Add Batch page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
    testRunner.Then("I select the first product in the table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 15
 testRunner.And("I click on the Set Batch button to navigate to Processing Procedure page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
    testRunner.Then("I select a Technologist from Technologist Name drop down", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
    testRunner.And("I click on Save button to save the Processing Procedure", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
    testRunner.Then("I click on Product List and navigate to Processing page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 19
 testRunner.Then("I click on the Title Arrow", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 20
 testRunner.Then("I navigate to Data Analysis Unselected Processing", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
 testRunner.And(string.Format("I fill in HPC Product Aliquot for Unselected Processing with {0}, {1}, {2}, {3}, " +
                        "{4}, {5}", hPCNotApplicable, hPCTotalVolume, hPCNucleatedCellCount, hPCPercentCD34Positive, hPCPercentCD3Positive, hPCCD34Viability), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.And(string.Format("I fill in T-Cell Aliquot with {0}, {1}, {2}, {3}, {4}, {5}", t_CellNotApplicable, t_CellAliquotID, t_CellTotalVolume, t_CellNucleatedCellCount, t_CellPercentCD34Positive, t_CellPercentCD3Positive), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
 testRunner.And(string.Format("I fill in Pre-Spin (After Removal of T-Cell Aliquots) with {0}, {1}, {2}, {3}, {4" +
                        "}", pre_SpinNotApplicable, pre_SpinTotalVolume, pre_SpinNucleatedCellCount, pre_SpinPercentCD34Positive, pre_SpinPercentCD3Positive), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.And(string.Format("I fill in Post-Spin with {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, " +
                        "{11}", post_SpinNotApplicable, post_SpinAliquotID, post_SpinGrossWeight, post_SpinCentrifugeID, post_SpinRPMs, post_SpinCentrifugeTemperature, post_SpinGrossWt, post_SpinBagWt, post_SpinNucleatedCellCount, post_SpinPercentCD34Positive, post_SpinPercentCD3Positive, post_SpinPercentRecovery), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.And("I verify Data Analysis Unselected Processing", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion