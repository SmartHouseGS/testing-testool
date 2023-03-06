using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UISpecflowTests.Drivers
{
    internal interface IDriver : IDisposable
    {
        public Task<IPage> InitializePlaywright();
        public Task ManualMSAuthAsync();
        public Task<IPage> InitializePlaywrightWithStorage();
    }
}
