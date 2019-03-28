using Flux.Core;
using Flux.Web;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;

namespace Flux.TranstemLab.StepHelper.Pages.Administrator
{
    public class AddUserPage : WebPageBase
    {
        // Main Info
        private readonly By _elementFirstName = By.Id("ContentPlaceHolder1_firstname");
        private readonly By _elementMiddleInitial = By.Id("ContentPlaceHolder1_middleinitial");
        private readonly By _elementLastName = By.Id("ContentPlaceHolder1_lastname");
        private readonly By _elementActiveUser = By.Id("ContentPlaceHolder1_isapproved");
        private readonly By _elementUserName = By.Id("ContentPlaceHolder1_isapproved");
        private readonly By _elementPassword = By.Id("ContentPlaceHolder1_password");
        private readonly By _elementEmail = By.Id("ContentPlaceHolder1_email");
        private readonly By _elementComment = By.Id("ContentPlaceHolder1_comment");
        // Regions
        private readonly By _elementRegions = By.Id("ContentPlaceHolder1_lstRegion");
        // Default Region
        private readonly By _elementDefaultRegion = By.Id("ContentPlaceHolder1_ddlRegion");
        // Signature
        private readonly By _elementUploadSignature = By.Id("ContentPlaceHolder1_UploadSignature");
        // Image Upload pop-up
        private readonly By _elementChooseFile = By.Id("ContentPlaceHolder1_ctrlFileUpload_filSelect");
        private readonly By _elementUpload = By.Id("ContentPlaceHolder1_ctrlFileUpload_btnUpload");
        // Roles
        private readonly By _elementAdmin = By.Id("ContentPlaceHolder1_UserRoles_0");
        private readonly By _elementCollectionsStaff = By.Id("ContentPlaceHolder1_UserRoles_1");
        private readonly By _elementCollector = By.Id("ContentPlaceHolder1_UserRoles_2");
        private readonly By _elementDonor = By.Id("ContentPlaceHolder1_UserRoles_3");
        private readonly By _elementDonorMgmt = By.Id("ContentPlaceHolder1_UserRoles_4");
        private readonly By _elementLDStaff = By.Id("ContentPlaceHolder1_UserRoles_5");
        private readonly By _elementLabBloodBank = By.Id("ContentPlaceHolder1_UserRoles_6");
        private readonly By _elementLab = By.Id("ContentPlaceHolder1_UserRoles_7");
        private readonly By _elementLabSup = By.Id("ContentPlaceHolder1_UserRoles_8");
        private readonly By _elementMgmt = By.Id("ContentPlaceHolder1_UserRoles_9");
        private readonly By _elementQuality = By.Id("ContentPlaceHolder1_UserRoles_10");
        private readonly By _elementRecipientMgmt = By.Id("ContentPlaceHolder1_UserRoles_11");

        private readonly By _elementAddUser = By.Id("ContentPlaceHolder1_AddUser");
        private readonly By _elementReset = By.Id("ContentPlaceHolder1_btnReset");

        public void ClickOnUpload()
        {
            Waits.WaitForElementToBeClickable(_elementUpload, WaitType.Small);
            Actions.Click(_elementUpload);
            Console.WriteLine("Clicked on Upload button of Image Upload pop-up");
            Waits.WaitForPageLoad();
            Waits.WaitForPageLoad();
            //Waits.WaitForElementToBeInvisible(_elementUpload, WaitType.Large);
            Console.WriteLine("Image Upload pop-up disappeared");
        }

        public void TypeFirstName(string name)
        {
            Actions.SendKeys(_elementFirstName, name);
            Console.WriteLine("Typed first name");
        }

        public void TypeMiddleInitial(char initial)
        {
            Actions.SendKeys(_elementMiddleInitial, initial.ToString());
            Console.WriteLine("Typed middle initial");
        }

        public void TypeLastName(string name)
        {
            Actions.SendKeys(_elementLastName, name);
            Console.WriteLine("Typed last name");
        }

        // Checks Active User checkbox if unchecked and parameter is true; unchecks Active User checkbox if checked and parameter is false
        public void AlterActiveUser(bool active)
        {
            if (active)
            {
                if (Actions.IsSelected(_elementActiveUser))
                {
                    Console.WriteLine("User already listed as active");
                }
                else
                {
                    Actions.SelectCheckbox(_elementActiveUser);
                    Console.WriteLine("Checked Active User checkbox");
                }
            }
            else
            {
                if (Actions.IsSelected(_elementActiveUser))
                {
                    Actions.UnselectCheckbox(_elementActiveUser);
                    Console.WriteLine("Unchecked Active User checkbox");
                }
                else
                {
                    Console.WriteLine("User already listed as inactive");
                }
            }
        }

        public void TypeUserName(string username)
        {
            Actions.SendKeys(_elementUserName, username);
            Console.WriteLine("Typed User Name");
        }

        public void TypePassword(string password)
        {
            Actions.SendKeys(_elementPassword, password);
            Console.WriteLine("Typed password");
        }

        public void TypeEmail(string email)
        {
            Actions.SendKeys(_elementEmail, email);
            Console.WriteLine("Typed email");
        }

        public void TypeComment(string comment)
        {
            Actions.SendKeys(_elementComment, comment);
            Console.WriteLine("Typed comment");
        }

        public void FillInMainInfo(string firstName, char middleInitial, string lastName, bool activeUser, string userName, string password, string email, string comment = "")
        {
            TypeFirstName(firstName);
            TypeMiddleInitial(middleInitial);
            TypeLastName(lastName);
            AlterActiveUser(activeUser);
            TypeUserName(userName);
            TypePassword(password);
            TypeEmail(email);
            TypeComment(comment);
        }

        public string GetRegionValue(int ordinal)
        {
            switch (ordinal)
            {
                case 0:
                    return "267599";
                case 1:
                    return "267589";
                case 2:
                    return "267601";
                case 3:
                    return "267594";
                default:
                    Console.WriteLine("No region option for selected region index");
                    return "error"; // handle better
            }
        }

        public void SelectRegions(bool[] selectedRegion)
        {
            string value;
            By regionElement;
            SelectElement regionList = new SelectElement(Actions.FindElement(_elementDefaultRegion));

            for (int i = 0; i < selectedRegion.Length; i++)
            {
                value = GetRegionValue(i);
                regionElement = By.CssSelector("option[value=" + value + "]");

                if (selectedRegion[i])
                {
                    if (Actions.IsSelected(regionElement))
                    {
                        Console.WriteLine("Region " + i.ToString() + " is already selected");
                    }
                    else
                    {
                        regionList.SelectByValue(value);
                        Console.WriteLine("Region " + i.ToString() + " selected");
                    }
                }
                else
                {
                    if (Actions.IsSelected(regionElement))
                    {
                        regionList.DeselectByValue(value);
                        Console.WriteLine("Region " + i.ToString() + " deselected");
                    }
                    else
                    {
                        Console.WriteLine("Region " + i.ToString() + " is already deselected");
                    }
                }
            }
        }

        public void SelectDefaultRegion()
        {
            Actions.SelectByRandoxIndex(_elementDefaultRegion);
            Console.WriteLine("Selected random Default Region");
        }

        public void UploadSignature()
        {
            Actions.Click(_elementUploadSignature);
            Console.WriteLine("Clicked on Upload Signature");

            //object directoryName = "";
            Console.WriteLine("Current Path is " + AppContext.BaseDirectory);
            string filePath = AppContext.BaseDirectory;
            filePath = filePath.Replace(@"\Flux.TranstemLab\bin\Debug\", "\\Attachment\\Signature.jpg");
            Waits.WaitForElementToBePresent(_elementChooseFile, WaitType.Medium);

            if (Actions.IsDisplayed(_elementChooseFile))
            {
                Actions.FindElement(_elementChooseFile).SendKeys(filePath);
            }

            // directoryName = new DirectoryInfo(filePath).Name;
            ClickOnUpload();
            Console.WriteLine("File has been uploaded successfully");
        }

        public void SelectRoles(bool[] assignedRoles)
        {
            string baseId = "ContentPlaceHolder1_UserRoles_";
            string fullId;

            for (int i = 0; i < assignedRoles.Length; i++)
            {
                fullId = baseId + i.ToString();

                // if role is to be assigned
                if (assignedRoles[i])
                {
                    if (Actions.IsSelected(By.Id(fullId)))
                    {
                        Console.WriteLine("Role " + i.ToString() + " already checked");
                    }
                    else
                    {
                        Actions.SelectCheckbox(By.Id(fullId));
                        Console.WriteLine("Checked box for role " + i.ToString());
                    }
                }
                else
                {
                    if (Actions.IsSelected(By.Id(fullId)))
                    {
                        Actions.UnselectCheckbox(By.Id(fullId));
                        Console.WriteLine("Unchecked box for role " + i.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Role " + i.ToString() + " already unchecked");
                    }
                }
            }
        }

        public void FillInAllInfo(string firstName, char middleInitial, string lastName, bool activeUser, string userName, string password, string email, string comment, bool[] regions, bool[] roles)
        {
            FillInMainInfo(firstName, middleInitial, lastName, activeUser, userName, password, email, comment);
            SelectRegions(regions);
            SelectDefaultRegion();
            UploadSignature();
            SelectRoles(roles);
        }

        public UserMgmtPage ClickOnAddUser()
        {
            Actions.Click(_elementAddUser);
            Console.WriteLine("Clicked on Add User");
            Waits.WaitForPageLoad();
            return CreateInstance<UserMgmtPage>();
        }
    }
}
