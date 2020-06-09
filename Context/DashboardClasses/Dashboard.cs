using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    public class Dashboard
    {

        public IWebElement toDashboard => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/aside/div/div[1]/ul/li[1]"));
        public IWebElement toMeetings => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/aside/div/div[1]/ul/li[2]"));
        public IWebElement toMessages => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/aside/div/div[1]/ul/li[3]"));
        public IWebElement toCalendar => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/aside/div/div[1]/ul/li[4]"));
        public IWebElement toSummits => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/aside/div/div[1]/ul/li[5]"));
        public IWebElement toContent => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/aside/div/div[1]/ul/li[6]"));
        public IWebElement toCompany => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/aside/div/div[1]/ul/li[7]"));
        public IWebElement toAccountName => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/aside/div/div[2]/div"));
        public IWebElement toSettings => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/header/div/div[2]/div/div[1]/a"));
        public IWebElement toCalendarNtfc => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/header/div/div[2]/div/div[2]/a"));
        public IWebElement toMessagesNtfc => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/header/div/div[2]/div/div[3]/a"));
        public IWebElement toNotifications => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/header/div/div[2]/div/div[4]/span"));
        public IWebElement meetingsStatsDdl => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div[1]/div[1]/div/div[1]/button"));
        public IWebElement meetingsStatsDdlSelect => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[3]/button"));
        public IWebElement toNextSummit => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div[2]/div[1]/div[2]/div[2]/div/button"));
        public IWebElement toPrivacyPolicy => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/footer/div/a[1]"));
        public IWebElement toTermsOfUse => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/footer/div/a[2]"));
        public IWebElement toEventRegistration => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/footer/div/a[3]"));
        public IWebElement toSubscriptionAndSeviceAgreement => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/footer/div/a[4]"));


        public void DashboardForm()
        {
            toDashboard.Click();
        }

        public void MettingsForm()
        {
            toMeetings.Click();
        }

        public void MessagesForm()
        {
            toMessages.Click();
        }

        public void CalendarForm()
        {
            toCalendar.Click();
        }

        public void SummitsForm()
        {
            toSummits.Click();
        }

        public void ContentForm()
        {
            toContent.Click();
        }

        public void CompanyForm()
        {
            toCompany.Click();
        }

        public void AccountNameForm()
        {
            toAccountName.Click();
        }

        public void toSettingsForm()
        {
            toSettings.Click();
        }

        public void CalendarNtfcForm()
        {
            toCalendarNtfc.Click();
        }

        public void MessagesNtfcForm()
        {
            toMessagesNtfc.Click();
        }

        public void NotificationsForm()
        {
            toNotifications.Click();
        }

        public void MeetingsStats()
        {
            System.Threading.Thread.Sleep(1000);
            meetingsStatsDdl.Click();

            System.Threading.Thread.Sleep(1000);
            meetingsStatsDdlSelect.Click();
        }

        public void NextSummitForm()
        {
            System.Threading.Thread.Sleep(2000);
            toNextSummit.Click();
        }

        public void PrivacyPolicyForm()
        {
            toPrivacyPolicy.Click();
        }

        public void TermsOfUseForm()
        {
            toTermsOfUse.Click();
        }

        public void EventRegistrationForm()
        {
            toEventRegistration.Click();
        }

        public void SubscriptionAndSeviceAgreementForm()
        {
            toSubscriptionAndSeviceAgreement.Click();
        }

    }
}
