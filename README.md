
This project demonstrates:
- Creating and attaching a C# script in Unity.
- Using Start() and Update() methods.
- Accessing and modifying GameObject components.
- Implementing simple keyboard-based player movement.
- Debugging using Debug.Log().

Setup Instructions:
1. Open Unity and load this project folder.
2. In the Scene, select the Cube (player object).
3. Confirm that the PlayerController script is attached.
4. Press Play and move the cube with WASD or Arrow Keys.

Key Script:
- PlayerController.cs
  * Uses Input.GetAxis("Horizontal") and Input.GetAxis("Vertical") to capture input.
  * Moves the Cube using transform.Translate().
  * Multiplies by Time.deltaTime to ensure frame-rate-independent movement.
