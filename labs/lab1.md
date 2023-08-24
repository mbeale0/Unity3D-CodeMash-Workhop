# Add Pictures/graphics
# Unity Fundamentals
In order to work our way up to all the fun stuff in Unity, we must first get comfortable with the basics. For this lab, we'll use a prebuilt scene and add some simple functionality. And don't worry! What we use here will be used for the later labs as well

In Unity, in the "Project" tab in the bottom half, left side, of the screen, open the "scenes" folder. Double click the scene "Lab1Scene" to open it
**Insert picture of scene**
The goal of this scene will be to get the ball to roll down the ramp, and through a finish line, which we'll add in a minute.
If you want, you can press the play button on the top of the window to see how nothing happens. Absolutely thrilling.

### Getting the ball to roll
We'll start slowly here. First, in the heirarchy window on the left side of the screen, click the "RollerBall" object. Upon doing so, the details about the object will appear on the right hand side of the screen in the inspector.

Two things need to happen so this ball will roll down the ramp. 
  1. It needs to be affected by physics like gravity
  2. It needs to detect when it hits the ramp. In a physics engine, objets need to be told to detect collisions

This is actually a really simple process. The reason we use engines like Unity is because they do a lot of the heavy lifting for us, like a JavaScript framework or a Python library. Instead of hardcoding all these interactions we can use what Unity gives us. Still in the inspector view of the ball, scroll **Note to Mason: Might not need to scroll** to the bottom and click the "Add Component " button.

In the search bar that appears, type in "rigidbody" and select the option that comes up for "RigidBody3D" **Note to Maon: Check Name**Another great thing about Unity specifically is that it has very mature documentation, so instead of rewriting the wheel, I'll let them explain what a rigidbody does: "Adding a Rigidbody component to an object will put its motion under the control of Unity's physics engine. Even without adding any code, a Rigidbody object will be pulled downward by gravity and will react to collisions with incoming objects if the right Collider component is also present." - [reference](https://docs.unity3d.com/ScriptReference/Rigidbody.html)https://docs.unity3d.com/ScriptReference/Rigidbody.html
**Note to Mason: check default settings of rigidbody**
