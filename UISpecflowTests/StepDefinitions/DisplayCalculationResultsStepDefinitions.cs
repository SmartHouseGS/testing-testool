using UISpecflowTests.Pages;
using UISpecflowTests.Drivers;

namespace UISpecflowTests.StepDefinitions
{
    [Binding]
    public class DisplayCalculationResultsStepDefinitions
    {
        private readonly GCDriver _driver;
        private readonly GCMapPage _gCMapPage;

        public DisplayCalculationResultsStepDefinitions(GCDriver driver)
        {
            _driver = driver;
            _gCMapPage = new GCMapPage(_driver.Page);
        }

        [Given(@"I navigate to GC application")]
        public async Task GivenINavigateToGcApplication()
        {
          //  await _driver.Page.GotoAsync("https://www-qa.gridcalculator.volue.com/");
         //   await _gCMapPage.WaitForMapLoaded();
        }

        [When(@"I click on right PowerTransformer that follow the rules of Tactic")]
        public async Task WhenIClickOnRightPowerTransformerThatFollowTheRulesOfTactic()
        {
            await _gCMapPage.ClickAreaOnMap();
        }

        [Then(@"I see right PowerTransformer on select asset list")]
        public async Task ThenISeeRightPowerTransformerOnSelectAssetList()
        {
            await _gCMapPage.WaitForAssetsListLoaded();
            var IsExist = await _gCMapPage.IsTestedTrafoExist();
            IsExist.Should().BeTrue();
        }

        [When(@"I click on right PowerTransformer")]
        public async Task WhenIClickOnRightPowerTransformer()
        {
            await _gCMapPage.ClickTestedTrafo();
        }

        [When(@"I click on Run Tactic for right PowerTransformer")]
        public async Task WhenIClickOnRunTacticForRightPowerTransformer()
        {
            await _gCMapPage.ClickRunTactic();
        }

        [When(@"I click on Show All checkbox")]
        public async Task WhenIClickOnShowAllCheckbox()
        {
            var IsExist = await _gCMapPage.IsTestedTrafoExist();
            IsExist.Should().BeTrue();
            await _gCMapPage.ClickShowAll();
        }


        [Then(@"I get (.*) failed, (.*) warning and (.*) valid result of tactic")]
        public async Task ThenIGetFailedWarningAndPassedResultOfTactic(int failedResult, int warningResult, int validResult)
        {
            var failedTacticResultsCount = await _gCMapPage.GetFailedTacticResultsCount();
            failedTacticResultsCount.Should().Be(failedResult);

            var warningTacticResultsCount = await _gCMapPage.GetWarningTacticResultsCount();
            warningTacticResultsCount.Should().Be(warningResult);

            var validTacticResultsCount = await _gCMapPage.GetValidTacticResultsCount();
            validTacticResultsCount.Should().Be(validResult);
        }


    }
}
