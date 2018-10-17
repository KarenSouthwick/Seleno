using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using TestStack.Seleno.PageObjects.Locators;

namespace Seleno
{
    [TestFixture]

    public class Test1
    {
        [Test]

        public void LogInTest()
        {
            BrowserHost.Instance.Application.Browser
                .Navigate()
                .GoToUrl(BrowserHost.RootUrl);

            var signUpPage = BrowserHost.Instance.NavigateToInitialPage<LogInPage>().GoToSignUpPage();
            Assert.That(signUpPage.Url, Is.EqualTo("https://qa-platform.authenticateis.com/SignUp"));

            var logInPage = BrowserHost.Instance.NavigateToInitialPage<LogInPage>();
            Assert.That(logInPage.Url, Is.EqualTo("https://qa-platform.authenticateis.com/Account/Logon?ReturnUrl=%2f"));

        }
    }
}
