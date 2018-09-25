Feature: UnSubscriptionSpecFlow
	As a user subscribed to emails I want to unsubscribe from getting emails

@mytag
Scenario: UnSubscribe from getting Emails
	Given I have logged into the grabone website
    When  I unsubscribed from getting mails
	Then  I should get an update message

