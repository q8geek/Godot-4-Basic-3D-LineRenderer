
# Godot 3D LineRenderer in C#

I couldn't find a good LineRenderer in C# for Godot that feels similar to Unity's LineRenderer, so I figured I'd make my own and share it.

## Demo

Here's a demo of how it'd look like (The white spheres are just to show where the points are, not a part of the script):

![](https://github.com/q8geek/Godot-4-Basic-3D-LineRenderer/blob/main/lineRenderer.png)
## Features

- An array of Vector3 to draw the line with
- Width in float or curve
- Boolean value to whether draw the line continuously or on demand
- Draw() to instantly draw the line when needed


## Installation

To use this script:

1. Copy `LineRenderer.cs` to your project's folder
2. Create a `MeshInstance3D` Node
3. Attach `TrailRenderer.cs` to the created node
4. Have fun!

Please make sure you attach materials to your liking and preferences.
## License

[The Unlicense](https://choosealicense.com/licenses/unlicense/)