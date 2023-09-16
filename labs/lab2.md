# Creating Your First Level
*Git branch: Lab1Finished*

Watching a ball roll down a hill is fun and all, but I think it's time for something a bit more exciting, how bout you? We want to actually _play_ our game.
Let's get started with the first step of that: creating a real level. (Our next lab will be introducing player controls). We'll start with a nice simple level, but revamp it as the labs go on.

## Set Up
First things first, we don't want to waste our work from the first lab, so let's go ahead and create some object prefabs. This works very much like classes in OOP, where we can create the object in the scene, create a prefab from it, and reuse it as many times as we want, and even create prefab variants, or nested prfabs. 

### Clean up
First, go ahead and navigate to the "project" tab and right click to open the context window. At the top of the window, hover over create, and in the new window, also at the top, select "Create Folder"
**Add picture**

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
