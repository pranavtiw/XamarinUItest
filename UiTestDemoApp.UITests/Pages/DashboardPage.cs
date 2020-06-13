using System;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;
using Xamarin.UITest;

namespace UiTestDemoApp.UITests.Pages
{
    public class DashboardPage
    {
        readonly Query  _dashboardSuccess;
        private IApp app;
        private string pageTitle;
        public DashboardPage(IApp App, string pageTitle)
        {
            app = App;
            _dashboardSuccess = x => x.Text(AutomationIdConstants.Dasboard_SuccessText);
        }
        public void AssertDashboardPage()
        {
            app.WaitForElement(_dashboardSuccess, timeout: TimeSpan.FromSeconds(30));
            
        }
    }
}
