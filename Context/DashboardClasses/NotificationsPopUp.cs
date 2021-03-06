﻿using OpenQA.Selenium;
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

        public IWebElement toPopUpNotificationsSettings => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div[1]/div/button[2]"));
        public IWebElement toPopUpMarkAllAsRead => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div[1]/div/button[1]"));
        public IWebElement toPopUpMeetings => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div[2]/div[1]/div[2]/div/div/div/div[1]/div[2]/span/span[1]"));
        public IWebElement toPopUpMeetings1 => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div[2]"));
        public IWebElement toPopUpMarkMeetingAsRead => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div[2]/div[1]/div[2]/div/div/div/div[1]/div[1]/button"));
        public IWebElement toPopUpShowAllNtfc => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div[3]/button"));
        public IWebElement AllNtfcGoBack => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div[1]/div[1]/button"));
        public IWebElement AllNtfcNextPage => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/ul/li[4]/a"));
        public IWebElement AllNtfcLastPage => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/ul/li[1]/a"));
        public IWebElement AllNtfcMarkAllAsRead => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div[1]/div[2]/button[1]"));
        public IWebElement AllNtfcSettings => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div[1]/div[2]/button[1]"));





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

        public void AllNtfcGoBackForm()
        {
            AllNtfcGoBack.Click();
        }

        public void AllNtfcNextPageForm()
        {
            AllNtfcNextPage.Click();
        }

        public void AllNtfcLastPageForm()
        {
            AllNtfcLastPage.Click();
        }

        public void AllNtfcMarkAllAsReadForm()
        {
            AllNtfcMarkAllAsRead.Click();
        }

        public void AllNtfcSettingsForm()
        {
            AllNtfcSettings.Click();
        }

    }
}
