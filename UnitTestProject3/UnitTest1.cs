using System;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using CC;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace CCWebDriver
{
    [TestFixture]
    public class UnitTest1
    {   
        [Test]
        [TestCase("badri", "password", "https://www.cc/notifications/CCLogin.aspx")]
        public void LoginTest(String u, String p, String url)
        {
           // Console.Out.Write("hello");
            //WebDriver driver = new RemoteWebDriver(new URL("http://localhost:4444/wd/hub"), capability);
            DesiredCapabilities dc = new DesiredCapabilities();
           // System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", "C:\\chromedriver_win32\\chromedriver.exe");
            ChromeOptions options = new ChromeOptions();
            options.BinaryLocation = "C:\\chromedriver_win32\\chromedriver.exe";
            
dc.SetCapability(ChromeOptions.Capability, options);
            
            
            //dc.SetCapability("webdriver.chrome.driver", "C:\\chromedriver_win32\\chromedriver.exe");
OpenQA.Selenium.IWebDriver ff = new FirefoxDriver();
                // new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), dc);
  //          OpenQA.Selenium.IWebDriver ff = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"),DesiredCapabilities.Firefox(),TimeSpan.FromMinutes(2));
            //WebDriverWait wait = new WebDriverWait(ff, TimeSpan.FromSeconds(10));
            
            ff.Navigate().GoToUrl(url);     

            Login l = new Login(ff);
            l.loginPage(u, p);
        }

        [TestCase()]
        public void Loginn()
        {
            
        }
    }
}
