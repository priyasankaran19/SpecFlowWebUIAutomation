Feature: CheckBox

Validation of Check box feature

Background: 

	Given The url for the checkbox webpage
	And Click Nav item Check Box
	And I click "Home" toggle
	And I click "Downloads" toggle
	And I select "wordFile"
@TC1
Scenario Outline: Verification of the selected items
	
	Then "wordFile" should be selected

Scenario Outline: Verification of the un selected items
	And I select "wordFile"
	Then "wordFile" should NOT be selected