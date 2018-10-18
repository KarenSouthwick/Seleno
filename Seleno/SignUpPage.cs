using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.Seleno.PageObjects.Locators;
using TestStack.Seleno.PageObjects;

namespace Seleno
{
    public class SignUpPage : Page
    {
        public LogInPage GoToLogInPage()
        {
            return Navigate.To<LogInPage>(By.LinkText("Home"));
        }
    }
}
