using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context.SummitsClasses
{
    public class NextSummitSchedule
    {

        public IWebElement firstDayOfSummit => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div[3]/div[3]/div[2]/div/div/div[1]/div/div/div/div/label[1]"));
        public IWebElement secondDayOfSummit => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div[3]/div[3]/div[2]/div/div/div[1]/div/div/div/div/label[2]"));
        public IWebElement thirdDayOfSummit => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div[3]/div[3]/div[2]/div/div/div[1]/div/div/div/div/label[3]"));
        public IWebElement exportMeetingContactDetails => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div[3]/div[3]/div[2]/div/div/div[2]/div[1]/button"));
        public IWebElement makeHourUnavailableFirstDay => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div[3]/div[3]/div[2]/div/div/div[2]/div[2]/div[3]/div[1]/div[2]/div/div/div/div/div/div/div/div/table/tbody/tr[1]/td[4]/button"));
        public IWebElement makeHourUnavailableFirstDay1 => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div[3]/div[3]/div[2]/div/div/div[2]/div[2]/div[3]/div[1]/div[2]/div/div/div/div/div/div/div/div/table/tbody/tr[2]/td[4]/button"));
        public IWebElement makeHourUnavailableSecondDay => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div[3]/div[3]/div[2]/div/div/div[2]/div[2]/div[3]/div[2]/div[2]/div/div/div/div/div/div/div/div/table/tbody/tr[1]/td[4]/button"));
        public IWebElement makeHourUnavailableThirdDay => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div/section/section/main/div/div/div[3]/div[3]/div[2]/div/div/div[2]/div[2]/div[3]/div[3]/div[2]/div/div/div/div/div/div/div/div/table/tbody/tr[4]/td[4]/button"));
        
        


        public void MakeSomeHoursUnavailable()
        {
            makeHourUnavailableFirstDay.Click();
            secondDayOfSummit.Click();
            makeHourUnavailableSecondDay.Click();
            thirdDayOfSummit.Click();
            makeHourUnavailableThirdDay.Click();
            firstDayOfSummit.Click();
            makeHourUnavailableFirstDay1.Click();
        }

    }
}

