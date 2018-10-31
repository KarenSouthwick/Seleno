using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestStack.Seleno.PageObjects;
using System.Threading;

namespace Seleno
{
    [TestFixture]

    public class Test4
    {
        [Test]

        public void KazTest()
        {
            var page = BrowserHost.Instance.NavigateToInitialPage<LogInPage>()
                .InputUserName("karensouthwick")
                .InputPassword("Exchange!6")
                .BootUp()
                .GoToProdCatPage();

        }
    }
}
