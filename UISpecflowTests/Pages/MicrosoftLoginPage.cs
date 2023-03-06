
namespace UISpecflowTests.Pages
{
    public class MicrosoftLoginPage
    {
        private IPage _page;
        public MicrosoftLoginPage(IPage page) => _page = page;
        private ILocator _txtEmail => _page.Locator("[name='loginfmt']");
        private ILocator _txtPassword => _page.Locator("[name='passwd']");
        private ILocator _btnNext => _page.Locator("text=Next");
        private ILocator _btnLogin => _page.Locator("text=Sign in");
        private ILocator _btnYes => _page.Locator("text=Yes");
        private ILocator _btnVerify => _page.GetByRole(AriaRole.Button).GetByText("Verify");// .Locator("input").Filter(new() { HasText = "Verify" }).First;

        private ILocator _btnDontShowAgain => _page.Locator("[name='DontShowAgain']");
        private ILocator _btnApprove => _page.Locator("div.table").First;

        public async Task Login(string userName, string password)
        {
            await _txtEmail.FillAsync(userName);
            await _btnNext.ClickAsync();
            await _txtPassword.FillAsync(password);
            await _page.WaitForLoadStateAsync(LoadState.NetworkIdle);
            
            await _page.RunAndWaitForResponseAsync(async () =>
            {
                await _btnLogin.ClickAsync();
                await _page.WaitForLoadStateAsync(LoadState.NetworkIdle);
            }
            , "https://www-qa.gridcalculator.volue.com/signin-oidc");
           
            //try
            //{
            if (await _btnVerify.IsVisibleAsync())
            {
                Console.WriteLine("Verify1 found");
                await _btnVerify.ClickAsync();
                await _page.WaitForLoadStateAsync(LoadState.NetworkIdle);
            }
            else
            {
                Console.WriteLine("Verify1 not found");
            }

            if (await _btnApprove.IsVisibleAsync())
            {
                Console.WriteLine("Approve found");
                await _btnApprove.ClickAsync();
                await _page.WaitForLoadStateAsync(LoadState.NetworkIdle);
            }
            else
            {
                Console.WriteLine("Approve not found");
            }
            if (await _btnDontShowAgain.IsVisibleAsync())
            {
                Console.WriteLine("DontShowAgain found");
                await _btnDontShowAgain.ClickAsync();
                await _page.WaitForLoadStateAsync(LoadState.NetworkIdle);
            }
            await _page.WaitForLoadStateAsync(LoadState.NetworkIdle);

            if (await _btnYes.IsVisibleAsync())
            {
                await _btnYes.ClickAsync();
            }
            //await _page.ScreenshotAsync(new PageScreenshotOptions
            //{
            //    Path = "test.jpg"
            //});
            //}
            //catch (TimeoutException)
            //{
            //    Console.WriteLine("Timeout!");
            //    await _page.ScreenshotAsync(new PageScreenshotOptions
            //    {
            //        Path = "test.jpg"
            //    });
            //}
        }
    }
}
