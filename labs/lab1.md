# Unity Fundamentals
In order to work our way up to all the fun stuff in Unity, we must first get comfortable with the basics. For this lab, we'll use a prebuilt scene and add some simple functionality. And don't worry! What we use here will be used for the later labs as well

In Unity, in the "Project" tab in the bottom half, left side, of the screen, open the "scenes" folder. Double click the scene "Lab1Scene" to open it
![OpenedFirstScene](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/4aa5eb42-4b2c-4c02-b579-8d0f827f9faf)

The goal of this scene will be to get the ball to roll down the ramp, and through a finish line, which we'll add in a minute.
If you want, you can press the play button on the top of the window to see how nothing happens. Absolutely thrilling.

**Note: Unity does not autosave. Either hit "ctrl-s" or in the top left file -> save**

## Getting the ball to roll
We'll start slowly here. First, in the heirarchy window on the left side of the screen, under "Lab1Scene", click the "Sphere" object. Upon doing so, the details about the object will appear on the right hand side of the screen in the inspector.
The Sphere contains basic features (known as components) that most objects in a game will have:
  1. Transform - The details of the object in the world space, or the "Scene" tab. The position is where its located, the rotation is how its rotated(hard to see in a sphere) and of course scale is how big it is
	- Feel free to mess with these values to see what they do, but make sure to rememeber them
	- We will talk shortly about to edit these directly in the scene
  2. Sphere (Mesh Filter) - Contains a reference for the mesh, a collection of triangles organized in 3D space to represent an object
  3. Mesh Renderer - Uses the Mesh Filter to put all the triangles actually into the scene
  4. Sphere Collider - Used to define where and how collisions should take place on the object in interaction with physics
  5. Dark Green (Material) - The material applied to an object giving it color or texture and other visual values

In order to get the ball to roll down the ramp simply requires that physics have an effect on the object.

Thankfully, this is actually a really simple process. The reason we use engines like Unity is because they do a lot of the heavy lifting for us, like a JavaScript framework or a Python library. Instead of hardcoding all these interactions we can use what Unity gives us. Still in the inspector view of the bal; click the "Add Component " button right below the material.

In the search bar that appears, type in "rigidbody" and select the option that comes up for "Rigidbody". Another great thing about Unity specifically is that it has very mature documentation, so instead of rewriting the wheel, I'll let them explain what a rigidbody does: "Adding a Rigidbody component to an object will put its motion under the control of Unity's physics engine. Even without adding any code, a Rigidbody object will be pulled downward by gravity and will react to collisions with incoming objects if the right Collider component is also present." - [reference](https://docs.unity3d.com/ScriptReference/Rigidbody.html)https://docs.unity3d.com/ScriptReference/Rigidbody.html

## Adding a simple finish line
Of course as fun as watching the infinite falling ball is, that's not really greate for a final game. Let's dive a little into the Unity scene editor to add a simple finish line.

In the top left of the screen, find the "GameObject" tab. This allows us to quickly add default Unity objects to our scenes, such as primitives(basic shapes), Cameras, UI, and more.

Go ahead and click that tab, select "Shapes" -> "3D Cube". Once you click that you should see a new cube labeled "Cube (1)" pop up in the heirarchy and Inspector, and you should notice a new white cube in the scene view.

The first thing we need to do is actually get our cube in a good place for the ball to roll to. There are two main ways of doing this. We can use the position value of the transform in the inspector, or the green/red/blue arrows in the scene.
The inspector is good for a couple things.
  1. Quickly reseting an object to its origin(0, 0, 0)
  2. Smaller, and more precise adjustemnts
Lets go ahead and use the arrows for now. As you may have guessed, the cube will move in the direction of the arrows. However, unless you have already been messing around in your scene, it may be hard to see the cube. Let's learn a little bit about navigating the scene.

To navigate the scene, you can both adjust your orientation/look, and your position. Its like a no clip mode in certain games.
In the scene view, you can click and hold the right mouse button to look around. You can then use the WASD keys to "fly" around the scene. The scroll wheel is also useful for zooming in/out, or if you scroll while holding the right mouse button, you adjusted the speed at which you fly.

Using this knowledge, navigate in your scene to where you are looking at a sort of top down view of the wrap, and you're able to see both the bottom of the ramp and the new cube(it doesn't have to be perfect)
**Image**

Now feel free to use the arrows on the cube(if you happen to have deselected it, you can reselect it in the heirarchy or the scene) and try to align it toward the bottom of the ramp.

Tip #1: You'll probably need to readjust your scene view to be viewing more from the side. Later we'll add some simple materials to make it easier to see the objects
Tip #2: You can click on the squares next to the arrows to move two axes at a time

Once you have the cube in a decent position like shown:
**CubeMoved**

Before we go any further, lets make things a little easier on ourselves, and rename the cube. Either in the inspector where it says "Cube (1)" or by clickin on the cube in the heiracrhy, and pressing F2, rename the cube to something more helpful, like "Finish Line" or "Goal"

You may noticed it doesn't fit super well. It's time to adjust the scale, another key transform value. Just like the position, the scale can be adjusted in the scene or inspector, though unlike position it isn't a big difference which you choose.
Let's start with the in scene usage. While still selected on the finish line, hit "r", this will transform the position tool to the scale tool. You can also use the "tools" menu in the top left of the scene.

Similarly to pressing "r", you can press "e" for rotation, "w" for position, and even "t" for a rect tool, which can be used for UI.

The position, scale, and rotation tools all work the same way. Using the colors for the axes (note the icon in the top right of the scene representing the colors) whichever you click and drag, it will affect that axis. On the scale tool, you can select the gray box in the middle to scale up or down on all axes.

Depending on how you brought over your cube, you can use the blue axis to stretch that out to be roughly the same length as the ramp. We can always adjust this later, don't worry about getting it perfect. 
We can make it look a little better by adjusting the green Y axis, and shrinking the height of the cube. Since this scales evenly from both sides, it will likely not be in line with the ramp anymore, so in the transform, hover over the "Y" value for the position.
When you see two mini arrows by your cursor, you can click and drag left and right to also adjust the settings that way. This works with any numeric fields like these. Go ahead and get the finish line back in line.


So we have our finish line object, now what? We need to have something detect when the ball passes over the finsh line, and something to handle logic when it does.

Let's start with simply adding a detection component, in this case, a collider. Again, I'll let the experts explain: "Collider components define the shape of an object for the purposes of physical collisions. 
A collider, which is invisible, need not be the exact same shape as the object’s mesh and in fact, a rough approximation is often more efficient and indistinguishable in gameplay."

In the hierarchy, if you click on the "FinishLine", you'll already see a "box collider" component attached. It's currently hard to see, as it is perfectly around the mesh of the cube.
There are two main ways to use a collider, as a trigger or not as a trigger. The default was has the "Is Trigger" field of the component turned off. This essentially treats the object like a normal hard object, IE
if something hits(or collides) with the object, the two objects don't merge, they stay separated by their colliders. This is how it works right now. Our ball would roll down the ramp, and roll over the finish line.
We want to keep this functionality, at least for now(feel free to experiment for what you like!). But we still need to detect when the ball rolls over. We could use a method in code for detecting collisions without triggers, but that isn't exactly what we want right now.
Instead, we are going to use a trigger, and detect that in code.

We can actually have multiple colliders on one object. At the bottom of the inspector for "FinishLine" click "Add Component" and type in "box collider". Click the first option(do NOT click the one that says "2D")

This add a new collider, though in the exact same way as the default. Under the "Box collider component", in the "size" field, change the y value to something like 7. You should see green borders roughly the same shape appear a little taller than the main box!
Similary, under the "Center" field, enter in a value of 3 for Y. to also make sure the ball crosses over completely before winning, change the x value of "Size" to something like .5

Now the last step we need to do is on the same box collider(Don't get the two confused!), is to click the checkbox for "Is Trigger" so it is marked as a trigger. This allows objects to pass through each other, and be detected in code. Often useful for things like pickups among many others.
**Insert picture finislinecollider**

Now it's finally time to add some code!

Go ahead and click the "Add Component" button again on the Finish Line object. This time, let's type in what we want to name our script. How about: "FinishLineManager" - feel free to choose your own name, but just remember it when we come back later. 
Click the "new script" button, then click "Create and Add". This will add the script to the /assets/ folder. You can double click the script name in the "Script" field of the newly created component, or click the script icon in the /assets/ folder to open the script.

Upon opening your file, you should see two very important Unity functions: Start and Update, with comments explaining their function. For a quick example, Start would be used for setting up a scene before play, and update would be used to check for input.

Delete them, and their comments.

Don't worry, we'll come back to them later, but we don't need them for this.

Instead, start typing "OnTriggerEnter". Assuming you have intellisense enabled, you should soon see an option for "OnTriggerEnter" pop up, click enter or your mouse on that option, and the following should appear:
**Insert EmptyTrigger Image"


As you may have guessed, this function will run when ever an object enters the trigger. https://docs.unity3d.com/ScriptReference/Collider.OnTriggerEnter.html **Add inline version**
Some things to note:
  1. The script must be attached to the object with the trigger
  2. Both objects must have a collider attached
  3. One or both objects must have a rigidbody

As the scene is right now, this will run when the ball gets to the bottom of the ramp. We can do a couple simple things right now to get this set up, but we'll expand it's features later.

In the function, add the following lines: **add code block**
Debug.Log("Finished!");
Time.timeScale = 0;

The Log statement will simply print to the console, and the timeScale is simply the rate at which speed passes. 1 is the default. 0 essentially stops time, making it useful for pausing. You could also set a value
like ".5f" to enter a slowmotion state if you want. (the "f" is required to denote a float value)

Hit "ctrl-s" to save the script

## Testing our work
Once your script is saved, go ahead and click back into the Unity editor(it may take a minute as the scripts reload).

If you forgot like me, make sure to save in the editor as well. Now go ahead and select the "console" window near the bottom of the screen, and click the play button at the top!

The editor should automatically switch to the "Game" view, and the ball will start rolling down the hill. When it reaches the bottom, it will output our Log and freeze time!

Congrats, you did it!