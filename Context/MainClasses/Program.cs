using Context.AccountClasses;
using Context.CompanyClasses;
using Context.DashboardClasses;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    class Program
    {
        ChromeOptions options = new ChromeOptions();

        static void Main(string[] args)
        {
        }

        [SetUp]
        public void Initialize ()
        {
            options.AddArguments("--disable-notifications");

            PropertiesCollection.driver = new ChromeDriver(options);

            PropertiesCollection.driver.Navigate().GoToUrl("http://qa.context365.com");
        }

        [Test]
        public void ExecuteTestLogin()
        {
            Login pageLogin = new Login();
            pageLogin.LoginForm("thomas.peters@ccap.com");
            System.Threading.Thread.Sleep(2000);
        }

        [Test]
        public void ExecuteTestToDashboard()
        {
            ExecuteTestLogin();
            System.Threading.Thread.Sleep(1000);
            Dashboard pageDashboard = new Dashboard();
            pageDashboard.DashboardForm();
        }

        [Test]
        public void ExecuteTestToMeetings()
        {
            ExecuteTestLogin();
            System.Threading.Thread.Sleep(1000);
            Dashboard pageDashboard = new Dashboard();
            pageDashboard.MettingsForm();
        }

        [Test]
        public void ExecuteTestToMessages()
        {
            ExecuteTestLogin();
            System.Threading.Thread.Sleep(1000);
            Dashboard pageDashboard = new Dashboard();
            pageDashboard.MessagesForm();
        }

        [Test]
        public void ExecuteTestToSummits()
        {
            ExecuteTestLogin();
            System.Threading.Thread.Sleep(1000);
            Dashboard pageDashboard = new Dashboard();
            pageDashboard.SummitsForm();      
        }

        [Test]
        public void ExecuteTestToCompany()
        {
            ExecuteTestLogin();
            System.Threading.Thread.Sleep(1000);
            Dashboard pageDashboard = new Dashboard();
            pageDashboard.CompanyForm();
        }

        [Test]
        public void ExecuteTestToAccountName()
        {
            ExecuteTestLogin();
            System.Threading.Thread.Sleep(1000);
            Dashboard pageDashboard = new Dashboard();
            pageDashboard.AccountNameForm();
        }

        [Test]
        public void ExecuteTestToSettings()
        {
            ExecuteTestLogin();
            System.Threading.Thread.Sleep(1000);
            Dashboard pageDashboard = new Dashboard();
            pageDashboard.toSettingsForm();
        }

        [Test]
        public void ExecuteTestToMessagesNtfc()
        {
            ExecuteTestLogin();
            System.Threading.Thread.Sleep(1000);
            Dashboard pageDashboard = new Dashboard();
            pageDashboard.MessagesNtfcForm();
        }

        [Test]
        public void ExecuteTestToNotifications()
        {
            ExecuteTestLogin();
            System.Threading.Thread.Sleep(1000);
            Dashboard pageDashboard = new Dashboard();
            pageDashboard.NotificationsForm();
        }

        [Test]
        public void ExecuteTestToDashboardSort()
        {
            ExecuteTestLogin();
            System.Threading.Thread.Sleep(3000);
            Dashboard pageDashboardSort = new Dashboard();
            pageDashboardSort.MeetingsStats();
        }

        [Test]
        public void ExecuteTestToNextSummit()
        {
            ExecuteTestLogin();
            System.Threading.Thread.Sleep(3000);
            Dashboard pageDashboard = new Dashboard();
            pageDashboard.NextSummitForm();
        }

        [Test]
        public void ExecuteTestToNextSummitSearch()
        {
            ExecuteTestToNextSummit();
            System.Threading.Thread.Sleep(3000);
            NextSummit pageNextSummit = new NextSummit();
            pageNextSummit.SearchInFunds("Catherine");
        }

        [Test]
        public void ExecuteTestToNextSummitCancelSearch()
        {
            ExecuteTestToNextSummit();
            System.Threading.Thread.Sleep(3000);
            NextSummit pageNextSummit = new NextSummit();
            pageNextSummit.CancelSearchInFunds("Catherine");
        }

        [Test]
        public void ExecuteTestToAccountNameSwitchCompanies()
        {
            ExecuteTestToAccountName();
            System.Threading.Thread.Sleep(3000);
            AccountName pageAccountName = new AccountName();
            pageAccountName.SwitchCompaniesForm();
        }

        [Test]
        public void ExecuteTestToAccountNamePersonalSettings()
        {
            ExecuteTestToAccountName();
            System.Threading.Thread.Sleep(3000);
            AccountName pageAccountName = new AccountName();
            pageAccountName.PersonalSettingsForm();
        }

        [Test]
        public void ExecuteTestToAccountNameCompanySettings()
        {
            ExecuteTestToAccountName();
            System.Threading.Thread.Sleep(3000);
            AccountName pageAccountName = new AccountName();
            pageAccountName.CompanySettingsForm();
        }

        [Test]
        public void ExecuteTestToAccountNameNotificationsSettings()
        {
            ExecuteTestToAccountName();
            System.Threading.Thread.Sleep(4000);
            AccountName pageAccountName = new AccountName();
            pageAccountName.NotificationsSettingsForm();
        }

        [Test]
        public void ExecuteTestToAccountNameLogout()
        {
            ExecuteTestToAccountName();
            System.Threading.Thread.Sleep(4000);
            AccountName pageAccountName = new AccountName();
            pageAccountName.LogoutForm();
        }

        [Test]
        public void ExecuteTestToNotificationsPopUpSettings()
        {
            ExecuteTestLogin();
            System.Threading.Thread.Sleep(2000);
            Dashboard dashboardntfc = new Dashboard();
            dashboardntfc.NotificationsForm();

            System.Threading.Thread.Sleep(2000);
            NotificationsPopUp notificationssettings = new NotificationsPopUp();
            notificationssettings.PopUpNotificationsSettings();
        }

        [Test]
        public void ExecuteTestToNotificationsPopUpMarkAllAsRead()
        {
            ExecuteTestLogin();
            System.Threading.Thread.Sleep(2000);
            Dashboard dashboardntfc1 = new Dashboard();
            dashboardntfc1.NotificationsForm();

            System.Threading.Thread.Sleep(2000);
            NotificationsPopUp notificationssettings1 = new NotificationsPopUp();
            notificationssettings1.PopUpShowAllNotifications(); //Tregon te gjithe notifications
            System.Threading.Thread.Sleep(2000);
            notificationssettings1.PopUpMarkAllAsRead();
        }

        [Test]
        public void ExecuteTestToNotificationsPopUpMarkMeetingAsRead()
        {
            ExecuteTestLogin();
            System.Threading.Thread.Sleep(2000);
            Dashboard dashboardntfc2 = new Dashboard();
            dashboardntfc2.NotificationsForm();

            System.Threading.Thread.Sleep(2000);
            NotificationsPopUp notificationssettings2 = new NotificationsPopUp();
            notificationssettings2.PopUpMarkMeetingAsRead();
        }

        [Test]
        public void ExecuteTestToNotificationsPopUpToMeeting()
        {
            ExecuteTestLogin();
            System.Threading.Thread.Sleep(2000);
            Dashboard dashboardntfc1 = new Dashboard();
            dashboardntfc1.NotificationsForm();

            System.Threading.Thread.Sleep(2000);
            NotificationsPopUp notificationssettings1 = new NotificationsPopUp();
            notificationssettings1.PopUpMeetings();
        }

        [Test]
        public void ExecuteTestToEditPersonalSettings()
        {
            ExecuteTestToAccountNamePersonalSettings();
            System.Threading.Thread.Sleep(2000);
            PersonalSettings PersonalSettingsEdit = new PersonalSettings();
            //Personal Settings
            PersonalSettingsEdit.FirstNameForm("Joni");
            PersonalSettingsEdit.LastNameForm("Tako");
            PersonalSettingsEdit.EmailForm("joni.tako@ccap.com");
            PersonalSettingsEdit.JobTitleForm("QA");

            EditPersonalSettings test = new EditPersonalSettings();
            test.JobLevelForm();
            //PersonalSettingsEdit.JobLevelForm();
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

        [Test]
        public void ExecuteTestToEditNitificationsSettings()
        {
            ExecuteTestToAccountNameNotificationsSettings();
            System.Threading.Thread.Sleep(2000);
            NotificationsSettings notificationssettings = new NotificationsSettings();

            notificationssettings.NtfcNewMessageForm();
            System.Threading.Thread.Sleep(2000);
            notificationssettings.NtfcMeetingAutomaticallyAcceptedForm();
            System.Threading.Thread.Sleep(2000);
            notificationssettings.NtfcMeetingScheduledForm();
            System.Threading.Thread.Sleep(2000);
            notificationssettings.NtfcMeetingDeclinedForm();
            System.Threading.Thread.Sleep(2000);
            notificationssettings.NtfcMeetingCanceledForm();
            System.Threading.Thread.Sleep(2000);
            notificationssettings.NtfcMeetingUpdatedForm();
            System.Threading.Thread.Sleep(2000);
            notificationssettings.NtfcMeetingConfirmedForm();
            System.Threading.Thread.Sleep(2000);
            notificationssettings.NtfcMeetingRequestedForm();
            System.Threading.Thread.Sleep(2000);
            notificationssettings.NtfcNewAlertForm();
            System.Threading.Thread.Sleep(2000);
            notificationssettings.BNtfcMeetingScheduledForm();
            System.Threading.Thread.Sleep(2000);
            notificationssettings.BNtfcMeetingDeclinedForm();
            System.Threading.Thread.Sleep(2000);
            notificationssettings.BNtfcMeetingCanceledForm();
            System.Threading.Thread.Sleep(2000);
            notificationssettings.BNtfcMeetingUpdatedForm();
            System.Threading.Thread.Sleep(2000);
            notificationssettings.BNtfcMeetingConfirmedForm();
            System.Threading.Thread.Sleep(2000);
            notificationssettings.BNtfcMeetingRequestedForm();
            System.Threading.Thread.Sleep(2000);
            notificationssettings.BNtfcMeetingAutomaticallyAcceptedForm();
            System.Threading.Thread.Sleep(2000);
            notificationssettings.BNtfcNewMessageForm();
            System.Threading.Thread.Sleep(2000);
            notificationssettings.BNtfcNewAlertForm();
            System.Threading.Thread.Sleep(2000);
            notificationssettings.PNtfcMeetingRequestedForm();
            System.Threading.Thread.Sleep(2000);
            notificationssettings.PNtfcNewMessageForm();
            System.Threading.Thread.Sleep(2000);
            notificationssettings.PNtfcMeetingAutomaticallyAcceptedForm();
            System.Threading.Thread.Sleep(2000);
            notificationssettings.PNtfcMeetingScheduledForm();
            System.Threading.Thread.Sleep(2000);
            notificationssettings.PNtfcMeetingDeclinedForm();
            System.Threading.Thread.Sleep(2000);
            notificationssettings.PNtfcMeetingCanceledForm();
            System.Threading.Thread.Sleep(2000);
            notificationssettings.PNtfcMeetingUpdatedForm();
            System.Threading.Thread.Sleep(2000);
            notificationssettings.PNtfcMeetingConfirmedForm();
            System.Threading.Thread.Sleep(2000);
            notificationssettings.PNtfcNewAlertForm();
            System.Threading.Thread.Sleep(2000);
            //notificationssettings.NtfcTransactionalEmailForm();
            System.Threading.Thread.Sleep(2000);
            //notificationssettings.NtfcBatchEmailForm();
            System.Threading.Thread.Sleep(2000);
            //notificationssettings.NtfcPushNotificationsForm();
        }

        [Test]
        public void ExecuteTestToEditCompanySettings()
        {

            ExecuteTestToAccountNameCompanySettings();
            System.Threading.Thread.Sleep(2000);
            CompanySettings CompanySettingsEdit = new CompanySettings();
            CompanySettingsEdit.CompanyNameForm("Joni Company");
            CompanySettingsEdit.CompanyWebsiteForm("www.google.com");
            CompanySettingsEdit.CompanyDescriptionForm("kompani kot");
            CompanySettingsEdit.PrimaryInvestorCompanyForm();
            CompanySettingsEdit.SecondaryInvestorCompanyForm();
            CompanySettingsEdit.PortofolioSizeForm("50000");
            CompanySettingsEdit.FundDomicileInterestForm();
            CompanySettingsEdit.InvestmentVehicleInterestForm();
            //CompanySettingsEdit.FirstLossCapitalYesForm();
            // CompanySettingsEdit.EditPreferencesForm();
            CompanySettingsEdit.CompanyContinentForm();
            CompanySettingsEdit.CompanyCountryForm();
            CompanySettingsEdit.CompanyZipCodeForm("00001");
            CompanySettingsEdit.CompanyStateForm("Sidney");
            CompanySettingsEdit.CompanyCityForm("P Sherman 42");
            CompanySettingsEdit.CompanyAddress1Form("Komuna e sidnew");
            CompanySettingsEdit.CompanyAddress2Form("Lulishtja");
            CompanySettingsEdit.CompanyAddress3Form("");
            //CompanySettingsEdit.UploadCompanyPhoto();
            //CompanySettingsEdit.CancelSaveCompanySettings();
            //CompanySettingsEdit.SaveCompanySettings();
        }

        [Test]
        public void ExecuteTestToCompanyEditYourselfUser()
        {
            ExecuteTestToCompany();
            System.Threading.Thread.Sleep(2000);
            CompanyColleagueEdit CompanyColleagueEdit1 = new CompanyColleagueEdit();
            CompanyColleagueEdit1.ColleagueYourselfForm();
            System.Threading.Thread.Sleep(2000);
            CompanyColleagueEdit1.ColleagueYourselfEditProfileForm();
            System.Threading.Thread.Sleep(2000);

            EditPersonalSettings personalSettings = new EditPersonalSettings();
            personalSettings.EditPersonalSettingsMethod();
        }


    }
}