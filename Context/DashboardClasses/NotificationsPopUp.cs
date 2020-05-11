using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context.DashboardClasses
{
    public class NotificationsPopUp
    {
        public NotificationsPopUp()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }       

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div/div[1]/div/button[2]")]
        public IWebElement toPopUpNotificationsSettings { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div/div[1]/div/button[1]")]
        public IWebElement toPopUpMarkAllAsRead { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div/div[2]/div[1]/div[2]/div/div/div/div[1]/div[2]/span/span[1]")]
        public IWebElement toPopUpMeetings { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div/div[2]")]
        public IWebElement toPopUpMeetings1 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div/div[2]/div[1]/div[2]/div/div/div/div[1]/div[1]/button")]
        public IWebElement toPopUpMarkMeetingAsRead { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div/div[3]/button")]
        public IWebElement toPopUpShowAllNtfc { get; set; }

        public void PopUpNotificationsSettings()
        {
            toPopUpNotificationsSettings.Click();
        }

        public void PopUpMarkAllAsRead()
        {
            toPopUpMarkAllAsRead.Click();
        }

        public void PopUpMeetings()
        {
            toPopUpMeetings.Click();
        }

        public void PopUpMarkMeetingAsRead()
        {
            toPopUpMarkMeetingAsRead.Click();
        }

        public void PopUpShowAllNotifications()
        {
            toPopUpShowAllNtfc.Click();
        }

    }
}
