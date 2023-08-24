# Add Pictures/graphics
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

Two things need to happen so this ball will roll down the ramp. 
  1. It needs to be affected by physics like gravity
  2. It needs to detect when it hits the ramp. In a physics engine, objets need to be told to detect collisions

This is actually a really simple process. The reason we use engines like Unity is because they do a lot of the heavy lifting for us, like a JavaScript framework or a Python library. Instead of hardcoding all these interactions we can use what Unity gives us. Still in the inspector view of the bal; click the "Add Component " button right below the material.

In the search bar that appears, type in "rigidbody" and select the option that comes up for "Rigidbody". Another great thing about Unity specifically is that it has very mature documentation, so instead of rewriting the wheel, I'll let them explain what a rigidbody does: "Adding a Rigidbody component to an object will put its motion under the control of Unity's physics engine. Even without adding any code, a Rigidbody object will be pulled downward by gravity and will react to collisions with incoming objects if the right Collider component is also present." - [reference](https://docs.unity3d.com/ScriptReference/Rigidbody.html)https://docs.unity3d.com/ScriptReference/Rigidbody.html

In other words, our sphere will move now. Go ahead and enter play mode by clicking the play at the top of the screen, or hit "ctrl-p". Watch the ball roll down the ramp and fall forever! Yippee! Click the play button or "ctrl-p" again to exit playmode.

## Adding a simple finish line!

