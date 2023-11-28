# Improving Our Level - Part One - WIP
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

// Add simple material to platforms

## Skyboxes
Skyboxes are the detail for the whole sky around the environment. With no floor, a full 360 degree skybox gives that fish bubble feeling found in simple mobile games. But skyboxes are used for day/night cycles, weather(visually) and overall providing an atmosphere. For our purposes, they are pretty straightforward. They also affect the lighting of the scene

// Open lighting window  
  // Go to env tab
  // Change skybox
  
## Lighting
Like the other two, we won't be diving as deep as you can go with lighting, but I want to make sure you are at least somewhat familiar.

// settings on light in scene
// baking light and why
