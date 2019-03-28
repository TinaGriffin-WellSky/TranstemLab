Feature: TestingCD34SelectionCD34Selection
	In order to ensure methods and steps are working properly while saving time
	As an SQA intern
	I want to run a test with steps only for CD34 Selection - Data Analysis CD34 Selection

@mytag
Scenario Outline: Data Analysis CD34 Selection
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
	Then I navigate to Data Analysis CD34 Selection
	And I fill in HPC Product Aliquot for CD34 Selection (Before Prep/Magnetic Labeling) with <HPC Before Prep Total Volume>, <HPC Before Prep Nucleated Cell Count>, <HPC Before Prep Percent CD34 Positve>, <HPC Before Prep Percent CD3 Positive>, <HPC Before Prep CD34 Viability>
	And I fill in HPC Product Aliquot for CD34 Selection (After Prep/Magnetic Labeling) with <HPC After Prep Total Volume>, <HPC After Prep Nucleated Cell Count>, <HPC After Prep Percent CD34 Positve>, <HPC After Prep Percent CD3 Positive>, <HPC After Prep CD34 Viability>
	And I fill in CD34 Selected Positive Fraction (Cell Collection Bag) with <CD34 Positive Fraction Aliquot ID>, <CD34 Positive Fraction Total Volume>, <CD34 Positive Fraction Nucleated Cell Count>, <CD34 Positive Fraction Percent CD34 Positve>, <CD34 Positive Fraction Percent CD3 Positive>, <CD34 Positive Fraction CD34 Viability>
	And I fill in CD34 Selected Negative Fraction (Negative Fraction Bag) with <CD34 Negative Fraction Total Volume>, <CD34 Negative Fraction Nucleated Cell Count>, <CD34 Negative Fraction Percent CD34 Positve>, <CD34 Negative Fraction Percent CD3 Positive>, <CD34 Negative Fraction CD34 Viability>
	And I verify the calculations in Data Analysis CD34 Selection

	Examples: Data Analysis CD34 Selection
	| HPC Before Prep Total Volume | HPC Before Prep Nucleated Cell Count | HPC Before Prep Percent CD34 Positve | HPC Before Prep Percent CD3 Positive | HPC Before Prep CD34 Viability | HPC After Prep Total Volume | HPC After Prep Nucleated Cell Count | HPC After Prep Percent CD34 Positve | HPC After Prep Percent CD3 Positive | HPC After Prep CD34 Viability | CD34 Positive Fraction Aliquot ID | CD34 Positive Fraction Total Volume | CD34 Positive Fraction Nucleated Cell Count | CD34 Positive Fraction Percent CD34 Positve | CD34 Positive Fraction Percent CD3 Positive | CD34 Positive Fraction CD34 Viability | CD34 Negative Fraction Total Volume | CD34 Negative Fraction Nucleated Cell Count | CD34 Negative Fraction Percent CD34 Positve | CD34 Negative Fraction Percent CD3 Positive | CD34 Negative Fraction CD34 Viability |
	| 290                          | 3.07                                 | 0.68                                 | 14.3                                 | 99.0                           | 272                         | 2.95                                | 0.82                                | 17.5                                | 98.8                          | A0                                | 82                                  | 5.53                                        | 90.57                                       | 0.04                                        | 99.2                                  | 421                                 | 1.72                                        | 0.11                                        | 19.2                                        | 94.0                                  |