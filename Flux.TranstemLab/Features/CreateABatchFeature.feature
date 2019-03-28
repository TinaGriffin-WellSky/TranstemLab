Feature: CreateABatchFeature


@mytag
Scenario Outline: CreateABatch

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
	And I record product information
	And I open 'sampleData.txt' and I generate the HL7 message for testing
	Then I click LogOutLink
	And I should be navigated to TranstemLab login page
	And I Log Out


	Examples: 
	| Recipient ID | First Name | Last Name | Medical Record | CRID | Registry ID |Birth Date  |
	| Test         | TF         | TL        | MR             | CR   | RID         |			   |   