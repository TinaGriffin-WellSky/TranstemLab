Feature: EquipmentFeature

@mytag
Scenario Outline: Create Equipment And Add Note, Document, and Maintance
	Given I navigate to TranstemLab application 
	Then I click on Equipment Link
	And I click on Add Equipment button
	Then I enter <AID> <Description> <Manufacturer> <MN> <SN> EquipmentType Location and Disposition in in the page
	Then I click on the Save button to Save the New Equipment
	And I should be Navigated to the Equipment Home Page
	And I record equipment information
	Then I click on Add Document button for file upload and I enter Values in Description as Testing and choose a file
	Then I click on Add Note button and fill out as Testing
	Then I click on Add Preventive Maintenance and I enter a date in Date Scheduled and values in Notes as Testing
	And I click on the Save button in Equipment Home Page
	Then I navigate to Transtem Home page frpm Equipment Home page
	Then I click on Equipment Link
	And I enter Equipment information
	And I click on Search and select correct equipment
	Then I click the Preventive Maintenance and I enter a date in Date Performed
	Then I verify the information of the equipment
    And I click LogOutName
    And I should be navigated to TranstemLab login page


	Examples: 
	| AID| Description | Manufacturer | MN | SN |
	| AID| D_          | M            | MN | SN |