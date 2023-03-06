@LogoAndGridCalculatorTabTests @ExpandedMenu
Feature: LogoAndGridCalculatorTabExpandedMenu

A short summary of the feature

@regression
Scenario: Verify that after clicking the Volue logo the Grid Calculator page is refreshed in the expanded menu
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed				
	Given Sidebar drop-down menu
	When I click the sidebar drop-down menu button at the bottom of the menu
	Then The menu is expanded	
	When I click on the Grid Calculator tab at the top of the menu
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed

	@regression
Scenario: Verify that after changing the tenant and then clicking the Grid Calculator tab, the Grid Calculator page is refreshed in the expanded menu
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed		
	Given Sidebar drop-down menu
	When I click the sidebar drop-down menu button at the bottom of the menu
	Then The menu is expanded
	Given Second tenant - expanded
	When I click the tenant tab in the menu
	Then The tooltip with the list of available organizations and tenants with a checked active tenant "nsa_dev" is displayed
	When I Hover over the second tenant from the list
	Then The hovering over tenant is highlighted in green
	When I click the second tenant "Grid Calculator Demo" from the list
	Then The page may display the message "Loading map configuration" for a few seconds, 
	And The Grid Calculator application is displayed but without power grid objects on the map
	When I verify that the current "Grid Calculator Demo" tenant name is displayed
	Then The current tenant name "Grid Calculator Demo" is displayed
	When I click on the Grid Calculator tab at the top of the menu
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed		
	When I click the tenant icon in the menu
	Then The tooltip with the list of available organizations and tenants with a checked active tenant "nsa_dev" is displayed

@regression
Scenario: Verify that after clicking on one of the power grid object on the map and displaying the Select asset pop-up window and then clicking the Grid Calculator tab, the Grid Calculator page is refreshed in the expanded menu
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed	
	Given Sidebar drop-down menu
	When I click the sidebar drop-down menu button at the bottom of the menu
	Then The menu is expanded
	Given Click one of the power grid objects - expanded
	When I click one of the power grid objects 
	Then The "Searching for assets" is displayed for a few seconds, then the "Select asset" pop-up window is displayed in the upper left corner of page	
	When I click on the Grid Calculator tab at the top of the menu
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed

@regression
Scenario: Verify that after selecting one of the power grid objects and displaying the pop-up window with information about it and then clicking the Grid Calculator tab, the Grid Calculator page is refreshed in the expanded menu
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed	
	Given Sidebar drop-down menu
	When I click the sidebar drop-down menu button at the bottom of the menu
	Then The menu is expanded
	Given Click one of the power grid objects - expanded
	When I click one of the power grid objects 
	Then The "Searching for assets" is displayed for a few seconds, then the "Select asset" pop-up window is displayed in the upper left corner of page		
	Given Select one of the power object - expanded
	When I Select one of the power grid objects from the list
    Then The selected power grid object information is displayed in the pop-up window	
	When I click on the Grid Calculator tab at the top of the menu
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed

@regression @repair
Scenario: Verify that after selecting one power transformer that has the required data for the calculation and running calculation and then clicking the Grid Calculator tab, the Grid Calculator page is refreshed in the expanded menu
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed	
	Given Sidebar drop-down menu
	When I click the sidebar drop-down menu button at the bottom of the menu
	Then The menu is expanded	
	#made 3 tests instead of table in design
	Given Find and zoom power transformer on map
	When I find on the map the place where right PowerTransformers that has the required data for the calculation is located
	| Key | Value                         |
	| 1	  | Ringgata 70, Hamar, Norway    |
	| 2   | Vangsvegen 143, Hamar, Norway |
	| 3   | Brugata 41, Hamar, Norway     |
	Then The power transformers is found	
	When I Zoom in on the area where the PowerTransformer that has the required data for calculation is located
	#TODO: redesign zooming
	Then The area is zoomed in
	Given Calculation for one of the PowerTransformers
	When I click on the dot in the center of the substation that is the power transformer that has the required data for the calculation
	And Have one of the names
	| Key | Value                   |
	| 1	  | ENS00383 TRF T1 TRAFO   |
	| 2   | ENS04633 TRF T1 TRAFO   |
	| 3   | ENS09636 TRF T1 TRAFO   |
	And Have Asset Group "Asset Group: Medium voltage 2 winding power transformer"
    Then The "Searching for assets" is displayed for a few seconds, then the "Select asset" pop-up window is displayed in the upper left corner of page	
	When I Select the electric network device
	And  I Select the "Medium voltage 2 winding power transformer"
	Then The power transformer that has the required data for the calculation is displayed in the pop-up window 
	When I click on the green Run Tactic button
	Then The green Run Tactic button is changed to the gray Running tactic button	
	When I wait until the gray Running tactic button is changed to the green Run Tactic button
	Then The pop-up window is extended with the Result of Tactic list
	And Subnetwork is highlighted in turquoise
	And Red Energy Consumers points for which the calculation results do not follow the rules of Tactic are displayed
	And Orange Energy Consumers points for which the calculation results almost do not follow the rules of Tactic by warning are displayed
	And Green Energy Consumers points for which the calculation results follow the rules of Tactic are displayed
	When I click on the Grid Calculator tab at the top of the menu
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed

	@regression
Scenario: Verify that after changing the zoom and position and then clicking the Grid Calculator tab, the Grid Calculator page is refreshed in the expanded menu
	Given I navigate to GC application
	When I Open the Grid Calculator application
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed		
	Given Sidebar drop-down menu
	When I click the sidebar drop-down menu button at the bottom of the menu
	Then The menu is expanded
	When I zoom in and out on the area on map using plus and minus buttons located in the lower right corner of page
	#TODO: redesign zooming
	Then The area is zoomed in
	When I change position on the map using gesture on map 
	#TODO: redesign positioning
	Then The position of area is changed	
	When I click on the Grid Calculator tab at the top of the menu
	Then The page displays the messages "Authenticating" and/or "Loading map configuration" for a few seconds, then the Grid Calculator application is displayed


	#TODO: test show all checkbox
	#TODO: click zoom in/out dont popup window