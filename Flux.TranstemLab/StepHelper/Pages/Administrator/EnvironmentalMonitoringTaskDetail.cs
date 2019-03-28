using Flux.Web;
using OpenQA.Selenium;
using System;

namespace Flux.TranstemLab.StepHelper.Pages.Administrator
{
    public class EnvironmentalMonitoringTaskDetail : WebPageBase
    {
        private int numColumn = 0;
        private readonly By _elementTaskNameField = By.Id("TaskName");
        private readonly By _elementSaveBtn = By.Id("btnSubmitTaskDetail");
        private readonly By _elementAddColumnBtn = By.Id("btnAddColumn");
        private readonly By _elementAddValue = By.Id("btnAddValue");
        private readonly By _elementSaveBtnFromPopUp = By.Id("btnSaveValuesList");


        //This method is to send a name to task name field
        public void EnterTaskName(string taskName)
        {
            Actions.SendKeys(_elementTaskNameField, taskName);
            Console.WriteLine(taskName + " is entered in Task Name field");
        }

        //this method is used to click on save button
        public void ClickOnSaveBtn()
        {
            Actions.Click(_elementSaveBtn);
            Console.WriteLine("Task Name is saved");
        }

        //thos method is used to click on add column
        public void ClickOnAddColumn(int numColumn)
        {
            this.numColumn = numColumn;
            for (int i = 0; i < numColumn; i++)
            {
                Actions.Click(_elementAddColumnBtn);
                Waits.WaitForPageLoad();
            }
        }

        //this method is to fill in the empty columns
        public void FillInColumns(string name)
        {
            Random rnd = new Random();
            for (int i = 0; i < numColumn; i++)
            {
                //send the name with index
                Actions.SendKeys(By.Id("Columns_" + i.ToString() + "__ColumnName"), name + i.ToString());
                Console.WriteLine("Value entered in column " + i + " is " + name + i.ToString());
                //when it can be divided by 3, select a text box
                if (i % 3 == 0)
                {
                    Actions.SelectByIndex(By.Id("ddlDataType_" + i), 1);
                }
                //when it can be divided by 2, select a check box
                else if (i % 2 == 0)
                {
                    Actions.SelectByIndex(By.Id("ddlDataType_" + i), 2);
                }
                //else select a drop down list
                else
                {
                    Actions.SelectByIndex(By.Id("ddlDataType_" + i), 3);
                    Actions.Click(By.Id("val_" + i.ToString()));
                    Waits.WaitForPageLoad();
                    for (int j = 0; j < numColumn; j++)
                    {
                        //add same amount of drop down list in the pop up window
                        Actions.Click(_elementAddValue);
                        Actions.SendKeys(By.Id("CurrentColumn_Values_" + j + "__ValueName"), name + i.ToString() + j.ToString());
                    }
                    Actions.Click(_elementSaveBtnFromPopUp);
                    Waits.WaitForPageLoad();
                }

                Actions.SendKeys(By.Id("Columns_" + i + "__TextLength"), "10");
                Actions.SendKeys(By.Id("Columns_" + i + "__Sort"), (i + 1).ToString());

                //randomly select isrequired check box
                int ran = rnd.Next(0, 99);
                if (ran % 2 == 0)
                {
                    Actions.Click(By.Id("Columns_" + i + "__IsRequired"));
                    Console.WriteLine("Column " + i + " is required");
                }

                Console.WriteLine(Actions.GetAttributeValue(By.Id("ddlDataType_" + i), "value") + " is selected in the drop down");
                Console.WriteLine("The length entered is 10");
                Console.WriteLine("The sort was entered");
            }
        }
    }
}
