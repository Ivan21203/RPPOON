using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ4z2
{
    public class ChromeLoginPage:LoginPage
    {
        public WebElement loginButton() { return new WebElement("#LoginButton"); }
        public WebElement usernameInput() { return new WebElement("#userInput"); }
        public WebElement passwordInput() { return new WebElement("#passwordElement"); }
    }
}
