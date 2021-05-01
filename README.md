# XR-Honors
Placeable AR Character: Places an animated AR character using a reticle (reticle target will appear on flat surfaces, tap the screen to lock location and place the AR character). Built for Android 7.0+

App 2 [WIP]: Places an AR doorway using a reticle. This doorway can then be walked through to see another "world", and walked back through to return to the "real world". Built for Android 7.0+

  -Placeable AR door: \**Old version of what is now AR doorway.\** Placement is going okay, and can see the interior through the door. However, when you walk through the door it doesn't allow you to see the interior, but rather swaps and you can see the "interior" objects peeking out the sides when looking back through the doorway (I believe it's just not swapping the shader properly when you walk through?)
  
  -AR doorway: Tap screen to place doorway prefab onto reticle target. Once placed, take care to walk *slowly* through or around the doorway, the scale on these collision objects doesn't always register if you move to fast. Walking into and out of worldA and worldB is going well, added invisiWall around the doorframe to make sure no objects from worlds you're not in or looking into are visible through the doorway (again, be sure to walk slowly and watch the text in the middle of the screen so as to avoid issues from moving through the collision too quickly). Currently working on making world environments more interesting than just a white or blue cube. Also note, this doorway is sized a tad smaller for ease of walking around in the physical/real world.
               
