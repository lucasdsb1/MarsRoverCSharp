Feature: Plateau

Verifica a criação de um plator.

@pdsw
Scenario: Create a plateau
	Given i have entered "5 5" into the input line on console
	When i press enter the result is processed
	Then the result should be Plator { X = 5, Y = 5 }
	
Scenario: Create a invalid plateau
	Given i have entered "5 5 " into the input line on console
	When i press enter the result is processed
	Then the result should be "Não foi possível criar o Plator!"