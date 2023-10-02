# Player Controls and Movement
I know I said this last time, but _now_ is really the time to get into the fun stuff! As per usual, we'll start simple and work our way up, so for the first part of the lab we won't have the camera move with the ball, since that adds an extra layer or two, but we will add it in the second half.

## Basic controls
### Setup
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
The first value is just as it sounds, a speed variable for our ball. The "SerializeField" value exposes(or serializes) the variable to the inspector, allowing it to be modified in the editor, useful for testing in playmode, and for designed who don't interact with the code
_Note: changing values in the inspector during playmode do not save. You have to change them again after exiting playmode_
The second value simply sets up a variable for the Rigidbody component, which we get access to using the _GetComponent()_ function, which we can add in _Start_:
``` C#
void Start()
{
    rigidBody = GetComponent<Rigidbody>();
}
```
_Note that the component you are trying to get is inside <> not the parantheses_
