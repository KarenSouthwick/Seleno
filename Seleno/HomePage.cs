using TestStack.Seleno.PageObjects;
using TestStack.Seleno.PageObjects.Locators;

namespace Seleno
{
    public class HomePage : Page
    {
        public LogInPage GoToLogInPage()
        {
            return Navigate.To<LogInPage>(By.CssSelector("input[type='submit']"));
        }
        
    }
    
}
