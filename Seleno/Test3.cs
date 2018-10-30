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

    public class Test3
    {
        [Test]

        public void BootUpTest()
        {
            var logInPage = BrowserHost.Instance.NavigateToInitialPage<LogInPage>();
            var homePage = logInPage
                .InputUserName("karensouthwick")
                .InputPassword("Exchange!6")
                .BootUp();

            Thread.Sleep(3000);            
        }
    }
}
