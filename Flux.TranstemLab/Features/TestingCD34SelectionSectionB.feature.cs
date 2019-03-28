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
    [NUnit.Framework.DescriptionAttribute("TestingCD34SelectionSectionB")]
    public partial class TestingCD34SelectionSectionBFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "TestingCD34SelectionSectionB.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "TestingCD34SelectionSectionB", "\tIn order to ensure methods and steps are working properly while saving time\r\n\tAs" +
                    " an SQA intern\r\n\tI want to run a test with steps only for CD34 Selection - Secti" +
                    "on B", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Section B")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        [NUnit.Framework.TestCaseAttribute("6150106017", "6150106017", "11:13", "1", "0", "1337", "11:43", "353", "123", "15", "838", "465", "462", "456", "15", "838", "457", "115", "0", "1", "309", null)]
        public virtual void SectionB(
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
                    string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "mytag"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Section B", @__tags);
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
 testRunner.Then("I navigate to CD34+ Section B", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
 testRunner.And(string.Format("I fill in Magnetic Labeling of CD34 Positive Cells with {0}, {1}", cD34ReagentID, secondCD34ReagentID), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.And(string.Format("I fill in Incubation with {0}, {1}, {2}, {3}, {4}", incubationStartTime, airInjection, placedOnRotator, rotatorComment, incubationStopTime), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
 testRunner.And(string.Format("I fill in Wash Number One with {0}, {1}, {2}, {3}, {4}", wash1AmountOfBufferTransferredIntoBag, wash1CentrifugeID, wash1CentrifugationTime, wash1CentrifugationSpeed, wash1AmountOfSupernatantRemoved), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.And(string.Format("I fill in Wash Number Two with {0}, {1}, {2}, {3}, {4}, {5}", wash2AmountOfBufferTransferredIntoBag, wash2CentrifugeID, wash2CentrifugationTime, wash2CentrifugationSpeed, wash2AmountOfSupernatantRemoved, weightOfBagAfterWashing), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.And(string.Format("I fill in Final Sample Preparation with {0}, {1}, {2}", volumeAdjustmentIsNormal, removeProductSampleForAnalysis, weightOfCellPreparationBagAfterBufferAddition), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.And("I verify Section B using <Weight of Empty Bag>", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion