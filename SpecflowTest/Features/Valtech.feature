Feature: Valtech hankerrank excercises

Scenario: Check latest news section is present on home page
	Given I am on the Valtech home page
	Then I see the latest news section

Scenario Outline: Check if the links in top navigation leads to the correct pages
	Given I am on the Valtech home page
	When I select the <menuitem> in the top navigation
	Then I should be shown the <menuitem> page with correct heading <pageheadings>
	Examples: 
	| menuitem | pageheadings |
	| ABOUT    | About        |
	| SERVICES | Services     |
	| WORK     | Work         |

Scenario: Show how many valtech offices are present on contact page
	Given I am on the Valtech home page
	When I navigate to the contact page
	Then I see x valtech offices
	
	
