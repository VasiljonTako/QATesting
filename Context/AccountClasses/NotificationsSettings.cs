using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context.AccountClasses
{
    public class NotificationsSettings
    {

        public IWebElement toNtfcTransactionalEmail => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div/div[1]/div[3]/div[1]/div/div[1]/button"));
        public IWebElement toNtfcNewMessage => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div/div[1]/div[3]/div[1]/div/div[3]/div[1]/div[1]/button"));
        public IWebElement toNtfcMeetingAutomaticallyAccepted => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div/div[1]/div[3]/div[1]/div/div[3]/div[1]/div[1]/button"));
        public IWebElement toNtfcMeetingScheduled => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div/div[1]/div[3]/div[1]/div/div[3]/div[3]/div[1]/button"));
        public IWebElement toNtfcMeetingDeclined => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div/div[1]/div[3]/div[1]/div/div[3]/div[4]/div[1]/button"));
        public IWebElement toNtfcMeetingCanceled => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div/div[1]/div[3]/div[1]/div/div[3]/div[5]/div[1]/button"));
        public IWebElement toNtfcMeetingUpdated => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div/div[1]/div[3]/div[1]/div/div[3]/div[6]/div[1]/button"));
        public IWebElement toNtfcMeetingConfirmed => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div/div[1]/div[3]/div[1]/div/div[3]/div[7]/div[1]/button"));
        public IWebElement toNtfcMeetingRequested => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div/div[1]/div[3]/div[1]/div/div[3]/div[8]/div[1]/button"));
        public IWebElement toNtfcNewAlert => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div/div[1]/div[3]/div[1]/div/div[3]/div[9]/div[1]/button"));
        public IWebElement toNtfcBatchEmail => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div/div[1]/div[3]/div[2]/div/div[1]/button"));
        public IWebElement toBNtfcMeetingScheduled => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div/div[1]/div[3]/div[2]/div/div[3]/div[1]/div[1]/button"));
        public IWebElement toBNtfcMeetingDeclined => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div/div[1]/div[3]/div[2]/div/div[3]/div[2]/div[1]/button"));
        public IWebElement toBNtfcMeetingCanceled => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div/div[1]/div[3]/div[2]/div/div[3]/div[3]/div[1]/button"));
        public IWebElement toBNtfcMeetingUpdated => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div/div[1]/div[3]/div[2]/div/div[3]/div[4]/div[1]/button"));
        public IWebElement toBNtfcMeetingConfirmed => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div/div[1]/div[3]/div[2]/div/div[3]/div[5]/div[1]/button"));
        public IWebElement toBNtfcMeetingRequested => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div/div[1]/div[3]/div[2]/div/div[3]/div[6]/div[1]/button"));
        public IWebElement toBNtfcMeetingAutomaticallyAccepted => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div/div[1]/div[3]/div[2]/div/div[3]/div[7]/div[1]/button"));
        public IWebElement toBNtfcNewMessage => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div/div[1]/div[3]/div[2]/div/div[3]/div[8]/div[1]/button"));
        public IWebElement toBNtfcNewAlert => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div/div[1]/div[3]/div[2]/div/div[3]/div[9]/div[1]/button"));
        public IWebElement toNtfcPushNotifications => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div/div[2]/div[3]/div/div[1]/button"));
        public IWebElement toPNtfcMeetingRequested => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div/div[2]/div[3]/div/div[3]/div[1]/div[1]/button"));
        public IWebElement toPNtfcNewMessage => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div/div[2]/div[3]/div/div[3]/div[2]/div[1]/button"));
        public IWebElement toPNtfcMeetingAutomaticallyAccepted => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div/div[2]/div[3]/div/div[3]/div[3]/div[1]/button"));
        public IWebElement toPNtfcMeetingScheduled => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div/div[2]/div[3]/div/div[3]/div[4]/div[1]/button"));
        public IWebElement toPNtfcMeetingDeclined => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div/div[2]/div[3]/div/div[3]/div[5]/div[1]/button"));
        public IWebElement toPNtfcMeetingCanceled => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div/div[2]/div[3]/div/div[3]/div[6]/div[1]/button"));
        public IWebElement toPNtfcMeetingUpdated => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div/div[2]/div[3]/div/div[3]/div[7]/div[1]/button"));
        public IWebElement toPNtfcMeetingConfirmed => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div/div[2]/div[3]/div/div[3]/div[8]/div[1]/button"));
        public IWebElement toPNtfcNewAlert => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div/div[2]/div[3]/div/div[3]/div[9]/div[1]/button"));


        public void NtfcTransactionalEmailForm()
        {
            toNtfcTransactionalEmail.Click();
        }

        public void NtfcNewMessageForm()
        {
            toNtfcNewMessage.Click();
        }

        public void NtfcMeetingAutomaticallyAcceptedForm()
        {
            toNtfcMeetingAutomaticallyAccepted.Click();
        }

        public void NtfcMeetingScheduledForm()
        {
            toNtfcMeetingScheduled.Click();
        }

        public void NtfcMeetingDeclinedForm()
        {
            toNtfcMeetingDeclined.Click();
        }

        public void NtfcMeetingCanceledForm()
        {
            toNtfcMeetingCanceled.Click();
        }

        public void NtfcMeetingUpdatedForm()
        {
            toNtfcMeetingUpdated.Click();
        }

        public void NtfcMeetingConfirmedForm()
        {
            toNtfcMeetingConfirmed.Click();
        }

        public void NtfcMeetingRequestedForm()
        {
            toNtfcMeetingRequested.Click();
        }

        public void NtfcNewAlertForm()
        {
            toNtfcNewAlert.Click();
        }

        public void NtfcBatchEmailForm()
        {
            toNtfcBatchEmail.Click();
        }

        public void BNtfcMeetingScheduledForm()
        {
            toBNtfcMeetingScheduled.Click();
        }

        public void BNtfcMeetingDeclinedForm()
        {
            toBNtfcMeetingDeclined.Click();
        }

        public void BNtfcMeetingCanceledForm()
        {
            toBNtfcMeetingCanceled.Click();
        }

        public void BNtfcMeetingUpdatedForm()
        {
            toBNtfcMeetingUpdated.Click();
        }

        public void BNtfcMeetingConfirmedForm()
        {
            toBNtfcMeetingConfirmed.Click();
        }

        public void BNtfcMeetingRequestedForm()
        {
            toBNtfcMeetingRequested.Click();
        }

        public void BNtfcMeetingAutomaticallyAcceptedForm()
        {
            toBNtfcMeetingAutomaticallyAccepted.Click();
        }


        public void BNtfcNewMessageForm()
        {
            toBNtfcNewMessage.Click();
        }

        public void BNtfcNewAlertForm()
        {
            toBNtfcNewAlert.Click();
        }

        public void NtfcPushNotificationsForm()
        {
            toNtfcPushNotifications.Click();
        }

        public void PNtfcMeetingRequestedForm()
        {
            toPNtfcMeetingRequested.Click();
        }

        public void PNtfcNewMessageForm()
        {
            toPNtfcNewMessage.Click();
        }

        public void PNtfcMeetingAutomaticallyAcceptedForm()
        {
            toPNtfcMeetingAutomaticallyAccepted.Click();
        }

        public void PNtfcMeetingScheduledForm()
        {
            toPNtfcMeetingScheduled.Click();
        }

        public void PNtfcMeetingDeclinedForm()
        {
            toPNtfcMeetingDeclined.Click();
        }

        public void PNtfcMeetingCanceledForm()
        {
            toPNtfcMeetingCanceled.Click();
        }

        public void PNtfcMeetingUpdatedForm()
        {
            toPNtfcMeetingUpdated.Click();
        }

        public void PNtfcMeetingConfirmedForm()
        {
            toPNtfcMeetingConfirmed.Click();
        }

        public void PNtfcNewAlertForm()
        {
            toPNtfcNewAlert.Click();
        }



    }
}
