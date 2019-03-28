using Flux.Core;
using Flux.TranstemLab.StepHelper.Base;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Flux.TranstemLab.StepHelper.Pages.Product
{
    public class CreateDonorWithANewKitPage : PageBase
    {

        public override string Url => "/Home";
        private readonly By _elementScanExistingKidIdRadioBtn = By.Id("rdExistingKitID");
        private readonly By _elementCreatNewKitBtn = By.Id("btnAddNewKit");
        private readonly By _elementKitSaveBtn = By.Id("ContentPlaceHolder1_btnSave");
        private readonly By _elementLoadBtn = By.Id("btnLoadKit");
        private readonly By _elementSyncBtn = By.Id("btnSync");

        //This method is to select the Scan/enter existing kit ID or create a new kit radio
        public void SelectExistingKitIDRadio()
        {
            if (Actions.IsDisplayed(_elementScanExistingKidIdRadioBtn))
            {
                Console.WriteLine("Navigated to product search page");
                Actions.Click(_elementScanExistingKidIdRadioBtn);
            }
        }

        //This method is to click on the Create New Kit button
        public void ClickOnCreateNewKitBtn()
        {
            if (Actions.IsDisplayed(_elementCreatNewKitBtn))
            {
                Console.WriteLine("Scan/enter existing kit ID or create a new kit radio selected");
                Actions.Click(_elementCreatNewKitBtn);
            }
        }

        //This method is used to enter the fields to create a new kit( having issue now)
        public void EnterAllFileds(string InHouseID, string LotNumber, string LabelPerKit, string KitExpiration)
        {

            //ArrayList allFieldsName = new ArrayList();
            //allFieldsName.Add(InHouseID);
            //allFieldsName.Add(LotNumber);
            //allFieldsName.Add(LabelPerKit);
            //allFieldsName.Add(KitExpiration);

            List<string> allFieldsName = new List<string>
            {
                InHouseID,
                LotNumber,
                LabelPerKit,
                KitExpiration
            };


            string[] dropDownListOptionsFromKit = new string[] { "lKitType", "Disposition", "lRegion" };

            for (int j = 0; j < dropDownListOptionsFromKit.Length; j++)
            {
                By _elementListoptionsFromKit = By.XPath("//SELECT[@id='ContentPlaceHolder1_ctrlEditKit_dd" + dropDownListOptionsFromKit[j] + "']");
                ReadOnlyCollection<IWebElement> lstFromKit = Actions.FindElements(_elementListoptionsFromKit);

                IList<string> strList = new List<string>();

                for(int i = 0; i < lstFromKit.Count; i++)
                {
                    strList.Add(lstFromKit[i].Text);
                    Console.WriteLine("The value is " + lstFromKit[i].Text +  "The count is " + i);
                }

                String[] valuesFromDropDown = strList.ToArray();

                foreach (string strValues in valuesFromDropDown)
                {
                    Console.Write("Values present in drop drop list : " + strValues + ",");
                }


                for (int i = 0; i < lstFromKit.Count; i++)
                {

                    Thread.Sleep(500);
                    lstFromKit[0].Click();
   

                    Console.WriteLine(lstFromKit[i].Text + " is selected from the " + dropDownListOptionsFromKit[j] + " dropDown");
                }

            }


            //fill in all fields
            ArrayList allFieldsID = new ArrayList() { "ClientIdentifier", "LotNumber", "DINQuantity", "KitExpirationDate" };
            for(int i = 0; i < allFieldsID.Count; i++)
            {
                By _elementFieldsName = By.Id("ContentPlaceHolder1_ctrlEditKit_txt" + allFieldsID[i]);
                Thread.Sleep(1000);
                Actions.Click(_elementFieldsName);
                Actions.FindElement(_elementFieldsName).SendKeys(Convert.ToString(allFieldsName[i]));
                Console.WriteLine("Value entered :" + Convert.ToString(allFieldsName[i]) + " to " + allFieldsID[i] + " Field");
            }

            
            Thread.Sleep(1000);
        }

        //this method is to click on the save button from kit page
        public void ClickOnSaveButton()
        {
            Actions.Click(_elementKitSaveBtn);
            if (Actions.IsDisplayed(_elementCreatNewKitBtn))
            {
                Console.WriteLine("kit created successfuly");
            }
        }

        //this method is used for click on load button
        public void ClickOnLoadKitButton()
        {
            Actions.Click(_elementLoadBtn);
            if (Actions.IsDisplayed(_elementSyncBtn))
            {
                Console.WriteLine("Match donor information page is open");
            }
        }






    }
}
