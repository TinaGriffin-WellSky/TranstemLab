using Flux.TranstemLab.StepHelper.Pages;
using Flux.TranstemLab.StepHelper.Pages.Donors;
using Flux.TranstemLab.StepHelper.Pages.Recipient;
using Flux.TranstemLab.StepHelper.Pages.Product;
using Flux.TranstemLab.StepHelper.Pages.Kit;
using Flux.TranstemLab.StepHelper.Pages.Product.BatchProcessing;
using Flux.TranstemLab.StepHelper.Pages.ReagentsSupplies;
using Flux.TranstemLab.StepHelper.Pages.Equipment;
using Flux.TranstemLab.StepHelper.Pages.EnvironmentalMonitoring;
using Flux.TranstemLab.StepHelper.Pages.Administrator;
using Flux.TranstemLab.StepHelper.Pages.Facilities;
using Flux.TranstemLab.StepHelper.Pages.Physicians;

namespace Flux.TranstemLab.StepHelper.Base
{
    /// <summary>
    /// This class will contain declarations of ALL the page objects
    /// </summary>
    public class Pages
    {
        public TranstemLabLoginPage transtemLabLoginPage;
        public TranstemLabHomePage transtemLabHomePage;
        
        public CommonMethodsPage commonMethodsPage;
        public UnitTestingPage unitTestingPage;

        //  Products
        //    Search
        public AddNewProductPage addNewProductPage;
        public ProductSearchPage productSearchPage;
        public ProductHomePage productHomePage;
        //    Add Batch
        public AddBatchPage addBatchPage;
        public SearchBatchPage searchBatchPage;
        public BatchHomePage batchHomePage;
        public SetBatchPage setBatchPage;
        public ProcessingProcedurePage processingProcedurePage;

        //  Donors
        public DonorCollectionEventsPage donorCollectionEventsPage;
        public DonorBirthEventPage donorBirthEventPage;
        public DocumentDonorPage documentDonorPage;
        public NotesDonorPage notesDonorPage;
        public AddDonorPage addDonorPage;
        public DonorSearchPage donorSearchPage;
        public DonorHomePage donorHomePage;

        //  Recipients
        public RecipientPage recipientPage;
        public DocumentsRecipientPage documentsRecipientPage;
        public NotesRecipientPage notesRecipientPage;
        public TransplantEventPage transplantEventPage;
        public RecipientSearchpage recipientSearchpage;

        //  Equipment/Consumables
        //    Equipment
        public EquipmentSearchPage equipmentSearchPage;
        public EquipmentCreation equipmentCreation;
        public EquipmentHomePage equipmentHomePage;
        //    Reagents/Supplies
        public SearchReagentPage searchReagentPage;
        public AddReagentPage addReagentPage;
        public ReagentDetailsPage reagentDetailsPage;
        //    Kits
        public AddKitPage addKitPage;

        //  Quality
        //    Enviromental Monitoring 
        public EnvironmentalMonitoringHomePage environmentalMonitoringHomePage;
        public TaskAssignmentDetailsPage taskAssignmentDetailsPage;

        //  Administrator
        public AdminHomePage adminHomePage;
        //    User Management
        public UserMgmtPage userMgmtPage;
        public AddUserPage addUserPage;
        //    Reference Tables
        public ReferenceTablesPage referenceTablesPage;
        //    Environmental Monitoring
        public EnvironmentalMonitorMgmtPage environmentalMonitorMgmtPage;
        public EnvironmentalMonitoringTaskDetail environmentalMonitoringTaskDetail;
        //    Processing Details
        public ProcessingDetailsPage processingDetailsPage;

        public CreateFacilityPage createFacilityPage;
        public CreatePhysiciansPage createPhysiciansPage;
    }
}
