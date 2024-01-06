## Instructions to install Unity/Unity Hub
Perhaps the easiest way to install Unity is through the Hub, which effectivelly manages your projects and editor versions. Follow _all_ the steps below to get everything installed!

1. Navigate to this [link](https://unity.com/download#:~:text=.%20Download%20the%20Unity%20Hub) and under the section "Download Unity Hub" select the option for your operating system, for Windows/Mac, this should download an installer, which you can then run to install Unity Hub. The link for Linux will include instructions.  
  ![image](https://github.com/mbeale0/Unity3D-CodeMash-Workhop/assets/74221606/aeae7e33-2258-44a4-9b37-9b57d5d2eea4)  
1. Once installed, navigate to the [download archive](https://unity.com/releases/editor/archive#:~:text=Release%20Notes-,Unity%202021.3.6,-July%208%2C%202022), where we can pick a specific version, so we can all be one, hopefully reducing some issues. For later projects, feel free to use whatever versions you like, downloading from the hub may be a lot easier for updates.
1. We will be using 2021.3.6, and if you are really concerned about slightly older versions, you could probably go all the way up to 2021.3.33 and have no issues following along, as the patch version is usually much smaller changes.  On the archive page, select the tab "Unity 2022.X" and scroll down till you find the following:  
   ![image](https://github.com/mbeale0/Unity3D-CodeMash-Workhop/assets/74221606/2873d454-0b6d-4159-8114-5fb959021217)
1. Select the button that says "Unity Hub" to start the installation process in the Unity Hub (click allow links to open Unity hub if prompted). Before it actually starts, follow the next step for extra needed installations.
1. We need to also install a couple of modules along with it.
    - First, if you choose to use Visual Studio Community(which is generally recommended but not needed) make sure that is selected. Some more info on IDEs, such as alternatives, can be found in the main ReadMe. I already have it installed, but it will be in this same location with a checkbox:
       ![image](https://github.com/mbeale0/Unity3D-CodeMash-Workhop/assets/74221606/dc79b8e6-6c32-4583-b250-6e7e0ca14d9e)
    - We also need to install a build module, so we can build the game to our target platform, and not just play it in the editor. For this course, we will choose WebGl, which will allow for easy sharing with friends which we will see in the last lab:
      ![image](https://github.com/mbeale0/Unity3D-CodeMash-Workhop/assets/74221606/d4000690-7aaf-496e-9528-0d98e7409f77)
   - Note, the build modules are per editor, but the IDE is one install across all editors(and can be used for non Unity projects as well). If you just want to test some things and not building, you can add the build modules later. 
   - Typically, along with WebGl, you would build to your own OS platform, with the modules noted by their lettering(L for Linux, M for Mac, W for Windows):
     ![image](https://github.com/mbeale0/Unity3D-CodeMash-Workhop/assets/74221606/3a47016d-c6de-4274-85f5-25b545e9fcf0)
      - More modules will increase installation time, so uninstall what you do not need(remember, you can easily install them later!)
1. At this point, if you are installing VS community through the Hub, it should prompt you to install the needed things, so keep an eye out for that window.
    1. If you already had VS Community installed prior to installing Unity, you can open up the VS installer and select "modify" on the desired version. This will take you to the same screen as mentioned above.
1. Scroll down in the list of VS modules to "Gaming" and check "Game Development with Unity"  
    ![image](https://github.com/mbeale0/Unity3D-CodeMash-Workhop/assets/74221606/12a77b60-036c-4cb8-8fef-27d7ac027862)

1. On the right hand side, under "installation details" -> "Game development with Unity", you should see it is installing C#, along with other needed and optional things. We can uncheck "Unity Hub" since we already have that installed:  
  ![image](https://github.com/mbeale0/Unity3D-CodeMash-Workhop/assets/74221606/83d2490e-c3a7-4ac7-b233-9a0968adb3b3)
1. Once that is installed you are good to go! Make sure to follow the IDE setup in the main ReadMe to hook up the IDE (Installing through the Unity Hub should link it up as well, but will be useful for other IDEs, and for a sanity check)
