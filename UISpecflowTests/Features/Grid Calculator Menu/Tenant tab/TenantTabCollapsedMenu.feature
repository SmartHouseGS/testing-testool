@TenantTabTests @CollapsedMenu
Feature: TenantTabCollapsedMenu

A short summary of the feature

@regression
Scenario: Hide the tooltip with the TenantName in the collapsed menu by moving the cursor to a different location
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed			
	Given Hover over tenant icon - collapsed
	When I hover over the tenant icon in the menu
	Then The tenant icon is highlighted in gray and the tooltip with tenant name is displayed
	When I dismiss hovering over the tenant icon in the menu
	Then The tooltip with tenant name is hidden and the tenant icon is no longer highlighted

@regression
Scenario: Display the tooltip with the TenantName in the collapsed menu by hovering over the tenant icon
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed			
	Given Hover over tenant icon - collapsed
	When I hover over the tenant icon in the menu
	Then The tenant icon is highlighted in gray and the tooltip with tenant name is displayed

@regression
Scenario: Hide the tooltip with the TenantName and display the tooltip with the list of the available organizations and tenants by clicking on the tenant icon in the collapsed menu
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed				
	Given Hover over tenant icon - collapsed
	When I hover over the tenant icon in the menu
	Then The tenant icon is highlighted in gray and the tooltip with tenant name is displayed	
	When I click the tenant icon in the menu
	Then The tooltip TenantName is hidden and The tooltip with the list of available organizations and tenants with a checked active tenant is displayed

@regression
Scenario: Hide the tooltip with the list of the available organizations and tenants by clicking on the tenant icon in the collapsed menu
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed					
	Given Hover over tenant icon - collapsed	
	When I hover over the tenant icon in the menu	
	Then The tenant icon is highlighted in gray and the tooltip with tenant name is displayed		
	When I click the tenant icon in the menu
	Then The tooltip TenantName is hidden and The tooltip with the list of available organizations and tenants with a checked active tenant is displayed	
	When I click the tenant icon in the menu
	Then The tooltip with the list of available organizations and tenants with a checked active tenant is hidden

@regression
Scenario: Hide the tooltip with the list of the available organizations and tenants by clicking on the different location than tooltip in the collapsed menu
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed						
	Given Hover over tenant icon - collapsed	
	When I hover over the tenant icon in the menu	
	Then The tenant icon is highlighted in gray and the tooltip with tenant name is displayed			
	When I click the tenant icon in the menu
	Then The tooltip TenantName is hidden and The tooltip with the list of available organizations and tenants with a checked active tenant is displayed		
	When I click on the different location than tooltip with the list of available organizations and tenants
	Then The tooltip with the list of available organizations and tenants with a checked active tenant is hidden

@regression
Scenario: Display the tooltip with the TenantName again in the collapsed menu after hiding it by moving the cursor to a different location
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed							
	Given Hover over tenant icon - collapsed	
	When I hover over the tenant icon in the menu	
	Then The tenant icon is highlighted in gray and the tooltip with tenant name is displayed				
	When I dismiss hovering over the tenant icon in the menu
	Then The tooltip with tenant name is hidden and the tenant icon is no longer highlighted	
	Given Hover over tenant icon - collapsed	
	When I hover over the tenant icon in the menu	
	Then The tenant icon is highlighted in gray and the tooltip with tenant name is displayed	

@regression
Scenario: Display the tooltip with the TenantName again after hiding it by clicking on the tenant icon in the collapsed menu
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed								
	Given Hover over tenant icon - collapsed	
	When I hover over the tenant icon in the menu	
	Then The tenant icon is highlighted in gray and the tooltip with tenant name is displayed					
	When I click the tenant icon in the menu
	Then The tooltip TenantName is hidden and The tooltip with the list of available organizations and tenants with a checked active tenant is displayed		
	When I dismiss hovering over the tenant icon in the menu
	Then The tooltip with tenant name is hidden and the tenant icon is no longer highlighted		
	Given Hover over tenant icon - collapsed	
	When I hover over the tenant icon in the menu	
	Then The tenant icon is highlighted in gray and the tooltip with tenant name is displayed

@regression
Scenario: Display the tooltip with the list of the available organizations and tenants again after hiding it by clicking on the tenant icon in the collapsed menu
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed									
	Given Hover over tenant icon - collapsed	
	When I hover over the tenant icon in the menu	
	Then The tenant icon is highlighted in gray and the tooltip with tenant name is displayed						
	When I click the tenant icon in the menu
	Then The tooltip TenantName is hidden and The tooltip with the list of available organizations and tenants with a checked active tenant is displayed		
	When I click the tenant icon in the menu
	Then The tooltip with the list of available organizations and tenants with a checked active tenant is hidden
	When I click the tenant icon in the menu
	Then The tooltip TenantName is hidden and The tooltip with the list of available organizations and tenants with a checked active tenant is displayed	

@regression
Scenario: Display the tooltip with the list of the available organizations and tenants again after hiding it by clicking on the different location than tooltip in the collapsed menu
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed							
	Given Hover over tenant icon - collapsed	
	When I hover over the tenant icon in the menu	
	Then The tenant icon is highlighted in gray and the tooltip with tenant name is displayed				
	When I click the tenant icon in the menu
	Then The tooltip TenantName is hidden and The tooltip with the list of available organizations and tenants with a checked active tenant is displayed			
	When I click on the different location than tooltip with the list of available organizations and tenants
	Then The tooltip with the list of available organizations and tenants with a checked active tenant is hidden
	When I click the tenant icon in the menu
	Then The tooltip TenantName is hidden and The tooltip with the list of available organizations and tenants with a checked active tenant is displayed