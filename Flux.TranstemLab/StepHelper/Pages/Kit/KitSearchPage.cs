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

namespace Flux.TranstemLab.StepHelper.Pages.Kit
{
    public class KitSearchPage : PageBase
    {
        public override string Url => "/Home";
        private readonly By _elementAddKitBtn = By.Id("ContentPlaceHolder1_imgAdd");
        private readonly By _elementBuilDistributionBtn = By.Id("ContentPlaceHolder1_imgBulkDist");
        private readonly By _elementKitIdField = By.Id("ContentPlaceHolder1_txtKitIdentifier_txtScanValidate");
        private readonly By _elementStatusDDL = By.Id("ContentPlaceHolder1_ddStatus");
        private readonly By _elementDispositionDDL = By.Id("ContentPlaceHolder1_ddDisposition");
        private readonly By _elementTypeDDL = By.Id("ContentPlaceHolder1_dd_Type");
        private readonly By _elementLotNumberField = By.Id("ContentPlaceHolder1_txt_LotNumber");
        private readonly By _elementExpirationDateRangeBegin = By.Id("ContentPlaceHolder1_txt_expirationDateRangeBegin");
        private readonly By _elementExpirationDateRangeEnd = By.Id("ContentPlaceHolder1_txt_expirationDateRangeEnd");
        private readonly By _elementSearchBtn = By.Id("ContentPlaceHolder1_btnSearch");
        private readonly By _elementCleanBtn = By.Id("ContentPlaceHolder1_btnClear");

        public AddKitPage ClickOnAddKitBtn()
        {
            Assert.True(Actions.IsDisplayed(_elementAddKitBtn), "Count not find add kit button");
            Actions.Click(_elementAddKitBtn);
            Console.WriteLine("Clicked on actions click button");
            return CreateInstance<AddKitPage>();
        }

    }
}
