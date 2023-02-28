Feature: Buttons

Verify the button selected by the message displayed on button click

Background: 

	Given The url for the Button webpage
	And Click Nav item Buttons


@rightclick
Scenario Outline: Verify the right click button 
	When I click Right Click me button
	Then The message You have done a right click should be displayed 

@doubleclick
Scenario Outline: Verify the double click button 
	When I click Double Click me button
	Then The message You have done a double click should be displayed 
	
@dynamicclick
Scenario Outline: Verify the dynamic click button 
	When I click Click me button
	Then The message You have done a dynamic click should be displayed 