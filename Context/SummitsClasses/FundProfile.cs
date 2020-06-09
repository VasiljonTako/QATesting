using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context.SummitsClasses
{
    public class FundProfile
    {
        public IWebElement FundProfileBtn => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[16]/div/div/ul/li[3]"));
        public IWebElement ExitFundProfile => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[18]/div/div[2]/div/div[2]/button"));
        public IWebElement MakeFundFavouriteFromProfile => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[17]/div/div[2]/div/div[2]/div/div/div/div/div[1]/div[2]/div/button[1]"));
        public IWebElement FundProfileMenu => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[17]/div/div[2]/div/div[2]/div/div/div/div/div[1]/div[2]/div/button[2]"));
        public IWebElement FundProfileMenuHistory => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[19]/div/div/ul/li[1]"));
        public IWebElement FundProfileExitHistory => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[19]/div/div[2]/div/div[2]/div[3]/button"));
        public IWebElement FundProfileDownload => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[19]/div/div/ul/li[3]"));
        public IWebElement FundProfileViewTearSheet => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[19]/div/div/ul/li[5]"));
        public IWebElement FundDetails => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[18]/div/div[2]/div/div[2]/div/div/div/div/div[2]/div[2]/div[1]/div/div/div/div/div[1]/div[2]"));
        public IWebElement FundManagers => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[18]/div/div[2]/div/div[2]/div/div/div/div/div[2]/div[2]/div[1]/div/div/div/div/div[1]/div[3]"));
        public IWebElement FundCharts => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[18]/div/div[2]/div/div[2]/div/div/div/div/div[2]/div[2]/div[1]/div/div/div/div/div[1]/div[4]"));
        public IWebElement FundDisclaimer => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[17]/div/div[2]/div/div[2]/div/div/div/div/div[2]/div[2]/div[1]/div/div/div/div/div[1]/div[5]"));
        public IWebElement SendMessageFromProfile => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[18]/div/div[2]/div/div[2]/div/div/div/div/div[3]/div/button[1]"));
        public IWebElement DeclineMetting => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[18]/div/div[2]/div/div[2]/div/div/div/div/div[3]/div/button[2]"));
        public IWebElement AcceptMetting => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[18]/div/div[2]/div/div[2]/div/div/div/div/div[3]/div/button[3]"));



        public void FundProfileForm()
        {
            FundProfileBtn.Click();
        }

        public void ExitFundProfileForm()
        {
            ExitFundProfile.Click();
        }
  
        public void MakeFundFavouriteFromProfileForm()
        {
            MakeFundFavouriteFromProfile.Click();
        }

        public void FundProfileMenuForm()
        {
            FundProfileMenu.Click();
        }

        public void FundProfileMenuHistoryForm()
        {
            FundProfileMenuHistory.Click();
        }

        public void FundProfileExitHistoryForm()
        {
            FundProfileExitHistory.Click();
        }

        public void FundProfileDownloadForm()
        {
            FundProfileDownload.Click();
        }

        public void FundProfileViewTearSheetForm()
        {
            FundProfileViewTearSheet.Click();
        }

        public void FundDetailsForm()
        {
            FundDetails.Click();
        }

        public void FundManagersForm()
        {
            FundManagers.Click();
        }

        public void FundChartsForm()
        {
            FundCharts.Click();
        }

        public void SendMessageFromProfileForm()
        {
            SendMessageFromProfile.Click();
        }

        public void DeclineMettingForm()
        {
            DeclineMetting.Click();
        }

        public void AcceptMettingForm()
        {
            AcceptMetting.Click();
        }

        public void SeeHistoryForm()
        {
            NextSummit smt = new NextSummit();
            smt.FundOptions.Click();
            System.Threading.Thread.Sleep(1000);
            FundProfileForm();
            System.Threading.Thread.Sleep(3000);
            MakeFundFavouriteFromProfileForm();
            System.Threading.Thread.Sleep(1000);
            FundProfileMenuForm();
            System.Threading.Thread.Sleep(1000);
            FundProfileMenuHistoryForm();
            System.Threading.Thread.Sleep(2000);
            FundProfileExitHistoryForm();
        }

    }
}
