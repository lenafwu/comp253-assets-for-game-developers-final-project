# comp253-assets-for-game-developers-final-project

Presentation video: https://youtu.be/m_yiQ5pDZ7U

Final Project Report

Fengting Wu
April 20, 2023


This final project is mainly an attempt to apply the various Blender technics learnt to build cartoon-style 3D models, with reference to real world figures and hand-drew sketches, as natural, detailed, and good-looking as possible. Several animations were designed for the humanoid characters. Simple environment objects are also added as required. Unity project was created with basic set up of movement as a showcase stage for the models. The result is interesting and promising and countless valuable experiences are gained during this journey 😊

Models

•	Tracer - dps, wields two pistols as weapons, has a goggle with transparent glasses, has hand-drew texture for face and pants, has shape keys of blinking, smiling, and frowning, has animations of idle, walk, run, jump, crouch & clapping hands. Inspired by my favorite game character Tracer from Overwatch. See pictures in the reference folder.
•	Angel - healer, uses a staff as weapon, has two moveable wings, has hand-drew texture for face and dress, has shape keys of blinking, smiling, and frowning, has animations of idle, walk, run, jump, crouch & clapping hands. Inspired by my second favorite game character Mercy from Overwatch. See pictures in the reference folder.
•	Hamster - a hamster, only has one animation of walking, as animal armature and weight would need more time to learn. Inspired by game character Hammond from Overwatch. See pictures in the reference folder. 
•	Tracer’s pistol - made from scratch!
•	Glass of water - modelled in Blender, transparent materials created in Unity.
•	Trees [1~3]

Unity Project

Controls
•	F - Attack

•	Space - Jump

•	Left Ctrl - Toggle Crouch

•	I - Clap hands - for my own encouragement!

Th player moves using Unity’s default input for movement.

The camera can be controlled with mouse and follows the player. The player moves forward in the direction where the camera is facing. Enabled with Unity extension Cinemachine.
The script was created to make player move as smooth as possible without rigidbody or colliders due to short time to work on the project.

A box collider was added under the character’s feet as a trigger for ground check to prevent the characters from jumping in the air.

Areas to Improve

The models are easily broken during the animation as no bones and weights are added for different part of clothes. The better way for this project should be to draw the clothes as textures on the body instead of creating mesh for them. 

The animations are all very basic and rigid right now. There should be an animation where characters can walk while crouching. The jumping animations should be split to three stages - start, in the air and off on the ground. 

The result is somewhat satisfying as the animations of movement, turning, jumping, and falling on the ground look good and smooth for now. However, without proper physics setting, it is pointless as the character is unable to interact with other objects. A functional melee combat system with health, hitbox etc. could be implemented to make it a real game.

References & Credits

Glass meterial in Unity: https://medium.com/nerd-for-tech/making-a-glass-material-in-unity-eda50c616463
Blender 3.2 Glass with Ice 3D Tutorial | Polygon Runway: https://www.youtube.com/watch?v=jCVEtLjpeB8&t=182s&ab_channel=PolygonRunway
Blender Speed Modeling Lowpoly Tree in 5 MINUTES in Blender 3d | Low poly 3d Modeling | Lowpoly Tree: https://www.youtube.com/watch?v=jgaaNmplML4&ab_channel=brainchildpl
THIRD PERSON MOVEMENT in Unity: https://www.youtube.com/watch?v=4HpC--2iowE&ab_channel=Brackeys
Video background music: GODDESS OF VICTORY: NIKKE OST - Para-DICE - Hero Road Theme (Extended): https://www.youtube.com/watch?v=daB4npFRL2o&list=PL6vhLV1hjE9E6X1ynPiznccudMTAVHj7J&index=50&ab_channel=deilost
![image](https://github.com/lenafwu/comp253-assets-for-game-developers-final-project/assets/113751598/5e803e3b-393e-4845-afa7-e7e5af81416d)
