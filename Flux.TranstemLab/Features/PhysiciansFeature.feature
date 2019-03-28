Feature: Physicians page Test Cases

Scenario: Create Physicians from Facility page
	Given  I navigate to TranstemLab application  
	And    I click on Entity Management option from Home page for Physicians
	And    I click on Add Physicians button
	Then   I enter values First Name Last Name Address city Postal Code Primary Phone Fax Number Email in page
			| First Name | Last Name | Address | city | Postal Code | Primary Phone | Fax Number | Email       |
			| FN         | LN       | ADD    | City   |             |               |            |   @Email.com|
	And    I Click on Save Button from Physicians page
