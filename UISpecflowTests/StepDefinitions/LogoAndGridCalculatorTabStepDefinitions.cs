using System;
using TechTalk.SpecFlow;

namespace UISpecflowTests.StepDefinitions
{
    [Binding]
    public class LogoAndGridCalculatorTabStepDefinitions
    {
        [When(@"I Open the Grid Calculator application")]
        public void WhenIOpenTheGridCalculatorApplication()
        {
            //throw new PendingStepException();
        }

        [Then(@"The page displays the messages ""([^""]*)"" and/or ""([^""]*)"" for a few seconds, then the Grid Calculator application is displayed")]
        public void ThenThePageDisplaysTheMessagesAndOrForAFewSecondsThenTheGridCalculatorApplicationIsDisplayed(string authenticating, string p1)
        {
            //throw new PendingStepException();
        }

        [When(@"I click the Volue logo at the top of the menu")]
        public void WhenIClickTheVolueLogoAtTheTopOfTheMenu()
        {
            //throw new PendingStepException();
        }

        [Given(@"Second tenant - collapsed")]
        public void GivenSecondTenant_Collapsed()
        {
            //throw new PendingStepException();
        }

        [When(@"I click the tenant icon in the menu")]
        public void WhenIClickTheTenantIconInTheMenu()
        {
            //throw new PendingStepException();
        }

        [Then(@"The tooltip with the list of available organizations and tenants with a checked active tenant ""([^""]*)"" is displayed")]
        public void ThenTheTooltipWithTheListOfAvailableOrganizationsAndTenantsWithACheckedActiveTenantIsDisplayed(string p0)
        {
            //throw new PendingStepException();
        }

        [When(@"I click the second tenant ""([^""]*)"" from the list")]
        public void WhenIClickTheSecondTenantFromTheList(string p0)
        {
            //throw new PendingStepException();
        }

        [Then(@"The page may display the message ""([^""]*)"" for a few seconds,")]
        public void ThenThePageMayDisplayTheMessageForAFewSeconds(string p0)
        {
            //throw new PendingStepException();
        }

        [Then(@"The Grid Calculator application is displayed but without power grid objects on the map")]
        public void ThenTheGridCalculatorApplicationIsDisplayedButWithoutPowerGridObjectsOnTheMap()
        {
            //throw new PendingStepException();
        }

        [Given(@"Click one of the power grid objects - collapsed")]
        public void GivenClickOneOfThePowerGridObjects_Collapsed()
        {
            //throw new PendingStepException();
        }

        [When(@"I click one of the power grid objects")]
        public void WhenIClickOneOfThePowerGridObjects()
        {
            //throw new PendingStepException();
        }

        [Then(@"The ""([^""]*)"" is displayed for a few seconds, then the ""([^""]*)"" pop-up window is displayed in the upper left corner of page")]
        public void ThenTheIsDisplayedForAFewSecondsThenThePop_UpWindowIsDisplayedInTheUpperLeftCornerOfPage(string p0, string p1)
        {
            //throw new PendingStepException();
        }

        [Given(@"Select one of the power object - collapsed")]
        public void GivenSelectOneOfThePowerObject_Collapsed()
        {
            //throw new PendingStepException();
        }

        [When(@"I Select one of the power grid objects from the list")]
        public void WhenISelectOneOfThePowerGridObjectsFromTheList()
        {
            //throw new PendingStepException();
        }

        [Then(@"The selected power grid object information is displayed in the pop-up window")]
        public void ThenTheSelectedPowerGridObjectInformationIsDisplayedInThePop_UpWindow()
        {
            //throw new PendingStepException();
        }

        [Given(@"Find and zoom power transformer on map")]
        public void GivenFindAndZoomPowerTransformerOnMap()
        {
            //throw new PendingStepException();
        }

        [When(@"I find on the map the place where right PowerTransformers that has the required data for the calculation is located")]
        public void WhenIFindOnTheMapThePlaceWhereRightPowerTransformersThatHasTheRequiredDataForTheCalculationIsLocated(Table table)
        {
            //throw new PendingStepException();
        }

        [Then(@"The power transformers is found")]
        public void ThenThePowerTransformersIsFound()
        {
            //throw new PendingStepException();
        }

        [When(@"I Zoom in on the area where the PowerTransformer that has the required data for calculation is located")]
        public void WhenIZoomInOnTheAreaWhereThePowerTransformerThatHasTheRequiredDataForCalculationIsLocated()
        {
            //throw new PendingStepException();
        }

        [Then(@"The area is zoomed in")]
        public void ThenTheAreaIsZoomedIn()
        {
            //throw new PendingStepException();
        }

        [Given(@"Calculation for one of the PowerTransformers")]
        public void GivenCalculationForOneOfThePowerTransformers()
        {
            //throw new PendingStepException();
        }

        [When(@"I click on the dot in the center of the substation that is the power transformer that has the required data for the calculation")]
        public void WhenIClickOnTheDotInTheCenterOfTheSubstationThatIsThePowerTransformerThatHasTheRequiredDataForTheCalculation()
        {
            //throw new PendingStepException();
        }

        [When(@"Have one of the names")]
        public void WhenHaveOneOfTheNames(Table table)
        {
            //throw new PendingStepException();
        }

        [When(@"Have Asset Group ""([^""]*)""")]
        public void WhenHaveAssetGroup(string p0)
        {
            //throw new PendingStepException();
        }

        [Then(@"Then The ""([^""]*)"" is displayed for a few seconds, then the ""([^""]*)"" pop-up window is displayed in the upper left corner of page")]
        public void ThenThenTheIsDisplayedForAFewSecondsThenThePop_UpWindowIsDisplayedInTheUpperLeftCornerOfPage(string p0, string p1)
        {
            //throw new PendingStepException();
        }

        [When(@"I Select the electric network device")]
        public void WhenISelectTheElectricNetworkDevice()
        {
            //throw new PendingStepException();
        }

        [When(@"I Select the ""([^""]*)""")]
        public void WhenISelectThe(string p0)
        {
            //throw new PendingStepException();
        }

        [Then(@"The power transformer that has the required data for the calculation is displayed in the pop-up window")]
        public void ThenThePowerTransformerThatHasTheRequiredDataForTheCalculationIsDisplayedInThePop_UpWindow()
        {
            //throw new PendingStepException();
        }

        [When(@"I click on the green Run Tactic button")]
        public void WhenIClickOnTheGreenRunTacticButton()
        {
            //throw new PendingStepException();
        }

        [Then(@"The green Run Tactic button is changed to the gray Running tactic button")]
        public void ThenTheGreenRunTacticButtonIsChangedToTheGrayRunningTacticButton()
        {
            //throw new PendingStepException();
        }

        [When(@"I wait until the gray Running tactic button is changed to the green Run Tactic button")]
        public void WhenIWaitUntilTheGrayRunningTacticButtonIsChangedToTheGreenRunTacticButton()
        {
            //throw new PendingStepException();
        }

        [Then(@"The pop-up window is extended with the Result of Tactic list")]
        public void ThenThePop_UpWindowIsExtendedWithTheResultOfTacticList()
        {
            //throw new PendingStepException();
        }

        [Then(@"Subnetwork is highlighted in turquoise")]
        public void ThenSubnetworkIsHighlightedInTurquoise()
        {
            //throw new PendingStepException();
        }

        [Then(@"Red Energy Consumers points for which the calculation results do not follow the rules of Tactic are displayed")]
        public void ThenRedEnergyConsumersPointsForWhichTheCalculationResultsDoNotFollowTheRulesOfTacticAreDisplayed()
        {
            //throw new PendingStepException();
        }

        [Then(@"Orange Energy Consumers points for which the calculation results almost do not follow the rules of Tactic by warning are displayed")]
        public void ThenOrangeEnergyConsumersPointsForWhichTheCalculationResultsAlmostDoNotFollowTheRulesOfTacticByWarningAreDisplayed()
        {
            //throw new PendingStepException();
        }

        [Then(@"Green Energy Consumers points for which the calculation results follow the rules of Tactic are displayed")]
        public void ThenGreenEnergyConsumersPointsForWhichTheCalculationResultsFollowTheRulesOfTacticAreDisplayed()
        {
            //throw new PendingStepException();
        }

        [When(@"I zoom in and out on the area on map using plus and minus buttons located in the lower right corner of page")]
        public void WhenIZoomInAndOutOnTheAreaOnMapUsingPlusAndMinusButtonsLocatedInTheLowerRightCornerOfPage()
        {
            //throw new PendingStepException();
        }

        [When(@"I change position on the map using gesture on map")]
        public void WhenIChangePositionOnTheMapUsingGestureOnMap()
        {
            //throw new PendingStepException();
        }

        [Then(@"The position of area is changed")]
        public void ThenThePositionOfAreaIsChanged()
        {
            //throw new PendingStepException();
        }

        [Given(@"Sidebar drop-down menu")]
        public void GivenSidebarDrop_DownMenu()
        {
            //throw new PendingStepException();
        }

        [When(@"I click the sidebar drop-down menu button at the bottom of the menu")]
        public void WhenIClickTheSidebarDrop_DownMenuButtonAtTheBottomOfTheMenu()
        {
            //throw new PendingStepException();
        }

        [Then(@"The menu is expanded")]
        public void ThenTheMenuIsExpanded()
        {
            //throw new PendingStepException();
        }

        [When(@"I click on the Grid Calculator tab at the top of the menu")]
        public void WhenIClickOnTheGridCalculatorTabAtTheTopOfTheMenu()
        {
            //throw new PendingStepException();
        }

        [Given(@"Second tenant - expanded")]
        public void GivenSecondTenant_Expanded()
        {
            //throw new PendingStepException();
        }

        [When(@"I click the tenant tab in the menu")]
        public void WhenIClickTheTenantTabInTheMenu()
        {
            //throw new PendingStepException();
        }

        [Given(@"Click one of the power grid objects - expanded")]
        public void GivenClickOneOfThePowerGridObjects_Expanded()
        {
            //throw new PendingStepException();
        }

        [Given(@"Select one of the power object - expanded")]
        public void GivenSelectOneOfThePowerObject_Expanded()
        {
            //throw new PendingStepException();
        }

        [When(@"I Hover over the second tenant from the list")]
        public void WhenIHoverOverTheSecondTenantFromTheList()
        {
            //throw new PendingStepException();
        }

    }
}
