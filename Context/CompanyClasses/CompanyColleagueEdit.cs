using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context.CompanyClasses
{
    public class CompanyColleagueEdit
    {

        public IWebElement toColleague => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div[2]/div[3]/div/div[2]/div/div/div/div/div/table/tbody/tr[1]/td[1]/a"));
        public IWebElement toColleagueYourself => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div[2]/div[3]/div/div[2]/div/div/div/div/div/table/tbody/tr[4]/td[1]/a"));
        public IWebElement toColleagueActions => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div[2]/div[3]/div/div[2]/div/div/div/div/div/table/tbody/tr[1]/td[4]/button"));
        public IWebElement toColleagueYourselfActions => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div/div[2]/div[3]/div/div[2]/div/div/div/div/div/table/tbody/tr[4]/td[4]/button"));
        public IWebElement toColleagueViewProfile => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[1]"));
        public IWebElement toColleagueYourselfViewProfile => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[4]/div/div/ul/li[1]"));
        public IWebElement toColleagueMakeAdmin => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[3]"));
        public IWebElement toColleagueYourselfMakeAdmin => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[4]/div/div/ul/li[3]"));
        public IWebElement toColleagueDeleteUser => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]"));
        public IWebElement toColleagueYourselfDeleteUser => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[4]/div/div/ul/li[5]"));
        public IWebElement toColleagueEditProfile => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div[1]/div[3]/button"));
        public IWebElement toColleagueYourselfEditProfile => PropertiesCollection.driver.FindElement(By.XPath("/html/body/div[1]/section/section/main/div/div[1]/div[3]/button"));



        public void ColleagueForm()
        {
            toColleague.Click();
        }

        public void ColleagueActionsForm()
        {
            toColleagueActions.Click();
        }

        public void ColleagueViewProfileForm()
        {
            toColleagueViewProfile.Click();
        }


        public void ColleagueMakeAdminForm()
        {
            toColleagueMakeAdmin.Click();
        }

        public void ColleagueDeleteUserForm()
        {
            toColleagueDeleteUser.Click();
        }

        public void ColleagueEditProfileForm()
        {
            toColleagueEditProfile.Click();
        }

        public void ColleagueYourselfForm()
        {
            System.Threading.Thread.Sleep(2000);
            toColleagueYourself.Click();
        }

        public void ColleagueYourselfActionsForm()
        {
            toColleagueYourselfActions.Click();
        }

        public void ColleagueYourselfViewProfileForm()
        {
            toColleagueYourselfViewProfile.Click();
        }


        public void ColleagueYourselfMakeAdminForm()
        {
            toColleagueYourselfMakeAdmin.Click();
        }

        public void ColleagueYourselfDeleteUserForm()
        {
            toColleagueYourselfDeleteUser.Click();
        }

        public void ColleagueYourselfEditProfileForm()
        {
            toColleagueYourselfEditProfile.Click();
        }

        public void EditPersonalSettingsMethod()
        {
            PersonalSettings PersonalSettingsEdit = new PersonalSettings();
            //Personal Settings
            PersonalSettingsEdit.FirstNameForm("Joni");
            PersonalSettingsEdit.LastNameForm("Tako");
            PersonalSettingsEdit.EmailForm("joni.tako@ccap.com");
            PersonalSettingsEdit.JobTitleForm("QA");
            PersonalSettingsEdit.JobLevelForm();
            PersonalSettingsEdit.JobFunctionForm();
            PersonalSettingsEdit.WorkPhoneForm("Test");
            PersonalSettingsEdit.WorkExtensionForm("Test1");
            PersonalSettingsEdit.MobilePhoneForm("0696862688");
            //Address
            PersonalSettingsEdit.ContinentForm();
            System.Threading.Thread.Sleep(2000);
            PersonalSettingsEdit.CountryForm();
            PersonalSettingsEdit.ZipCodeForm("02034");
            PersonalSettingsEdit.StateForm("Albania");
            PersonalSettingsEdit.CityForm("Tirane");
            PersonalSettingsEdit.Address1Form("Komuna");
            PersonalSettingsEdit.Address2Form("kika");
            PersonalSettingsEdit.Address3Form("");
            //PersonalSettingsEdit.UploadPhoto();
            //PersonalSettingsEdit.CancelPersonalSettings();
            //PersonalSettingsEdit.SavePersonalSettings();
        }

    }
}
