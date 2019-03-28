Feature: Processing Details

# Currently only works if there are no tasks under Processing Details
@mytag
Scenario: Processing Details
	Given I navigate to TranstemLab application
	Then I should be navigated to TranstemLab home page
	Then I navigate to Administrator homepage
	Then I navigate to Processing Details page
	Then I click on Add new record
	And I enter a description for record 1
	And I update the record
	Then I click on the Edit button for the last record
	And I enter a description for record 1
	And I update the record
	Then I delete the last record
	And I click LogOutLink
	And I should be navigated to TranstemLab login page