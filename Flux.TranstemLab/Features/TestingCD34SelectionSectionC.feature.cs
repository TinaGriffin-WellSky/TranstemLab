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
    [NUnit.Framework.DescriptionAttribute("TestingCD34SelectionSectionC")]
    public partial class TestingCD34SelectionSectionCFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "TestingCD34SelectionSectionC.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "TestingCD34SelectionSectionC", "\tIn order to ensure methods and steps are working properly while saving time\r\n\tAs" +
                    " an SQA intern\r\n\tI want to run a test with steps only for CD34 Selection - Secti" +
                    "on C", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Section C")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        [NUnit.Framework.TestCaseAttribute("6/2/15", "15:19", "6/2/15", "16:04", "2304", "104", "22.0", "M60F0004S4002N1", null)]
        public virtual void SectionC(string cliniMACSSeparationDateStarted, string cliniMACSSeparationTimeStarted, string cliniMACSSeparationDateEnded, string cliniMACSSeparationTimeEnded, string tubingSetReagentID, string weightOfCellCollectionBagAfterRun, string weightOfEmptyCellCollectionBag, string processCode, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "mytag"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Section C", @__tags);
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
 testRunner.Then("I navigate to CD34+ Section C", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
 testRunner.And(string.Format("I fill in CliniMACS Separation (Run) with {0}, {1}, {2}, {3}, {4}", cliniMACSSeparationDateStarted, cliniMACSSeparationTimeStarted, cliniMACSSeparationDateEnded, cliniMACSSeparationTimeEnded, tubingSetReagentID), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.And(string.Format("I fill in Calculate the Amount of Positive Fraction with {0}, {1}, {2}", weightOfCellCollectionBagAfterRun, weightOfEmptyCellCollectionBag, processCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
 testRunner.And("I verify Section C", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
