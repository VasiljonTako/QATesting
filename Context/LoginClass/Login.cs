using Context.DashboardClasses;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    class Login
    {
        //public Login()
       // {
         //   PageFactory.InitElements(PropertiesCollection.driver, this);
        //}

        //[FindsBy(How= How.XPath, Using = IWebElement loginToEmail]
        //public IWebElement loginToEmail { get; set; }

        //[FindsBy(How = How.XPath, Using = "/html/body/div/div/div[2]/div/div[2]/div/form/div[2]/div/div[2]/button")]
        //public IWebElement loginNext { get; set; }

        //[FindsBy(How = How.XPath, Using = "/html/body/div/div/div[2]/div/div[2]/div/form/div[4]/div/div[2]/button")]
        //public IWebElement loginNext1 { get; set; }        

        //[FindsBy(How = How.XPath, Using = "/html/body/div/div/div[2]/div/div[2]/div/form/div[2]/div/div/div[1]")]
        //public IWebElement selectEmailValue { get; set; }

        //[FindsBy(How = How.XPath, Using = "/html/body/div/div/div[2]/div/div[2]/div/form/div[4]/div/div[1]/button")]
        //public IWebElement cancelLogin { get; set; }


        public IWebElement loginToEmail => PropertiesCollection.driver.FindElement(By.Name("email"));
        public IWebElement loginNext => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/form/div[2]/div/div[2]/button"));
        public IWebElement loginNext1 => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[2]/div/form/div[4]/div/div[2]/button"));

        public void LoginForm(string email)
        {
            loginToEmail.Click();
            loginToEmail.SendKeys(email);
            //rememberMe.Click();
            loginNext.Click();
            System.Threading.Thread.Sleep(2000);
            //selectEmailValue.Click();
            System.Threading.Thread.Sleep(2000);
            //loginNext1.Click();;
            //loginNext2.Click();
            //System.Threading.Thread.Sleep(1000);


        }
    }
}
