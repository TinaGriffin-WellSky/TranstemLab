Feature: User Management

@mytag
Scenario: Creating New User
	Given I navigate to TranstemLab application
	Then I navigate to Administrator homepage
	Then I navigate to User Management page
	Then I navigate to Add User page
	Then I fill in all the information to create a user
	And I click on Add User
	And I click LogOutName
	And I should be navigated to TranstemLab login page