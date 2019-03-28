Feature: Reagents

@mytag
Scenario: Create and Check Reagent
	Given I navigate to TranstemLab application
	Then I click on Equipment/Consumables and select Reagents/Supplies
	Then I click on Add Reagent
	Then I fill out necessary fields with random data on Add Reagent
	And I click Save on Add Reagent
	And I record the reagent ID
	Then I add a document
	Then I add a note
    And I click LogOutName
    And I should be navigated to TranstemLab login page