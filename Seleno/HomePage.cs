using TestStack.Seleno.PageObjects;
using TestStack.Seleno.PageObjects.Locators;

namespace Seleno
{
    public class HomePage : Page
    {
        public ProdCatPage GoToProdCatPage()
        {
            return Navigate.To<ProdCatPage>(By.Id("sel-productCatalogueLink"));
        }
       
    }
    
}
