# Coin Pickups & Lives

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

Now all that's left(basically) is to set the coin to be _Is Trigger_, and all the backend will be working! We can now add some UI to keep track of this visually. We can also move this new script to the Scripts folder.

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
Since we already have it set up, let's quickly add some UI to our HUD for lives. Add a TextMeshPro Text object to the HUD canvas, and align it where you please. I will add mine to be underneath the coins, so I will align it to the upper right, and move it down a little.  
![LivesUI](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/1507bd01-09d1-4714-a82b-1fac4f15b3c6)

We can head over to the _GameManger_ script, and handle our lives there.

First, we want to add a private variable(or you can serialize it if you want to change it between levels, for example), an int called _lives_. For now, I'll initialize it to _1_. We also want a serialized field for the UI text.  
```C#
[SerializeField] private TMP_Text livesText = null;
private int lives = 1;
```
Let's set the text in _Start_, just like we did with the coin text:
```C#
livesText.text = $"Lives: {lives}";
```
Then, in _AddCoin_, we can add a step to see if we want to increase the number of lives. For simplicity sake, as it is how many I have in my scene, I will increase lives every two coins. You could also reset the number of coins like they are "spent" by simply setting them to _0_, but I will leave them as it. Players may like to know their total collected. Since we aren't removing coins we have to use the modulus operator, to check if the number of coins is divisible by 0:
```C#
if(numberOfCoins % 2 == 0)
{
    lives++;
    livesText.text = $"Lives: {lives}";
}
```

Now comes a slightly more tricky part, really just in the fact that it involves some moving pieces, and that is the respawning. We could add what we need to the GameManger now, but I think it might be better to work iteratively, so let's headover to our Scripts folder, and create a new script called "CheckPointManager". Open this script.

This will work almost identiacal to _FinishLineManager_, so we can actually copy the code from inside that class. We want checkpoints to also handle checking when the ball enters, and use the _GameManager_ to handle that.

Remove the call to _HandleGameOver_, and replace it with:
```C#
SetCurrentCheckpoint(transform.position)
```

We'll create that function in just a second. This function call passes in a vector3, its position, which is where the ball will(almost) be spawned. Let's go add that function to the _GameManagerScript_, along with a private Vector3 to reference it:
```C#
private Vector3 checkpoint = Vector3.zero;
...
public void SetCurrentCheckpoint(Vector3 position)
{
    checkpoint = position;
}
```

We also need a reference to start for when the player first starts, and on lives 0. There should also be a reference to the player so we can set his position.
```C#
[SerializeField] private Transform start = null;
[SerializeField] private Transform player = null;
```

And a function to handle respawning:
```C#
 public void Respawn()
 {
     lives--;
    livesText.text = $"Lives: {lives}";
     if(lives < 0)
     {
         HandleGameOver("You lose!");
     }
     else
     {
         player.position = new Vector3(checkpoint.x, checkpoint.y + 5, checkpoint.z);
     }
 }
```

Two things to note on the respawn function:
1. When lives are out, we want to reset the player but they need something to work with so we give them one life
2. We check for lives < 0, because when a player has one life, they have more chance, at least in my mind 🙂 Feel free to take some leeway on that/

Now all that is left to do is add the "respawn" function to whenever the player dies, and to hook up all the new fields. Go ahead and give this a try, then check out my solution.

<details><summary>Solution</summary>
In the boundary manager, we simply replace the function call with the call to respawn
    
    GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().Respawn();
After that, we hook up "start", "player" and "lives text" to the GameManger, and add _CheckpointManager_ to the two checkpoints along with start. We also need to add a box collider to start, that is trigger. I added  one with a scale of 5 all around, and moved it up a little bit. Now, we're good to go!
</details>

Congrats! Your game is super solid. We can win and lose, have some actual challenges with obstacles, and an extra challenge with coins. I think it's time to add some polish and make things look better.
