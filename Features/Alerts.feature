Feature: Alerts
Verify "Onbutton Click, prompt box will appear"

Background: 
	Given The url for the Alerts webpage

@promptbox
Scenario: click button to check prompt box
	When I click the click me button to check the prompt box
	Then Entered Text appeat on the screen