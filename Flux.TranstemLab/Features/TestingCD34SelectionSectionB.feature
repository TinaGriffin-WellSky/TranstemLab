Feature: TestingCD34SelectionSectionB
	In order to ensure methods and steps are working properly while saving time
	As an SQA intern
	I want to run a test with steps only for CD34 Selection - Section B

@mytag
Scenario Outline: Section B
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
	Then I navigate to CD34+ Section B
	And I fill in Magnetic Labeling of CD34 Positive Cells with <CD34 Reagent ID>, <Second CD34 Reagent ID>
	And I fill in Incubation with <Incubation Start Time>, <Air Injection>, <Placed on Rotator>, <Rotator Comment>, <Incubation Stop Time>
	And I fill in Wash Number One with <Wash 1 Amount of Buffer Transferred into Bag>, <Wash 1 Centrifuge ID>, <Wash 1 Centrifugation Time>, <Wash 1 Centrifugation Speed>, <Wash 1 Amount of Supernatant Removed>
	And I fill in Wash Number Two with <Wash 2 Amount of Buffer Transferred into Bag>, <Wash 2 Centrifuge ID>, <Wash 2 Centrifugation Time>, <Wash 2 Centrifugation Speed>, <Wash 2 Amount of Supernatant Removed>, <Weight of Bag after Washing>
	And I fill in Final Sample Preparation with <Volume Adjustment is Normal>, <Remove Product Sample for Analysis>, <Weight of Cell Preparation Bag after Buffer Addition>
	And I verify Section B using <Weight of Empty Bag>

	Examples: Section B
	| CD34 Reagent ID | Second CD34 Reagent ID | Incubation Start Time | Air Injection | Placed on Rotator | Rotator Comment | Incubation Stop Time | Wash 1 Amount of Buffer Transferred into Bag | Wash 1 Centrifuge ID | Wash 1 Centrifugation Time | Wash 1 Centrifugation Speed | Wash 1 Amount of Supernatant Removed | Wash 2 Amount of Buffer Transferred into Bag | Wash 2 Centrifuge ID | Wash 2 Centrifugation Time | Wash 2 Centrifugation Speed | Wash 2 Amount of Supernatant Removed | Weight of Bag after Washing | Volume Adjustment is Normal | Remove Product Sample for Analysis | Weight of Cell Preparation Bag after Buffer Addition |
	| 6150106017      | 6150106017             | 11:13                 | 1             | 0                 | 1337            | 11:43                | 353                                          | 123                  | 15                         | 838                         | 465                                  | 462                                          | 456                  | 15                         | 838                         | 457                                  | 115                         | 0                           | 1                                  | 309                                                  |