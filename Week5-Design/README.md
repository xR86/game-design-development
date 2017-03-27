# game-design-development

## Requirement
Design a card game for two players:
– the second player will have the role of the „system”
– the difficulty of the game adjusts with the
progression of the first player
– Playtest! Take notes on the experience.
Present in front of the class, explaining if you succeded
to create a state of flow for the first player. (2 min)

## Siege (inspired by Gwent)

Second player is in defense, protecting a castle. Castle has a number of hitpoints.

```
------------
System
Hitpoints: 1000
____  ____
|___| |___|
defending cards

--
no man's land
--

___   ___
|  |  |  |
|__|  |__|
attacking cards

Player
------------
```
> How the board should look

### Card asignment
This game uses the standard [52-card deck](https://en.wikipedia.org/wiki/Standard_52-card_deck).

Is the game using 2 card set, or just one ?
Are the cards assigned randomly, or split into subsets ?

### Naming cards

Jack/Queen/King are siege cards
Ace is hero

2-10 are foot soldiers (swordsmen / archers):
+ any card can be swordsmen / archer - or just color-based cards
+ number indicates health/morale/experience ... ?


### Rules
+ win conditions:
  + player loses when no attacking cards are left / all att cards are destroyed / morale is used
  + system loses when hitpoints have been reduced to 0
+ rock-paper-scissor:
  + archer in defense beats attacking swordsman (reverse is true)
  + siege in defense beats attacking ... ?
  + siege in attack beats defending archer
  + swordsman in attack beats defending swordsman if force(numbers)/morale(hero+health) is higher






