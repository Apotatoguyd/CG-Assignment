Our game focuses mostly on the toon feel of the game
It focuses on problem solving abilities of the player to find and collect 3 chests from each level within the time limit
Each level gets progressively harder with more time to accommodate for the difficulty
This game is meant for speedrunners, puzzle solvers and anybody who likes the look of toon style games
Changes between Assignment 1 and here. We have added more shaders, normals to the rock and sand shaders, and features to make the chests more visible to the player
For the shaders the player and the Chest used the same shader script just different materials in our course project we have separated it into 2 different shaderlabs scripts with their own properties with the player having no hologram,
because with the color tint and makes it look almost white and overrides the toon shading. To replace the hologram shading for the player we instead used the outline shader to make it pop out. 
The chest will keep its hologram but loses its color tint because the hologram already does it and it overrides the texture. But the hologram has reduced power (10 in assignment 1, 1 in course project) so that the texture and toon shading can shine.
We added normal mapping for our rock and sand textures as well as moving images for our sand texture.
We changed the player model from a square to a circle so the outline looks much better.
We also added the toon shader slider for the player so we can adjust the toon shading without going back to the script.
Erik: Implemented the normals of the sand shading, redid the hologram, toon and added the outline shading as well as making the chests spin and redid the player.
Alex: Added moving sand on top of sand shader, added particles to chest on collection, made the textures change on click, added a water trap in the 3rd level with moving shader with waves, and added pixelation effect on the scenes


COURSE PROJECT CHANGES

Revised player shader: changed to make the player have a toon feel
Added default textured material. reasons for each colour:
   rock: stone-like colour, makes the game have a natural setting
   sand: sand, similar colour to what you would find on a beach
   player: high contrasting colour so it's easy to see on the sand/rock textures
   chest: colour is used for glow, made for the chest to pop-out from the surroundings
moving textures: the sand and the water in level 3 has a moving texture on it. both have it to simulate the feel of wind, blowing the sand across the ground and small waves in the water
waves: as mention before the wind feel adds to the natural feel of the game, adding waves to the water adds to it further
particles: added explosion when interacting with a chest, this is mostly for fun and feedback for collecting it


sand texture: https://assetstore.unity.com/packages/2d/textures-materials/floors/yughues-free-sand-materials-12964
water texture: https://assetstore.unity.com/packages/2d/textures-materials/water/stylize-water-texture-153577
particle effects: https://assetstore.unity.com/packages/vfx/particles/legacy-particle-pack-73777
