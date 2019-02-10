Feature: RegistrationSteps

	As a new user of the site 
	I should be able to register to giftere site
	


Scenario: Valid Registration
	Given I navigate to the site
	When I click on register link
	And I enter fisrtname
	And I enter lastname 
	And I enter email "test@giftrete.com"
	And I enter password
	And I confirm password
	And I click on the signup botton
	Then I should be  register 

Scenario: InValid Registration
	Given I navigate to the site
	When I click on register link
	And I enter fisrtname
	And I enter lastname 
	And I enter email "test@giftrete.com"
	And I enter wrong password "goodman"
	And I confirm password "No"
	And I click on the signup botton
	Then I should not be register


