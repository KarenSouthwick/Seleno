using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.Seleno.PageObjects;
using TestStack.Seleno.PageObjects.Locators;

namespace Seleno
{
    public class SignUpPage : Page
    {
        public SignUpPage GoToLogInPage()
        {
            Find.Element(By.LinkText("Home")).Click();

            return this;
        }
    }
}
