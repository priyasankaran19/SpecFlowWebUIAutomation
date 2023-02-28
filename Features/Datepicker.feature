Feature: Date Picker

Implement logic to test 'Select Date' and 'Date and Time'  feature

Background: 
	Given The url for the Date picker
@selectdate
Scenario: Select Date
	When Enter the date "20/02/2017" in Select Date field
	Then Date should be selected as per the input
@dateandtime
Scenario:  Date and Time
	When Enter the datetime "February 28, 2023 11:57 AM" in Date and Time field	
	Then Date and Time should be selected as per the input
