# Unity - VR Room

![com DefaultCompany vr_room-20210624-170851](https://user-images.githubusercontent.com/56147649/123342059-accb5100-d514-11eb-8a58-82afb3930de8.jpg)

### What is this?
A VR escape room created as a project for [Holberton School](https://www.holbertonschool.com/). An [escape room](https://en.wikipedia.org/wiki/Escape_room) is a type of puzzle game in which players have to solve problems in a sequence to escape from a room they are trapped in.

### Why?
This project was intended to familiarize ourselves with VR tools and concepts required to create interactive experiences. Examples include locomotion styles and grabbing objects.

### Requirements of project
- Unity 2019.*

### How to use
Method 1 (recommended, Oculus Quest 2):
1. Download a build of the game from [here.](https://drive.google.com/file/d/1FkaOqmpVFWPQtQkBaz1FZhMZ32W9GTx8/view?usp=sharing)
2. Sideload the game onto an Oculus Quest 2 device by any means of your choice. [SideQuest](https://sidequestvr.com/) is a popular option.
3. In your headset, navigate to the 'Unknown Developer' section of your apps.
4. Launch the game and enjoy!

Method 2 (compatibility not guaranteed, any VR device):
1. Clone this repo to your system.
2. Using Unity 2019.4 or later, import this project.
3. Open the project and select your platform of choice in the build settings.
4. Hit 'Build' and cross your fingers!
5. Deployment from this point varies by platform.

### How to Play
Controls:
  Left Joystick: Move
  Right Joystick: Snap Turn
  Left Trigger: Teleport
  Right Trigger: Click
  Left/Right Grip: Grab
  
Objective:
  Get to the second room and turn on the projector.
  
<details>
  <summary>Walkthrough (Spoilers)</summary>
  
  First Room:
    First you must attempt to open the door to the second room via the button on the console next to it.
    An error will occur and prompt you for an ID Card. The ID card is located on the shelf to the right of the console.
    Grab it and place it in the outlined square on the console. This will clear the error message and allow you to click the open button successfully this time.
    
  Second Room:
    In the second room you will see a monitor saying something about objects out of place. You must find these objects and put them where they belong.
    There is no specific order for these items, but they are located as follows:
      - Pillow under the bottom bunk of the bed. Belongs next to the other pillow on the bottom bunk.
      - Chess piece under the aforementioned pillow. Belongs on the chess board on the other side of the room.
      - Chess piece in the left most planter in the hallway coming from the first room. Belongs on the chess board.
      - Chess piece on the shelf in the first room behind small boxes. Belongs on the chess board.
      - Chess piece on top of the large crate in the back left corner of the first room. Belongs on the chess board.
      
</details>

### Implemented Features
- **Instant Teleport**

  Usage: Hold the left trigger to aim, use the left stick to choose orientation, and release to teleport.

  What it does: Teleports the user to a location, facing a certain direction. It is a form of player movement that is much more comfortable than normal joystick movement.

- **Joystick Movement**

  Usage: Left joystick will move the character around.

  What it does: A very basic, albeit uncomfortable form of character movement that allows for finer control and ease of use.

- **Snap Rotation**

  Usage: Right joystick will rotate the character by 45 degrees in either direction.

  What it does: Allows players with less space to be able to turn their character without moving their head/body. The snapping is usually much more comfortable than continuous rotation.

- **Distance Grab**

  Usage: Point either hand at any object with a white outline. If it is in range, the outline will turn green. Press the grip button when in range for the item to snap to your hand.

  What it does: Allows for a simple way to grab items even if they happen to be just out of reach. A great solution for players with less space.

### Challenges
- Getting the different features like teleport and joystick movement to work together.
- Testing without full deployment. Test runs behaved different from full deployment, but full deployment takes too long for small changes.

### Known Bugs
- The teleport feature throws the player the opposite direction. I have figured out why and implemented a fix, but the fix only seems to work on PC.
- UI interaction (such as the console in the first room) does not work on PC.
- Placing the ID card on the podeum is difficult due to physics interactions.

## Developers
### Sean Taylor
- LinkedIn: [Sean Taylor](https://www.linkedin.com/in/madmansilver/)
- Twitter: [@MadmanSilver](https://twitter.com/MadmanSilver)
