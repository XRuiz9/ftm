# The Currently Untitled Project That Was Formerly Known as "From Teen Mom"
It just sounded far too serious.

## Womb

### V1.1 - Closing Reception Release
This is an iteration released just a few days later after my final crit. There were a few notes and logistical problems that presented themselves that I needed to be solved, so I took the remaining few days before my mom and friends saw the piece to fix them. Here are the changes:

- Baby's got a body! That's right, I added a fetus with little cabbage patch kid style feet, and also animated it to gently bob around in the womb. I think I'd like to reshape it's body into a more intense fetal position, but I'm not sure how this will affect the viewers ability to see the body. It's really fun to have a little baby body though. I do think I need to update the materials so that the match the spandex more closely. but that would have required more detailed UV mapping of the body parts, which I didn't have the time to do. The fetus body is not perfect and I might go back and change it some day. 

- I also smoothed out the hands since they were a little too low poly.

- She loops. At the end when the water breaks, I disable the entire womb to turn off the light (lol), but there is this issue when I set it back to active it the light's animator sets it to the last frame of the animation, and I don't know how to fix that. So whenever the experience loops any time after the first playback, the womb flashes super abruptly during the introduction. I hate it a lot but it's 3AM and I don't have the time or energy to fix it.

- The experience recenters on HMDMounted(). The headset itself is not being reset. Apparently this can't be done within a game without using Oculus's built-in recenter feature, which most new users would never be able to fucking find. I kind of hate oculus for this. So I decided to reset the experience by moving the entire womb to the players position (offset a touch).

### V1.0 - Final Crit Release
This is the first complete release that was available to the public, and it was completed in a whirlwind of a 24 hour period before my final crit on April 12th. After pulling an all-nighter, I truly could not comprehend anything the critics said, but they seemed intrigued. They said it raised a lot of interesting questions about proximity, bodily presence and autonomy. Of the few critiques I could parse, these are the significant things that I noticed needed to be changed.

1. It needed to be louder: They went on and on about how the audio needed more of a presence. Too bad I didn't turn the headset on to max volume. Still, there is a chance I may need to go back into the audio files and play with volume levels.
2. The womb needed to be centered and the tracking needed to be changed: Because people were repeatedly getting in the headset as soon as other people had gotten out, not sitting through the entire experience, and were different heights, they'd go into the experience, and the womb would be in a place where the chair was not. This may also be a result of me turning off the guardian, which was absolutely essential to making sure oculus did not lose it's tracking while people sat in the chair and kicking them out of the experience.
3. It needed to loop: This needed to happen anyway. I kind of just forgot to add this before the crit, but like I said before, people were entering and leaving the experience much faster than I anticipated, and so three people sat in it before the experience had even finished, and the last person went in after all the audio had played, so they just kind of say inside a silent womb.

## Midway Demo
This is a demo for the first half of my year-long thesis project. This demo served as a proof-of-concept for what I was trying to explore in the relationship between physical and digital sculpture. It is meant to be experienced in tandem with a physical sculpture that exists in real-life, a pink pillow that is also present in the VR experience.

The features are as follows:

Right index-finger pinch: Instantiate pillow
Right middle-finger pinch: Clear all pillows
Left index-finger pinch: Lock instantiation
Left middle-finger pinch: Unlock instantiation

