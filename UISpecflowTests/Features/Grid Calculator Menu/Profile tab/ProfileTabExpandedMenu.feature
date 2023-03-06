@ProfileTabTests @ExpandedMenu
Feature: ProfileTabExpandedMenu

A short summary of the feature

@regression
Scenario: Display the tooltip with the user name, email and the Log Out button in the expanded menu by clicking on the user tab
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed					
	Given Sidebar drop-down menu
	When I click the sidebar drop-down menu button at the bottom of the menu
	Then The menu is expanded
	When I hover over the user tab in the menu
	Then The user tab is highlighted in gray		
	Given Click user tab - expanded
	When I click the user tab in the menu
	Then The tooltip with the user name, email and red Log Out button is displayed

@regression
Scenario: Hide the tooltip with the user name, email and the Log Out button in the expanded menu by clicking on the user tab
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed				
	Given Sidebar drop-down menu
	When I click the sidebar drop-down menu button at the bottom of the menu
	Then The menu is expanded
	When I hover over the user tab in the menu
	Then The user tab is highlighted in gray		
	Given Click user tab - expanded
	When I click the user tab in the menu
	Then The tooltip with the user name, email and red Log Out button is displayed
	When I click the user tab in the menu
	Then The tooltip with the user name, email and red Log Out button is hidden

	@regression
Scenario: Hide the tooltip with the user name, email and the "Log Out" button in the expanded menu by clicking on the different location than tooltip
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed				
	Given Sidebar drop-down menu
	When I click the sidebar drop-down menu button at the bottom of the menu
	Then The menu is expanded
	When I hover over the user tab in the menu
	Then The user tab is highlighted in gray		
	Given Click user tab - expanded
	When I click the user tab in the menu
	Then The tooltip with the user name, email and red Log Out button is displayed
	When I click on the different location than tooltip with the user name, email and red Log Out button
	Then The tooltip with the user name, email and red Log Out button is hidden

@regression
Scenario: Display the tooltip with the user name, email and the Log Out button again in the expanded menu after hiding it by clicking on the user tab
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed				
	Given Sidebar drop-down menu
	When I click the sidebar drop-down menu button at the bottom of the menu
	Then The menu is expanded
	When I hover over the user tab in the menu
	Then The user tab is highlighted in gray		
	Given Click user tab - expanded
	When I click the user tab in the menu
	Then The tooltip with the user name, email and red Log Out button is displayed
	When I click the user tab in the menu
	Then The tooltip with the user name, email and red Log Out button is hidden
	When I click the user tab in the menu
	Then The tooltip with the user name, email and red Log Out button is displayed

	@regression
Scenario: Display the tooltip with the user name, email and the Log Out button again in the expanded menu after hiding it by clicking on the different location than tooltip
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed				
	Given Sidebar drop-down menu
	When I click the sidebar drop-down menu button at the bottom of the menu
	Then The menu is expanded
	When I hover over the user tab in the menu
	Then The user tab is highlighted in gray		
	Given Click user tab - expanded
	When I click the user tab in the menu
	Then The tooltip with the user name, email and red Log Out button is displayed
	When I click on the different location than tooltip with the user name, email and red Log Out button
	Then The tooltip with the user name, email and red Log Out button is hidden
	When I click the user tab in the menu
	Then The tooltip with the user name, email and red Log Out button is displayed
