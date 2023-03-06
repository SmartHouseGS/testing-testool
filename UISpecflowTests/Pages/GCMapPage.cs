
using NUnit.Framework.Internal;

namespace UISpecflowTests.Pages
{
    public class GCMapPage
    {
        private IPage _page;
        public GCMapPage(IPage page)
        {
            _page = page;
        }

        private ILocator _mapLeaflet => _page.Locator("div").Filter(new() { HasText = "Leaflet | © OpenStreetMap contributors" }).First;
        private ILocator _assetsList => _page.Locator("h3").Filter(new() { HasText = "Select asset" }).First;
        private ILocator _btnTestedTrafo => _page.Locator("text=Medium voltage 2 winding power transformer - ENS00383 TRF T1 TRAFO");
        private ILocator _btnRunTactic => _page.Locator("text=Run Tactic");
        private ILocator _btnShowAll => _page.Locator("text=Show all");
        private ILocator _listOfFailedTacticResult => _page.Locator("div[data-icon-name='error']");
        private ILocator _listOfWarningTacticResult => _page.Locator("div[data-icon-name='warning']");
        private ILocator _listOfValidTacticResult => _page.Locator("div[data-icon-name='validation']");

        public async Task<int> GetFailedTacticResultsCount() =>  await _listOfFailedTacticResult.CountAsync();
        public async Task<int> GetWarningTacticResultsCount() => await _listOfWarningTacticResult.CountAsync();
        public async Task<int> GetValidTacticResultsCount() => await _listOfValidTacticResult.CountAsync();
        public async Task<bool> IsTestedTrafoExist() => await _btnTestedTrafo.IsVisibleAsync();
        public async Task ClickTestedTrafo() => await _btnTestedTrafo.ClickAsync();
        public async Task ClickAreaOnMap() => await _page.Mouse.ClickAsync(604, 417);
        public async Task ClickRunTactic() => await _btnRunTactic.ClickAsync();
        public async Task<bool> IsShowAllExist() => await _btnShowAll.IsVisibleAsync();
        public async Task ClickShowAll() => await _btnShowAll.ClickAsync();


        public async Task WaitForMapLoaded()
        {

            await _page.WaitForLoadStateAsync(LoadState.NetworkIdle);
            await _page.ScreenshotAsync(new PageScreenshotOptions
            {
                Path = "test.jpg"
            });
            await _mapLeaflet.ElementHandleAsync();

            await _page.WaitForLoadStateAsync(LoadState.NetworkIdle);
        }

        public async Task WaitForAssetsListLoaded()
        {
            await _assetsList.ElementHandleAsync();

            await _page.WaitForLoadStateAsync(LoadState.NetworkIdle);
        }
    }
}
