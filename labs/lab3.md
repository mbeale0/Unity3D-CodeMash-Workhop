# Player Controls and Movement
I know I said this last time, but _now_ is really the time to get into the fun stuff! As per usual, we'll start simple and work our way up, so for the first part of the lab we won't have the camera move with the ball, since that adds an extra layer or two, but we will add it in the second half.

## Basic controls
Navigate back to the Scripts folder (Assets/Scripts/ in the project tab), right-click, click create -> C# Script. Name this "PlayerController". Double click to open the script.

There are multiple different ways to move an object in Unity, such as:
- Manually setting the position in code
- A method called Transform.translate(...), which is similar to the first one but smoother/built in
- Setting the velocity of the object to move it based off of physics, which is what we'll be doing(the first two ignore physics on moving to some extent)

In order to adjust the velocity, we need a couple of values, namely speed, and the rigidbody, which handles physics for the object

Above the _Start_ function add the following lines:
``` C#
[SerializeField] private float speed = 10f;
private new Rigidbody rigidBody = null;
```
The first value is just as it sounds, a speed variable for our ball. The "SerializeField" value exposes(or serializes) the variable to the inspector, allowing it to be modified in the editor, useful for testing in playmode, and for designers who don't interact with the code
_Note: changing values in the inspector during playmode do not save. You have to change them again after exiting playmode_
The second value simply sets up a variable for the Rigidbody component, which we get access to using the _GetComponent()_ function, which we can add in _Start_:
``` C#
void Start()
{
    rigidBody = GetComponent<Rigidbody>();
}
```
_Note that the component you are trying to get is inside <> not the parantheses_

Last time I had you delete start, so I should probably explain what it does, though the comment is pretty helpful and accurate. Start is simply called before the first frame. It is useful for setting up your scene, such as what we are doing now with getting variables, or setting positions of players, or loading things from save data. Update is the other method you should see, another crucial one that we will use in just a minute. Update is essentially a `while(true)` loop that is synced with framerate. The default frames per second in Unity is 60fps, so this loop will be called 60 times per second. This is useful for handling things that can occur at any time or that need constant updating, like gameplay timers and player input - which is what we'll do right now.

We can get physical input using the built in Input class, which contains an array of functions. The function we care about is the "GetKey" function which detect when a key on the keyboard is held down. For the keyboard there is also "GetKeyDown" which only detect the input for one frame, and "GetKeyUp" which detect the one frame when the key is released. There are also other methods beyond the scope of this course

_Note: This is using the "old" input system in Unity, however for a simple pc game it gets up and running a bit faster and is still farily robust. I do like the new input system and would encourage you to look more into it after this course. It isn't significantly complex, just a little more powerful than we need for this project_

In the update method, add the following code:
``` C#
if (Input.GetKey(KeyCode.W))
{
    Debug.Log("Pressing W!");
}
```
Two things to note:
1. This is an if statement, since we need to actually check when this happens
2. We get the desired Key using the KeyCode enum, which will contain a whole list of keys(which you can see with intellisense completion)

Save this file and switch back to Unity. Once you're there, navigate to assets/prefabs and select the Player. Click add component and type in the name of our script, then click add so the player actually is hooked up.

Now, switch to the "console" tab and click play. Hold down "W" to see the wonderful output!

Of course one key is rather boring. Let's add the rest, and I'll explain as we go.

First we need to add a couple more variables at the top, under rigidbody:
``` C#
private int MoveX = 0;
private int MoveZ = 0;
```
These will be how we keep track of the direction. We will use it to choose three states each, and set the actual velocity. For example, depending on your orientation, MoveX will be for W and S. 1 would represent forward, -1 would be backward and 0 would be stopped.
Now fill in the rest of the Input handlers(make sure to replace the check for "W" as well)
``` C#
if (Input.GetKey(KeyCode.W))
{
    MoveX = 1;
}
else if (Input.GetKey(KeyCode.S))
{
    MoveX = -1;
}
else
{
    MoveX = 0;
}
if (Input.GetKey(KeyCode.A))
{
    MoveZ = 1;
}
else if (Input.GetKey(KeyCode.D))
{
    MoveZ = -1;
}
else
{
    MoveZ = 0;
}
```
This is broken out into two parts: left/right and forward/backward, each also having an "else" to reset, as we want the player to move left and forward at the sime time, but not forward and backward. 

___Important: which values have MoveX or MoveY and which are positive are negative will depend on your balls orientation. We can use the Z and X axis(blue and red) along with the direction of the camera to determine this. For example, in the below picture, the forward direction of my ball falls in line with the direction of X, so W would be on the x axis, and since X is also going forward, W is positive. That means S will be on the X as well, but negative. Similarlly, my z axis is going to the left, so A and D will be MoveZ and A will me positve, while D is negative___
    
![Ballorientation](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/cfc1d81b-f7b7-4805-846f-5b5e341b62c6)

Finally add this function with the code inside:
``` C#
private void FixedUpdate()
{
    rigidBody.AddForce(new Vector3(MoveX, 0, MoveZ) * speed);
}
```
Fixed update runs based on the physics of the engine, so it is not dependent on the framerate and should always be used for things involving physics such as this.

The "AddForce" method applies a new velocity to the ball using a Vector3, which is a direction in 3D space. That is multiplied by our speed variable to give a desired speed. I found a value of 15 works well for this. 
_Note: changing a serializefield variable in code after already being compiled once will not affect gameobjects already in a scene. Those need to be set individually_

Save your file, and switch back to Unity. Click play and look at that ball go. Woo-Hoooo!

## Camera follow
I think now would be a good time to add some minor complexity and have the camera follow the ball. We will have to re-figure out our movex/movey values but I think it was worth it to start simple.

Technically, you could drag the camera to be a child of the player, but then the camera would follow the ball totally - even in rotation. Which could maybe be fun in a rage game or something, which isn't quite what we are going for. So instead, we'll deal with this with a great power: CODE!

In the scripts folder, create a new C# script called "CameraFollow"

First we need a couple of fields:
``` C#
[SerializeField] private Transform player = null;
private Vector3 offset = Vector3.zero;
```
We'll use the player transform to track the player, and the offset will be used to actually set the position. (I set the offset to Vector3.zero, which is simply (0,0,0))

In Start add:
``` C#
offset = transform.position - player.position;
```
This will get us a vector relative to the player's position, so it can be accurate even if the player moves - which they will.

Delete "Update" and add the following method:
``` C#
private void LateUpdate()
{
    transform.position = player.position + offset;
}
```
LateUpdate is another version of Update, but it is called _after_. This is to help ensure the ball updates before moving the camera. If they were both in update, there is no guarantee which would happen first.

The code in LateUpdate simply sets the position of the camera based off the current player position and the offset, keeping the camera at a set distance.

Save your file and switch back to Unity. Add our new script to the Main Camera by selecting the camera in hierarchy. Once opened, click and drag our script into the Inspector, on any of the black lines separating components. You'll see a blue line when you can release. Now we can hook up our player, simply drag the player from the hierarchy into the Player field of the script.

If you click play as is, watch your camera move with the ball! Things are feeling so dynamic and fast paced now! You can leave it as is if you'd like, but I'd prefer to orient the camera with my forward movement.

Like we did in the first lab, navigate in the scene to be behind the ball where feels right to you. Then once you're happy(or moderately okay), right click the camera object and select "align with view". If you click play, you'' notice the camera moves but the ball now goes the wrong direction. We need to adjust our MoveX/MoveZ values. Using the suggestions about looking at the X and Z axes, try and fix this new bug yourself, and playtest it to see if it works. If you can't get it to work, take a look at what I changed:

<details><summary> Click here to see the code</summary>
    
    if (Input.GetKey(KeyCode.W))
    {
        MoveZ = -1;
    }
    else if (Input.GetKey(KeyCode.S))
    {
        MoveZ = 1;
    }
    else
    {
        MoveZ = 0;
    }
    if (Input.GetKey(KeyCode.A))
    {
        MoveX = 1;
    }
    else if (Input.GetKey(KeyCode.D))
    {
        MoveX = -1;
    }
    else
    {
        MoveX = 0;
    }   
</details>

I'm getting excited. It's starting to feel like a real game! In the next lab we'll add consequences: obstacles and losing!
