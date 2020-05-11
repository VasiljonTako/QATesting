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

        public CompanyColleagueEdit()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div[2]/div[3]/div/div[2]/div/div/div/div/div/table/tbody/tr[1]/td[1]/a")]
        public IWebElement toColleague { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div/section/section/main/div/div/div[2]/div[3]/div/div[2]/div/div/div/div/div/table/tbody/tr[4]/td[1]/a")]
        public IWebElement toColleagueYourself { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div[2]/div[3]/div/div[2]/div/div/div/div/div/table/tbody/tr[1]/td[4]/button")]
        public IWebElement toColleagueActions { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div/div[2]/div[3]/div/div[2]/div/div/div/div/div/table/tbody/tr[2]/td[4]/button")]
        public IWebElement toColleagueYourselfActions { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div/ul/li[1]")]
        public IWebElement toColleagueViewProfile { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div/div/ul/li[1]")]
        public IWebElement toColleagueYourselfViewProfile { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div/ul/li[3]")]
        public IWebElement toColleagueMakeAdmin { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div/div/ul/li[3]")]
        public IWebElement toColleagueYourselfMakeAdmin { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div/div/ul/li[5]")]
        public IWebElement toColleagueDeleteUser { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div/div/ul/li[5]")]
        public IWebElement toColleagueYourselfDeleteUser { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div[1]/div[3]/button")]
        public IWebElement toColleagueEditProfile { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/section/section/main/div/div[1]/div[3]/button")]
        public IWebElement toColleagueYourselfEditProfile { get; set; }



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
