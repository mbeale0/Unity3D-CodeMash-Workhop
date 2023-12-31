# Challenge - Create a Pause Menu

It is time to use what you have learned and try it on your own! This is a lot of little pieces, so don't feel bad if you don't get it all!  I just want you to at least try on your own, so when I show you, you know what went wrong and such. Feel free to use the hints you have and if you get stuck I'll show you how to do it. Let's try and take 10 minutes for this.

![Intro to Unity (1)](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/bf7b94a8-73da-49e2-a222-9279ea576bc0)



## Solution
Alrighty! Let me show you how I did it!

Let's start with copying our already existing Canvas, and name this copy "PauseCanvas"

We could in theory do the same thing as with the win/lose Canavas where we change the restart button info to resume, but then we need references to the button, change its text, change its on click method(which would mean we have to change it back for win/lose) and just more complexity then we need. A duplicate canvas keeps it nice and simple.

You may want to disable the other Canvas because they will layer on top of each other making it hard to see. You can do this by selecting the gameobject you wish to disable, anc clicking the check mark right at the top of the Inspector:

![DisableObject](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/d7d90935-b1ac-4041-98e9-ddfa8547a9a6)


In this pause Canvas, set the main text to "PAUSED", and change the text of the Restart Button to "RESUME". We should also change the name of the button object to "ResumeButton". We'll come back to this button in a minute for changing the functionality.

![PauseMenu](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/4664d774-6a9d-4297-94a2-5a2edbe9e8a3)

Now let's create the actual functionality. We'll start with the GameManager Script.

We want a reference to the Canvas:
``` C#
[SerializeField] private GameObject pauseCanvas = null;
```
Deactivate the canvas in start:
``` C#
pauseCanvas.SetActive(false);
```
And finally, a new function
``` C#
public void HandlePause()
{
    Time.timeScale = 0;
    pauseCanvas.SetActive(true);
}
```

Now we can head on over to the player controller and call this new function with a key press:
``` C#
if(Input.GetKey(KeyCode.Escape))
{
    GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().HandlePause();
}
```

Our last thing we need to do is add a function for our resume button in the menu controller, plus a reference to the pause menu:
``` C#
[SerializeField] private GameObject pauseCanvas = null;
...
public void OnResume()
{
    pauseCanvas.SetActive(false);
    Time.timeScale = 1.0f;
}
```

Finally, we can hook it up in the editor:
Let's first off remove the Menu Controller from both Canvases, and create a new empty Object called "UI". Add the menu controller to this object, drag and drop both Canvases to be children of this object, and drag and drop the pause Canvas into the field of the MenuController.

Now let's rehook up all the buttons.

On the normal canvas, expand it so you can access "QuitButton" and "RestartButton". Drag "UI" into their on click methods, and in the "No Function" drop down select the correct method.

Now do the same thing for the pause canvas, and finally hook up the Pause Canvas in the Game Manager Script we added to the camera.

Make sure to save your scene. Play test the game and revel in the fact you can now control time at your will!
