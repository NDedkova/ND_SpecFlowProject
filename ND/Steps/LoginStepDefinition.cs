using Microsoft.VisualStudio.TestTools.UnitTesting;
using ND.ComponentHelper;
using ND.Pages;
using ND.Settings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace ND.Steps
{
    [Binding]
    public class LoginStepDefinitions
    {
        private readonly IWebDriver _driver;
        private readonly NavigationHelper _navigationHelper;
        private readonly LoginPage _loginPage;
        public LoginStepDefinitions(IWebDriver driver) 
        { 
            _driver = driver;
            _navigationHelper = new NavigationHelper(driver);
            _loginPage = new LoginPage(driver);
        }

        [Given(@"I navigate to the app")]
        public void NavigateToApp()
        {
            _navigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
        }
        [Then(@"I verify welcome message is visible")]
        public void VerifyWelcomeMessage()
        {
            IWebElement result = _driver.FindElement(_loginPage.welcomMsg);
            Assert.IsTrue(result.Displayed);
        }
        [Then(@"I verify happy message is visible")]
        public void VerifyHappyMessage()
        {
            IWebElement result = _driver.FindElement(_loginPage.happymsge);
            Assert.IsTrue(result.Displayed);
        }

    }
}
