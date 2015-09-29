================================================================================
I. Full name, email, and prism account name
================================================================================
* Tiffany Zhang
* tzhang76@mail.gatech.edu
* tzhang76

================================================================================
ii. Detail which requirements you have completed, which are incomplete, and
which are buggy (be specific)
================================================================================
All of the core requirements of the project should be complete. Specifically:

* The level was created using a free nature asset pack from the Unity Store. The
  assets were put together using Unity's terrain editor. It includes many big
  trees which are collidable. Some of the smaller trees/bushes are not collidable.
* The model used is Kyle the Space Robot who is free in the Unity Asset Store.
  The rigging's and animation clips for Kyle were downloaded from a free motion
  pack in the Unity Asset Store.
* The controller for Kyle was put together for this project. It can be found in
  the AC folder of Assets and includes:
  * Three input parameters that control animations: grounded (bool),
    speed (float), and powered (bool)
  * Four different states: idle, walk/run, jump, and depowered. Idle is the
    default state.
  * All of the state except idle use blend trees. Walk/run and jump have three
    clips whereas depowered has two. These blend trees use speed as their input
    parameter. For example, the robot only falls to the ground after depowering
    when his speed gets low.
  * The movement of the character is done through a root animation script called
    PlayerRootAnimation.cs. This script can be found in the Scripts folder inside
    Assets.
* The script to take player input and control the robot can be found at
  Scripts/PlayerMovement.cs.

Known Bugs/Issues
* No current bugs in the animation known.
* Jumping is slightly buggy. The game considers you grounded if you are touching
  a tree due to the use of capsule colliders. It is possible to jump over the
  invisible walls bounding the world and fall off over the edge by abusing this.

================================================================================
iii. Detail any and all resources that were acquired outside of class and what
it is being used for(e.g. Asset Bundles downloaded from the Asset Store for
double sided cutout shaders, or this file was found on the internet has link
http://example.com/test and does the orbit camera tracking ).
================================================================================
Asset Sources (All from the Unity Asset Store)
Character
* Space Robot Kyle: https://www.assetstore.unity3d.com/en/#!/content/4696

Animations
* Move Motion Free Pack: https://www.assetstore.unity3d.com/en/#!/content/25900
* Mecanim Warrior Anim Free: https://www.assetstore.unity3d.com/en/#!/content/6127

Terrain
* Painterly Nature: https://www.assetstore.unity3d.com/en/#!/content/22755

================================================================================
iv. Detail any special install instructions the grader will need to be aware of
for building and running your code
================================================================================
* None known.

================================================================================
v. Detail exact steps grader should take to demonstrate that your game meets
assignment requirements.
================================================================================
How to Play
* Use arrow keys to move (Left/Right for turning and Up/Down for moving)
* Use spacebar to jump
* x and c are Kyle the Robot's power buttons. (These controls are animated)
  * If you press x, he deactivates.
  * If you press c, he powers on again.

Notes
* Different combinations of animations and their transitions should look
  relatively smooth.
* Everything is in the Assets folder.
  * The Animation Controller is in the AC folder
  * The clips used are all in the Animations folder
  * Scripts are in the scripts folder

================================================================================
vi. Which scene file is the main file that should be opened first in Unity
================================================================================
* main.unity (Inside Assets root)

================================================================================
vii. URL of the web page where you posted your assignment
================================================================================
* http://tiffzhang.com/m1
