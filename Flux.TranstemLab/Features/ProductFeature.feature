Feature: ProductFeature


@mytag
Scenario Outline: Create a New Donor and Add Product with System Generated Donor ID
	Given I navigate to TranstemLab application
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
	Then I click LogOutLink
	And I should be navigated to TranstemLab login page
	And I Log Out

	Examples: 
	| First Name | Last Name | Maiden Name | MRN | Internal Donor ID | Registry ID | Email     | Birth Date | Weight | Height | SSN Last Four | Address | Apartment | City | ZipCode | Home Phone | Work Phone | Cell Phone |
	| FN         | LN        | MN          | MRN | IID               | RID         | @mail.com |            |        |        |               | Add     |           | City |         |            |            |            |

Scenario Outline: Create a New Donor with a New Donor Kit and assign it to the Donor
	Given I navigate to TranstemLab application
	Then I click on Donors Link to create a Donor
	And I click on Add donor button
	Then I enter donor personal information <First Name>, <Last Name>, <Maiden Name>, <MRN>, <Internal Donor ID>, <Registry ID>, <Email>, <Birth Date>, <Weight>, <Height>, <SSN Last Four> in to the page
	Then I enter donor demographic information <Address>, <Apartment>, <City>, <ZipCode>, <Home Phone>, <Work Phone> and <Cell Phone> in to the page	
	And I save donor information
	Then I click on the Save Button from page
	Then I Start to Add a Product
	Then I click on the Product link to add a new product
	And  I start to add a new kit
	Then I click on Scan/enter existing kit ID or create a new kit radio, and click on Create New Kit
	Then I fill out the required fields in Add New Kit(s) page
	And I click on the save button from Add New Kits(s) page
	Then I verify the information and click on Load Kit # button
	And I fill out donor information
	And I click on the sync button from Add New Product page
	And I click on Create Collection Event button from Add New Product page
	And I fill out the required fields to Add a new kit
	Then I click on the Create Product button
	And I verify the information
	Then I click LogOutLink
	And I should be navigated to TranstemLab login page
	And I Log Out

	Examples: 
	| First Name | Last Name | Maiden Name | MRN | Internal Donor ID | Registry ID | Email     | Birth Date | Weight | Height | SSN Last Four | Address | Apartment | City | ZipCode | Home Phone | Work Phone | Cell Phone |
	| FN         | LN        | MN          | MRN | IID               | RID         | @mail.com |            |        |        |               | Add     |           | City |         |            |            |            |


Scenario: Create a New Donor and Add Product with Bypass Donor/Kit
	Given I navigate to TranstemLab application
	Then I click on product link to add
	Then I click on the Product link to add a new product
	And I click on Bypass Donor/Kit
	And I click on Bypass Sync
	Then I fill in the Collection Event Data
	And I click on the Create Product from Bypass Donor/Kit
	Then I click LogOutLink
	And I should be navigated to TranstemLab login page
	And I Log Out