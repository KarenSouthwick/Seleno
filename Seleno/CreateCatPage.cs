using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.Seleno.PageObjects;
using TestStack.Seleno.PageObjects.Locators;

namespace Seleno
{
    public class CreateCatPage : Page<CreateCatModel>
    {
        public ProdCatPage CreateCategory(CreateCatModel model)
        {
            Input.Model(model);
            return Navigate.To<ProdCatPage>(By.CssSelector(".button.button.action"));
        }
    }
}
