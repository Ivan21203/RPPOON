using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4z2
{
    public class ChromeLoginPageFactory:LoginPageFactory
    {
        public override LoginPage CreatePage()
        {
            return new ChromeLoginPage();
        }
    }
}
