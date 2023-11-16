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
// Add Cylinder and shrink it down to look vaugely like coin  
&ensp;&ensp;// Add world space text with dollar sign?  
// Place this and duplicate over platforms  
// Create Coin Manager Script  
&ensp;&ensp;// Rotation  
&ensp;&ensp;// OnTriggerEnter  
// UI/storage for number of coins  

## Lives
// UI for Lives  
// Logic  
&ensp;&ensp;// Initial number of lives  
&ensp;&ensp;// Adding of lives by number of coins  
&ensp;&ensp;// hook up to UI  
&ensp;&ensp;// spawning based on Lives  
