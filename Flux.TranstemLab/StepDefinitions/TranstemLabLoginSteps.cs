using Flux.Web;
using Flux.TranstemLab.StepHelper.Base;
using Flux.TranstemLab.StepHelper.Pages;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace Flux.TranstemLab.StepDefinitions
{
    [Binding]
    public class TranstemLabLoginSteps : TranstemLabTestBase
    {
        private readonly Pages pages;

        public TranstemLabLoginSteps(Pages pages)
        {
            this.pages = pages;
        }

        [Given(@"I navigate to TranstemLab login page")]
        public void GivenINavigateToTranstemLabLoginpage()
        {
            pages.transtemLabLoginPage = Application.NewPage<TranstemLabLoginPage>().NavigateToLoginPage();
        }

        [When(@"I enter username as '(.*)'")]
        public void WhenIEnterUsernameAs(string username)
        {
            pages.transtemLabLoginPage.EnterUsername(username);
        }

        [When(@"I enter password as '(.*)'")]
        public void WhenIEnterPasswordAs(string password)
        {
            pages.transtemLabLoginPage.EnterPassword(password);
        }

        [When(@"I click the Login button")]
        public void WhenIClickTheLoginButton()
        {
            pages.transtemLabHomePage = pages.transtemLabLoginPage.ClickLogin();
            pages.commonMethodsPage = pages.transtemLabHomePage.ReferenceForCommonMethods();
            pages.commonMethodsPage.GenerateDirectory();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click LogOutLink")]
        public void ThenIClickLogOutLink()
        {
            pages.transtemLabHomePage = pages.transtemLabHomePage.ClickLogOutLink();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I should be navigated to TranstemLab login page")]
        public void ThenIShouldBeNavigatedToTranstemLabLoginPage()
        {
            pages.transtemLabLoginPage = Application.NewPage<TranstemLabLoginPage>().NavigateToLoginPage();
        }

        [Given(@"I navigate to TranstemLab application")]
        public void GivenINavigateToTranstemLabApplication()
        {
            string username = WebEnvironment.AppSettings["Username"];
            string password = WebEnvironment.AppSettings["Password"];
            pages.transtemLabLoginPage = Application.NewPage<TranstemLabLoginPage>().NavigateToLoginPage();
            pages.transtemLabLoginPage.EnterUsername(username);
            pages.transtemLabLoginPage.EnterPassword(password);
            pages.transtemLabHomePage = pages.transtemLabLoginPage.ClickLogin();
            pages.transtemLabHomePage.VerificationOfHomePage();
            pages.commonMethodsPage = pages.transtemLabHomePage.ReferenceForCommonMethods();
            pages.commonMethodsPage.GenerateDirectory();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I Log Out")]
        public void ThenILogOut()
        {
            bool checkLogOutLink = pages.transtemLabLoginPage.ClickLogOutLink();
            pages.commonMethodsPage.TakeScreenShot();
            Assert.True(checkLogOutLink, "Logging out");
        }
    }
}
