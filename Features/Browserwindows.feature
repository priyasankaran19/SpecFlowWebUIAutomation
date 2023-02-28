Feature: Browserwindows
Implement logic to handle New Tab,New Window, and New Window message

Background: 
	Given The url for the Browserwindows webpage
	And Click Nav item Browser windows
@newtab
Scenario: Logic to handle New tab 
	When I click the New Tab button
	Then The New Tab will be opened with sample message
@newwindow
Scenario: Logic to handle New window 
	When I click the New Window button
	Then The New Window will be opened sample message
@newwindowmsg
Scenario: Logic to handle New window message 
	When I click the New Window Message button
	Then The New Window message will be opened
