using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {
        ChromeDriver chromeDriver;
        private const string baseurl = "https://github.com/";
        private const string username = "testautomationuser";
        private const string password = "Time4Death!";

        [TestMethod]
        public void TestMethod1()
        {
            chromeDriver = new ChromeDriver();
            chromeDriver.Navigate().GoToUrl(baseurl);
            chromeDriver.FindElementByXPath(".//a[text() = 'Sign in']").Click();
            chromeDriver.FindElementById("login_field").SendKeys(username);
            chromeDriver.FindElementById("password").SendKeys(password);
        }
        [TestCleanup]
        public void TearDown()
        {
            chromeDriver.Quit();
        }
    }
}
