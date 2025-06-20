This is a simple Pong game built with [Godot Engine](https://godotengine.org/) using C#. The project was created as a learning exercise for C#

## Requirements

- [Godot Engine 4.x (.NET version)](https://godotengine.org/download)
- [.NET SDK](https://dotnet.microsoft.com/download) (for C# support)

## How to Run

1. **Clone or Download the Repository**
    ```sh
    git clone https://github.com/skayaith/Pong.git
    ```
    Or download and extract the ZIP.

2. **Open the Project in Godot**
    - Launch Godot.
    - Click "Import" and select the `project.godot` file in the root folder.

3. **Build C# Scripts**
    - Godot will automatically build the C# scripts when you open the project.
    - If prompted, ensure the .NET SDK path is set correctly in Godot's Editor Settings.

4. **Run the Game**
    - Click the "Play" button (F5) in the Godot editor.

## Running the Project with VS Code

You can also run and edit the project using [Visual Studio Code](https://code.visualstudio.com/):

1. **Open the Project Folder in VS Code**
    2. **Configure VS Code for Building & Debugging**
        - Create a `.vscode` folder in your project root if it doesn't exist.
        - Add your `tasks.json` file for building C# scripts:
          ```json
          {
            "version": "2.0.0",
            "tasks": [
              {
                "label": "build",
                "type": "process",
                "command": "dotnet",
                "args": [
                    "build"
                ],
                "problemMatcher": "$msCompile"
              }
            ]
          }
          ```
        - Add your `launch.json` file for running and debugging:
          ```json
          {
            "version": "0.2.0",
            "configurations": [
              {
                "name": "Play",
                "type": "coreclr",
                "request": "launch",
                "preLaunchTask": "build",
                "program": "C:/Path/To/Godot.exe",
                "args": [],
                "cwd": "${workspaceFolder}",
                "stopAtEntry": false,
              }
            ]
          }
          ```
          > **Note:** Set the `"program"` field to the path of your Godot executable.

    3. **Build & Run via VS Code**
        - Press `Ctrl+Shift+B` to build the project.
        - Press `F5` or select "Launch Godot" in the Run and Debug panel to start and debug your project directly from VS Code.


2. **Install the C# Extension**
    - Install the [C# extension](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) for syntax highlighting and IntelliSense.




## Project Structure

- `Main.tscn` — Main scene for the game.
- `Paddle.cs`, `Ball.cs` — C# scripts for game logic.

## Learning Goals

- Practice using C# through Godot
