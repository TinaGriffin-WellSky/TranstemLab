Feature: Test Cases for Recipient page

	Scenario Outline: Creating New Recipients 
	Given I navigate to TranstemLab application
	Then I click on Recipients Link 
	Then I click on Add Recipient button from Recipient Search Page
	Then I enter <Recipient ID> <First Name> <Last Name> <Medical Record> <CRID> <Registry ID> <Birth Date> Gender Ethnicity and Client Status in the page
	Then I click on Save button from page
	And  I Click on Add a transplant event for patient from RecipientDetail page
	Then I enter value for all fields in Add Transplant Event page
	Then I click on Save button form Add Tranplant Event Page
	And I click on Documents for file upload
	Then I enter Values in Description as Testing & for Category & for File
	Then I click on Notes for making note for the RecipientID
	Then I enter values for Category & for Note as Testing
	Then I click on Save Button from the Note Page
	And I click LogOutName
	And I should be navigated to TranstemLab login page

	Examples: 
	| Recipient ID | First Name | Last Name | Medical Record | CRID | Registry ID |Birth Date  |
	| Test         | TF         | TL        | MR             | CR   | RID         |			   |   

	Scenario Outline: Search Recipient By First Name
	Given I navigate to TranstemLab application
	Then I click on Recipients Link 
	Then I click on Add Recipient button from Recipient Search Page
	Then I enter <Recipient ID> <First Name> <Last Name> <Medical Record> <CRID> <Registry ID> <Birth Date> Gender Ethnicity and Client Status in the page
	Then I click on Save button from page
	And  I Click on Add a transplant event for patient from RecipientDetail page
	Then I enter value for all fields in Add Transplant Event page
	Then I click on Save button form Add Tranplant Event Page
	And  I record recipient information
	Then go to home page from Recipient page
	And I start to do a Recipient search
	And I enter Recipient Last Name 
	Then I click on Search button on the Recipient Search page
	And  I verify the recipient information
	And I click LogOutName
	And I should be navigated to TranstemLab login page

	Examples: 
	| Recipient ID | First Name | Last Name | Medical Record | CRID | Registry ID |Birth Date  |
	| Test         | TF         | TL        | MR             | CR   | RID         |			   |   


	Scenario Outline: Search Recipient By Last Name
	Given I navigate to TranstemLab application
	Then I click on Recipients Link 
	Then I click on Add Recipient button from Recipient Search Page
	Then I enter <Recipient ID> <First Name> <Last Name> <Medical Record> <CRID> <Registry ID> <Birth Date> Gender Ethnicity and Client Status in the page
	Then I click on Save button from page
	And  I Click on Add a transplant event for patient from RecipientDetail page
	Then I enter value for all fields in Add Transplant Event page
	Then I click on Save button form Add Tranplant Event Page
	And  I record recipient information
	Then go to home page from Recipient page
	And I start to do a Recipient search
	And I enter Recipient First Name 
	Then I click on Search button on the Recipient Search page
	And  I verify the recipient information
	And I click LogOutName
	And I should be navigated to TranstemLab login page

	Examples: 
	| Recipient ID | First Name | Last Name | Medical Record | CRID | Registry ID |Birth Date  |
	| Test         | TF         | TL        | MR             | CR   | RID         |			   |   

	Scenario Outline: Search Recipient By MRN
	Given I navigate to TranstemLab application
	Then I click on Recipients Link 
	Then I click on Add Recipient button from Recipient Search Page
	Then I enter <Recipient ID> <First Name> <Last Name> <Medical Record> <CRID> <Registry ID> <Birth Date> Gender Ethnicity and Client Status in the page
	Then I click on Save button from page
	And  I Click on Add a transplant event for patient from RecipientDetail page
	Then I enter value for all fields in Add Transplant Event page
	Then I click on Save button form Add Tranplant Event Page
	And  I record recipient information
	Then go to home page from Recipient page
	And I start to do a Recipient search
	And I enter Recipient MRN
	Then I click on Search button on the Recipient Search page
	And  I verify the recipient information
	And I click LogOutName
	And I should be navigated to TranstemLab login page

	Examples: 
	| Recipient ID | First Name | Last Name | Medical Record | CRID | Registry ID |Birth Date  |
	| Test         | TF         | TL        | MR             | CR   | RID         |			   |   


	Scenario Outline: Search Recipient By First name Last Name and MRN
	Given I navigate to TranstemLab application
	Then I click on Recipients Link 
	Then I click on Add Recipient button from Recipient Search Page
	Then I enter <Recipient ID> <First Name> <Last Name> <Medical Record> <CRID> <Registry ID> <Birth Date> Gender Ethnicity and Client Status in the page
	Then I click on Save button from page
	And  I Click on Add a transplant event for patient from RecipientDetail page
	Then I enter value for all fields in Add Transplant Event page
	Then I click on Save button form Add Tranplant Event Page
	And  I record recipient information
	Then go to home page from Recipient page
	And I start to do a Recipient search
	And I enter Recipient MRN
	And I enter Recipient First Name 
	And I enter Recipient Last Name
	Then I click on Search button on the Recipient Search page
	And  I verify the recipient information
	And I click LogOutName
	And I should be navigated to TranstemLab login page

	Examples: 
	| Recipient ID | First Name | Last Name | Medical Record | CRID | Registry ID |Birth Date  |
	| Test         | TF         | TL        | MR             | CR   | RID         |			   |   







	
	

