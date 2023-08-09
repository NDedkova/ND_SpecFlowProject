using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND.Pages
{
    public class LoginPage
    {
        public By welcomMsg = By.XPath("//h2[starts-with(text(),'Добр')]");
        public By happymsge = By.XPath("//div[contains(text(), 'Рады снова вас видеть')]");
        private IWebDriver _driver;
        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
