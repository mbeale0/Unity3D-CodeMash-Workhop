# Improving Our Level - Part One
These next two labs will go hand in hand, both focusing on improving our level and hopefully making it feel a bit more like our own. Across both labs we will cover several different things, some not directly related, but enough that we could bundle it all together. I split it across to labs to just make it more manageable.

I will also give some time after the next lab to let you all customize your levels, so feel free to just follow along right now, then go and explore

## Materials
The first thing we will take a look at is one of the most important when it comes to improving our games visual appearance, and this is materials, or really, colors. These work very similar to textures which provide much more detailed and custom looks, and are even applied to objects much the same way. Since they are similar and we do not have built in textures, we will just stick with materials for now.

I already have one material created, which is the color green that is on our ball. Head over to /Assets/Materials to find the material called "DarkGreen". Click this so we can view it in the inspector. There are a lot of fields here that go way beyond the scope of this course, but there are several we can understand and see a quick difference. It may help to view the player in the inspector to see changes.

The first setting is "Rendering Mode" which has four options:
1. Opaque - Default, used for solid, non-transparent object
2. Cutout - Object can be 100% opaque or 100% transparent. "useful when using transparency to create the shape of materials such as leaves, or cloth with holes and tatters"
3. Transparent - Allows an object to become transparent but still render things like reflections, so useful for things like glass
4. Fade - Similar to transparent, but also fades out things  like reflections
Some more info [here](https://docs.unity3d.com/Manual/StandardShaderMaterialParameterRenderingMode.html)

Up next is the albedo, or the RGBA values(red, gred, blue, alpha) which allows you to set color and transparency.  
![ColorPicke](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/b0b6ee09-2998-4f47-be1c-7c618535ffed)

1. You can use the color wheel and square to find the best colors(picking the general color on the wheel gives you shades of that color)
2. You can manually set the RGBA values(each has a range of 0-255)
3. You can use hex values

The next two we care about for this are right under albedo: metallic and smoothness(the opposite of a common property called roughness). These two values are often confused, as it seems they do similar things. User "bgolus" on the Unity forums gives a good comparison:  
> "Metal objects reflect light differently than non metal objects. The "metallic" property is more literally "is this object made of metal or not" and should be either be 0.0 or 1.0 for real world objects. 
  Using values in between can sometimes work as approximations of more complex real world materials, like a metal surface covered in dust, but generally should be avoided. 
  The main difference between metal and non-metal (dielectric is the technical term) surfaces is metal reflects the same amount of light regardless of it's facing toward you or away from you,
 and that light is tinted by the color of the metal. Dielectric materials reflect only some of the light when the surface is facing towards, but reflects more light the closer to a glancing angle it gets.
  ...
  Smoothness on the other hand is how smooth or rough the surface is. A metal sphere can have a rough or smooth surface and look quite different" - [source](https://forum.unity.com/threads/metallic-v-smoothness.524704/)

Let's take a look at Unity's reference for smoothness, with a handy chart and other info [here](https://docs.unity3d.com/Manual/StandardShaderMaterialParameterSmoothness.html#:~:text=A%20range%20of%20smoothness%20values%20from%200%20to%201) 
And let's take a look at their one for [metallic](https://docs.unity3d.com/Manual/StandardShaderMaterialParameterMetallic.html#:~:text=a%20surface%20is.-,Metallic%20Property,-The%20Metallic%20Property)

Those are the main settings that we care about for this training, but remember the "tiling" and "offset" ones, as those are used for what is essentially scaling textures.

We will spend more time on improving our levels soon, but for now to demonstrate, I'll add a couple of quick materials and apply them.

In the materials folder, right click to open the context menu, click "create", then "Material":  
![CreateMaterial](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/ea226478-a87f-4bad-9fe1-fcb0a7fd3918)  

Name this "Gray" (or "grey" if you insist 🙂)

Keeping it simple for now, I'll just change the albedo by clicking on the white color bar and draging the center circle to the middle left area, where gray is. I can no click and drag this object into the scene. Any object I hover over, and then let go of my mouse on, will have this material applied. (note, be careful of the UI canvas, that can get in the way). I'm gonna add this gray material to my three main platforms and the two coin platforms.

I'll also repeat this process, adding a new color, "yellow", which I will apply to my coins.

And now, even with just a couple of simple materials, our level looks so much better, if nothing else because there is contrast between objects:  
![SimpleColors](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/6b09c98f-4ea4-4242-8692-70ff8d38deeb)


## Skyboxes
Skyboxes are the detail for the whole sky around the environment. With no main floor or environment, a full 360 degree skybox can give that fish bubble feeling found in simple mobile games. But skyboxes are used for day/night cycles, weather(visually) and overall providing an atmosphere. For our purposes, they are just static, though they also can affect the lighting of the scene, though you can turn that off in the lighting settings.

If you navigate to /Assets/SkyBoxes, you should see several skyboxes I got from the Unity Asset store. Similar to materials, you should get a quick idea of what they look like.

For this asset pack, the ones starting with "6sided" will cover the entire environment. (The default one is not 6 sided). Though, regular ones still have some impact on the bottom half, just not as distinct. 

I like the first one: "6sided Cosmic Cool Cloud". Go ahead and select one for now to get an idea, and we can try out more later. Much like materials, we can just drag them into the scene, except on the "void" and not any particular object. Whichever one you choose, be sure to select it in the project tab, so it is opened in the inspector. 6 sided skyboxed will have 6 textures. The regular kind will just look like a material.

For both types, you have three main fields to add further customization: Tint, Exposure, and Rotation. These do pretty much what you expect. Tint changes the color output from teh skybox, which can dramatically change some of them(it doesn't simply add a tint, it overlays it very well). The exposure turns up the brightness, which affects the color of the scene as mentioned before. The rotation simply rotates the skybox. After quickly messing with those valuesm this is a peak of my scene:  
![image](https://github.com/mbeale0/Unity-Intro-Project/assets/74221606/cca162b4-6cf1-4bf9-9607-597271c00eae)

## Lighting
As with everything else in Unity, you can go incredibly deep on just a couple things, and that is especially true with lighting, so we are just going to look at a couple different lighting sources, and some main fields that we are more likely to change. This is a kind of info dump, so dont worry about remembering every detail 🙂 Feel free to refer back to this later.

In the hieracrchy, expand the "Environment" object, and select "Directional light". I want us to look at the first 6 fields, and encourage you to look into it more later. Information below and for other fields from [here](https://docs.unity3d.com/Packages/com.unity.render-pipelines.universal@7.2/manual/light-component.html#:~:text=The%20Indirect%20Multiplier%20defines%20the,light%20brighter%20with%20each%20bounce.)
1. Type - "The current type of light. Possible values are Directional, Point, Spot and Area."
     - Point Light, a Light that’s located at a point in the Scene and emits light in all directions equally
     - Spot Light, a Light that’s located at a point in the Scene and emits light in a cone shape
     - Directional Light, a Light that’s located infinitely far away and emits light in one direction only
     - Area Light, a Light that’s defined by a rectangle or disc in the Scene, and emits light in all directions uniformly across its surface area but only from one side of the rectangle or disc
3. Color - "Use the color picker to set the color of the emitted light"
4. Mode - "Specify the Light Mode used to determine if and how a light is "baked". Possible modes are Realtime, Mixed and Baked."
    - Baked: Unity pre-calculates the illumination from Baked Lights before runtime, and does not include them in any runtime lighting calculations.
    - Realtime: Unity calculates and updates the lighting of Realtime Lights every frame at runtime. Unity does not precompute any calculations for Realtime Lights.
    - Mixed: Unity performs some calculations for Mixed Lights in advance, and some calculations at runtime.
5. Intensity - "Set the brightness of the light. The default value for a Directional light is 0.5. The default value for a Point, Spot or Area light is 1"
6. Indirect Multiplier - "Use this value to vary the intensity of indirect light. Indirect light is light that has bounced from one object to another"
7. Shadow Type - "Determine whether this Light casts Hard Shadows, Soft Shadows, or no shadows at all."
    - "Hard shadows take the nearest shadow map pixel. Soft shadows average several shadow map pixels, resulting in smoother looking shadows. However, soft shadows are more expensive to render."   

There are also a couple more standard fields for Spot lights(and one of them is also for point lights:
1. Range(both point and spot) - "Define how far the light emitted from the center of the object travels"
2. "Define the angle (in degrees) at the base of a spot light’s cone"

It is also useful to know about the lighting tab, found in "Window" -> "Lighting" that contains a lot of useful fields and settings as well, which we will not be getting in to here.

Alright, it's time to move on to "Improving Our Level", part two! We will look at adding some more obstacles, a timer, and some audio. Then you'll get some time to just work on your level! Let's get going! 
