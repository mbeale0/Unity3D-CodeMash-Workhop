# Intro to Unity 3D Game Development
Welcome to an intro to Unity 3D! Follow along in the labs to fix, improve, and build on a simple roller ball game.

The game you will make is a simple one where the goal is to roll the ball to the end of the level, dodging obstacles along the way. This game may be simple
but you will learn about and engage with many key aspects of game development including programming for obstacles, player controls, and more, UI, Collision, and building your game.

Follow all the steps below _**before starting the training**_ so you are prepared and ready to dive in!

## Pre-requisites:
### Previous knowledge
- No knowledge of Unity needed
- At least Object Oriented programming experience is highly recommended. We will be using basics such as but not limited to: functions, classes, conditionals, variables and loops.
- Knoweledge of Git/GitHub is preferred, but not required
### Equipment
You'll need a laptop(if attending in person) or desktop with Windows, Linux, or Mac installed
- Unity can run decently well on most laptops, even if they are not super powerful, as long as they aren't already super slow even with things like browsing the internet, but especially for the game we will make, it is not super power intensive
  - Unity offical system requirements: https://docs.unity3d.com/Manual/system-requirements.html#editor
  - For more in depth and specifics about RAM, CPU, etc vist here: https://www.cgdirector.com/unity-system-requirements/
    - One quote from that article worth mentioning: "It definitely doesn’t need the latest and greatest hardware, and you can run it just fine on anything released in the last 5 years" (and probably even a few more years than that for what we are doing, but better to be safe)

It would also be recommended to have a mouse instead of a touch pad, as that makes scene navigation easier(IMO)
### Unity
This will be done using Unity 2021.3.6. 
Since this is the basics, any version should work, but it is better to have the same version. You can download it from here: [Unity Download](https://unity.com/releases/editor/archive) (Unity Hub recommended, but not needed)
 - Follow this video till the end for steps to install, starting at 2:19: https://youtu.be/Kh_FD0Ypdhg?t=139
 - This Method will also install an IDE, VS Community, which will be hooked up to Unity by default
 - In one lab we will build and upload a web build so in the modules make sure to include "WebGL Build Support"
For builds to run on your local machine you can do that following. Windows can leave as default
 - For Mac users, you need to check "Mac Build Support (Mono)" and uncheck "Windows Build Support"
 - For Linux, to install Unity Hub: https://docs.unity3d.com/hub/manual/InstallHub.html#install-hub-linux
 - For the purpose of this tutorial, Linux users can choose either mono or IL2CPP when choosing "Linux Build Support" in the modules
### IDE
You will also need something to edit the code. If you followed the above steps, VS Community should be installed. You can also feel free to install VS Code or Jet brains Rider(free trial)
 - https://docs.unity3d.com/Manual/ScriptingToolsIDEs.html#:~:text=Unity%20supports%20the%20following%20IDEs,JetBrains%20Rider
 - The link also explains how to hook up the IDE to the editor, which can be done when testing your setup in a few moments

Intellisense/compiler error warnings and such should be set up automatically especially if using VS community, but I have had some issues with dotnet on Linux for IDE information so it may be worth it to create a very simple "Hello world" dotnet program to see if you get things like intellisense and the red squiggles, as this is(usually) not a direct issue 
with Unity.

### Git
You can manage without Git but it is recommended to have it installed. If you clone using Git there will be progress branches to help stay on pace
 - https://git-scm.com/book/en/v2/Getting-Started-Installing-Git
### Cloning the project
This repo contains a test project and a starter project for the training, so you need the files.

With Git installed, you can clone the project.
 - https://docs.github.com/en/repositories/creating-and-managing-repositories/cloning-a-repository

Or you can download as a ZIP
## How to test if it works
It should work just fine, but always good to make sure :)
- In the Unity Hub, at the top right of the window click "open"
- Navigate to the directory where you cloned the project, and open "RockPaperScissors" in the main folder
- Once Unity loads, if the game is not on the center screen click the "assets" tab in the bottom of the window next to "console"
- Double click to enter the "scenes" folder, then double click the "Main" scene
- Once on the game scene, click the "console" tab in the bottom of the window to view game results
- Click the play button at the top of the editor
- If you can play the game, you're all set!
