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
        public NotificationsSettings()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div/section/section/main/div/div/div/div[1]/div[3]/div[1]/div/div[1]/button")]
        public IWebElement toNtfcTransactionalEmail { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/section/section/main/div/div/div/div[1]/div[3]/div[1]/div/div[3]/div[1]/div[1]/button")]
        public IWebElement toNtfcNewMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/section/section/main/div/div/div/div[1]/div[3]/div[1]/div/div[3]/div[2]/div[1]/button")]
        public IWebElement toNtfcMeetingAutomaticallyAccepted { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/section/section/main/div/div/div/div[1]/div[3]/div[1]/div/div[3]/div[3]/div[1]/button")]
        public IWebElement toNtfcMeetingScheduled { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/section/section/main/div/div/div/div[1]/div[3]/div[1]/div/div[3]/div[4]/div[1]/button")]
        public IWebElement toNtfcMeetingDeclined { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/section/section/main/div/div/div/div[1]/div[3]/div[1]/div/div[3]/div[5]/div[1]/button")]
        public IWebElement toNtfcMeetingCanceled { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/section/section/main/div/div/div/div[1]/div[3]/div[1]/div/div[3]/div[6]/div[1]/button")]
        public IWebElement toNtfcMeetingUpdated { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/section/section/main/div/div/div/div[1]/div[3]/div[1]/div/div[3]/div[7]/div[1]/button")]
        public IWebElement toNtfcMeetingConfirmed { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/section/section/main/div/div/div/div[1]/div[3]/div[1]/div/div[3]/div[8]/div[1]/button")]
        public IWebElement toNtfcMeetingRequested { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/section/section/main/div/div/div/div[1]/div[3]/div[1]/div/div[3]/div[9]/div[1]/button")]
        public IWebElement toNtfcNewAlert { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/section/section/main/div/div/div/div[1]/div[3]/div[2]/div/div[1]/button")]
        public IWebElement toNtfcBatchEmail { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/section/section/main/div/div/div/div[1]/div[3]/div[2]/div/div[3]/div[1]/div[1]/button")]
        public IWebElement toBNtfcMeetingScheduled { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/section/section/main/div/div/div/div[1]/div[3]/div[2]/div/div[3]/div[2]/div[1]/button")]
        public IWebElement toBNtfcMeetingDeclined { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/section/section/main/div/div/div/div[1]/div[3]/div[2]/div/div[3]/div[3]/div[1]/button")]
        public IWebElement toBNtfcMeetingCanceled { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/section/section/main/div/div/div/div[1]/div[3]/div[2]/div/div[3]/div[4]/div[1]/button")]
        public IWebElement toBNtfcMeetingUpdated { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/section/section/main/div/div/div/div[1]/div[3]/div[2]/div/div[3]/div[5]/div[1]/button")]
        public IWebElement toBNtfcMeetingConfirmed { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/section/section/main/div/div/div/div[1]/div[3]/div[2]/div/div[3]/div[6]/div[1]/button")]
        public IWebElement toBNtfcMeetingRequested { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/section/section/main/div/div/div/div[1]/div[3]/div[2]/div/div[3]/div[7]/div[1]/button")]
        public IWebElement toBNtfcMeetingAutomaticallyAccepted { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/section/section/main/div/div/div/div[1]/div[3]/div[2]/div/div[3]/div[8]/div[1]/button")]
        public IWebElement toBNtfcNewMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/section/section/main/div/div/div/div[1]/div[3]/div[2]/div/div[3]/div[9]/div[1]/button")]
        public IWebElement toBNtfcNewAlert { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/section/section/main/div/div/div/div[2]/div[3]/div/div[1]/button")]
        public IWebElement toNtfcPushNotifications { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div/div[2]/div[3]/div/div[3]/div[1]/div[1]/button")]
        public IWebElement toPNtfcMeetingRequested { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div/div[2]/div[3]/div/div[3]/div[2]/div[1]/button")]
        public IWebElement toPNtfcNewMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div/div[2]/div[3]/div/div[3]/div[3]/div[1]/button")]
        public IWebElement toPNtfcMeetingAutomaticallyAccepted { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div/div[2]/div[3]/div/div[3]/div[4]/div[1]/button")]
        public IWebElement toPNtfcMeetingScheduled { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div/div[2]/div[3]/div/div[3]/div[5]/div[1]/button")]
        public IWebElement toPNtfcMeetingDeclined { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div/div[2]/div[3]/div/div[3]/div[6]/div[1]/button")]
        public IWebElement toPNtfcMeetingCanceled { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div/div[2]/div[3]/div/div[3]/div[7]/div[1]/button")]
        public IWebElement toPNtfcMeetingUpdated { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div/div[2]/div[3]/div/div[3]/div[8]/div[1]/button")]
        public IWebElement toPNtfcMeetingConfirmed { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div/div[2]/div[3]/div/div[3]/div[9]/div[1]/button")]
        public IWebElement toPNtfcNewAlert { get; set; }


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
