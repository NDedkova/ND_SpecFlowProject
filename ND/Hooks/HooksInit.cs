using ND.Configuration;
using ND.CustomerExeption;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using ND.Settings;
using BoDi;

namespace ND.Hooks
{
    [Binding]
    public class HookInit
    {
        private readonly IObjectContainer _objectContainer;
        private IWebDriver _driver;
        public HookInit(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }
        public ChromeOptions GetChromeOptions()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("start-maximized");
            return option;
        }
        public InternetExplorerOptions GetIEOptions()
        {
            InternetExplorerOptions option = new InternetExplorerOptions();
            option.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            option.EnsureCleanSession = true;
            return option;
        }
        public IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver(GetChromeOptions());
            return driver;
        }
        public IWebDriver GetIEDriver()
        {
            IWebDriver driver = new InternetExplorerDriver(GetIEOptions());
            return driver;
        }
        [BeforeScenario]
        public void InitWebdriver()
        {
            ObjectRepository.Config = new AppConfigReader();
            switch (ObjectRepository.Config.GetBrowser())
            {
                case BrowserType.Chrome:
                    _driver = GetChromeDriver();
                    break;
                case BrowserType.IExplorer:
                    _driver = GetIEDriver();
                    break;
                default:
                    throw new NoSutiableDriverFound("Driver Not Found: " + ObjectRepository.Config.GetBrowser().ToString());
            }
            _objectContainer.RegisterInstanceAs<IWebDriver>(_driver);
        }
        [AfterScenario]
        public void TearDown()
        {
            if (_driver != null)
            {
                _driver.Close();
                _driver.Quit();
            }
        }
    }
}