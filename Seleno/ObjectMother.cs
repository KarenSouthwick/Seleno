using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.Seleno.PageObjects;
using TestStack.Seleno.PageObjects.Locators;

namespace Seleno
{
    public class ObjectMother
    {
        public static CreateCatModel CreateCreateCatModel()
        {
            var model = new CreateCatModel
            {
                CategoryName = "Bananas"
            };

            return model;
        }
    }
}
