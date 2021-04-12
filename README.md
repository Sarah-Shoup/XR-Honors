# XR-Honors
Placeable AR Character: Places an animated AR character using a reticle (reticle target will appear on flat surfaces, tap the screen to lock location and place the AR character). Built for Android 7.0+

App 2 [WIP]: Places an AR doorway using a reticle. This doorway can then be walked through to see another "world", and walked back through to return to the "real world". Built for Android 7.0+

  -Placeable AR door: Placement is going okay, and can see the interior through the door. However, when you walk through the door it doesn't allow you to see the interior, but rather swaps and you can see the "interior" objects peeking out the sides when looking back through the doorway (I believe it's just not swapping the shader properly when you walk through?)
  
  -AR doorway: Likewise is okay with placement and looking through the doorway. However, also currently doesn't register that you're "inside the other world" when you cross through the doorway. It almost appears as though the moveThroughDoor script is never activating?