using System;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UiTestDemoApp.UITests.Tests
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class LoginTest:BaseTest
    {
        Platform platform;
        public LoginTest(Platform platform) : base(platform)
        {
            this.platform = platform;
        }
        [Test]
        public void CheckLoginSuccess()
        {
            LoginPage.TestLoginSuccess(AutomationIdConstants.Username, AutomationIdConstants.Password);
            DashboardPage.AssertDashboardPage();
        }

        [Test]
        public void CheckLoginSuccessWithWrongCredentials()
        {
            LoginPage.TestLoginSuccess(AutomationIdConstants.WrongUsername, AutomationIdConstants.Password);
            DashboardPage.AssertDashboardPage();
        }

        [Test]
        public void BackdoorMethod()
        {
            LoginPage.TestLoginSuccess(AutomationIdConstants.Username, AutomationIdConstants.Password);
            DashboardPage.AssertDashboardPage();
            LoginPage.SendAppToBackground();
            DashboardPage.AssertDashboardPage();

        }

       

    }
}
