# game-design-development

## Requirement
 Construct a card game where the players will have
one meaningful and two meaningless decisions. 


## "Not-Hearthstone"
![](https://8gmwp015fo-flywheel.netdna-ssl.com/wp-content/uploads/sites/4/2014/08/WWDKMRD-Druid-v-Warrior-1024x575.jpg)


### Rules & Mechanics

#### Abilities
A player has 3 abilities:
+ an ability with no mana, once per game
+ an ability with `2 mana`, `once per turn` (class specific) - similar to Hearthstone, you either use your mana on cards or on ability
+ an ability that `consumes all mana` (all mana or all mana left ?), `once per game` (player chosen) - player saving (prolongs the game)

Why ?
+ will make the game a bit slower, especially since you have an ability that will use up all your mana and protect the opponent if you rush him too fast

#### Attack stances 
A card can be in `2 positions`, `attacking` or `defensive`:
+ For every turn that you have a card in attacking position, you will be drained of `1 mana/card`.
For a card to attack, it needs to be in attacking position. Otherwise, a defending card has to `wait a turn` to `change stance` (or `consume 2 mana` to change stance).
+ If you have more than 3 defending cards on board, all cards that will be put on the board will have to be in `attacking stance`.
+ If you keep a card in `defend` stance more than 3 turns, it will be changed automatically to attacking stance.

Obs: Regardless of stance, a card will consume mana when cast.

Some further rules:
+ minions can attack in first round only if they are in attack position (no summon sickness ?)
  + provided there are no glass cannons (eg: 2-5-1 cards - 2 mana, 5 attack, 1 health)
+ in defence, minions have taunt and can't attack
+ if you are in defence, the opponent has to attack (taunt can't be silenced)
+ stats varied by stance



Why ?
+ HS used to have strategies like `grim patron` or `face hunter`, where you will have populated the board and attack the enemy hero or cleared his board - with the extra constraints, filling the board will make impossible for you to use more secrets, spells, while also using a populating strategy
+ game should also not go into the other extreme and play fatigue; minions with big health either are removed or have slightly less health in defend

#### Minions with abilities
+ emblem - applies an effect for everything that is on the board / will be summoned to the board
+ planeswalkers - characters based on loyalty/health, gaining or losing loyalty (minor effects used for buffing, major effects cost a lot)
  + ultimates on planeswalkers aren't too often used, because most players won't have time to get to that point (or the character will be destroyed), and/or the sacrifice of the card for the ultimate won't be worth it
eg: Elspeth, Knight-Errant or Sorin, Lord of Innistrad

#### Trading ... goes without saying

#### Spells that can be activated at any moment in game


---

## Meaningful decisions:
+ the ability that consumes all mana can be chosen before the game starts, and will be powerful (like iceblock) ... you should use it wisely, because it's the most powerful ability you will have, and you use up all your mana in the process
  + using all mana, if you need a full bar, will be maybe too costly to be worth it ?

## Meaningless decisions:
+ the ability with no mana is a choose between 3 mana and draw a card or discover a card
  + in a critical moment, it may be useful, otherwise it will be used randomly by players, so it will not count

