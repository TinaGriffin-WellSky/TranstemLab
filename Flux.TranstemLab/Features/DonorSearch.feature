Feature: DonorSearch
	In order to access donor information
	As a user
	I want to be able to search for donors


	
@mytag


Scenario Outline: Search by Donor Last Name
	Given I navigate to TranstemLab application
	Then I click on Donors Link to create a Donor
    And I click on Add donor button
	Then I enter donor personal information <First Name>, <Last Name>, <Maiden Name>, <MRN>, <Internal Donor ID>, <Registry ID>, <Email>, <Birth Date>, <Weight>, <Height>, <SSN Last Four> in to the page
	Then I enter donor demographic information <Address>, <Apartment>, <City>, <ZipCode>, <Home Phone>, <Work Phone> and <Cell Phone> in to the page
	Then I click on the Save Button from page
	Then I record donor information
	And I click LogOutName
	And I should be navigated to TranstemLab login page
	Given  I navigate to TranstemLab application
	Then  I click on Donors Link
	And I enter Donor Last Name
	When I click search
	Then I verify Donor with Last Name is returned
		

	Examples: 
	| First Name | Last Name | Maiden Name | MRN | Internal Donor ID | Registry ID | Email     | Birth Date | Weight | Height | SSN Last Four | Address | Apartment | City | ZipCode | Home Phone | Work Phone | Cell Phone |
	| SD         | LN        | MN          | MRN | IID               | RID         | @mail.com |            |        |        |               | Add     |           |      |         |            |            |            |											
	
	
	Scenario: Search by Status
	Given  I navigate to TranstemLab application
	Then  I click on Donors Link
	Given I have selected a status from the drop down
	When I click search
	Then the expected donor based on status should be displayed
	And I click LogOutName
	And I should be navigated to TranstemLab login page