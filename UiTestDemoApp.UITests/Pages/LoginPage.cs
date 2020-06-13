using System;
using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;
namespace UiTestDemoApp.UITests.Pages
{
    public class LoginPage
    {
        private IApp app;
        private string pageTitle;

        readonly Query _usernameTextField, _passwordTextField, _loginButton;
            
        public LoginPage(IApp app, string pageTitle)
        {
            this.app = app;
            this.pageTitle = pageTitle;
            _passwordTextField = x => x.Marked(AutomationIdConstants.LoginPage_txtPassword);

            _usernameTextField = x => x.Marked(AutomationIdConstants.LoginPage_txtUsername);
            _loginButton = x => x.Marked(AutomationIdConstants.LoginPage_LoginButton);
            

        }

        public void TestLoginSuccess(String username,String password)
        {
            
            app.WaitForElement(_usernameTextField, timeout: TimeSpan.FromSeconds(30));
            app.Tap(_usernameTextField);
            app.EnterText(username);
            app.DismissKeyboard();
            app.Tap(_passwordTextField);
            app.EnterText(password);
            app.DismissKeyboard();
            app.Tap(_loginButton);


        }
        public void SendAppToBackground()
        {
            app.Invoke("SendAppToBackground");
        }


    }
}
