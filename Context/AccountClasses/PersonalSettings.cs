using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    public class PersonalSettings
    {

        public IWebElement toFirstName => PropertiesCollection.driver.FindElement(By.Id("firstName"));
        public IWebElement toLastName => PropertiesCollection.driver.FindElement(By.Id("lastName"));
        public IWebElement toEmail => PropertiesCollection.driver.FindElement(By.Id("email"));
        public IWebElement toJobTitle => PropertiesCollection.driver.FindElement(By.Id("jobTitle"));
        public IWebElement toJobLevel => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div/div[1]/div[2]/div[5]/div"));
        public IWebElement toJobLevelValue => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[3]/div/div/div/ul/li[2]"));
        public IWebElement toJobFunction => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div/div[1]/div[2]/div[6]/div"));
        public IWebElement toJobFunctionValue => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[4]/div/div/div/ul/li[2]"));
        public IWebElement toWorkPhone => PropertiesCollection.driver.FindElement(By.Id("workPhone"));
        public IWebElement toWorkExtension => PropertiesCollection.driver.FindElement(By.Id("workExtension"));
        public IWebElement toMobilePhone => PropertiesCollection.driver.FindElement(By.Id("mobilePhone"));
        public IWebElement toContinent => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div/div[2]/div[2]/div[1]/div"));
        public IWebElement toContinentValue => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[5]/div/div/div/ul/li[3]"));
        public IWebElement toCountry => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div/div[2]/div[2]/div[2]/div"));
        public IWebElement toCountryValue => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[6]/div/div/div/ul/li[1]"));
        public IWebElement toZipCode => PropertiesCollection.driver.FindElement(By.Id("zipCode"));
        public IWebElement toZipCodeSEarchBtn => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div/div[2]/div[2]/div[3]/span/span/span/button"));
        public IWebElement toState => PropertiesCollection.driver.FindElement(By.Id("state"));
        public IWebElement toCity => PropertiesCollection.driver.FindElement(By.Id("city"));
        public IWebElement toAddress1 => PropertiesCollection.driver.FindElement(By.Id("address1"));
        public IWebElement toAddress2 => PropertiesCollection.driver.FindElement(By.Id("address2"));
        public IWebElement toAddress3 => PropertiesCollection.driver.FindElement(By.Id("address3"));
        public IWebElement toCancelPersonalSettings => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div/div[3]/div[2]/button[1]"));
        public IWebElement toSavePersonalSettings => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div/div[3]/div[2]/button[2]"));
        public IWebElement toUploadPhoto => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div/div[1]/div[3]/div/span/div/span/img"));

        public void FirstNameForm(string firstnamevalue)
        {
            toFirstName.Click();
            toFirstName.Clear();
            toFirstName.SendKeys(firstnamevalue);
        }

        public void LastNameForm(string lastnamevalue)
        {
            toLastName.Click();
            toLastName.Clear();
            toLastName.SendKeys(lastnamevalue);
        }

        public void EmailForm(string emailvalue)
        {
            toEmail.Click();
            toEmail.Clear();
            toEmail.SendKeys(emailvalue);
        }

        public void JobTitleForm(string jobtitlevalue)
        {
            toJobTitle.Click();
            toJobTitle.Clear();
            toJobTitle.SendKeys(jobtitlevalue);
        }

        public void JobLevelForm()
        {
            toJobLevel.Click();
            System.Threading.Thread.Sleep(2000);
            toJobLevelValue.Click();
        }

        public void JobFunctionForm()
        {
            toJobFunction.Click();
            System.Threading.Thread.Sleep(2000);
            toJobFunctionValue.Click();
        }

        public void WorkPhoneForm(string workphonevalue)
        {
            toWorkPhone.Click();
            toWorkPhone.Clear();
            toWorkPhone.SendKeys(workphonevalue);
        }

        public void WorkExtensionForm(string workextensionvalue)
        {
            toWorkExtension.Click();
            toWorkExtension.Clear();
            toWorkExtension.SendKeys(workextensionvalue);
        }

        public void MobilePhoneForm(string mobilephonevalue)
        {
            toMobilePhone.Click();
            toMobilePhone.Clear();
            toMobilePhone.SendKeys(mobilephonevalue);
        }

        public void ContinentForm()
        {
            toContinent.Click();

            toContinentValue.Click();
        }

        public void CountryForm()
        {
            toCountry.Click();
            toCountryValue.Click();
        }

        public void ZipCodeForm(string zipcodevalue)
        {
            toZipCode.Click();
            toZipCode.Clear();
            toZipCode.SendKeys(zipcodevalue);
            toZipCodeSEarchBtn.Click();
        }

        public void StateForm(string statevalue)
        {
            toState.Click();
            toState.Clear();
            toState.SendKeys(statevalue);
        }

        public void CityForm(string cityvalue)
        {
            toCity.Click();
            toCity.Clear();
            toCity.SendKeys(cityvalue);
        }

        public void Address1Form(string address1value)
        {
            toAddress1.Click();
            toAddress1.Clear();
            toAddress1.SendKeys(address1value);
        }

        public void Address2Form(string address2value)
        {
            toAddress2.Click();
            toAddress2.Clear();
            toAddress2.SendKeys(address2value);
        }

        public void Address3Form(string address3value)
        {
            toAddress3.Click();
            toAddress3.Clear();
            toAddress3.SendKeys(address3value);
        }

        public void CancelPersonalSettings()
        {
            toCancelPersonalSettings.Click();
        }

        public void SavePersonalSettings()
        {
            toSavePersonalSettings.Click();
        }

        public void UploadPhoto()
        {
            toUploadPhoto.Click();
            toUploadPhoto.SendKeys("/C:/Users/User/Desktop/test.png");      
        }
    }
}
