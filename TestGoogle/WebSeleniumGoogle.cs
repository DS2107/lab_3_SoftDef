using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestGoogle
{
    [TestClass]
    public class WebSeleniumGoogle
    {

        ChromeDriver chrome;

        [TestMethod]
        public void Search()
        {
            chrome = new ChromeDriver();
            chrome.Navigate().GoToUrl("http://www.google.com/");
            chrome.FindElement(By.Name("q")).SendKeys("unit testing" + Keys.Enter);
          //  chrome.FindElement(By.Name("q")).SendKeys(Keys.Enter);

            WebDriverWait wait = new WebDriverWait(chrome, TimeSpan.FromSeconds(10));
            wait.Until(d => d.FindElement(By.Id("main")));

            var entries = chrome.FindElements(By.Id("main"));

            foreach (IWebElement entry in entries)
            {
     
                    entry.FindElement(By.XPath("//a[@href='https://en.wikipedia.org/wiki/Unit_testing']")).Click();
            }

            chrome.FindElement(By.XPath("//*[contains(@placeholder,'Search Wikipedia')]")).SendKeys("NUnit" + Keys.Enter);
         //   chrome.FindElement(By.XPath("//*[contains(@placeholder,'Search Wikipedia')]")).SendKeys(Keys.Enter);

            wait.Until(d => d.FindElement(By.Id("p-lang")));
            entries = chrome.FindElements(By.Id("p-lang"));

            foreach (IWebElement entry in entries)
            {
                if (entry.Text.Contains("Русский"))
                {
                    entry.FindElement(By.XPath("//a[@lang='ru']")).Click();
                }
            }
        }


        // разрушение объекта драйвера после окончание теста.
        [TestCleanup]
        public void TearDown()
        {
            chrome.Quit();
        }
    }
}
