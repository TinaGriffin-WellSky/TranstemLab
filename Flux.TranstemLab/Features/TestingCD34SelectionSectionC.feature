Feature: TestingCD34SelectionSectionC
	In order to ensure methods and steps are working properly while saving time
	As an SQA intern
	I want to run a test with steps only for CD34 Selection - Section C

@mytag
Scenario Outline: Section C
    Given I navigate to TranstemLab application
    Then  I click on Product Link and select Batch Processing to Search page
    And   I click on Add Batch button to Add Batch page
    Then  I change the Date Range
    And   I select Cell Processing v1 20111 from the drop down list
    And   I click on Search button in the Add Batch page
    Then  I select the first product in the table
	And I click on the Set Batch button to navigate to Processing Procedure page
    Then  I select a Technologist from Technologist Name drop down
    And   I click on Save button to save the Processing Procedure
    Then  I click on Product List and navigate to Processing page
	Then I click on the Title Arrow
	Then I navigate to CD34+ Section C
	And I fill in CliniMACS Separation (Run) with <CliniMACS Separation Date Started>, <CliniMACS Separation Time Started>, <CliniMACS Separation Date Ended>, <CliniMACS Separation Time Ended>, <Tubing Set Reagent ID>
	And I fill in Calculate the Amount of Positive Fraction with <Weight of Cell Collection Bag after Run>, <Weight of Empty Cell Collection Bag>, <Process Code>
	And I verify Section C
	
	Examples: Section C
	| CliniMACS Separation Date Started | CliniMACS Separation Time Started | CliniMACS Separation Date Ended | CliniMACS Separation Time Ended | Tubing Set Reagent ID | Weight of Cell Collection Bag after Run | Weight of Empty Cell Collection Bag | Process Code    |
	| 6/2/15                            | 15:19                             | 6/2/15                          | 16:04                           | 2304                  | 104                                     | 22.0                                | M60F0004S4002N1 |