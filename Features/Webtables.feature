Feature: WebTables

Edit the contents of the Web Table
Background: 
	Given The url for the webpage
	And Click Nav item Web Tables
@tag1
Scenario: Edit the contents of web table 
	When Click the edit button
	And Edit the table with the following data
	| firstName | lastName        | email           | age           | salary | department |
	| tom       | john            | tjohn@email.com | 45            | 50000  | Bank       |
	And Click the submit button
	Then Data should get saved successfully
