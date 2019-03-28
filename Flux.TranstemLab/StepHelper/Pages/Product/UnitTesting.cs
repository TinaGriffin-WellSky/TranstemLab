using Flux.Core;
using Flux.Web;
using OpenQA.Selenium;

namespace Flux.TranstemLab.StepHelper.Pages.Product
{
    public class UnitTestingPage : WebPageBase
    {
        private readonly By _elementNavigateToProductHome = By.Id("ContentPlaceHolder1_btn_Summary");
        private readonly By _elementIdm = By.Id("__tab_ContentPlaceHolder1_tab_main_TabPanel1");
        private readonly By _elementAboRh = By.Id("__tab_ContentPlaceHolder1_tab_main_TabPanel2");
        private readonly By _elementHemoglobin = By.Id("__tab_ContentPlaceHolder1_tab_main_TabPanel3");
        private readonly By _elementCulture = By.Id("__tab_ContentPlaceHolder1_tab_main_TabPanel4");
        private readonly By _elementHlaTyping = By.Id("__tab_ContentPlaceHolder1_tab_main_TabPanel6");

        //adding values into unit testing
        private readonly By _elementAddInitial = By.Id("ContentPlaceHolder1_tab_main_TabPanel1_IDMT1_imgAddInitial");
        private readonly By _elementAddAboRh = By.Id("ContentPlaceHolder1_tab_main_TabPanel2_ABORhTesting2_btnNewTest");
        private readonly By _elementAddCulture = By.Id("ContentPlaceHolder1_tab_main_TabPanel4_Culture1_ibNew");
        private readonly By _elementAddHlaType = By.Id("ContentPlaceHolder1_tab_main_TabPanel6_btnNewHlaTest");

        //adding values to the Hemoglobin Tab
        private readonly By _elementSampleId = By.Id("ContentPlaceHolder1_tab_main_TabPanel3_HemoTesting1_HemoglobinSampleID_txtScanValidate");
        private readonly By _elementTestSite = By.Id("ContentPlaceHolder1_tab_main_TabPanel3_HemoTesting1_TestSiteDropDownList");
        private readonly By _elementSource = By.Id("ContentPlaceHolder1_tab_main_TabPanel3_HemoTesting1_SourceDropDownList");
        private readonly By _elementReportdate = By.Id("ContentPlaceHolder1_tab_main_TabPanel3_HemoTesting1_ReportdateTextBox");
    }
}
