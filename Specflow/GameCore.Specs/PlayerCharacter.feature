Feature: PlayerCharacter
	In order to play the game
	As a human player
	I want my character attributes to be correctly represented

@PlayerHealth
Scenario: Taking no damage when hit doesn't affect health
	Given I am a new player
	When I take 0 damage
	Then my health should be 100

@PlayerHealth
Scenario: Starting health is reduced when hit
	Given I am a new player
	When  I am hit by 10 damage
	Then  My health should reduce to 90

@PlayerHealth
Scenario: Taking too much damage results in player's death
	Given I am a new player
	When I am hit by 10 damage 
	And  I am hit by 90 damage
	Then My health should reduce to 0
	And  I should be dead
