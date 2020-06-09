using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context.SummitsClasses
{
    public class NextSummitMeetings
    {
        public IWebElement meetingsButton => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div[1]/div/div/div/div/div[1]/div[2]"));
        public IWebElement receivedMeetings => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div[3]/div[2]/div[2]/div[1]/div/div/label[1]"));
        public IWebElement confirmedMeetings => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div[3]/div[2]/div[2]/div[1]/div/div/label[2]"));
        public IWebElement sentMeetings => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div[3]/div[2]/div[2]/div[1]/div/div/label[3]"));
        public IWebElement declinedMeetings => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div[3]/div[2]/div[2]/div[1]/div/div/label[4]"));
        public IWebElement declineAll => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div[3]/div[2]/div[2]/div[2]/div[3]/div[1]/div[2]/div/div/div[2]/div[1]/button"));
        public IWebElement searchReceivedMeetingsField => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div[3]/div[2]/div[2]/div[2]/div[3]/div[1]/div[2]/div/div/div[2]/div[2]/span/input"));
        public IWebElement cancelSearchReceivedMeetingsBtn => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div[3]/div[2]/div[2]/div[2]/div[3]/div[1]/div[2]/div/div/div[2]/div[2]/span/span/i[1]"));
        public IWebElement searchReceivedMeetingsBtn => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div[3]/div[2]/div[2]/div[2]/div[3]/div[1]/div[2]/div/div/div[2]/div[2]/span/span/i[2]"));
        public IWebElement searchConfirmedMeetingsField => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div[3]/div[2]/div[2]/div[2]/div[3]/div[2]/div[2]/div[2]/div/div[1]/div[2]/span/input"));
        public IWebElement cancelSearchConfirmedMeetingsBtn => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div[3]/div[2]/div[2]/div[2]/div[3]/div[2]/div[2]/div[2]/div/div[1]/div[2]/span/span/i[1]"));
        public IWebElement searchConfirmedMeetingsBtn => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div[3]/div[2]/div[2]/div[2]/div[3]/div[2]/div[2]/div[2]/div/div[1]/div[2]/span/span/i[2]"));
        public IWebElement searchSentMeetingsField => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div[3]/div[2]/div[2]/div[2]/div[3]/div[3]/div[2]/div/div/div[1]/div[2]/span/input"));
        public IWebElement cancelSearchSentMeetingsBtn => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div[3]/div[2]/div[2]/div[2]/div[3]/div[3]/div[2]/div/div/div[1]/div[2]/span/span/i[1]"));
        public IWebElement searchSentMeetingsBtn => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div[3]/div[2]/div[2]/div[2]/div[3]/div[3]/div[2]/div/div/div[1]/div[2]/span/span/i[2]"));
        public IWebElement searchDeclinedMeetingsField => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div[3]/div[2]/div[2]/div[2]/div[3]/div[4]/div[2]/div/div/div[1]/div[2]/span/input"));
        public IWebElement cancelSearchDeclinedMeetingsBtn => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div[3]/div[2]/div[2]/div[2]/div[3]/div[4]/div[2]/div/div/div[1]/div[2]/span/span/i[1]"));
        public IWebElement searchDeclinedMeetingsBtn => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div[3]/div[2]/div[2]/div[2]/div[3]/div[4]/div[2]/div/div/div[1]/div[2]/span/span/i[2]"));
        public IWebElement acceptMeetingRequest => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div[3]/div[2]/div[2]/div[2]/div[3]/div[1]/div[2]/div/div/div[3]/div/div/div/div/div/table/tbody/tr[1]/td[5]/div/button[1]"));
        public IWebElement declineMeetingRequest => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div[3]/div[2]/div[2]/div[2]/div[3]/div[1]/div[2]/div/div/div[3]/div/div/div/div/div/table/tbody/tr[1]/td[5]/div/button[2]"));
        public IWebElement viewMeetingRequest => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div[3]/div[2]/div[2]/div[2]/div[3]/div[1]/div[2]/div/div/div[3]/div/div/div/div/div/table/tbody/tr[1]/td[2]/div/a"));
        public IWebElement acceptMeetingRequestInside => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div/div[2]/div/div[1]/div[3]/button[1]"));
        public IWebElement declineMeetingRequestInside => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div/div[2]/div/div[1]/div[3]/button[2]"));
        public IWebElement showPreviousMessageOrLess => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div/div[2]/div/div[4]/div[1]/div/div[1]/div[2]/button"));
        public IWebElement profileOnMeetingRequest => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div/div[2]/div/div[4]/div[2]/div[1]/div/div/div/div/div[1]/div[1]"));
        public IWebElement detailsOnMeetingRequest => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div/div[2]/div/div[4]/div[2]/div[1]/div/div/div/div/div[1]/div[2]")); 
        public IWebElement sendReplyOnMeetingRequest => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div/div[2]/div/div[4]/div[1]/div/div[2]/div[2]/button"));
        public IWebElement messageField => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div/div[2]/div/div[4]/div[1]/div/div[2]/div[1]/textarea"));
        public IWebElement goBackToMeetings => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div/div[1]/button"));
        public IWebElement rescheduleMeeting => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div[3]/div[2]/div[2]/div[2]/div[3]/div[2]/div[2]/div[2]/div/div[2]/div/div/div/div/div/table/tbody/tr/td[6]/div/button[1]"));
        public IWebElement cancelMeeting => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div[3]/div[2]/div[2]/div[2]/div[3]/div[2]/div[2]/div[2]/div/div[2]/div/div/div/div/div/table/tbody/tr/td[6]/div/button[2]"));
        public IWebElement exitRescheduleMeeting => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div/div[2]/button"));
        public IWebElement selectTimezoneDdl => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div/div[2]/div[2]/div/div/div/div[2]/div[1]/div/div/div[2]/div"));
        public IWebElement selectTimezoneValue => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div/div[2]/div[2]/div/div/div/div[2]/div[1]/div/div/div[1]/div[1]"));
        public IWebElement cancelMeetingInside => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div/div[2]/div[3]/div/button[1]"));
        public IWebElement saveRescheduleMeeting => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div/div[2]/div[3]/div/button[1]"));
        public IWebElement viewConfirmedMeeting => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div[3]/div[2]/div[2]/div[2]/div[3]/div[2]/div[2]/div[2]/div/div[2]/div/div/div/div/div/table/tbody/tr/td[1]/div/a"));
        public IWebElement sendMessageToConfirmedMeeting => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div/div[2]/div/div[1]/div[3]/button[1]"));
        public IWebElement rescheduleMeetingInside => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div/div[2]/div/div[1]/div[3]/button[2]"));
        public IWebElement cancelScheduledMeetingInside => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div/div[2]/div/div[1]/div[3]/button[3]"));
        public IWebElement profileScheduledMeetingInside => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div/div[2]/div/div[4]/div/div[1]/div/div/div/div/div[1]/div[1]"));
        public IWebElement detailsScheduledMeetingInside => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div/div[2]/div/div[4]/div/div[1]/div/div/div/div/div[1]/div[2]"));
        public IWebElement goBackFromScheduledMeetingInside => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div/div[1]/button"));
        public IWebElement viewDeclinedMeeting => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div[3]/div[2]/div[2]/div[2]/div[3]/div[4]/div[2]/div/div/div[2]/div/div/div/div/div/table/tbody/tr[1]/td[1]/a"));
        public IWebElement profileDeclinedMeetingInside => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div/div[2]/div/div[4]/div[2]/div[1]/div/div/div/div/div[1]/div[1]"));
        public IWebElement detailsDeclinedMeetingInside => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div/div[2]/div/div[4]/div[2]/div[1]/div/div/div/div/div[1]/div[2]"));
        public IWebElement goBackFromDeclinedMeetingInside => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div/div[1]/button"));


        




    }
}
