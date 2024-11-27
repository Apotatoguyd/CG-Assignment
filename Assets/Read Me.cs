/*
 This is a Read me for instructions on how to use the Shaders in the game.

The code for the hologram shader are very close to what we went over in class. What was changed is the lack of an invisible part of the shader.
This is done as a design feature so it's easier to see where the chest is, and is more of a glowing texture.

The Rocks texture is also close to what was covered in class for diffused textures. What changed from the class version is the addition of metallic sliders.
This is done to add a slight shine to the objects as to not make the map feel 2D.
The Sand texture uses the same Rock texture shader but changed the texture used to be more fitting of sand.
https://assetstore.unity.com/packages/2d/textures-materials/floors/yughues-free-sand-materials-12964

The LUT was edited to create a toon feel to the game, since toon shaders don't work very well with flat surfaces the LUT is used to fix that. 



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
*/