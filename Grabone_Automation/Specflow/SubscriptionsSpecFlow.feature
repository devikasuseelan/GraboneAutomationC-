Feature: SubscriptionsSpecFlow
	As a user of the grabone website I want to get subscribed to emails
@mytag
Scenario: Subscribe to Emails
	Given I have logged into the grabone website
	When I selected preferences for getting emails
	Then I should get the subscription enabled message
