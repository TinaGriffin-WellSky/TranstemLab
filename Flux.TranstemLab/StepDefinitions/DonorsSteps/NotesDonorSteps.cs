using Flux.TranstemLab.StepHelper.Base;
using TechTalk.SpecFlow;

namespace Flux.TranstemLab.StepDefinitions.DonorsSteps
{
    [Binding]
    class NotesDonorSteps : TranstemLabTestBase
    {
        private readonly Pages pages;
        public NotesDonorSteps(Pages pages)
        {
            this.pages = pages;
        }

        [Then(@"I click on Notes for making note for the RecipientID on the Donor page")]
        public void ThenIClickOnNotesForMakingNoteForTheRecipientIDOnTheDonorPage()
        {
            pages.notesDonorPage = pages.transtemLabHomePage.ClickOnAddNotesBtnDonor("Note");
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I enter values for Category & for Note as (.*) on the Donor page")]
        public void ThenIEnterValuesForCategoryForNoteAsTestingOnTheDonorPage(string description)
        {
            //pages.commonMethodsPage = pages.transtemLabHomePage.ReferenceForCommonMethods();

            int NumbersRandom = pages.commonMethodsPage.GetRandomNumber(1, 100);
            pages.notesDonorPage.SelectValuesFromCategory("Notes");
            pages.notesDonorPage.EnterTextInDescriptionBox(description, NumbersRandom);
            pages.commonMethodsPage.TakeScreenShot();

        }

        [Then(@"I click on Save Button from the Note Page on the Donor page")]
        public void ThenIClickOnSaveButtonFromTheNotePageOnTheDonorPage()
        {
            pages.notesDonorPage.ClickOnSaveButtonFromNotePage();
            //Thread.Sleep(5000);
            pages.commonMethodsPage.TakeScreenShot();
        }
    }
}
