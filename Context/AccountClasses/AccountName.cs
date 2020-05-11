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
        public AccountName()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div/div[1]/div[2]/div/div[2]/div")]
        public IWebElement toSwitchCompanies { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div/div[2]/div[2]/a[1]")]
        public IWebElement toPersonalSettings { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div/div[2]/div[2]/a[2]")]
        public IWebElement toCompanySettings { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div/div[2]/div[2]/a[3]")]
        public IWebElement toNotificationsSettings { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div/div[2]/div[2]/button")]
        public IWebElement toLogout { get; set; }


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
