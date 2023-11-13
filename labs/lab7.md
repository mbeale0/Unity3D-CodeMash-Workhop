# Coin Pickups & Lives

It's one thing to have a goal the player can aim for over and over again, but I think we should give them extra consequences in the form of lives.

We can do this Mario style, where a certain number of coins will give a bonus life. If they have lives, they can respawn at the most recent checkpoint. If not, then they restart at the beginning. For now we can start with two coins to keep things simple. This will also get us set up for the next two labs, where we add some simple yet improved visual effects, and some gamplay features such as a timer and audio. 

## Setup
First off, let's set ourselves up for places to have coins and our checkpoints.

// Add two cubes for checkpoints  
// copy and paste level base twice  
// Set Tags for start, checkpoints(2) and End  
&ensp;&ensp;// Add transforms on checkpoints and start for spawning(note, we can simply reload level since we have no real save system. TBD)  
  
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
