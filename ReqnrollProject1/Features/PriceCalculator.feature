Feature: Price calculator

Simple BDD scenarios for the BusCompany.PriceCalculator

@price
Scenario: Price for distance 0
	Given a distance of 0
	When the price is calculated
	Then the price should be 2500

@price
Scenario: Price for distance 1
	Given a distance of 1
	When the price is calculated
	Then the price should be 2510

@price
Scenario: Price for distance 100
	Given a distance of 100
	When the price is calculated
	Then the price should be 3498

@price
Scenario: Price for distance 501
	Given a distance of 501
	When the price is calculated
	Then the price should be 6704

@price
Scenario: Negative distance throws
	Given a distance of -1
	When the price is calculated
	Then an argument exception should be thrown
