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

Select your Canvas again, and press "F". Since the Canvas is 2D, you might see a couple weird white lines, but fly around for a second around these and you should see these lines appearing more box like. Angle yourself so the words "New Text" are visible inside this box and you can still see the whole box.

![EmptyCanvas](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/9a09ad21-1ef5-4bc9-b82f-7bba2f55af67)
_*note the tiny star in the bottom left. That's our main level_

In the rect transform of the new text object, find the square that says "center" and "middle"

![RectSquare](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/a72152ac-bddd-4e03-ae15-a7ae6d5fac38)

Click that square, and in the grid of options, click the one that lines up "top" and "center"

![TopCenter](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/1b28ec0e-9f7a-4d0c-8412-6e2c9b47064c)

This sets the anchor points of the UI object. If you look at the top center of the Canvas now, you'll see four little arrows, which are the anchor points.

You can adjust them manually in the scene, or using the _anchors_ field in the Rect Transform. however, using the quick tool that we just did more than not works just as well. The anchors are "used to determine the position and scaling of a UI element relative to its parent" - [Source](https://www.linkedin.com/pulse/navigating-unity-ui-anchors-pivots-iman-irajdoost/) In other words, they set the origin of the object.

![Anchors](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/a58eebea-dc6f-4c70-93ae-e88dd063bf84)

Go ahead and set the Y position of the Text object to 0. This will move the text to now be at the top of the screen, with the anchor points again in the center. Anchors are useful for layout of your UI and for scaling with screen sizes/aspect ratios. Unity will know the object should be moved relative to the anchors instead of smushing everything back into the middle.

_Hint: after clicking the anchor widget in the Rect transform, hold alt when clicking to move the object at the same time you set the anchor points_

If you switch to the game view, you should notie the next about halfway cutoff, since it is outside of the canvas boundaries. Let's set the Y position to about -100 and bring it down. Also note with the anchor points being the oring, despite the text being in the top half of the Canvas, the position is in the negatives since it is below the anchors.

For simple text on screen, we also want it to be centered both vertically and horizontally, so that way, however we adjust the transfom is how the text is moved. We can set that in the alignment in "TextMeshPro - Text (UI)" (I'll refer to this component simply as the text component from now on). We select the second option of both rows.

![Alignment](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/d2f40ac9-c775-430d-a8be-261c56ac28b7)

The text is also quite small, we can adjust the size but it will be limited by it's transform, so let's increase that by a factor of three. We can actually do simple math right in the width/height fields:
`200*3` and `150*3`, will get us 600 and 450.

![Size](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/c7a09f87-329a-4b0e-88a6-8fc4ee253ca9)

Now we can comfortably resize the text. In the text compoent, we can manually size the text, but as we have talked about,  we want things to scale with the screen. So instead, we will select "Auto Size".
This gives you some differnt options. The max value is what we care about here. I set mine to "125" but it is really up to you. I would start smaller and work your way up, because you could have a font size bigger than your transform can even fit, which isn't necessary, though it likely wouldn't hurt anything

![FontSize](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/b7925bde-8d4c-44c4-8c55-fb1d38cb2ee4)

It is also helpful when determining size to add it to the Text box at the top of the text component. Something like "You Win!!!" or whatever you would like the win screen to say. This can also later be set in code.

Let's also change the color of the font to make it stand out a bit more. We do that by clicking the white bar next to "vertex color", and draging both circles in the inner square and outer circle till we get our desired color. You can also set it by hex, RGB, and set the alpha, which changes the transparency. I set mine to a nice red for now.

![NiceRed](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/263cdd8c-ff94-4efe-93d0-51c7bb262582)

Before we add some buttons, let's navigate to the "Fonts" folder in Assets. I am going to go with the "RoughBattleFont" but you can choose whichever you prefer, or come back later to try them. 

Before we can use them, we have to convert the font to Text Mesh Pro. We do this by going to Window -> TextMeshPro -> FontAssetCreator

![FontCreator](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/9822cc10-dc93-43ff-a4c4-2b0c7757fcfa)

If we click the bullseye next to the "None(Font)" field, a whole list of fonts will show up. Double click the one you want. then click Generate font atlas. After it generates, you can click "Save-As" and save it in the fonts folder. Close the FontAssetCreator Window.

Navigate back to the text object, and under the text component find "Font Asset" Click the bullseye on the right and select your font. And congrats! Your game is already starting to look good!

![COmpleteFont](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/c2c5dccd-673b-4e05-a24f-fed757606e00)

It looks good, but let's add something we can give functionality too, in the form of buttons!

Add a button just like we added the font. Right click on Canvas -> UI -> Button - TextMeshPro. Name this button "RestartButton".

Feel free to add anothe custom font to this by selecting the dropdown arrow in the inspector next to the object in the inspector and selecting the child text objext. You can change the font in the exact same way as before, by clicking the bullseye next to "Font Asset". While changing the font, let's change the text to "RESTART"

Reslect the button.

Let's get these buttons
  // Edit/adjust Buttons
  // Custom UI 

## Adding the code
// Create GameManagerScript
  // public function to end game
// MenuMangerScript to handle buttons
