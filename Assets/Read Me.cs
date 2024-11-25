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
*/