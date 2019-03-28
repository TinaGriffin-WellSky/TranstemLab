Feature: ReferenceTable

@mytag
Scenario: Manage Reference Table
	Given I navigate to TranstemLab application
	Then I navigate to Administrator homepage
	Then I navigate to Reference Table page Administrator homepage
	And I click on the plus button to expend the all of the Reference Tables in the list
	Then I select every item in the list to very that they are all working properly
	Then I select 'Cell VIability Method' from the list
	And I add new row to the look up table
	Then I verify that all of the sorting method works properly
	And I click on the Save button in the reference table page
	Then I click on Add button in the reference table page
	And I enter the string to the newly generated cell
	And I click on the Save button in the reference table page
#   Verification part could not be done because of the delays
#	And I navigate to Transtem Home page from Reference table page
#	Then  I click on Product Link and select Batch Processing to Search page
#    And   I click on Add Batch button to Add Batch page
#    Then  I change the Date Range
#    And   I select Cell Processing v1 20111 from the drop down list
#    And   I click on Search button in the Add Batch page
#    Then  I select the first product in the table
#    And   I click on the check box of the parent and click on Set Batch button to navigate to Processing Procedure page
#    Then  I select a Technologist from Technologist Name drop down
#    And   I click on Save button to save the Processing Procedure
#    Then  I click on Product List and navigate to Processing page
#	Then I click on the Title Arrow
#	Then I click on Processing
#	And I click on processing step 1
#	Then I check on the value in the Viability Method
	And I click LogOutName
	And I should be navigated to TranstemLab login page


