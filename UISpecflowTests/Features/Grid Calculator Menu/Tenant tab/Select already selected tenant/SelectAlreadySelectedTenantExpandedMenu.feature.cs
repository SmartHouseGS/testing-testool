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
namespace UISpecflowTests.Features.GridCalculatorMenu.TenantTab.SelectAlreadySelectedTenant
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("SelectAlreadySelectedTenantExpandedMenu")]
    [NUnit.Framework.CategoryAttribute("TenantTabTests")]
    [NUnit.Framework.CategoryAttribute("ExpandedMenu")]
    public partial class SelectAlreadySelectedTenantExpandedMenuFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = new string[] {
                "TenantTabTests",
                "ExpandedMenu"};
        
#line 1 "SelectAlreadySelectedTenantExpandedMenu.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/Grid Calculator Menu/Tenant tab/Select already selected tenant", "SelectAlreadySelectedTenantExpandedMenu", "A short summary of the feature", ProgrammingLanguage.CSharp, featureTags);
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
        [NUnit.Framework.DescriptionAttribute("Select the tenant which is already selected")]
        [NUnit.Framework.CategoryAttribute("regression")]
        public void SelectTheTenantWhichIsAlreadySelected()
        {
            string[] tagsOfScenario = new string[] {
                    "regression"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Select the tenant which is already selected", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
 testRunner.Given("Sidebar drop-down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 12
 testRunner.When("I click the sidebar drop-down menu button at the bottom of the menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
 testRunner.Then("The menu is expanded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 14
 testRunner.When("I click the tenant tab in the menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 15
 testRunner.Then("The tooltip with the list of available organizations and tenants with a checked a" +
                        "ctive tenant \"nsa_dev\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 16
 testRunner.Given("Hover over selected tenant - expanded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 17
 testRunner.When("I hover over the selected tenant", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 18
 testRunner.Then("The hovering over tenant is highlighted in green", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 19
 testRunner.Given("Click selected tenant - expanded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 20
 testRunner.When("I click the selected tenant", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 21
 testRunner.Then("The page displays the messages \"Authenticating\" and/or \"Loading map configuration" +
                        "\" for a few seconds, then the Grid Calculator application is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 22
 testRunner.Given("Verify that tenant name is displayed - expanded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 23
 testRunner.When("I verify that the current \"nsa_dev\" tenant name is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 24
 testRunner.Then("The current tenant name \"nsa_dev\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Select the tenant which is already selected after clicking on one of the power gr" +
            "id object on the map and displaying the Select asset pop-up window")]
        [NUnit.Framework.CategoryAttribute("regression")]
        public void SelectTheTenantWhichIsAlreadySelectedAfterClickingOnOneOfThePowerGridObjectOnTheMapAndDisplayingTheSelectAssetPop_UpWindow()
        {
            string[] tagsOfScenario = new string[] {
                    "regression"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Select the tenant which is already selected after clicking on one of the power gr" +
                    "id object on the map and displaying the Select asset pop-up window", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 27
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 28
 testRunner.Given("I navigate to GC application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 29
 testRunner.When("I Open the Grid Calculator application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 30
 testRunner.Then("The page displays the messages \"Authenticating\" and/or \"Loading map configuration" +
                        "\" for a few seconds, then the Grid Calculator application is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 31
 testRunner.Given("Sidebar drop-down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 32
 testRunner.When("I click the sidebar drop-down menu button at the bottom of the menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 33
 testRunner.Then("The menu is expanded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 34
 testRunner.Given("Click one of the power grid objects - expanded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 35
 testRunner.When("I click one of the power grid objects", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 36
 testRunner.Then("The \"Searching for assets\" is displayed for a few seconds, then the \"Select asset" +
                        "\" pop-up window is displayed in the upper left corner of page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 37
 testRunner.When("I click the tenant tab in the menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 38
 testRunner.Then("The tooltip with the list of available organizations and tenants with a checked a" +
                        "ctive tenant \"nsa_dev\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 39
 testRunner.Given("Hover over selected tenant - expanded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 40
 testRunner.When("I hover over the selected tenant", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 41
 testRunner.Then("The hovering over tenant is highlighted in green", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 42
 testRunner.Given("Click selected tenant - expanded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 43
 testRunner.When("I click the selected tenant", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 44
 testRunner.Then("The page displays the messages \"Authenticating\" and/or \"Loading map configuration" +
                        "\" for a few seconds, then the Grid Calculator application is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 45
 testRunner.Given("Verify that tenant name is displayed - expanded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 46
 testRunner.When("I verify that the current \"nsa_dev\" tenant name is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 47
 testRunner.Then("The current tenant name \"nsa_dev\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Select the tenant which is already selected after selecting one of the power grid" +
            " objects and displaying the pop-up window with information about it")]
        [NUnit.Framework.CategoryAttribute("regression")]
        public void SelectTheTenantWhichIsAlreadySelectedAfterSelectingOneOfThePowerGridObjectsAndDisplayingThePop_UpWindowWithInformationAboutIt()
        {
            string[] tagsOfScenario = new string[] {
                    "regression"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Select the tenant which is already selected after selecting one of the power grid" +
                    " objects and displaying the pop-up window with information about it", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 50
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 51
 testRunner.Given("I navigate to GC application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 52
 testRunner.When("I Open the Grid Calculator application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 53
 testRunner.Then("The page displays the messages \"Authenticating\" and/or \"Loading map configuration" +
                        "\" for a few seconds, then the Grid Calculator application is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 54
 testRunner.Given("Sidebar drop-down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 55
 testRunner.When("I click the sidebar drop-down menu button at the bottom of the menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 56
 testRunner.Then("The menu is expanded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 57
 testRunner.Given("Click one of the power grid objects - expanded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 58
 testRunner.When("I click one of the power grid objects", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 59
 testRunner.Then("The \"Searching for assets\" is displayed for a few seconds, then the \"Select asset" +
                        "\" pop-up window is displayed in the upper left corner of page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 60
 testRunner.Given("Select one of the power object - expanded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 61
 testRunner.When("I Select one of the power grid objects from the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 62
    testRunner.Then("The selected power grid object information is displayed in the pop-up window", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 63
 testRunner.When("I click the tenant tab in the menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 64
 testRunner.Then("The tooltip with the list of available organizations and tenants with a checked a" +
                        "ctive tenant \"nsa_dev\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 65
 testRunner.Given("Hover over selected tenant - expanded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 66
 testRunner.When("I hover over the selected tenant", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 67
 testRunner.Then("The hovering over tenant is highlighted in green", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 68
 testRunner.Given("Click selected tenant - expanded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 69
 testRunner.When("I click the selected tenant", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 70
 testRunner.Then("The page displays the messages \"Authenticating\" and/or \"Loading map configuration" +
                        "\" for a few seconds, then the Grid Calculator application is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 71
 testRunner.Given("Verify that tenant name is displayed - expanded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 72
 testRunner.When("I verify that the current \"nsa_dev\" tenant name is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 73
 testRunner.Then("The current tenant name \"nsa_dev\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Select the tenant which is already selected after selecting one of the PowerTrans" +
            "formers that has the required data for the calculation and displaying the pop-up" +
            " window with information about it and running calculation")]
        [NUnit.Framework.CategoryAttribute("regression")]
        public void SelectTheTenantWhichIsAlreadySelectedAfterSelectingOneOfThePowerTransformersThatHasTheRequiredDataForTheCalculationAndDisplayingThePop_UpWindowWithInformationAboutItAndRunningCalculation()
        {
            string[] tagsOfScenario = new string[] {
                    "regression"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Select the tenant which is already selected after selecting one of the PowerTrans" +
                    "formers that has the required data for the calculation and displaying the pop-up" +
                    " window with information about it and running calculation", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
 testRunner.Given("Sidebar drop-down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 81
 testRunner.When("I click the sidebar drop-down menu button at the bottom of the menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 82
 testRunner.Then("The menu is expanded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 84
 testRunner.Given("Find and zoom power transformer on map", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table7.AddRow(new string[] {
                            "1",
                            "Ringgata 70, Hamar, Norway"});
                table7.AddRow(new string[] {
                            "2",
                            "Vangsvegen 143, Hamar, Norway"});
                table7.AddRow(new string[] {
                            "3",
                            "Brugata 41, Hamar, Norway"});
#line 85
 testRunner.When("I find on the map the place where right PowerTransformers that has the required d" +
                        "ata for the calculation is located", ((string)(null)), table7, "When ");
#line hidden
#line 90
 testRunner.Then("The power transformers is found", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 91
 testRunner.When("I Zoom in on the area where the PowerTransformer that has the required data for c" +
                        "alculation is located", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 93
 testRunner.Then("The area is zoomed in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 94
 testRunner.Given("Calculation for one of the PowerTransformers", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 95
 testRunner.When("I click on the dot in the center of the substation that is the power transformer " +
                        "that has the required data for the calculation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                            "Key",
                            "Value"});
                table8.AddRow(new string[] {
                            "1",
                            "ENS00383 TRF T1 TRAFO"});
                table8.AddRow(new string[] {
                            "2",
                            "ENS04633 TRF T1 TRAFO"});
                table8.AddRow(new string[] {
                            "3",
                            "ENS09636 TRF T1 TRAFO"});
#line 96
 testRunner.And("Have one of the names", ((string)(null)), table8, "And ");
#line hidden
#line 101
 testRunner.And("Have Asset Group \"Asset Group: Medium voltage 2 winding power transformer\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 102
    testRunner.Then("Then The \"Searching for assets\" is displayed for a few seconds, then the \"Select " +
                        "asset\" pop-up window is displayed in the upper left corner of page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 103
 testRunner.When("I Select the electric network device", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 104
 testRunner.And("I Select the \"Medium voltage 2 winding power transformer\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 105
 testRunner.Then("The power transformer that has the required data for the calculation is displayed" +
                        " in the pop-up window", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 106
 testRunner.When("I click on the green Run Tactic button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 107
 testRunner.Then("The green Run Tactic button is changed to the gray Running tactic button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 108
 testRunner.When("I wait until the gray Running tactic button is changed to the green Run Tactic bu" +
                        "tton", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 109
 testRunner.Then("The pop-up window is extended with the Result of Tactic list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 110
 testRunner.And("Subnetwork is highlighted in turquoise", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 111
 testRunner.And("Red Energy Consumers points for which the calculation results do not follow the r" +
                        "ules of Tactic are displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 112
 testRunner.And("Orange Energy Consumers points for which the calculation results almost do not fo" +
                        "llow the rules of Tactic by warning are displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 113
 testRunner.And("Green Energy Consumers points for which the calculation results follow the rules " +
                        "of Tactic are displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 114
 testRunner.When("I click the tenant tab in the menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 115
 testRunner.Then("The tooltip with the list of available organizations and tenants with a checked a" +
                        "ctive tenant \"nsa_dev\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 116
 testRunner.Given("Hover over selected tenant - expanded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 117
 testRunner.When("I hover over the selected tenant", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 118
 testRunner.Then("The hovering over tenant is highlighted in green", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 119
 testRunner.Given("Click selected tenant - expanded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 120
 testRunner.When("I click the selected tenant", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 121
 testRunner.Then("The page displays the messages \"Authenticating\" and/or \"Loading map configuration" +
                        "\" for a few seconds, then the Grid Calculator application is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 122
 testRunner.Given("Verify that tenant name is displayed - expanded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 123
 testRunner.When("I verify that the current \"nsa_dev\" tenant name is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 124
 testRunner.Then("The current tenant name \"nsa_dev\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Select the tenant which is already selected after changing the zoom and position")]
        [NUnit.Framework.CategoryAttribute("regression")]
        public void SelectTheTenantWhichIsAlreadySelectedAfterChangingTheZoomAndPosition()
        {
            string[] tagsOfScenario = new string[] {
                    "regression"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Select the tenant which is already selected after changing the zoom and position", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 127
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 128
 testRunner.Given("I navigate to GC application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 129
 testRunner.When("I Open the Grid Calculator application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 130
 testRunner.Then("The page displays the messages \"Authenticating\" and/or \"Loading map configuration" +
                        "\" for a few seconds, then the Grid Calculator application is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 131
 testRunner.Given("Sidebar drop-down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 132
 testRunner.When("I click the sidebar drop-down menu button at the bottom of the menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 133
 testRunner.Then("The menu is expanded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 134
 testRunner.When("I zoom in and out on the area on map using plus and minus buttons located in the " +
                        "lower right corner of page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 136
 testRunner.Then("The area is zoomed in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 137
 testRunner.When("I change position on the map using gesture on map", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 139
 testRunner.Then("The position of area is changed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 140
 testRunner.When("I click the tenant tab in the menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 141
 testRunner.Then("The tooltip with the list of available organizations and tenants with a checked a" +
                        "ctive tenant \"nsa_dev\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 142
 testRunner.Given("Hover over selected tenant - expanded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 143
 testRunner.When("I hover over the selected tenant", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 144
 testRunner.Then("The hovering over tenant is highlighted in green", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 145
 testRunner.Given("Click selected tenant - expanded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 146
 testRunner.When("I click the selected tenant", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 147
 testRunner.Then("The page displays the messages \"Authenticating\" and/or \"Loading map configuration" +
                        "\" for a few seconds, then the Grid Calculator application is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 148
 testRunner.Given("Verify that tenant name is displayed - expanded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 149
 testRunner.When("I verify that the current \"nsa_dev\" tenant name is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 150
 testRunner.Then("The current tenant name \"nsa_dev\" is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
