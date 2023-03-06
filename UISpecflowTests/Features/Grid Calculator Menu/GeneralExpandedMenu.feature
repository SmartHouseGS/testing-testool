@ExpandedMenu
Feature: GeneralExpandedMenu

A short summary of the feature

@regression
Scenario: Verify that the expanded menu includes all the necessary icons and information
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed			
	When I verify that the menu on the left site of page is displayed 
	Then The menu on the left site of page
	Given Sidebar drop-down menu
	When I click the sidebar drop-down menu button at the bottom of the menu
	Then The menu is expanded
	When I verify that the Volue logo and Grid Calculator at the top of the menu are displayed 
	Then The Volue logo and Grid Calculator at the top of the menu are displayed 
	When I verify that the organization icon and name under the Volue logo and Grid Calculator are displayed 
	Then The organization icon and name under the Volue logo and Grid Calculator are displayed 
	When I verify that the tenant icon and name under the organization tab are displayed 
	Then The tenant icon under and name the organization tab are displayed 
	When I verify that the dashboard icon and text under the tenant tab are displayed
	Then The dashboard icon and text under the tenant tab are displayed 
	When I verify that the user icon and name at the bottom of the menu are displayed 
	Then The user icon and name at the bottom of the menu are displayed 
	When I verify that the sidebar drop-down menu button on the right of the user tab is displayed
	Then The sidebar drop-down menu button on the right of the user tab is displayed 

@regression
Scenario: Hide the menu by clicking on the sidebar drop-down menu button
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed	
	Given Sidebar drop-down menu
	When I click the sidebar drop-down menu button at the bottom of the menu
	Then The menu is expanded
	Given Sidebar drop-down menu - expanded	
	When I hover over the sidebar drop-down menu button
	Then The sidebar drop-down menu button is highlighted in gray	
	When I click the sidebar drop-down menu button at the bottom of the menu
	Then The menu is collapsed