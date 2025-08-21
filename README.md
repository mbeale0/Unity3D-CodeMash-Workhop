# Intro to Unity 3D Game Development
Welcome to an intro to Unity 3D! Follow along in the labs to fix, improve, and build on a simple roller ball game.

The game you will make is a simple one where the goal is to roll the ball to the end of the level, dodging obstacles along the way. This game may be simple
but you will learn about and engage with many key aspects of game development including programming for obstacles, player controls, and more, UI, Collision, and building your game.

Follow all the steps below _**before starting the training**_ so you are prepared and ready to dive in!

## Pre-requisites:
***IMPORTANT: Installation can take a decent bit of time, so make sure everything is installed and ready to go ahead of time!!!***  
If you need any help installing, ping "@Mason Beale" in the CodeMash [Discord](https://discord.gg/RbZENJ8c73)

**Announcement:** If you cloned this repo _before_ 12/28/2023 noon, please clone again as some branches were updated.

### Previous knowledge
- No knowledge of Unity needed
- At least some object oriented programming experience is highly recommended. We will be using basics such as but not limited to: functions, classes, conditionals, variables and loops.
- Knoweledge of Git/GitHub is preferred, but not required
### Equipment
You'll need a laptop(if attending in person) or desktop with Windows, Linux, or Mac installed
- Unity can run decently well on most laptops, even if they are not super powerful, as long as they aren't already super slow even with things like browsing the internet, but especially for the game we will make, it is not super power intensive
  - Unity official system requirements: https://docs.unity3d.com/Manual/system-requirements.html#editor
  - For more in depth and specifics about RAM, CPU, etc vist here: https://www.cgdirector.com/unity-system-requirements/
    - One quote from that article worth mentioning: "It definitely doesn’t need the latest and greatest hardware, and you can run it just fine on anything released in the last 5 years" (and probably even a few more years than that for what we are doing, but better to be safe)

It would also be recommended to have a mouse instead of a touch pad, as that makes scene navigation easier(IMO)

### Itch.io
As long as there is time, the last lab will involve uploading a build of our game to Itch.io, so to save time, go ahead and register for a (free) account now: https://itch.io/register

### Unity
This will be done using Unity 2021.3.6. You will have to create an account with Unity, just follow the prompts when they appear.
Since this is the basics, any version should work, but it is better to have the same version. Follow the instructions [here](https://github.com/mbeale0/Unity3D-CodeMash-Workhop/blob/master/installation.md) to install Unity.

### IDE
You will also need something to edit the code. If you followed the above steps, VS Community should be installed, which is the _recommended_ IDE to use, as the process to install is much more streamlined and will include more autocomplete features out of the box. 

You can also feel free to install VS Code or Jet brains Rider(free trial), though there may be extra steps involved
 - Click this link for helpful install info: https://docs.unity3d.com/Manual/ScriptingToolsIDEs.html#:~:text=Unity%20supports%20the%20following%20IDEs,JetBrains%20Rider
 - The link also explains how to hook up the IDE to the editor, which can be done when testing your setup in a few moments
 - Follow this [video](https://code.visualstudio.com/docs/other/unity) to install and hook up VS Code. You will need to install SDKs, extensions, etc, so this is very **important** if you wish to use VS Code!
 - Jet Brains is less common, and I have not used it before, so choose this at your own risk.

It may be worth it to create a simple [C# "Hello World" program](https://www.programiz.com/csharp-programming/hello-world) to ensure code completion, intellisense, and general SDK is working. 

### Git
You can manage without Git but it is recommended to have it installed. If you clone using Git there will be progress branches to help stay on pace
 - https://git-scm.com/book/en/v2/Getting-Started-Installing-Git

### Cloning the project
This repo contains a test project and a starter project for the training, so you need the files.

With Git installed, you can clone the project.
 - https://docs.github.com/en/repositories/creating-and-managing-repositories/cloning-a-repository
 - Or you can download as a ZIP

### Unity License
You also need a license to use Unity, and for personal/hobby use, it will be free.
Follow the steps at this link to get your personal license, it only only take a minute: [Instructions](https://support.unity.com/hc/en-us/articles/211438683-How-do-I-activate-my-license-#:~:text=Online%20activation%20steps%3A)

## How to test if it works
It should work just fine, but always good to make sure :) Also a good time to make sure your IDE is hooked up
- In the Unity Hub, at the top right of the window click "Add"
- Navigate to the directory where you cloned the project, and open "RockPaperScissors" in the main folder
- In the middle of the "Projects" tab in the Hub, click "RockPaperScissors" to open the Unity project, and wait for the Editor to open(this might take a minute)
  - The project you are loading is also where you can set up your IDE as mentioned above
- Once Unity loads in the middle window select the "Game" tab next to the "Scene" tab
    - If you see this pop up:  
       ![SkipNewVersion](https://github.com/mbeale0/Unity3D-CodeMash-Workhop/assets/74221606/cc259896-784a-4fe8-b49b-357a206abcaf)
    - Click, "Skip new Version"
- If you see a blank screen on this game tab, open the the "assets" tab in the bottom of the window next to "console"
- From the assets tab, double click to enter the "scenes" folder, then double click the "Main" scene to open that scene
- Once on the proper game scene, click the "console" tab in the bottom of the window to view game results
- Click the play button at the very top of the editor
- If you can play the game, you're all set!

## Finishing Set-Up
We also need to add the main project just like we did above, since there is a small amount of starter content for the actual workshop
Just like before:
   In the Unity Hub, at the top right of the window click "Add"
- Navigate to the directory where you cloned the project, and open "RollerBall" in the main folder
- You're all set! See you at the Kalahari!

## Tentative Schedule
Before starting, make sure you are on the master branch branch. Below is a tentative schedule, which will likely change slightly as time allows

1. Intro and Welcome
 
1. Presentation
   
1. [Lab 1](https://github.com/mbeale0//Unity3D-CodeMash-Workhop/blob/master/labs/lab1.md)

1. [Lab 2](https://github.com/mbeale0//Unity3D-CodeMash-Workhop/blob/master/labs/lab2.md)

1. 1. Break ~5 minutes

1. [Lab 3](https://github.com/mbeale0//Unity3D-CodeMash-Workhop/blob/master/labs/lab3.md)

1. [Lab 4](https://github.com/mbeale0//Unity3D-CodeMash-Workhop/blob/master/labs/lab4.md)

1. [Lab 5](https://github.com/mbeale0//Unity3D-CodeMash-Workhopblob/master/labs/lab5.md)

1. 1. Break ~ 10 minutes

1. [Lab 6](https://github.com/mbeale0//Unity3D-CodeMash-Workhop/blob/master/labs/lab6.md)

1. [Lab 7](https://github.com/mbeale0/Unity3D-CodeMash-Workhop/blob/master/labs/lab7.md)

1. [Lab 8](https://github.com/mbeale0//Unity3D-CodeMash-Workhop/blob/master/labs/lab8.md)

1. Break ~ 5 Minutes

1. [Lab 9](https://github.com/mbeale0//Unity3D-CodeMash-Workhop/blob/master/labs/lab9.md)

1. [Lab 10](https://github.com/mbeale0//Unity3D-CodeMash-Workhop/blob/master/labs/lab10.md)

1. Wrap-up

## Where to go next
I would encourage you to keep learning and (hopefully) having fun with Unity, so I wanted to provide a few different things you can do next:
  - The biggest is to simply keep making games. Several small, yet complete, games are incredibly helpful for learning Unity. Even just for a hobbyist, it is really really good to start smaller(Even smaller than what you're thinking!
    - Game Jams are a wonderful way to do this. There are tons of public online ones, some in person, or even do one solo or with a friend  
  - There are several good courses out there. I tend to like the ones at [gamedev.tv](https://www.gamedev.tv/courses/category/Unity)https://www.gamedev.tv/courses/category/Unity) (Note, _don't_ start with online multiplayer courses).
       - They are paid, but they go on sale quite a lot, Udemy.com also has a lot
  - Explore other areas of game dev to stretch your creative muscles, such as learning Blender, music or audio(gamedev.tv also has some Blender courses)
  - Look into engine/backend/computer graphics if you wanna get technical
  - Also, the Unity Asset Store has _tons_ of great resources, such as models, UI, and even programs. They have many free things available as well, which help for quickly making your game look decent, especially if you just want to show off to friends(note, for commerical projects, check licensing!)

Here is also a handy [link](https://github.com/mbeale0/Unity3D-CodeMash-Workhop/blob/master/README.md#itchio) to a public _.gitignore_ which is great thing to have built for you!

Also keep working on the game today, see what else you can expand on and make, and feel free to ping me  "@Mason Beale" on the CodeMash Discord if you need anything, and I'll do my best.

There are many things you can do of course, but it really comes down to just doing _something_. Be careful of tutorial hell, but don't be afraid of tutorials either. Game dev involves a large variety of software and creative fields, so figure out what you like, and just enjoy yourself 🙂
