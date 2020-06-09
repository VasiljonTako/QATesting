using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
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
        public IWebElement attendeesBtn => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div[1]/div/div/div/div/div[1]/div[1]"));
        public IWebElement meetingsBtn => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div[1]/div/div/div/div/div[1]/div[2]"));
        public IWebElement scheduleBtn => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div[1]/div/div/div/div/div[1]/div[3]"));
        public IWebElement agendaBtn => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div[1]/div/div/div/div/div[1]/div[4]"));
        public IWebElement contentBtn => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div[1]/div/div/div/div/div[1]/div[5]"));
        public IWebElement fundsBtn => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div[3]/div[1]/div[2]/div/div/label[1]"));
        public IWebElement serviceProvidersBtn => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div[3]/div[1]/div[2]/div/div/label[2]"));
        public IWebElement contextBtn => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div[3]/div[1]/div[2]/div/div/label[3]"));
        public IWebElement searchInFundsBtn => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div[3]/div[1]/div[3]/div[3]/div[1]/header/div/div[2]/span/span/i[2]"));
        public IWebElement searchInFundsField => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div[3]/div[1]/div[3]/div[3]/div[1]/header/div/div[2]/span/input"));
        public IWebElement cancelSearchInFundsBtn => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div[3]/div[1]/div[3]/div[3]/div[1]/header/div/div[2]/span/span/i[1]"));
        public IWebElement customizeColumnsBtn => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div[3]/div[1]/div[3]/div[3]/div[1]/header/div/div[2]/button[1]"));
        public IWebElement exitCustomizeColumnsBtn => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[21]/div/div[2]/div/div/div[1]"));
        public IWebElement saveCustomizeColumnsBtn => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[21]/div/div[2]/div/div/div[2]/div/div[3]/button[1]"));
        public IWebElement cancelCustomizeColumnsBtn => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[21]/div/div[2]/div/div/div[2]/div/div[3]/button[2]"));
        public IWebElement BroadStrategyGroup => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[16]/div/div[2]/div/div/div[2]/div/div[2]/div[2]/label/span[1]/input"));       
        public IWebElement fromBroadStrategyGroup => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[16]/div/div[2]/div/div/div[2]/div/div[2]/div[12]"));
        public IWebElement toSubStrategy => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[16]/div/div[2]/div/div/div[2]/div/div[2]/div[6]"));
        public IWebElement showFavouriteFundsBtn => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div[3]/div[1]/div[3]/div[3]/div[1]/header/div/div[2]/button[2]"));
        public IWebElement sortByFundNameBtn => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div[3]/div[1]/div[3]/div[3]/div[1]/div[3]/div/div/div/div/div/div[1]/div[2]/div[1]/table/thead/tr/th[3]"));
        public IWebElement FilterMenuBtn => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div[3]/div[1]/div[3]/div[3]/div[1]/div[3]/div/div/div/div/div/div[1]/div[2]/div[1]/table/thead/tr/th[3]/i"));
        public IWebElement FilterPendingBtn => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[15]/div/div/div/ul/li[1]"));
        public IWebElement FilterConfirmedBtn => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[15]/div/div/div/ul/li[2]"));
        public IWebElement FilterDeclinedBtn => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[15]/div/div/div/ul/li[3]"));
        public IWebElement FilterCancelledBtn => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[15]/div/div/div/ul/li[4]"));
        public IWebElement FilterOkBtn => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[15]/div/div/div/div/a[1]"));
        public IWebElement FilterResetBtn => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[15]/div/div/div/div/a[2]"));
        public IWebElement makeFundFavouriteBtn => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div[3]/div[1]/div[3]/div[3]/div[1]/div[3]/div/div/div/div/div/div[1]/div[2]/div[2]/div/table/tbody/tr[1]/td[1]/button"));
        public IWebElement makeFundFavouriteBtn1 => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div[3]/div[1]/div[3]/div[3]/div[1]/div[3]/div/div/div/div/div/div[1]/div[2]/div[2]/div/table/tbody/tr[1]/td[1]/button"));
        public IWebElement FundOptions => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div[3]/div[1]/div[3]/div[3]/div[1]/div[3]/div/div/div/div/div/div[1]/div[2]/div[2]/div/table/tbody/tr[1]/td[4]/button"));
        public IWebElement FundSendMessage => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[16]/div/div/ul/li[1]"));
        public IWebElement FundSendMessageField => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[17]/div/div[2]/div/div[2]/div[2]/div/div/div/div[2]/textarea"));
        public IWebElement CancelSendMessage => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[16]/div/div[2]/div/div[2]/div[3]/div/button[1]"));
        public IWebElement SendMessageConfirm => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[16]/div/div[2]/div/div[2]/div[3]/div/button[2]"));
        public IWebElement ViewMeetingRequestBtn => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[15]/div/div/ul/li[5]"));



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

        public void goToContent()
        {
            contentBtn.Click();
        }

        public void goToFunds()
        {
           fundsBtn.Click();
        }

        public void goToServiceProviders()
        {
            serviceProvidersBtn.Click();
        }

        public void FundOptionsForm()
        {
            FundOptions.Click();
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

        public void DragAndDropForm()
        {
            BroadStrategyGroup.Click();
            Actions builder = new Actions(PropertiesCollection.driver);
            System.Threading.Thread.Sleep(1000);
            builder.DragAndDropToOffset(fromBroadStrategyGroup, 137 , 18).Perform();
            saveCustomizeColumnsBtn.Click();

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

        public void MakeFundFavouriteForm()
        {
            makeFundFavouriteBtn.Click();
            System.Threading.Thread.Sleep(2000);
            makeFundFavouriteBtn1.Click();
        }

        public void MakeFundFavouriteAndSeeFavouriteFunds()
        {
            MakeFundFavouriteForm();
            System.Threading.Thread.Sleep(2000);
            showFavouriteFunds();
        }

        public void FilterFundsByPending()
        {
            FilterMenu();
            FilterPending();
            FilterOk();
        }

        public void SendMessageToFundForm()
        {
            FundOptions.Click();
            System.Threading.Thread.Sleep(1000);
            FundSendMessage.Click();
            System.Threading.Thread.Sleep(1000);
            FundSendMessageField.Click();
            FundSendMessageField.SendKeys("Test Joni");
            SendMessageConfirm.Click();
        }


    }
   }

