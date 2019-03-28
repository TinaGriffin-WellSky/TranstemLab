using Flux.Web;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace Flux.TranstemLab.StepHelper.Pages.Product.BatchProcessing
{
    public class ProcessingProcedurePage : WebPageBase
    {
        private string productID;
        private string productCode;
        private string unitID;
        private string processingProcedureUrl;
        private readonly By _elementBatchHomePage = By.LinkText("Batch Processing Home Page");
        private readonly By _elementPrint = By.LinkText("Print");
        private readonly By _elementDivide = By.XPath("//IMG[@src='/Content/images/LabLayout/ProcessMenu_Divide.png']");
        private readonly By _elementSave = By.CssSelector("img[class='processButton'][title='Save']");
        private readonly By _elementSaveFromDivisionPopUp = By.XPath("//SPAN[@class='ui-button-text'][text()='Save']");
        private readonly By _elementLabels = By.Id("11972");
        private readonly By _elementScanVerification = By.LinkText("Scan Verification");
        private readonly By _elementProductRecord = By.LinkText("Product Record");
        private readonly By _elementYesBtn = By.Id("IsDistributedEvenly");
        private readonly By _elementUnitIDLink = By.CssSelector("a[href^='/Product/Detail/']");
        private readonly By _elementProductCode = By.Id("ProductHeader_ProductCode");
        private readonly By _elementUnitId = By.Id("ProductHeader_UnitIdentifier");

        private readonly By _elementProductId = By.XPath("//DIV[@id='productIdentifier']");
        private readonly By _elementTitleArrow = By.Name("titleArrow");
        private readonly By _elementProductWeightField = By.Id("ProductHeader_Weight");
        private readonly By _elementProductVolumeField = By.Id("ProductHeader_Volume");
        private readonly By _elementRecipientddl = By.Id("ddlRecipientList");
        private readonly By _elementRecipientWeight = By.Id("ProductHeader_RecipientWeight");

        //  Component
        //    Receipt
        private readonly By _elementReceipt = By.Id("menu_1023");
        private readonly By _elementReceiptDetail = By.Id("menu_1024");
        private readonly By _elementLabelReivew = By.Id("menu_1025");
        private readonly By _elementOtherFacility = By.Id("menu_1026");
        private readonly By _elementReceivedDateField = By.Id("ProcedureData_ComponentList_1__Fields_1__ValueInput_InputDateString");
        private readonly By _elementReceivedDateClockBtn = By.Id("clock_rdReceivedDate");
        private readonly By _elementReceivedTimeField = By.Id("ProcedureData_ComponentList_1__Fields_2__ValueTimeSpan");
        private readonly By _elementReceivedTimeClickBtn = By.Id("clock_rdReceivedTime");
        private readonly By _elementStorageTemperatureDDL = By.Id("ProcedureData_ComponentList_1__Fields_3__ValueInt");
        private readonly By _elementTemperatureUponArrivalField = By.Id("ProcedureData_ComponentList_1__Fields_4__ValueDecimal");
        private readonly By _elementContainerIntactRadioBtn = By.CssSelector("input[id='ProcedureData_ComponentList_1__Fields_5__ValueRadio'][value='2']");
        private readonly By _elementContainerIntactSpecifyField = By.Id("ProcedureData_ComponentList_1__Fields_6_");
        private readonly By _elementContainerSatisfactoryRadioBtn = By.CssSelector("input[id='ProcedureData_ComponentList_1__Fields_7__ValueRadio'][value='2']");
        private readonly By _elementContainerSatisfactorySpecifyField = By.Id("ProcedureData_ComponentList_1__Fields_8_");
        private readonly By _elementAppearanceSatisfactoryRadioBtn = By.CssSelector("input[id='ProcedureData_ComponentList_1__Fields_9__ValueRadio'][value='2']");
        private readonly By _elementAppearanceSatisfactorySpecifyField = By.Id("ProcedureData_ComponentList_1__Fields_10_");
        private readonly By _elementEligibilityDeterminationRadioBtn = By.CssSelector("input[id='ProcedureData_ComponentList_1__Fields_11__ValueRadio'][value='2']");
        private readonly By _elementEligibilityDeterminationSpecifyField = By.Id("ProcedureData_ComponentList_1__Fields_12_");

        //Label Review
        private readonly By _elementAutologousRadioBtn = By.Id("ProcedureData_ComponentList_2__Fields_1__ValueRadio");
        private readonly By _elementRecipientNameRadioBtn = By.CssSelector("input[id = 'ProcedureData_ComponentList_2__Fields_2__ValueRadio'][value = '1']");
        private readonly By _elementRecipientMRNRadioBtn = By.CssSelector("input[id = 'ProcedureData_ComponentList_2__Fields_3__ValueRadio'][value = '1']");
        private readonly By _elementRecipientDOBRadioBtn = By.CssSelector("input[id = 'ProcedureData_ComponentList_2__Fields_4__ValueRadio'][value = '1']");
        private readonly By _elementUniqueProductID = By.CssSelector("input[id = 'ProcedureData_ComponentList_2__Fields_10__ValueRadio'][value = '2']");
        private readonly By _elementDateOfCollection = By.CssSelector("input[id = 'ProcedureData_ComponentList_2__Fields_11__ValueRadio'][value = '2']");

        //Other Facility
        private readonly By _elementMarkersReceivedRadioBtn = By.CssSelector("input[id = 'ProcedureData_ComponentList_3__Fields_1__ValueRadio'][value = '2']");
        private readonly By _elementMarkersReceivedSpecifyField = By.Id("ProcedureData_ComponentList_3__Fields_2_");
        private readonly By _elementTestingReceivedRadioBtn = By.CssSelector("input[id = 'ProcedureData_ComponentList_3__Fields_3__ValueRadio'][value = '2']");
        private readonly By _elementTestingReceivedSpecifyField = By.Id("ProcedureData_ComponentList_3__Fields_4_");
        private readonly By _elementReviewer1 = By.Id("sign_ofReviewer1");
        private readonly By _elementUserName = By.Id("userName");
        private readonly By _elementPassword = By.Id("password");
        private readonly By _elementAuthorizeBtn = By.Id("AuthorizeButton");
        private readonly By _elementDoneBtnOtherFacility = By.Id("doneLink_ofReviewer1");


        //ABO/Rh Check
        private readonly By _elementABORhCheck = By.Id("menu_1020");
        private readonly By _elementBloodMatchRadioBtn = By.CssSelector("input[id = 'ProcedureData_ComponentList_4__Fields_1__ValueRadio'][value = '2']");
        private readonly By _elementBloodMatchSpecifyField = By.Id("ProcedureData_ComponentList_4__Fields_2_");
        private readonly By _elementReviewerSignature = By.Id("sign_abchPilotReviewer");
        private readonly By _elementDoneBtnABORhCheck = By.Id("doneLink_abchPilotReviewer");

        //Samping
        private readonly By _elementSampling = By.Id("menu_1022");
        //    Processing
        private readonly By _elementProcessing = By.Id("menu_1028");
        //      Processing Step 1
        private readonly By _elementProcessingStep1 = By.Id("menu_1029");
        private readonly By _elementProcessingTypeDDL = By.Id("ProcedureData_ComponentList_7__Fields_0__ValueInt");
        private readonly By _elementProductGrowssWeight = By.Id("ProcedureData_ComponentList_7__Fields_1__ValueDecimal");
        private readonly By _elementBagTareWeight = By.Id("ProcedureData_ComponentList_7__Fields_2__ValueInteger");
        private readonly By _elementTotalVolume = By.Id("ProcedureData_ComponentList_7__Fields_4__ValueDecimal");
        private readonly By _elementNucleatedCellCount = By.Id("ProcedureData_ComponentList_7__Fields_5__ValueDecimal");
        private readonly By _elementTotalNucleatedCells = By.Id("ProcedureData_ComponentList_7__Fields_7__ValueDecimal");
        private readonly By _elementNucleatedCell = By.Id("ProcedureData_ComponentList_7__Fields_8__ValueDecimal");
        private readonly By _elementMNCRadioBtnYes = By.CssSelector("input[id='ProcedureData_ComponentList_7__Fields_9__ValueRadio'][value='1']");
        private readonly By _elementMNCRadioBtnNo = By.CssSelector("input[id='ProcedureData_ComponentList_7__Fields_9__ValueRadio'][value='2']");
        private readonly By _elementCD3RadioYes = By.CssSelector("input[id='ProcedureData_ComponentList_7__Fields_14__ValueRadio'][value='1']");
        private readonly By _elementCD3RadioNo = By.CssSelector("input[id='ProcedureData_ComponentList_7__Fields_14__ValueRadio'][value='2']");
        //      Processing Step 2
        private readonly By _elementProcessingStep2 = By.Id("menu_1030");
        private readonly By _elementProcessingTypeDDLStep2 = By.Id("ProcedureData_ComponentList_8__Fields_0__ValueInt");
        private readonly By _elementTotalVolumeStep2 = By.Id("ProcedureData_ComponentList_8__Fields_7__ValueDecimal");
        private readonly By _elementNucleatedCellCountStep2 = By.Id("ProcedureData_ComponentList_8__Fields_8__ValueDecimal");
        private readonly By _elementTotalNucleatedCellsStep2 = By.Id("ProcedureData_ComponentList_8__Fields_10__ValueDecimal");
        private readonly By _elementNucleatedCellStep2 = By.Id("ProcedureData_ComponentList_8__Fields_11__ValueDecimal");
        private readonly By _elementMNCRadioBtnYesStep2 = By.CssSelector("input[id='ProcedureData_ComponentList_8__Fields_12__ValueRadio'][value='1']");
        private readonly By _elementMNCRadioBtnNoStep2 = By.CssSelector("input[id='ProcedureData_ComponentList_8__Fields_12__ValueRadio'][value='2']");
        private readonly By _elementCD3RadioYesStep2 = By.CssSelector("input[id='ProcedureData_ComponentList_8__Fields_17__ValueRadio'][value='1']");
        private readonly By _elementCD3RadioNoStep2 = By.CssSelector("input[id='ProcedureData_ComponentList_8__Fields_17__ValueRadio'][value='2']");
        private readonly By _elementCD34Step2 = By.Id("ProcedureData_ComponentList_8__Fields_15__ValueDecimal");
        private readonly By _elementCD34PerKgStep2 = By.Id("ProcedureData_ComponentList_8__Fields_16__ValueDecimal");
        private readonly By _elementCD3PlusStep2 = By.Id("ProcedureData_ComponentList_8__Fields_18__ValueDecimal");
        private readonly By _elementCD3PlusPerKgStep2 = By.Id("ProcedureData_ComponentList_8__Fields_19__ValueDecimal");
        private readonly By _elementRecoveryStep2 = By.Id("ProcedureData_ComponentList_8__Fields_10__ValueDecimal");
        private readonly By _elementRecoveryAcceptabilityRadiobtnYes = By.CssSelector("input[id='ProcedureData_ComponentList_8__Fields_21__ValueRadio'][value='1']");
        private readonly By _elementRecoveryAcceptabilityRadiobtnNo = By.CssSelector("input[id='ProcedureData_ComponentList_8__Fields_21__ValueRadio'][value='2']");
        private readonly By _elementRecoveryAcceptabilitySpecify = By.Id("ProcedureData_ComponentList_8__Fields_22_");
        private readonly By _elementViabilityMethod = By.Id("ProcedureData_ComponentList_7__Fields_17__ValueInt");

        //      Processing Step 3
        private readonly By _elementProcessingStep3 = By.Id("menu_1031");

        //Label verification
        private readonly By _elementLabelVerification = By.Id("menu_1021");
        private readonly By _elementProductTagsPreparer = By.Id("sign_lvProductPreparedBy");
        private readonly By _elementProductTagsPreparerDoneBtn = By.Id("doneLink_lvProductPreparedBy");
        private readonly By _elementCardsVerifier = By.Id("sign_lvProcessingCardsVerified");
        private readonly By _elementCardsVerifierDoneBtn = By.Id("doneLink_lvProcessingCardsVerified");
        private readonly By _elementLabelNeededRadioBtn = By.CssSelector("input[id = 'ProcedureData_ComponentList_10__Fields_5__ValueRadio'][value = '2']");
        private readonly By _elementModificationsRadioBtn = By.CssSelector("input[id = 'ProcedureData_ComponentList_10__Fields_8__ValueRadio'][value = '1']");
        private readonly By _elementModificationsSpecifyField = By.Id("ProcedureData_ComponentList_10__Fields_9_");
        private readonly By _elementModificationVerifier = By.Id("sign_lvModificationsVerifiedBy");
        private readonly By _elementModificationVerifierDoneBtn = By.Id("doneLink_lvModificationsVerifiedBy");

        //Cryoperservation
        private readonly By _elementCryoperservation = By.Id("menu_1027");
        private readonly By _elementInitialProductVolume = By.Id("ProcedureData_ComponentList_11__Fields_1__ValueDecimal");
        private readonly By _elementPlasmaAdded = By.Id("ProcedureData_ComponentList_11__Fields_2__ValueDecimal");
        private readonly By _elementAlbuminAdded = By.Id("ProcedureData_ComponentList_11__Fields_3__ValueDecimal");
        private readonly By _elementHSACheckBox = By.Id("ProcedureData_ComponentList_11__Fields_4_");
        private readonly By _elementAutologousPlasma = By.Id("ProcedureData_ComponentList_11__Fields_5_");
        private readonly By _elementFreezSolution = By.Id("ProcedureData_ComponentList_11__Fields_6__ValueDecimal");
        private readonly By _elementFinalVolume = By.Id("ProcedureData_ComponentList_11__Fields_7__ValueDecimal");
        private readonly By _elementLaminarFlowHoodDDL = By.Id("ProcedureData_ComponentList_11__Fields_9__ValueInt");
        private readonly By _elementGuageReading = By.Id("ProcedureData_ComponentList_11__Fields_10__ValueDecimal");
        private readonly By _elementFreezeSolutionPreparer = By.Id("sign_crcdDMSOFreezeSolutionPreparedBy");
        private readonly By _elementFreezeSolutionPreparerDone = By.Id("doneLink_crcdDMSOFreezeSolutionPreparedBy");
        private readonly By _elementFreezeSolutionPreparDateClock = By.Id("clock_crcdDateDMSOFreezeSolutionPrepared");
        private readonly By _elementFreezeSolutionPreparTimeClock = By.Id("clock_crcdTimeDMSOFreezeSolutionPrepared");
        private readonly By _elementFreezingProgramDDL = By.Id("ProcedureData_ComponentList_11__Fields_15__ValueInt");
        private readonly By _elementProbeNumber = By.Id("ProcedureData_ComponentList_11__Fields_16__ValueInteger");
        private readonly By _elementFreezerIDDDL = By.Id("ProcedureData_ComponentList_11__Fields_17__ValueInt");
        private readonly By _elementFreezeCurveReview = By.CssSelector("input[id = 'ProcedureData_ComponentList_11__Fields_18__ValueRadio'][value = '2']");
        private readonly By _elementFreezeCurveReviewSpecifyField = By.Id("ProcedureData_ComponentList_11__Fields_19_");
        private readonly By _elementFreezeReviewPerformer = By.Id("sign_crfdFreezeReviewPerformedBy");
        private readonly By _elementFreezeReviewPerformerDone = By.Id("doneLink_crfdFreezeReviewPerformedBy");
        private readonly By _elementEligibleForStorage = By.Id("ProcedureData_ComponentList_11__ApprovalSectionTrue");

        //RBCDepletion
        private readonly By _elementRBCDepletion = By.Id("menu_1032");
        private readonly By _elementHES1 = By.Id("menu_1033");
        private readonly By _elementHES2 = By.Id("menu_1034");
        //HEs-1
        //I
        private readonly By _elementRBCDepletionDateClockBtn1 = By.Id("clock_h1ipRBCDepletionDate");
        private readonly By _elementTotalVolumeField1 = By.Id("ProcedureData_ComponentList_13__Fields_2__ValueDecimal");
        private readonly By _elementNucleatedCellCountField1 = By.Id("ProcedureData_ComponentList_13__Fields_3__ValueDecimal");
        private readonly By _elementTotalNucleatedCellsField1 = By.Id("ProcedureData_ComponentList_13__Fields_5__ValueDecimal");
        private readonly By _elementHCTField1 = By.Id("ProcedureData_ComponentList_13__Fields_6__ValueDecimal");
        private readonly By _elementRBCVolumeField1 = By.Id("ProcedureData_ComponentList_13__Fields_7__ValueDecimal");

        //II
        private readonly By _elementProcessingStepIIDDL2 = By.Id("ProcedureData_ComponentList_13__Fields_9__ValueInt");
        //private readonly By _element

        //III
        private readonly By _elementProcessingStepIIIDDL3 = By.Id("ProcedureData_ComponentList_13__Fields_20__ValueInt");
        private readonly By _elementTotalVolumeField3 = By.Id("ProcedureData_ComponentList_13__Fields_21__ValueDecimal");
        private readonly By _elementHetastarchField3 = By.Id("ProcedureData_ComponentList_13__Fields_22__ValueDecimal");
        private readonly By _elementHetastarchAddedRadioBtnYes3 = By.CssSelector("input[id = 'ProcedureData_ComponentList_13__Fields_23__ValueRadio'][value = '1']");
        private readonly By _elementHetastarchAddedRadioBtnNo3 = By.CssSelector("input[id = 'ProcedureData_ComponentList_13__Fields_23__ValueRadio'][value = '2']");
        private readonly By _elementAmountAddedField3 = By.Id("ProcedureData_ComponentList_13__Fields_24__ValueDecimal");
        private readonly By _elementHatastarchAdderDDL3 = By.Id("ProcedureData_ComponentList_13__Fields_25__ValueInt");
        private readonly By _elementHetastarchAddedDateField3 = By.Id("ProcedureData_ComponentList_13__Fields_26__ValueInput_InputDateString");
        private readonly By _elementHetastarchAddedTimeField3 = By.Id("ProcedureData_ComponentList_13__Fields_27__ValueTimeSpan");
        private readonly By _elementHetastarchAddedTimeClock3 = By.Id("clock_h1ahHetastarchAddedTime");
        private readonly By _elementHetastarchReagentIDField3 = By.Id("ProcedureData_ComponentList_13__Fields_28_");

        //IV
        private readonly By _elementInitialProductField4 = By.Id("ProcedureData_ComponentList_13__Fields_30__ValueDecimal");
        private readonly By _elementPlasmalyteAField4 = By.Id("ProcedureData_ComponentList_13__Fields_31__ValueDecimal");
        private readonly By _element6HetastarchField4 = By.Id("ProcedureData_ComponentList_13__Fields_32__ValueDecimal");
        private readonly By _elementMixedRadioBtnYes4 = By.CssSelector("input[id = 'ProcedureData_ComponentList_13__Fields_34__ValueRadio'][value = '1']");
        private readonly By _elementMixedRadioBtnNo4 = By.CssSelector("input[name = 'ProcedureData.ComponentList[13].Fields[34].h1fpWereContentsMixed'][value = '2']");
        private readonly By _elementFinalVolume4 = By.Id("ProcedureData_ComponentList_13__Fields_33__ValueDecimal");
        private readonly By _elementMixedSpecifyField4 = By.Id("ProcedureData_ComponentList_13__Fields_35_");

        //V
        private readonly By _elementStartDateClock5 = By.Id("clock_h1hsStartDate");
        private readonly By _elementStartDateField = By.Id("ProcedureData_ComponentList_13__Fields_37__ValueInput_InputDateString");
        private readonly By _elementStartTimeClick5 = By.Id("clock_h1hsStartTime");
        private readonly By _elementStopDateClock5 = By.Id("clock_h1hsStopDate");
        private readonly By _elementStoPTimeClock5 = By.Id("clock_h1hsStopTime");
        private readonly By _elementInitialProductVolume5 = By.Id("ProcedureData_ComponentList_13__Fields_41__Rows_1__Fields_2__ValueDecimal");
        private readonly By _elementInitialProductNC5 = By.Id("ProcedureData_ComponentList_13__Fields_41__Rows_1__Fields_3__ValueDecimal");
        private readonly By _elementInitialProductTNC5 = By.Id("ProcedureData_ComponentList_13__Fields_41__Rows_1__Fields_5__ValueDecimal");
        private readonly By _elementInitialProductHCT5 = By.Id("ProcedureData_ComponentList_13__Fields_41__Rows_1__Fields_7__ValueDecimal");
        private readonly By _elementInitialProductRBC5 = By.Id("ProcedureData_ComponentList_13__Fields_41__Rows_1__Fields_8__ValueDecimal");

        private readonly By _elementPreHESSedimentationVolume5 = By.Id("ProcedureData_ComponentList_13__Fields_41__Rows_2__Fields_2__ValueDecimal");
        private readonly By _elementPreHESSedimentationNC5 = By.Id("ProcedureData_ComponentList_13__Fields_41__Rows_2__Fields_3__ValueDecimal");
        private readonly By _elementPreHESSedimentationTNC5 = By.Id("ProcedureData_ComponentList_13__Fields_41__Rows_2__Fields_5__ValueDecimal");
        private readonly By _elementPreHESSedimentationHTC5 = By.Id("ProcedureData_ComponentList_13__Fields_41__Rows_2__Fields_7__ValueDecimal");
        private readonly By _elementPreHESSedimentationRBC5 = By.Id("ProcedureData_ComponentList_13__Fields_41__Rows_2__Fields_8__ValueDecimal");
        private readonly By _elementPreHESSedimentationTNCRecovery5 = By.Id("ProcedureData_ComponentList_13__Fields_41__Rows_2__Fields_6__ValueDecimal");

        private readonly By _elementPostHESSedimentationVolume5 = By.Id("ProcedureData_ComponentList_13__Fields_41__Rows_3__Fields_2__ValueDecimal");
        private readonly By _elementPostHESSedimentationNC5 = By.Id("ProcedureData_ComponentList_13__Fields_41__Rows_3__Fields_3__ValueDecimal");
        private readonly By _elementPostHESSedimentationTNC5 = By.Id("ProcedureData_ComponentList_13__Fields_41__Rows_3__Fields_5__ValueDecimal");
        private readonly By _elementPostHESSedimentationHTC5 = By.Id("ProcedureData_ComponentList_13__Fields_41__Rows_3__Fields_7__ValueDecimal");
        private readonly By _elementPostHESSedimentationRBC5 = By.Id("ProcedureData_ComponentList_13__Fields_41__Rows_3__Fields_8__ValueDecimal");
        private readonly By _elementPostHESSedimentationTNCRecovery5 = By.Id("ProcedureData_ComponentList_13__Fields_41__Rows_3__Fields_6__ValueDecimal");

        private readonly By _elementPostHESRemovalVolume5 = By.Id("ProcedureData_ComponentList_13__Fields_41__Rows_4__Fields_2__ValueDecimal");
        private readonly By _elementPostHESRemovalNC5 = By.Id("ProcedureData_ComponentList_13__Fields_41__Rows_4__Fields_3__ValueDecimal");
        private readonly By _elementPostHESRemovalTNC5 = By.Id("ProcedureData_ComponentList_13__Fields_41__Rows_4__Fields_5__ValueDecimal");
        private readonly By _elementPostHESRemovalHTC5 = By.Id("ProcedureData_ComponentList_13__Fields_41__Rows_4__Fields_7__ValueDecimal");
        private readonly By _elementPostHESRemovalRBC5 = By.Id("ProcedureData_ComponentList_13__Fields_41__Rows_4__Fields_8__ValueDecimal");
        private readonly By _elementPostHESRemovalTNCRecovery5 = By.Id("ProcedureData_ComponentList_13__Fields_41__Rows_4__Fields_6__ValueDecimal");

        //Processing Review
        private readonly By _elementProcessingReview = By.Id("menu_ProcessingReview");
        private readonly By _elementProcessingReviewer1 = By.Id("sign_7");
        private readonly By _elementProcessingReviewerDone = By.Id("doneLink_7");

        //    CD34 Selection
        private readonly By _elementCD34Selection = By.Id("menu_1250");

        //    CD34+ Section A
        private readonly By _elementCD34SectionA = By.Id("menu_1251");
        private readonly By _elementCD34SectionAOverrideCalculationsBox = By.Id("ProcedureData_ComponentList_16__OverrideCalculations");

        //      Transfer of leukapheresis product into Cell Bag Preparation
        private readonly By _elementCD34SectionAStartingDate = By.Id("ProcedureData_ComponentList_16__Fields_1__ValueInput_InputDateString");
        private readonly By _elementCD34SectionAStartingTime = By.Id("ProcedureData_ComponentList_16__Fields_2__ValueTimeSpan");
        private readonly By _elementCD34SectionARemoveLeukapheresisYesRadioBtn = By.CssSelector("input[id='ProcedureData_ComponentList_16__Fields_3__ValueRadio'][value='1']");
        private readonly By _elementCD34SectionARemoveLeukapheresisNoRadioBtn = By.CssSelector("input[ProcedureData_ComponentList_16__Fields_3__ValueRadio][value='2']");
        private readonly By _elementCD34SectionAWeightOfCPBWithLeukapheresis = By.Id("ProcedureData_ComponentList_16__Fields_4__ValueDecimal");
        private readonly By _elementCD34SectionAWeightOfEmptyCPB = By.Id("ProcedureData_ComponentList_16__Fields_5__ValueDecimal");
        private readonly By _elementCD34SectionAWeightOfLeukapheresis = By.Id("ProcedureData_ComponentList_16__Fields_6__ValueDecimal");
        private readonly By _elementCD34SectionAReducedNABox = By.Id("ProcedureData_ComponentList_16__Fields_7_");
        private readonly By _elementCD34SectionAWeightOfLeukapheresisAfterReduction = By.Id("ProcedureData_ComponentList_16__Fields_8__ValueDecimal");
        //      Diluting leukapheresis product
        //      The Leukapheresis product should be diluted with CliniMACS PBS/EDTA Buffer before magnetic labeling.
        private readonly By _elementCD34SectionAWeightOfBufferUsingA4 = By.Id("ProcedureData_ComponentList_16__Fields_11__ValueDecimal");
        private readonly By _elementCD34SectionAWeightOfBufferUsingA4Reduced = By.Id("ProcedureData_ComponentList_16__Fields_12__ValueDecimal");
        private readonly By _elementCD34SectionAActualBufferAdded = By.Id("ProcedureData_ComponentList_16__Fields_13__ValueDecimal");
        private readonly By _elementCD34SectionATotalCPBWeightAfterBuffer = By.Id("ProcedureData_ComponentList_16__Fields_14__ValueDecimal");
        private readonly By _elementCD34SectionATotalLeukapheresisWeightAfterBuffer = By.Id("ProcedureData_ComponentList_16__Fields_15__ValueDecimal");
        //      Adjusting the leukapheresis product to 95g or 180g
        //      Centrifugation Conditions
        private readonly By _elementCD34SectionACentrifugeID = By.Id("ProcedureData_ComponentList_16__Fields_18_");
        private readonly By _elementCD34SectionACentrifugationTime = By.Id("ProcedureData_ComponentList_16__Fields_19__ValueDecimal");
        private readonly By _elementCD34SectionACentrifugationSpeed = By.Id("ProcedureData_ComponentList_16__Fields_20__ValueDecimal");
        private readonly By _elementCD34SectionATargetFinalVolume95RadioBtn = By.CssSelector("input[id='ProcedureData_ComponentList_16__Fields_21__ValueRadio'][value='1']");
        private readonly By _elementCD34SectionATargetFinalVolume190RadioBtn = By.CssSelector("input[id='ProcedureData_ComponentList_16__Fields_21__ValueRadio'][value='2']");
        //      Calculate the amount of supernatant to be removed to give a final volume of 95 g.
        private readonly By _elementCD34SectionA95AmountOfSupernatantToBeRemoved = By.Id("ProcedureData_ComponentList_16__Fields_23__ValueDecimal");
        private readonly By _elementCD34SectionA95ActualAmountOfSupernatantRemoved = By.Id("ProcedureData_ComponentList_16__Fields_24__ValueDecimal");
        private readonly By _elementCD34SectionA95TotalCPBWeightAfterDilution = By.Id("ProcedureData_ComponentList_16__Fields_25__ValueDecimal");
        private readonly By _elementCD34SectionA95TotalLeukapheresisWeightAfterDilution = By.Id("ProcedureData_ComponentList_16__Fields_26__ValueDecimal");
        //      Calculate the amount of supernatant to be removed to give a final volume of 190 g.
        private readonly By _elementCD34SectionA190AmountOfSupernatantToBeRemoved = By.Id("ProcedureData_ComponentList_16__Fields_28__ValueDecimal");
        private readonly By _elementCD34SectionA190ActualAmountOfSupernatantRemoved = By.Id("ProcedureData_ComponentList_16__Fields_29__ValueDecimal");
        private readonly By _elementCD34SectionA190TotalCPBWeightAfterDilution = By.Id("ProcedureData_ComponentList_16__Fields_30__ValueDecimal");
        private readonly By _elementCD34SectionA190TotalLeukapheresisWeightAfterDilution = By.Id("ProcedureData_ComponentList_16__Fields_31__ValueDecimal");
        //    CD34+ Section B
        private readonly By _elementCD34SectionB = By.Id("menu_1252");
        private readonly By _elementCD34SectionBOverrideCalculationsBox = By.Id("ProcedureData_ComponentList_17__OverrideCalculations");
        //      Magnetic labeling of CD34 positive cells
        private readonly By _elementCD34SectionBReagentID = By.Id("ProcedureData_ComponentList_17__Fields_1_");
        private readonly By _elementCD34SectionBSecondReagentID = By.Id("ProcedureData_ComponentList_17__Fields_2_");
        //      Incubation
        private readonly By _elementCD34SectionBIncubationStartTime = By.Id("ProcedureData_ComponentList_17__Fields_4__ValueTimeSpan");
        private readonly By _elementCD34SectionBAirInjectionYesRadioBtn = By.CssSelector("input[id='ProcedureData_ComponentList_17__Fields_5__ValueRadio'][value='1']");
        private readonly By _elementCD34SectionBAirInjectionNoRadioBtn = By.CssSelector("input[id='ProcedureData_ComponentList_17__Fields_5__ValueRadio'][value='2']");
        private readonly By _elementCD34SectionBPlacedOnRotatorYesRadioBtn = By.CssSelector("input[id='ProcedureData_ComponentList_17__Fields_6__ValueRadio'][value='1']");
        private readonly By _elementCD34SectionBPlacedOnRotatorNoRadioBtn = By.CssSelector("input[id='ProcedureData_ComponentList_17__Fields_6__ValueRadio'][value='2']");
        private readonly By _elementCD34SectionBPlacedOnRotatorSpecify = By.Id("ProcedureData_ComponentList_17__Fields_7_");
        private readonly By _elementCD34SectionBIncubationStopTime = By.Id("ProcedureData_ComponentList_17__Fields_8__ValueTimeSpan");
        //      Wash No. 1
        private readonly By _elementCD34SectionBWash1AmountOfBuffer = By.Id("ProcedureData_ComponentList_17__Fields_10__ValueDecimal");
        //      Centrifugation Conditions
        private readonly By _elementCD34SectionBWash1CentrifugeID = By.Id("ProcedureData_ComponentList_17__Fields_12_");
        private readonly By _elementCD34SectionBWash1CentrifugationTime = By.Id("ProcedureData_ComponentList_17__Fields_13__ValueDecimal");
        private readonly By _elementCD34SectionBWash1CentrifugationSpeed = By.Id("ProcedureData_ComponentList_17__Fields_14__ValueDecimal");
        private readonly By _elementCD34SectionBWash1AmountOfRemovedSupernatant = By.Id("ProcedureData_ComponentList_17__Fields_15__ValueDecimal");
        //      Wash No. 2
        private readonly By _elementCD34SectionBWash2AmountOfBuffer = By.Id("ProcedureData_ComponentList_17__Fields_17__ValueDecimal");
        //      Centrifugation Conditions
        private readonly By _elementCD34SectionBWash2CentrifugeID = By.Id("ProcedureData_ComponentList_17__Fields_19_");
        private readonly By _elementCD34SectionBWash2CentrifugationTime = By.Id("ProcedureData_ComponentList_17__Fields_20__ValueDecimal");
        private readonly By _elementCD34SectionBWash2CentrifugationSpeed = By.Id("ProcedureData_ComponentList_17__Fields_21__ValueDecimal");
        private readonly By _elementCD34SectionBWash2AmountOfRemovedSupernatant = By.Id("ProcedureData_ComponentList_17__Fields_22__ValueDecimal");
        private readonly By _elementCD34SectionBWeightOfCPBAfterWashing = By.Id("ProcedureData_ComponentList_17__Fields_23__ValueDecimal");
        private readonly By _elementCD34SectionBWeightOfLeukapheresisAfterWashing = By.Id("ProcedureData_ComponentList_17__Fields_24__ValueDecimal");
        //      Final Sample Preparation
        private readonly By _elementCD34SectionBVolumeAdjust150RadioBtn = By.CssSelector("input[id='ProcedureData_ComponentList_17__Fields_26__ValueRadio'][value='1']");
        private readonly By _elementCD34SectionBVolumeAdjust275RatioBtn = By.CssSelector("input[id='ProcedureData_ComponentList_17__Fields_26__ValueRadio'][value='2']");
        private readonly By _elementCD34SectionBAmountOfBufferToAdd = By.Id("ProcedureData_ComponentList_17__Fields_27__ValueDecimal");
        private readonly By _elementCD34SectionBRemoveLeukapheresisBox = By.Id("ProcedureData_ComponentList_17__Fields_28_");
        private readonly By _elementCD34SectionBCPBWeightAfterBufferAddition = By.Id("ProcedureData_ComponentList_17__Fields_29__ValueDecimal");
        private readonly By _elementCD34SectionBLeukapheresisWeightAfterBufferAddition = By.Id("ProcedureData_ComponentList_17__Fields_30__ValueDecimal");
        //    CD34+ Section C
        private readonly By _elementCD34SectionC = By.Id("menu_1253");
        private readonly By _elementCD34SectionCOverrideCalculationsBox = By.Id("ProcedureData_ComponentList_18__OverrideCalculations");
        //      CliniMACS Separation (Run)
        private readonly By _elementCD34SectionCDateRunStarted = By.Id("ProcedureData_ComponentList_18__Fields_1__ValueInput_InputDateString");
        private readonly By _elementCD34SectionCTimeRunStarted = By.Id("ProcedureData_ComponentList_18__Fields_2__ValueTimeSpan");
        private readonly By _elementCD34SectionCDateRunEnded = By.Id("ProcedureData_ComponentList_18__Fields_3__ValueInput_InputDateString");
        private readonly By _elementCD34SectionCTimeRunEnded = By.Id("ProcedureData_ComponentList_18__Fields_4__ValueTimeSpan");
        private readonly By _elementCD34SectionCTubingSetReagentID = By.Id("ProcedureData_ComponentList_18__Fields_5_");
        //      Calculate the amount of positive fraction
        private readonly By _elementCD34SectionCCPBWeightAfterRun = By.Id("ProcedureData_ComponentList_18__Fields_7__ValueDecimal");
        private readonly By _elementCD34SectionCEmptyCPBWeight = By.Id("ProcedureData_ComponentList_18__Fields_8__ValueDecimal");
        private readonly By _elementCD34SectionCPositiveFractionWeight = By.Id("ProcedureData_ComponentList_18__Fields_9__ValueDecimal");
        private readonly By _elementCD34SectionCProcessCode = By.Id("ProcedureData_ComponentList_18__Fields_10_");
        //    Data Analysis Unselected Processing
        private readonly By _elementDataAnalysisUnselectedProcessing = By.Id("menu_1254");
        private readonly By _elementDataAnalysisUnselectedProcessingOverrideCalculationsBox = By.Id("ProcedureData_ComponentList_19__OverrideCalculations");
        //      HPC Product Aliquot for Unselected Processing
        private readonly By _elementDataAnalysisUnselectedProcessingHPCNotApplicableBox = By.Id("ProcedureData_ComponentList_19__Fields_1_");
        private readonly By _elementDataAnalysisUnselectedProcessingHPCTotalVolume = By.Id("ProcedureData_ComponentList_19__Fields_2__ValueDecimal");
        private readonly By _elementDataAnalysisUnselectedProcessingHPCNucleatedCellCount = By.Id("ProcedureData_ComponentList_19__Fields_3__ValueDecimal");
        private readonly By _elementDataAnalysisUnselectedProcessingHPCTotalNucleatedCells = By.Id("ProcedureData_ComponentList_19__Fields_4__ValueDecimal");
        private readonly By _elementDataAnalysisUnselectedProcessingHPCNucleatedCellsPerKg = By.Id("ProcedureData_ComponentList_19__Fields_5__ValueDecimal");
        private readonly By _elementDataAnalysisUnselectedProcessingHPCCD34 = By.Id("ProcedureData_ComponentList_19__Fields_6__ValueDecimal");
        private readonly By _elementDataAnalysisUnselectedProcessingHPCCD34PerKg = By.Id("ProcedureData_ComponentList_19__Fields_7__ValueDecimal");
        private readonly By _elementDataAnalysisUnselectedProcessingHPCCD3 = By.Id("ProcedureData_ComponentList_19__Fields_8__ValueDecimal");
        private readonly By _elementDataAnalysisUnselectedProcessingHPCCD3PerKg = By.Id("ProcedureData_ComponentList_19__Fields_9__ValueDecimal");
        private readonly By _elementDataAnalysisUnselectedProcessingHPCCD34Viability = By.Id("ProcedureData_ComponentList_19__Fields_10__ValueDecimal");
        private readonly By _elementDataAnalysisUnselectedProcessingHPCTech1Review = By.Id("sign_daupTech1Review");
        private readonly By _elementDataAnalysisUnselectedProcessingHPCTech2Review = By.Id("sign_daupTech2Review");
        //      T-Cell Aliquot
        private readonly By _elementDataAnalysisUnselectedProcessingTCellNotApplicableBox = By.Id("ProcedureData_ComponentList_19__Fields_14_");
        private readonly By _elementDataAnalysisUnselectedProcessingTCellAliquotID = By.Id("ProcedureData_ComponentList_19__Fields_15_");
        private readonly By _elementDataAnalysisUnselectedProcessingTCellTotalVolume = By.Id("ProcedureData_ComponentList_19__Fields_16__ValueDecimal");
        private readonly By _elementDataAnalysisUnselectedProcessingTCellNucleatedCellCount = By.Id("ProcedureData_ComponentList_19__Fields_17__ValueDecimal");
        private readonly By _elementDataAnalysisUnselectedProcessingTCellTotalNucleatedCells = By.Id("ProcedureData_ComponentList_19__Fields_18__ValueDecimal");
        private readonly By _elementDataAnalysisUnselectedProcessingTCellNucleatedCellsPerKg = By.Id("ProcedureData_ComponentList_19__Fields_19__ValueDecimal");
        private readonly By _elementDataAnalysisUnselectedProcessingTCellCD34 = By.Id("ProcedureData_ComponentList_19__Fields_20__ValueDecimal");
        private readonly By _elementDataAnalysisUnselectedProcessingTCellCD34PerKg = By.Id("ProcedureData_ComponentList_19__Fields_21__ValueDecimal");
        private readonly By _elementDataAnalysisUnselectedProcessingTCellCD3 = By.Id("ProcedureData_ComponentList_19__Fields_22__ValueDecimal");
        private readonly By _elementDataAnalysisUnselectedProcessingTCellCD3PerKg = By.Id("ProcedureData_ComponentList_19__Fields_23__ValueDecimal");
        private readonly By _elementDataAnalysisUnselectedProcessingTCellTech1Review = By.Id("sign_daupTech1ReviewCell");
        private readonly By _elementDataAnalysisUnselectedProcessingTCellTech2Review = By.Id("sign_daupTech1ReviewCell");
        //      Pre-Spin (After Removal of T-Cell Aliquots
        private readonly By _elementDataAnalysisUnselectedProcessingPreSpinNotApplicableBox = By.Id("ProcedureData_ComponentList_19__Fields_27_");
        private readonly By _elementDataAnalysisUnselectedProcessingPreSpinTotalVolume = By.Id("ProcedureData_ComponentList_19__Fields_28__ValueDecimal");
        private readonly By _elementDataAnalysisUnselectedProcessingPreSpinNucleatedCellCount = By.Id("ProcedureData_ComponentList_19__Fields_29__ValueDecimal");
        private readonly By _elementDataAnalysisUnselectedProcessingPreSpinTotalNucleatedCells = By.Id("ProcedureData_ComponentList_19__Fields_30__ValueDecimal");
        private readonly By _elementDataAnalysisUnselectedProcessingPreSpinNucleatedCellsPerKg = By.Id("ProcedureData_ComponentList_19__Fields_31__ValueDecimal");
        private readonly By _elementDataAnalysisUnselectedProcessingPreSpinCD34 = By.Id("ProcedureData_ComponentList_19__Fields_32__ValueDecimal");
        private readonly By _elementDataAnalysisUnselectedProcessingPreSpinCD34PerKg = By.Id("ProcedureData_ComponentList_19__Fields_33__ValueDecimal");
        private readonly By _elementDataAnalysisUnselectedProcessingPreSpinCD3 = By.Id("ProcedureData_ComponentList_19__Fields_34__ValueDecimal");
        private readonly By _elementDataAnalysisUnselectedProcessingPreSpinCD3PerKg = By.Id("ProcedureData_ComponentList_19__Fields_35__ValueDecimal");
        private readonly By _elementDataAnalysisUnselectedProcessingPreSpinTech1Review = By.Id("sign_daupTech1ReviewPreSpin");
        private readonly By _elementDataAnalysisUnselectedProcessingPreSpinTech2Review = By.Id("sign_daupTech2ReviewPreSpin");
        //      Post-Spin
        private readonly By _elementDataAnalysisUnselectedProcessingPostSpinNotApplicableBox = By.Id("ProcedureData_ComponentList_19__Fields_39_");
        private readonly By _elementDataAnalysisUnselectedProcessingPostSpinAliquotID = By.Id("ProcedureData_ComponentList_19__Fields_40_");
        private readonly By _elementDataAnalysisUnselectedProcessingPostSpinGrossWeight = By.Id("ProcedureData_ComponentList_19__Fields_41_");
        private readonly By _elementDataAnalysisUnselectedProcessingPostSpinCentrifugeID = By.Id("ProcedureData_ComponentList_19__Fields_42_");
        private readonly By _elementDataAnalysisUnselectedProcessingPostSpinRPM = By.Id("ProcedureData_ComponentList_19__Fields_43_");
        private readonly By _elementDataAnalysisUnselectedProcessingPostSpinCentrifugeTemp = By.Id("ProcedureData_ComponentList_19__Fields_44_");
        private readonly By _elementDataAnalysisUnselectedProcessingPostSpinGrossWt = By.Id("ProcedureData_ComponentList_19__Fields_45_");
        private readonly By _elementDataAnalysisUnselectedProcessingPostSpinBagWt = By.Id("ProcedureData_ComponentList_19__Fields_46_");
        private readonly By _elementDataAnalysisUnselectedProcessingPostSpinTotalVolume = By.Id("ProcedureData_ComponentList_19__Fields_47_");
        private readonly By _elementDataAnalysisUnselectedProcessingPostSpinNucleatedCellCount = By.Id("ProcedureData_ComponentList_19__Fields_48_");
        private readonly By _elementDataAnalysisUnselectedProcessingPostSpinTotalNucleatedCells = By.Id("ProcedureData_ComponentList_19__Fields_49_");
        private readonly By _elementDataAnalysisUnselectedProcessingPostSpinNucleatedCellsPerKg = By.Id("ProcedureData_ComponentList_19__Fields_50_");
        private readonly By _elementDataAnalysisUnselectedProcessingPostSpinCD34 = By.Id("ProcedureData_ComponentList_19__Fields_51_");
        private readonly By _elementDataAnalysisUnselectedProcessingPostSpinCD34PerKg = By.Id("ProcedureData_ComponentList_19__Fields_52_");
        private readonly By _elementDataAnalysisUnselectedProcessingPostSpinCD3 = By.Id("ProcedureData_ComponentList_19__Fields_53_");
        private readonly By _elementDataAnalysisUnselectedProcessingPostSpinCD3PerKg = By.Id("ProcedureData_ComponentList_19__Fields_54_");
        private readonly By _elementDataAnalysisUnselectedProcessingPostSpinRecovery = By.Id("ProcedureData_ComponentList_19__Fields_55_");
        private readonly By _elementDataAnalysisUnselectedProcessingPostSpinTech1Review = By.Id("sign_daupTech1ReviewPostSpin");
        private readonly By _elementDataAnalysisUnselectedProcessingPostSpinTech2Review = By.Id("sign_daupTech2ReviewPostSpin");
        //    Data Analysis CD34 Selection
        private readonly By _elementDataAnalysisCD34Selection = By.Id("menu_1255");
        private readonly By _elementDataAnalysisCD34SelectionOverrideCalculatins = By.Id("ProcedureData_ComponentList_20__OverrideCalculations");
        //      HPC Product Aliquot for CD34 Selection (before prep/magnetic labeling)
        private readonly By _elementDataAnalysisCD34SelectionBeforePrepTotalVolume = By.Id("ProcedureData_ComponentList_20__Fields_1__ValueDecimal");
        private readonly By _elementDataAnalysisCD34SelectionBeforePrepNucleatedCellCount = By.Id("ProcedureData_ComponentList_20__Fields_2__ValueDecimal");
        private readonly By _elementDataAnalysisCD34SelectionBeforePrepTotalNucleatedCells = By.Id("ProcedureData_ComponentList_20__Fields_3__ValueDecimal");
        private readonly By _elementDataAnalysisCD34SelectionBeforePrepNucleatedCellsPerKg = By.Id("ProcedureData_ComponentList_20__Fields_4__ValueDecimal");
        private readonly By _elementDataAnalysisCD34SelectionBeforePrepCD34 = By.Id("ProcedureData_ComponentList_20__Fields_5__ValueDecimal");
        private readonly By _elementDataAnalysisCD34SelectionBeforePrepCD34PerKg = By.Id("ProcedureData_ComponentList_20__Fields_6__ValueDecimal");
        private readonly By _elementDataAnalysisCD34SelectionBeforePrepCD3 = By.Id("ProcedureData_ComponentList_20__Fields_7__ValueDecimal");
        private readonly By _elementDataAnalysisCD34SelectionBeforePrepCD3PerKg = By.Id("ProcedureData_ComponentList_20__Fields_8__ValueDecimal");
        private readonly By _elementDataAnalysisCD34SelectionBeforePrepCD34Viability = By.Id("ProcedureData_ComponentList_20__Fields_9__ValueDecimal");
        private readonly By _elementDataAnalysisCD34SelectionBeforePrepTech1Review = By.Id("sign_dasA1Signature");
        private readonly By _elementDataAnalysisCD34SelectionBeforePrepTech2Review = By.Id("sign_dasA2Signature");
        //      HPC Product Aliquot for CD34 Selection (after prep/magnetic labeling)
        private readonly By _elementDataAnalysisCD34SelectionAfterPrepTotalVolume = By.Id("ProcedureData_ComponentList_20__Fields_13__ValueDecimal");
        private readonly By _elementDataAnalysisCD34SelectionAfterPrepNucleatedCellCount = By.Id("ProcedureData_ComponentList_20__Fields_14__ValueDecimal");
        private readonly By _elementDataAnalysisCD34SelectionAfterPrepTotalNucleatedCells = By.Id("ProcedureData_ComponentList_20__Fields_15__ValueDecimal");
        private readonly By _elementDataAnalysisCD34SelectionAfterPrepNucleatedCellsPerKg = By.Id("ProcedureData_ComponentList_20__Fields_16__ValueDecimal");
        private readonly By _elementDataAnalysisCD34SelectionAfterPrepCD34 = By.Id("ProcedureData_ComponentList_20__Fields_17__ValueDecimal");
        private readonly By _elementDataAnalysisCD34SelectionAfterPrepCD34PerKg = By.Id("ProcedureData_ComponentList_20__Fields_18__ValueDecimal");
        private readonly By _elementDataAnalysisCD34SelectionAfterPrepCD3 = By.Id("ProcedureData_ComponentList_20__Fields_19__ValueDecimal");
        private readonly By _elementDataAnalysisCD34SelectionAfterPrepCD3PerKg = By.Id("ProcedureData_ComponentList_20__Fields_20__ValueDecimal");
        private readonly By _elementDataAnalysisCD34SelectionAfterPrepCD34Recovery = By.Id("ProcedureData_ComponentList_20__Fields_21__ValueDecimal");
        private readonly By _elementDataAnalysisCD34SelectionAfterPrepCD34Viability = By.Id("ProcedureData_ComponentList_20__Fields_22__ValueDecimal");
        private readonly By _elementDataAnalysisCD34SelectionAfterPrepTech1Review = By.Id("sign_dasB1Signature");
        private readonly By _elementDataAnalysisCD34SelectionAfterPrepTech2Review = By.Id("sign_dasB2Signature");
        //      CD34 Selected Positive Fraction (Cell Collection Bag)
        private readonly By _elementDataAnalysisCD34SelectionPosFracAliquotID = By.Id("ProcedureData_ComponentList_20__Fields_26_");
        private readonly By _elementDataAnalysisCD34SelectionPosFracTotalVolume = By.Id("ProcedureData_ComponentList_20__Fields_27__ValueDecimal");
        private readonly By _elementDataAnalysisCD34SelectionPosFracNucleatedCellCount = By.Id("ProcedureData_ComponentList_20__Fields_28__ValueDecimal");
        private readonly By _elementDataAnalysisCD34SelectionPosFracTotalNucleatedCells = By.Id("ProcedureData_ComponentList_20__Fields_29__ValueDecimal");
        private readonly By _elementDataAnalysisCD34SelectionPosFracNucleatedCellsPerKg = By.Id("ProcedureData_ComponentList_20__Fields_30__ValueDecimal");
        private readonly By _elementDataAnalysisCD34SelectionPosFracCD34 = By.Id("ProcedureData_ComponentList_20__Fields_31__ValueDecimal");
        private readonly By _elementDataAnalysisCD34SelectionPosFracCD34PerKg = By.Id("ProcedureData_ComponentList_20__Fields_32__ValueDecimal");
        private readonly By _elementDataAnalysisCD34SelectionPosFracCD3 = By.Id("ProcedureData_ComponentList_20__Fields_33__ValueDecimal");
        private readonly By _elementDataAnalysisCD34SelectionPosFracCD3PerKg = By.Id("ProcedureData_ComponentList_20__Fields_34__ValueDecimal");
        private readonly By _elementDataAnalysisCD34SelectionPosFracCD34Recovery = By.Id("ProcedureData_ComponentList_20__Fields_35__ValueDecimal");
        private readonly By _elementDataAnalysisCD34SelectionPosFracCD34Viability = By.Id("ProcedureData_ComponentList_20__Fields_36__ValueDecimal");
        private readonly By _elementDataAnalysisCD34SelectionPosFracTech1Review = By.Id("sign_dasC1Signature");
        private readonly By _elementDataAnalysisCD34SelectionPosFracTech2Review = By.Id("sign_dasC2Signature");
        //      CD34 Selected Negative Fraction (Negative Fraction Bag)
        private readonly By _elementDataAnalysisCD34SelectionNegFracTotalVolume = By.Id("ProcedureData_ComponentList_20__Fields_40__ValueDecimal");
        private readonly By _elementDataAnalysisCD34SelectionNegFracNucleatedCellCount = By.Id("ProcedureData_ComponentList_20__Fields_41__ValueDecimal");
        private readonly By _elementDataAnalysisCD34SelectionNegFracTotalNucleatedCells = By.Id("ProcedureData_ComponentList_20__Fields_42__ValueDecimal");
        private readonly By _elementDataAnalysisCD34SelectionNegFracNucleatedCellsPerKg = By.Id("ProcedureData_ComponentList_20__Fields_43__ValueDecimal");
        private readonly By _elementDataAnalysisCD34SelectionNegFracCD34 = By.Id("ProcedureData_ComponentList_20__Fields_44__ValueDecimal");
        private readonly By _elementDataAnalysisCD34SelectionNegFracCD34PerKg = By.Id("ProcedureData_ComponentList_20__Fields_45__ValueDecimal");
        private readonly By _elementDataAnalysisCD34SelectionNegFracCD3 = By.Id("ProcedureData_ComponentList_20__Fields_46__ValueDecimal");
        private readonly By _elementDataAnalysisCD34SelectionNegFracCD3PerKg = By.Id("ProcedureData_ComponentList_20__Fields_47__ValueDecimal");
        private readonly By _elementDataAnalysisCD34SelectionNegFracCD34Viability = By.Id("ProcedureData_ComponentList_20__Fields_48__ValueDecimal");
        private readonly By _elementDataAnalysisCD34SelectionNegFracTech1Review = By.Id("sign_dasD1Signature");
        private readonly By _elementDataAnalysisCD34SelectionNegFracTech2Review = By.Id("sign_dasD2Signature");

        //    Storage
        private readonly By _elementStorage = By.Id("menu_Storage");
        //      Sample Storage
        private readonly By _elementStorageSample = By.Id("menu_ProductStorageSamples");
        private readonly By _elementStorageSampleType = By.Id("ProductStorageSamples_SampleStorageType");
        private readonly By _elementStorageSampleQuantity = By.Id("ProductStorageSamples_Quantity");
        private readonly By _elementStorageSampleLocation = By.Id("ProductStorageSamples_SampleStorageLocation");
        private readonly By _elementStorageSampleFreezerNumber = By.Id("ProductStorageSamples_UserFields_0__RealValue");
        private readonly By _elementStorageSampleDateStored = By.Id("ProductStorageSamples_DateTimeStored_InputDateString");
        private readonly By _elementStorageSampleTimeStored = By.Id("ProductStorageSamples_DateTimeStored_InputTimeString");
        private readonly By _elementStorageSampleBoxNumber = By.Id("ProductStorageSamples_SampleBoxNumber");
        private readonly By _elementStorageSampleOpenNewBox = By.Id("OpenNewBoxLink");
        private readonly By _elementStorageSampleCreateSample = By.Id("btnCreateSample");
        //      Unit Storage
        private readonly By _elementStorageUnit = By.Id("menu_ProductStorage");
        private readonly By _elementStorageUnitLocation = By.Id("ddlLocation");
        private readonly By _elementStorageUnitFreezerNumber = By.Id("ProductStorage_CurrentTracking_UserFields_0__RealValue");
        private readonly By _elementStorageUnitRack = By.Id("ProductStorage_CurrentTracking_UserFields_1__RealValue");
        private readonly By _elementStorageUnitPosition = By.Id("ProductStorage_CurrentTracking_UserFields_2__RealValue");
        private readonly By _elementStorageUnitDateRemoved = By.Id("ProductStorage_CurrentTracking_ActionDate_InputDateString");
        private readonly By _elementStorageUnitDateTimeNow = By.ClassName("fa bigger fa-clock-o dateButton timeButton storageTime");
        private readonly By _elementStorageUnitTimeRemoved = By.Id("ProductStorage_CurrentTracking_ActionDate_InputTimeString");
        private readonly By _elementStorageUnitSaveSuccess = By.ClassName("ResultSuccess");

        //Folder Tracking
        private readonly By _elementFolderTracking = By.Id("menu_FolderTracking");
        private readonly By _elementShelfOrBoxDDL = By.Id("ddlShelfOrBox");
        private readonly By _elementRowDDL = By.Id("ddlRow");
        private readonly By _elementFolderPlacementClock = By.CssSelector("span[title = 'Date Time Now']");
        private readonly By _elementFolderPlacementDateField = By.Id("ProductFolderTracking_CurrentTracking_CheckInOutDate_InputDateString");
        private readonly By _elementFolderPlacementTimeField = By.Id("ProductFolderTracking_CurrentTracking_CheckInOutDate_InputTimeString");

        // Repeat Components pop-up
        private readonly By _elementProcessingStep1Repeat = By.CssSelector("li[class='fa fa-plus-square repeatButton']"); // need more detail
        private readonly By _elementRepeatComponentCount = By.Id("repeatComponentCount");
        private readonly By _elementPopupOkay = By.XPath("//SPAN[@class='ui-button-text'][text()='OK']");

        //  Pop-Ups
        //    Signature Verification
        private readonly By _elementSignatureVerificationUsername = By.Id("userName");
        private readonly By _elementSignatureVerificationPassword = By.Id("Password");

        //Label verification
        private readonly By _elementLabelBtn = By.CssSelector("img[title='Labels']");
        private readonly By _elementLabelPrinterDDL = By.Id("PrinterId");
        private readonly By _elementLabelTypeDDL = By.Id("ProductLabelTypeId");
        private readonly By _elementLabelSpecialMessageDDL = By.Id("SpecialMessageId");
        private readonly By _elementNumberPrintedTextbox = By.Id("NumberPrinted");
        private readonly By _elementLabelPrintBtn = By.Id("processingLabelPrintButton");

        private const double WeirdConstYouShouldProbablyAskAbout = 1.06;
        private const double MaxTolerance = 0.005;

        /*
        // Sidebar
       // private readonly By _elementSidebarTranstemMenuExpand = By.XPath("//INPUT[@type='image']");
        private readonly By _elementSidebarHome = By.XPath("(//IMG[@class='menuIcon'])[1]");
        private readonly By _elementSidebarAccount = By.XPath("(//IMG[@class='menuIcon'])[2]");
        private readonly By _elementSidebarLogout = By.XPath("(//IMG[@class='menuIcon'])[3]");

        // Navigation Menu
        private readonly By _elementNavMenu = By.Id("cssmenuCollapse");
        private readonly By _elementNavMenuProducts = By.LinkText("Products");
        private readonly By _elementNavMenuProductsSearch = By.XPath("(//A[@href='/Laboratory/UnitSearch.aspx'])[1]");
        private readonly By _elementNavMenuProductsBatchSearch = By.XPath("(//A[@href='/BatchProcessing/Search?Area='])[1]");
        private readonly By _elementNavMenuDonors = By.XPath("(//A[@href='/DonorMgmt/DonorSearch.aspx'][text()='Donors'][text()='Donors'])[1]");
        private readonly By _elementNavMenuRecipients = By.XPath("(//A[@href='/RecipientMgmt/RecipientSearch.aspx'][text()='Recipients'][text()='Recipients'])[1]");
        private readonly By _elementNavMenuEntityManagement = By.LinkText("Entity Management");
        private readonly By _elementNavMenuEntityManagementFacilities = By.XPath("(//SPAN[text()='Facilities'][text()='Facilities'])[1]");
        private readonly By _elementNavMenuEntityManagementPhysicians = By.XPath("(//SPAN[text()='Physicians'][text()='Physicians'])[1]");
        private readonly By _elementNavMenuEquipmentConsumables = By.LinkText("Equipment/Consumables");
        private readonly By _elementNavMenuEquipmentConsumablesEquipment = By.XPath("(//SPAN[text()='Equipment'][text()='Equipment'])[1]");
        private readonly By _elementNavMenuEquipmentConsumablesReagents = By.XPath("(//SPAN[text()='Reagents'][text()='Reagents'])[1]");
        private readonly By _elementNavMenuEquipmentConsumablesKits = By.XPath("(//A[@href='/SupplyMan/KitSearch.aspx'])[1]");
        private readonly By _elementNavMenuQuality = By.LinkText("Quality");
        private readonly By _elementNavMenuQualityEnvironmentalMonitoring = By.XPath("(//SPAN[text()='Environmental Monitoring'])[1]");
        private readonly By _elementNavMenuQualityCT = By.XPath("(//A[@href='/Laboratory/ConfirmatoryTyping.aspx'])[1]");
        private readonly By _elementNavMenuQualityRegistry = By.XPath("(//SPAN[text()='Registry Listing'][text()='Registry Listing'])[1]");
        private readonly By _elementNavMenuReporting = By.XPath("(//A[@href='/Reporting/Reports.aspx'][text()='Reporting'][text()='Reporting'])[1]");
        private readonly By _elementNavMenuAdministrator = By.XPath("(//A[@href='/HomePages/AdministratorHome.aspx'][text()='Administrator'][text()='Administrator'])[1]");
        */

        public void SetProductId(string productId)
        {
            productID = productId;
        }

        public void SetProcudeCode()
        {
            productCode = Actions.GetText(_elementProductCode);
            Console.WriteLine(Actions.GetAttributeValue(_elementProductCode, "value") + " Is the product code");
        }

        public void SetUnitId()
        {
            unitID = Actions.GetText(_elementUnitId);
            Console.WriteLine(Actions.GetAttributeValue(_elementUnitId, "value") + " Is the Unit ID");
        }

        public string GetUnitId() { return unitID; }
        public string GetProductId() { return productID; }
        public string GetProductCode() { return productCode; }

        public void ClickOnHighestTitleArrow()
        {
            Assert.True(Actions.IsDisplayed(_elementTitleArrow), "Could not find title arrow");
            ClickAndLoad(_elementTitleArrow);
            //Actions.Click(_elementTitleArrow);
            Console.WriteLine("Clicked on title arrow");
            // Waits.WaitForPageLoad();
        }

        //this method is used to click on the title arrow button
        public void ClickOnTitleArrow()
        {
            Assert.True(Actions.IsDisplayed(_elementTitleArrow), "Not able to locate title arrow");
            ClickAndLoad(_elementTitleArrow);
            //Actions.Click(_elementTitleArrow);
            Console.WriteLine("Title arrow being clicked");
            //Waits.WaitForPageLoad();
        }

        // Start repeat methods =====

        // Click on repeat icon of sub-component
        public void ClickOnRepeat(string componentId, int repeatNum = 1)
        {
            string cssContainerCode = "li[class='subComponentMenu notActive'][id='menu_" + componentId + "'][repeatnumber='" + repeatNum + "']"; // make more robust by removing active part
            string cssRepeatSignCode = "span[class='fa fa-plus-square repeatButton']";
            Actions.FindElement(By.CssSelector(cssContainerCode)).FindElement(By.CssSelector(cssRepeatSignCode)).Click();
        }

        public void TypeRepeatComponentCount(int repeatNum = 1)
        {
            Assert.True(Actions.IsDisplayed(_elementRepeatComponentCount), "Could not find Repeat Components Count text field");
            Actions.SendKeys(_elementRepeatComponentCount, repeatNum.ToString());
            Console.WriteLine("Typed Repeat Components Count");
        }

        public void ClickOnOkayInPopup()
        {
            Assert.True(Actions.IsDisplayed(_elementPopupOkay), "Could not find Okay button in pop-up");
            Actions.Click(_elementPopupOkay);
            Console.WriteLine("Clicked on Okay in pop-up");
        }

        // Types in number of repeats for a sub-component and confirms
        public void EnterRepeatComponentCount(int repeatNum = 1)
        {
            TypeRepeatComponentCount(repeatNum);
            ClickOnOkayInPopup();
            ClickOnOkayInPopup(); // confirmation pop-up
            ClickOnOkayInPopup();
        }

        public void CheckRepeatedComponent(string componentId, int repeatNum = 1)
        {
            string cssContainerCode = "li[class^='subComponentMenu '][id='menu_" + componentId + "'][repeatnumber='" + repeatNum + "']";
            string cssRepeatSignCode = "span[class='fa fa-plus-square repeatButton']";
            Actions.FindElement(By.CssSelector(cssContainerCode)).FindElement(By.CssSelector(cssRepeatSignCode));
        }

        //Start Processing methods =====

        public void ClickOnProcessing()
        {
            Assert.True(Actions.IsDisplayed(_elementProcessing), "Could not find Processing");
            ClickAndLoad(_elementProcessing);
            //Actions.Click(_elementProcessing);
            Console.WriteLine("Clicked on Processing");
            //Waits.WaitForPageLoad();
        }

        // Goes to processing, repeats step, checks that new step appears
        public void RepeatProcessingComponentCount(int step, int repeatNum = 1)
        {
            string componentId = (1028 + step).ToString();
            Assert.True(step >= 1 && step <= 3, "Step is not in range of 1 to 3");
            ClickOnProcessing();
            ClickOnRepeat(componentId, repeatNum);
            EnterRepeatComponentCount(repeatNum);

            //WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
            //wait.Until(ExpectedConditions.ElementToBeClickable(_elementProcessing));

            //new WebDriverWait(Driver, TimeSpan.FromSeconds(30)).Until(
            //    d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));

            //Thread.Sleep(30000); // wait time increases dramatically after first replication

            //Waits.WaitForElementToBeClickable(_elementProcessing, WaitType.Large);

            Waits.WaitForPageLoad();

            ClickOnProcessing();
            CheckRepeatedComponent(componentId, repeatNum);
        }

        // CD34 Selection methods =====

        public void ClickOnCD34Selection()
        {
            Actions.Click(_elementCD34Selection);
            Console.WriteLine("Clicked on CD34 Selection component");
            Waits.WaitForPageLoad();
        }

        // Repeats Data Analysis Unselected Processing sub-component
        public void RepeatDataAnalysisUnselectedProcessingComponentCount(int repeatNum = 1)
        {
            string componentId = "1254";
            ClickOnCD34Selection();
            ClickOnRepeat(componentId, repeatNum);
            EnterRepeatComponentCount(repeatNum);
            Waits.WaitForPageLoad();
            ClickOnCD34Selection();
            CheckRepeatedComponent(componentId, repeatNum);
        }

        // Repeats Data Analysis CD34 Selection sub-component
        public void RepeatDataAnalysisCD34SelectionComponentCount(int repeatNum = 1)
        {
            string componentId = "1255";
            ClickOnCD34Selection();
            ClickOnRepeat(componentId, repeatNum);
            EnterRepeatComponentCount(repeatNum);
            Waits.WaitForPageLoad();
            ClickOnCD34Selection();
            CheckRepeatedComponent(componentId, repeatNum);
        }

        // Storage methods =====

        public void ClickOnStorage()
        {
            Assert.True(Actions.IsDisplayed(_elementStorage), "Could not find Storage");
            ClickAndLoad(_elementStorage);
            //Actions.Click(_elementStorage);
            Console.WriteLine("Clicked on Storage");
            //Waits.WaitForPageLoad();
        }

        public void ClickOnSampleStorage()
        {
            Assert.True(Actions.IsDisplayed(_elementStorageSample), "Could not find Sample Storage");
            ClickAndLoad(_elementStorageSample);
            //Actions.Click(_elementStorageSample);
            Console.WriteLine("Clicked on Sample Storage");
            //Waits.WaitForPageLoad();
        }

        public void FillSampleStorage(string quantity, string freezerNumber)
        {
            Assert.True(Actions.IsDisplayed(_elementStorageSampleType), "Could not find Sample Type drop-down list");
            Actions.SelectByRandoxIndex(_elementStorageSampleType);
            Console.WriteLine("Entered random Sample Type");

            Assert.True(Actions.IsDisplayed(_elementStorageSampleQuantity), "Could not find Quantity text field");
            Actions.SendKeys(_elementStorageSampleQuantity, quantity);
            Console.WriteLine("Entered random Quantity");

            Assert.True(Actions.IsDisplayed(_elementStorageSampleLocation), "Could not find Sample Storage Location drop-down list");
            Actions.SelectByRandoxIndex(_elementStorageSampleLocation);
            Console.WriteLine("Entered random Sample Storage Location");

            Assert.True(Actions.IsDisplayed(_elementStorageSampleFreezerNumber), "Could not find Freezer Number text field");
            Actions.SendKeys(_elementStorageSampleFreezerNumber, freezerNumber);
            Console.WriteLine("Entered random Freezer Number");
        }

        public void ClickOnCreateSample()
        {
            Assert.True(Actions.IsDisplayed(_elementStorageSampleCreateSample), "Could not find Create Sample button");
            Waits.WaitForPageLoad();
            ClickAndLoad(_elementStorageSampleCreateSample);
            //Actions.Click(_elementStorageSampleCreateSample);
            Console.WriteLine("Clicked on Create Sample button");
            //Waits.WaitForPageLoad();
        }

        public void ClickOnUnitStorage()
        {
            Assert.True(Actions.IsDisplayed(_elementStorageUnit), "Could not find Unit Storage");
            ClickAndLoad(_elementStorageUnit);
            //Actions.Click(_elementStorageUnit);
            Console.WriteLine("Clicked on Unit Storage");
            //Waits.WaitForPageLoad();
        }

        public void FillUnitStorage(string freezerNum, string rack, string position)
        {
            Assert.True(Actions.IsDisplayed(_elementStorageUnitLocation), "Could not find Location drop-down list");
            Actions.SelectByRandoxIndex(_elementStorageUnitLocation);
            Console.WriteLine("Selected random Location");

            Assert.True(Actions.IsDisplayed(_elementStorageUnitFreezerNumber), "Could not find Freezer Number text field");
            Actions.SendKeys(_elementStorageUnitFreezerNumber, freezerNum);
            Console.WriteLine("Typed Freezer Number entry");

            Assert.True(Actions.IsDisplayed(_elementStorageUnitRack), "Could not find Rack text field");
            Actions.SendKeys(_elementStorageUnitRack, rack);
            Console.WriteLine("Typed Rack entry");

            Assert.True(Actions.IsDisplayed(_elementStorageUnitPosition), "Could not find Position text field");
            Actions.SendKeys(_elementStorageUnitPosition, position);
            Console.WriteLine("Typed Position entry");

            Assert.True(Actions.IsDisplayed(_elementStorageUnitDateRemoved), "Could not find Date Removed text field");
            Actions.SendKeys(_elementStorageUnitDateRemoved, DateTime.Now.ToString());
            Console.WriteLine("Typed Date Removed entry");
        }

        //this method is used to click on the unitID so it will return a product home page
        public void ClickOnUnitIdLink()
        {
            Assert.True(Actions.IsDisplayed(_elementUnitIDLink), "Unit ID link is not shown");
            Actions.Click(_elementUnitIDLink);
            Console.WriteLine("Navigated to product home page");
        }

        //this method should be moved to product home page
        public string ParseProductIDFromUrl()
        {
            string url = Actions.GetCurrentUrl();
            Console.WriteLine("url is " + url);
            string[] words = url.Split('/');
            Console.WriteLine("ID is " + words[words.Length - 1]);
            return words[words.Length - 1];
        }

        //this method is used to click back 
        public void BackToPreviousPage()
        {
            Actions.NavigateToUrl(processingProcedureUrl);
            Console.WriteLine("The url nagigated to is " + processingProcedureUrl);
        }

        //this method is used to click on the divide button
        public void ClickOnDivideBtn()
        {
            Assert.True(Actions.IsDisplayed(_elementDivide), "Not able to locate divide");
            Actions.Click(_elementDivide);
            Console.WriteLine("divide button is clicked");
        }

        //this method is used to click on yes radio button
        public void ClickYesRadioBtn()
        {
            string value = Actions.GetAttributeValue(_elementYesBtn, "value");
            if (value.Equals("1"))
                Actions.Click(_elementYesBtn);

            Console.WriteLine("Yes is being selected");
        }

        //this method is sued to click on save button in the division product
        public void ClickOnSaveBtnFromPopUp()
        {
            Assert.True(Actions.IsDisplayed(_elementSaveFromDivisionPopUp), "Not able to find save");
            ClickAndLoad(_elementSaveFromDivisionPopUp);
            //Actions.Click(_elementSaveFromDivisionPopUp);
            Console.WriteLine("save button is clicked");
            //Waits.WaitForPageLoad();
        }

        //this method is sued to click on save button 
        public void ClickOnSaveBtn()
        {
            Assert.True(Actions.IsDisplayed(_elementSave), "Not able to find save");
            ClickAndLoad(_elementSave);
            // Actions.Click(_elementSave);
            Console.WriteLine("save button is clicked");
            // Waits.WaitForPageLoad();
        }

        //this method is to click on the parent title arrow
        public void ClickOnParentTitleArrow()
        {
            string parentTitleArrowId = "titleArrow_" + productID;
            Console.WriteLine("The parent title arrow id is " + parentTitleArrowId);
            By _elementParentTitleArrow = By.Id(parentTitleArrowId);
            Assert.True(Actions.IsDisplayed(_elementParentTitleArrow), "parent title arrow not found");
            ClickAndLoad(_elementParentTitleArrow);
            //Actions.Click(_elementParentTitleArrow);
            Console.WriteLine("parent title arrow is being clicked");
            //Waits.WaitForPageLoad();
        }

        //this method is to deternmind if parent is read only
        //if the parent is readonly, it will not be set to enable
        public bool IsWeightAndVolumeVisible()
        {

            if (Actions.IsEnabled(_elementProductVolumeField))
                return false;

            else if (Actions.IsEnabled(_elementProductWeightField))
                return false;
            else
                return true;
        }

        //this method is to select from the drop down
        public bool IsRecipientInddl()
        {
            if (Actions.IsDisplayed(_elementRecipientddl) == false)
            {
                Console.WriteLine("Element recipient field is not being displayed");
                return false;
            }
            else
            {
                Actions.SelectByIndex(_elementRecipientddl, 1);
                Console.WriteLine("The recipient in the drop down is " + Actions.GetAttributeValue(_elementRecipientddl, "value"));
                Waits.WaitForPageLoad();
                return true;
            }
        }

        // Checks for save message on Unit Storage
        public bool VerifyUnitStorageSave()
        {
            if (Actions.IsDisplayed(_elementStorageUnitSaveSuccess))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Get the current URL
        public void RecordCurrentUrl()
        {
            processingProcedureUrl = Actions.GetCurrentUrl();
            Console.WriteLine("The processing procedure URL is " + processingProcedureUrl);
        }

        //This method is used to click on recepit tab
        public void ClickOnReceipt()
        {
            ClickAndLoad(_elementReceipt);
            // Actions.Click(_elementReceipt);
            Console.WriteLine("Receipt is clicked");
            //Waits.WaitForPageLoad();
        }

        public void ClickOnReceiptDetail()
        {
            ClickAndLoad(_elementReceiptDetail);
            //Actions.Click(_elementReceiptDetail);
            Console.WriteLine("Receipt details page is being displayed");
            //Waits.WaitForPageLoad();
        }

        //this method is used to fill in details in Receipt Details page
        public void FillInDetailsInReceiptDetailPage(string temperature, string date)
        {
            Actions.Click(_elementReceivedTimeClickBtn);
            Console.WriteLine(Actions.GetAttributeValue(_elementReceivedTimeField, "value") + " is entered in received time field");
            //Actions.Click(_elementReceivedDateClockBtn);
            Actions.SendKeys(_elementReceivedDateField, date);
            Console.WriteLine(Actions.GetAttributeValue(_elementReceivedDateField, "value") + " is entered in received date field");
            Actions.SelectByRandoxIndex(_elementStorageTemperatureDDL);
            Console.WriteLine(Actions.GetAttributeValue(_elementStorageTemperatureDDL, "value") + " is selected in storage temperature during transport drop down list");
            Actions.SendKeys(_elementTemperatureUponArrivalField, temperature);
            Console.WriteLine(temperature + " is entered in the temperature upon arrival in cell processing lab field");

            ClickAndLoad(_elementContainerIntactRadioBtn);
            //Actions.Click(_elementContainerIntactRadioBtn);
            Console.WriteLine("No is selected in Transport Cotainer Intact radio button");
            //Waits.WaitForPageLoad();
            Actions.SendKeys(_elementContainerIntactSpecifyField, "Testing!");
            Console.WriteLine("Testing! is entered in the container intact specify field ");

            ClickAndLoad(_elementContainerSatisfactoryRadioBtn);
            //Actions.Click(_elementContainerSatisfactoryRadioBtn);
            Console.WriteLine("No is selected in Transport Cotainer Intact radio button");
            //Waits.WaitForPageLoad();
            Actions.SendKeys(_elementContainerSatisfactorySpecifyField, "Testing!");
            Console.WriteLine("Testing! is entered in the container intact specify field ");

            ClickAndLoad(_elementAppearanceSatisfactoryRadioBtn);
            //Actions.Click(_elementAppearanceSatisfactoryRadioBtn);
            Console.WriteLine("No is selected in Transport Cotainer Intact radio button");
            //Waits.WaitForPageLoad();
            Actions.SendKeys(_elementAppearanceSatisfactorySpecifyField, "Testing!");
            Console.WriteLine("Testing! is entered in the container intact specify field ");

            ClickAndLoad(_elementEligibilityDeterminationRadioBtn);
            //Actions.Click(_elementEligibilityDeterminationRadioBtn);
            Console.WriteLine("No is selected in Transport Cotainer Intact radio button");
            //Waits.WaitForPageLoad();
            Actions.SendKeys(_elementEligibilityDeterminationSpecifyField, "Testing!");
            Console.WriteLine("Testing! is entered in the container intact specify field ");
        }

        public void ClickOnLabelReview()
        {
            ClickAndLoad(_elementLabelReivew);
            //Actions.Click(_elementLabelReivew);
            Console.WriteLine("Label Review is clicked");
            //Waits.WaitForPageLoad();
        }

        //this method is used to select radios under Label review
        public void SelectRadiosInLabelReview()
        {
            Actions.Click(_elementAutologousRadioBtn);
            Console.WriteLine("Autologous has been selected");
            Actions.Click(_elementRecipientNameRadioBtn);
            Actions.Click(_elementRecipientMRNRadioBtn);
            Actions.Click(_elementRecipientDOBRadioBtn);
            Actions.Click(_elementUniqueProductID);
            Actions.Click(_elementDateOfCollection);
        }

        public void ClickOnOtherFacility()
        {
            ClickAndLoad(_elementOtherFacility);
            //Actions.Click(_elementOtherFacility);
            Console.WriteLine("Other facility opened");
            //Waits.WaitForPageLoad();
        }

        //this method is used to fill in the fields other facility
        public void FillInDetailsInOtherFacility()
        {
            ClickAndLoad(_elementMarkersReceivedRadioBtn);
            //Actions.Click(_elementMarkersReceivedRadioBtn);
            Console.WriteLine("No is being selected in the Results of Infectious Disease Markers Received radio");
            //Waits.WaitForPageLoad();
            Actions.SendKeys(_elementMarkersReceivedSpecifyField, "Testing!");
            ClickAndLoad(_elementTestingReceivedRadioBtn);
            //Actions.Click(_elementTestingReceivedRadioBtn);
            Console.WriteLine("No is being selected in the Results of Sterility Testing Received Received radio");
            // Waits.WaitForPageLoad();
            Actions.SendKeys(_elementTestingReceivedRadioBtn, "Testing!");
        }

        public void ClickOnReviewer1()
        {
            ClickAndLoad(_elementReviewer1);
            //Actions.Click(_elementReviewer1);
            //Waits.WaitForPageLoad();
        }

        //this method is used to sign in as a reviewer
        public void SignInWithCredential(string userName, string password)
        {
            Actions.SendKeys(_elementUserName, userName);
            Actions.SendKeys(_elementPassword, password);
            Console.WriteLine("Username and password is entered");
            ClickAndLoad(_elementAuthorizeBtn);
            //Actions.Click(_elementAuthorizeBtn);
            //Waits.WaitForPageLoad();
            Console.WriteLine("Admin info entered");
        }

        public void ClickOnDoneOnOtherFacilityPage()
        {
            ClickAndLoad(_elementDoneBtnOtherFacility);
            //Actions.Click(_elementDoneBtnOtherFacility);
            //Waits.WaitForPageLoad();
            Console.WriteLine("Done button clicked in other facility");
        }

        public void ClickOnABORhCheck()
        {
            ClickAndLoad(_elementABORhCheck);
            //Actions.Click(_elementABORhCheck);
            Console.WriteLine("ABO/RH check page is open");
            //Waits.WaitForPageLoad();
        }

        public void FillInDetailsInABORhCheck()
        {
            ClickAndLoad(_elementBloodMatchRadioBtn);
            //Actions.Click(_elementBloodMatchRadioBtn);
            Console.WriteLine("ABO/RH match has been selected as no");
            //Waits.WaitForPageLoad();
            Actions.SendKeys(_elementBloodMatchSpecifyField, "Testing!");
            Console.WriteLine("Testing! has been entered in the specify field");
        }

        //this method is to click on the check mark next to reviewer in the ABO/Rh check page
        public void ClickOnReviewerToSignInABORhCheckPage()
        {
            ClickAndLoad(_elementReviewerSignature);
            //Actions.Click(_elementReviewerSignature);
            Console.WriteLine("signature window is open");
            //Waits.WaitForPageLoad();
        }

        public void ClickOnDoneBtnOnABORhCheckPage()
        {
            ClickAndLoad(_elementDoneBtnABORhCheck);
            //Actions.Click(_elementDoneBtnABORhCheck);
            Console.WriteLine("Signature is uploaded");
            //Waits.WaitForPageLoad();
        }

        public void ClickOnSamplingPage()
        {
            ClickAndLoad(_elementSampling);
            Actions.Click(_elementSampling);
            Console.WriteLine("Sampleing page is open");
            Waits.WaitForPageLoad();
        }

        public void CickOnFolderTracking()
        {
            ClickAndLoad(_elementFolderTracking);
            //Actions.Click(_elementFolderTracking);
            Console.WriteLine("Folder tracking page is open");
            //Waits.WaitForPageLoad();
        }

        public void FillInDetailsInFolderTracking(string date)
        {
            Actions.SelectByIndex(_elementShelfOrBoxDDL, 1);
            Actions.SelectByRandoxIndex(_elementRowDDL);
            Actions.SendKeys(_elementFolderPlacementDateField, date);
            Waits.WaitForPageLoad();
        }

        public void FillInDetailsInSamplingPage()
        {
            for (int i = 2; i < 8; i++)
            {
                By _elementInSampling = By.Id("ProcedureData_ComponentList_5__Fields_" + i.ToString() + "_");

                if (i == 7)
                {
                    Waits.WaitForPageLoad();
                    Actions.SendKeys(_elementInSampling, "Testing!");
                    Console.WriteLine("Testing is entered on Specify field");
                }
                else Actions.Click(_elementInSampling);
            }
        }

        public void ClickOnLabelVerificationpage()
        {
            ClickAndLoad(_elementLabelVerification);
            //Actions.Click(_elementLabelVerification);
            Console.WriteLine("Label Verification page is open");
            //Waits.WaitForPageLoad();
        }

        public void FillInDetailsInLabelVerification()
        {
            ClickAndLoad(_elementLabelNeededRadioBtn);
            //Actions.Click(_elementLabelNeededRadioBtn);
            Console.WriteLine("Appropriate Biohazard/Warning Label Needed is selected as no");
            //Waits.WaitForPageLoad();
            ClickAndLoad(_elementModificationsRadioBtn);
            //Actions.Click(_elementModificationsRadioBtn);
            Console.WriteLine("Modifications is selected as yes");
            // Waits.WaitForPageLoad();
            Actions.SendKeys(_elementModificationsSpecifyField, "Testing!");
            Console.WriteLine("Testing! is entered in modificatipn specify field");
        }

        //this method is used to sign 3 signature in label verification page
        public void SignatureInLabelVerificationPage(string userName, string password)
        {
            ClickAndLoad(_elementProductTagsPreparer);
            //Actions.Click(_elementProductTagsPreparer);
            //Waits.WaitForPageLoad();
            SignInWithCredential(userName, password);
            ClickAndLoad(_elementProductTagsPreparerDoneBtn);
            //Actions.Click(_elementProductTagsPreparerDoneBtn);
            //Waits.WaitForPageLoad();
            Console.WriteLine("Product Bags, Product Tags preparer was signed");

            ClickAndLoad(_elementCardsVerifier);
            //Actions.Click(_elementCardsVerifier);
            //Waits.WaitForPageLoad();
            SignInWithCredential(userName, password);
            ClickAndLoad(_elementCardsVerifierDoneBtn);
            //Actions.Click(_elementCardsVerifierDoneBtn);
            //Waits.WaitForPageLoad();
            Console.WriteLine("Processing/Disposition Cards verifier signed");

            ClickAndLoad(_elementModificationVerifier);
            //Actions.Click(_elementModificationVerifier); 
            //Waits.WaitForPageLoad();
            SignInWithCredential(userName, password);
            ClickAndLoad(_elementModificationVerifierDoneBtn);
            //Actions.Click(_elementModificationVerifierDoneBtn);
            //Waits.WaitForPageLoad();
            Console.WriteLine("Modifications verifier signed");
        }

        public void ClickOnProcessingReview()
        {
            ClickAndLoad(_elementProcessingReview);
            //Actions.Click(_elementProcessingReview);
            Console.WriteLine("Processing review page open");
            //Waits.WaitForPageLoad();
        }

        public void ClickOnProcessingReview1CheckMark(string userName, string password)
        {
            ClickAndLoad(_elementProcessingReviewer1);
            //Actions.Click(_elementProcessingReviewer1);
            //Waits.WaitForPageLoad();
            SignInWithCredential(userName, password);
            ClickAndLoad(_elementProcessingReviewerDone);
            //Actions.Click(_elementProcessingReviewerDone);
            Console.WriteLine("Processing Reviewer #1 is signed");
            //Waits.WaitForPageLoad();
        }

        //Cryopreservation

        public void ClickOnCryopreservation()
        {
            ClickAndLoad(_elementCryoperservation);
            //Actions.Click(_elementCryoperservation);
            Console.WriteLine("Cryopreservation page is open");
            //Waits.WaitForPageLoad();
        }

        public void FillInDetailsInCryopreservationPage(int randomNumber)
        {
            Actions.Click(_elementHSACheckBox);
            Actions.Click(_elementAutologousPlasma);
            Actions.SendKeys(_elementInitialProductVolume, randomNumber.ToString());
            Console.WriteLine(randomNumber + " is entered in Initial Product Volume field");
            Actions.SendKeys(_elementPlasmaAdded, randomNumber.ToString());
            Console.WriteLine(randomNumber + " is entered in Volume of Plasma Added field");
            Actions.SendKeys(_elementAlbuminAdded, randomNumber.ToString());
            Console.WriteLine(randomNumber + " is entered in Volume of Albumin Added field");
            Actions.SendKeys(_elementFreezSolution, randomNumber.ToString());
            Console.WriteLine(randomNumber + " is entered in Freeze Solution field");
            Actions.PressKey(Keys.Enter);
            Waits.WaitForPageLoad();
            Console.WriteLine("25% HSA and Autologous plasma has been selected");

            Assert.True(Convert.ToInt32(Actions.GetAttributeValue(_elementFinalVolume, "value")) == 4 * randomNumber, "The calculation is not correct");

            Actions.SelectByRandoxIndex(_elementLaminarFlowHoodDDL);
            Console.WriteLine(Actions.GetAttributeValue(_elementLaminarFlowHoodDDL, "value") + " is selected in the Laminar Flow Hood drop dowm");
            Actions.SendKeys(_elementGuageReading, randomNumber.ToString());
            Console.WriteLine(randomNumber + " is entered inMagnehelic Gauge Reading field");
            Actions.Click(_elementFreezeSolutionPreparTimeClock);
            Actions.Click(_elementFreezeSolutionPreparDateClock);
            Console.WriteLine("Current time is entered for the solution prepared");

            Actions.SelectByRandoxIndex(_elementFreezingProgramDDL);
            Console.WriteLine(Actions.GetAttributeValue(_elementFreezingProgramDDL, "value") + " is selected in the Freezing Program drop dowm");
            Actions.SelectByRandoxIndex(_elementFreezerIDDDL);
            Console.WriteLine(Actions.GetAttributeValue(_elementFreezerIDDDL, "value") + " is selected in the Freezer ID drop dowm");
            Actions.SendKeys(_elementProbeNumber, randomNumber.ToString());
            Console.WriteLine(randomNumber + " is entered in Probe # field");
            ClickAndLoad(_elementFreezeCurveReview);
            //Actions.Click(_elementFreezeCurveReview);
            Console.WriteLine("Not Acceptable is selected in Freeze Curve Review radio button");
            //Waits.WaitForPageLoad();
            Actions.SendKeys(_elementFreezeCurveReviewSpecifyField, "Testing!");
            Console.WriteLine("Testing! is entered in freeze Curve Review specify");

            Actions.Click(_elementEligibleForStorage);
            Console.WriteLine("Yes is selected for Eligible for Storage radio button");
        }

        //this method is to sign the 2 signature on the cryopreservation page
        public void SignatureInCryopreservationPage(string userName, string password)
        {
            ClickAndLoad(_elementFreezeSolutionPreparer);
            //Actions.Click(_elementFreezeSolutionPreparer);
            //Waits.WaitForPageLoad();
            SignInWithCredential(userName, password);
            ClickAndLoad(_elementFreezeSolutionPreparerDone);
            //Actions.Click(_elementFreezeSolutionPreparerDone);
            //Waits.WaitForPageLoad();
            Console.WriteLine("20% DMSO Freeze Solution Preparer was signed");

            ClickAndLoad(_elementFreezeReviewPerformer);
            //Actions.Click(_elementFreezeReviewPerformer);
            //Waits.WaitForPageLoad();
            SignInWithCredential(userName, password);
            ClickAndLoad(_elementFreezeReviewPerformerDone);
            //Actions.Click(_elementFreezeReviewPerformerDone);
            //Waits.WaitForPageLoad();
            Console.WriteLine("Freeze review Performer signed");
        }

        public void ClickOnRBCDepletion()
        {
            ClickAndLoad(_elementRBCDepletion);
            //Actions.Click(_elementRBCDepletion);
            Console.WriteLine("RBC Depletion page is opened");
            //Waits.WaitForPageLoad();
        }

        public void ClickOnHES1()
        {
            ClickAndLoad(_elementHES1);
            //Actions.Click(_elementHES1);
            Console.WriteLine("HES-1 page opened");
            //Waits.WaitForPageLoad();
        }

        //this method is used to fill in the first section of HES-1 and verify the calculation
        public void FillInFirstSectionHES1AndVerify(double totalVolume, double nucleatedCellCount, double HCTPersentage, double RBCVolume)
        {
            Actions.Click(_elementRBCDepletionDateClockBtn1);
            Console.WriteLine("Current time entered for RBC Depletion Date");
            Actions.SendKeys(_elementTotalVolumeField1, totalVolume.ToString());
            Console.WriteLine(totalVolume + " is entered on Total Volume field");
            Actions.PressKey(Keys.Enter);
            Waits.WaitForPageLoad();
            Actions.SendKeys(_elementNucleatedCellCountField1, nucleatedCellCount.ToString());
            Console.WriteLine(nucleatedCellCount + " is entered on Nucleated Cell Count field");
            Actions.PressKey(Keys.Enter);
            Waits.WaitForPageLoad();
            Actions.SendKeys(_elementHCTField1, HCTPersentage.ToString());
            Console.WriteLine(HCTPersentage + " is entered on HCT% field");
            Actions.SendKeys(_elementRBCVolumeField1, RBCVolume.ToString());
            Console.WriteLine(RBCVolume + " is entered on RBC Volume field");
            Actions.PressKey(Keys.Enter);
            Waits.WaitForPageLoad();

        }

        public bool VerifyFirstSection(double totalNucleatedCells)
        {

            if (Convert.ToDouble(Actions.GetAttributeValue(_elementTotalNucleatedCellsField1, "value")) == totalNucleatedCells)
                return true;
            else
                return false;
        }

        //this method is used to fill in the second section of HES-1
        public void FillInSecondSectionHES1()
        {
            Actions.SelectByIndex(_elementProcessingStepIIDDL2, 2);
            Console.WriteLine("Not Applicable is selected for the drop down");
        }

        //this method is used to fill in the third section of HES-1
        public void FillInThirdSectionHES1(double totalVolume, string date, string ReagentID)
        {
            Actions.SelectByIndex(_elementProcessingStepIIIDDL3, 1);
            Console.WriteLine("Addition of 6% Hetastarch is selected for Processing step drop down");
            Waits.WaitForPageLoad();
            Actions.SendKeys(_elementTotalVolumeField3, totalVolume.ToString());
            Actions.PressKey(Keys.Enter);
            Waits.WaitForPageLoad();
            Actions.Click(_elementHetastarchAddedRadioBtnNo3);
            Console.WriteLine("No was selected for Hetastarch added");
            Actions.SelectByRandoxIndex(_elementHatastarchAdderDDL3);
            Console.WriteLine(Actions.GetAttributeValue(_elementHatastarchAdderDDL3, "value") + " is selected for Hetastarch added by DDL");
            Actions.SendKeys(_elementHetastarchAddedDateField3, date);
            Console.WriteLine(date + " is entered on Hetastarch Added Date");
            Actions.Click(_elementHetastarchAddedTimeClock3);
            Console.WriteLine("current time is entered");
            Actions.SendKeys(_elementHetastarchReagentIDField3, ReagentID);
            Console.WriteLine(ReagentID + " is entered for Reagent ID field");
        }

        public bool VerifyThirdSection(double hetastarch)
        {
            if (Convert.ToDouble(Actions.GetAttributeValue(_elementHetastarchField3, "value")) == hetastarch)
                return true;
            else
                return false;
        }

        public void FillinFourthSectionHES1(double totalVolume, double plasmalyte, double hetastarch)
        {
            Actions.SendKeys(_elementInitialProductField4, totalVolume.ToString());
            Waits.WaitForPageLoad();
            Console.WriteLine(totalVolume + " is entered on initial product");
            Actions.SendKeys(_elementPlasmalyteAField4, plasmalyte.ToString());
            Console.WriteLine(plasmalyte + " is entered on the Plasmalyte-A field");
            Waits.WaitForPageLoad();
            Actions.SendKeys(_element6HetastarchField4, hetastarch.ToString());
            Console.WriteLine(hetastarch + " is entered for 6% Hetastarch field");
            Waits.WaitForPageLoad();
            ClickAndLoad(_elementMixedRadioBtnNo4);
            //Actions.Click(_elementMixedRadioBtnNo4);
            //Waits.WaitForPageLoad();
            Console.WriteLine("No is selected for mixed radio button");
            Actions.SendKeys(_elementMixedSpecifyField4, "Testing!");
            Console.WriteLine("Testing! is entered on the mixed specify field");
        }

        public bool VerifyFourthSection(double totalVolume, double plasmalyte, double hetastarch)
        {
            double FinalVolume = totalVolume + plasmalyte + hetastarch;
            if (Convert.ToDouble(Actions.GetAttributeValue(_elementFinalVolume4, "value")) == FinalVolume)
                return true;
            else
                return false;
        }

        public void FillInFifthSectionHES1(string PreHes1SedimentationVolume, string PreHes1SedimentationNC, string PreHes1SedimentationTNC,
            string PreHes1SedimentationHCT, string PreHes1SedimentationRBC, string PostHes1SedimentationVolume, string PostHes1SedimentationNC,
            string PostHes1SedimentationTNC, string PostHes1SedimentationHCT, string PostHes1SedimentationRBC, string PostHes1RemovalVolume,
            string PostHes1RemovalNC, string PostHes1RemovalTNC, string PostHes1RemovalHCT, string PostHes1RemovalRBC, string stopDate)
        {
            ClickAndLoad(_elementStartDateClock5);
            //Actions.Click(_elementStartDateClock5);
            //Waits.WaitForPageLoad();
            Actions.Click(_elementStartTimeClick5);
            Console.WriteLine("Start time and stop time is entered");

            Actions.SendKeys(_elementPreHESSedimentationVolume5, PreHes1SedimentationVolume);
            Actions.SendKeys(_elementPreHESSedimentationNC5, PreHes1SedimentationNC);
            Actions.SendKeys(_elementPreHESSedimentationTNC5, PreHes1SedimentationTNC);
            Actions.PressKey(Keys.Enter);
            Waits.WaitForPageLoad();
            Actions.SendKeys(_elementPreHESSedimentationHTC5, PreHes1SedimentationHCT);
            Actions.SendKeys(_elementPreHESSedimentationRBC5, PreHes1SedimentationRBC);

            Actions.SendKeys(_elementPostHESSedimentationVolume5, PostHes1SedimentationVolume);
            Actions.SendKeys(_elementPostHESSedimentationNC5, PostHes1SedimentationNC);
            Actions.SendKeys(_elementPostHESSedimentationTNC5, PostHes1SedimentationTNC);
            Actions.PressKey(Keys.Enter);
            Waits.WaitForPageLoad();
            Actions.SendKeys(_elementPostHESSedimentationHTC5, PostHes1SedimentationHCT);
            Actions.SendKeys(_elementPostHESSedimentationRBC5, PostHes1SedimentationRBC);

            Actions.SendKeys(_elementPostHESRemovalVolume5, PostHes1RemovalVolume);
            Actions.SendKeys(_elementPostHESRemovalNC5, PostHes1RemovalNC);
            Actions.SendKeys(_elementPostHESRemovalTNC5, PostHes1RemovalTNC);
            Actions.PressKey(Keys.Enter);
            Waits.WaitForPageLoad();
            Actions.SendKeys(_elementPostHESRemovalHTC5, PostHes1RemovalHCT);
            Actions.SendKeys(_elementPostHESRemovalRBC5, PostHes1RemovalRBC);

            //Actions.Click(_elementStopDateClock5);
            Actions.SendKeys(_elementStartDateField, stopDate);
            Waits.WaitForPageLoad();
            Actions.Click(_elementStoPTimeClock5);

            Console.WriteLine("Table is filled in");
        }

        public bool VerifyFifthSection(double initialProductVolume, double initialProductNC, double initialProductTNC,
            double initialproductHCT, double initialProductRBC, double PreHes1SedimentationTNC, double PostHes1SedimentationTNC,
            double PostHes1RemovalTNC)
        {

            if (Convert.ToDouble(Actions.GetAttributeValue(_elementInitialProductVolume5, "value")) != initialProductVolume)
            {
                Console.WriteLine(Actions.GetAttributeValue(_elementInitialProductVolume5, "value") + " != " + initialProductVolume);
                Console.WriteLine("1");
                return false;
            }
            else if (Convert.ToDouble(Actions.GetAttributeValue(_elementInitialProductNC5, "value")) != initialProductNC)
            {
                Console.WriteLine(Actions.GetAttributeValue(_elementInitialProductNC5, "value") + " != " + initialProductNC);
                Console.WriteLine("2");
                return false;
            }
            else if (Convert.ToDouble(Actions.GetAttributeValue(_elementInitialProductTNC5, "value")) != initialProductTNC)
            {
                Console.WriteLine(Actions.GetAttributeValue(_elementInitialProductTNC5, "value") + " != " + initialProductTNC);
                Console.WriteLine("3");
                return false;
            }
            else if (Convert.ToDouble(Actions.GetAttributeValue(_elementInitialProductHCT5, "value")) != initialproductHCT)
            {
                Console.WriteLine(Actions.GetAttributeValue(_elementInitialProductHCT5, "value") + " != " + initialproductHCT);
                Console.WriteLine("4");
                return false;
            }
            else if (Convert.ToDouble(Actions.GetAttributeValue(_elementInitialProductRBC5, "value")) != initialProductRBC)
            {
                Console.WriteLine(Actions.GetAttributeValue(_elementInitialProductRBC5, "value") + " != " + initialProductRBC);
                Console.WriteLine("5");
                return false;
            }
            else if (Convert.ToDouble(Actions.GetAttributeValue(_elementPostHESSedimentationTNCRecovery5, "value")) != PostHes1SedimentationTNC)
            {
                Console.WriteLine(Actions.GetAttributeValue(_elementPostHESSedimentationTNCRecovery5, "value") + " != " + PostHes1SedimentationTNC);

                Console.WriteLine("7");
                return false;
            }
            else if (Convert.ToDouble(Actions.GetAttributeValue(_elementPostHESRemovalTNCRecovery5, "value")) != PostHes1RemovalTNC)
            {
                Console.WriteLine(Actions.GetAttributeValue(_elementPostHESRemovalTNCRecovery5, "value") + " != " + PostHes1RemovalTNC);
                Console.WriteLine("8");
                return false;
            }
            else if (Convert.ToDouble(Actions.GetAttributeValue(_elementPreHESSedimentationTNCRecovery5, "value")) != PreHes1SedimentationTNC)
            {
                Console.WriteLine("6");
                Console.WriteLine(Actions.GetAttributeValue(_elementPreHESSedimentationTNCRecovery5, "value") + " != " + PreHes1SedimentationTNC);
                return false;
            }

            else
                return true;
        }

        public void ClickOnProcessingStep1()
        {
            ClickAndLoad(_elementProcessingStep1);
            //Actions.Click(_elementProcessingStep1);
            Console.WriteLine("Processing Step 1 is opened");
            //Waits.WaitForPageLoad();
        }

        //this method is used to fill in the fields in the processing step 1 form
        public void FillInProcessingStep1Form(string productGrossWeight, string bagTareWeight, string totalVolume, string nucleatedCellCount)
        {
            Actions.SelectByIndex(_elementProcessingTypeDDL, 1);
            Console.WriteLine("Initial is being selected from the processing type ddl");
            Actions.SendKeys(_elementNucleatedCellCount, nucleatedCellCount);
            Console.WriteLine(nucleatedCellCount + " is entered for the Nucleated Cell Count Field");
            Actions.PressKey(Keys.Enter);
            Waits.WaitForPageLoad();
            Actions.SendKeys(_elementProductGrowssWeight, productGrossWeight);
            Console.WriteLine(productGrossWeight + " is entered for the product growss weight field");
            Actions.SendKeys(_elementBagTareWeight, bagTareWeight);
            Console.WriteLine(bagTareWeight + " is entered for the Bag Tare Weight field");
            Actions.SendKeys(_elementTotalVolume, totalVolume);
            Console.WriteLine(totalVolume + " is entered for the total volume field"); ;
            ClickAndLoad(_elementMNCRadioBtnNo);
            //Actions.Click(_elementMNCRadioBtnNo);
            //Waits.WaitForPageLoad();
            ClickAndLoad(_elementCD3RadioNo);
            //Actions.Click(_elementCD3RadioNo);
            //Waits.WaitForPageLoad();
            Console.WriteLine("Not avaliable is selected for both radio buttons");
        }

        //this method is used to verify the processing step 1 page
        public bool VerifyProcessingStep1Form()
        {
            double totalNucleatedCellCount = Convert.ToDouble(Actions.GetAttributeValue(_elementTotalNucleatedCells, "value"));
            double nucleatedCells = Convert.ToDouble(Actions.GetAttributeValue(_elementNucleatedCell, "value"));
            double totalVolume = Convert.ToDouble(Actions.GetAttributeValue(_elementTotalVolume, "value"));
            double nucleatedCellCount = Convert.ToDouble(Actions.GetAttributeValue(_elementNucleatedCellCount, "value"));
            if (Math.Round(totalNucleatedCellCount, 2, MidpointRounding.AwayFromZero) == Math.Round(totalVolume * nucleatedCellCount / 1e2, 2))
            {
                Console.WriteLine("Calculation is verified");
                return true;
            }
            else
            {
                Console.WriteLine(Math.Round(totalNucleatedCellCount, 2, MidpointRounding.AwayFromZero) + " != " + Math.Round(totalVolume * nucleatedCellCount / 1e2, 2));
                return false;
            }
        }

        //this method is to sign processing procedure
        public void SignProcessingStep(string processingStepNumber, string userName, string password)
        {
            By _elementProcessingStepSignature = By.Id("sign_pr" + processingStepNumber + "Tech1Review");
            By _elementprocessingStepSignatureDone = By.Id("doneLink_pr" + processingStepNumber + "Tech1Review");
            ClickAndLoad(_elementProcessingStepSignature);
            //Actions.Click(_elementProcessingStepSignature);
            //Waits.WaitForPageLoad();
            SignInWithCredential(userName, password);
            ClickAndLoad(_elementprocessingStepSignatureDone);
            //Actions.Click(_elementprocessingStepSignatureDone);
            //Waits.WaitForPageLoad();
        }

        //this method is used to click on processing step 2 page
        public void ClickOnProcessingStep2()
        {
            Actions.Click(_elementProcessingStep2);
            Console.WriteLine("Processing step 2 page is opened");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="totalVolume"></param>
        /// <param name="nucleatedCellCount"></param>
        /// <param name="cd34"></param>
        /// <param name="cd3"></param>
        public void FillInProcessingStep2Form(string totalVolume, string nucleatedCellCount, string cd34, string cd3)
        {
            Actions.SelectByIndex(_elementProcessingTypeDDLStep2, 1);
            Waits.WaitForPageLoad();
            Actions.SendKeys(_elementTotalVolumeStep2, totalVolume);
            Console.WriteLine(totalVolume + " is entered for the total volume field");
            Actions.PressKey(Keys.Enter);
            Waits.WaitForPageLoad();
            Actions.SendKeys(_elementNucleatedCellCountStep2, nucleatedCellCount);
            Console.WriteLine(nucleatedCellCount + " is entered to the Nucleated Cell Count field");
            Actions.PressKey(Keys.Enter);
            Waits.WaitForPageLoad();
            Actions.Click(_elementMNCRadioBtnNoStep2);
            Actions.SendKeys(_elementCD34Step2, cd34);
            Console.WriteLine(cd34 + " is entered to the %CD34+ field");
            Actions.PressKey(Keys.Enter);
            Waits.WaitForPageLoad();
            ClickAndLoad(_elementCD3RadioYesStep2);
            //Actions.Click(_elementCD3RadioYesStep2);
            //Waits.WaitForPageLoad();
            Actions.SendKeys(_elementCD3PlusStep2, cd3);
            Console.WriteLine(cd3 + " is entered to the %cd3+ field");
            Actions.PressKey(Keys.Enter);
            Waits.WaitForPageLoad();
            ClickAndLoad(_elementRecoveryAcceptabilityRadiobtnNo);
            //Actions.Click(_elementRecoveryAcceptabilityRadiobtnNo);
            //Waits.WaitForPageLoad();
            Actions.SendKeys(_elementRecoveryAcceptabilitySpecify, "Testing!");
            Console.WriteLine("Not available is selected for MNC");
            Console.WriteLine("available is selected for %cd3+");
            Console.WriteLine("No is selected for Recovery Acceptability, and Testing! is entered for the specify");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool VerifyProcessingStep2Form()
        {
            double weight = Convert.ToDouble(Actions.GetAttributeValue(_elementRecipientWeight, "value"));
            double totalVolume = Convert.ToDouble(Actions.GetAttributeValue(_elementTotalVolumeStep2, "value"));
            double nucleatedCellCount = Convert.ToDouble(Actions.GetAttributeValue(_elementNucleatedCellCountStep2, "value"));
            double totalNucleatedCellCount = Convert.ToDouble(Actions.GetAttributeValue(_elementTotalNucleatedCellsStep2, "value"));
            double nucleatedCellsPerKg = Convert.ToDouble(Actions.GetAttributeValue(_elementNucleatedCellStep2, "value"));
            double cd34 = Convert.ToDouble(Actions.GetAttributeValue(_elementCD34Step2, "value"));
            double cd34PerKg = Convert.ToDouble(Actions.GetAttributeValue(_elementCD34PerKgStep2, "value"));
            double cd3Plus = Convert.ToDouble(Actions.GetAttributeValue(_elementCD3PlusStep2, "value"));
            double cd3PlusPerKg = Convert.ToDouble(Actions.GetAttributeValue(_elementCD3PlusPerKgStep2, "value"));

            if (totalNucleatedCellCount != (Math.Round(totalVolume * nucleatedCellCount / 1e2, 2)))
            {
                Console.WriteLine("Total nucleated cells is not correctly calculated");
                Console.WriteLine(totalNucleatedCellCount + " != " + (Math.Round(totalVolume * nucleatedCellCount / 1e2, 2)));
                return false;
            }
            else if (nucleatedCellsPerKg != (Math.Round(totalNucleatedCellCount / weight * 1e2, 2)))
            {
                Console.WriteLine("Nucleated Cell / kg is not correctly calculated");
                Console.WriteLine(nucleatedCellsPerKg + " != " + (Math.Round(totalNucleatedCellCount / weight * 1e2, 2)));
                return false;
            }
            else if (cd34PerKg != (Math.Round(nucleatedCellsPerKg * cd34, 2)))
            {
                Console.WriteLine(cd34PerKg + " != " + (Math.Round(nucleatedCellsPerKg * cd34, 2)));
                Console.WriteLine("cd34 / kg is not correctly calculated");
                return false;
            }
            else if (cd3PlusPerKg != (Math.Round(nucleatedCellsPerKg * cd3Plus / 1e2, 2)))
            {
                Console.WriteLine("cd3+ / kg is not correctly calculated");
                Console.WriteLine(cd34PerKg + " != " + (Math.Round(nucleatedCellsPerKg * cd3Plus / 1e2, 2)));
                return false;
            }
            else
            {
                return true;
            }
        }

        // General Methods =====

        /// <summary>
        /// Click on an element and wait for the page to load.
        /// </summary>
        /// <param name="element"></param>
        public void ClickAndLoad(By element)
        {
            Actions.Click(element);
            Waits.WaitForPageLoad();
        }

        /// <summary>
        /// Types a string into a text field and then waits for it to update the page.  Used to enter information in text fields that are used to compute values for other fields.
        /// </summary>
        /// <param name="element">Web element of text field.</param>
        /// <param name="text">String to type into text field.</param>
        public void FillFieldAndLoad(By element, string text)
        {
            Actions.SendKeys(element, text);
            Actions.PressKey(Keys.Enter);
            Waits.WaitForPageLoad();
        }

        /// <summary>
        /// Clicks on a radio button when two choices are present.
        /// </summary>
        /// <param name="elementId">ID of radio buttons.</param>
        /// <param name="choice">true for CSS value 1, false for CSS value 2.</param>
        public void SelectYesOrNo(string elementId, bool choice)
        {
            string cssVal;
            if (choice)
            {
                cssVal = "1";
            }
            else
            {
                cssVal = "2";
            }
            Actions.Click(By.CssSelector("input[id='" + elementId + "'][value='" + cssVal + "']"));
        }

        /// <summary>
        /// Selects or unselects a checkbox.
        /// </summary>
        /// <param name="element">Web element of checkbox.</param>
        /// <param name="choice">false to unselect, true to select.</param>
        public void CheckOrUncheck(By element, bool choice)
        {
            if (choice)
            {
                Actions.SelectCheckbox(element);
            }
            else
            {
                Actions.UnselectCheckbox(element);
            }
        }

        public void EnterSignatureInfo(string username, string password)
        {
            Actions.SendKeys(_elementUserName, username);
            Actions.SendKeys(_elementPassword, password);
            ClickAndLoad(_elementAuthorizeBtn);
        }

        /// <summary>
        /// Compares value calculated in Transtem to value calculated in test function.
        /// </summary>
        /// <param name="given">Value given from Transtem.</param>
        /// <param name="calculated">Value given from testing function.</param>
        /// <param name="tolerance">Greatest allowed difference between values.</param>
        /// <returns>Returns true if difference between values is less than tolerance; returns false otherwise.</returns>
        public bool CompareGivenAndCalculated(double given, double calculated, double tolerance)
        {
            Console.WriteLine("Given by web element: " + given.ToString() + "; calculated by test function: " + calculated.ToString() + "; tolerance: " + tolerance);
            return Math.Abs(given - calculated) < tolerance;
        }

        /// <summary>
        /// Compares a text field's value to a value calculated with testing function.
        /// </summary>
        /// <param name="givenElement">Text field web element.</param>
        /// <param name="calculated">Value calculated with testing function.</param>
        /// <param name="tolerance">Greatest allowed difference between values.</param>
        /// <returns>Returns true if difference between value read from web element and value calculated with testing function is less than tolerance; returns false otherwise.</returns>
        public bool CompareGivenAndCalculated(By givenElement, double calculated, double tolerance)
        {
            return CompareGivenAndCalculated(Convert.ToDouble(Actions.GetAttributeValue(givenElement, "value")), calculated, tolerance);
        }

        //  CD34 Selection methods +++++

        //    CD34+ Section A ======

        public void ClickOnCD34SectionA()
        {
            Actions.Click(_elementCD34SectionA);
            Console.WriteLine("Clicked on CD34+ Section A header");
            Waits.WaitForPageLoad();
        }

        public void FillInTransferOfLeukapheresisIntoCPB(string date, string time, bool removeLeukapheresis, double CPBWithLeukapheresis, double CPBEmpty, bool reducedNA, double weightAfterReduction)
        {
            FillFieldAndLoad(_elementCD34SectionAStartingDate, date);
            FillFieldAndLoad(_elementCD34SectionAStartingTime, time);
            SelectYesOrNo("ProcedureData_ComponentList_16__Fields_3__ValueRadio", removeLeukapheresis);
            FillFieldAndLoad(_elementCD34SectionAWeightOfCPBWithLeukapheresis, CPBWithLeukapheresis.ToString());
            FillFieldAndLoad(_elementCD34SectionAWeightOfEmptyCPB, CPBEmpty.ToString());
            CheckOrUncheck(_elementCD34SectionAReducedNABox, reducedNA);
            FillFieldAndLoad(_elementCD34SectionAWeightOfLeukapheresisAfterReduction, weightAfterReduction.ToString());
        }

        public void FillInDilutingLeukapheresis(double actualBufferAdded, double totalCPBWeightAfterBuffer)
        {
            Actions.SendKeys(_elementCD34SectionAActualBufferAdded, actualBufferAdded.ToString());
            FillFieldAndLoad(_elementCD34SectionATotalCPBWeightAfterBuffer, totalCPBWeightAfterBuffer.ToString());
        }

        public void FillInCentrifugationConditions(string id, double time, double speed, bool targetIs95)
        {
            Actions.SendKeys(_elementCD34SectionACentrifugeID, id);
            Actions.SendKeys(_elementCD34SectionACentrifugationTime, time.ToString());
            Actions.SendKeys(_elementCD34SectionACentrifugationSpeed, speed.ToString());
            SelectYesOrNo("ProcedureData_ComponentList_16__Fields_21__ValueRadio", targetIs95);
            Waits.WaitForPageLoad();
        }

        public void FillInCalculatingSupernatantToBeRemoved(string actualSupernatantAmountRemoved, string totalCPBWeightAfter)
        {
            if (Actions.IsSelected(_elementCD34SectionATargetFinalVolume95RadioBtn))
            {
                Actions.SendKeys(_elementCD34SectionA95ActualAmountOfSupernatantRemoved, actualSupernatantAmountRemoved);
                FillFieldAndLoad(_elementCD34SectionA95TotalCPBWeightAfterDilution, totalCPBWeightAfter);
            }
            else if (Actions.IsSelected(_elementCD34SectionATargetFinalVolume190RadioBtn))
            {
                Actions.SendKeys(_elementCD34SectionA190ActualAmountOfSupernatantRemoved, actualSupernatantAmountRemoved);
                FillFieldAndLoad(_elementCD34SectionA190TotalCPBWeightAfterDilution, totalCPBWeightAfter);
            }
            else
            {
                return;
            }
        }

        public double CalculateLeukapheresisProductWeight(double withProduct, double withoutProduct)
        {
            return withProduct - withoutProduct;
        }

        public double CalculateBufferToBeAdded(double productWeight)
        {
            return 2 * productWeight;
        }

        public double CalculateTotalLeukapheresisWeightAfterBuffer(double CPBWeightAfterBuffer, double CPBWeightWithoutProduct)
        {
            return CPBWeightAfterBuffer - CPBWeightWithoutProduct;
        }

        public double CalculateAmountOfSupernatantToBeRemoved(double totalLeukapheresisWeightAfterBuffer, bool targetMassIs95)
        {
            double targetFinalMass;
            if (targetMassIs95)
            {
                targetFinalMass = 95;
            }
            else
            {
                targetFinalMass = 190;
            }
            return totalLeukapheresisWeightAfterBuffer - targetFinalMass;
        }

        public double CalculateTotalLeukapheresisWeightAfterDilution(double CPBWeightAfterDilution, double CPBWeightWithoutProduct)
        {
            return CPBWeightAfterDilution - CPBWeightWithoutProduct;
        }

        public bool CheckCD34SectionALeukapheresisProductWeight(double CPBWeightWithProduct, double CPBWeightWithoutProduct)
        {
            double given = Convert.ToDouble(Actions.GetAttributeValue(_elementCD34SectionAWeightOfLeukapheresis, "value"));
            double calculated = CalculateLeukapheresisProductWeight(CPBWeightWithProduct, CPBWeightWithoutProduct);
            Console.WriteLine("For weight of leukapheresis product, given result is " + given.ToString() + " and calculated result is " + calculated.ToString());
            return Math.Abs(given - calculated) < MaxTolerance;
        }

        public bool CheckCD34SectionAWeightOfBufferUsingA4(double productWeight)
        {
            double given = Convert.ToDouble(Actions.GetAttributeValue(_elementCD34SectionAWeightOfBufferUsingA4, "value"));
            double calculated = CalculateBufferToBeAdded(productWeight);
            Console.WriteLine("For weight of CliniMACS PBS/EDTA buffer to be added using A4, given result is " + given.ToString() + " and calculated result is " + calculated.ToString());
            return given == calculated;
        }

        public bool CheckCD34SectionAWeightOfBufferUsingA4Reduced(double productWeight)
        {
            double given = Convert.ToDouble(Actions.GetAttributeValue(_elementCD34SectionAWeightOfBufferUsingA4Reduced, "value"));
            double calculated = CalculateBufferToBeAdded(productWeight);
            Console.WriteLine("For weight of CliniMACS PBS/EDTA buffer to be added using A4 reduced, given result is " + given.ToString() + " and calculated result is " + calculated.ToString());
            return given == calculated;
        }

        public bool CheckCD34SectionATotalLeukapheresisWeightAfterBuffer(double CPBWeightAfterBuffer, double CPBWeightWithoutProduct)
        {
            double given = Convert.ToDouble(Actions.GetAttributeValue(_elementCD34SectionATotalLeukapheresisWeightAfterBuffer, "value"));
            double calculated = CalculateTotalLeukapheresisWeightAfterBuffer(CPBWeightAfterBuffer, CPBWeightWithoutProduct);
            Console.WriteLine("For weight of total leukapheresis product after adding buffer, given result is " + given.ToString() + " and calculated result is " + calculated.ToString());
            return given == calculated;
        }

        public bool CheckCD34SectionAAmountOfSupernatantToBeRemoved(double totalLeukapheresisWeightAfterBuffer, bool targetMassIs95)
        {
            double given;
            double calculated;
            if (targetMassIs95)
            {
                given = Convert.ToDouble(Actions.GetAttributeValue(_elementCD34SectionA95AmountOfSupernatantToBeRemoved, "value"));
            }
            else
            {
                given = Convert.ToDouble(Actions.GetAttributeValue(_elementCD34SectionA190AmountOfSupernatantToBeRemoved, "value"));
            }
            calculated = CalculateAmountOfSupernatantToBeRemoved(totalLeukapheresisWeightAfterBuffer, targetMassIs95);
            Console.WriteLine("For amount of supernatant to be removed, given result is " + given.ToString() + " and calculated result is " + calculated.ToString());
            return given == calculated;
        }

        public bool CheckCD34SectionA95TotalLeukapheresisWeightAfterDilution(double calculated)
        {
            double given = Convert.ToDouble(Actions.GetAttributeValue(_elementCD34SectionA95TotalLeukapheresisWeightAfterDilution, "value"));
            Console.WriteLine("For amount of supernatant to be removed, given result is " + given.ToString() + " and calculated result is " + calculated.ToString());
            return given == calculated;
        }

        public bool CheckCD34SectionA95TotalLeukapheresisWeightAfterDilution(double CPBWeightAfterDilution, double CPBWeightWithoutProduct)
        {
            return CheckCD34SectionA95TotalLeukapheresisWeightAfterDilution(CalculateTotalLeukapheresisWeightAfterDilution(CPBWeightAfterDilution, CPBWeightWithoutProduct));
        }

        public void VerifyCD34SectionA(double CPBWeightWithProduct, double CPBWeightWithoutProduct, double reducedProduct, double CPBWeightAfterBuffer)
        {
            Assert.True(Actions.IsSelected(_elementCD34SectionATargetFinalVolume95RadioBtn) || Actions.IsSelected(_elementCD34SectionATargetFinalVolume190RadioBtn), "No final volume button selected");
            bool finalVolumeIs95 = Actions.IsSelected(_elementCD34SectionATargetFinalVolume95RadioBtn);
            string errorMsg = "Expected and actual values do not match";
            double nonReducedProduct = CalculateTotalLeukapheresisWeightAfterDilution(CPBWeightWithProduct, CPBWeightWithoutProduct);
            double totalLeukapheresisWeightAfterBuffer = CalculateTotalLeukapheresisWeightAfterDilution(CPBWeightAfterBuffer, CPBWeightWithoutProduct);

            Assert.True(CheckCD34SectionALeukapheresisProductWeight(CPBWeightWithProduct, CPBWeightWithoutProduct), errorMsg);
            Assert.True(CheckCD34SectionAWeightOfBufferUsingA4(nonReducedProduct), errorMsg);

            if (!Actions.IsSelected(_elementCD34SectionAReducedNABox))
            {
                Assert.True(CheckCD34SectionAWeightOfBufferUsingA4Reduced(nonReducedProduct), errorMsg);
            }

            Assert.True(CheckCD34SectionATotalLeukapheresisWeightAfterBuffer(CPBWeightAfterBuffer, CPBWeightWithoutProduct), errorMsg);
            Assert.True(CheckCD34SectionAAmountOfSupernatantToBeRemoved(totalLeukapheresisWeightAfterBuffer, finalVolumeIs95), errorMsg);
        }

        //    CD34 Section B ======

        public void ClickOnCD34SectionB()
        {
            Actions.Click(_elementCD34SectionB);
            Console.WriteLine("Clicked on CD34+ Section B header");
            Waits.WaitForPageLoad();
        }

        public void FillInMagneticLabeling(string reagentID, string secondReagentID)
        {
            Actions.SendKeys(_elementCD34SectionBReagentID, reagentID);
            Actions.SendKeys(_elementCD34SectionBSecondReagentID, secondReagentID);
        }

        public void FillInIncubation(string startTime, string stopTime, bool airInjection, bool placedOnRotator, string comment)
        {
            Actions.SendKeys(_elementCD34SectionBIncubationStartTime, startTime);
            SelectYesOrNo("ProcedureData_ComponentList_17__Fields_5__ValueRadio", airInjection);
            SelectYesOrNo("ProcedureData_ComponentList_17__Fields_6__ValueRadio", placedOnRotator);
            Waits.WaitForPageLoad();
            Actions.SendKeys(_elementCD34SectionBPlacedOnRotatorSpecify, comment);
            Actions.SendKeys(_elementCD34SectionBIncubationStopTime, stopTime);
        }

        public void FillInWash1(string amountOfBuffer, string centrifugeID, string centrifugeTime, string centrifugeSpeed, string amountSupernatantRemoved)
        {
            Actions.SendKeys(_elementCD34SectionBWash1AmountOfBuffer, amountOfBuffer);
            Actions.SendKeys(_elementCD34SectionBWash1CentrifugeID, centrifugeID);
            Actions.SendKeys(_elementCD34SectionBWash1CentrifugationTime, centrifugeTime);
            Actions.SendKeys(_elementCD34SectionBWash1CentrifugationSpeed, centrifugeSpeed);
            Actions.SendKeys(_elementCD34SectionBWash1AmountOfRemovedSupernatant, amountSupernatantRemoved);
        }

        public void FillInWash2(string amountOfBuffer, string centrifugeID, string centrifugeTime, string centrifugeSpeed, string amountSupernatantRemoved, string CPBWeight)
        {
            Actions.SendKeys(_elementCD34SectionBWash2AmountOfBuffer, amountOfBuffer);
            Actions.SendKeys(_elementCD34SectionBWash2CentrifugeID, centrifugeID);
            Actions.SendKeys(_elementCD34SectionBWash2CentrifugationTime, centrifugeTime);
            Actions.SendKeys(_elementCD34SectionBWash2CentrifugationSpeed, centrifugeSpeed);
            Actions.SendKeys(_elementCD34SectionBWash2AmountOfRemovedSupernatant, amountSupernatantRemoved);
            Actions.SendKeys(_elementCD34SectionBWeightOfCPBAfterWashing, CPBWeight);
        }

        public void FillInFinalSamplePreparation(bool volAdjustIs150, bool removeLeukapheresis, string CPBWeight)
        {
            SelectYesOrNo("ProcedureData_ComponentList_17__Fields_26__ValueRadio", volAdjustIs150);
            Waits.WaitForPageLoad();
            CheckOrUncheck(_elementCD34SectionBRemoveLeukapheresisBox, removeLeukapheresis);
            FillFieldAndLoad(_elementCD34SectionBCPBWeightAfterBufferAddition, CPBWeight);
        }

        public double CalculateLeukapheresisWeightAfterWash(double CPBWeightAfterWash, double CPBEmptyWeight)
        {
            return CPBWeightAfterWash - CPBEmptyWeight;
        }

        public double CalculateAmountOfBufferToAdd(double leukapheresisWeightAfterWash)
        {
            Assert.True(Actions.IsSelected(_elementCD34SectionBVolumeAdjust150RadioBtn) || Actions.IsSelected(_elementCD34SectionBVolumeAdjust275RatioBtn), "No volume adjustment is selected");
            if (Actions.IsSelected(_elementCD34SectionBVolumeAdjust150RadioBtn))
            {
                return 150 - leukapheresisWeightAfterWash;
            }
            else
            {
                return 275 - leukapheresisWeightAfterWash;
            }
        }

        public double CalculateLeukapheresisWeightAfterBufferAddition(double CPBWeightAfterBufferAddition, double CPBEmptyWeight)
        {
            return CPBWeightAfterBufferAddition - CPBEmptyWeight;
        }

        public void VerifyCD34SectionB(double CPBEmptyWeight)
        {
            Console.WriteLine("Beginning verification for CD34 Selection - CD34+ Section B");
            string errorMsg = "Expected and actual values do not match";
            double tolerance = 0.05;
            string attributeName = "value";
            // CHECK FOR EMPTY TEXT FIELDS
            double CPBWeightAfterWash = Convert.ToDouble(Actions.GetAttributeValue(_elementCD34SectionBWeightOfCPBAfterWashing, attributeName));
            double CPBWeightAfterBufferAddition = Convert.ToDouble(Actions.GetAttributeValue(_elementCD34SectionBCPBWeightAfterBufferAddition, attributeName));

            Console.WriteLine("Checking Weight of leukapheresis product after washing procedure (B12)");
            double productWeightAfterWash = CalculateLeukapheresisWeightAfterWash(CPBWeightAfterWash, CPBEmptyWeight);
            Assert.True(CompareGivenAndCalculated(_elementCD34SectionBWeightOfLeukapheresisAfterWashing, productWeightAfterWash, tolerance), errorMsg);

            Console.WriteLine("Checking Amount of Buffer to Add");
            double bufferToAdd = CalculateAmountOfBufferToAdd(productWeightAfterWash);
            Assert.True(CompareGivenAndCalculated(_elementCD34SectionBAmountOfBufferToAdd, bufferToAdd, tolerance), errorMsg);

            Console.WriteLine("Checking Weight of Leukapheresis Product Bag after Buffer Addition");
            double productWeightAfterBufferAddition = CalculateLeukapheresisWeightAfterBufferAddition(CPBWeightAfterBufferAddition, CPBEmptyWeight);
            Assert.True(CompareGivenAndCalculated(_elementCD34SectionBLeukapheresisWeightAfterBufferAddition, productWeightAfterBufferAddition, tolerance), errorMsg);
        }

        //    CD34+ Section C =====

        public void ClickOnCD34SectionC()
        {
            Actions.Click(_elementCD34SectionC);
            Console.WriteLine("Clicked on CD34+ Section C header");
            Waits.WaitForPageLoad();
        }

        public void FillInCliniMACSSeparation(string dateStarted, string timeStarted, string dateEnded, string timeEnded, string tubingSetReagentID)
        {
            FillFieldAndLoad(_elementCD34SectionCDateRunStarted, dateStarted);
            FillFieldAndLoad(_elementCD34SectionCTimeRunStarted, timeStarted);
            FillFieldAndLoad(_elementCD34SectionCDateRunEnded, dateEnded);
            FillFieldAndLoad(_elementCD34SectionCTimeRunEnded, timeEnded);
            Actions.SendKeys(_elementCD34SectionCTubingSetReagentID, tubingSetReagentID);
            Console.WriteLine("Filled CD34+ Section C CliniMACS Separation (Run)");
        }

        public void FillInCalculateAmountOfPositiveFraction(string cellBagWeightAfterRun, string emptyCellBagWeight, string processCode)
        {
            FillFieldAndLoad(_elementCD34SectionCCPBWeightAfterRun, cellBagWeightAfterRun);
            FillFieldAndLoad(_elementCD34SectionCEmptyCPBWeight, emptyCellBagWeight);
            Actions.SendKeys(_elementCD34SectionCProcessCode, processCode);
            Console.WriteLine("Filled CD34+ Section C Calculate the amount of positive fraction");
        }

        public double CalculateWeightOfPositiveFraction(double CCBWeightAfterRun, double CCBWeightEmpty)
        {
            return CCBWeightAfterRun - CCBWeightEmpty;
        }

        /*
        public bool CheckCD34SectionCWeightOfPositiveFraction(double cellBagWeightAfterRun, double emptyCellBagWeight)
        {
            double given = Convert.ToDouble(Actions.GetAttributeValue(_elementCD34SectionCPositiveFractionWeight, "value"));
            double calculated = CalculateWeightOfPositiveFraction(cellBagWeightAfterRun, emptyCellBagWeight);
            Console.WriteLine("For weight of positive fraction, given result is " + given.ToString() + " and calculated result is " + calculated.ToString());
            return given == calculated;
        }
        */

        public void VerifyCD34SectionC()
        {
            Console.WriteLine("Beginning verification for CD34 Selection - CD34+ Section C");
            string errorMsg = "Expected and actual values do not match";
            double tolerance = 0.05;
            string attributeName = "value";
            // CHECK FOR EMPTY TEXT FIELDS
            double CCBWeightAfterRun = Convert.ToDouble(Actions.GetAttributeValue(_elementCD34SectionCCPBWeightAfterRun, attributeName));
            double CCBWeightEmpty = Convert.ToDouble(Actions.GetAttributeValue(_elementCD34SectionCEmptyCPBWeight, attributeName));

            Console.WriteLine("Checking Weight of positive fraction (C6)");
            double posFracWeight = CalculateWeightOfPositiveFraction(CCBWeightAfterRun, CCBWeightEmpty);
            Assert.True(CompareGivenAndCalculated(_elementCD34SectionCPositiveFractionWeight, posFracWeight, tolerance), errorMsg);
        }

        //    Data Analysis Unselected Processing =====

        public void ClickOnDataAnalysisUnselectedProcessing()
        {
            Actions.Click(_elementDataAnalysisUnselectedProcessing);
            Console.WriteLine("Clicked on Data Analysis Unselected Processing header");
            Waits.WaitForPageLoad();
        }

        /// <summary>
        /// Calculates total nucleated cells.
        /// </summary>
        /// <param name="totalVolume">Measured in mL.</param>
        /// <param name="nucleatedCellCount">Measured in 10^8 cells/mL.</param>
        /// <returns>Measured in 10^10 cells.</returns>
        public double CalculateTotalNucleatedCells(double totalVolume, double nucleatedCellCount)
        {
            Console.WriteLine("Calculating total nucleated cells");
            Console.WriteLine("Taking arguments total volume: " + totalVolume + " and nucleated cell count: " + nucleatedCellCount);
            return (nucleatedCellCount * totalVolume) / 100;
        }

        public double CalculateTotalNucleatedCells(By totalVolume, double nucleatedCellCount)
        {
            return CalculateTotalNucleatedCells(Convert.ToDouble(Actions.GetAttributeValue(totalVolume, "value")), nucleatedCellCount);
        }

        /// <summary>
        /// Calculates number of nucleated cells per kilogram.
        /// </summary>
        /// <param name="totalNucleatedCells">Measured in 10^10 cells.</param>
        /// <param name="recipientWt">Measured in kg.</param>
        /// <returns>Measured in 10^8 cells/kg.</returns>
        public double CalculateNucleatedCellsPerKg(double totalNucleatedCells, double recipientWt)
        {
            Console.WriteLine("Calculating nucleated cells per kg");
            Console.WriteLine("Taking arguments total nucleated cells: " + totalNucleatedCells + " and recipient weight: " + recipientWt);
            return (totalNucleatedCells / recipientWt) * 100;
        }

        public double CalculateNucleatedCellsPerKg(By totalNucleatedCells, double recipientWt)
        {
            return CalculateNucleatedCellsPerKg(Convert.ToDouble(Actions.GetAttributeValue(totalNucleatedCells, "value")), recipientWt);
        }

        /// <summary>
        /// Calculates CD34+/kg.
        /// </summary>
        /// <param name="nucleatedCellsPerKg">Measured in 10^8 cells/kg.</param>
        /// <param name="percentCD34">%CD34+.</param>
        /// <returns>Returns 10^6 CD34+/kg.</returns>
        public double CalculateCD34PerKg(double nucleatedCellsPerKg, double percentCD34)
        {
            Console.WriteLine("Calculating CD34+/kg");
            Console.WriteLine("Taking arguments nucleated cells/kg: " + nucleatedCellsPerKg + " and %CD34+: " + percentCD34);
            return nucleatedCellsPerKg * percentCD34;
        }

        public double CalculateCD34PerKg(By nucleatedCellsPerKg, double percentCD34)
        {
            return CalculateCD34PerKg(Convert.ToDouble(Actions.GetAttributeValue(nucleatedCellsPerKg, "value")), percentCD34);
        }

        /// <summary>
        /// Calculates CD3+/kg.
        /// </summary>
        /// <param name="nucleatedCellsPerKg">Measured in 10^8 cells/kg.</param>
        /// <param name="percentCD3">%CD3+.</param>
        /// <returns>Returns 10^8 CD3+/kg.</returns>
        public double CalculateCD3PerKg(double nucleatedCellsPerKg, double percentCD3)
        {
            Console.WriteLine("Calculating CD3+/kg");
            Console.WriteLine("Taking arguments nucleated cells/kg: " + nucleatedCellsPerKg + " and %CD3+: " + percentCD3);
            return (nucleatedCellsPerKg * percentCD3) / 100;
        }

        public double CalculateCD3PerKg(By nucleatedCellsPerKg, double percentCD3)
        {
            return CalculateCD3PerKg(Convert.ToDouble(Actions.GetAttributeValue(nucleatedCellsPerKg, "value")), percentCD3);
        }

        public void VerifyDataAnalysisUnselectedProcessing()
        {
            if (!Actions.IsSelected(_elementDataAnalysisUnselectedProcessingHPCNotApplicableBox))
            {
                VerifyHPCProductAliquotForUnselectedProcessing();
            }

            if (!Actions.IsSelected(_elementDataAnalysisUnselectedProcessingTCellNotApplicableBox))
            {
                VerifyTCellAliquot();
            }

            if (!Actions.IsSelected(_elementDataAnalysisUnselectedProcessingPreSpinNotApplicableBox))
            {
                VerifyPreSpin();
            }

            if (!Actions.IsSelected(_elementDataAnalysisUnselectedProcessingPostSpinNotApplicableBox))
            {
                VerifyPostSpin();
            }
        }

        //      HPC Product Aliquot for Unselected Processing -----

        public void FillInHPCProductAliquotForUnselectedProcessing(bool notApplicable, string totalVolume, string nucleatedCellCount, string percentCD34, string percentCD3, string CD34Viability)
        {
            CheckOrUncheck(_elementDataAnalysisUnselectedProcessingHPCNotApplicableBox, notApplicable);
            Waits.WaitForPageLoad();

            if (!notApplicable)
            {
                FillFieldAndLoad(_elementDataAnalysisUnselectedProcessingHPCTotalVolume, totalVolume);
                FillFieldAndLoad(_elementDataAnalysisUnselectedProcessingHPCNucleatedCellCount, nucleatedCellCount);
                FillFieldAndLoad(_elementDataAnalysisUnselectedProcessingHPCCD34, percentCD34);
                FillFieldAndLoad(_elementDataAnalysisUnselectedProcessingHPCCD3, percentCD3);
                Actions.SendKeys(_elementDataAnalysisUnselectedProcessingHPCCD34Viability, CD34Viability);
            }

            Console.WriteLine("Filled HPC Product Aliquot for Unselected Processing");
        }

        public void SignHPCProductAliquotForUnselectedProcessing(string username, string password, int reviewerNum = 1)
        {
            string baseStr = "_daupTech" + reviewerNum.ToString() + "Review";
            string signatureID = "sign" + baseStr;
            string doneID = "donelink" + baseStr;

            ClickAndLoad(By.Id(signatureID));
            EnterSignatureInfo(username, password);
            ClickAndLoad(By.Id(doneID));
        }

        public void VerifyHPCProductAliquotForUnselectedProcessing()
        {
            Console.WriteLine("Beginning verification for CD34 Selection - Data Analysis Unselected Processing - HPC Product Aliquot for Unselected Processing");
            string errorMsg = "Expected and actual values do not match";
            double tolerance = 0.005;
            string attributeName = "value";
            string strTotalVolume = Actions.GetAttributeValue(_elementDataAnalysisUnselectedProcessingHPCTotalVolume, attributeName);
            string strNucleatedCellCount = Actions.GetAttributeValue(_elementDataAnalysisUnselectedProcessingHPCNucleatedCellCount, attributeName);

            // If total volume and nucleated cell count fields are non-empty
            if (strTotalVolume != "" && strNucleatedCellCount != "")
            {
                double totalVolume = Convert.ToDouble(strTotalVolume);
                double nucleatedCellCount = Convert.ToDouble(strNucleatedCellCount);
                string strRecipientWeight = Actions.GetAttributeValue(_elementRecipientWeight, attributeName);

                Console.WriteLine("Checking Total Nucleated Cells");
                double totalNucleatedCells = CalculateTotalNucleatedCells(totalVolume, nucleatedCellCount);
                Assert.True(CompareGivenAndCalculated(_elementDataAnalysisUnselectedProcessingHPCTotalNucleatedCells, totalNucleatedCells, tolerance), errorMsg);

                // If recipient weight field is non-empty
                if (strRecipientWeight != "")
                {
                    double recipientWeight = Convert.ToDouble(strRecipientWeight);
                    string strPercentCD34 = Actions.GetAttributeValue(_elementDataAnalysisUnselectedProcessingHPCCD34, attributeName);
                    string strPercentCD3 = Actions.GetAttributeValue(_elementDataAnalysisUnselectedProcessingHPCCD3, attributeName);
                    Console.WriteLine("Checking Nucleated Cells/Kg");
                    double nucleatedCellsPerKg = CalculateNucleatedCellsPerKg(totalNucleatedCells, recipientWeight);
                    Assert.True(CompareGivenAndCalculated(_elementDataAnalysisUnselectedProcessingHPCNucleatedCellsPerKg, nucleatedCellsPerKg, tolerance), errorMsg);

                    // If %CD34+ field is non-empty
                    if (strPercentCD34 != "")
                    {
                        double percentCD34 = Convert.ToDouble(strPercentCD34);

                        Console.WriteLine("Checking CD34+/Kg");
                        double CD34PerKg = CalculateCD34PerKg(nucleatedCellsPerKg, percentCD34);
                        Assert.True(CompareGivenAndCalculated(_elementDataAnalysisUnselectedProcessingHPCCD34, CD34PerKg, tolerance), errorMsg);
                    }

                    // If %CD3 field is non-empty
                    if (strPercentCD3 != "")
                    {
                        double percentCD3 = Convert.ToDouble(strPercentCD3);

                        Console.WriteLine("Checking CD3+/Kg");
                        double CD3PerKg = CalculateCD3PerKg(nucleatedCellsPerKg, percentCD3);
                        Assert.True(CompareGivenAndCalculated(_elementDataAnalysisUnselectedProcessingHPCCD3, CD3PerKg, tolerance), errorMsg);
                    }
                }
            }
        }

        //      T-Cell Aliquot -----

        public void FillInTCellAliquot(bool notApplicable, string aliquotID, string totalVolume, string nucleatedCellCount, string percentCD34, string percentCD3)
        {
            CheckOrUncheck(_elementDataAnalysisUnselectedProcessingTCellNotApplicableBox, notApplicable);
            Waits.WaitForPageLoad();

            if (!notApplicable)
            {
                Actions.SendKeys(_elementDataAnalysisUnselectedProcessingTCellAliquotID, aliquotID);
                FillFieldAndLoad(_elementDataAnalysisUnselectedProcessingTCellTotalVolume, totalVolume);
                FillFieldAndLoad(_elementDataAnalysisUnselectedProcessingTCellNucleatedCellCount, nucleatedCellCount);
                FillFieldAndLoad(_elementDataAnalysisUnselectedProcessingTCellCD34, percentCD34);
                FillFieldAndLoad(_elementDataAnalysisUnselectedProcessingTCellCD3, percentCD3);
            }

            Console.WriteLine("Filled T-Cell Aliquot");
        }

        public void SignTCellAliquot(string username, string password, int reviewerNum = 1)
        {
            string baseStr = "_daupTech" + reviewerNum.ToString() + "ReviewCell";
            string signatureID = "sign" + baseStr;
            string doneID = "donelink" + baseStr;

            ClickAndLoad(By.Id(signatureID));
            EnterSignatureInfo(username, password);
            ClickAndLoad(By.Id(doneID));
        }

        public void VerifyTCellAliquot()
        {
            Console.WriteLine("Beginning verification for CD34 Selection - Data Analysis Unselected Processing - T-Cell Aliquot");
            string errorMsg = "Expected and actual values do not match";
            double tolerance = 0.005;
            string attributeName = "value";
            string strTotalVolume = Actions.GetAttributeValue(_elementDataAnalysisUnselectedProcessingTCellTotalVolume, attributeName);
            string strNucleatedCellCount = Actions.GetAttributeValue(_elementDataAnalysisUnselectedProcessingTCellNucleatedCellCount, attributeName);

            // If total volume and nucleated cell count fields are non-empty
            if (strTotalVolume != "" && strNucleatedCellCount != "")
            {
                double totalVolume = Convert.ToDouble(strTotalVolume);
                double nucleatedCellCount = Convert.ToDouble(strNucleatedCellCount);
                string strRecipientWeight = Actions.GetAttributeValue(_elementRecipientWeight, attributeName);

                Console.WriteLine("Checking Total Nucleated Cells");
                double totalNucleatedCells = CalculateTotalNucleatedCells(totalVolume, nucleatedCellCount);
                Assert.True(CompareGivenAndCalculated(_elementDataAnalysisUnselectedProcessingTCellTotalNucleatedCells, totalNucleatedCells, tolerance), errorMsg);

                // If recipient weight field is non-empty
                if (strRecipientWeight != "")
                {
                    double recipientWeight = Convert.ToDouble(strRecipientWeight);
                    string strPercentCD34 = Actions.GetAttributeValue(_elementDataAnalysisUnselectedProcessingTCellCD34, attributeName);
                    string strPercentCD3 = Actions.GetAttributeValue(_elementDataAnalysisUnselectedProcessingTCellCD3, attributeName);
                    Console.WriteLine("Checking Nucleated Cells/Kg");
                    double nucleatedCellsPerKg = CalculateNucleatedCellsPerKg(totalNucleatedCells, recipientWeight);
                    Assert.True(CompareGivenAndCalculated(_elementDataAnalysisUnselectedProcessingTCellNucleatedCellsPerKg, nucleatedCellsPerKg, tolerance), errorMsg);

                    // If %CD34+ field is non-empty
                    if (strPercentCD34 != "")
                    {
                        double percentCD34 = Convert.ToDouble(strPercentCD34);

                        Console.WriteLine("Checking CD34+/Kg");
                        double CD34PerKg = CalculateCD34PerKg(nucleatedCellsPerKg, percentCD34);
                        Assert.True(CompareGivenAndCalculated(_elementDataAnalysisUnselectedProcessingTCellCD34, CD34PerKg, tolerance), errorMsg);
                    }

                    // If %CD3 field is non-empty
                    if (strPercentCD3 != "")
                    {
                        double percentCD3 = Convert.ToDouble(strPercentCD3);

                        Console.WriteLine("Checking CD3+/Kg");
                        double CD3PerKg = CalculateCD3PerKg(nucleatedCellsPerKg, percentCD3);
                        Assert.True(CompareGivenAndCalculated(_elementDataAnalysisUnselectedProcessingTCellCD3, CD3PerKg, tolerance), errorMsg);
                    }
                }
            }
        }

        //       Pre-Spin (After Removal of T-Cell Aliquots) -----

        public void FillInPreSpin(bool notApplicable, string totalVolume, string nucleatedCellCount, string percentCD34, string percentCD3)
        {
            CheckOrUncheck(_elementDataAnalysisUnselectedProcessingPreSpinNotApplicableBox, notApplicable);
            Waits.WaitForPageLoad();

            if (!notApplicable)
            {
                FillFieldAndLoad(_elementDataAnalysisUnselectedProcessingPreSpinTotalVolume, totalVolume);
                FillFieldAndLoad(_elementDataAnalysisUnselectedProcessingPreSpinNucleatedCellCount, nucleatedCellCount);
                FillFieldAndLoad(_elementDataAnalysisUnselectedProcessingPreSpinCD34, percentCD34);
                FillFieldAndLoad(_elementDataAnalysisUnselectedProcessingPreSpinCD3, percentCD3);
            }

            Console.WriteLine("Filled Pre-Spin (After Removal of T-Cell Aliquots");
        }

        public void SignPreSpin(string username, string password, int reviewerNum = 1)
        {
            string baseStr = "_daupTech" + reviewerNum.ToString() + "ReviewPreSpin";
            string signatureID = "sign" + baseStr;
            string doneID = "donelink" + baseStr;

            ClickAndLoad(By.Id(signatureID));
            EnterSignatureInfo(username, password);
            ClickAndLoad(By.Id(doneID));
        }

        public void VerifyPreSpin()
        {
            Console.WriteLine("Beginning verification for CD34 Selection - Data Analysis Unselected Processing - Pre-Spin (After Removal of T-Cell Aliquots)");
            string errorMsg = "Expected and actual values do not match";
            double tolerance = 0.005;
            string attributeName = "value";
            string strTotalVolume = Actions.GetAttributeValue(_elementDataAnalysisUnselectedProcessingPreSpinTotalVolume, attributeName);
            string strNucleatedCellCount = Actions.GetAttributeValue(_elementDataAnalysisUnselectedProcessingPreSpinNucleatedCellCount, attributeName);

            // If total volume and nucleated cell count fields are non-empty
            if (strTotalVolume != "" && strNucleatedCellCount != "")
            {
                double totalVolume = Convert.ToDouble(strTotalVolume);
                double nucleatedCellCount = Convert.ToDouble(strNucleatedCellCount);
                string strRecipientWeight = Actions.GetAttributeValue(_elementRecipientWeight, attributeName);

                Console.WriteLine("Checking Total Nucleated Cells");
                double totalNucleatedCells = CalculateTotalNucleatedCells(totalVolume, nucleatedCellCount);
                Assert.True(CompareGivenAndCalculated(_elementDataAnalysisUnselectedProcessingPreSpinTotalNucleatedCells, totalNucleatedCells, tolerance), errorMsg);

                // If recipient weight field is non-empty
                if (strRecipientWeight != "")
                {
                    double recipientWeight = Convert.ToDouble(strRecipientWeight);
                    string strPercentCD34 = Actions.GetAttributeValue(_elementDataAnalysisUnselectedProcessingPreSpinCD34, attributeName);
                    string strPercentCD3 = Actions.GetAttributeValue(_elementDataAnalysisUnselectedProcessingPreSpinCD3, attributeName);
                    Console.WriteLine("Checking Nucleated Cells/Kg");
                    double nucleatedCellsPerKg = CalculateNucleatedCellsPerKg(totalNucleatedCells, recipientWeight);
                    Assert.True(CompareGivenAndCalculated(_elementDataAnalysisUnselectedProcessingPreSpinNucleatedCellsPerKg, nucleatedCellsPerKg, tolerance), errorMsg);

                    // If %CD34+ field is non-empty
                    if (strPercentCD34 != "")
                    {
                        double percentCD34 = Convert.ToDouble(strPercentCD34);

                        Console.WriteLine("Checking CD34+/Kg");
                        double CD34PerKg = CalculateCD34PerKg(nucleatedCellsPerKg, percentCD34);
                        Assert.True(CompareGivenAndCalculated(_elementDataAnalysisUnselectedProcessingPreSpinCD34, CD34PerKg, tolerance), errorMsg);
                    }

                    // If %CD3 field is non-empty
                    if (strPercentCD3 != "")
                    {
                        double percentCD3 = Convert.ToDouble(strPercentCD3);

                        Console.WriteLine("Checking CD3+/Kg");
                        double CD3PerKg = CalculateCD3PerKg(nucleatedCellsPerKg, percentCD3);
                        Assert.True(CompareGivenAndCalculated(_elementDataAnalysisUnselectedProcessingPreSpinCD3, CD3PerKg, tolerance), errorMsg);
                    }
                }
            }
        }

        //      Post-Spin -----

        public void FillInPostSpin(bool notApplicable, string aliquotID, string postSpinGrossWeight, string centrifugeID, string RPM, string centrifugeTemp, string grossWt, string bagWt, string nucleatedCellCount, string percentCD34, string percentCD3, string percentRecovery)
        {
            CheckOrUncheck(_elementDataAnalysisUnselectedProcessingPostSpinNotApplicableBox, notApplicable);
            Waits.WaitForPageLoad();

            if (!notApplicable)
            {
                Actions.SendKeys(_elementDataAnalysisUnselectedProcessingPostSpinAliquotID, aliquotID);
                Actions.SendKeys(_elementDataAnalysisUnselectedProcessingPostSpinGrossWeight, postSpinGrossWeight);
                Actions.SendKeys(_elementDataAnalysisUnselectedProcessingPostSpinCentrifugeID, centrifugeID);
                Actions.SendKeys(_elementDataAnalysisUnselectedProcessingPostSpinRPM, RPM);
                Actions.SendKeys(_elementDataAnalysisUnselectedProcessingPostSpinCentrifugeTemp, centrifugeTemp);
                FillFieldAndLoad(_elementDataAnalysisUnselectedProcessingPostSpinGrossWt, grossWt);
                FillFieldAndLoad(_elementDataAnalysisUnselectedProcessingPostSpinBagWt, bagWt);
                FillFieldAndLoad(_elementDataAnalysisUnselectedProcessingPostSpinNucleatedCellCount, nucleatedCellCount);
                FillFieldAndLoad(_elementDataAnalysisUnselectedProcessingPostSpinCD34, percentCD34);
                FillFieldAndLoad(_elementDataAnalysisUnselectedProcessingPostSpinCD3, percentCD3);
                Actions.SendKeys(_elementDataAnalysisUnselectedProcessingPostSpinRecovery, percentRecovery);
            }

            Console.WriteLine("Filled Post-Spin");
        }

        public double CalculatePostSpinTotalVolume(double grossWt, double bagWt)
        {
            return (grossWt - bagWt) / WeirdConstYouShouldProbablyAskAbout;
        }

        public void SignPostSpin(string username, string password, int reviewerNum = 1)
        {
            string baseStr = "_daupTech" + reviewerNum.ToString() + "ReviewPostSpin";
            string signatureID = "sign" + baseStr;
            string doneID = "donelink" + baseStr;

            ClickAndLoad(By.Id(signatureID));
            EnterSignatureInfo(username, password);
            ClickAndLoad(By.Id(doneID));
        }

        public void VerifyPostSpin()
        {
            Console.WriteLine("Beginning verification for CD34 Selection - Data Analysis Unselected Processing - Post-Spin");
            string errorMsg = "Expected and actual values do not match";
            double tolerance = 0.005;
            string attributeName = "value";
            string strGrossWt = Actions.GetAttributeValue(_elementDataAnalysisUnselectedProcessingPostSpinGrossWt, attributeName);
            string strBagWt = Actions.GetAttributeValue(_elementDataAnalysisUnselectedProcessingPostSpinBagWt, attributeName);

            // If Gross Wt and Bag Wt fields are non-empty
            if (strGrossWt != "" && strBagWt != "")
            {
                double grossWt = Convert.ToDouble(strGrossWt);
                double bagWt = Convert.ToDouble(strBagWt);
                string strNucleatedCellCount = Actions.GetAttributeValue(_elementDataAnalysisUnselectedProcessingPostSpinNucleatedCellCount, attributeName);

                Console.WriteLine("Checking Total Volume");
                double totalVolume = CalculatePostSpinTotalVolume(grossWt, bagWt);
                Assert.True(CompareGivenAndCalculated(_elementDataAnalysisUnselectedProcessingPostSpinTotalVolume, totalVolume, tolerance), errorMsg);

                // If Nucleated Cell Count (cells/mL) field is non-empty
                if (strNucleatedCellCount != "")
                {
                    double nucleatedCellCount = Convert.ToDouble(strNucleatedCellCount);
                    string strRecipientWeight = Actions.GetAttributeValue(_elementRecipientWeight, attributeName);

                    Console.WriteLine("Checking Total Nucleated Cells");
                    double totalNucleatedCells = CalculateTotalNucleatedCells(totalVolume, nucleatedCellCount);
                    Assert.True(CompareGivenAndCalculated(_elementDataAnalysisUnselectedProcessingPostSpinTotalNucleatedCells, totalNucleatedCells, tolerance), errorMsg);

                    // If Recipient Weight field is non-empty
                    if (strRecipientWeight != "")
                    {
                        double recipientWeight = Convert.ToDouble(strRecipientWeight);
                        string strPercentCD34 = Actions.GetAttributeValue(_elementDataAnalysisUnselectedProcessingPostSpinCD34, attributeName);
                        string strPercentCD3 = Actions.GetAttributeValue(_elementDataAnalysisUnselectedProcessingPostSpinCD3, attributeName);

                        Console.WriteLine("Checking Nucleated Cells/Kg");
                        double nucleatedCellsPerKg = CalculateNucleatedCellsPerKg(totalNucleatedCells, recipientWeight);
                        Assert.True(CompareGivenAndCalculated(_elementDataAnalysisUnselectedProcessingPostSpinNucleatedCellsPerKg, nucleatedCellsPerKg, tolerance), errorMsg);

                        // If %CD34+ field is non-empty
                        if (strPercentCD34 != "")
                        {
                            double percentCD34 = Convert.ToDouble(strPercentCD34);

                            Console.WriteLine("Checking CD34+/Kg");
                            double CD34PerKg = CalculateCD34PerKg(nucleatedCellsPerKg, percentCD34);
                            Assert.True(CompareGivenAndCalculated(_elementDataAnalysisUnselectedProcessingPostSpinCD34, CD34PerKg, tolerance), errorMsg);
                        }

                        // If %CD3+ field is non-empty
                        if (strPercentCD3 != "")
                        {
                            double percentCD3 = Convert.ToDouble(strPercentCD3);

                            Console.WriteLine("Checking CD3+/Kg");
                            double CD3PerKg = CalculateCD3PerKg(nucleatedCellsPerKg, percentCD3);
                            Assert.True(CompareGivenAndCalculated(_elementDataAnalysisUnselectedProcessingPostSpinCD3, CD3PerKg, tolerance), errorMsg);
                        }
                    }
                }
            }
        }

        //    Data Analysis CD34 Selection =====

        public void ClickOnDataAnalysisCD34Selection()
        {
            Actions.Click(_elementDataAnalysisCD34Selection);
            Console.WriteLine("Clicked on Data Analysis CD34 Selection sub-component");
            Waits.WaitForPageLoad();
        }

        /// <summary>
        /// Calculates percent CD34+ recovery.
        /// </summary>
        /// <param name="CD34PerKgBefore">Measured in 10^6 CD34+/kg.</param>
        /// <param name="CD34PerKgAfter">Measured in 10^6 CD34+/kg.</param>
        /// <returns>Percentage.</returns>
        public double CalculatePercentCD34Recovery(double CD34PerKgBefore, double CD34PerKgAfter)
        {
            return (CD34PerKgAfter / CD34PerKgBefore) * 100;
        }

        //      HPC Product Aliquot for CD34 Selection (before prep/magnetic labeling) -----

        public void FillInHPCBeforePrep(string totalVolume, string nucleatedCellCount, string percentCD34, string percentCD3, string CD34Viability)
        {
            FillFieldAndLoad(_elementDataAnalysisCD34SelectionBeforePrepTotalVolume, totalVolume);
            FillFieldAndLoad(_elementDataAnalysisCD34SelectionBeforePrepNucleatedCellCount, nucleatedCellCount);
            FillFieldAndLoad(_elementDataAnalysisCD34SelectionBeforePrepCD34, percentCD34);
            FillFieldAndLoad(_elementDataAnalysisCD34SelectionBeforePrepCD3, percentCD3);
            Actions.SendKeys(_elementDataAnalysisCD34SelectionBeforePrepCD34Viability, CD34Viability);
            Console.WriteLine("Filled HPC Product Aliquot for CD34 Selection (before prep/magnetic labeling)");
        }

        public void SignHPCBeforePrep(string username, string password, int reviewerNum = 1)
        {
            string signatureID = "sign_dasA" + reviewerNum.ToString() + "Signature";
            string doneID = "doneLink_dasA" + reviewerNum.ToString() + "Signature";

            ClickAndLoad(By.Id(signatureID));
            EnterSignatureInfo(username, password);
            ClickAndLoad(By.Id(doneID));
        }

        /// <summary>
        /// Verifies that values are calculated correctly in HPC Product Aliquot for CD34 Selection (before prep/magnetic labeling) section.
        /// </summary>
        public void VerifyBeforePrep()
        {
            Console.WriteLine("Beginning verification for CD34 Selection - Data Analysis CD34 Selection - HPC Product Aliquot for CD34 Selection (before prep/magnetic labeling)");
            string errorMsg = "Expected and actual values do not match";
            double tolerance = 0.005;
            string attributeName = "value";
            string strTotalVolume = Actions.GetAttributeValue(_elementDataAnalysisCD34SelectionBeforePrepTotalVolume, attributeName);
            string strNucleatedCellCount = Actions.GetAttributeValue(_elementDataAnalysisCD34SelectionBeforePrepNucleatedCellCount, attributeName);

            // If Total Volume and Nucleated Cell Count (cells/mL) fields are non-empty
            if (strTotalVolume != "" && strNucleatedCellCount != "")
            {
                double totalVolume = Convert.ToDouble(strTotalVolume);
                double nucleatedCellCount = Convert.ToDouble(strNucleatedCellCount);
                string strRecipientWeight = Actions.GetAttributeValue(_elementRecipientWeight, attributeName);

                Console.WriteLine("Checking Total Nucleated Cells");
                double totalNucleatedCells = CalculateTotalNucleatedCells(totalVolume, nucleatedCellCount);
                Assert.True(CompareGivenAndCalculated(_elementDataAnalysisCD34SelectionBeforePrepTotalNucleatedCells, totalNucleatedCells, tolerance), errorMsg);

                // If Recipient Weight field is non-empty
                if (strRecipientWeight != "")
                {
                    double recipientWeight = Convert.ToDouble(strRecipientWeight);
                    string strPercentCD34 = Actions.GetAttributeValue(_elementDataAnalysisCD34SelectionBeforePrepCD34, attributeName);
                    string strPercentCD3 = Actions.GetAttributeValue(_elementDataAnalysisCD34SelectionBeforePrepCD3, attributeName);

                    Console.WriteLine("Checking Nucleated Cells/Kg");
                    //double nucleatedCellsPerKg = CalculateNucleatedCellsPerKg(totalNucleatedCells, recipientWeight);
                    double nucleatedCellsPerKg = CalculateNucleatedCellsPerKg(_elementDataAnalysisCD34SelectionBeforePrepTotalNucleatedCells, recipientWeight);
                    Assert.True(CompareGivenAndCalculated(_elementDataAnalysisCD34SelectionBeforePrepNucleatedCellsPerKg, nucleatedCellsPerKg, tolerance), errorMsg);

                    // If %CD34+ field is non-empty
                    if (strPercentCD34 != "")
                    {
                        double percentCD34 = Convert.ToDouble(strPercentCD34);

                        Console.WriteLine("Checking CD34+/Kg");
                        //double CD34PerKg = CalculateCD34PerKg(nucleatedCellsPerKg, percentCD34);
                        double CD34PerKg = CalculateCD34PerKg(_elementDataAnalysisCD34SelectionBeforePrepNucleatedCellsPerKg, percentCD34);
                        Assert.True(CompareGivenAndCalculated(_elementDataAnalysisCD34SelectionBeforePrepCD34PerKg, CD34PerKg, tolerance), errorMsg);
                    }

                    // If %CD3+ field is non-empty
                    if (strPercentCD3 != "")
                    {
                        double percentCD3 = Convert.ToDouble(strPercentCD3);

                        Console.WriteLine("Checking CD3+/Kg");
                        //double CD3PerKg = CalculateCD3PerKg(nucleatedCellsPerKg, percentCD3);
                        double CD3PerKg = CalculateCD3PerKg(_elementDataAnalysisCD34SelectionBeforePrepNucleatedCellsPerKg, percentCD3);
                        Assert.True(CompareGivenAndCalculated(_elementDataAnalysisCD34SelectionBeforePrepCD3PerKg, CD3PerKg, tolerance), errorMsg);
                    }
                }
            }
        }

        //      HPC Product Aliquot for CD34 Selection (after prep/magnetic labeling) -----

        public void FillInHPCAfterPrep(string totalVolume, string nucleatedCellCount, string percentCD34, string percentCD3, string CD34Viability)
        {
            FillFieldAndLoad(_elementDataAnalysisCD34SelectionAfterPrepTotalVolume, totalVolume);
            FillFieldAndLoad(_elementDataAnalysisCD34SelectionAfterPrepNucleatedCellCount, nucleatedCellCount);
            FillFieldAndLoad(_elementDataAnalysisCD34SelectionAfterPrepCD34, percentCD34);
            FillFieldAndLoad(_elementDataAnalysisCD34SelectionAfterPrepCD3, percentCD3);
            Actions.SendKeys(_elementDataAnalysisCD34SelectionAfterPrepCD34Viability, CD34Viability);
            Console.WriteLine("Filled HPC Product Aliquot for CD34 Selection (after prep/magnetic labeling)");
        }

        public void SignHPCAfterePrep(string username, string password, int reviewerNum = 1)
        {
            string signatureID = "sign_dasB" + reviewerNum.ToString() + "Signature";
            string doneID = "doneLink_dasB" + reviewerNum.ToString() + "Signature";

            ClickAndLoad(By.Id(signatureID));
            EnterSignatureInfo(username, password);
            ClickAndLoad(By.Id(doneID));
        }

        public void VerifyAfterPrep()
        {
            Console.WriteLine("Beginning verification for CD34 Selection - Data Analysis CD34 Selection - HPC Product Aliquot for CD34 Selection (after prep/magnetic labeling)");
            string errorMsg = "Expected and actual values do not match";
            double tolerance = 0.005;
            string attributeName = "value";
            string strTotalVolume = Actions.GetAttributeValue(_elementDataAnalysisCD34SelectionAfterPrepTotalVolume, attributeName);
            string strNucleatedCellCount = Actions.GetAttributeValue(_elementDataAnalysisCD34SelectionAfterPrepNucleatedCellCount, attributeName);

            // If Total Volume and Nucleated Cell Count (cells/mL) fields are non-empty
            if (strTotalVolume != "" && strNucleatedCellCount != "")
            {
                double totalVolume = Convert.ToDouble(strTotalVolume);
                double nucleatedCellCount = Convert.ToDouble(strNucleatedCellCount);
                string strRecipientWeight = Actions.GetAttributeValue(_elementRecipientWeight, attributeName);

                Console.WriteLine("Checking Total Nucleated Cells");
                double totalNucleatedCells = CalculateTotalNucleatedCells(totalVolume, nucleatedCellCount);
                Assert.True(CompareGivenAndCalculated(_elementDataAnalysisCD34SelectionAfterPrepTotalNucleatedCells, totalNucleatedCells, tolerance), errorMsg);

                // If Recipient Weight field is non-empty
                if (strRecipientWeight != "")
                {
                    double recipientWeight = Convert.ToDouble(strRecipientWeight);
                    string strPercentCD34 = Actions.GetAttributeValue(_elementDataAnalysisCD34SelectionAfterPrepCD34, attributeName);
                    string strPercentCD3 = Actions.GetAttributeValue(_elementDataAnalysisCD34SelectionAfterPrepCD3, attributeName);

                    Console.WriteLine("Checking Nucleated Cells/Kg");
                    //double nucleatedCellsPerKg = CalculateNucleatedCellsPerKg(totalNucleatedCells, recipientWeight);
                    double nucleatedCellsPerKg = CalculateNucleatedCellsPerKg(_elementDataAnalysisCD34SelectionAfterPrepTotalNucleatedCells, recipientWeight);
                    Assert.True(CompareGivenAndCalculated(_elementDataAnalysisCD34SelectionAfterPrepNucleatedCellsPerKg, nucleatedCellsPerKg, tolerance), errorMsg);

                    // If %CD34+ field is non-empty
                    if (strPercentCD34 != "")
                    {
                        double percentCD34 = Convert.ToDouble(strPercentCD34);
                        string strCD34PerKgBeforePrep = Actions.GetAttributeValue(_elementDataAnalysisCD34SelectionBeforePrepCD34PerKg, attributeName);

                        Console.WriteLine("Checking CD34+/Kg");
                        //double CD34PerKg = CalculateCD34PerKg(nucleatedCellsPerKg, percentCD34);
                        double CD34PerKg = CalculateCD34PerKg(_elementDataAnalysisCD34SelectionAfterPrepNucleatedCellsPerKg, percentCD34);
                        Assert.True(CompareGivenAndCalculated(_elementDataAnalysisCD34SelectionAfterPrepCD34PerKg, CD34PerKg, tolerance), errorMsg);

                        // If %CD34+ field in HPC Product Aliquot for CD34 Selection (before prep/magnetic labeling) is non-empty
                        if (strCD34PerKgBeforePrep != "")
                        {
                            double CD34PerKgBeforePrep = Convert.ToDouble(strCD34PerKgBeforePrep);

                            Console.WriteLine("Checking %CD34+ Recovery");
                            tolerance = 0.05;
                            //double percentCD34Recovery = CalculatePercentCD34Recovery(CD34PerKgBeforePrep, CD34PerKg);
                            double percentCD34Recovery = CalculatePercentCD34Recovery(CD34PerKgBeforePrep, Convert.ToDouble(Actions.GetAttributeValue(_elementDataAnalysisCD34SelectionAfterPrepCD34PerKg, attributeName)));
                            Assert.True(CompareGivenAndCalculated(_elementDataAnalysisCD34SelectionAfterPrepCD34Recovery, percentCD34Recovery, tolerance), errorMsg);
                        }
                    }

                    // If %CD3+ field is non-empty
                    if (strPercentCD3 != "")
                    {
                        double percentCD3 = Convert.ToDouble(strPercentCD3);

                        Console.WriteLine("Checking CD3+/Kg");
                        //double CD3PerKg = CalculateCD3PerKg(nucleatedCellsPerKg, percentCD3);
                        double CD3PerKg = CalculateCD3PerKg(_elementDataAnalysisCD34SelectionAfterPrepNucleatedCellsPerKg, percentCD3);
                        Assert.True(CompareGivenAndCalculated(_elementDataAnalysisCD34SelectionAfterPrepCD3PerKg, CD3PerKg, tolerance), errorMsg);
                    }
                }
            }
        }

        //      CD34 Selected Positive Fraction (Cell Collection Bag) -----

        public void FillInCD34SelectedPositiveFraction(string aliquodID, string totalVolume, string nucleatedCellCount, string percentCD34, string percentCD3, string CD34Viability)
        {
            Actions.SendKeys(_elementDataAnalysisCD34SelectionPosFracAliquotID, aliquodID);
            FillFieldAndLoad(_elementDataAnalysisCD34SelectionPosFracTotalVolume, totalVolume);
            FillFieldAndLoad(_elementDataAnalysisCD34SelectionPosFracNucleatedCellCount, nucleatedCellCount);
            FillFieldAndLoad(_elementDataAnalysisCD34SelectionPosFracCD34, percentCD34);
            FillFieldAndLoad(_elementDataAnalysisCD34SelectionPosFracCD3, percentCD3);
            Actions.SendKeys(_elementDataAnalysisCD34SelectionPosFracCD34Viability, CD34Viability);
            Console.WriteLine("Filled CD34 Selected Positive Fraction (Cell Collection Bag)");
        }

        /// <summary>
        /// Calculates total nucleated cells.
        /// </summary>
        /// <param name="totalVolume">Measured in mL.</param>
        /// <param name="nucleatedCellCount">Measured in 10^6 cells/mL.</param>
        /// <returns>Measured in 10^10 cells.</returns>
        public double CalculatePositiveFractionTotalNucleatedCells(double totalVolume, double nucleatedCellCount)
        {
            return CalculateTotalNucleatedCells(totalVolume, nucleatedCellCount) / 100;
        }

        public void SignPositiveFraction(string username, string password, int reviewerNum = 1)
        {
            string signatureID = "sign_dasC" + reviewerNum.ToString() + "Signature";
            string doneID = "doneLink_dasC" + reviewerNum.ToString() + "Signature";

            ClickAndLoad(By.Id(signatureID));
            EnterSignatureInfo(username, password);
            ClickAndLoad(By.Id(doneID));
        }

        public void VerifyPositiveFraction()
        {
            Console.WriteLine("Beginning verification for CD34 Selection - Data Analysis CD34 Selection - HPC Product Aliquot for CD34 Selection (after prep/magnetic labeling)");
            string errorMsg = "Expected and actual values do not match";
            double tolerance = 0.005;
            string attributeName = "value";
            string strTotalVolume = Actions.GetAttributeValue(_elementDataAnalysisCD34SelectionPosFracTotalVolume, attributeName);
            string strNucleatedCellCount = Actions.GetAttributeValue(_elementDataAnalysisCD34SelectionPosFracNucleatedCellCount, attributeName);

            // If Total Volume and Nucleated Cell Count (cells/mL) fields are non-empty
            if (strTotalVolume != "" && strNucleatedCellCount != "")
            {
                double totalVolume = Convert.ToDouble(strTotalVolume);
                double nucleatedCellCount = Convert.ToDouble(strNucleatedCellCount);
                string strRecipientWeight = Actions.GetAttributeValue(_elementRecipientWeight, attributeName);

                Console.WriteLine("Checking Total Nucleated Cells");
                double totalNucleatedCells = CalculatePositiveFractionTotalNucleatedCells(totalVolume, nucleatedCellCount);
                Assert.True(CompareGivenAndCalculated(_elementDataAnalysisCD34SelectionPosFracTotalNucleatedCells, totalNucleatedCells, tolerance), errorMsg);

                // If Recipient Weight field is non-empty
                if (strRecipientWeight != "")
                {
                    double recipientWeight = Convert.ToDouble(strRecipientWeight);
                    string strPercentCD34 = Actions.GetAttributeValue(_elementDataAnalysisCD34SelectionPosFracCD34, attributeName);
                    string strPercentCD3 = Actions.GetAttributeValue(_elementDataAnalysisCD34SelectionPosFracCD3, attributeName);

                    Console.WriteLine("Checking Nucleated Cells/Kg");
                    //double nucleatedCellsPerKg = CalculateNucleatedCellsPerKg(totalNucleatedCells, recipientWeight);
                    double nucleatedCellsPerKg = CalculateNucleatedCellsPerKg(_elementDataAnalysisCD34SelectionPosFracTotalNucleatedCells, recipientWeight);
                    Assert.True(CompareGivenAndCalculated(_elementDataAnalysisCD34SelectionPosFracNucleatedCellsPerKg, nucleatedCellsPerKg, tolerance), errorMsg);

                    // If %CD34+ field is non-empty
                    if (strPercentCD34 != "")
                    {
                        double percentCD34 = Convert.ToDouble(strPercentCD34);
                        string strCD34PerKgAfterPrep = Actions.GetAttributeValue(_elementDataAnalysisCD34SelectionAfterPrepCD34PerKg, attributeName);

                        Console.WriteLine("Checking CD34+/Kg");
                        //double CD34PerKg = CalculateCD34PerKg(nucleatedCellsPerKg, percentCD34);
                        double CD34PerKg = CalculateCD34PerKg(_elementDataAnalysisCD34SelectionPosFracNucleatedCellsPerKg, percentCD34);
                        Assert.True(CompareGivenAndCalculated(_elementDataAnalysisCD34SelectionPosFracCD34PerKg, CD34PerKg, tolerance), errorMsg);

                        // If CD34+/kg field for HPC Product Aliquot for CD34 Selection (after prep/magnetic labeling) is non-empty
                        if (strCD34PerKgAfterPrep != "")
                        {
                            double CD34PerKgAfterPrep = Convert.ToDouble(strCD34PerKgAfterPrep);

                            Console.WriteLine("Checking %CD34+ Recovery");
                            tolerance = 0.05;
                            //double percentCD34Recovery = CalculatePercentCD34Recovery(CD34PerKgAfterPrep, CD34PerKg);
                            double percentCD34Recovery = CalculatePercentCD34Recovery(CD34PerKgAfterPrep, Convert.ToDouble(Actions.GetAttributeValue(_elementDataAnalysisCD34SelectionPosFracCD34PerKg, attributeName)));
                            Assert.True(CompareGivenAndCalculated(_elementDataAnalysisCD34SelectionPosFracCD34Recovery, percentCD34Recovery, tolerance), errorMsg);
                        }
                    }

                    // If %CD3+ field is non-empty
                    if (strPercentCD3 != "")
                    {
                        double percentCD3 = Convert.ToDouble(strPercentCD3);

                        Console.WriteLine("Checking CD3+/Kg");
                        //double CD3PerKg = CalculateCD3PerKg(nucleatedCellsPerKg, percentCD3);
                        double CD3PerKg = CalculateCD3PerKg(_elementDataAnalysisCD34SelectionPosFracNucleatedCellsPerKg, percentCD3);
                        Assert.True(CompareGivenAndCalculated(_elementDataAnalysisCD34SelectionPosFracCD3PerKg, CD3PerKg, tolerance), errorMsg);
                    }
                }
            }
        }

        //      CD34 Selected Negative Fraction (Negative Fraction Bag) -----

        public void FillInCD34SelectedNegativeFraction(string totalVolume, string nucleatedCellCount, string percentCD34, string percentCD3, string CD34Viability)
        {
            FillFieldAndLoad(_elementDataAnalysisCD34SelectionNegFracTotalVolume, totalVolume);
            FillFieldAndLoad(_elementDataAnalysisCD34SelectionNegFracNucleatedCellCount, nucleatedCellCount);
            FillFieldAndLoad(_elementDataAnalysisCD34SelectionNegFracCD34, percentCD34);
            FillFieldAndLoad(_elementDataAnalysisCD34SelectionNegFracCD3, percentCD3);
            Actions.SendKeys(_elementDataAnalysisCD34SelectionNegFracCD34Viability, CD34Viability);
            Console.WriteLine("Filled CD34 Selected Negative Fraction (Cell Collection Bag)");
        }

        public void SignNegativeFraction(string username, string password, int reviewerNum = 1)
        {
            string signatureID = "sign_dasD" + reviewerNum.ToString() + "Signature";
            string doneID = "doneLink_dasD" + reviewerNum.ToString() + "Signature";

            ClickAndLoad(By.Id(signatureID));
            EnterSignatureInfo(username, password);
            ClickAndLoad(By.Id(doneID));
        }

        public void VerifyNegativeFraction()
        {
            Console.WriteLine("Beginning verification for CD34 Selection - Data Analysis CD34 Selection - HPC Product Aliquot for CD34 Selection (before prep/magnetic labeling)");
            string errorMsg = "Expected and actual values do not match";
            double tolerance = 0.005;
            string attributeName = "value";
            string strTotalVolume = Actions.GetAttributeValue(_elementDataAnalysisCD34SelectionNegFracTotalVolume, attributeName);
            string strNucleatedCellCount = Actions.GetAttributeValue(_elementDataAnalysisCD34SelectionNegFracNucleatedCellCount, attributeName);

            // If Total Volume and Nucleated Cell Count (cells/mL) fields are non-empty
            if (strTotalVolume != "" && strNucleatedCellCount != "")
            {
                double totalVolume = Convert.ToDouble(strTotalVolume);
                double nucleatedCellCount = Convert.ToDouble(strNucleatedCellCount);
                string strRecipientWeight = Actions.GetAttributeValue(_elementRecipientWeight, attributeName);

                Console.WriteLine("Checking Total Nucleated Cells");
                double totalNucleatedCells = CalculateTotalNucleatedCells(totalVolume, nucleatedCellCount);
                Assert.True(CompareGivenAndCalculated(_elementDataAnalysisCD34SelectionNegFracTotalNucleatedCells, totalNucleatedCells, tolerance), errorMsg);

                // If Recipient Weight field is non-empty
                if (strRecipientWeight != "")
                {
                    double recipientWeight = Convert.ToDouble(strRecipientWeight);
                    string strPercentCD34 = Actions.GetAttributeValue(_elementDataAnalysisCD34SelectionNegFracCD34, attributeName);
                    string strPercentCD3 = Actions.GetAttributeValue(_elementDataAnalysisCD34SelectionNegFracCD3, attributeName);

                    Console.WriteLine("Checking Nucleated Cells/Kg");
                    //double nucleatedCellsPerKg = CalculateNucleatedCellsPerKg(totalNucleatedCells, recipientWeight);
                    double nucleatedCellsPerKg = CalculateNucleatedCellsPerKg(_elementDataAnalysisCD34SelectionNegFracTotalNucleatedCells, recipientWeight);
                    Assert.True(CompareGivenAndCalculated(_elementDataAnalysisCD34SelectionNegFracNucleatedCellsPerKg, nucleatedCellsPerKg, tolerance), errorMsg);

                    // If %CD34+ field is non-empty
                    if (strPercentCD34 != "")
                    {
                        double percentCD34 = Convert.ToDouble(strPercentCD34);

                        Console.WriteLine("Checking CD34+/Kg");
                        //double CD34PerKg = CalculateCD34PerKg(nucleatedCellsPerKg, percentCD34);
                        double CD34PerKg = CalculateCD34PerKg(_elementDataAnalysisCD34SelectionNegFracNucleatedCellsPerKg, percentCD34);
                        Assert.True(CompareGivenAndCalculated(_elementDataAnalysisCD34SelectionNegFracCD34PerKg, CD34PerKg, tolerance), errorMsg);
                    }

                    // If %CD3+ field is non-empty
                    if (strPercentCD3 != "")
                    {
                        double percentCD3 = Convert.ToDouble(strPercentCD3);

                        Console.WriteLine("Checking CD3+/Kg");
                        //double CD3PerKg = CalculateCD3PerKg(nucleatedCellsPerKg, percentCD3);
                        double CD3PerKg = CalculateCD3PerKg(_elementDataAnalysisCD34SelectionNegFracNucleatedCellsPerKg, percentCD3);
                        Assert.True(CompareGivenAndCalculated(_elementDataAnalysisCD34SelectionNegFracCD3PerKg, CD3PerKg, tolerance), errorMsg);
                    }
                }
            }
        }
        //This section is for the reference table
        public void SelectFromCellViabilityDDL(string selection)
        {
            Console.WriteLine(selection + " ----------------------------");
            Actions.SelectByVisibleText(_elementViabilityMethod, selection);
            Console.WriteLine(selection + " is selected from from Cell Viability DDL");
        }

        //This section is for the print processing labels
        public void ClickOnLabelBtn()
        {
            ClickAndLoad(_elementLabelBtn);
            Console.WriteLine("Print processing Labels pop up menu is open");
        }

        //this method is usded to fill out the pop window to print processing label
        public void FillOutPrintProcessingLabelPopUp()
        {
            Actions.SelectByVisibleText(_elementLabelPrinterDDL, "Lenexa GX430t");
            Console.WriteLine("Lenexa GX430t is selected for the Printer drop down");
            Actions.SelectByRandoxIndex(_elementLabelTypeDDL);
            Console.WriteLine(Actions.GetAttributeValue(_elementLabelTypeDDL, "values") + " is selected on Label Type DDL");
            Actions.SelectByRandoxIndex(_elementLabelSpecialMessageDDL);
            Console.WriteLine(Actions.GetAttributeValue(_elementLabelSpecialMessageDDL, "values") + " is selected on Special Message DDL");
            Random ran = new Random();
            int randomNumber = (ran.Next(1, 100));
            if (randomNumber % 2 == 0)
            {
                Actions.Clear(_elementNumberPrintedTextbox);
                Actions.SendKeys(_elementNumberPrintedTextbox, "1");
                Console.WriteLine("1 label will be print");
            }
            else
            {
                Actions.Clear(_elementNumberPrintedTextbox);
                Actions.SendKeys(_elementNumberPrintedTextbox, "2");
                Console.WriteLine("2 labels will be print");
            }

            ClickAndLoad(_elementLabelPrintBtn);
            Console.WriteLine("Label is printed");
        }
    }
}
