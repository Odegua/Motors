Feature: CustomerCanViewPrice
	In order to know the cost of a car 
	As a customer 
	I want the ability to view car price 

Scenario: Customer can view the cost of a car
	Given I navigate to Motors homepage
	When enter postcode and I select the make of the car 
	And I select the model of the car
	And I click on the search button
	And I click the first car from the result
	Then the price of the car is displayed

	Scenario: Customer can view the image of a car
	Given I navigate to Motors homepage
	When enter postcode and I select the make of the car 
	And I select the model of the car
	And I click on the search button
	And I click the first car from the result
	Then the price of the car is displayed
