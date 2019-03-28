Feature: BatchProcessingFeature

@mytag
Scenario: Add Batch and Divide Batch
    Given I navigate to TranstemLab application
    Then  I click on Product Link and select Batch Processing to Search page
    And   I click on Add Batch button to Add Batch page
    Then  I change the Date Range
    And   I select Cell Processing v1 20111 from the drop down list
    And   I click on Search button in the Add Batch page
    Then  I select the first parent in the table
    And   I click on the check box of the parent and click on Set Batch button to navigate to Processing Procedure page
    Then  I select a Technologist from Technologist Name drop down
    And   I click on Save button to save the Processing Procedure
    Then  I click on Product List and navigate to Processing page
	And   I get the product ID from product home page
    And   I click on Divide button
    Then I select 2 for number of divisions, and I click on Yes button for distributiong product division counts evenly
    Then I click Save on Pop window
    Then  I click on the parent title arrow
    Then  I verify that the parent is read only
	Then I click LogOutLink
	And I should be navigated to TranstemLab login page
	And I Log Out

	Scenario: Sample Storage testing
    Given I navigate to TranstemLab application
    Then  I click on Product Link and select Batch Processing to Search page
    And   I click on Add Batch button to Add Batch page
    Then  I change the Date Range
    And   I select Cell Processing v1 20111 from the drop down list
    And   I click on Search button in the Add Batch page
    Then  I select the first parent in the table
    And   I click on the check box of the parent and click on Set Batch button to navigate to Processing Procedure page
    Then  I select a Technologist from Technologist Name drop down
    And   I click on Save button to save the Processing Procedure
    Then  I click on Product List and navigate to Processing page
	Then I click on the Title Arrow
	Then I click on Storage
	Then I click on Sample Storage
	Then I fill out the sample storage information
	Then I click on Create Sample
	Then I click LogOut
	And I should be navigated to TranstemLab login page
	And I Log Out

Scenario: Unit Storage testing
    Given I navigate to TranstemLab application
    Then  I click on Product Link and select Batch Processing to Search page
    And   I click on Add Batch button to Add Batch page
    Then  I change the Date Range
    And   I select Cell Processing v1 20111 from the drop down list
    And   I click on Search button in the Add Batch page
    Then  I select the first product in the table
    And   I click on the check box of the parent and click on Set Batch button to navigate to Processing Procedure page
    Then  I select a Technologist from Technologist Name drop down
    And   I click on Save button to save the Processing Procedure
    Then  I click on Product List and navigate to Processing page
	Then I click on the Title Arrow
	Then I click on Storage
	Then I click on Unit Storage
	Then I fill out the unit storage information
	Then I click Save
	And I verify that the storage action saves
	Then I click LogOut
	And I should be navigated to TranstemLab login page
	And I Log Out

Scenario: Repeat Sub-Components
    Given I navigate to TranstemLab application
    Then  I click on Product Link and select Batch Processing to Search page
    And   I click on Add Batch button to Add Batch page
    Then  I change the Date Range
    And   I select Cell Processing v1 20111 from the drop down list
    And   I click on Search button in the Add Batch page
    Then  I select the first product in the table
    And   I click on the check box of the parent and click on Set Batch button to navigate to Processing Procedure page
    Then  I select a Technologist from Technologist Name drop down
    And   I click on Save button to save the Processing Procedure
    Then  I click on Product List and navigate to Processing page
	Then I click on the Title Arrow
	Then I click on Processing
	Then I repeat Processing Step 1
	Then I repeat Processing Step 2
	Then I repeat Processing Step 3
	Then I click on CD34 Selection
	Then I repeat Data Analysis Unselected Processing
	Then I repeat Data Analysis CD34 Selection
	Then I click LogOutLink
	And I should be navigated to TranstemLab login page
	And I Log Out
