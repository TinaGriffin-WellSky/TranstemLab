Feature: EnvironmentalMonitoring


@mytag
Scenario: Add Task Response
	Given I navigate to TranstemLab application
	And I navigated to Environmental Monitoring
	Then I select task 'Lab cleaning'
	And I will click on add button to add a task
	Then I fill in the detail on the Task Response
	And I click on Save button in the Task Response Pop Up
	Then I click on the Edit link
	And I fill in the table
	And I click on the Update link in Environmental Monitoring Home Page
	Then I click LogOut
	And I should be navigated to TranstemLab login page
	And I Log Out

Scenario: Create a Task
	Given I navigate to TranstemLab application
	And I navigated to Admin Home page
	Then I click on Environmental Monitoring Link
	And I click on Add button to add a new task
	Then I enter a name in Task Name field
	And I click on the save button
	Then I sort the table to view tasks in DESC order
	And I click on the task just created
	Then I want to create '3' columns
	And I fill out those columns
	And I click on the save button
	Then I click LogOut
	And I should be navigated to TranstemLab login page
	And I Log Out

	