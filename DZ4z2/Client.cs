using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4z2
{
    public class Client
    {
        public static void Run()
        {
            
            LoginPageFactory loginPageFactory = new ChromeLoginPageFactory();
            
            LoginPage loginPage = loginPageFactory.CreatePage();
            
            loginPage.loginButton().Click();
        }
    }
}
