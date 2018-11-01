using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.Seleno.PageObjects;
using TestStack.Seleno.PageObjects.Locators;

namespace Seleno
{
    public class ProdCatPage : Page 
    {
        public MenuBar MenuBar
        {
            get { return GetComponent<MenuBar>(); }
        }

        public CreateCatPage AddCat()
        {
            return Navigate.To<CreateCatPage>(By.LinkText("add category"));
        }
    }


}
