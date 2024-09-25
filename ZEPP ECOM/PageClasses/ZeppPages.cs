using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZEPP_ECOM.PageClasses
{
    public class ZeppPages
        
    {
        public IWebDriver dr;
        public ZeppPages(IWebDriver dr)
        {
            this.dr = dr;
       
        }
        IWebElement ClickOnMoblieNumber => dr.FindElement(By.XPath("//p[text()='Mobile Number (One time registration required)']"));
        IWebElement EnteringMobileNumber => dr.FindElement(By.XPath("//input[@id='mobile_number']"));
        IWebElement SendOtpBtn => dr.FindElement(By.XPath("//button[@id='send_mobile_login_link']"));
        IWebElement SubmitOtp => dr.FindElement(By.XPath("//button[@id='submitOTP']"));

        public void VerifyingOtp()
        {
            ClickOnMoblieNumber.Click();
            EnteringMobileNumber.SendKeys("6281454459");
            Thread.Sleep(2000);
            SendOtpBtn.Click();
            Thread.Sleep(20000);
            SubmitOtp.Click();

        }
    }

    }

