@OrganizationTabTests @ExpandedMenu
Feature: OrganizationTabExpandedMenu

A short summary of the feature

@regression
Scenario: Verify that the organization tab displays the current organization name in the expanded menu
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed				
	Given Sidebar drop-down menu
	When I click the sidebar drop-down menu button at the bottom of the menu
	Then The menu is expanded	
	When I verify that the current organization name is displayed in the organization tab
	Then The current organization name is displayed	

@regression
Scenario: Display the tooltip with the OrganizationName in the expanded menu by hovering over the organization tab
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed				
	Given Sidebar drop-down menu
	When I click the sidebar drop-down menu button at the bottom of the menu
	Then The menu is expanded	
	Given Hover over organization tab - expanded
	When I hover over the organization tab in the menu
	Then The tooltip with organization name is displayed	

	@regression
Scenario: Hide the tooltip with the OrganizationName in the organization tab in the expanded menu by clicking on the organization tab
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed			
	Given Sidebar drop-down menu
	When I click the sidebar drop-down menu button at the bottom of the menu
	Then The menu is expanded
	Given Hover over organization tab - expanded
	When I hover over the organization tab in the menu
	Then The tooltip with organization name is displayed		
	When I click the organization tab in the menu
	Then The tooltip with organization name is hidden

@regression
Scenario: Hide the tooltip with the OrganizationName in the organization tab in the expanded menu by moving the cursor to a different location
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed				
	Given Sidebar drop-down menu
	When I click the sidebar drop-down menu button at the bottom of the menu
	Then The menu is expanded	
	Given Hover over organization tab - expanded
	When I hover over the organization tab in the menu
	Then The tooltip with organization name is displayed			
	When I dismiss hovering over the organization tab in the menu
	Then The tooltip with organization name is hidden

@regression
Scenario: Display the tooltip with the OrganizationName again in the organization tab in the expanded menu after hiding it by moving the cursor to a different location
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed					
	Given Sidebar drop-down menu
	When I click the sidebar drop-down menu button at the bottom of the menu
	Then The menu is expanded	
	Given Hover over organization tab - expanded
	When I hover over the organization tab in the menu
	Then The tooltip with organization name is displayed					
	When I dismiss hovering over the organization tab in the menu
	Then The tooltip with organization name is hidden	
	When I hover over the organization tab in the menu
	Then The tooltip with organization name is displayed

@regression
Scenario: Display the tooltip with the OrganizationName again in the organization tab in the expanded menu after hiding it by clicking on the organization tab
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed					
	Given Sidebar drop-down menu
	When I click the sidebar drop-down menu button at the bottom of the menu
	Then The menu is expanded	
	Given Hover over organization tab - expanded
	When I hover over the organization tab in the menu
	Then The tooltip with organization name is displayed
	When I click the organization tab in the menu
	Then The tooltip with organization name is hidden
	When I dismiss hovering over the organization tab in the menu
	Then The tooltip with organization name is hidden	
	When I hover over the organization tab in the menu
	Then The tooltip with organization name is displayed