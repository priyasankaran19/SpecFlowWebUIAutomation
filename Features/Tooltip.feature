
Feature: Tooltip

Verify the logic to validate the tool tip content obtained on hovering over the highlighted items
Background: 
	Given Click Nav item Tool tips 

@tooltip
Scenario Outline: Verify the tool tip content
	When Move the mouse over Hover over me button
	Then The Tooltip message should be displayed