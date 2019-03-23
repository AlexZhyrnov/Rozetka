Feature: Search
	As a user
	I want to use search feature
	In order to find a product by its name


Background:
	Given I am on Rozetka 'Main' page


Scenario Outline: Search product in search bar
	When I search for '<searchText>' in search bar
	Then I see only products that I searched for
	And  Button 'Показать еще 32 товара' is displayed
Examples:
	| searchText |
	| Hyundai    |
	| LG         |
