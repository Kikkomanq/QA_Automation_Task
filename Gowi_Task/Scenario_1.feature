Feature: Navigate to page and check if image is present

As a user
I want to click the management team menu items
So that we can see that the correct page is displayed

Scenario: Story 1
	Given I navigate to the page "http://www.euromoneyplc.com/who-we-are/management-team"
	When I see the page is loaded
	Then Verify that the URL of the first image is present


	