@OrganizationTabTests @CollapsedMenu
Feature: OrganizationTabCollapsedMenu

A short summary of the feature

@regression
Scenario: Hide the tooltip with the OrganizationName in the collapsed menu by moving the cursor to a different location
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed			
	Given Hover over organization icon - collapsed
	When I hover over the organization icon in the menu
	Then The tooltip with organization name is displayed	
	When I dismiss hovering over the organization icon in the menu
	Then The tooltip with organization name is hidden

@regression
Scenario: Display the tooltip with the OrganizationName in the collapsed menu by hovering over the organization icon
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed			
	Given Hover over organization icon - collapsed
	When I hover over the organization icon in the menu
	Then The tooltip with organization name is displayed	

@regression
Scenario: Hide the tooltip with the OrganizationName in the collapsed menu by clicking on the organization icon
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed			
	Given Hover over organization icon - collapsed
	When I hover over the organization icon in the menu
	Then The tooltip with organization name is displayed	
	When I click the organization icon in the menu
	Then The tooltip with organization name is hidden

@regression
Scenario: Display the tooltip with the OrganizationName again in the collapsed menu after hiding it by clicking on the organization icon
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed				
	Given Hover over organization icon - collapsed
	When I hover over the organization icon in the menu
	Then The tooltip with organization name is displayed		
	When I click the organization icon in the menu
	Then The tooltip with organization name is hidden	
	When I dismiss hovering over the organization icon in the menu
	Then The tooltip with organization name is hidden
	When I hover over the organization icon in the menu
	Then The tooltip with organization name is displayed

@regression
Scenario: Display the tooltip with the OrganizationName again in the collapsed menu after hiding it by moving the cursor to a different location
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed				
	Given Hover over organization icon - collapsed
	When I hover over the organization icon in the menu
	Then The tooltip with organization name is displayed			
	When I dismiss hovering over the organization icon in the menu
	Then The tooltip with organization name is hidden
	When I hover over the organization icon in the menu
	Then The tooltip with organization name is displayed