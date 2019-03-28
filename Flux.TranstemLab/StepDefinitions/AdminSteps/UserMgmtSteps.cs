using Flux.TranstemLab.StepHelper.Base;
using TechTalk.SpecFlow;

namespace Flux.TranstemLab.StepDefinitions.AdminSteps
{
    [Binding]
    public class UserMgmtSteps : TranstemLabTestBase
    {
        private readonly Pages pages;

        public UserMgmtSteps(Pages pages)
        {
            this.pages = pages;
        }

        [Then(@"I navigate to Administrator homepage")]
        public void ThenINavigateToAdministratorHomepage()
        {
            pages.adminHomePage = pages.transtemLabHomePage.ClickOnAdminLink();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I navigate to User Management page")]
        public void ThenINavigateToUserManagementPage()
        {
            pages.userMgmtPage = pages.adminHomePage.ClickOnUserMgmt();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I navigate to Add User page")]
        public void ThenINavigateToAddUserPage()
        {
            pages.addUserPage = pages.userMgmtPage.ClickOnAddUser();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I fill in all the information to create a user")]
        public void ThenIFillInAllTheInformationToCreateAUser()
        {
            string firstName = pages.commonMethodsPage.GenerateName(pages.commonMethodsPage.GetRandomNumber(3, 12));
            string middleName = pages.commonMethodsPage.GenerateName(pages.commonMethodsPage.GetRandomNumber(3, 12));
            string lastName = pages.commonMethodsPage.GenerateName(pages.commonMethodsPage.GetRandomNumber(3, 12));
            bool activeUser = true; // randomize
            string username = firstName[0] + lastName;
            string password = "Testing!";
            string email = username + "@icantthinkofagoodemailaddressjoke.com";
            string comment = "";
            bool[] activeRegion = { true, true, true, true }; // randomize; note it couples with default region in the page
            bool[] roles = pages.commonMethodsPage.GetRandomBooleanValues(12);

            pages.addUserPage.FillInAllInfo(firstName, middleName[0], lastName, activeUser, username, password, email, comment, activeRegion, roles);
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on Add User")]
        public void ThenIClickOnAddUser()
        {
            pages.addUserPage.ClickOnAddUser();
            pages.commonMethodsPage.TakeScreenShot();
        }
    }
}
