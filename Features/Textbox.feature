Feature: Text Box
Validation of Text box feature
Background: 

	Given The url for the webpage
	And Click Nav item Text Box

@TC1
Scenario Outline: Verification of details post submission

	Given I entered the following data to the form:
		| fullName      | email				| currentAddress | permanentAddress |
		| tom john		| tjohn@email.com	| 15, Melbourne  | 15, Melbourne    |
	And I click Submit button
	Then Verify the data post submit
	
