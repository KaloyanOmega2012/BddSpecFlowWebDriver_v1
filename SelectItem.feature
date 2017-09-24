Feature: SelectItem
	In order to select an item
	As a user
	I want to be able to find it by its title

@mytag
Scenario: Find item by its title
	Given I am on amazon home page
	And I have entered item name inside searchbar
	When I press search button inside searchbar
	Then then the item is found
	And it should be on first position inside items collection
	And It has a badge “Best Seller”
	And Selected type is Paperback
	And And the price is £3.99

