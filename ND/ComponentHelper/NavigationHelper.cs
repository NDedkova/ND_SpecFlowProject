using ND.Settings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND.ComponentHelper
{
    public class NavigationHelper
    {
        private IWebDriver _driver;
        public NavigationHelper(IWebDriver driver)
        {
            _driver = driver;
        }
        public void NavigateToUrl(string Url)
        {
            _driver.Navigate().GoToUrl(Url);
        }
    }
}
