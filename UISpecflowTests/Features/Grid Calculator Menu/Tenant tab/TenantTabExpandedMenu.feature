@TenantTabTests @ExpandedMenu
Feature: TenantTabExpandedMenu

A short summary of the feature

@regression
Scenario: Hide the tooltip with the TenantName in the expanded menu by moving the cursor to a different location
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed				
	Given Sidebar drop-down menu
	When I click the sidebar drop-down menu button at the bottom of the menu
	Then The menu is expanded	
	Given Hover over tenant tab - expanded
	When I hover over the tenant tab in the menu
	Then The tenant tab is highlighted in gray and the tooltip with tenant name is displayed	
	When I dismiss hovering over the tenant tab in the menu
	Then The tooltip with tenant name is hidden and the tenant tab is no longer highlighted

@regression
Scenario: Display the tooltip with the TenantName in the expanded menu by hovering over the tenant tab
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed				
	Given Sidebar drop-down menu
	When I click the sidebar drop-down menu button at the bottom of the menu
	Then The menu is expanded	
	Given Hover over tenant tab - expanded
	When I hover over the tenant tab in the menu
	Then The tenant tab is highlighted in gray and the tooltip with tenant name is displayed

@regression
Scenario: Hide the tooltip with the TenantName and display the tooltip with the list of the available organizations and tenants by clicking on the tenant tab in the expanded menu
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed				
	Given Sidebar drop-down menu
	When I click the sidebar drop-down menu button at the bottom of the menu
	Then The menu is expanded	
	Given Hover over tenant tab - expanded
	When I hover over the tenant tab in the menu
	Then The tenant tab is highlighted in gray and the tooltip with tenant name is displayed	
	When I click the tenant tab in the menu
	Then The tooltip TenantName is hidden and The tooltip with the list of available organizations and tenants with a checked active tenant is displayed

@regression
Scenario: Verify that the tenant tab displays the current tenant name and it is the same tenant like in the tootip in the expanded menu
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed				
	Given Sidebar drop-down menu
	When I click the sidebar drop-down menu button at the bottom of the menu
	Then The menu is expanded	
	When I verify that the current tenant name is displayed in the tenant tab
	Then The current tenant name is displayed		
	When I click the tenant tab in the menu
	Then The tooltip TenantName is hidden and The tooltip with the list of available organizations and tenants with a checked active tenant is displayed
	And The same tenant as in the tenant tab is displayed

@regression
Scenario: Hide the tooltip with the list of the available organizations and tenants by clicking on the tenant tab in the expanded menu
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed				
	Given Sidebar drop-down menu
	When I click the sidebar drop-down menu button at the bottom of the menu
	Then The menu is expanded	
	Given Hover over tenant tab - expanded
	When I hover over the tenant tab in the menu
	Then The tenant tab is highlighted in gray and the tooltip with tenant name is displayed	
	When I click the tenant tab in the menu
	Then The tooltip TenantName is hidden and The tooltip with the list of available organizations and tenants with a checked active tenant is displayed
	When I click the tenant tab in the menu
	Then The tooltip with the list of available organizations and tenants with a checked active tenant is hidden

@regression
Scenario: Hide the tooltip with the list of the available organizations and tenants by clicking on the different location than tooltip in the expanded menu
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed				
	Given Sidebar drop-down menu
	When I click the sidebar drop-down menu button at the bottom of the menu
	Then The menu is expanded	
	Given Hover over tenant tab - expanded
	When I hover over the tenant tab in the menu
	Then The tenant tab is highlighted in gray and the tooltip with tenant name is displayed	
	When I click the tenant tab in the menu
	Then The tooltip TenantName is hidden and The tooltip with the list of available organizations and tenants with a checked active tenant is displayed
	When I click on the different location than tooltip with the list of available organizations and tenants
	Then The tooltip with the list of available organizations and tenants with a checked active tenant is hidden

@regression
Scenario: Display the tooltip with the TenantName in the expanded menu again after hiding it by moving the cursor to a different location
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed				
	Given Sidebar drop-down menu
	When I click the sidebar drop-down menu button at the bottom of the menu
	Then The menu is expanded	
	Given Hover over tenant tab - expanded
	When I hover over the tenant tab in the menu
	Then The tenant tab is highlighted in gray and the tooltip with tenant name is displayed	
	When I dismiss hovering over the tenant tab in the menu
	Then The tooltip with tenant name is hidden and the tenant tab is no longer highlighted
	When I hover over the tenant tab in the menu
	Then The tenant tab is highlighted in gray and the tooltip with tenant name is displayed

@regression
Scenario: Display the tooltip with the TenantName again after hiding it by clicking on the tenant tab in the expanded menu
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed				
	Given Sidebar drop-down menu
	When I click the sidebar drop-down menu button at the bottom of the menu
	Then The menu is expanded	
	Given Hover over tenant tab - expanded
	When I hover over the tenant tab in the menu
	Then The tenant tab is highlighted in gray and the tooltip with tenant name is displayed	
	When I click the tenant tab in the menu
	Then The tooltip TenantName is hidden and The tooltip with the list of available organizations and tenants with a checked active tenant is displayed
	When I dismiss hovering over the tenant tab in the menu
	Then The tooltip with tenant name is hidden and the tenant tab is no longer highlighted
	When I hover over the tenant tab in the menu
	Then The tenant tab is highlighted in gray and the tooltip with tenant name is displayed

@regression
Scenario: Display the tooltip with the list of the available organizations and tenants again after hiding it by clicking on the tenant tab in the expanded menu
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed				
	Given Sidebar drop-down menu
	When I click the sidebar drop-down menu button at the bottom of the menu
	Then The menu is expanded	
	Given Hover over tenant tab - expanded
	When I hover over the tenant tab in the menu
	Then The tenant tab is highlighted in gray and the tooltip with tenant name is displayed	
	When I click the tenant tab in the menu
	Then The tooltip TenantName is hidden and The tooltip with the list of available organizations and tenants with a checked active tenant is displayed
	When I click the tenant tab in the menu
	Then The tooltip with the list of available organizations and tenants with a checked active tenant is hidden
	When I click the tenant tab in the menu
	Then The tooltip TenantName is hidden and The tooltip with the list of available organizations and tenants with a checked active tenant is displayed

@regression
Scenario: Display the tooltip with the list of the available organizations and tenants again after hiding it by clicking on the different location than tooltip in the expanded menu
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed				
	Given Sidebar drop-down menu
	When I click the sidebar drop-down menu button at the bottom of the menu
	Then The menu is expanded	
	Given Hover over tenant tab - expanded
	When I hover over the tenant tab in the menu
	Then The tenant tab is highlighted in gray and the tooltip with tenant name is displayed	
	When I click the tenant tab in the menu
	Then The tooltip TenantName is hidden and The tooltip with the list of available organizations and tenants with a checked active tenant is displayed
	When I click on the different location than tooltip with the list of available organizations and tenants
	Then The tooltip with the list of available organizations and tenants with a checked active tenant is hidden
	When I click the tenant tab in the menu
	Then The tooltip TenantName is hidden and The tooltip with the list of available organizations and tenants with a checked active tenant is displayed