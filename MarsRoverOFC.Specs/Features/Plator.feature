Feature: Plateau

Valida a criação de um plator.

@plator
Scenario: Create a valid plateau
	Given i have entered "5 5" into the input line on console
	When i press enter the result is processed
	Then the result should be Plator { X = 5, Y = 5 }

@plator	
Scenario: Create a valid plateau 1
	Given i have entered "0 0" into the input line on console
	When i press enter the result is processed
	Then the result should be Plator { X = 0, Y = 0 }

@plator
Scenario: Create a invalid plateau 1
	Given i have entered "5 5 " into the input line on console
	When i press enter the result is processed
	Then the result should be "Não foi possível criar o Plator!"

@plator
Scenario: Create a invalid plateau 2
	Given i have entered " 5 5 " into the input line on console
	When i press enter the result is processed
	Then the result should be "Não foi possível criar o Plator!"

@plator
Scenario: Create a invalid plateau 3
	Given i have entered " 5 5" into the input line on console
	When i press enter the result is processed
	Then the result should be "Não foi possível criar o Plator!"

@plator
Scenario: Create a invalid plateau 4
	Given i have entered "5" into the input line on console
	When i press enter the result is processed
	Then the result should be "Não foi possível criar o Plator!"

@plator
Scenario: Create a invalid plateau 5
	Given i have entered "A B" into the input line on console
	When i press enter the result is processed
	Then the result should be "Não foi possível criar o Plator!"

@plator
Scenario: Create a invalid plateau 6
	Given i have entered "A 5" into the input line on console
	When i press enter the result is processed
	Then the result should be "Não foi possível criar o Plator!"

@plator
Scenario: Create a invalid plateau 7
	Given i have entered "5 B" into the input line on console
	When i press enter the result is processed
	Then the result should be "Não foi possível criar o Plator!"

@plator
Scenario: Create a invalid plateau 8
	Given i have entered "" into the input line on console
	When i press enter the result is processed
	Then the result should be "Não foi possível criar o Plator!"

@plator
Scenario: Create a invalid plateau 9
	Given i have entered " " into the input line on console
	When i press enter the result is processed
	Then the result should be "Não foi possível criar o Plator!"

@plator
Scenario: Create a invalid plateau 10
	Given i have entered "-1 0" into the input line on console
	When i press enter the result is processed
	Then the result should be "Não foi possível criar o Plator!"

@plator
Scenario: Create a invalid plateau 11
	Given i have entered "-1 -1" into the input line on console
	When i press enter the result is processed
	Then the result should be "Não foi possível criar o Plator!"

@plator
Scenario: Create a invalid plateau 12
	Given i have entered "0 -1" into the input line on console
	When i press enter the result is processed
	Then the result should be "Não foi possível criar o Plator!"