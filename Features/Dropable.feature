Feature: Droppable

Perform Drag and drop action and verify the same post completion through the validation of the message displayed
Background: 
	Given The url for the Drag and Drop webpage
@draganddrop1
Scenario: Drag and drop
	When Drag the element to the target	
	Then After dragging the element is within the box 

@draganddrop2
Scenario: Drag and drop for offset values
	When Drag the element not to the target	
	Then After dragging the element is outside the target