using Flux.Core;
using Flux.Web;
using Flux.TranstemLab.StepHelper.Pages.Donors;
using Flux.TranstemLab.StepHelper.Pages.Recipient;
using Flux.TranstemLab.StepHelper.Pages.Product;
using Flux.TranstemLab.StepHelper.Pages.ReagentsSupplies;
using OpenQA.Selenium;
using System;
using Flux.TranstemLab.StepHelper.Pages.Product.BatchProcessing;
using Flux.TranstemLab.StepHelper.Pages.Equipment;
using Flux.TranstemLab.StepHelper.Pages.EnvironmentalMonitoring;
using Flux.TranstemLab.StepHelper.Pages.Administrator;
using Flux.TranstemLab.StepHelper.Pages.Facilities;
using Flux.TranstemLab.StepHelper.Pages.Physicians;

namespace Flux.TranstemLab.StepHelper.Pages
{
    public class TranstemLabHomePage : WebPageBase
    {
        private readonly By _elementLogOutLink = By.Id("lnkLogout");
        private readonly By _elementLogOutButton = By.LinkText("Log Out");
        private readonly By _elementLogOutName = By.Name("ctl00$searchBlock1$ctl02");
        private readonly By _elementLogOut = By.Id("crtlLogInOut_lnkLogout");
        private readonly By _elementSerachButton = By.Id("ContentPlaceHolder1_btnSearch");
        private readonly By _elementIdentifier = By.LinkText("//*[text()='Last Name']");
        private readonly By _elementHeaderAddBirthEvent = By.XPath("//span[@id='ui-id-1'][text()='Add Birth Event']");
        private readonly By _elementAddBirthEvent = By.Id("ContentPlaceHolder1_btnAddBirthEvent");
        private readonly By _elementDonorsLink = By.XPath("//div[@id='cssmenu']//li/a[text()='Donors']");
        private readonly By _elementRecipientsLink = By.XPath("//div[@id='cssmenu']//li/a[text()='Recipients']");
        private readonly By _elementProductsLink = By.XPath("//div[@id='cssmenu']//li/a[text()='Products']");
        private readonly By _elementProductsSearchLink = By.XPath("(//SPAN[text()='Search'][text()='Search'])[2]");
        private readonly By _elementBatchProcessingLink = By.XPath("(//SPAN[text()='Batch Processing'][text()='Batch Processing'])[2]");
        private readonly By _elementRcpTransplantAddButton = By.Id("ContentPlaceHolder1_btnTransplantAdd");
        private readonly By _elementHomeButton = By.XPath("(//INPUT[@type='image'])[1]");
        private readonly By _elementConvertToIsbt = By.Id("btnConvert");
        private readonly By _elementQualityLink = By.XPath("//div[@id='cssmenu']//li/a[text()='Quality']");
        private readonly By _elementEnvironmentalMonitorningLink = By.XPath("(//SPAN[text()='Environmental Monitoring'][text()='Environmental Monitoring'])[2]");
        private readonly By _elementAdminLink = By.XPath("//div[@id='cssmenu']//li/a[text()='Administrator']");
        private readonly By _elementEntityManagement = By.XPath("//div[@id='cssmenu']//li/a[text()='Entity Management']");
        private readonly By _elementFacilities = By.XPath("(//SPAN[text()='Facilities'][text()='Facilities'])[2]");
        private readonly By _elementPhysicians = By.XPath("(//SPAN[text()='Physicians'][text()='Physicians'])[2]");
        //private readonly By _elementEquipmentConsumablesLink = By.XPath("(//SPAN[text()='Equipment'][text()='Equipment'])[2]");
        private readonly By _elementEquipmentConsumablesLink = By.XPath("(//A)[33]");
        private readonly By _elementReagentsLink = By.XPath("(//SPAN[text()='Reagents'][text()='Reagents'])[2]");

        // Equipment
        private readonly By _elementEquipmentAndConsumables = By.XPath("//div[@id='cssmenu']//li/a[text()='Equipment/Consumables']");
        private readonly By _elementEquipmentSearch = By.XPath("(//SPAN[text()='Equipment'][text()='Equipment'])[2]");

        public TranstemLabHomePage VerificationOfHomePage()
        {
            if (Actions.IsDisplayed(_elementLogOutLink))
            {
                Console.WriteLine("Transtem Lab Home Page is diaplyed");
            }
            return CreateInstance<TranstemLabHomePage>();
        }

        //Logout
        public TranstemLabHomePage ClickLogOutLink()
        {
            if (Actions.IsDisplayed(_elementLogOutLink))
            {
                Actions.Click(_elementLogOutLink);
                Console.WriteLine("Log Out Successful");
            }
            return CreateInstance<TranstemLabHomePage>();
        }

        public TranstemLabHomePage ClickLogOutName()
        {
            Waits.WaitForElementToBeClickable(_elementLogOutName, WaitType.ImplicitWaitTime);
            Actions.Click(_elementLogOutName);
            Console.WriteLine("Log Out Successful");
            return CreateInstance<TranstemLabHomePage>();
        }

        public TranstemLabHomePage ClickLogOutButton()
        {
            if (Actions.IsDisplayed(_elementSerachButton))
            {
                Actions.Click(_elementLogOutButton);
                Console.WriteLine("Log Out Successful");
            }
            return CreateInstance<TranstemLabHomePage>();
        }

        public TranstemLabHomePage ClickLogOut()
        {
            if (Actions.IsDisplayed(_elementLogOut))
            {
                Actions.Click(_elementLogOut);
                Console.WriteLine("Log Out Successful");
            }
            return CreateInstance<TranstemLabHomePage>();
        }

        public DonorCollectionEventsPage ClickOnDonorLink()
        {
            if (Actions.IsDisplayed(_elementDonorsLink))
            {
                Waits.WaitForElementToBeClickable(_elementDonorsLink, WaitType.Small);
                Actions.Click(_elementDonorsLink);
                if (Actions.IsDisplayed(_elementSerachButton))
                {
                    Console.WriteLine("Donor link is visible ======");
                }
            }
            return CreateInstance<DonorCollectionEventsPage>();
        }

        public DonorBirthEventPage ClickOnAddBirthEvent()
        {
            if (Actions.IsEnabled(_elementAddBirthEvent))
            {
                Actions.Click(_elementAddBirthEvent);
            }
            Report.LogPassedTest("Clicked on Add Birth Event page successfully from the Donor Page");
            Console.WriteLine("Clicked on Add Birth Event page successfully from the Donor Page");
            return CreateInstance<DonorBirthEventPage>();
        }

        public RecipientPage ClickOnRecipientLink()
        {
            if (Actions.IsDisplayed(_elementRecipientsLink))
            {
                Waits.WaitForElementToBeClickable(_elementRecipientsLink, WaitType.Small);
                Actions.Click(_elementRecipientsLink);
            }
            return CreateInstance<RecipientPage>();
        }

        public DocumentDonorPage ClickOnAddDocumentsBtnDonor(String TypeButton)
        {
            //Thread.Sleep(500);
            //ContentPlaceHolder1_btnAddNote
            //Note, Document,ContentPlaceHolder1_btnAddNote,ContentPlaceHolder1_btnAddDocument
            By _ElementDocuments = By.Id("ContentPlaceHolder1_btnAdd" + TypeButton + "");

            if (Actions.IsEnabled(_ElementDocuments))
            {
                //Thread.Sleep(2000);
                //Waits.WaitForElementToBePresent(_ElementDocuments, WaitType.ImplicitWaitTime);
                Waits.WaitForPageLoad();
                Actions.Click(_ElementDocuments);
            }
            Console.WriteLine("Clciked on Add" + TypeButton + " plus sign from the RecipientDetail page");
            return CreateInstance<DocumentDonorPage>();
        }

        public NotesDonorPage ClickOnAddNotesBtnDonor(String TypeButton)
        {
            //Thread.Sleep(6000);
            //ContentPlaceHolder1_btnAddNote
            //Note, Document,ContentPlaceHolder1_btnAddNote,ContentPlaceHolder1_btnAddDocument
            By _ElementDocuments = By.Id("ContentPlaceHolder1_btnAdd" + TypeButton + "");

            if (Actions.IsEnabled(_ElementDocuments))
            {
                Waits.WaitForElementToBePresent(_ElementDocuments, WaitType.Large);
                Actions.Click(_ElementDocuments);
            }
            Console.WriteLine("Clciked on Add" + TypeButton + " plus sign from the RecipientDetail page");
            return CreateInstance<NotesDonorPage>();
        }

        public TransplantEventPage ClickOnAddaTransplantEvent()
        {
            //Thread.Sleep(2000);
            if (Actions.IsEnabled(_elementRcpTransplantAddButton))
            {
                Actions.Click(_elementRcpTransplantAddButton);
                Console.WriteLine("Clicked on Add Transplant Event Button Successfully ");
            }
            return CreateInstance<TransplantEventPage>();
        }

        //This Method is for clicking on Document & Note plus sign from RecipientDetail page
        public DocumentsRecipientPage ClickOnAddDocumentsBtnRecipient(String TypeButton)
        {
            //Thread.Sleep(500);
            //ContentPlaceHolder1_btnAddNote
            //Note, Document,ContentPlaceHolder1_btnAddNote,ContentPlaceHolder1_btnAddDocument
            By _ElementDocuments = By.Id("ContentPlaceHolder1_btnAdd" + TypeButton + "");

            if (Actions.IsEnabled(_ElementDocuments))
            {
                //Thread.Sleep(1000);
                Waits.WaitForElementToBePresent(_ElementDocuments, WaitType.ImplicitWaitTime);
                Actions.Click(_ElementDocuments);
            }
            Console.WriteLine("Clicked on Add" + TypeButton + " plus sign from the RecipientDetail page");
            return CreateInstance<DocumentsRecipientPage>();
        }

        //This Method is for clicking on Document & Note plus sign from RecipientDetail page
        public NotesRecipientPage ClickOnAddNotesBtnRecipient(String TypeButton)
        {
            //Thread.Sleep(500);
            //ContentPlaceHolder1_btnAddNote
            //Note, Document,ContentPlaceHolder1_btnAddNote,ContentPlaceHolder1_btnAddDocument
            By _ElementDocuments = By.Id("ContentPlaceHolder1_btnAdd" + TypeButton + "");

            if (Actions.IsEnabled(_ElementDocuments))
            {
                Waits.WaitForElementToBePresent(_ElementDocuments, WaitType.Large);
                Actions.Click(_ElementDocuments);
            }
            Console.WriteLine("Clciked on Add" + TypeButton + " plus sign from the RecipientDetail page");
            return CreateInstance<NotesRecipientPage>();
        }

        public CommonMethodsPage ReferenceForCommonMethods()
        {
            Console.WriteLine("Accessing Common methods reference");
            return CreateInstance<CommonMethodsPage>();
        }

        public AddDonorPage ClickOnDonorLinkToAdd()
        {
            By _elementDonorsLink = By.XPath("//div[@id='cssmenu']//li/a[text()='Donors']");
            if (Actions.IsDisplayed(_elementDonorsLink))
            {
                Waits.WaitForElementToBeClickable(_elementDonorsLink, WaitType.Small);
                Actions.Click(_elementDonorsLink);
                if (Actions.IsDisplayed(_elementSerachButton))
                {
                    Console.WriteLine("Donor link is visible ======");
                }
            }
            return CreateInstance<AddDonorPage>();
        }

        //this method is for open donor search page
        public DonorSearchPage ClickOnDonorLinkToSearch()
        {
            By _elementDonorsLink = By.XPath("//div[@id='cssmenu']//li/a[text()='Donors']");
            if (Actions.IsDisplayed(_elementDonorsLink))
            {
                Waits.WaitForElementToBeClickable(_elementDonorsLink, WaitType.Small);
                Actions.Click(_elementDonorsLink);
                if (Actions.IsDisplayed(_elementSerachButton))
                {
                    Console.WriteLine("Donor link is visible ======");
                }
            }
            return CreateInstance<DonorSearchPage>();
        }

        public ProductSearchPage ClickOnProductToAdd()
        {
            if (Actions.IsDisplayed(_elementProductsLink))
            {
                Waits.WaitForElementToBeClickable(_elementProductsLink, WaitType.Small);
                Actions.Click(_elementProductsLink);
                Waits.WaitForElementToBeClickable(_elementProductsSearchLink, WaitType.Small);
                Actions.Click(_elementProductsSearchLink);
            }
            return CreateInstance<ProductSearchPage>();
        }

        public SearchBatchPage ClickOnBatchProcessing()
        {
            if (Actions.IsDisplayed(_elementProductsLink))
            {
                Waits.WaitForElementToBeClickable(_elementProductsLink, WaitType.Small);
                Actions.Click(_elementProductsLink);
                Waits.WaitForElementToBeClickable(_elementProductsSearchLink, WaitType.Small);
                Actions.Click(_elementBatchProcessingLink);
            }
            return CreateInstance<SearchBatchPage>();
        }

        public RecipientSearchpage SearchForRecipient()
        {
            if (Actions.IsDisplayed(_elementRecipientsLink))
            {
                Waits.WaitForElementToBeClickable(_elementRecipientsLink, WaitType.Small);
                Actions.Click(_elementRecipientsLink);
            }
            //Waits.WaitForPageLoad();
            return CreateInstance<RecipientSearchpage>();
        }

        //Convert Unit id to Isbt 
        public ProductHomePage ClickOnIsbtBtn()
        {
            if (Actions.IsDisplayed(_elementConvertToIsbt))
            {
                Waits.WaitForElementToBePresent(_elementConvertToIsbt, WaitType.Large);
                //Thread.Sleep(500);
                Actions.Click(_elementConvertToIsbt);
                Console.WriteLine("Unit ID converted to Isbt");
            }
            return CreateInstance<ProductHomePage>();
        }

        public void CloseBrowser()
        {
            Actions.CloseBrowser();
        }

        public SearchReagentPage ClickOnReagents()
        {
            //Thread.Sleep(2000);
            if (Actions.IsDisplayed(_elementEquipmentConsumablesLink))
            {
                Waits.WaitForElementToBeClickable(_elementEquipmentConsumablesLink, WaitType.Small);
                Actions.Click(_elementEquipmentConsumablesLink);
                Waits.WaitForElementToBeClickable(_elementReagentsLink, WaitType.Small);
                Actions.Click(_elementReagentsLink);
            }
            return CreateInstance<SearchReagentPage>();
        }

        public EquipmentSearchPage ClickOnEquipment()
        {
            if (Actions.IsDisplayed(_elementEquipmentAndConsumables))
            {
                Actions.Click(_elementEquipmentAndConsumables);
                Waits.WaitForElementToBeClickable(_elementEquipmentSearch, WaitType.Small);
                Actions.Click(_elementEquipmentSearch);
            }
            return CreateInstance<EquipmentSearchPage>();
        }

        //this method opens the enviromnetal page
        public EnvironmentalMonitoringHomePage ClickOnEnvironmentalMonitoring()
        {
            Actions.Click(_elementQualityLink);
            Console.WriteLine("Quaility link is being clicked");
            Waits.WaitForElementToBeClickable(_elementEnvironmentalMonitorningLink, WaitType.Medium);
            Actions.Click(_elementEnvironmentalMonitorningLink);
            Console.WriteLine("Navigated to environmental monitoring home page");
            return CreateInstance<EnvironmentalMonitoringHomePage>();
        }

        //this method is to open the admin page
        public AdminHomePage ClickOnAdminLink()
        {
            Actions.Click(_elementAdminLink);
            Console.WriteLine("Admin link is beling clicked, Admin home page is open");
            return CreateInstance<AdminHomePage>();
        }

        //This method is for clicking on EntityManagement option from Home Page
        public CreateFacilityPage ClickOnEntityManagementForFacilities()
        {
            if (Actions.IsDisplayed(_elementEntityManagement))
            {
                Waits.WaitForElementToBeClickable(_elementEntityManagement, WaitType.Small);
                Actions.Click(_elementEntityManagement);
                Actions.Click(_elementFacilities);
                Console.WriteLine("Facility search is opened");
                Waits.WaitForPageLoad();
            }
            return CreateInstance<CreateFacilityPage>();
        }

        //This method is for clicking on EntityManagement option from Home Page
        public CreatePhysiciansPage ClickOnEntityManagementForPhysicians()
        {
            if (Actions.IsDisplayed(_elementEntityManagement))
            {
                Waits.WaitForElementToBeClickable(_elementEntityManagement, WaitType.Small);
                Actions.Click(_elementEntityManagement);
                Actions.Click(_elementPhysicians);
                Console.WriteLine("Physcians search is opened");
                Waits.WaitForPageLoad();
            }
            return CreateInstance<CreatePhysiciansPage>();
        }
    }
}
