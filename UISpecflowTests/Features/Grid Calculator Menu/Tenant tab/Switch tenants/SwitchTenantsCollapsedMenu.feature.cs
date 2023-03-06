﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace UISpecflowTests.Features.GridCalculatorMenu.TenantTab.SwitchTenants
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("SwitchTenantsCollapsedMenu")]
    [NUnit.Framework.CategoryAttribute("TenantTabTests")]
    public partial class SwitchTenantsCollapsedMenuFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = new string[] {
                "TenantTabTests"};
        
#line 1 "SwitchTenantsCollapsedMenu.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/Grid Calculator Menu/Tenant tab/Switch tenants", "SwitchTenantsCollapsedMenu", "A short summary of the feature", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify that after opening the Grid Calculator application, the first tenant from " +
            "the tenant\'s list is checked and the power grid objects display on the map")]
        [NUnit.Framework.CategoryAttribute("regression")]
        public void VerifyThatAfterOpeningTheGridCalculatorApplicationTheFirstTenantFromTheTenantsListIsCheckedAndThePowerGridObjectsDisplayOnTheMap()
        {
            string[] tagsOfScenario = new string[] {
                    "regression"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify that after opening the Grid Calculator application, the first tenant from " +
                    "the tenant\'s list is checked and the power grid objects display on the map", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 7
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 8
 testRunner.Given("I navigate to GC application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 9
 testRunner.When("I Open the Grid Calculator application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 10
 testRunner.Then("The page displays the messages \"Authenticating\" and/or \"Loading map configuration" +
                        "\" for a few seconds, then the Grid Calculator application is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 11
 testRunner.When("I click the tenant icon in the menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 12
 testRunner.Then("The tooltip with the list of available organizations and tenants with a checked a" +
                        "ctive tenant \"nsa_dev\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 13
 testRunner.When("I verify that the first tenant from the list \"nsa_dev\" is checked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 14
 testRunner.Then("The first tenant from the list \"nsa_dev\" is checked", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 15
 testRunner.When("I verify that the power grid objects display on the map", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 16
 testRunner.Then("The power grid objects are displayed on the map", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Switch the tenant to the second from the list")]
        [NUnit.Framework.CategoryAttribute("regression")]
        public void SwitchTheTenantToTheSecondFromTheList()
        {
            string[] tagsOfScenario = new string[] {
                    "regression"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Switch the tenant to the second from the list", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 19
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 20
 testRunner.Given("I navigate to GC application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 21
 testRunner.When("I Open the Grid Calculator application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 22
 testRunner.Then("The page displays the messages \"Authenticating\" and/or \"Loading map configuration" +
                        "\" for a few seconds, then the Grid Calculator application is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 23
 testRunner.Given("Second tenant - collapsed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 24
 testRunner.When("I click the tenant icon in the menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 25
 testRunner.Then("The tooltip with the list of available organizations and tenants with a checked a" +
                        "ctive tenant \"nsa_dev\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 26
 testRunner.When("I Hover over the second tenant from the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 27
 testRunner.Then("The hovering over tenant is highlighted in green", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 28
 testRunner.When("I click the second tenant \"Grid Calculator Demo\" from the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 29
 testRunner.Then("The page may display the message \"Loading map configuration\" for a few seconds,", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 30
 testRunner.And("The Grid Calculator application is displayed but without power grid objects on th" +
                        "e map", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 31
 testRunner.When("I click the tenant icon in the menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 32
 testRunner.Then("The tooltip with the list of available organizations and tenants with a checked a" +
                        "ctive tenant \"Grid Calculator Demo\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Switch the tenant to the second from the list and then to the first from the list" +
            " again")]
        [NUnit.Framework.CategoryAttribute("regression")]
        public void SwitchTheTenantToTheSecondFromTheListAndThenToTheFirstFromTheListAgain()
        {
            string[] tagsOfScenario = new string[] {
                    "regression"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Switch the tenant to the second from the list and then to the first from the list" +
                    " again", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 35
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 36
 testRunner.Given("I navigate to GC application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 37
 testRunner.When("I Open the Grid Calculator application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 38
 testRunner.Then("The page displays the messages \"Authenticating\" and/or \"Loading map configuration" +
                        "\" for a few seconds, then the Grid Calculator application is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 39
 testRunner.Given("Second tenant - collapsed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 40
 testRunner.When("I click the tenant icon in the menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 41
 testRunner.Then("The tooltip with the list of available organizations and tenants with a checked a" +
                        "ctive tenant \"nsa_dev\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 42
 testRunner.When("I Hover over the second tenant from the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 43
 testRunner.Then("The hovering over tenant is highlighted in green", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 44
 testRunner.When("I click the second tenant \"Grid Calculator Demo\" from the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 45
 testRunner.Then("The page may display the message \"Loading map configuration\" for a few seconds,", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 46
 testRunner.And("The Grid Calculator application is displayed but without power grid objects on th" +
                        "e map", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 47
 testRunner.When("I click the tenant icon in the menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 48
 testRunner.Then("The tooltip with the list of available organizations and tenants with a checked a" +
                        "ctive tenant \"Grid Calculator Demo\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 49
 testRunner.When("I Hover over the first tenant from the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 50
 testRunner.Then("The hovering over tenant is highlighted in green", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 51
 testRunner.When("I click the first tenant \"nsa_dev\" from the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 52
 testRunner.Then("The page displays the messages \"Authenticating\" and/or \"Loading map configuration" +
                        "\" for a few seconds, then the Grid Calculator application is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 53
 testRunner.When("I click the tenant icon in the menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 54
 testRunner.Then("The tooltip with the list of available organizations and tenants with a checked a" +
                        "ctive tenant \"nsa_dev\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Switch the tenant to the second from the list after clicking on one of the power " +
            "grid object on the map and displaying the Select asset pop-up window")]
        [NUnit.Framework.CategoryAttribute("regression")]
        public void SwitchTheTenantToTheSecondFromTheListAfterClickingOnOneOfThePowerGridObjectOnTheMapAndDisplayingTheSelectAssetPop_UpWindow()
        {
            string[] tagsOfScenario = new string[] {
                    "regression"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Switch the tenant to the second from the list after clicking on one of the power " +
                    "grid object on the map and displaying the Select asset pop-up window", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 57
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 58
 testRunner.Given("I navigate to GC application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 59
 testRunner.When("I Open the Grid Calculator application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 60
 testRunner.Then("The page displays the messages \"Authenticating\" and/or \"Loading map configuration" +
                        "\" for a few seconds, then the Grid Calculator application is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 61
 testRunner.Given("Click one of the power grid objects - collapsed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 62
 testRunner.When("I click one of the power grid objects", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 63
 testRunner.Then("The \"Searching for assets\" is displayed for a few seconds, then the \"Select asset" +
                        "\" pop-up window is displayed in the upper left corner of page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 64
 testRunner.Given("Second tenant - collapsed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 65
 testRunner.When("I click the tenant icon in the menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 66
 testRunner.Then("The tooltip with the list of available organizations and tenants with a checked a" +
                        "ctive tenant \"nsa_dev\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 67
 testRunner.When("I Hover over the second tenant from the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 68
 testRunner.Then("The hovering over tenant is highlighted in green", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 69
 testRunner.When("I click the second tenant \"Grid Calculator Demo\" from the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 70
 testRunner.Then("The page may display the message \"Loading map configuration\" for a few seconds,", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 71
 testRunner.And("The Grid Calculator application is displayed but without power grid objects on th" +
                        "e map", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 72
 testRunner.When("I click the tenant icon in the menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 73
 testRunner.Then("The tooltip with the list of available organizations and tenants with a checked a" +
                        "ctive tenant \"Grid Calculator Demo\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Switch the tenant to the second from the list after selecting one of the power gr" +
            "id objects and displaying the pop-up window with information about it")]
        [NUnit.Framework.CategoryAttribute("regression")]
        public void SwitchTheTenantToTheSecondFromTheListAfterSelectingOneOfThePowerGridObjectsAndDisplayingThePop_UpWindowWithInformationAboutIt()
        {
            string[] tagsOfScenario = new string[] {
                    "regression"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Switch the tenant to the second from the list after selecting one of the power gr" +
                    "id objects and displaying the pop-up window with information about it", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 76
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 77
 testRunner.Given("I navigate to GC application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 78
 testRunner.When("I Open the Grid Calculator application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 79
 testRunner.Then("The page displays the messages \"Authenticating\" and/or \"Loading map configuration" +
                        "\" for a few seconds, then the Grid Calculator application is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 80
 testRunner.Given("Click one of the power grid objects - collapsed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 81
 testRunner.When("I click one of the power grid objects", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 82
 testRunner.Then("The \"Searching for assets\" is displayed for a few seconds, then the \"Select asset" +
                        "\" pop-up window is displayed in the upper left corner of page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 83
 testRunner.Given("Select one of the power object - collapsed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 84
 testRunner.When("I Select one of the power grid objects from the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 85
    testRunner.Then("The selected power grid object information is displayed in the pop-up window", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 86
 testRunner.Given("Second tenant - collapsed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 87
 testRunner.When("I click the tenant icon in the menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 88
 testRunner.Then("The tooltip with the list of available organizations and tenants with a checked a" +
                        "ctive tenant \"nsa_dev\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 89
 testRunner.When("I Hover over the second tenant from the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 90
 testRunner.Then("The hovering over tenant is highlighted in green", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 91
 testRunner.When("I click the second tenant \"Grid Calculator Demo\" from the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 92
 testRunner.Then("The page may display the message \"Loading map configuration\" for a few seconds,", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 93
 testRunner.And("The Grid Calculator application is displayed but without power grid objects on th" +
                        "e map", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 94
 testRunner.When("I click the tenant icon in the menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 95
 testRunner.Then("The tooltip with the list of available organizations and tenants with a checked a" +
                        "ctive tenant \"Grid Calculator Demo\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Switch the tenant to the second from the list after selecting one of the PowerTra" +
            "nsformers that has the required data for the calculation and displaying the pop-" +
            "up window with information about it and running calculation")]
        [NUnit.Framework.CategoryAttribute("regression")]
        public void SwitchTheTenantToTheSecondFromTheListAfterSelectingOneOfThePowerTransformersThatHasTheRequiredDataForTheCalculationAndDisplayingThePop_UpWindowWithInformationAboutItAndRunningCalculation()
        {
            string[] tagsOfScenario = new string[] {
                    "regression"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Switch the tenant to the second from the list after selecting one of the PowerTra" +
                    "nsformers that has the required data for the calculation and displaying the pop-" +
                    "up window with information about it and running calculation", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 98
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 99
 testRunner.Given("I navigate to GC application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 100
 testRunner.When("I Open the Grid Calculator application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 101
 testRunner.Then("The page displays the messages \"Authenticating\" and/or \"Loading map configuration" +
                        "\" for a few seconds, then the Grid Calculator application is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 103
 testRunner.Given("Find and zoom power transformer on map", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table9.AddRow(new string[] {
                            "1",
                            "Ringgata 70, Hamar, Norway"});
                table9.AddRow(new string[] {
                            "2",
                            "Vangsvegen 143, Hamar, Norway"});
                table9.AddRow(new string[] {
                            "3",
                            "Brugata 41, Hamar, Norway"});
#line 104
 testRunner.When("I find on the map the place where right PowerTransformers that has the required d" +
                        "ata for the calculation is located", ((string)(null)), table9, "When ");
#line hidden
#line 109
 testRunner.Then("The power transformers is found", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 110
 testRunner.When("I Zoom in on the area where the PowerTransformer that has the required data for c" +
                        "alculation is located", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 112
 testRunner.Then("The area is zoomed in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 113
 testRunner.Given("Calculation for one of the PowerTransformers", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 114
 testRunner.When("I click on the dot in the center of the substation that is the power transformer " +
                        "that has the required data for the calculation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table10.AddRow(new string[] {
                            "1",
                            "ENS00383 TRF T1 TRAFO"});
                table10.AddRow(new string[] {
                            "2",
                            "ENS04633 TRF T1 TRAFO"});
                table10.AddRow(new string[] {
                            "3",
                            "ENS09636 TRF T1 TRAFO"});
#line 115
 testRunner.And("Have one of the names", ((string)(null)), table10, "And ");
#line hidden
#line 120
 testRunner.And("Have Asset Group \"Asset Group: Medium voltage 2 winding power transformer\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 121
    testRunner.Then("Then The \"Searching for assets\" is displayed for a few seconds, then the \"Select " +
                        "asset\" pop-up window is displayed in the upper left corner of page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 122
 testRunner.When("I Select the electric network device", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 123
 testRunner.And("I Select the \"Medium voltage 2 winding power transformer\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 124
 testRunner.Then("The power transformer that has the required data for the calculation is displayed" +
                        " in the pop-up window", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 125
 testRunner.When("I click on the green Run Tactic button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 126
 testRunner.Then("The green Run Tactic button is changed to the gray Running tactic button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 127
 testRunner.When("I wait until the gray Running tactic button is changed to the green Run Tactic bu" +
                        "tton", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 128
 testRunner.Then("The pop-up window is extended with the Result of Tactic list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 129
 testRunner.And("Subnetwork is highlighted in turquoise", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 130
 testRunner.And("Red Energy Consumers points for which the calculation results do not follow the r" +
                        "ules of Tactic are displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 131
 testRunner.And("Orange Energy Consumers points for which the calculation results almost do not fo" +
                        "llow the rules of Tactic by warning are displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 132
 testRunner.And("Green Energy Consumers points for which the calculation results follow the rules " +
                        "of Tactic are displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 133
 testRunner.Given("Second tenant - collapsed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 134
 testRunner.When("I click the tenant icon in the menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 135
 testRunner.Then("The tooltip with the list of available organizations and tenants with a checked a" +
                        "ctive tenant \"nsa_dev\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 136
 testRunner.When("I Hover over the second tenant from the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 137
 testRunner.Then("The hovering over tenant is highlighted in green", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 138
 testRunner.When("I click the second tenant \"Grid Calculator Demo\" from the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 139
 testRunner.Then("The page may display the message \"Loading map configuration\" for a few seconds,", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 140
 testRunner.And("The Grid Calculator application is displayed but without power grid objects on th" +
                        "e map", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 141
 testRunner.When("I click the tenant icon in the menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 142
 testRunner.Then("The tooltip with the list of available organizations and tenants with a checked a" +
                        "ctive tenant \"Grid Calculator Demo\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Switch the tenant to the second from the list after changing the zoom and positio" +
            "n")]
        [NUnit.Framework.CategoryAttribute("regression")]
        public void SwitchTheTenantToTheSecondFromTheListAfterChangingTheZoomAndPosition()
        {
            string[] tagsOfScenario = new string[] {
                    "regression"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Switch the tenant to the second from the list after changing the zoom and positio" +
                    "n", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 145
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 146
 testRunner.Given("I navigate to GC application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 147
 testRunner.When("I Open the Grid Calculator application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 148
 testRunner.Then("The page displays the messages \"Authenticating\" and/or \"Loading map configuration" +
                        "\" for a few seconds, then the Grid Calculator application is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 149
 testRunner.When("I zoom in and out on the area on map using plus and minus buttons located in the " +
                        "lower right corner of page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 151
 testRunner.Then("The area is zoomed in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 152
 testRunner.When("I change position on the map using gesture on map", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 154
 testRunner.Then("The position of area is changed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 155
 testRunner.Given("Second tenant - collapsed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 156
 testRunner.When("I click the tenant icon in the menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 157
 testRunner.Then("The tooltip with the list of available organizations and tenants with a checked a" +
                        "ctive tenant \"nsa_dev\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 158
 testRunner.When("I Hover over the second tenant from the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 159
 testRunner.Then("The hovering over tenant is highlighted in green", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 160
 testRunner.When("I click the second tenant \"Grid Calculator Demo\" from the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 161
 testRunner.Then("The page may display the message \"Loading map configuration\" for a few seconds,", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 162
 testRunner.And("The Grid Calculator application is displayed but without power grid objects on th" +
                        "e map", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 163
 testRunner.When("I click the tenant icon in the menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 164
 testRunner.Then("The tooltip with the list of available organizations and tenants with a checked a" +
                        "ctive tenant \"Grid Calculator Demo\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
