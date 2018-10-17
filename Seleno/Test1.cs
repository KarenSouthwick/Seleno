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

            var firstNameBox = BrowserHost.Instance.Application.Browser.FindElement(By.Id("UserName"));
            firstNameBox.SendKeys("karensouthwick");

            var passwordBox = BrowserHost.Instance.Application.Browser.FindElement(By.Id("Password"));
            passwordBox.SendKeys("Exchange!6");

            var loginBox = BrowserHost.Instance.Application.Browser.FindElement(By.Id("do-submit"));
            loginBox.Click();

            Thread.Sleep(3000);

            var networkHeader = BrowserHost.Instance.Application.Browser.FindElement(By.Id("sel-network"));
            Assert.That(networkHeader.Text, Is.EqualTo("Network"));
           
        }
    }
}
