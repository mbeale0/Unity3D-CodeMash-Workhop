# Win and lose UI - WIP
With a longer level, basic winning/losing and obstacles, we have a fairly solid base game. If we were doing a simple versioning, this would be like version 1. A basic minimum viable product. I think it's time to start working on "version 2" to keep with that analogy, and flesh out the game a bit. A quick and easy way to this is to have some simple UI when we win and lose so a real player could more easily play again, or quit. (right now we can easily do that in the Editor where we have a play button. That doesn't exist in a build).

## Adding the UI
The UI in Unity is, by default, layered much differently than the rest of our objects. It requires a couple special tools (built-in) to utilize them: a Canvas and Event system:
1. Canvas: "The Canvas is the basic component of Unity UI. It generates meshes that represent the UI Elements placed on it, regenerates the meshes when UI Elements change, and issues draw calls to the GPU so that the UI is actually displayed." [(Source)](https://unity.com/how-to/unity-ui-optimization-tips#:~:text=The%20Canvas%20is%20the%20basic%20component%20of%20Unity%20UI.%20It%20generates%20meshes%20that%20represent%20the%20UI%20Elements%20placed%20on%20it%2C%20regenerates%20the%20meshes%20when%20UI%20Elements%20change%2C%20and%20issues%20draw%20calls%20to%20the%20GPU%20so%20that%20the%20UI%20is%20actually%20displayed) In other words, it handles the visual aspect of UI, like a physical canvas for the painter.
2. Event system: "The Event System is a way of sending events to objects in the application based on input, be it keyboard, mouse, touch, or custom input. The Event System consists of a few components that work together to send events." [(Source)](https://docs.unity3d.com/560/Documentation/Manual/EventSystem.html#:~:text=The%20Event%20System%20is%20a,work%20together%20to%20send%20events.)

Now that we know what we need, let's go ahead and add them. We can add a Canvas much like we add any other gameobject. Adding a Canvas will also add an event system if one does not exist.

_Note: there can be more than one Canvas, but **not** more than one event system_

We add a Canvas by clicking the "GameObject" tab at the tob, but instead of "3D Object" we select "UI", then select "Canvas towards the bottom.

We'll keep going in a little bit but our heirarchy is getting a bit cluttered. We can actually clean it up similar to how we use folder in the asset window. In the heirarchy, right click, and select "Create Empty". Name this new empty gameobject "Obstacles". Empty game objects have nothing more than a transform, but can have components added as needed. We'll just use ours for storage. Select all your obstacles(Either by holding control down while you select them all or hold shift and click the top and bottom of consecutive objects) and drag them over top of the empty object. 

Now do the same thing but for the enviroment objects: Finish line, lightning, start, main platform, and killzone(or feel free to choose your own organization). Afterwards, your heirarchy should look something more like this:
![HeiracrhyClean](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/1a0b4e91-d80f-4ecb-b067-e5b7bf170658)

Okay, I don't know about you, but I feel better now. \*phew\*

Time to get back to our UI. Select your Canvas and find the "Canvas Scaler" component.  For the "UI Scale Mode" field, select the drop down and choose "Scale with Screen size". Under referecnce resolution, you can put "1920" in the x and "1080" in the y. This allows the Canvas to dynamically scale based on our set resolution. 1080p works well since it is a fairly common resolution and somewhat in the middle. It doesn't mean you don't ever have to test different resolutions/ratios, but it is a quick change that makes a big difference.
![CanvasScaler](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/c339e08f-eb24-487d-9116-5dbdca0ec058)

Note that a Canvas also uses a Rect Transform instead of a regular transform. A rect transform represent a whole rectangle for UI, while a transform represents a single point.

Now go ahead and right click on your canvas in the heirarchy and choose "UI" -> "Text - TextMeshPro". You should see a prompt like this come up:
![TMP_Prompt](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/39b58795-ceb4-4fdc-9f0c-ba0e409231a9)

Select "Import TMP Essentials". Don't import the examples and extras, you can just exit out of the tab. Text Mesh Pro, or TMP, is essentially a previously 3rd party text improvement that Unity had bought.

Select your Canvas again, and press "F". Since the Canvas is 2d, you might see a couple weird white lines, but fly around for a second around these and you should see these lines appearing more box like. Angle yourself so the words "New Text" are visible inside this box and you can still see the whole box.
![EmptyCanvas](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/9a09ad21-1ef5-4bc9-b82f-7bba2f55af67)
_*note the tiny star in the bottom left. That's our main level_
  // Talk about anchor points
  // Edit/adjust text
  // Custom fonts
// Add buttons
  // Edit/adjust Buttons
  // Custom UI 

## Adding the code
// Create GameManagerScript
  // public function to end game
// MenuMangerScript to handle buttons
