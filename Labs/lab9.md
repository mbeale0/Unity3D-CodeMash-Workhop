# More Fun Level - Part 2
The last lab was more demoing some things to use, and not as much about following along. This lab is still usedful for ideas and adding your own thing, but may be more helpful to follow along more 🙂

## A timer
Let's go ahead and add a timer to our game. This is a relatively simple feature, but can really put on the pressure for more competitive players. Now a timer is not the hardest thing you can do in game dev, but it does require a couple steps.

We can start with the front end by adding a new text element under UI -> HUD in the hierarchy, which I will call timer. As usual, I will set the anchor in the Rect Transform, this time in the top left of the screen, and put in some placeholder text for sizing: `99:99:99`. Now I can tweak the sizing and position more as I like(don't forget to select auto size!)

I think this is a main game feature, so let's add the code for this in _GameManager.cs_. As usual let's start with getting a reference to the object:
``` C#
[SerializeField] private TMP_Text timerText = null;
```
And then initializing it in _Start_:
``` C#
timerText.text = "00:00:00";
```
We also need the following variables to utilize in the timer:
``` C#
private int currentMinutes = 0;
private int currentSeconds = 0;
private float currentMilliseconds = 0;
```

We could get time based on the actual real time, but for our game it make more sense to actually get the time from `Time.deltaTime`. That provides time between frames, which allows the time to be based on the frames, which helps if the frames are incconsistent or higher or lower than 60 fps.

The only value we need to change every loop in _Update_ will be `currentMilliseconds` which we can add to the `Time.deltaTime * 100` to properly adjust(note this time field is probably not super accurate to actual milliseconds but adjust to keep similar formatting, and it moves so fast the player doesn't even really notice, it is useful to "Add the pressure") So the first line of our Update loop will be:
``` C#
currentMilliseconds += Time.deltaTime * 100;
```
We then need to check everytime 100 milliseconds occur, and since `Time.deltaTime` is variable, we should check if it is greater than or equal to a hundred. If that happens, what do you think we should do?

We should reset the milliseconds, and increment seconds:
``` C#
if(currentMilliseconds >= 100)
{
    currentMilliseconds = 0;
    currentSeconds++;
}
```
Similarly, if seconds is greater than or equal to 60, we should follow a similar approach. We could also just check if seconds is equal to 60. It is an integer and should not go above, but sometimes it doesn't hurt to be extra safe if it doesn't complicate the code:
``` C#
if (currentSeconds >= 60)
{
    currentSeconds = 0;
    currentMinutes++;
}
```
And that gives us all the numbers we need. Its unlikely(though possible) the user would be on a level for more than 60 minutes, but if we wanted to add option for that, we would follow the same method as before.

We also want the minutes and seconds to be formatted well, as when they are only one digit, they would shorten the text, so we can use a built in C# method, _ToString_ with a parameter to specify how many digits:
```C#
string minutesText = currentMinutes.ToString("D2");
string secondsText = currentSeconds.ToString("D2");
```

Now we just set the text of the text object using a format string:
``` C#
timerText.text = $"{minutesText}:{secondsText}:{Mathf.Round(currentMilliseconds)}";
```
We round the milliseconds as well to keep that format
And finally, after saving this script, we hook up the text gameobject in the scene to the GameManager, and we are good to go!

## Some audio
Audio is an extremely important aspect of any game, or even the lack of audio can and should be intentional choices, as it is a strong feature to influence player emotion. Even in a simple game like this, we can engage our players more with some music, and some simple sound effects than engage them more and make them want to play and do it well!

Let's start with some easy audio, in adding some music. Music is pretty easy to add in unity, as for simple looping tracks, you just need to add a component to an object, called "Audio Source" and add your audio file. All you need to play an audio track in Unity is an Audio Source and an Audio Listener. You can have as many Audio Sources as you need/want, but only one Audio Listener(by default it is placed on the Camera)

Since it is also the GameObject with our GameManager and music is a gamewide thing, let's add a new commponent to the camera, an Audio Source.  
![image](https://github.com/mbeale0/Unity3D-CodeMash-Workhop/assets/74221606/9d4dd96f-1e87-41bb-ae1d-b0eed5c01dd5)  

Let's break down a couple of the main fields. Find descriptions for others [here](https://docs.unity3d.com/ScriptReference/AudioSource.html#:~:text=state%0A%20%20%20%20%20%20%20%20%20%20%20%20m_ToggleChange%20%3D%20true%3B%0A%20%20%20%20%20%20%20%20%7D%0A%20%20%20%20%7D%0A%7D-,Properties,-bypassEffects)
1. AudioClip - The clip you want to play, this can also be set in code to be more dynamic. In a minute, we'll add our music track to this
2. Output - Used to set the mixer, which often would be sub mixers off the master volume, so you could add different sliders like "Music", "SFX"m or "Voice"
3. Mute - Mutes the audio
4. Play on awake - Decides if audio will start playing as soon as the game starts
5. Loop - Loops the audio
6. Priority - Based on number of available audio channels(up to 256) to decide which audiosource to use if needed
7. Volume - Sets the volume
8. Pitch - Sets the pitch so you can alter the sound slightly
9. Spatial Blend - Used if you want to make the sound 2D(hearable from anywhere in scene) or 3D(hearable based on direction and postion)

Once you add the AudioSource, navigate to Assets/Audio/ and find the "MainMusic" track. Drag that into the AudioClip field on the AudioSource. Also enable "Loop"

Now, if you click play, you should hear the music start to play, and already it feels so much more alive! Though personally, I don't want the music to be overbearing so I am gonna lower the volume to about .3

Next let's add a couple of sound effects that get trigger on certain events: Checkpoints, coin pickups, and finish line. Let's start with the coin. Also for a handy resource, I got all of these clips from freesound.org, which has tons of free audio, but be sure to check the licenses if you are doing anything for non hobby projects.

Let's start with adding an audioclip to a checkpoint(reminder, if you wish to skip playing through the level each time, move your ball to an easier start)

Open up "CheckPointManager.cs" so we can get started. Let's add an instance variable:
```C#
private AudioSource audioSource = null;
```
We will add an AudioSource component here in a minute. The script itself can't play the sound, so we get references to the AudioSource and manipulate that. That being said, let's get a reference to the AudioSource in the code, in _Start_:
``` C#
private void Start()
{
    audioSource = GetComponent<AudioSource>();
}
```
In _OnTriggerEnter_ All we need to do is add the following code:
``` C#
audioSource.Play();
```
Note, `audioSource` has several helpful methods, inlcuding "PlayOneShot" which allows you to define the audio clip in code, and play multiple of them without looping over. You can also set the clip of `audioSource` with `audioSource.clip`.

Techncally, once we add the AudioSource and Clip we would be good to go, but if the player rolls back over the checkpoint the audio would play again and again. Let's update our GameManger so we can check if its their current checkpoint.

In _GameManager_, we just need to add the folllowing function:
```C#
public Vector3 GetCurrentcheckpoint()
{
    return checkpoint;
}
```
Returning back to CheckpointManager, let's update this so it's a little more clear. We'll add an instace variable for GameManager, and set that in Start:
``` C#
private GameManager gameManager = null;
...
gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
```
That makes the line setting the checkpoint much easier to read!

Now all we need to do is only play the audio and set the checkpoint if it isn't the current checkpoint. It should be fairly simple, but try the code yourself to make sure you're following along!

<details><Summary>Answer</Summary>

``` C#
if(gameManager.GetCurrentcheckpoint() != transform.position)
{
    audioSource.Play();
    gameManager.SetCurrentCheckpoint(transform.position);
}
```
</details>

Great! Now add an "AudioSource" to all three checkpoints(including Start), along with the clip "Checkpoint" and then it should work!

We can also do almost the exact same thing for the Finish Line, except using the "Finish" audio clip, and we don't need to check if its in the checkpoints. Go ahead and try it on your own!
<details><Summary>Answer</Summary>

``` C#
private AudioSource audioSource = null;
private void Start()
{
    audioSource = GetComponent<AudioSource>();
}
private void OnTriggerEnter(Collider other)
{
    audioSource.Play();
    GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().HandleGameOver("You Win!!!");
}
```
</details>

Congrats! Now it is just time for the coin audio, which is just a little different. It is actually only a couple lines, but because the coins get destroyed, we can't use their own audiosource, as that would get destroyed as well.

We well use a different _AudioSource_ method called `PlayClipAtPoint` which actually spawns an instance of an AudioSource, and deletes it when the clip is done, which is great for pickups! Also to note, this technically plays a 3D sound, but since we are right where the _AudioSource_ will spawn, this isn't a big deal. Another option if you want 2D sound would be to create a prefab of an AudioSource, customize it to your liking, and instantiate that as an object.

In CoinManager, we need to get a reference to the desired sound effect:
``` C#
[SerializeField] private AudioClip pickupSFX = null;
```
And then we just need to play it upon pickup:
``` C#
AudioSource.PlayClipAtPoint(pickupSFX, transform.position, 1);    
```
The three arguments are the clip, the location to spawn(in our case, where the coin was) and the volume, which I have set to one. Add the "CoinPickup" clip to the new field on your coins and we are good to go!

## Work time!
Congrats! You have made an entire game that includes dying/winnin, challenge, extra features, UI and even audio! This is a great thing! I hope you at least added some of your own self as you were following along, but now is also the time.

We have one more lab, where we will build and share our games, but right now, let's take about 20 minutes and all work on our games. Maybe experience with visuals through lighting or materials. Add challenge to the course through narrow paths or moving platforms the player has to get on, or maybe even new obstacles, like ones that try to smash the player or move in less random patters, or even better yet, think of a whole new feature or cool idea that wasn't even thought about in the training!

