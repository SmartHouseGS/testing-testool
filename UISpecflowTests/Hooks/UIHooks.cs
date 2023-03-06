using BoDi;
using TechTalk.SpecFlow;
using UISpecflowTests.Drivers;

namespace UISpecflowTests.Hooks
{
    [Binding]
    public sealed class UIHooks
    {
        private readonly IObjectContainer container;
        private static IDriver? driver;

        public UIHooks(IObjectContainer container)
        {
            this.container = container;
        }
       
        [BeforeFeature]
        public static async Task BeforeFeature()
        {
            driver = new GCDriver();
            await driver.InitializePlaywright();
            await driver.ManualMSAuthAsync();
            await driver.Page.Context.StorageStateAsync(new BrowserContextStorageStateOptions
            {
                Path = "state.json"
            });
            driver.Dispose();
        }

        [BeforeScenario]
        public async Task FirstBeforeScenario()
        {
            var driver = new GCDriver();
            await driver.InitializePlaywrightWithStorage();
            container.RegisterInstanceAs(driver);



            // Example of ordering the execution of hooks
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=order#hook-execution-order

            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario(IObjectContainer container)
        {
            var driver = container.Resolve<GCDriver>();
            driver.Dispose();
           
            //TODO: implement logic that has to run after executing each scenario
        }

        [AfterFeature]
        public static void FeatureTearDown()
        {
            if (driver == null)
                return;

            driver.Dispose();
            driver = null;
        }


        //public async Task StartTracingAsync(DriverTest driverTest)
        //{
        //    //var tracing = await driverTest.Tracing;
        //    //await tracing.StartAsync(new TracingStartOptions
        //    //{
        //    //    Name = _traceName,
        //    //    Screenshots = true,
        //    //    Snapshots = true
        //    //});

        //    await driverTest.ManualMSAuthAsync();
        //}

        //[AfterScenario]
        //public async Task StopTracingAsync(DriverTest driverTest)
        //{
        //    var tracing = await driverTest.Tracing;
        //    await tracing.StopAsync(new TracingStopOptions()
        //    {
        //        Path = $"traces/{_traceName}.zip"
        //    });
        //}



    }
}