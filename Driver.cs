using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualSportSeleniumTests
{

    public  class Driver
    {
      public  IWebDriver driver = new ChromeDriver();
        
        //IWebDriver driverOpera = new OperaDriver();

        [SetUp]
        public void Test()
        {
            driver.Navigate().GoToUrl("https://www.totogaming.am/en");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        }

        [TearDown]
        public void Close()
        {
           // driver.Close();
            driver.Quit();
        }

    }

}
