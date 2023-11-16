# Coin Pickups & Lives - WIP

It's one thing to have a goal the player can aim for over and over again, but I think we should give them extra consequences in the form of lives.

We can do this Mario style, where a certain number of coins will give a bonus life. If they have lives, they can respawn at the most recent checkpoint(of there current session, arcade style). If not, then they restart at the beginning. For now we can start with two coins to keep things simple. This will also get us set up for the next two labs, where we add some simple yet improved visual effects, and some gamplay features such as a timer and audio. 

## Setup
First off, let's set ourselves up for places to have coins and our checkpoints.

I just copied the main platform, shrunk it down and places it off to the side. I then duplicated that one, and moved it elsewhere. You're welcome to add as many as you'd like, wherever and however(we'll also have some customization time in the next couple labs):  
![CoinPlatforms](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/b021b214-b632-478b-be07-64cc9d6b87d9)

Now lets set ourselves up for a longer level. For now we can just copy and paste the main platform and finish line, and don't worry about the obstacles. I copied and pasted my level twice, so we have a couple of checkpoints to test and use:  
![DuplicatedLevel](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/8f5da2a3-277f-48a8-b4aa-87ea9ecd0848)

For the last set up step, we simply need to change our two middle "Finish Lines" to actual check points. We can shift or ctrl click in the hierarchy or in the editor to select both at the same time. This allows us to edit two similar objects at once. We can rename them both to "Checkpoint" (note that this doesnt append a number to either name). We also want to remove the Finish Line Manager from the component list. We can keep the extra box collider to trigger checkpoint saving. It should now look something like this:  
![checkpoint_setup](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/65b48a04-046b-4b57-82cd-49a039c311e2)

Alright, let's add some coins!
## Coin Pickup
Go ahead and add a new object, this time a _cylinder_. That's basically a really tall coin. Name this object "Coin". We can shrink the coin to a size of our liking, I will go with a Y value of about .05, and leave X and Y at 1. We can also rotate it 90 degrees to stand it up on its side so its more visible to the player.

On our Coin, click "Add Component" and type _CoinManager_. Then click "new script" --> "create and add". Open this new script.

A nice effect would be gettings this coin to rotate. Take a moment and see if you can figure out how to do that(hint: referenec the RotatingObstacle)


We can make this coin rotate in _Update_ with the following code:  
```C#
transform.Rotate(new Vector3(0, 0, 1) * speed * Time.deltaTime);
```
And we also need the speed variable, set to your desired value, at class level:  
```C#
[SerializeField] private float speed = 50f;
```
We need to add a trigger, but first lets add some management to the _GameManager_, so everything is managed in once place instead of across many coins. Save the current script, and switch over to _GameManager.cs_
We don't need to add much, so I think it would be a good time for a mini challenge! Try and add a function _AddCoin_ that can be called from _CoinManager.cs_ that increases coin count and keeps it stored in _GameManager_ 

<details><summary>Solution</summary>
    
    private int numberOfCoins = 0;
    ...
    public void AddCoin()
    {
        numberOfCoins++;
    }

</details>

Save this, and we can head back to the _CoinManager_.

In the CoinManager, add an _OnTriggerEnterFunction_. We want to call our new GameManager function, and also destroy the coin. Again, try this on your own first, and then see my solution:  

<details><summary>Solution</summary>
    
    private void OnTriggerEnter(Collider other)
    {
        GameManager gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        gameManager.AddCoin();
        Destroy(gameObject);
    }
</details>

Now all that's left(basically) is to set the coin to be _Is Trigger_, and all the backend will be working! We can now add some UI to keep track of this visually.

Also a helpful tip. If you are trying to test things like this, and don't want to play the level each time, you can move the player to a much more reasonable place to save time(and sometimes your keyboards)

Under our _UI_ object, create a new _canvas_. You can all it something like _HUD_ or _display_ since we'll add a couple of things to it. Set the Canvas to "Scale with Screen Size" and set the reference resolution accordingly, preferablly to something like 1920x1080

Now, add a TestMeshPro Text as a child to _HUD_, named _coins_. I am going to align this text in the _Rect Transform_ to the top right of the screen, but any place will do. In the Text field, input something like "Coins: 999". We probably won't get that many coins, but adding a couple extra characters helps ensure some good spacing. Feel free to change the font our sizing, but I like it as is.

Now back to our _GameManager_ script, let's add a new filed to get a reference to the text. While we are at it, let's change the name of _canvas_ to _gameOverCanvas_, and change _canvasText_ to _gameOverText_. This way we keep better names and cleaner code. All of our serialized fields should look something likethis, and don't forget to change other variables in the script:  

```C#
    [SerializeField] private GameObject gameOverCanvas = null;
    [SerializeField] private TMP_Text gameOverText = null;
    [SerializeField] private TMP_Text coinText = null;
    [SerializeField] private GameObject pauseCanvas = null;
```

In _AddCoin_, we can manipulate the coin text, adding a line after the increment line. This time, we'll use a special string formatter, so we can easily add the coin variable to the UI. (There is also normal string concatenation available).
```C#
coinText.text = $"Coins: {numberOfCoins}";
```

The "$" tells C# its a format string, and any variables can be placed in curly braces.
We also want to add something in _Start_ to initialize the text:

```C#
coinText.text = $"Coins: {numberOfCoins}";
```

Save this file and return to Unity.

Select the _Main Camera_ to access the _GameManger_, and hook up the new coin text, along with the GameOver text/canvas if that got disconnected in the name change.

Now if you press play, and roll over to the coin, watch your UI update!  Woo-hoo! Instant feedback for players!

Before we get into lives and checkpoints, feel free to duplicate the coin to any other platforms you added.

## Lives
// UI for Lives  
// Logic  
&ensp;&ensp;// Initial number of lives  
&ensp;&ensp;// Adding of lives by number of coins  
&ensp;&ensp;// hook up to UI  
&ensp;&ensp;// spawning based on Lives  
