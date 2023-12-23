 # Obstacles and Losing
Most _games_ with a specific goal aren't as fun without some sort of consequence. This could simply be losing a couple resources and it takes you a couple extra minutes, or hardcore gamemodes that resets all your progress. We'll be somewhere in the middle of that, though you can later adjust the penalty somewhat with things like checkpoints. Let's get started.

## Set up
First,  we need to actually have room for some obstacles, so let's lengthen our platform a little bit. This is only a couple of steps:
1. Select our main platform either in the editor or in the heirarchy.
2. Using either the transform in the inspector or by clicking "r" and using the gizmo, size the platform up to maybe double the size of it was before
    - I found a size of 4 on my Z axis worked well, but it is up to you.
      
    ![Scale](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/4a602198-34cc-4495-b576-cc6411b5e26f)

3. While still selecting the platform, press "w" to switch to the position gizmo, and drag the platform so one side is in line with our starting line as it was before
4. Select the Finish Line, and drag that to the end so that is lined up as well
5. Finally, your result should look something like this
    ![Expanded platform](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/6c777364-9873-41a9-bfa6-9534088bca42)
   - dont worry. We'll remove all the white in a couple labs

## Adding a boundary
Our primary way of losing should be a classic platformer style: falling off the map. In a minute we'll add some obstacles that spin and move and try to push the player off, but let's start with actually adding the boundary. Can you think of anything we have used so far that can be used for this?

If you said the finish line, you would be right! The Finish line detect when the player enters it using trigger detection, and stops time. Since we pretty much know how it works let's go ahead and create a very similar object for losing.

### The boundary object
First let's create a new object. It can really be any object but something like a cube works the best. Name this object something like "boundary" or "KillZone"

![AddCube](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/fa11d179-c95b-4a2c-ac0a-0f1d4da39db4)

If the cube is not right in front of you, press "f" to focus it in. Once selected and in view of the cube, drag it to be about the center of the platform, and then bring it down a little, however far you want the player to fall really.
![CubeBelow](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/f1dcd476-59c3-49ae-9f6f-8789e0e53978)
Now press "r" or using the inspector, resize the x and z axes so anywhere a player could fall, they would land on this platform(extend it a little more on the sides that would be the left and right of the player, in case an object pushes them off farther). For this, it's okay to be a little bigger than smaller.

Once it is resized correctly, we want to make this invisible, at least for the time being, no reason for the players to die on a weird white cube. To do this, disable the mesh renderer component in the inspector for the object:

![Invisible](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/101db42c-ac57-41a1-9143-6f4198c98151)

Then your result should look as follows:
![AddedKillZone](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/0bf7fb67-1d8b-44a1-9794-2881f6353b26)
_Note: you will only see the green lines(the collider), when selected on the object_

### The boundary code
Go ahead and add a new component to the boundary, a new script called "BoundaryManager"

Open this script and delete all the template code in the class. 

Now try on your own to add the necessary code to 1. output to the console the player lost and 2. stop time.

<details><summary> Click here to see the code</summary>
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("You lose!");
        Time.timeScale = 0;
    } 
</details>
Once you're done with the script, make sure to move the script in the assets folder into the Scripts folder.

Awesome! The code is done. If you tried to test your code, and you may have noticed I "totally on purpose for learning purposes" forgot a step. If you happened to catch it and were able to fix it, great! If not, no worries. I'm teaching you this and I forgot.

In order to actually check if there when an object enters a trigger, _there must actually be a trigger_. Select the boundary object, and under box collider, enable "Is Trigger"

![IsTrigger](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/19e0a5d4-b15d-4d2c-940f-078f04cee767)

And tada, things magically work! Now it's time to try and push our players in the death zone.

## Some simple obstacles
Now let's try and push the player into the boundary with some good old fashioned obstacles!

## The first obstacle
Our first object will be pretty straightforward, a rotating cube(or if you want to get technical, a rectangular prism, but that' a lot more to say)

What's nice about an obstacle like this and the way we'll make it, as that it we will be able to adjust both the speed and size to allow multiple varieties all from one object.

Go ahead and add a new cube, and name it "RotatingObstacle". Once added, move it so it is sitting roughly just above the platform, about 1/3 of the way in front of the player, in the center. Extend the X axis to be about 7.5, roughly the same width as the platform. 
![RotatingPlatform](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/a6d293e9-8d02-4179-ae62-63a8e5180e71)

Now that we have the object created, let's create a simple script by adding a new component to the RotatingObstacle. Call this script something like "RotatingObjectManager"

In this script, we need two main values: speed, and rotation direction(clockwise or counter clockwise). Add those values and serialize them.

<details><summary> Click here to see the code</summary>
    
    [SerializeField] private float speed = 80.0f;
    [SerializeField] private bool rotateClockWise = true; 
</details

We will use a Vector 3 to rotate the object, so to reverse direction, we can simply negate the speed, which we can do in start:
``` C#
if (!rotateClockWise)
{
    speed = -speed;
}
```
Then finally we add the the actual code to rotate, using a function on the transform which just takes a vector3, which can be multipled by our speed:
``` C#
gameObject.transform.Rotate(new Vector3 (0, 1, 0) * speed * Time.deltaTime);
```
A couple of things to note:

1. This does not act on the physics of the object, which as we mentioned before can affect the collisions. However, since this is a small part with relatively discrete set of actions, it 
    isn't a huge difference here. The "1" is basically saying move 1 degree at a time, so even though the object is technically "teleporting" to that new rotation, it is on such a small scale that it is negligible for our purposes
2. We haven't seen Time.deltaTime before, it is useful for keeping things in track with the frames, I found a good defintion [here]([https://link-url-here.org](https://gamedevbeginner.com/how-to-rotate-in-unity-complete-beginners-guide/#rotate_unity:~:text=How%20to%20make%20an%20object%20spin):
    - "_Multiplying the rotation amount by Time.deltaTime (which is the duration of the last frame) makes sure that the rotation is smooth and consistent, even if the framerate of the game changes_"

Great! Now we have one obstacle that you can tweak to your liking, and even prefab to create variants of. Let's go ahead and add another one.

## The second obstacle
Follow the same process as earlier: create a new cube named "MovingObstacle", center it on the platform, though this time on the other side and set it to about 5 on the X value, and line it so it is perpendicular to the platform
   ![MovingObstacle](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/e370068f-e45c-4061-aee2-d43acca9c4ed)
   
Create a new Script on this object called "MovingObjectManager". Double click to open this script.

This one is a bit more complex than the previous ones, so it may not all make sense now, but it is good to start getting our toes wet - I also added a little bit to help visualize this in the scene before adding all the code.

We need three serialized fields and two privates ones:
``` C#
[Range(-1, 1)]
[SerializeField] private float movementMultiplier = 0f;
[SerializeField] private float movementRange = 7f;
[SerializeField] private bool startMovePositive = true;

private float startXPosition = 0f;
private bool movingPositive = true;
```
1. The "movementMultiplier" will simply be a multipier to help restrict our obstacle, and something we can set during playmode to test things out. The "Range" attribute keeps it between the set values.
2. "movementRange" is saying how many units can our object move each way, this can be adjusted along with a speed value if you add one to vary the obstacle
3. "startMovePositive" is setting the starting direction, so we can again introduce some variability
4. "startXPostion" will be the xPosition of the object which we will get in start
5. "movingPositive" will keep track of the actual direction.

You can access the values of the transform using transform.position/scale/rotation.x/y/z. In this case, we want x for the position, though you may want "z" depending on your game orientation. Let's grab this, and the direction, in start:
``` C#
startXPosition = transform.position.x;
movingPositive = startMovePositive;
```

Next let's skip the actual auto movement for just a second so we can test this out with manual movement. Add the following to Update:
```C#
float currentOffset = movementRange * movementMultiplier;
```
That will get the units the cube should be moved relative to the offset and where the percetanage multiplier is at.

Now set the new X (or Z if you choose something else) position by using our cached starting position:
```C#
float newXPosition = startXPosition + currentOffset;
```

Now actually set the position based off our calculated value. We also need to use the transforms y and z values, since we cannot modify just the x coordinate.
```C#
transform.position = new Vector3(newXPosition, transform.position.y, transform.position.z);
```

Save this script and go back to Unity. Make sure the obstacle is selected in the scene/heirarchy and click play. The range value will be a slider, you can slide that back and forth and watch your object move! Go to the min and max, if it feels liks a good range great, if not adjust the _movementRange_ until you feel comfortable(Make sure to set it again after exiting playmode). While we are back in the editor, take this time to move the _MovingObjectManager_ and _RotatingObjectManager_ scripts into the scripts folder.

Now, back in the script, let's get this thing going on it's own.
We can use the following code:
``` C#
if (transform.position.x >= startXPosition + movementRange)
{
    movingPositive = false;    
}
else if(transform.position.x <= startXPosition - movementRange){
    movingPositive = true;
}
```
This will switch the direction flag if the object moves outside of it's range
Then add:
``` C#
if (movingPositive)
{
    movementMultiplier += Time.deltaTime;
}
else
{
    movementMultiplier -= Time.deltaTime;
}
```
Now based on the direction flag, we simply add to the multipler or subtract(much like we were manually doing in the editor). We add/subtract _deltaTime_ since that is time since last frame. And since frames are 60/second, it is about .016th of a second, a very small amount that humans wouldn't notice so it works well for this and things like timers(timers that want to be dependent on in game time, not real world)

And bam! It's come to life! Save and switch back to play mode to watch this obstacle go. Take a couple minutes and add some duplicates of both our obstacles and make your level a little bit yours.

<details><summary> Click here to see my updated levels</summary>
![81qjwp](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/bd65e9d6-9902-4bf3-bc6c-5b5179be1877)
</details

See you in the next one, where we'll add some "quality of life" to our game with some actual UI for winning and losing. 
