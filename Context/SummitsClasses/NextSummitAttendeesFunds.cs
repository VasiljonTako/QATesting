using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    public class NextSummit
    {
        public NextSummit()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div[1]/div/div/div/div/div[1]/div[1]")]
        public IWebElement attendeesBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div[1]/div/div/div/div/div[1]/div[2]")]
        public IWebElement meetingsBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div[1]/div/div/div/div/div[1]/div[3]")]
        public IWebElement scheduleBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div[1]/div/div/div/div/div[1]/div[4]")]
        public IWebElement agendaBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div[3]/div[1]/div[2]/div/div/label[1]")]
        public IWebElement fundsBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div[3]/div[1]/div[2]/div/div/label[2]")]
        public IWebElement serviceProvidersBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div[3]/div[1]/div[2]/div/div/label[3]")]
        public IWebElement contextBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div[3]/div[1]/div[3]/div[3]/div[1]/header/div/div[2]/span/span/i[2]")]
        public IWebElement searchInFundsBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div[3]/div[1]/div[3]/div[3]/div[1]/header/div/div[2]/span/input")]
        public IWebElement searchInFundsField { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div[3]/div[1]/div[3]/div[3]/div[1]/header/div/div[2]/span/span/i[1]")]
        public IWebElement cancelSearchInFundsBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div[3]/div[1]/div[3]/div[3]/div[1]/header/div/div[2]/button[1]")]
        public IWebElement customizeColumnsBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div[3]/div[1]/div[3]/div[3]/div[1]/header/div/div[2]/button[2]")]
        public IWebElement showFavouriteFundsBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div[3]/div[1]/div[3]/div[3]/div[1]/header/div/div[2]/button[2]")]
        public IWebElement sortByFundNameBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div[3]/div[1]/div[3]/div[3]/div[1]/div[3]/div/div/div/div/div/div[1]/div[2]/div[1]/table/thead/tr/th[3]/i")]
        public IWebElement FilterMenuBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[15]/div/div/div/ul/li[1]")]
        public IWebElement FilterPendingBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[15]/div/div/div/ul/li[2]")]
        public IWebElement FilterConfirmedBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[15]/div/div/div/ul/li[3]")]
        public IWebElement FilterDeclinedBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[15]/div/div/div/ul/li[4]")]
        public IWebElement FilterCancelledBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[15]/div/div/div/div/a[1]")]
        public IWebElement FilterOkBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[15]/div/div/div/div/a[2]")]
        public IWebElement FilterResetBtn { get; set; }




        public void goToAttendees()
        {
            attendeesBtn.Click();
        }

        public void goToMeetings()
        {
            meetingsBtn.Click();
        }

        public void goToSchedule()
        {
            scheduleBtn.Click();
        }

        public void goToAgenda()
        {
            agendaBtn.Click();
        }

        public void goToFunds()
        {
           fundsBtn.Click();
        }

        public void goToServiceProviders()
        {
            serviceProvidersBtn.Click();
        }

        public void SearchInFunds(string SearchWord)
        {
            searchInFundsField.SendKeys(SearchWord);
            System.Threading.Thread.Sleep(3000);
            searchInFundsBtn.Click();
        }

        public void CancelSearchInFunds(string CancelSearchWord)
        {
            searchInFundsField.SendKeys(CancelSearchWord);
            System.Threading.Thread.Sleep(3000);
            cancelSearchInFundsBtn.Click();
        }

        public void CustomizeColumns()
        {
            customizeColumnsBtn.Click();
        }

        public void showFavouriteFunds()
        {
            showFavouriteFundsBtn.Click();
        }

        public void sortByFundName()
        {
            sortByFundNameBtn.Click();
        }

        public void FilterMenu()
        {
            FilterMenuBtn.Click();
        }

        public void FilterPending()
        {
            FilterPendingBtn.Click();
        }

        public void FilterConfirmed()
        {
            FilterConfirmedBtn.Click();
        }

        public void FilterDeclined()
        {
            FilterDeclinedBtn.Click();
        }

        public void FilterCancelled()
        {
            FilterCancelledBtn.Click();
        }

        public void FilterOk()
        {
            FilterOkBtn.Click();
        }

        public void FilterReset()
        {
            FilterResetBtn.Click();
        }



    }
   }

