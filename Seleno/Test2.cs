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

    public class Test2
    {
        [Test]

        public void NavigateTest()
        {
            var logInPage = BrowserHost.Instance.NavigateToInitialPage<LogInPage>();
            var signUpPage = logInPage.GoToSignUpPage();
            var logInPage2 = signUpPage.GoToLogInPage();

            Thread.Sleep(3000);
        }
    }
}
