using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.Seleno.PageObjects;
using TestStack.Seleno.PageObjects.Locators;

namespace Seleno
{
    public class MenuBar : UiComponent
    {
        public string NetworkLink
        {
            get { return Find.Element(By.Id("sel-network")).Text; }
        }
    }
}
