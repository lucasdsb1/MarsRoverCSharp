Feature: Rover

Verificar os movimentos do Rover

@rover
Scenario: East to right
    Given direction is "E"
    When i turn "R"
    Then the result should be "S"

@rover
Scenario: North to right
    Given direction is "N"
    When i turn "R"
    Then the result should be "E"

@rover
Scenario:South to right
    Given direction is "S"
    When i turn "R"
    Then the result should be "W"
  
@rover
Scenario: West to right
    Given direction is "W"
    When i turn "R"
    Then the result should be "N"
	
@rover
Scenario: East to left
    Given direction is "E"
    When i turn "L"
    Then the result should be "N"

@rover
Scenario: North to left
    Given direction is "N"
    When i turn "L"
    Then the result should be "W"

@rover
Scenario: Nouth to left
    Given direction is "S"
    When i turn "L"
    Then the result should be "E"
  
@rover
Scenario: West to left
    Given direction is "W"
    When i turn "L"
    Then the result should be "S"