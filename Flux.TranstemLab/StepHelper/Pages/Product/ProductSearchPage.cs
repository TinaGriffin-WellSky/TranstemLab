using Flux.Core;
using Flux.Web;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace Flux.TranstemLab.StepHelper.Pages.Product
{
    public class ProductSearchPage : WebPageBase
    {
        private readonly By _elementAddProduct = By.Name("ctl00$ContentPlaceHolder1$imgAdd");
        private readonly By _elementIsbtIDOrUnitId = By.Name("ctl00$ContentPlaceHolder1$txtCordUnitID$txtScanValidate");
        private readonly By _elementProductDescCode = By.Name("ctl00$ContentPlaceHolder1$txtProductCode");
        private readonly By _elementDisposition = By.Name("ctl00$ContentPlaceHolder1$dd_disposition");
        private readonly By _elementClientStatus = By.Name("ctl00$ContentPlaceHolder1$dd_Status");
        private readonly By _elementProductType = By.Name("ctl00$ContentPlaceHolder1$dd_productType");
        private readonly By _elementDrFirstName = By.Name("ctl00$ContentPlaceHolder1$txtDonorLastName");
        private readonly By _elementDrLastName = By.Name("ctl00$ContentPlaceHolder1$txtDonorFirstName");
        private readonly By _elementColStartDate = By.Name("ctl00$ContentPlaceHolder1$txt_collectionbefore");
        private readonly By _elementColEndDate = By.Name("ctl00$ContentPlaceHolder1$txt_collectionafter");
        private readonly By _elementProcessStartDate = By.Name("ctl00$ContentPlaceHolder1$txt_processedbefore");
        private readonly By _elementProcessEndDate = By.Name("ctl00$ContentPlaceHolder1$txt_processedafter");
        private readonly By _elementSearchProductSearch = By.Name("ctl00$ContentPlaceHolder1$btnSearch");
        private readonly By _elementClearProductSearch = By.Name("ctl00$ContentPlaceHolder1$btnClear");
        private readonly By _elementProductSearchGrid = By.Id("ContentPlaceHolder1_gv1");

        //This method is to click on add product button
        public AddNewProductPage ClickOnAddProduct()
        {
            Assert.True(Actions.IsDisplayed(_elementAddProduct), "Could not find Add Product icon");
            Actions.Click(_elementAddProduct);
            Console.WriteLine("Clicked on Add Product");
            return CreateInstance<AddNewProductPage>();
        }
    }
}