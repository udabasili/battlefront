# Battlefront

Welcome to Battlefront! This is a two-player game built with C# using Windows Forms in Visual Studio. Players will engage in exciting battles between characters, each with their own attack and defense stats. The objective of the game is to reduce your opponent's HP (Hit Points) to zero. Let the battle begin!

## Game Preview

![Battlefront](https://github.com/udabasili/battlefront/assets/33573587/e5a0adaf-5d38-4c96-83e2-ecdccb1bc2fb)

## Installation

To run this game, you need to have Visual Studio installed on your system. Follow these steps:

1. Clone this repository to your local machine.
2. Open the solution file (.sln) in Visual Studio.
3. Move the images from the `Images` folder to the `bin/Debug` folder.
4. Make sure to install the Newtonsoft.Json package. You can do this via NuGet Package Manager.
5. Build and run the project.

## How to Play

1. **Starting**: The start screen shows when you run the code and the user(s) would need to click the `Add Player` button and add two players.
2. **Cards Selection**: Once the players have been added, you click the `Start Game` button to start the game. Each player will be given 5 cards from the deck.
3. **Battle**: Players take turns attacking each other. The attack power of the attacking player's character will be compared against the defense of the defending player's character. Damage will be calculated accordingly, and the defending player's HP will only be reduced if the attack power is greater than the defense.
4. **Win Condition**: The game continues until one player's HP drops to zero. The player whose HP isn't zero wins the game.

## Features

- Two-player turn-based gameplay.
- Various characters with different attack and defense attributes.
- Engaging battle mechanics.

## Technologies Used

- C#
- Windows Forms
- Newtonsoft.Json (Make sure to install this package)

## Future Improvements

- Potential to add more functionality and features.

## Contributing

Contributions are welcome! If you have any suggestions, ideas, or bug fixes, feel free to open an issue or create a pull request.

## License

This project is licensed under the [MIT License](LICENSE).
