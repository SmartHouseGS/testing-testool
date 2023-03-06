@CollapsedMenu
Feature: GeneralCollapsedMenu

A short summary of the feature

@regression
Scenario: Verify that the collapsed menu includes all the necessary icons
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed		
	When I verify that the menu on the left site of page is displayed 
	Then The menu on the left site of page
	When I verify that the Volue logo at the top of the menu is displayed 
	Then The Volue logo at the top of the menu is displayed 
	When I verify that the organization icon under the Volue logo is displayed 
	Then The organization icon under the Volue logo is displayed 
	When I verify that the tenant icon under the organization icon is displayed 
	Then The tenant icon under the organization icon is displayed 
	When I verify that the dashboard icon under the tenant icon is displayed
	Then The dashboard icon under the tenant icon is displayed 
	When I verify that the user icon at the bottom of the menu is displayed 
	Then The user icon at the bottom of the menu is displayed 
	When I verify that the sidebar drop-down menu button under the user icon is displayed
	Then The sidebar drop-down menu button under the user icon is displayed 


	@regression
Scenario: Expand the menu by clicking on the sidebar drop-down menu button
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed
	Given Sidebar drop-down menu - collapsed
	When I hover over the sidebar drop-down menu button
	Then The sidebar drop-down menu button is highlighted in gray
	When I click the sidebar drop-down menu button at the bottom of the menu
	Then The menu is expanded