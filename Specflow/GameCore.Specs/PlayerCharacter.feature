Feature: PlayerCharacter
	In order to play the game
	As a human player
	I want my character attributes to be correctly represented

Background: 
	Given I am a new player


@PlayerHealth
Scenario Outline: Health Reduction
	When I take <damage> damage
	Then My health should be <health>
	Examples: 
	| damage | health |
	|     0  |     100|
	|     10 |     90 |

@PlayerHealth
Scenario: Taking too much damage results in player's death
	When I take 10 damage 
		And  I take 90 damage
	Then My health should be 0
	And  I should be dead

@Elf
Scenario: Impact of Initial resistance and race on health
		And I have an initial resistace of 10
		And I am of Race  Elf
	When I take 40 damage
	Then My health should be 90

@Elf
Scenario Outline: Impact of Initial resistance and race on health using data table
		And I have following attributes
		| attribute | value |
		| resistance | 10    |
		| race       | Elf   |
	When I take <damage> damage
	Then My health should be <health>
		Examples: 
		| damage | health |
		|     40 |     90 |
		|     10 |     100|


@PlayerHealth @LastSlept
Scenario: Impact of sleep on health
	Given I last slept 3 days ago
	When I take 1 damage
	Then My health should be 0


Scenario: Total value of Weapons
	Given I have following weapons
		| Name   | Value |
		| Sword  | 50    |
		| Hammer | 60    |
		| Gun    | 100   |
	Then  Total value of weapons should be 210

Scenario: Initial Health value
	Given My current health is 50
	When I take 20 damage
	 Then My health should be 30

@Elf
Scenario: Take damage for elves
	When I take 20 damage
	Then My health should be 80
	
