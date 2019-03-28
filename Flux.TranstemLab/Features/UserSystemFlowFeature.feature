Feature: User System Flow

@mytag
Scenario Outline: User System Flow
	Given I navigate to TranstemLab application
	Then I should be navigated to TranstemLab home page
	Then I click on Recipients Link 
	Then I click on Add Recipient button from Recipient Search Page
	Then I enter <Recipient ID> <First Name> <Last Name> <Medical Record> <CRID> <Registry ID> <Birth Date> Gender Ethnicity and Client Status in the page
	Then I click on Save button from page
	And  I Click on Add a transplant event for patient from RecipientDetail page
	Then I enter value for all fields in Add Transplant Event page
	Then I click on Save button form Add Tranplant Event Page
	And  I record recipient information
	Then go to home page from Recipient page
	And I start to do a Donor search
	Then I enter donor information and select that Donor
	And  I start to Add collection
	Then I click on Add collection Event link from the Donor Detail page and fill out the required fields 
	Then  I click on Save button
	And  I record the system generated donor ID
	Then I Start to Add a Product from Donor home page
	Then I click on the Product link to add a new product
	And I select radio button to enter system generated donor ID and enter the ID
	And I click on the Load Donor ID and check the patient information
	Then I click on the sync button
	And I click on the radio button to select donor and press enter key in the keyboard
	Then I click on Create Collection Event button
	And  I note down the Product ID
	And I click on the Create Product
	Then go to home page from Add New Product page
	And I start to do a Recipient search
	And I enter Recipient Last Name
	Then I click on Search button on the Recipient Search page
	And  I verify the recipient information
	And  I edit the transplant event to add product
	Then go to home page from Recipient page
	Then  I click on Product Link and select Batch Processing to Search page
    And   I click on Add Batch button to Add Batch page
    And   I select Cell Processing v1 20111 from the drop down list
    And   I click on Search button in the Add Batch page
	Then  I select the Product ID that was created
	And   I click on the check box of the newly created product
	Then  I select a Technologist from Technologist Name drop down
	And   I click on Save button to save the Processing Procedure
	Then  I click on Product List and navigate to Processing page
	And   I get the product ID from product home page
    Then  I click on the parent title arrow
	And I verify the patient is in the drop down list
	Then I click on Storage
	Then I click on Unit Storage
	Then I fill out the unit storage information
	Then I click Save
	And I verify that the storage action saves
	Then I click on Storage
	Then I click on Sample Storage
	Then I fill out the sample storage information
	Then I click on Create Sample
	Then I click on Storage
	Then I click on Folder Tracking
	Then I fill out details in Folder Tracking
	Then I click Save
	Then I click on Processing
	Then I click on Processing Step 1
	And I fill in <Product Gross Weight>, <Bag Tare Weight>, <Total Volume> and <Nucleated Cell Count PP> to First Processing Step
	And I verify the information in the First processing Step and sign in as Tech
	Then I click Save
	Then I click on Processing Step two
	And I fill in <Total Volume>, <Nucleated Cell Count>, <%CD34+> and <%CD3+> to Second Processing Step
	And I verify the information in the Second processing Step and sign in as Tech
	Then I click on Label Verification to open Label Verification page
	And I fill in the details in the Label Verification page
	Then I sign all three signatures in Label Verification page
	Then I click Save
	And I click on RBC Depletion tab on the side
	Then I click on HES-1 to open HES-1 page
	And I fill in <Total Volume> <Nucleated Cell Count> <HCT%> <RBC Volume> and verify <Total Nucleated Cells> in the first section
	And I fill in details in third section
	And I fill in <Total Volume> and verify <Hetastarch> in the third section
	And I fill in <Plasmalyte> <Total Volume> and <Hetastarch>  in the fourth section and verify the total volume
	And I fill in <Pre HES-1 Sedimentation Volume>, <Pre HES-1 Sedimentation NC>, <Pre HES-1 Sedimentation TNC>, <Pre HES-1 Sedimentation HCT>, <Pre HES-1 Sedimentation RBC>, <Post HES-1 Sedimentation Volume>, <Post HES-1 Sedimentation NC>, <Post HES-1 Sedimentation TNC>, <Post HES-1 Sedimentation HCT>, <Post HES-1 Sedimentation RBC>, <Post HES-1 Removal Volume>, <Post HES-1 Removal NC>, <Post HES-1 Removal TNC>, <Post HES-1 Removal HCT> and <Post HES-1 Removal RBC> to the table in the fifth section
	And I verify the table in the fifth section with <Total Volume>, <Nucleated Cell Count>, <Total Nucleated Cells>, <HCT%>, <RBC Volume>, <Pre HES-1 Sedimentation TNC Recovery>, <Post HES-1 Sedimentation TNC Recovery> and <Post HES-1 Removal TNC Recovery>
	Then I click Save
	And I click on Cryopreservation tab on the side
	Then I fill in the details in Cryopreservation page
	Then I sign all two signatures in Cryopreservation page
	Then I click Save
	And I click on Receipt tab on the side
	Then I click on Receipt Details tab to open Receipt Details page
	And I fill in the details in the Receipt Details
	Then I click Save
	Then I click on Label Review tab to open Label Review page
	And I fill in the details in the Label Review page
	Then I click Save
	Then I click on Other Facility to Open Other Facility page
	And I fill the details in the Other Facility page
	And I click on Reviewer 1 
	Then I sign in with credential
	And I click done on Other Facility page
	Then I click Save
	Then I click on Processing Review tab to open Processing Review page
	And I sign the Processing Review #1 in the Processing Review page
	Then I click Save
	Then I click on ABO/Rh Check tab to open ABO/Rh Check page
	And I fill in the details in the ABO/Rh Check page
	And I click on Reviewer check mark to sign
	Then I sign in with credential
	And I click done on ABO/Rh Check page
	Then I click Save
	Then I click on the Sampling to open Sampling page
	And I fill in the details in the Sampling page
	Then I click Save
	Then I navigate to CD34+ Section A
	And I fill in Transfer of Leukapheresis Product into Cell Preparation Bag section with <Leukapheresis Transfer into Cell Bag Start Time>, <Remove Sample for Testing>, <Weight of Bag with Leukapheresis>, <Weight of Empty Bag>, <A4 Reduced NA>, <Weight of Leukapheresis after Reduction>
	And I fill in Diluting Leukapheresis Product section with <Actual Dilution Buffer Added>, <Bag Weight after Adding Dilution Buffer>
	And I fill in Centrifugation Conditions with <Centrifuge ID>, <Centrifugation Time>, <Centrifugation Speed>, <Target Final Volume is 95g>
	And I fill in Calculate the Amount of Supernatant to be Removed to give a Final Volume section with <Actual Amount of Supernatant Removed>, <Total Weight of Bag after Complete Dilution>
	Then I verify Section A using <Weight of Bag with Leukapheresis>, <Weight of Empty Bag>, <Weight of Leukapheresis after Reduction>, <Bag Weight after Adding Dilution Buffer>
	Then I navigate to CD34+ Section B
	And I fill in Magnetic Labeling of CD34 Positive Cells with <CD34 Reagent ID>, <Second CD34 Reagent ID>
	And I fill in Incubation with <Incubation Start Time>, <Air Injection>, <Placed on Rotator>, <Rotator Comment>, <Incubation Stop Time>
	And I fill in Wash Number One with <Wash 1 Amount of Buffer Transferred into Bag>, <Wash 1 Centrifuge ID>, <Wash 1 Centrifugation Time>, <Wash 1 Centrifugation Speed>, <Wash 1 Amount of Supernatant Removed>
	And I fill in Wash Number Two with <Wash 2 Amount of Buffer Transferred into Bag>, <Wash 2 Centrifuge ID>, <Wash 2 Centrifugation Time>, <Wash 2 Centrifugation Speed>, <Wash 2 Amount of Supernatant Removed>, <Weight of Bag after Washing>
	And I fill in Final Sample Preparation with <Volume Adjustment is Normal>, <Remove Product Sample for Analysis>, <Weight of Cell Preparation Bag after Buffer Addition>
	And I verify Section B using <Weight of Empty Bag>
	Then I navigate to CD34+ Section C
	And I fill in CliniMACS Separation (Run) with <CliniMACS Separation Date Started>, <CliniMACS Separation Time Started>, <CliniMACS Separation Date Ended>, <CliniMACS Separation Time Ended>, <Tubing Set Reagent ID>
	And I fill in Calculate the Amount of Positive Fraction with <Weight of Cell Collection Bag after Run>, <Weight of Empty Cell Collection Bag>, <Process Code>
	And I verify Section C
	Then I navigate to Data Analysis Unselected Processing
	And I fill in HPC Product Aliquot for Unselected Processing with <HPC Not Applicable>, <HPC Total Volume>, <HPC Nucleated Cell Count>, <HPC Percent CD34 Positive>, <HPC Percent CD3 Positive>, <HPC CD34 Viability>
	And I fill in T-Cell Aliquot with <T-Cell Not Applicable>, <T-Cell Aliquot ID>, <T-Cell Total Volume>, <T-Cell Nucleated Cell Count>, <T-Cell Percent CD34 Positive>, <T-Cell Percent CD3 Positive>
	And I fill in Pre-Spin (After Removal of T-Cell Aliquots) with <Pre-Spin Not Applicable>, <Pre-Spin Total Volume>, <Pre-Spin Nucleated Cell Count>, <Pre-Spin Percent CD34 Positive>, <Pre-Spin Percent CD3 Positive>
	And I fill in Post-Spin with <Post-Spin Not Applicable>, <Post-Spin Aliquot ID>, <Post-Spin Gross Weight>, <Post-Spin Centrifuge ID>, <Post-Spin RPMs>, <Post-Spin Centrifuge Temperature>, <Post-Spin Gross Wt>, <Post-Spin Bag Wt>, <Post-Spin Nucleated Cell Count>, <Post-Spin Percent CD34 Positive>, <Post-Spin Percent CD3 Positive>, <Post-Spin Percent Recovery>
	And I verify Data Analysis Unselected Processing
	Then I navigate to Data Analysis CD34 Selection
	And I fill in HPC Product Aliquot for CD34 Selection (Before Prep/Magnetic Labeling) with <HPC Before Prep Total Volume>, <HPC Before Prep Nucleated Cell Count>, <HPC Before Prep Percent CD34 Positve>, <HPC Before Prep Percent CD3 Positive>, <HPC Before Prep CD34 Viability>
	And I fill in HPC Product Aliquot for CD34 Selection (After Prep/Magnetic Labeling) with <HPC After Prep Total Volume>, <HPC After Prep Nucleated Cell Count>, <HPC After Prep Percent CD34 Positve>, <HPC After Prep Percent CD3 Positive>, <HPC After Prep CD34 Viability>
	And I fill in CD34 Selected Positive Fraction (Cell Collection Bag) with <CD34 Positive Fraction Aliquot ID>, <CD34 Positive Fraction Total Volume>, <CD34 Positive Fraction Nucleated Cell Count>, <CD34 Positive Fraction Percent CD34 Positve>, <CD34 Positive Fraction Percent CD3 Positive>, <CD34 Positive Fraction CD34 Viability>
	And I fill in CD34 Selected Negative Fraction (Negative Fraction Bag) with <CD34 Negative Fraction Total Volume>, <CD34 Negative Fraction Nucleated Cell Count>, <CD34 Negative Fraction Percent CD34 Positve>, <CD34 Negative Fraction Percent CD3 Positive>, <CD34 Negative Fraction CD34 Viability>
	And I verify the calculations in Data Analysis CD34 Selection
	Then I click LogOutLink 
	And I should be navigated to TranstemLab login page
	And I Log Out

    Examples: Recipient
    | Recipient ID | First Name | Last Name | Medical Record | CRID | Registry ID | Birth Date | Total Volume | Nucleated Cell Count | HCT% | RBC Volume | Plasmalyte | Total Nucleated Cells | Hetastarch | Pre HES-1 Sedimentation Volume | Pre HES-1 Sedimentation NC | Pre HES-1 Sedimentation TNC | Pre HES-1 Sedimentation HCT | Pre HES-1 Sedimentation RBC | Post HES-1 Sedimentation Volume | Post HES-1 Sedimentation NC | Post HES-1 Sedimentation TNC | Post HES-1 Sedimentation HCT | Post HES-1 Sedimentation RBC | Post HES-1 Removal Volume | Post HES-1 Removal NC | Post HES-1 Removal TNC | Post HES-1 Removal HCT | Post HES-1 Removal RBC | Pre HES-1 Sedimentation TNC Recovery | Post HES-1 Sedimentation TNC Recovery | Post HES-1 Removal TNC Recovery | Product Gross Weight | Bag Tare Weight | Nucleated Cell Count PP | %CD34+ | %CD3+ | Leukapheresis Transfer into Cell Bag Start Date | Leukapheresis Transfer into Cell Bag Start Time | Remove Sample for Testing | Weight of Bag with Leukapheresis | Weight of Empty Bag | A4 Reduced NA | Weight of Leukapheresis after Reduction | Actual Dilution Buffer Added | Bag Weight after Adding Dilution Buffer | Centrifuge ID | Centrifugation Time | Centrifugation Speed | Target Final Volume is 95g | Actual Amount of Supernatant Removed | Total Weight of Bag after Complete Dilution | CD34 Reagent ID | Second CD34 Reagent ID | Incubation Start Time | Air Injection | Placed on Rotator | Rotator Comment | Incubation Stop Time | Wash 1 Amount of Buffer Transferred into Bag | Wash 1 Centrifuge ID | Wash 1 Centrifugation Time | Wash 1 Centrifugation Speed | Wash 1 Amount of Supernatant Removed | Wash 2 Amount of Buffer Transferred into Bag | Wash 2 Centrifuge ID | Wash 2 Centrifugation Time | Wash 2 Centrifugation Speed | Wash 2 Amount of Supernatant Removed | Weight of Bag after Washing | Volume Adjustment is Normal | Remove Product Sample for Analysis | Weight of Cell Preparation Bag after Buffer Addition | CliniMACS Separation Date Started | CliniMACS Separation Time Started | CliniMACS Separation Date Ended | CliniMACS Separation Time Ended | Tubing Set Reagent ID | Weight of Cell Collection Bag after Run | Weight of Empty Cell Collection Bag | Process Code    | HPC Not Applicable | HPC Total Volume | HPC Nucleated Cell Count | HPC Percent CD34 Positive | HPC Percent CD3 Positive | HPC CD34 Viability | T-Cell Not Applicable | T-Cell Aliquot ID | T-Cell Total Volume | T-Cell Nucleated Cell Count | T-Cell Percent CD34 Positive | T-Cell Percent CD3 Positive | Pre-Spin Not Applicable | Pre-Spin Total Volume | Pre-Spin Nucleated Cell Count | Pre-Spin Percent CD34 Positive | Pre-Spin Percent CD3 Positive | Post-Spin Not Applicable | Post-Spin Aliquot ID | Post-Spin Gross Weight | Post-Spin Centrifuge ID | Post-Spin RPMs | Post-Spin Centrifuge Temperature | Post-Spin Gross Wt | Post-Spin Bag Wt | Post-Spin Nucleated Cell Count | Post-Spin Percent CD34 Positive | Post-Spin Percent CD3 Positive | Post-Spin Percent Recovery | HPC Before Prep Total Volume | HPC Before Prep Nucleated Cell Count | HPC Before Prep Percent CD34 Positve | HPC Before Prep Percent CD3 Positive | HPC Before Prep CD34 Viability | HPC After Prep Total Volume | HPC After Prep Nucleated Cell Count | HPC After Prep Percent CD34 Positve | HPC After Prep Percent CD3 Positive | HPC After Prep CD34 Viability | CD34 Positive Fraction Aliquot ID | CD34 Positive Fraction Total Volume | CD34 Positive Fraction Nucleated Cell Count | CD34 Positive Fraction Percent CD34 Positve | CD34 Positive Fraction Percent CD3 Positive | CD34 Positive Fraction CD34 Viability | CD34 Negative Fraction Total Volume | CD34 Negative Fraction Nucleated Cell Count | CD34 Negative Fraction Percent CD34 Positve | CD34 Negative Fraction Percent CD3 Positive | CD34 Negative Fraction CD34 Viability |
    | Test         | TF         | TL        | MR             | CR   | RID         |            | 452          | 5.02                 | 5    | 22.6       | 0          | 22.69                 | 90.4       | 542.4                          | 3.99                       | 21.64                       | 4                           | 21.7                        | 522                             | 4.37                        | 22.8                         | 2                            | 10.4                         | 166                       | 13.76                 | 22.84                  | 7                      | 11.6                   | 95.4                                 | 105.4                                 | 100.2                           | 419                  | 40              | 4.88                    | 0.19   | 10.9  | 2/6/15                                          | 09:15                                           | 1                         | 327                              | 37                  | 0             | 290                                     | 340                          | 552                                     | 123           | 15                  | 838                  | 0                          | 325                                  | 225                                         | 6150106017      | 6150106017             | 11:13                 | 1             | 0                 | 1337            | 11:43                | 353                                          | 123                  | 15                         | 838                         | 465                                  | 462                                          | 456                  | 15                         | 838                         | 457                                  | 115                         | 0                           | 1                                  | 309                                                  | 6/2/15                            | 15:19                             | 6/2/15                          | 16:04                           | 2304                  | 104                                     | 22.0                                | M60F0004S4002N1 | 1                  |                  |                          |                           |                          |                    | 1                     |                   |                     |                             |                              |                             | 1                       |                       |                               |                                |                               | 1                        |                      |                        |                         |                |                                  |                    |                  |                                |                                 |                                |                            | 290                          | 3.07                                 | 0.68                                 | 14.3                                 | 99.0                           | 272                         | 2.95                                | 0.82                                | 17.5                                | 98.8                          | A0                                | 82                                  | 5.53                                        | 90.57                                       | 0.04                                        | 99.2                                  | 421                                 | 1.72                                        | 0.11                                        | 19.2                                        | 94.0                                  |
