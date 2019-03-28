using Flux.Core;
using Flux.Web;
using Flux.TranstemLab.StepHelper.Pages.Product;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Flux.TranstemLab.StepHelper.Pages.Donors
{
    public class DonorHomePage : WebPageBase
    {
        /*
        private string firstName;
        private string lastName;
        private string birthDate;
        */
        public string donorIDText = string.Empty;
        private readonly By _elementDonorIDField = By.Id("ContentPlaceHolder1_spnDonorId");
        private readonly By _elementDonorCollectionevenBtn = By.Id("ContentPlaceHolder1_btnAddCollectionEvent");
        private readonly By _elementProductIcon = By.Name("ctl00$searchBlock1$ctl03");
        private readonly By _elementProductLink = By.XPath("(//SPAN[text()='Products'][text()='Products'])[1]");
        private readonly By _elementProductSearch = By.Id("searchBlock1_pnlProductSearchCollapse");

        public string GetDonorID() { return donorIDText; }

        //Get the DonorID to create product
        public void SetDonorID()
        {
            donorIDText = Actions.GetText(_elementDonorIDField);
        }

        //this method is used to create an add collection page
        public DonorCollectionEventsPage CreateCollectionEventPage()
        {
            Assert.True(Actions.IsDisplayed(_elementDonorCollectionevenBtn), "Donor collection event is not found");
            return CreateInstance<DonorCollectionEventsPage>();
        }

        //Navigate to search product page
        public ProductSearchPage NavigateToProduct()
        {
            //Thread.Sleep(500);
            Actions.MouseHover(_elementProductIcon);
            //Thread.Sleep(500);
            Actions.Click(_elementProductLink);
            //Thread.Sleep(500);
            Actions.Click(_elementProductSearch);
            //Thread.Sleep(500);

            return CreateInstance<ProductSearchPage>();
        }
    }
}
