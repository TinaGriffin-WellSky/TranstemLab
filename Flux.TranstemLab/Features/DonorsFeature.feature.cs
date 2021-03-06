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
    [NUnit.Framework.DescriptionAttribute("Donors Test Cases")]
    public partial class DonorsTestCasesFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "DonorsFeature.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Donors Test Cases", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Create Collection Event From Donor Page for Existing Recepient")]
        public virtual void CreateCollectionEventFromDonorPageForExistingRecepient()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create Collection Event From Donor Page for Existing Recepient", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line 4
 testRunner.Given("I navigate to TranstemLab application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 5
 testRunner.Then("I click on Donors Link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 6
 testRunner.And("I click on search button from the Donor Search Page and I select an identifier", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 7
 testRunner.Then("I click on Add collection Event link from the Donor Detail page and fill out the " +
                    "required fields", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 8
 testRunner.Then("I click on Save button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 9
 testRunner.And("I click LogOutName", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.And("I should be navigated to TranstemLab login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create Birth Event From Donor Page for Existing Recepient")]
        [NUnit.Framework.TestCaseAttribute("Physi", "Lenexa", "Emma", null)]
        public virtual void CreateBirthEventFromDonorPageForExistingRecepient(string otherPhysician, string location, string otherReferralType, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create Birth Event From Donor Page for Existing Recepient", exampleTags);
#line 12
 this.ScenarioSetup(scenarioInfo);
#line 13
 testRunner.Given("I navigate to TranstemLab application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 14
 testRunner.Then("I click on Donors Link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 15
 testRunner.And("I click on search button from the Donor Search Page and I select an identifier", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.Then(string.Format("I click on Add Birth Event link from the Donor Detail page and fill out the requi" +
                        "red fields {0} {1} {2}", otherPhysician, location, otherReferralType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
 testRunner.And("I Click on Save button on Add Birth Event page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.And("I click on Documents for file upload for Donor page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.Then("I enter Values in Description as Testing & for Category & for File on Donor page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 20
 testRunner.Then("I click on Notes for making note for the RecipientID on the Donor page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
 testRunner.Then("I enter values for Category & for Note as Testing on the Donor page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 22
    testRunner.Then("I click on Save Button from the Note Page on the Donor page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
    testRunner.And("I click LogOutName", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
    testRunner.And("I should be navigated to TranstemLab login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create a New Donor")]
        [NUnit.Framework.TestCaseAttribute("FN", "LN", "MN", "MRN", "IID", "RID", "@mail.com", "", "", "", "", "Add", "", "City", "", "", "", "", null)]
        public virtual void CreateANewDonor(
                    string firstName, 
                    string lastName, 
                    string maidenName, 
                    string mRN, 
                    string internalDonorID, 
                    string registryID, 
                    string email, 
                    string birthDate, 
                    string weight, 
                    string height, 
                    string sSNLastFour, 
                    string address, 
                    string apartment, 
                    string city, 
                    string zipCode, 
                    string homePhone, 
                    string workPhone, 
                    string cellPhone, 
                    string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a New Donor", exampleTags);
#line 29
this.ScenarioSetup(scenarioInfo);
#line 30
    testRunner.Given("I navigate to TranstemLab application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 31
    testRunner.Then("I click on Donors Link to create a Donor", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 32
    testRunner.And("I click on Add donor button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.Then(string.Format("I enter donor personal information {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {" +
                        "9}, {10} in to the page", firstName, lastName, maidenName, mRN, internalDonorID, registryID, email, birthDate, weight, height, sSNLastFour), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 35
 testRunner.Then(string.Format("I enter donor demographic information {0}, {1}, {2}, {3}, {4}, {5} and {6} in to " +
                        "the page", address, apartment, city, zipCode, homePhone, workPhone, cellPhone), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 36
 testRunner.Then("I click on the Save Button from page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 37
 testRunner.And("I click LogOutName", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.And("I should be navigated to TranstemLab login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
