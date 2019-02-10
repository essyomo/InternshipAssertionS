Feature: LoginSteps
	As user of the site
	I need to login 
	

@mytag
Scenario: Login to the site
	Given I navigate to the site
	When  I click on login
	And   I enter my email
	And   I enter my password
	And   I click on login button
	Then  I can login to the site
