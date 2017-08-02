Feature: Check for different links on website

As a user
I want go to the Specialist finance and economic data menu item
So that I can open the IJ Global website and see the latest news section

Scenario: Story 2
	Given The ‘Specialist finance and economic data’ link is displayed correctly on the menu item
	When The ‘VISIT IJ GLOBAL’ link navigates to https://ijglobal.com/
	When The page title is ‘IJGlobal | Infrastructure Journal and Project Finance Magazine’
	Then The league table section is displayed on the home page
