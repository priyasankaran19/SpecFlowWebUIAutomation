Feature: Login

Register user and login with the registerd credentials and verify the login functionality

@registeruser
Scenario: Register new user
	Given I navigate to Login url
	When I Click New User button
	And Enter the following user details:
		| firstName | lastName | userName | password    |
		| foo       | bar      | foo_bar  | password123 |
	And I click Register
	Then I get output "Please verify reCaptcha to register!"

Scenario: Login user - Invalid User details
	Given I navigate to Login url
	When I enter the following Login details:
		| userName | password    |
		| foo_bar  | password123 |
	And I click Login
	Then I get output "Invalid username or password!" 

Scenario: Login user - Valid User details
	Given I navigate to Login url
	When I enter the following Login details:
		| userName | password    |
		| test_user12345  | Passw0rd@123 |
	And I click Login
	Then I check loggedin_user is "test_user12345"
