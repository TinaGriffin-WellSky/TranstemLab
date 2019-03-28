using Flux.TranstemLab.StepHelper.Base;
using TechTalk.SpecFlow;

namespace Flux.TranstemLab.StepDefinitions.RecipientSteps
{
    [Binding]
    public class TransplantEventSteps : TranstemLabTestBase
    {
        private readonly Pages pages;
        public int RecipientID;

        public TransplantEventSteps(Pages pages)
        {
            this.pages = pages;
        }

        [Then(@"I Click on Add a transplant event for patient from RecipientDetail page")]
        public void ThenIClickOnAddATransplantEventForPatientFromRecipientDetailPage()
        {
            //Thread.Sleep(9000);
            pages.transplantEventPage = pages.transtemLabHomePage.ClickOnAddaTransplantEvent();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I enter value for all fields in Add Transplant Event page")]
        public void ThenIEnterValueForAllFieldsInAddTransplantEventPage()
        {
            //pages.commonMethodsPage = pages.transtemLabHomePage.ReferenceForCommonMethods();
            string DateOfNeedOrTransplantDate = pages.commonMethodsPage.GetFutureDate(2);
            int WeightKg = pages.commonMethodsPage.GetRandomNumber(50, 100);
            string LastContact = pages.commonMethodsPage.GetFutureDate(20);

            pages.transplantEventPage.EnterFieldsInAddaTransplantEvent(DateOfNeedOrTransplantDate, WeightKg, LastContact);
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on Save button form Add Tranplant Event Page")]
        public void ThenIClickOnSaveButtonFormAddTranplantEventPage()
        {
            pages.transplantEventPage.ClickOnSaveBtnFromEditTransplantEvent();
            pages.commonMethodsPage.TakeScreenShot();
            //RecipientID = pages.recipientPage.GetTheCreatedRecipientID();
            //Console.WriteLine(RecipientID + "RecipientID Gets created successfully");
        }
    }
}
