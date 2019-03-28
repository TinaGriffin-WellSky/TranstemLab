using Flux.TranstemLab.StepHelper.Base;
using TechTalk.SpecFlow;

namespace Flux.TranstemLab.StepDefinitions
{
    [Binding]
    public class NotesRecipientSteps : TranstemLabTestBase
    {
        private readonly Pages pages;
        public int RecipientID;

        public NotesRecipientSteps(Pages pages)
        {
            this.pages = pages;
        }

        [Then(@"I click on Notes for making note for the RecipientID")]
        public void ThenIClickOnNotesForMakingNoteForTheRecipientID()
        {
            pages.notesRecipientPage = pages.transtemLabHomePage.ClickOnAddNotesBtnRecipient("Note");
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I enter values for Category & for Note as Testing")]
        public void ThenIEnterValuesForCategoryForNoteAsTesting()
        {
            pages.notesRecipientPage.SelectValuesFromCategory("Notes");
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on Save Button from the Note Page")]
        public void ThenIClickOnSaveButtonFromTheNotePage()
        {
            pages.notesRecipientPage.ClickOnSaveButtonFromNotePage();
            pages.commonMethodsPage.TakeScreenShot();
            //Thread.Sleep(5000);
        }
    }
}
