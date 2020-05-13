using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    public class AccountName
    {

        public IWebElement toSwitchCompanies => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[3]/div/div/div/div[1]/div[2]/div/div[2]"));
        public IWebElement toPersonalSettings => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[3]/div/div/div/div[2]/div[2]/a[1]/div/button"));
        public IWebElement toCompanySettings => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[3]/div/div/div/div[2]/div[2]/a[2]/div/button"));
        public IWebElement toNotificationsSettings => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[3]/div/div/div/div[2]/div[2]/a[3]/div/button"));
        public IWebElement toLogout => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[3]/div/div/div/div[2]/div[2]/button"));


        public void SwitchCompaniesForm()
        {
            toSwitchCompanies.Click();
        }

        public void PersonalSettingsForm()
        {
            toPersonalSettings.Click();
        }

        public void CompanySettingsForm()
        {
            toCompanySettings.Click();
        }

        public void NotificationsSettingsForm()
        {
            toNotificationsSettings.Click();
        }

        public void LogoutForm()
        {
            toLogout.Click();
        }
    }
}
