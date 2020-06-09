using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context.CalendarClasses
{
   public class Calendar
    {

        public IWebElement Month => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div[1]/div[1]/div/div/div/label[1]"));
        public IWebElement Week => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div[1]/div[1]/div/div/div/label[2]"));
        public IWebElement Day => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div[1]/div[1]/div/div/div/label[3]"));
        public IWebElement MyMeetings => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div[2]/div[1]/div[2]/div/label[1]/span[1]/input"));
        public IWebElement CompanyMeetings => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div[2]/div[1]/div[2]/div/label[2]/span[1]/input"));
        public IWebElement SelectDate => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div[2]/div[1]/div[1]/span/div/input"));
        public IWebElement NextYear => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[5]/div/div/div/div/div/div/div[2]/div/div[1]/a[3]"));
        public IWebElement LastYear => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[5]/div/div/div/div/div/div/div[2]/div/div[1]/a[1]"));
        public IWebElement SelectYear => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[5]/div/div/div/div/div/div/div[2]/div/div[1]/a[2]"));
        public IWebElement June => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[5]/div/div/div/div/div/div/div[2]/div/div[2]/table/tbody/tr[2]/td[3]/a"));
        public IWebElement MeetingOnCalendar => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div[2]/div[2]/div/div/div[2]/div/table/tbody/tr/td/div/div/div[1]/div[2]/table/tbody/tr/td[4]/a"));
        public IWebElement MeetingOnCalendar2 => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div[2]/div[2]/div/div/div[2]/div/table/tbody/tr/td/div/div/div[1]/div[2]/table/tbody/tr/td[5]/a"));

        
        public void MonthForm()
        {
            Month.Click();
        }

        public void WeekForm()
        {
            Week.Click();
        }

        public void DayForm()
        {
            Day.Click();
        }

        public void MyMeetingsForm()
        {
            MyMeetings.Click();
        }

        public void CompanyMeetingForm()
        {
            CompanyMeetings.Click();
        }

        public void JuneForm()
        {
            June.Click();
        }

        public void MeetingOnCalendarForm()
        {
            MeetingOnCalendar.Click();
        }

        public void MeetingOnCalendar2Form()
        {
            MeetingOnCalendar2.Click();
        }

    }
}
