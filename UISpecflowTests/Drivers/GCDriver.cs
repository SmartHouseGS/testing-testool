using Gherkin;
using UISpecflowTests.Pages;

namespace UISpecflowTests.Drivers
{
    [Binding]
    public class GCDriver: IDriver
    {
        private readonly string _testEmail;
        private readonly string _testPass;
        private Task<IPage> _page;
        private MicrosoftLoginPage _loginPage;
        private IBrowser? _browser;

        public GCDriver()
        {
            _testEmail = Environment.GetEnvironmentVariable("TEST_EMAIL");
            _testPass = Environment.GetEnvironmentVariable("TEST_PASS");
        }

        public IPage Page => _page.Result;

        public void Dispose()
        {
            _browser?.CloseAsync();
        }


        public async Task<IPage> InitializePlaywright()
        {
            var playwright = await Playwright.CreateAsync();

            _browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false
            });

            var browserContext = await _browser.NewContextAsync(new()
            {
                // StorageStatePath = "state.json",
            });

            _page = browserContext.NewPageAsync();

            return await _page;
        }

        public async Task ManualMSAuthAsync()
        {
            _loginPage = new MicrosoftLoginPage(Page);
            await Page.GotoAsync("https://www-qa.gridcalculator.volue.com/");
            await _loginPage.Login(_testEmail, _testPass);
        }

        public async Task<IPage> InitializePlaywrightWithStorage()
        {
            var playwright = await Playwright.CreateAsync();

            _browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = true
            });

            var browserContext = await _browser.NewContextAsync(new()
            {
                     StorageStatePath = "state.json",
            });

            _page = browserContext.NewPageAsync();

            return await _page;
        }
    }
}
