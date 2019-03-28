Feature: Donors Test Cases	
	
Scenario: Create Collection Event From Donor Page for Existing Recepient 
	Given I navigate to TranstemLab application 
	Then I click on Donors Link 
	And  I click on search button from the Donor Search Page and I select an identifier 
	Then I click on Add collection Event link from the Donor Detail page and fill out the required fields 
	Then  I click on Save button
	And I click LogOutName
	And I should be navigated to TranstemLab login page
	
 Scenario Outline: Create Birth Event From Donor Page for Existing Recepient 
	Given I navigate to TranstemLab application 
	Then I click on Donors Link 
	And  I click on search button from the Donor Search Page and I select an identifier
	Then I click on Add Birth Event link from the Donor Detail page and fill out the required fields <OtherPhysician> <Location> <OtherReferralType>
	And  I Click on Save button on Add Birth Event page
	And I click on Documents for file upload for Donor page
	Then I enter Values in Description as Testing & for Category & for File on Donor page
	Then I click on Notes for making note for the RecipientID on the Donor page
	Then I enter values for Category & for Note as Testing on the Donor page
    Then I click on Save Button from the Note Page on the Donor page
    And I click LogOutName
    And I should be navigated to TranstemLab login page
  Examples:
    | OtherPhysician | Location | OtherReferralType |
    | Physi		     | Lenexa    | Emma				|

Scenario Outline: Create a New Donor
    Given I navigate to TranstemLab application
    Then I click on Donors Link to create a Donor
    And I click on Add donor button
	# Then I enter donor personal information <First Name> <Last Name> <Maiden Name> <MRN> <Internal Donor ID> <Registry ID> <Email> <Birth Date> <Weight> <Height> <SSN Last Four> <Address> <Apartment> <City> <ZipCode> <Home Phone> <Work Phone> <Cell Phone> Gender ABORhType State Country and Status in the page
	Then I enter donor personal information <First Name>, <Last Name>, <Maiden Name>, <MRN>, <Internal Donor ID>, <Registry ID>, <Email>, <Birth Date>, <Weight>, <Height>, <SSN Last Four> in to the page
	Then I enter donor demographic information <Address>, <Apartment>, <City>, <ZipCode>, <Home Phone>, <Work Phone> and <Cell Phone> in to the page
	Then I click on the Save Button from page
	And I click LogOutName
	And I should be navigated to TranstemLab login page

	Examples: 
	| First Name | Last Name | Maiden Name | MRN | Internal Donor ID | Registry ID | Email     | Birth Date | Weight | Height | SSN Last Four | Address | Apartment | City | ZipCode | Home Phone | Work Phone | Cell Phone |
	| FN         | LN        | MN          | MRN | IID               | RID         | @mail.com |            |        |        |               | Add     |           | City |         |            |            |            |