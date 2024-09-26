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
        IWebElement VerifyingErrorMsg => dr.FindElement(By.XPath("//p[text()[normalize-space()='Your mobile number is not linked with your institute Email ID.']]"));
        IWebElement ClickOnEmail => dr.FindElement(By.XPath("//p[text()='Personal Email ID* (Additional verification required)']"));
        IWebElement EnteringEmail => dr.FindElement(By.XPath("//input[@id='home_email']"));
        IWebElement ClickSendOtpBtn => dr.FindElement(By.XPath("//button[@id='send_login_link']"));
        IWebElement EnterStudentId => dr.FindElement(By.XPath("//input[@id='emp_name']"));
        IWebElement EnterInstname => dr.FindElement(By.XPath("//input[@name='institute_name']"));
        IWebElement chooseDoctype => dr.FindElement(By.XPath("//label[text()='Upload Institute Document (Enrolment Letter, Admission Letter)']"));
        IWebElement choosefile => dr.FindElement(By.XPath("//input[@id='document_image']"));
        IWebElement Submitbutton => dr.FindElement(By.XPath("//button[text()='Submit']"));





        public void VerifyingOtp()
        {
            ClickOnMoblieNumber.Click();
            EnteringMobileNumber.SendKeys("9390562853");
            Thread.Sleep(2000);
            SendOtpBtn.Click();
            Thread.Sleep(20000);
            SubmitOtp.Click();
            Assert.IsTrue(VerifyingErrorMsg.Displayed,"Error msg is not displayed");

        }
        public void EnterEmail()
        {
            ClickOnEmail.Click();
            EnteringEmail.SendKeys("vasanthapuramkarthik@gmail.com");
            Thread.Sleep(2000);
            ClickSendOtpBtn.Click();
            Thread.Sleep(35000);
            SubmitOtp.Click();
            EnterStudentId.SendKeys("Karthik");
            dr.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(2);
            EnterInstname.SendKeys("Jawaharlal Nehru Technological University, Anantapur");
            dr.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            chooseDoctype.Click();
            dr.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            string filepath= @"C:\\Users\\HP PRO BOOK 640 G5\\Downloads\\WhatsApp Image 2024-09-25 at 2.56.16 PM.jpeg";
            choosefile.SendKeys(filepath);
            dr.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            Submitbutton.Click();
        }
    }

    }

