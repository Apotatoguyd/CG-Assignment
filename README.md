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
Alex: Added moving sand on top of sand shader, added particles to chest on collection, made the textures change on click, added a water trap in the 3rd level with moving shader
