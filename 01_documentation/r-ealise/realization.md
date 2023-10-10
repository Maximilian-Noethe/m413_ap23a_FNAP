## Realization

The project's realization has now begun. First, we had to decide what to do. My plan was to create the 3D models for the player, the map, and one opponent first. 

## Player
First off, the player.
Naturally, we use Blender because it is the best free 3D modeling application available. I began with a capsule. Afterwards I will add arms, a mask, and a flashlight. I began with the arms, which I had to adjust later in the process because of a problem I'll describe later.

![01_01](https://github.com/Maximilian-Noethe/m413_ap23a_FNAP/blob/main/01_documentation/Screenshots/01_01.png)

I proceed by adding each minor detail. I also added the flashlight, once I had the arms, which consists of a cylinder and a spotlight probe. I particularly like the effect that the spotlight probe gives the flashlight. It almost looks like a beam. The Mask is made up of some iso-spheres and two toruses. all lined up appear to a mask and voila you have got your player.

![01_02](https://github.com/Maximilian-Noethe/m413_ap23a_FNAP/blob/main/01_documentation/Screenshots/01_02.png)

## First enemy
Now to the enemy.
The enemy was supposed to resemble the banana skin from Fortnite, but with a more terrifying gimmick. I began with an iso-sphere and bent it into a banana or moon form. 

![02_01](https://github.com/Maximilian-Noethe/m413_ap23a_FNAP/blob/main/01_documentation/Screenshots/02_01.png)

The eyes, which contain a light in the center to make them appear shiny were up next. Then I added some arms, two feet, and a stem to give it a banana look. the mouth came next. I started by half-circling an iso-sphere and painting it black.

![02_02](https://github.com/Maximilian-Noethe/m413_ap23a_FNAP/blob/main/01_documentation/Screenshots/02_02.png)

A material can be used to give objects texture.

![02_03](https://github.com/Maximilian-Noethe/m413_ap23a_FNAP/blob/main/01_documentation/Screenshots/02_03.png)

After that, I added some teeth-spikes. And here you have your enemy.

## Template map
Making the map took a very long time.
A plane served as the foundation when I first got started. I then created a sketch in MS Paint that looked like this.

![03_01](https://github.com/Maximilian-Noethe/m413_ap23a_FNAP/blob/main/01_documentation/Screenshots/03_01.png)

After the boys and I reached a decision to act on this sketch, I began to develop the map. It had to be quite accurate. The xyz compass proved useful in this regard. In order to make the template map, which had only walls and a floor and no other colors or interior objects, each room's walls had to be drawn first. 

![03_02](https://github.com/Maximilian-Noethe/m413_ap23a_FNAP/blob/main/01_documentation/Screenshots/03_02.png)

## Unity project
I began the Unity project with this.
I started by adding the player and the sample map. I gave both the necessary finishing touches. Now, thanks to the boxcollider, we have a still bean that isn't falling through the floor.

![04_01](https://github.com/Maximilian-Noethe/m413_ap23a_FNAP/blob/main/01_documentation/Screenshots/04_01.png)

The initial code, which dealt with player movement, was about to start. I looked up where to get a movement code and soon discovered it. I copied the code into a new C# script that I had created. The player was functional yet odd. I got rid of the arms and made the rest of the body move in sync with the camera, it looked awesome. This is the before and after.

[![04_02]()](https://github.com/Maximilian-Noethe/m413_ap23a_FNAP/blob/main/01_documentation/Screenshots/04_02.png)


https://github.com/Maximilian-Noethe/m413_ap23a_FNAP/assets/142780585/51ed717a-dd79-41d1-afb2-3327cef6f2c6


It was now time to complete the map.

## Designing the map
I started giving the floor and walls textures. After that, I designed the interior, including the playroom, the kitchen, the stage, and some tables that I downloaded off the internet. Of these, the playroom is what I am most proud of. The second story is meant to resemble a playground from the mall. Additionally, there is a hidden room, which will be covered in the paperwork later. We'll import it into the game now that everything is set up. The rooms we have are the main hall, the playroom, the secret room, the stage, the kitchen, the corridor, the office, and the staff room.

## Artificial inteligence
The enemy's AI will be coded as the next step.
I looked up how to add a following system to an object on YouTube and found a few tutorials that together helped me do the task. I had to download an AI asset, which gave me a ton of brand-new features and elements. It was really useful to have the navigation mesh agent and obstacle components. The object you want to move gets the agent added, and the things that are obviously impediments get the obstacle added. You can decide if the obstacles are walkable at that point: if not, the program must discover the quickest path around them. After making all of your preferred selections, you can bake the software, which will then show you where the opponent can and cannot move. Additionally, I had to write one line of code, possibly two. Everything was successfully imported into our game, and the player is now being pursued.

## Functions
Now I added the functions for the mask and the flashlight.
I started with the flashlight. I had to plan how I would implement it kind off like a flowchart but I had no idea how I would do it with c#. So my idea was to write it kind off in the language c and gave it to chatgpt which convertet the code into c#. Afterwards I added the code and started it. what happened was, i wouldnt work. i tried it several times and it just couldnt work. After a quick reasearch on youtube, I got the anwser which was the keybinds werent ajusted. So i ajusted the keybinds and it work. Next was the mask. I already designed it so it wasnt a big deal. The code was very simular to the flashlight code but i had problems with editing the code for the AI enemy. Why? You may ask. The problem was they had to stop following me, when I put on the mask. But as always uncle gpt was here to help me with this problem. Of course it worked out. Now we have alot of functions and playable features.

## Collectables
Then we moved on to the collectables. 
Designing them was not that difficult. They were just cylinders of various sizes. After you had gathered all the collectables, I created a code that raised a wall. The final enemy and the escape key are located in the room behind a wall. For the little cherry on the top of the cake I decided to add a sparkling effect to them so that they appear more.
