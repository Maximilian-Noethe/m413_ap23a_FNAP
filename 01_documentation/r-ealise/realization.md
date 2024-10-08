## Table of contents

* [Realization](#realization)
* [Player](#player)
* [First enemy](#first-enemy)
* [Template map](#template-map)
* [Unity project](#unity-project)
* [Designing the map](#designing-the-map)
* [Artificial inteligence](#artificial-inteligence)
* [Functions](#functions)
* [Collectables](#collectables)
* [HUD](#hud)
* [Jumpscare](#jumpscare)
* [Sounds](#sounds)
* [Saving](#saving)
* [Source](#source)



## Realization

The project's realization has now begun. First, we had to decide what to do. My plan was to create the 3D models for the player, the map, and one opponent first. What we had to download for the project was: Unity, Blender and VS Code.

## Player
First off, the player.
Naturally, we use Blender because it is the best free 3D modeling application available. We began with a capsule. Afterwards we will add arms, a mask, and a flashlight. We began with the arms, which we had to adjust later in the process because of a problem we will describe later.

![01_01](https://github.com/Maximilian-Noethe/m413_ap23a_FNAP/blob/main/01_documentation/Screenshots/01_01.png)

We proceed by adding each minor detail. We also added the flashlight, once we had the arms, which consists of a cylinder and a spotlight probe. We particularly like the effect that the spotlight probe gives the flashlight. It almost looks like a beam. The Mask is made up of some iso-spheres and two toruses. All lined up appear to a mask and voila you have got your player.

![01_02](https://github.com/Maximilian-Noethe/m413_ap23a_FNAP/blob/main/01_documentation/Screenshots/01_02.png)

## First enemy
Now to the enemy.
The enemy was supposed to resemble the banana skin from Fortnite, but with a more terrifying gimmick. We began with an iso-sphere and bent it into a banana or moon form. 

![02_01](https://github.com/Maximilian-Noethe/m413_ap23a_FNAP/blob/main/01_documentation/Screenshots/02_01.png)

The eyes, which contain a light in the center to make them appear shiny were up next. Then we added some arms, two feet, and a stem to give it a banana look. the mouth came next. We started by half-circling an iso-sphere and painting it black.

![02_02](https://github.com/Maximilian-Noethe/m413_ap23a_FNAP/blob/main/01_documentation/Screenshots/02_02.png)

A material can be used to give objects texture.

![02_03](https://github.com/Maximilian-Noethe/m413_ap23a_FNAP/blob/main/01_documentation/Screenshots/02_03.png)

After that, we added some teeth-spikes. And here you have your enemy.

## Template map
Making the map took a very long time.
A plane served as the foundation when we first got started. We then created a sketch in MS Paint that looked like this.

![03_01](https://github.com/Maximilian-Noethe/m413_ap23a_FNAP/blob/main/01_documentation/Screenshots/03_01.png)

After the boys and we reached a decision to act on this sketch, we began to develop the map. It had to be quite accurate. The xyz compass proved useful in this regard. In order to make the template map, which had only walls and a floor and no other colors or interior objects, each room's walls had to be drawn first. 

![03_02](https://github.com/Maximilian-Noethe/m413_ap23a_FNAP/blob/main/01_documentation/Screenshots/03_02.png)

## Unity project
We began the Unity project with this.
We started by adding the player and the sample map. We gave both the necessary finishing touches. Now, thanks to the boxcollider, we have a still bean that isn't falling through the floor.

![04_01](https://github.com/Maximilian-Noethe/m413_ap23a_FNAP/blob/main/01_documentation/Screenshots/04_01.png)

The initial code, which dealt with player movement, was about to start. We looked up where to get a movement code and soon discovered it. We copied the code into a new C# script that we had created. The player was functional yet odd. We got rid of the arms and made the rest of the body move in sync with the camera, it looked awesome. This is the before and after.

https://github.com/Maximilian-Noethe/m413_ap23a_FNAP/assets/142780585/51ed717a-dd79-41d1-afb2-3327cef6f2c6

It was now time to complete the map.

## Designing the map
We started giving the floor and walls textures.
After that, we designed the interior, including the playroom, the kitchen, the stage, and some tables that we downloaded off the internet. Of these, the playroom is what we am most proud of. The second story is meant to resemble a playground from the mall. Additionally, there is a hidden room, which will be covered in the paperwork later. We'll import it into the game now that everything is set up. The rooms we have are the main hall, the playroom, the secret room, the stage, the kitchen, the corridor, the office, and the staff room.

![05_01](https://github.com/Maximilian-Noethe/m413_ap23a_FNAP/blob/main/01_documentation/Screenshots/05_01.png)

## Artificial inteligence
The enemy's AI will be coded as the next step.
We looked up how to add a following system to an object on YouTube and found a few tutorials that together helped me do the task. We had to download an AI asset, which gave me a ton of brand-new features and elements. It was really useful to have the navigation mesh agent and obstacle components. 

![06_03](https://github.com/Maximilian-Noethe/m413_ap23a_FNAP/blob/main/01_documentation/Screenshots/06_03.png)

The object you want to move gets the agent added, and the things that are obviously impediments get the obstacle added. You can decide if the obstacles are walkable at that point. 

![06_01](https://github.com/Maximilian-Noethe/m413_ap23a_FNAP/blob/main/01_documentation/Screenshots/06_01.png)

If not, the program must discover the quickest path around them. After making all of your preferred selections, you can bake the software, which will then show you where the opponent can and cannot move.

![06_02](https://github.com/Maximilian-Noethe/m413_ap23a_FNAP/blob/main/01_documentation/Screenshots/06_02.png)

Additionally, we had to write one line of code, possibly two. Everything was successfully imported into our game, and the player is now being pursued.

## Functions
Now we added the functions for the mask and the flashlight.
We started with the flashlight. We had to plan how we would implement it kind off like a flowchart but we had no idea how we would do it with c#. So my idea was to write it kind off in the language c and gave it to chatgpt which convertet the code into c#. Afterwards we added the code and started it. What happened was, we wouldnt work. We tried it several times and it just couldnt work. After a quick reasearch on youtube, we got the anwser which was the keybinds werent ajusted. So we ajusted the keybinds and it work.

![07_01](https://github.com/Maximilian-Noethe/m413_ap23a_FNAP/blob/main/01_documentation/Screenshots/07_01.png)

Next was the mask. We already designed it so it wasnt a big deal. The code was very simular to the flashlight code but we had problems with editing the code for the AI enemy. Why? You may ask. The problem was they had to stop following me, when we put on the mask. But as always uncle gpt was here to help me with this problem. Of course it worked out. Now we have alot of functions and playable features.

## Collectables
Then we moved on to the collectables. 
Designing them was not that difficult. They were just cylinders of various sizes.

![08_01](https://github.com/Maximilian-Noethe/m413_ap23a_FNAP/blob/main/01_documentation/Screenshots/08_01.png)

After you gather all the collectables during the game, we created a code that raised a wall which led to the secret room. The final enemy and the escape key are located in the secret room. For the little cherry on the top of the cake we decided to add a sparkling effect to them so that they appear more.

![08_02](https://github.com/Maximilian-Noethe/m413_ap23a_FNAP/blob/main/01_documentation/Screenshots/08_02.png)

## HUD
Next thing was adding the HUD to the game. We had to get a picture of a needle and added a counter next to it so you can see how many needles you have already collected. We also added the batteryprocentage and with that the funktion to make the flashlight slowly fade away and make the intensity smaller. It functions reallz well and im very proud of myself.

![09_021](https://github.com/Maximilian-Noethe/m413_ap23a_FNAP/blob/main/01_documentation/Screenshots/09_01.png)

## Jumpscare

Now was the time for jumpscares. What we did, was to if the player gets caught by the enemy, that he will be teleported to the jumpscare sceen. It looks like this.

https://github.com/Maximilian-Noethe/m413_ap23a_FNAP/assets/142780585/fd6d2a77-b5ed-45fd-8889-383ebb34ed71

## Sounds

The sounds were the final element we added to the game. Given our time constraints, we had doubted we would be able to implement this feature, but now that it is here, the sounds are functional. It looks excellent since we added a Jumpscare sound that we stole from FNAF 2 (We gave credit though). There is a YAY sound that plays if you win; We are not sure from which FNAF game it is tho. We also included some other sounds, like a cemetery sound that permeates the entire area and spooks everyone. A sound that sounds like a broken music box is playing in the playroom, giving the impression that it's a haunted place. More easter eggs can be found throughout the map, but we want you to solve them on your own.

## Saving

Everything was saved differently by us. We saved the code, for instance, in the vscode timeline. You can view your safes in code by going back in time using the timeline. We downloaded the game's assets and saved them to the cloud after making some significant changes. Because of that, our project was secure, and we could have returned to the last checkpoint if something had gone wrong.

## Source

*Text corrected by: Quillbot.*
*Text writen by: Karol Krawiec.*
