# More Fun Level - Part 2 - WIP
The last lab was more demoing some things to use here in a minute, and not as much about following along. This lab is still usedful for ideas and adding your own thing, but may be more helpful to follow along more 🙂

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

## Some more obstacles
## Some audio
  // Audio is important!!  
  // Start with music?  
## Work time!

