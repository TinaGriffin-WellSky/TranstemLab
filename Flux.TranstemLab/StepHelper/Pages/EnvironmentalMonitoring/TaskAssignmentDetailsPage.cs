using Flux.Web;
using OpenQA.Selenium;
using System;
using System.Collections;

namespace Flux.TranstemLab.StepHelper.Pages.EnvironmentalMonitoring
{
    public class TaskAssignmentDetailsPage : WebPageBase
    {
        private readonly By _elementEnvironmentalMonitoringTasksDDL = By.Id("ddlTasks");
        private readonly By _elementAddTaskBtn = By.Id("btnAddResponse");
        private readonly By _elementStartDateField = By.Id("startdatepicker");
        private readonly By _elementEndDateField = By.Id("enddatepicker");
        private readonly By _elementuserNameField = By.Id("UserNum");
        private readonly By _elementSearchBtn = By.Id("btnSearch");
        private readonly By _elementAcceptableCheckBox = By.Id("QcAccept");
        private readonly By _elementNotAcceptableCheckBox = By.Id("QcNotAccept");
        private readonly By _elementNotReviewedCheckBox = By.Id("QcNotReview");
        private readonly By _elementPrintBtn = By.Id("btnPrint");
        private readonly By _elementEditLink = By.Id("EditLink");
        private readonly By _elementSaveTaskResponse = By.Id("btnSaveResponse");
        private readonly By _elementTimeQCPerformedField = By.Id("QCDate_0");
        private readonly By _elementQCResultAcceptableRadio = By.CssSelector("input[value='true']");
        private readonly By _elementQCComments = By.Id("Responses_0__QCComments");
        private readonly By _elementUpdateLink = By.CssSelector("a[class='UpdateLink']");

        //this method is used to click on the add task button
        public void ClickOnAddTaskBtn()
        {
            Actions.Click(_elementAddTaskBtn);
            Console.WriteLine("add task button is being clicked");
        }

        //this method is used to fill in the pop up window for add task
        public void FillInPopUpWindow(string date)
        {
            int i = 0;
            while (true)
            {
                string ColumnsId = "NewResponse_Columns_";
                By CheckBox = By.Id(ColumnsId + i.ToString() + "__IsChecked");
                By TextField = By.Id(ColumnsId + i.ToString() + "__ResponseText");
                By DropDownList = By.Id(ColumnsId + i.ToString() + "__ValueId");

                if (Actions.IsDisplayed(CheckBox))
                {
                    Actions.SelectCheckbox(CheckBox);
                    Console.WriteLine("Check box in the task response is being checked");
                }

                else if (Actions.IsDisplayed(TextField))
                {
                    Actions.SendKeys(TextField, date);
                    Console.WriteLine(date + " is entered in the date field");
                }

                else if (Actions.IsDisplayed(DropDownList))
                {
                    Actions.SelectByRandoxIndex(DropDownList);
                    Console.WriteLine(Actions.GetAttributeValue(DropDownList, "value") + " is selected from the drop down list");
                }

                else break;

                i++;
            }
        }

        public void ClickOnSaveBtnFromTaskResponse()
        {
            Actions.Click(_elementSaveTaskResponse);
            Console.WriteLine("Save button is clicked");
        }

        public void ClickOnEditLink()
        {
            Actions.Click(_elementEditLink);
            Console.WriteLine("Edit link is clicked");
        }

        //this method is used to fill in the table
        public void FillInTable(string date)
        {
            Actions.SendKeys(_elementTimeQCPerformedField, date);
            Actions.Click(_elementQCResultAcceptableRadio);
            Actions.SendKeys(_elementQCComments, "testing");
            Console.WriteLine(date + " is entered in QC date performed, " + " radio is selected as acceptable, the comments entered is testing");
        }

        //this method is used to click on update link
        public void ClickOnUpdateLink()
        {
            Actions.Click(_elementUpdateLink);
            Console.WriteLine("UpdateLink is clicked");
        }
    }
}
