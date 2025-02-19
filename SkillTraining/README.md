# Overview

This is a mod for [Caves of Qud](https://www.cavesofqud.com) that allows unlocking basic skills through practical training, rather than spending skill points.

The main goal of this mod is to add a little bit of realism and some benefit to engaging with aspects of the game that aren't part of your build trajectory.

## Mod menu

Wish (`Ctrl+W` by default) for `SkillTraining` to display the mod's main menu, where you can:
* See and modify training point progress for each trainable skill.
* Unlearn known skills, with or without refunding the skill points.

# Details

* In-game actions that train certain skills increase a special training point value every time they are performed. When the training point value reaches or exceeds the cost of the corresponding skill, that skill is automatically unlocked.
  * If the skill has an attribute requirement, it won't be unlocked until that requirement is met and  another training event has occured after that.
* (Most) training targets "base" skills that unlock a whole skill category (including the initial 0-point skill, if present).
  * There is no training for [Acrobatics](https://wiki.cavesofqud.com/wiki/Acrobatics), [Endurance](https://wiki.cavesofqud.com/wiki/Endurance), [Self-discipline](https://wiki.cavesofqud.com/wiki/Self-discipline) and [Tactics](https://wiki.cavesofqud.com/wiki/Tactics) trees; only individual skills [Swimming](https://wiki.cavesofqud.com/wiki/Swimming) and [Deft Throwing](https://wiki.cavesofqud.com/wiki/Deft_Throwing) can be trained.
* Skill points and training points are completely independent of each other. Training a skill does not make it cheaper to purchase with points, nor does spending skill points affect the practical training in any other skill.


## Melee combat

Using melee weapons in combat trains their corresponding skills ([Axe](https://wiki.cavesofqud.com/wiki/Axe), [Cudgel](https://wiki.cavesofqud.com/wiki/Cudgel), [Short Blade](https://wiki.cavesofqud.com/wiki/Short_Blade) or [Long Blade](https://wiki.cavesofqud.com/wiki/Long_Blade)).

Training points are earned for each attack where all the following are true:
* The target is successfully hit (with or without damage).
* The target is a creature other than player (attacking walls or yourself doesn't count).
* The weapon is an equipped item (no natural weapons like fists or claws).
* The attacking weapon has an associated skill to train (whips will not train anything).

Training amount gets a bonus on critical hits, and a penalty for offhand weapons.

### Single/multi weapon fighting

* If the attacking weapon is the only one equipped, [Single Weapon Fighting](https://wiki.cavesofqud.com/wiki/Single_Weapon_Fighting) will also be trained.
* If the attacking weapon is equipped in an off-hand, it will train [Multiweapon Fighting](https://wiki.cavesofqud.com/wiki/Multiweapon_Fighting).

Single/Multiweapon skill training doesn't benefit from the critical hit bonus.


## Missile weapon combat

Using missile weapons in combat trains the corresponding skills ([Bow and Rifle](https://wiki.cavesofqud.com/wiki/Bow_and_Rifle), [Heavy Weapon](https://wiki.cavesofqud.com/wiki/Heavy_Weapon), or [Pistol](https://wiki.cavesofqud.com/wiki/Pistol)).

Training points are earned for each attack where all the following are true:
* The target is successfully hit (with or without damage).
* The target is a creature other than player (attacking walls or yourself doesn't count).
* The target is the one originally aimed at (hitting something else by accident or through bullet spread doesn't count).


## Cooking and Gathering

Cooking meals, harvesting plants and butchering corpses all train the [Cooking and Gathering](https://wiki.cavesofqud.com/wiki/Cooking_and_Gathering) skill.

Harvesting has an exceedingly low training value (you'd need thousands of plants to unlock the skill just by harvesting), butchering is only mildly better (around a thousand corpses). Most training is earned through cooking meals at campfires (around 300 meals until a skill unlock), and "tasty" meals earn double points.


## Customs and Folklore

[Customs and Folklore](https://wiki.cavesofqud.com/wiki/Customs_and_Folklore) is trained when your reputation changes during a water ritual, and whenever you discover a secret (no matter how).

The reputation gain from the very first water ritual with a creature earns bonus training.     


## Deft Throwing

Successfully hitting an enemy with a thrown weapon trains [Deft Throwing](https://wiki.cavesofqud.com/wiki/Deft_Throwing) skill.

Training increases every time you throw something at an enemy, if all the following are true:
* The target is successfully hit (with or without damage).
* The target is a creature (throwing at walls and trees doesn't count).
* The target is the one originally aimed at (hitting something else by accident or through bullet spread doesn't count).

Note that this is an individual skill, rather than a skill tree -- unlocking it will not unlock [Tactics](https://wiki.cavesofqud.com/wiki/Tactics).


## Physic

Successfully applying bandages to bleeding wounds trains [Physic](https://wiki.cavesofqud.com/wiki/Physic) skill.


## Shield

Blocking an attack with a shield trains the [Shield](https://wiki.cavesofqud.com/wiki/Shield) skill.


## Swimming

Swimming in deep water automatically trains [Swimming](https://wiki.cavesofqud.com/wiki/Swimming) skill.

Note that this is an individual skill, rather than a skill tree -- unlocking it will not unlock [Endurance](https://wiki.cavesofqud.com/wiki/Endurance).


## Snake Oiler

[Snake Oiler](https://wiki.cavesofqud.com/wiki/Snake_Oiler) is trained by selling items worth $1 or more.
* The amount of training points earned is affected by the [base value](https://wiki.cavesofqud.com/wiki/Commerce) of items sold.

Note that this is an individual skill, rather than a skill tree -- unlocking it will not unlock [Persuasion](https://wiki.cavesofqud.com/wiki/Persuasion).


## Tinkering

Successfully examining artifacts trains [Tinkering](https://wiki.cavesofqud.com/wiki/Tinkering) skill.


## Wayfaring

[Wayfaring](https://wiki.cavesofqud.com/wiki/Wayfaring) skill is trained whenever you take a step on the world map.
* Rougher terrain trains the skill faster (based on how many turns it takes to travel across it).
* Getting lost and then regaining your bearings gives a big training boost. 