using Flux.Core;
using Flux.Web;
using OpenQA.Selenium;
using System;

namespace Flux.TranstemLab.StepHelper.Pages.Administrator
{
    public class UserMgmtPage : WebPageBase
    {
        private readonly By _elementAddUser = By.CssSelector("a[href='add_user.aspx']");

        public AddUserPage ClickOnAddUser()
        {
            Waits.WaitForElementToBeClickable(_elementAddUser, WaitType.Small);
            Actions.Click(_elementAddUser);
            Console.WriteLine("Clicked on Add User link");
            return CreateInstance<AddUserPage>();
        }
    }
}
