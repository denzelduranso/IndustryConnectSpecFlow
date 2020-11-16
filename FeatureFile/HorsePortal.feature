Feature: HorsePortal
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Verify user is able to login into the portal

Given I navigate to the Portal
When I add credentials to the Login Page and click submit btn
Then I create a TM Record
Then Edit the last new created TM Record