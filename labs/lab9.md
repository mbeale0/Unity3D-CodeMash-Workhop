# More Fun Level - Part 2 - WIP
The last lab was more demoing some things to use here in a minute, and not as much about following along. This lab is still usedful for ideas and adding your own thing, but may be more helpful to follow along more 🙂

## A timer
Let's go ahead and add a timer to our game. This is a relatively simple feature, but can really put on the pressure for more competitive players. Now a timer is not the hardest thing you can do in game dev, but it does require a couple steps.

We can start with the front end by adding a new text element under UI -> HUD in the hierarchy, which I will call timer. As usual, I will set the anchor in the Rect Transform, this time in the top left of the screen, and put in some placeholder text for sizing: `99:99:99`. Now I can tweak the sizing and position more as I like(don't forget to select auto size!)

I think this is a main game feature, so let's add the code for this in _GameManager.cs_. As usual let's start with getting a reference to the object:
``` C#
[SerializeField] private TMP_Text timerText = null;
```
And then initializing it:
``` C#
timerText.text = "00:00:00";
```


## Some more obstacles
## Some audio
  // Audio is important!!  
  // Start with music?  
## Work time!

