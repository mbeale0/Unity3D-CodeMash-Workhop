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

Now in the same spot as where "Switch Platform" was, click "Build". Create a new folder to build the game in (it is often in the project folder, but it doesn't need to be. Make sure to add to .gitignore if using Git). Select your folder and the game will begin to build!

## Uploading To Itch.io
While that is building, navigate to https://gamejolt.com, and sign up for an account. Feel free to skip the personalization stuff for now if you wish.

Once you have an account, go to https://gamejolt.com/games, and at the top right, click "Add your Game":  
![image](https://github.com/mbeale0/Unity3D-CodeMash-Workhop/assets/74221606/0acd0d47-aef1-48f9-9e4b-7f0e17f6fb82)  

Choose either "Early Access" or "Complete", though it doesn't make a huge difference which you choose, it is really just for people browsing the store, and can be changed at any time. The Game page will not be published until later in the process, when you choose.

Now we need to fill in the basic details(note a lot of this is pretty straightforward if you want to go on your own, and if you get stuck, wait till I get to that point). I unchecked "Add to Partner System" but truthfully that only matters for games making revenue.
![image](https://github.com/mbeale0/Unity3D-CodeMash-Workhop/assets/74221606/636a7b93-51b1-4843-aa72-4e208992b2a4)  

Click "Save & Next"  

Add a description, I put:
> A fun roller Ball game made during the CodeMash 2024 Conferencec!

For the "Design" all you need is the thumbnail, but feel free to be more creative than me:  
![image](https://github.com/mbeale0/Unity3D-CodeMash-Workhop/assets/74221606/09b303c1-ad95-4a0b-bebb-04daa53a1830)  

Now, "Packages" is the important part. I will leave mine as public and free. Towards the bottom, click "Add Package", then click "New Release"  

GameJolt follows a MAJOR.MINOR.PATCH versioning system, and since our game is techincally done, I will make mine 1.0.0, but again this is really up to you, and really isn't a big deal for a game to share with friends if that's all you want to do.

There are two options, "Downloadable" and "Browser" builds. We want a browser build, but we need to compress our Build folder into a zip file, so hopefully that is done building, and we can do that now. Name it whatever you wish, though I would zip it outside the project folder, since `.gitignore` probably won't catch that.

Upload that zip folder to the "Browser Build Option", and once it is upload, select "Fit to Screen", the "Save Build". While that is processing, we can hit "Publish Release". Clicking "Next Step" we need to set the "Age Rating", which can probably be for "All Ages", and everything can be left as defaults. Once you save that, feel free to hit "Publish" to publish your game!! Though if it is still processing, that will take a moment to finish.

## Wrap Up
Again, congratulations! Thanks for going through this course, I hope you enjoyed! I just have a few closing thoughts.
