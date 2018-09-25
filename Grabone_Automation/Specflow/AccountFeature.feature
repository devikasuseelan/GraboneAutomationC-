Feature: AccountFeature
	AS a Grabone Website user I want to update my account details

@mytag
Scenario: Update user account with valid details
	Given I have logged into the website
    When I changed my account  details
	Then I should be able to update details
