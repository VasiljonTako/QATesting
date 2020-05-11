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
        
        public Dashboard()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
           
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/aside/div/div[1]/ul/li[1]/a")]
        public IWebElement toDashboard { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/section/aside/div/div[1]/ul/li[2]/a")]
        public IWebElement toMeetings { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/section/aside/div/div[1]/ul/li[3]/a")]
        public IWebElement toMessages { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/section/aside/div/div[1]/ul/li[4]/a")]
        public IWebElement toSummits { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/section/aside/div/div[1]/ul/li[5]/a")]
        public IWebElement toCompany { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/section/aside/div/div[2]/div")]
        public IWebElement toAccountName { get; set; }
                                           
        [FindsBy(How = How.XPath, Using = "/html/body/div/section/section/header/div/div[2]/div/div[1]/a")]
        public IWebElement toSettings { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/header/div/div[2]/div/div[2]/a")]
        public IWebElement toMessagesNtfc { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/header/div/div[2]/div/div[3]/span")]
        public IWebElement toNotifications { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div[1]/div[1]/div/div[1]/button")]
        public IWebElement meetingsStatsDdl { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/ul/li[3]")]
        public IWebElement meetingsStatsDdlSelect { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/section/section/main/div/div[2]/div[1]/div[2]/div[2]/div/button")]
        public IWebElement toNextSummit { get; set; }   


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

        public void SummitsForm()
        {
            toSummits.Click();
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
            //meetingsStatsDdl.SelectDropdownList(2);
            System.Threading.Thread.Sleep(1000);
            meetingsStatsDdl.Click();

            System.Threading.Thread.Sleep(1000);
            meetingsStatsDdlSelect.Click();
        }

        public void NextSummitForm()
        {
            toNextSummit.Click();
        }

    }
}
