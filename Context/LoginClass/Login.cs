using Context.DashboardClasses;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Context
{
    public class Login
    {
        public IWebElement loginToEmail => PropertiesCollection.driver.FindElement(By.Name("email"));
        public IWebElement loginNext => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/form/div[2]/div/div[2]/button"));
        public IWebElement loginNext1 => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[2]/div/form/div[3]/div/div[2]/button"));
        public IWebElement selectEmailValue => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[2]/div/form/div[2]/div/div/div[1]"));
        public IWebElement loginNext2 => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[2]/div/form/div[4]/div/div[2]/button"));
        public IWebElement cancelLogin => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div/div[2]/div/form/div[4]/div/div[1]/button"));
        public IWebElement cancelRateMeeting => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div/div[2]/button"));

        public void LoginForm(string email)
        {
            loginToEmail.Click();
            loginToEmail.SendKeys(email);
            loginNext.Click();
            System.Threading.Thread.Sleep(2000);
            selectEmailValue.Click();
            System.Threading.Thread.Sleep(2000);
            loginNext1.Click();
            System.Threading.Thread.Sleep(2000);
            loginNext2.Click();
            //System.Threading.Thread.Sleep(2000);
            //cancelRateMeeting.Click();

        }

        
    }
}
