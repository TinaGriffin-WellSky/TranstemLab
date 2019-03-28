Feature: ConvertUnitIdToIsbt

@mytag
Scenario Outline: Convert Product ID to ISBT
    Given I navigate to TranstemLab application
	Then I should be navigated to TranstemLab home page
	Then I click on Donors Link to create a Donor
	And I click on Add donor button
	Then I enter donor personal information <First Name>, <Last Name>, <Maiden Name>, <MRN>, <Internal Donor ID>, <Registry ID>, <Email>, <Birth Date>, <Weight>, <Height>, <SSN Last Four> in to the page
	Then I enter donor demographic information <Address>, <Apartment>, <City>, <ZipCode>, <Home Phone>, <Work Phone> and <Cell Phone> in to the page	
	Then I click on the Save Button from page
	Then I will create collection event
	Then I click on Add collection Event link from the Donor Detail page and fill out the required fields
	And  I record the system generated donor ID
	Then  I click on Save button
	Then I Start to Add a Product
	Then I click on the Product link to add a new product
	And I select radio button to enter system generated donor ID and enter the ID
	And I click on the Load Donor ID and check the patient information 
	Then I click on the sync button
	And I click on the radio button to select donor and press enter key in the keyboard
	Then I click on Create Collection Event button
	And I click on the Create Product
	And I click on Convert to ISBT button Unit Id is converted to ISBT
	And I click on Save Button for Product Home Page
	And I click LogOutLink
    And I should be navigated to TranstemLab login page

	Examples: 
	| First Name | Last Name | Maiden Name | MRN | Internal Donor ID | Registry ID | Email     | Birth Date | Weight | Height | SSN Last Four | Address | Apartment | City | ZipCode | Home Phone | Work Phone | Cell Phone |
	| FN         | LN        | MN          | MRN | IID               | RID         | @mail.com |            |        |        |               | Add     |           | City |         |            |            |            |