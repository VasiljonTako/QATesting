using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context.AccountClasses
{
    public class CompanySettings
    {
        public CompanySettings()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Id, Using = "name")]
        public IWebElement toCompanyName { get; set; }

        [FindsBy(How = How.Id, Using = "companyWebsite")]
        public IWebElement toCompanyWebsite { get; set; }

        [FindsBy(How = How.Id, Using = "companyDescription")]
        public IWebElement toCompanyDescription { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div/div[1]/div[2]/div[4]/div")]
        public IWebElement toPrimaryInvestorCompany { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div/div/ul/li[5]")]
        public IWebElement toPrimaryInvestorCompanyValue { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div/div[1]/div[2]/div[5]/div/label[1]")]
        public IWebElement toSecondaryInvestorCompany { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div/div[1]/div[2]/div[5]/div/label[2]")]
        public IWebElement toSecondaryInvestorCompany1 { get; set; }

        [FindsBy(How = How.Id, Using = "companyAllocator.portfolioSize")]
        public IWebElement toPortofolioSize { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div/div[1]/div[2]/div[7]/div/div/label[1]")]
        public IWebElement toFundDomicileInterest { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div/div[1]/div[2]/div[7]/div/div/label[2]")]
        public IWebElement toFundDomicileInterest1 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div/div[1]/div[2]/div[7]/div/div[2]/div/label[1]")]
        public IWebElement toFundDomicileInterest1Value { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div/div[1]/div[2]/div[8]/div/label[2]")]
        public IWebElement toInvestmentVehicleInterest { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div/div[1]/div[2]/div[8]/div/label[5]")]
        public IWebElement toInvestmentVehicleInterest1 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div/div[1]/div[2]/div[9]/div[2]/label[1]/span[1]/input")]
        public IWebElement toFirstLossCapitalYes { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div/div[1]/div[2]/div[9]/div[2]/label[2]/span[1]/input")]
        public IWebElement toFirstLossCapitalNo { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/section/section/main/div/div/div/div[1]/div[2]/div[10]/button")]
        public IWebElement toEditPreferences { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div/div[2]/div[2]/div[1]/div/div")]
        public IWebElement toCompanyContinent { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div/div/ul/li[4]")]
        public IWebElement toCompanyContinentValue { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div/div[2]/div[2]/div[2]/div")]
        public IWebElement toCompanyCountry { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div/div/div/ul/li[6]")]
        public IWebElement toCompanyCountryValue { get; set; }

        [FindsBy(How = How.Id, Using = "zipCode")]
        public IWebElement toCompanyZipCode { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div/div[2]/div[2]/div[3]/span/span/span/button")]
        public IWebElement toSearchCompanyZipCode { get; set; }

        [FindsBy(How = How.Id, Using = "state")]
        public IWebElement toCompanyState { get; set; }

        [FindsBy(How = How.Id, Using = "city")]
        public IWebElement toCompanyCity { get; set; }

        [FindsBy(How = How.Id, Using = "address1")]
        public IWebElement toCompanyAddress1 { get; set; }

        [FindsBy(How = How.Id, Using = "address2")]
        public IWebElement toCompanyAddress2 { get; set; }

        [FindsBy(How = How.Id, Using = "address1")]
        public IWebElement toCompanyAddress3 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div/div[3]/div[2]/button[2]")]
        public IWebElement toSaveCompanySettings { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div/div[3]/div[2]/button[1]")]
        public IWebElement toCancelSaveCompanySettings { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div/div[1]/div[3]/div/span/div/span")]
        public IWebElement toUploadCompanyPhoto { get; set; }

        public void CompanyNameForm(string companynamevalue)
        {
            toCompanyName.Click();
            toCompanyName.Clear();
            toCompanyName.SendKeys(companynamevalue);
        }

        public void CompanyWebsiteForm(string companywebsitevalue)
        {
            toCompanyWebsite.Click();
            toCompanyWebsite.Clear();
            toCompanyWebsite.SendKeys(companywebsitevalue);
        }

        public void CompanyDescriptionForm(string companydescriptionvalue)
        {
            toCompanyDescription.Click();
            toCompanyDescription.Clear();
            toCompanyDescription.SendKeys(companydescriptionvalue);
        }

        public void PrimaryInvestorCompanyForm()
        {
            toPrimaryInvestorCompany.Click();
            toPrimaryInvestorCompanyValue.Click();
        }

        public void SecondaryInvestorCompanyForm()
        {
            toSecondaryInvestorCompany.Click();
            toSecondaryInvestorCompany1.Click();
        }

        public void PortofolioSizeForm(string portofoliosizevalue)
        {
            toPortofolioSize.Click();
            toPortofolioSize.Clear();
            toPortofolioSize.SendKeys(portofoliosizevalue);
        }

        public void FundDomicileInterestForm()
        {
            toFundDomicileInterest.Click();
            toFundDomicileInterest1.Click();
            toFundDomicileInterest1Value.Click();
        }

        public void InvestmentVehicleInterestForm()
        {
            toInvestmentVehicleInterest.Click();
            toInvestmentVehicleInterest1.Click();
        }

        public void FirstLossCapitalYesForm()
        {
            toFirstLossCapitalYes.Click();
            toFirstLossCapitalNo.Click();
        }

        public void EditPreferencesForm()
        {
            toEditPreferences.Click();
        }

        public void CompanyContinentForm()
        {
            toCompanyContinent.Click();
            System.Threading.Thread.Sleep(2000);
            toCompanyContinentValue.Click();
        }

        public void CompanyCountryForm()
        {
            toCompanyCountry.Click();
            toCompanyCountryValue.Click();
        }

        public void CompanyZipCodeForm(string companyzipcodevalue)
        {
            toCompanyZipCode.Click();
            toCompanyZipCode.Clear();
            toCompanyZipCode.SendKeys(companyzipcodevalue);
            toSearchCompanyZipCode.Click();
        }

        public void CompanyStateForm(string companystatevalue)
        {
            toCompanyState.Click();
            toCompanyState.Clear();
            toCompanyState.SendKeys(companystatevalue);
        }

        public void CompanyCityForm(string companycityvalue)
        {
            toCompanyCity.Click();
            toCompanyCity.Clear();
            toCompanyCity.SendKeys(companycityvalue);
        }

        
        public void CompanyAddress1Form(string companyaddress1value)
        {
            toCompanyAddress1.Click();
            toCompanyAddress1.Clear();
            toCompanyAddress1.SendKeys(companyaddress1value);
        }

        public void CompanyAddress2Form(string companyaddress2value)
        {
            toCompanyAddress2.Click();
            toCompanyAddress2.Clear();
            toCompanyAddress2.SendKeys(companyaddress2value);
        }

        public void CompanyAddress3Form(string companyaddress3value)
        {
            toCompanyAddress2.Click();
            toCompanyAddress2.Clear();
            toCompanyAddress2.SendKeys(companyaddress3value);
        }

        public void CancelSaveCompanySettings()
        {
            toCancelSaveCompanySettings.Click();
        }

        public void SaveCompanySettings()
        {
            toSaveCompanySettings.Click();
        }

        public void UploadCompanyPhoto()
        {
            toUploadCompanyPhoto.Click();
            toUploadCompanyPhoto.SendKeys("/C:/Users/User/Desktop/test.png");
        }
    }
}
