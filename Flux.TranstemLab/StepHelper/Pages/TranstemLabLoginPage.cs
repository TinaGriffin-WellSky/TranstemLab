using Flux.Core;
using Flux.Web;
using OpenQA.Selenium;

namespace Flux.TranstemLab.StepHelper.Pages
{
    public class TranstemLabLoginPage : WebPageBase
    {
        private readonly By _elementUsername = By.Id("crtlLogInOut_lgnMain_UserName");
        private readonly By _elementPassword = By.Id("crtlLogInOut_lgnMain_Password");
        private readonly By _elementLogInButton = By.Id("crtlLogInOut_lgnMain_LoginButton");
        private readonly By _elementLogOutLink = By.Id("crtlLogInOut_lnkLogout");

        public TranstemLabLoginPage NavigateToLoginPage()
        {
            Actions.NavigateToUrl(WebEnvironment.AppSettings["AppUrl"]);
            return this;
        }

        public TranstemLabLoginPage EnterUsername(string username)
        {
            Actions.SendKeys(_elementUsername, username);
            return this;
        }

        public TranstemLabLoginPage EnterPassword(string password)
        {
            Actions.SendKeys(_elementPassword, password);
            return this;
        }

        public TranstemLabHomePage ClickLogin()
        {
            Actions.Click(_elementLogInButton);
            return CreateInstance<TranstemLabHomePage>();
        }

        public TranstemLabHomePage LoginToTranstemApplication()
        {
            return NavigateToLoginPage()
                                        .EnterUsername(TestEnvironment.AppSettings["Username"])
                                        .EnterPassword(TestEnvironment.AppSettings["Password"])
                                        .ClickLogin();
        }

        public bool ClickLogOutLink()
        {
            if (Actions.IsDisplayed(_elementLogOutLink))
            {
                Actions.Click(_elementLogOutLink);
                return true;
            }
            else return false;
        }
    }
}