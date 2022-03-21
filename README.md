# HitSpeedTest

Translated to English with DeepL (proofread and fixed by me). There have been various fixes applied and features added.

## Downloads: 
https://github.com/Kuuuube/HitSpeedTest/releases

## Usage: 

Use the dropdown menus to change the keybinds to your preferred bindings.

Set the test value, then, click the reset button or press enter before each test.

There are two types of tests:

1. Timed testing: Set a time, the number of hits is counted within the set time.

2. Click count testing: Set a number of clicks, the time taken to complete the number of clicks is counted.

## Features: 

1. Static BPM graph for easier tracking. (The graph doesn't jump around as your tapping bpm goes up and down.)

	The BPM shown can be configured using the `Max displayed BPM` setting.
2. Two realtime data displays on the graph:

	The green line shows the overall average bpm.

	The blue line shows the average bpm of the last 5 clicks.
3. There is a conflict judgment (K1 cannot be pressed at the same time as M1 and the same for K2 and M2. This is consistent with how it is handled in osu!) 
4. When only a single key is enabled it will be read at double the BPM. This means it will reflect 1/2 timing (typical jumps) instead of 1/4 timing (typical streams) so you can test your singletap speed.