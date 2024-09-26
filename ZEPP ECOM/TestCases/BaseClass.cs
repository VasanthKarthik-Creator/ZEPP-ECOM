using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZEPP_ECOM.TestCases
{
    public class BaseClass
    {
        public IWebDriver driver;

        [SetUp]
        public void Setup() 
        { 
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://zepp.studentpurchaseprogram.com/");
            driver.Manage().Window.Maximize();   
        }
    }
}
