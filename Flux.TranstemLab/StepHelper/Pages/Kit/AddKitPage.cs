using Flux.Web;
using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Flux.TranstemLab.StepHelper.Pages.Kit
{
    public class AddKitPage : WebPageBase
    {
        private readonly By _elementKitSaveBtn = By.Id("ContentPlaceHolder1_btnSave");

        //This method is used to enter the fields to create a new kit( having issue now)
        public void EnterAllFileds(string InHouseID, string LotNumber, string LabelPerKit, string KitExpiration)
        {
            ArrayList allFieldsName = new ArrayList();
            allFieldsName.Add(InHouseID);
            allFieldsName.Add(LotNumber);
            allFieldsName.Add(LabelPerKit);
            allFieldsName.Add(KitExpiration);

            //fill in all fields
            ArrayList allFieldsID = new ArrayList() { "ClientIdentifier", "LotNumber", "DINQuantity", "KitExpirationDate" };
            for (int i = 0; i < allFieldsID.Count; i++)
            {
                By _elementFieldsName = By.Id("ContentPlaceHolder1_ctrlEditKit_txt" + allFieldsID[i]);
                //Thread.Sleep(1000);
                Actions.Click(_elementFieldsName);
                Actions.FindElement(_elementFieldsName).SendKeys(Convert.ToString(allFieldsName[i]));
                Console.WriteLine("Value entered :" + Convert.ToString(allFieldsName[i]) + " to " + allFieldsID[i] + " Field");
            }

            //Thread.Sleep(1000);

            string[] dropDownListOptionsFromKit = new string[] { "lKitType", "Disposition", "lRegion" };

            for (int j = 0; j < dropDownListOptionsFromKit.Length; j++)
            {

                By _elementListoptionsFromKit = By.XPath("//SELECT[@id='ContentPlaceHolder1_ctrlEditKit_dd" + dropDownListOptionsFromKit[j] + "']");
                //Thread.Sleep(1000);
                ReadOnlyCollection<IWebElement> lstFromKit = Actions.FindElements(_elementListoptionsFromKit);
                IList<string> strList = new List<string>();

                for (int i = 0; i < lstFromKit.Count; i++)
                {
                    strList.Add(lstFromKit[i].Text);
                    Console.WriteLine(lstFromKit[i].Text);
                }

                String[] valuesFromDropDown = strList.ToArray();
                foreach (string strValues in valuesFromDropDown)
                {
                    Console.Write("Values present in drop drop list : " + strValues + ",");

                }
                Console.WriteLine();
                Actions.SelectByRandoxIndex(_elementListoptionsFromKit);
            }
        }



        //this method is to click on the save button from kit page
        public void ClickOnSaveButton()
        {
            Actions.Click(_elementKitSaveBtn);
            if (Actions.IsDisplayed(_elementKitSaveBtn))
            {
                Actions.Click(_elementKitSaveBtn);
            }
        }
    }
}
