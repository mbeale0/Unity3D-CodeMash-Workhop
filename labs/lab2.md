# Creating Your First Level
*Git branch: Lab1Finished*

Watching a ball roll down a hill is fun and all, but I think it's time for something a bit more exciting, how bout you? We want to actually _play_ our game.
Let's get started with the first step of that: creating a real level. (Our next lab will be introducing player controls). We'll start with a nice simple level, but revamp it as the labs go on.

## Set Up
First things first, we don't want to waste our work from the first lab, so let's go ahead and create some object prefabs. This works very much like classes in OOP, where we can create the object in the scene, create a prefab from it, and reuse it as many times as we want, and even create prefab variants, or nested prfabs. 

### Clean up
First, go ahead and navigate to the "project" tab and right click to open the context window. At the top of the window, hover over create, and in the new window, also at the top, select "Create Folder"
![CreateFolder](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/0c06554b-2da2-42b0-9c1f-461ee1399ee3)

Name this folder "Prefabs". Go ahead and repeat this process, creating a folder called "Scripts". Now click and drag the FinisLine script into the Scripts folder. The asset tab can quickly become overwhelming, so it can be helpful to start organizing earlier.

### Prefabing
The act of creating a prefab is actually very straight forward, it works much like moving files and folder around in the asset window. 
In the heirarchy pane, click and drag the "Finish Line" object into the prefab folder. _Note how the object in the window turns blue, indicating it is a prefab_

_Another quick note, there are a couple ways to edit prefabs. You can single click the object in the assets pane, and edit the components/details in the inspector. You can double click it to open the the object in isolation in the scene view, allowing you to modify the object in both the scene view and inspector. You can also modify the object based off the instantiated object in the inspector, by clicking the right chevron next to the listing, opening the asset in context(ie, still in the main scene view) or by right clicking, hovering over the prefab option, and clicking one of the options._

Next go ahead and drag the "sphere" object into the folder as well. And boom! You have two prefabs you can reuse to your hearts desire.

Before we go on, let's change the sphere's name to something a but more intuitive. In the Prefab folder, click the "Sphere" and either press F2 or right click and select rename to rename the ball. Let's name it something like "Player".

You may notice the ball in the heirarchy doesn't change. This is to be expected, as that functions like a variable name for a class instantiation, ie, it is simply a way to reference the specific object. However, changing something like "Mass" on the prefab _will_ alter the object(however you can change the variables in the instantiated object to be what you like without affecting the orefab or other instances)

Okay, that's enough info =) Let's actually get to making a level now!

## Actually making the level

In order to work on a new level, we need to create a new Scene in the asset window, using the context menu again. Go ahead and double click into the "Scenes" folder.
Once in the folder, right click -> Create -> Scene. 
![SceneCreation](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/869b3971-f7b3-4883-9af2-9b3d6c294c34)

Go ahead and name this scene "Level1". Double click it to open the new empty scene. 

As you can see in the Heirarchy each new level starts with just a camera and directional light, needed for almost every scene.

Let's get started by adding simple starting line for the player. In the top left, go ahead and select the GameObject tab. From there, "3D Objects" -> "Plane"

Planes, as oppoosed to cubes, work well for floors or platforms like our game, since they start flat. They also only render one side, if you were to navigate in the viewport to look underneath the plane, you would see right through it! Like a sort of one way window. The reason for this is much more in depth than this course will go into, but it ultimately has to do with culling, ie stopping render of certain objects to optimize the game. 

This plane is probably a bit to big for our starting line, so let's shrink it up a little bit. We can do this in the editor. With the plane selected, press "r" to switch the gizmo. Click and drag to the left the white/gray block in the middle to shrink the plane. I found a value of .3 worked well across the XYZ values, but it's really up to you _Note: the Z value does not do anything, so it can typically be left at "1" or if X and Y are the same, it can look nice to change them all. Personal preference._

***TIP: If the plane has moved out of a good view, select it and press "f" to reorient. This is also a fix for an issue where when you view an object at close up, it starts to dissapear***

Let's go ahead and utilize our Player prefab now, navigate to the prefabs folder, then click and drag the player prefab into the scene view. Adjust the values of the position fields so the ball is just slightly above the plane, towards the center. You can use the XYZ position coordinates from the plane, copy those to the player, and then just move the player up a little but, or just adjust the ball's position using the in scene gizmo. 

Now let's add the rest of our simple level. Go ahead and add another plane just like earlier. For clarity sake, let's name this something like "Platform" and the other plane "Start"

Move the plane so that one of the edges aligns with one of the edges of the starting plane, it doesn't really matter which. A small gap or overlap is okay.
![platforn](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/036c2da6-cec8-4cc5-bcad-73300f62eb99)

Now, depending on which way you moved the platform, shrink either the red x or blue z axis to create a narrower platform, but a little bigger than the start. Then the opposite axis, expand to create 
a longer pathway. I used a length of 2. Again, we'll expand this more later. We just want a simple "boxed out" level to start adding features. You'll also need to line up the edges again after that.

Finally, let's add back in the Finish line. It should be pretty straightforward by now, so try and add it yourself before reading what I do

<details><summary> Click here to see how to add the Finish Line</summary> 
Just like the player, click and drag the "Finish Line" prefab into the scene.

You can use the same trick as earlier to get it on the same height as the other objects by copying over the z value. THen use the red and blue arrows, or the square between them to line it up on the other side of the platform. 
</details>
