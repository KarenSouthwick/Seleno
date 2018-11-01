using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Seleno
{
    [TestFixture]

    public class Test5
    {
        [Test]

        public void StrongTest()
        {
            var page = BrowserHost.Instance.NavigateToInitialPage<LogInPage>()
                .InputUserName("karensouthwick")
                .InputPassword("Exchange!6")
                .BootUp()
                .GoToProdCatPage()
                .AddCat()
                .CreateCategory(ObjectMother.CreateCreateCatModel());
        }
    }
}
