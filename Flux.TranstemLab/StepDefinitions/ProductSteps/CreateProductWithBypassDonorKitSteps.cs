using Flux.TranstemLab.StepHelper.Base;
using TechTalk.SpecFlow;

namespace Flux.TranstemLab.StepDefinitions
{
    [Binding]
    public class CreateProductWithBypassDonorKitSteps
    {
        private readonly Pages pages;

        public CreateProductWithBypassDonorKitSteps(Pages pages)
        {
            this.pages = pages;
        }

        [Then(@"I click on Bypass Donor/Kit")]
        public void ThenIClickOnBypassDonorKit()
        {
            pages.addNewProductPage.ClickOnBypassDonorKit();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I click on Bypass Sync")]
        public void ThenIClickOnBypassSync()
        {
            pages.addNewProductPage.ClickOnBypassSync();
            pages.commonMethodsPage.TakeScreenShot();
        }

        [Then(@"I fill in the Collection Event Data")]
        public void ThenIFillInTheCollectionEventData()
        {
            pages.commonMethodsPage = pages.transtemLabHomePage.ReferenceForCommonMethods();
            int randomNumber = pages.commonMethodsPage.GetRandomNumber(0, 999);
            int volume = pages.commonMethodsPage.GetRandomNumber(68, 200);
            string randomName = pages.commonMethodsPage.GenerateName(5);
            string CollectionTime = pages.commonMethodsPage.GetRandomNumber(0, 23).ToString() + pages.commonMethodsPage.GetRandomNumber(0, 59).ToString();
            string startDate = pages.commonMethodsPage.GetFutureDate(5);

            pages.addNewProductPage.FillInCollectionEventForm(randomNumber, randomName, startDate, CollectionTime, volume);
        }

        [Then(@"I click on the Create Product from Bypass Donor/Kit")]
        public void ThenIClickOnTheaddNewProductPage()
        {
            pages.addNewProductPage.ClickOnCreateProduct();
            pages.commonMethodsPage.TakeScreenShot();
        }
    }
}
