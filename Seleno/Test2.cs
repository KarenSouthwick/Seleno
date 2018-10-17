using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Threading;

namespace Seleno
{
    class Test2
    {
        [Test]

        public void LogIn2Test()
        {
            var logInPage = BrowserHost.Instance.NavigateToInitialPage<LogInPage>();

            var signUpPage = logInPage.GoToSignUpPage();
                    
            Thread.Sleep(3000);

        }
    }
}
