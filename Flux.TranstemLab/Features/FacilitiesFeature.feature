Feature: Facilities Test Cases

Scenario: Create Facilities from Facility page
	Given  I navigate to TranstemLab application  
	And    I click on Entity Management option from Home page
	And    I click on Add Facility button
	Then   I enter values Name Address city PostalCode & Type status Region state in page
			|Name  | Address | city | PostalCode |
			|FN    |     Add | City|             |
	And    I Click on Save Button from Facility page
