using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context.CompanyClasses
{
    public class EditPersonalSettings
    {
        public EditPersonalSettings()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Id, Using = "firstName")]
        public IWebElement toFirstName { get; set; }

        [FindsBy(How = How.Id, Using = "lastName")]
        public IWebElement toLastName { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement toEmail { get; set; }

        [FindsBy(How = How.Id, Using = "jobTitle")]
        public IWebElement toJobTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div/div[1]/div[2]/div[5]/div")]
        public IWebElement toJobLevel { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div/div/ul/li[3]")]
        public IWebElement toJobLevelValue { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div/div[1]/div[2]/div[6]/div")]
        public IWebElement toJobFunction { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div/div/ul/li[4]")]
        public IWebElement toJobFunctionValue { get; set; }

        [FindsBy(How = How.Id, Using = "workPhone")]
        public IWebElement toWorkPhone { get; set; }

        [FindsBy(How = How.Id, Using = "workExtension")]
        public IWebElement toWorkExtension { get; set; }

        [FindsBy(How = How.Id, Using = "mobilePhone")]
        public IWebElement toMobilePhone { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div/div[2]/div[2]/div[1]/div")]
        public IWebElement toContinent { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div/div/div/ul/li[3]")]
        public IWebElement toContinentValue { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div/div[2]/div[2]/div[2]/div")]
        public IWebElement toCountry { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[5]/div/div/div/ul/li[1]")]
        public IWebElement toCountryValue { get; set; }

        [FindsBy(How = How.Id, Using = "zipCode")]
        public IWebElement toZipCode { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div/div[2]/div[2]/div[3]/span/span/span/button")]
        public IWebElement toZipCodeSEarchBtn { get; set; }

        [FindsBy(How = How.Id, Using = "state")]
        public IWebElement toState { get; set; }

        [FindsBy(How = How.Id, Using = "city")]
        public IWebElement toCity { get; set; }

        [FindsBy(How = How.Id, Using = "address1")]
        public IWebElement toAddress1 { get; set; }

        [FindsBy(How = How.Id, Using = "address2")]
        public IWebElement toAddress2 { get; set; }

        [FindsBy(How = How.Id, Using = "address3")]
        public IWebElement toAddress3 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div/div[3]/div[2]/button[1]")]
        public IWebElement toCancelPersonalSettings { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div/div[3]/div[2]/button[2]")]
        public IWebElement toSavePersonalSettings { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div/div[1]/div[3]/div/span/div/span/img")]
        public IWebElement toUploadPhoto { get; set; }


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
            System.Threading.Thread.Sleep(1000);
            toJobLevelValue.Click();
        }

        public void JobFunctionForm()
        {
            toJobFunction.Click();
            System.Threading.Thread.Sleep(1000);
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

        public void EditPersonalSettingsMethod()
        {
            EditPersonalSettings editpersonalsettings = new EditPersonalSettings();
            editpersonalsettings.FirstNameForm("Joni");
            editpersonalsettings.LastNameForm("Tako");
            editpersonalsettings.EmailForm("joni.tako@ccap.com");
            editpersonalsettings.JobTitleForm("QA");
            editpersonalsettings.JobLevelForm();
            editpersonalsettings.JobFunctionForm();
            editpersonalsettings.WorkPhoneForm("Test");
            editpersonalsettings.WorkExtensionForm("Test1");
            editpersonalsettings.MobilePhoneForm("0696862688");
            //Address
            editpersonalsettings.ContinentForm();
            System.Threading.Thread.Sleep(2000);
            editpersonalsettings.CountryForm();
            editpersonalsettings.ZipCodeForm("02034");
            editpersonalsettings.StateForm("Albania");
            editpersonalsettings.CityForm("Tirane");
            editpersonalsettings.Address1Form("Komuna");
            editpersonalsettings.Address2Form("kika");
            editpersonalsettings.Address3Form("");
            //editpersonalsettings.UploadPhoto();
            //editpersonalsettings.CancelPersonalSettings();
            //editpersonalsettings.SavePersonalSettings();
        }
    }
}
