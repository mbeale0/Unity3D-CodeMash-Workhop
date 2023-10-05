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

Once it is resized correctly, we want to make this invisible, at least for the time being, no reason for the players to die on weird white cube. To turn this, disable the mesh renderer component in the inspector for the object:
![Invisible](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/101db42c-ac57-41a1-9143-6f4198c98151)
Then your result should look as follows:
![AddedKillZone](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/0bf7fb67-1d8b-44a1-9794-2881f6353b26)
_Note: you will only see the green lines(the collider), when selected on the object_

### The boundary code
Go ahead and add a new component to the boundary, a new script called "BoundayManager"

Open this script and delete all the template code in the class. 

Now try on your own to add the necessary code to 1. output to the console the player lost and 2. stop time.

<details><summary> Click here to see the code</summary>
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("You lose!");
        Time.timeScale = 0;
    } 
</details>

Awesome! The code is done. If you tried to test your code, and you may have noticed I "totally on purpose for learning purposes" forgot a step. If you happened to catch it and were able to fix it, great! If not, no worries. I'm teaching you this and I forgot.

In order to actually check if there when an object enters a trigger, _there must actually be a trigger_. Select the boundary object, and under box collider, engable "Is Trigger"
![IsTrigger](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/19e0a5d4-b15d-4d2c-940f-078f04cee767)

And tada, things magically work! Now it's time to try and push our players in the death zone.

## Some simple obstacles
Our first object will be pretty straightforward, a rotating cube(or if you want to get technical, a rectangular prism, but that' a lot more to say)

What's nice about an obstacle like this and the way we'll make it, as that it we will be able to adjust both the speed and size to allow multiple varieties all from one object.


