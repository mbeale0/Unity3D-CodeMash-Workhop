# Building our game and uploading to Itch.io
Congrats! You have made a complete and full game, which is something even many passionate game developers struggle with. Way to go!

Of course, when we make a new project, its super fun to let other people play it, so let's actually build our game(so the person doesn't need Unity) and to make it even easier, we will upload it as a WebGL build to gamejolt so it will be super easy to share online, and free!

## Building our game
We will need to create GameJolt accounts, but it _can_ take a while to build a WebGL project, so I want that to be running in the background in case it takes too long.

In the Unity Editor, navigate to "File" -> "Build Settings"  
![image](https://github.com/mbeale0/Unity3D-CodeMash-Workhop/assets/74221606/8aa20ecd-4cba-4b8a-bfe8-9b4111db15a5)  

First, the scenes of the game need to be added to the build settings so Unity knows what to add, so let's click "Add Open Scenes", you could also drag in the scene from the assets pane:  
![image](https://github.com/mbeale0/Unity3D-CodeMash-Workhop/assets/74221606/e4ce9491-47ae-426e-a34a-91faf93e6cbb)

Make sure "WebGL" is selected in the left column, and if you see "Switch Platform" at the bottom right, select that. This will take a minute.
![image](https://github.com/mbeale0/Unity3D-CodeMash-Workhop/assets/74221606/94182bf0-75ea-4c60-90e1-607061e686a0)

Now in the same spot as where "Switch Platform" was, click "Build". Create a new folder called "Build", to build the game in (it is often in the project folder, but it doesn't need to be. Make sure to add to .gitignore if using Git and "Build" is in the project folder). Select your folder and the game will begin to build!

## Uploading To Itch.io
While that is building, navigate to https://itch.io/game/new, and sign in if needed.

The process is very straightforward, but I have included some screenshots to help you as you go. First, make sure to set the title and kind of project, noted by the stars. Unless noted otherwise, you can leave everything else as defaults(but you are welcome to change what you want)  
![image](https://github.com/mbeale0/Unity3D-CodeMash-Workhop/assets/74221606/19a4effc-0689-424a-9602-0727d946f220)  

Let's skip uploading our game for now, to make sure they are all done building. We can set the viewport dimensions to 1920x1080(this may need experimented with) and enable the fullscreen option.
![image](https://github.com/mbeale0/Unity3D-CodeMash-Workhop/assets/74221606/eaf0ed64-c7b6-4c9c-85ae-c0ad71c8eaf9)

Finally, leave "Visibility and access" set to "Draft", and click save. It needs to be saved once to make it public
![image](https://github.com/mbeale0/Unity3D-CodeMash-Workhop/assets/74221606/ee6df430-ba1f-4b6a-bcf5-31b67c6eb236)

Choose either "Early Access" or "Complete", though it doesn't make a huge difference which you choose, it is really just for people browsing the store, and can be changed at any time. The Game page will not be published until later in the process, when you choose.

Now we need to fill in the basic details(note a lot of this is pretty straightforward if you want to go on your own, and if you get stuck, wait till I get to that point). I unchecked "Add to Partner System" but truthfully that only matters for games making revenue.
![image](https://github.com/mbeale0/Unity3D-CodeMash-Workhop/assets/74221606/636a7b93-51b1-4843-aa72-4e208992b2a4)  

On your game page, in the error, click "edit your project"
![image](https://github.com/mbeale0/Unity3D-CodeMash-Workhop/assets/74221606/d1e6a701-c791-4192-8493-7ec2daf8033c)

Now it is time to upload your build, assuming your project is done building. Compress the "Build" folder you built your game in to a standard zip folder in a location of your choosing(probably not your project folder).

Upload that zip folder where it says "Upload files" in your itch.io project edit view. Check "This file will be played in the browser"
![image](https://github.com/mbeale0/Unity3D-CodeMash-Workhop/assets/74221606/24e62d15-bd9c-48e0-9360-c538417ab86b)  

Now just change the visibility to public, save your page and you are good to go!!

## Wrap Up
Again, congratulations! Thanks for going through this course, I hope you enjoyed! I just have a few closing thoughts.
