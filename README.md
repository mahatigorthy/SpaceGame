# SpaceGame

In this Unity game, players take on the role of a skilled pilot navigating through an asteroid field in outer space. The primary objective is to survive as long as possible by dodging incoming asteroids and shooting them down with missiles. Players control the plane's movements using the left and right arrow keys, allowing them to weave through the asteroid obstacles. The spacebar or another designated key can be used to launch missiles at the asteroids. Players earn points for each successfully destroyed asteroid. 

Here's a detailed description of each script:

1. **AsteroidMovement**:
   - This script is attached to asteroids in the game.
   - It checks if an asteroid has moved below a certain point on the y-axis (less than -50).
   - If an asteroid goes below this point, it gets destroyed.

2. **EnemySpawn**:
   - This script handles the spawning of asteroids.
   - Three different asteroid prefabs are defined.
   - In the `Start` method, a function called `asteroidLaunch` is repeatedly invoked every second using `InvokeRepeating`.
   - The `asteroidLaunch` method randomly selects one of three configurations:
     1. Spawns one asteroid at a random x-position.
     2. Spawns two asteroids at adjacent positions.
     3. Spawns three asteroids in a triangular formation.
   - Each asteroid is given a force to move it forward (in the negative z-direction).

3. **Missiles**:
   - This script controls the behavior of missiles.
   - A missile prefab is defined.
   - When the spacebar is pressed, a missile is instantiated at the player's position and given a forward force.
   - When a missile collides with another object, it plays a particle effect, destroys its mesh and collider components, and destroys the other object it collided with.

4. **Movement**:
   - This script handles the player’s movement and shooting.
   - Variables for speed, missile spawn points (left and right), and a missile prefab are defined.
   - A static score variable and a TextMeshProUGUI component for displaying the score are also defined.
   - In the `Start` method, the text component is added to a canvas and assigned a font.
   - In the `Update` method:
     - The player can move left and right using the arrow keys, with constraints to keep them within bounds.
     - The player’s rotation is adjusted to tilt left or right when moving, creating a more dynamic movement effect.
     - Pressing the spacebar fires missiles alternately from the left and right spawn points.
   - A static method `IncreaseScore` updates the score and displays it on the screen.
