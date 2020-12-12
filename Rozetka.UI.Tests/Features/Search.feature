@UI
@Rozetka
@Search

Feature: Search
	As a Rozetka user
	I want to use Search
	In order to find products

Background:
	Given I am on page Rozetka

Scenario Outline: Search products in search bar
	When I search '<searchText>' in search bar
	Then Results show only products with '<searchText>' name
	Then Button with text 'Показать еще 36 товаров' is displayed
Examples:
	| searchText |
	| LG         |
	| Meizu      |
