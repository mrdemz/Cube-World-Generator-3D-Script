ClickTile Script Readme
Description
The clickTile script is a Unity MonoBehaviour script designed to handle tile selection and highlighting based on mouse input. It allows users to interact with selectable tiles in the scene by clicking on them. The script enables a visual outline to highlight the selectable tiles when the mouse hovers over them and selects a tile when the left mouse button is clicked.

How to Use
Attach the clickTile script to a GameObject in your Unity scene that contains the selectable tiles you want to interact with.

Ensure that you have a Camera tagged as "MainCamera" in your scene, as the script relies on Camera.main to cast the rays for highlighting and selecting tiles.

Make sure there is an EventSystem in the hierarchy. The EventSystem is required to handle UI events and prevent tiles from being selected while interacting with UI elements.

For the tiles you want to make selectable, tag them with the "Selectable" tag in the Inspector.

Optionally, you can adjust the outline appearance (color and width) by modifying the properties of the Outline component attached to the highlighted tiles.

How it Works
Highlighting: The script uses a raycast from the mouse position to check if it hits a selectable tile. If it does, it highlights the tile by adding an outline effect using the Outline component. When the mouse moves away from the tile or no selectable tile is found, the highlight is removed.

Selection: When the left mouse button is clicked (Input.GetMouseButtonDown(0)), the script checks if there is a highlighted tile. If a highlighted tile is found, it becomes the selected tile, and its outline is enabled. If no highlighted tile is found or if the selected tile is clicked again, the selection is cleared.

Example
Here's an example of how you can use the clickTile script:

Create a 3D plane and raise it slightly to represent a tile.
Add the "Selectable" tag to the plane.
Attach the Outline component to the plane and configure it as desired.
Create an empty GameObject and attach the clickTile script to it.
Run the scene and observe how the tile highlights when the mouse hovers over it and how it becomes selected when clicked.

Note
Remember to have a Camera tagged as "MainCamera" in your scene for the script to work correctly.
Ensure you have the required "Selectable" tag on the tiles you want to interact with.
Make sure to have an EventSystem in the hierarchy to handle UI events and prevent conflicts with tile selection.
The Outline component is necessary for highlighting. If a tile doesn't have the Outline component, the script will add one with default settings.
Disclaimer
This script is a basic implementation for tile selection and highlighting. Depending on your project's specific needs, you may need to extend or modify the functionality of the script to fit your requirements.

Feel free to enhance the script according to your project's needs and enjoy using it in your Unity projects!






GeneratePlatform Script Readme
Description
The GeneratePlatform script is a Unity MonoBehaviour script that generates a platform composed of 36 cubes arranged in a grid pattern. The script calculates the center point of the platform and positions each cube relative to this center, creating a grid-like formation. This script can be used to quickly set up a basic platform for various purposes in your Unity projects.

How to Use
Attach the GeneratePlatform script to an empty GameObject in your Unity scene.

Create a cube GameObject (or any other 3D object) that you want to use as the building block for the platform. Assign this prefab to the cubePrefab field in the Inspector of the GeneratePlatform script.

Optionally, you can customize the appearance of the cube prefab in the Inspector (e.g., changing its color, material, or size).

Run the scene, and the platform will be automatically generated with 36 cubes arranged in a grid pattern.

How it Works
The script creates 36 cube GameObjects using the provided cubePrefab and adds them to a list called cubeList.

It then calculates the center point of the platform by summing up the positions of all the cubes and dividing by the total number of cubes (72 in this case).

Next, the script positions each cube in the cubeList relative to the calculated center point. It uses nested loops to create a 6x7 grid pattern of cubes, where each cube is placed 2 units away from the center in both the X and Z directions.

Note
Make sure to have a prefab assigned to the cubePrefab field in the Inspector. Without a prefab, the script won't be able to generate the platform.

The script is designed to generate a 6x7 grid of cubes, resulting in 42 cubes in total. If you wish to change the size or shape of the platform, you can modify the loops in the Start() method to create a different grid pattern.

You can further customize the platform generation by adjusting the position offsets (e.g., i * 2 and j * 2) to change the distance between cubes in the grid.

Example
Here's an example of how you can use the GeneratePlatform script:

Create a cube GameObject and assign the "Cube" prefab to the cubePrefab field in the Inspector of the GeneratePlatform script.

Create an empty GameObject and attach the GeneratePlatform script to it.

Run the scene, and a platform consisting of 36 cubes arranged in a 6x7 grid pattern will be generated.

Feel free to experiment with different cube prefabs, grid patterns, and cube positions to create various platforms suitable for your project's needs.

Disclaimer
This script is a basic platform generation implementation that can serve as a starting point for more complex platform-building systems. Depending on your specific requirements, you may need to extend or modify the script's functionality to suit your project's needs.




PlayerMovement Script Readme
Description
The PlayerMovement script is a Unity MonoBehaviour script designed to handle the movement of a player or character in the scene. The script allows the player to click on objects tagged as "Selectable" in the scene, and the player will move towards the clicked position at a specified speed. The script uses raycasting to detect the mouse click and calculate the destination position for the player. Additionally, it includes collision handling with objects tagged as "Harvester," which will stop the player's movement upon collision.

How to Use
Attach the PlayerMovement script to the GameObject representing the player or character in your Unity scene.

Create objects that you want the player to be able to move towards and tag them as "Selectable" in the Inspector.

Optionally, create objects that should stop the player's movement upon collision and tag them as "Harvester" in the Inspector.

Adjust the movement speed variable in the Inspector to control how fast the player moves towards the clicked position.

Run the scene and click on objects tagged as "Selectable" to move the player towards those positions. The player will stop moving when colliding with objects tagged as "Harvester."

How it Works
The script uses raycasting to detect mouse clicks. When the left mouse button is clicked (Input.GetMouseButtonDown(0)), it casts a ray from the camera into the scene.

If the ray hits an object with the "Selectable" tag, the script stores the hit position as the targetPosition, ensuring that the player only moves on the horizontal plane by setting the y coordinate of the targetPosition to be the same as the player's current y position.

The script continuously moves the player towards the targetPosition using Vector3.MoveTowards() while the isMoving flag is set to true.

If the distance between the player's current position and the targetPosition becomes smaller than a certain threshold (0.1f), the isMoving flag is set to false, and the player stops moving.

The script also includes collision detection with objects tagged as "Harvester." If the player collides with an object tagged as "Harvester," the isMoving flag is set to false, effectively stopping the player's movement.

Note
Make sure to have a Camera tagged as "MainCamera" in your scene, as the script uses Camera.main to cast rays for detecting mouse clicks.

Ensure that the objects you want the player to move towards are tagged as "Selectable" in the Inspector.

If you want to use collision handling with objects that should stop the player's movement, ensure that those objects are tagged as "Harvester" in the Inspector.

You can adjust the movement speed variable in the Inspector to control how fast the player moves towards the clicked position.

Example
Here's an example of how you can use the PlayerMovement script:

Create a 3D environment with various objects, including objects that you want the player to move towards and objects that should stop the player's movement.

Tag the objects that the player can move towards as "Selectable" and tag the objects that should stop the player's movement as "Harvester" in the Inspector.

Create a GameObject to represent the player character and attach the PlayerMovement script to it.

Run the scene, and the player will be able to move towards the "Selectable" objects upon mouse click. The player will stop moving upon colliding with objects tagged as "Harvester."

Experiment with different movement speeds and object arrangements to fit your project's requirements.

Disclaimer
This script provides basic player movement functionality and collision handling for moving towards specific objects. Depending on your project's specific needs, you may need to extend or modify the script to fit your requirements, such as adding more advanced movement logic or implementing additional interaction features.

QuantumSource Script Readme
Description
The QuantumSource script is a Unity MonoBehaviour script that represents a quantum source in the scene. The quantum source generates a resource called "quantum" over time up to a specified capacity. Players can harvest the quantum by clicking on the quantum source when it is full. The script also displays a floating text above the quantum source to indicate the current amount of quantum available.

How to Use
Attach the QuantumSource script to a GameObject in your Unity scene that represents the quantum source.

Create an empty GameObject to represent the floating text, and assign it to the qsFloatingText field in the Inspector of the QuantumSource script. The floating text will display the current amount of quantum available.

Adjust the capacity variable in the Inspector to set the maximum amount of quantum the source can hold.

Optionally, you can customize the appearance and behavior of the floating text by modifying the TMPro.TextMeshPro component attached to the qsFloatingText GameObject.

Run the scene, and the quantum source will start generating quantum over time until it reaches its capacity.

When the quantum source is full, click on it with the left mouse button to harvest the quantum, and the quantum source will reset to zero.

How it Works
The QuantumSource script extends from a base class called Quantum, indicating that it is part of a larger system for handling quantum resources.

In the Start() method, the script initializes the quantum source with a capacity of 10. It also creates a floating text GameObject and sets up a TMPro.TextMeshPro component to display the current amount of quantum.

In the Update() method, the script increments the quantum source by 1 every 0.5 seconds (adjustable by changing the timer and quantumSource variables). The quantum source will stop generating quantum when it reaches its capacity.

The showFloatingText() method updates the position and text of the floating text to reflect the current amount of quantum available.

The OnMouseDown() method handles the player's click on the quantum source. If the quantum source is at its capacity, it allows the player to harvest the quantum by clicking on the quantum source with the left mouse button. Once harvested, the quantum source resets to zero, and the player can wait for it to generate more quantum.

Note
Make sure to have a Camera tagged as "MainCamera" in your scene, as the script uses Camera.main to cast rays for detecting mouse clicks.

The floating text should be created separately and assigned to the qsFloatingText field in the Inspector. The script will handle updating the position and text of the floating text.

The script uses a base class called Quantum, which may be part of a larger system to manage quantum resources. Ensure that this base class is implemented correctly and available in your project.

Example
Here's an example of how you can use the QuantumSource script:

Create a 3D environment with a quantum source represented by a GameObject in the scene.

Create an empty GameObject to represent the floating text, and customize its appearance using the TMPro.TextMeshPro component as desired.

Attach the QuantumSource script to the quantum source GameObject.

Set the capacity variable in the Inspector to the desired maximum amount of quantum the source can hold.

Run the scene, and the quantum source will start generating quantum over time, displaying the current amount of quantum using the floating text.

When the quantum source is full, click on it with the left mouse button to harvest the quantum, and the quantum source will reset to zero.

Experiment with different values for capacity and the generation interval (timer) to customize the behavior of the quantum source according to your project's needs.

Disclaimer
This script provides basic functionality for a quantum source in a larger quantum resource management system. Depending on your specific requirements, you may need to extend or modify the script to fit your project's needs or integrate it into a more comprehensive game mechanic.


BuildHarvester Script Readme
Description
The BuildHarvester script is a Unity MonoBehaviour script that allows players to build quantum harvesters in the scene. Quantum harvesters are constructed when the player clicks on an object and has enough quantum resources. The script checks for a valid build location, and if there are no existing harvesters within a 3x3 area of the target position, a new quantum harvester is instantiated at that position. The player can build a harvester by clicking a designated build button.

How to Use
Attach the BuildHarvester script to a GameObject in your Unity scene, which will handle the construction of quantum harvesters.

Create a prefab for the quantum harvester and assign it to the quantumHarvester field in the Inspector. The prefab represents the harvester that will be built.

Create a button in your UI canvas and assign it to the buildButton field in the Inspector. This button will trigger the construction of the quantum harvester.

Optionally, you can create an empty GameObject to represent the quantum harvester's text, which will display the current amount of quantum available to construct harvesters. Assign this text GameObject to the qHarvesterText field in the Inspector.

Run the scene, and players can click on objects in the scene to select them. By clicking on the designated build button, the player can build quantum harvesters if they have enough available quantum and there are no other harvesters within a 3x3 area of the selected position.

How it Works
In the Start() method, the script sets up the button click event to call the BuildQuantumHarvester() function when the build button is pressed.

In the Update() method, the script checks for mouse clicks (Input.GetMouseButtonDown(0)) and stores the clicked object in the selectedObject variable using raycasting.

The BuildQuantumHarvester() method is triggered when the build button is pressed. It first checks if the player has enough quantum resources (at least 5) using the base.getQuantum() method from the Quantum base class.

If the player has enough quantum, the script checks whether a valid build location is selected by raycasting to find a target position. The quantum harvester will be placed at the selected object's position, with the y coordinate adjusted to be 4.5 units above the target object.

The script then uses Physics.OverlapSphere() to check for existing harvesters within a 3x3 area around the selected position. If any harvesters are found, the script prevents building and displays a message indicating that a harvester already exists in the area.

If there are no harvesters within the area, a new quantum harvester prefab is instantiated at the target position, and the script subtracts 5 quantum from the player's available resources using base.subtractQuantum(5).

Note
Make sure to have a Camera tagged as "MainCamera" in your scene, as the script uses Camera.main to cast rays for detecting mouse clicks.

The BuildHarvester script is dependent on a base class called Quantum, which is not included in the provided script. Ensure that the Quantum base class is implemented correctly and available in your project.

The quantum harvester prefab (quantumHarvester) should be created separately and assigned to the quantumHarvester field in the Inspector. The script will handle the instantiation and placement of the harvester.

If you want to display the current amount of quantum available for building harvesters, create a UI text element and assign it to the qHarvesterText field in the Inspector. The script will update the text with the current quantum amount.

Example
Here's an example of how you can use the BuildHarvester script:

Create a 3D environment with various objects, including areas where players can build quantum harvesters.

Create a prefab for the quantum harvester and assign it to the quantumHarvester field in the Inspector of the BuildHarvester script.

Create a UI button in your UI canvas, and assign it to the buildButton field in the Inspector of the BuildHarvester script.

Optionally, create a UI text element to display the current amount of quantum available for building harvesters. Assign this text element to the qHarvesterText field in the Inspector of the BuildHarvester script.

Attach the BuildHarvester script to a GameObject in your scene.

Run the scene, and players can click on objects to select a build location and click the designated button to build quantum harvesters.

Experiment with different quantum costs, build positions, and UI elements to customize the quantum harvester construction mechanic according to your project's needs.

Disclaimer
This script provides basic functionality for building quantum harvesters in a larger quantum resource management system. Depending on your specific requirements, you may need to extend or modify the script to fit your project's needs or integrate it into a more comprehensive game mechanic. Ensure that you have implemented the Quantum base class correctly for the script to work as intended.