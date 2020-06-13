using System;
using NUnit.Framework;
using UiTestDemoApp.UITests.Pages;
using Xamarin.UITest;

namespace UiTestDemoApp.UITests.Tests
{
    public class BaseTest
    {
        IApp app;

        public LoginPage LoginPage { get; private set; }
        public DashboardPage DashboardPage { get; private set; }

        Platform platform;
        public BaseTest(Platform platform)
        {
            this.platform = platform;
        }
        [SetUp]
        public virtual void TestSetup()
        {
            app = AppInitializer.StartApp(platform);

            LoginPage = new LoginPage(app, "LoginPage");
            DashboardPage = new DashboardPage(app, "DashboardPage");


        }
    }
}
