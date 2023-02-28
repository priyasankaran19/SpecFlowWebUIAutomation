Feature: Autocomplete
Implement logic begind the auto completion of words in search boxes both multiple colour names and single color names

Background: 
	Given The url for the Autocomplete webpage

@multiple
Scenario: Autocompletion of words for multiple colour names
	When I enter the multiple colour names in the text box
	Then Autocomplete of multiple names should exists
@single
Scenario: Autocompletion of words for single colour names
	When I enter the single colour name in the text box
	Then Autocomplete of single names should exists