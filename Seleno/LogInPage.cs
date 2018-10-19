using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.Seleno.PageObjects;
using TestStack.Seleno.PageObjects.Locators;

namespace Seleno
{
    public class LogInPage : Page
    {
        public SignUpPage GoToSignUpPage()
        {
            return Navigate.To<SignUpPage>(By.LinkText("register / sign up"));
        }

        public LogInPage InputUserName(string term)
        {
            Find.Element(By.Id("UserName"))
                .SendKeys(term);

            return this;
        }

        public LogInPage InputPassword(string term)
        {
            Find.Element(By.Id("Password"))
                .SendKeys(term);

            return this;

        }

        public HomePage BootUp()
        {
            return Navigate.To<HomePage>(By.Id("do-submit"));
        }
    }

    public class HomePage : Page
    {
    }
}
