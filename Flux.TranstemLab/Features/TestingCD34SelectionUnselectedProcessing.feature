Feature: TestingCD34SelectionUnselectedProcessing
	In order to ensure methods and steps are working properly while saving time
	As an SQA intern
	I want to run a test with steps only for CD34 Selection - Data Analysis Unselected Processing

@mytag
Scenario Outline: Data Analysis Unselected Processing
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
	Then I navigate to Data Analysis Unselected Processing
	And I fill in HPC Product Aliquot for Unselected Processing with <HPC Not Applicable>, <HPC Total Volume>, <HPC Nucleated Cell Count>, <HPC Percent CD34 Positive>, <HPC Percent CD3 Positive>, <HPC CD34 Viability>
	And I fill in T-Cell Aliquot with <T-Cell Not Applicable>, <T-Cell Aliquot ID>, <T-Cell Total Volume>, <T-Cell Nucleated Cell Count>, <T-Cell Percent CD34 Positive>, <T-Cell Percent CD3 Positive>
	And I fill in Pre-Spin (After Removal of T-Cell Aliquots) with <Pre-Spin Not Applicable>, <Pre-Spin Total Volume>, <Pre-Spin Nucleated Cell Count>, <Pre-Spin Percent CD34 Positive>, <Pre-Spin Percent CD3 Positive>
	And I fill in Post-Spin with <Post-Spin Not Applicable>, <Post-Spin Aliquot ID>, <Post-Spin Gross Weight>, <Post-Spin Centrifuge ID>, <Post-Spin RPMs>, <Post-Spin Centrifuge Temperature>, <Post-Spin Gross Wt>, <Post-Spin Bag Wt>, <Post-Spin Nucleated Cell Count>, <Post-Spin Percent CD34 Positive>, <Post-Spin Percent CD3 Positive>, <Post-Spin Percent Recovery>
	And I verify Data Analysis Unselected Processing

	Examples: Data Analysis Unselected Processing
	| HPC Not Applicable | HPC Total Volume | HPC Nucleated Cell Count | HPC Percent CD34 Positive | HPC Percent CD3 Positive | HPC CD34 Viability | T-Cell Not Applicable | T-Cell Aliquot ID | T-Cell Total Volume | T-Cell Nucleated Cell Count | T-Cell Percent CD34 Positive | T-Cell Percent CD3 Positive | Pre-Spin Not Applicable | Pre-Spin Total Volume | Pre-Spin Nucleated Cell Count | Pre-Spin Percent CD34 Positive | Pre-Spin Percent CD3 Positive | Post-Spin Not Applicable | Post-Spin Aliquot ID | Post-Spin Gross Weight | Post-Spin Centrifuge ID | Post-Spin RPMs | Post-Spin Centrifuge Temperature | Post-Spin Gross Wt | Post-Spin Bag Wt | Post-Spin Nucleated Cell Count | Post-Spin Percent CD34 Positive | Post-Spin Percent CD3 Positive | Post-Spin Percent Recovery |
	| 1                  |                  |                          |                           |                          |                    | 1                     |                   |                     |                             |                              |                             | 1                       |                       |                               |                                |                               | 1                        |                      |                        |                         |                |                                  |                    |                  |                                |                                 |                                |                            |