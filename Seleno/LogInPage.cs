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
        public LogInPage GoToSignUpPage()
        {
            Find.Element(By.LinkText("register / sign up")).Click();

            return this;
        }
    }

}
