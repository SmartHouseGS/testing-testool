using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UISpecflowTests.Pages
{
    internal class GCMenuPage
    {
        private IPage _page;
        public GCMenuPage(IPage page) =>  _page = page;
      

        private ILocator _btnShowAll => _page.Locator("");
        private ILocator _listOfFailedTacticResult => _page.Locator("");
        private ILocator _listOfWarningTacticResult => _page.Locator("");
        private ILocator _listOfValidTacticResult => _page.Locator("");

    }
}
