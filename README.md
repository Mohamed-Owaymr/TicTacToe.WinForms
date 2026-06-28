# 🎮 TicTacToe — WinForms Edition

<p align="center">
  <img src="https://img.shields.io/badge/Platform-Windows-blue?style=for-the-badge&logo=windows" />
  <img src="https://img.shields.io/badge/Language-C%23-purple?style=for-the-badge&logo=csharp" />
  <img src="https://img.shields.io/badge/Framework-.NET%204.8-blueviolet?style=for-the-badge&logo=dotnet" />
  <img src="https://img.shields.io/badge/UI-WinForms-orange?style=for-the-badge" />
  <img src="https://img.shields.io/badge/License-MIT-green?style=for-the-badge" />
</p>

<p align="center">
  A clean, well-architected <strong>Tic Tac Toe</strong> desktop game built with <strong>C# Windows Forms</strong> and <strong>.NET Framework 4.8</strong>. Featuring a clear separation between game logic and UI, custom image assets for X and O markers, and a polished two-form interface — this project is both a fun game and a solid reference for clean WinForms architecture.
</p>

---

##  Preview

> *Launch the game, enter player names, and battle it out on the classic 3×3 grid — all rendered with crisp custom graphics.*

---

##  Features

| Feature | Description |
|---|---|
| 🧠 **Clean Architecture** | Game logic is fully separated from the UI layer into a dedicated `Core/GameLogic.cs` class |
| 🎭 **Two-Form UI Flow** | A welcoming `MainForm` for setup flows into a dedicated `PlayForm` for gameplay |
| 👥 **Two-Player Mode** | Full local multiplayer — no AI required, just two human players taking turns |
| 🖼️ **Custom Image Assets** | X and O moves rendered with custom PNG images (`X.png`, `O.png`) for a polished look |
| 🏆 **Win Detection** | Automatic detection of all winning combinations (rows, columns, diagonals) |
| 🤝 **Draw Detection** | Gracefully handles a fully-filled board with no winner |
| 🔄 **Game State Management** | `GameState` enum cleanly tracks game phases (Playing, Win, Draw) |
| 👤 **Player Model** | Dedicated `Player` model class encapsulating player name and symbol |
| 🎨 **Background Theming** | Custom background image (`TicTacToeGameBackground.png`) for visual flair |

---

##  Project Structure

```
TicTacToe.WinForms/
│
├── Core/
│   └── GameLogic.cs          # All game rules, win/draw detection, turn management
│
├── Enums/
│   └── GameState.cs          # Enum: Playing | Win | Draw
│
├── Models/
│   └── Player.cs             # Player entity (name, symbol: X or O)
│
├── UI/
│   └── Forms/
│       ├── MainForm.cs        # Entry screen — player setup & game launch
│       ├── MainForm.Designer.cs
│       ├── PlayForm.cs        # Main gameplay screen with the 3×3 board
│       └── PlayForm.Designer.cs
│
├── Resources/
│   ├── X.png                  # Custom X marker image
│   ├── O.png                  # Custom O marker image
│   ├── TicTacToeGameBackground.png
│   └── question-mark-96.png
│
├── Properties/
│   ├── AssemblyInfo.cs
│   ├── Resources.resx
│   └── Settings.settings
│
├── Program.cs                 # Entry point — launches MainForm
├── App.config
├── TicTacToeGame.csproj
└── TicTacToeGame.slnx
```

---

##  Architecture Overview

This project follows a clear **separation of concerns** pattern:

```
┌─────────────────────────────────────────────────────┐
│                     UI Layer                        │
│  MainForm (Setup) ──────────► PlayForm (Gameplay)   │
└────────────────────────┬────────────────────────────┘
                         │ calls
┌────────────────────────▼────────────────────────────┐
│                   Core Layer                        │
│              GameLogic.cs                           │
│   - Turn management                                 │
│   - Win / Draw detection                            │
│   - Board state                                     │
└────────────────────────┬────────────────────────────┘
                         │ uses
┌────────────────────────▼────────────────────────────┐
│                  Models & Enums                     │
│   Player.cs           GameState.cs                  │
└─────────────────────────────────────────────────────┘
```

- **`GameLogic.cs`** is UI-agnostic — it knows nothing about buttons or forms, only game rules.
- **`PlayForm`** calls into `GameLogic` and updates the visual board based on returned state.
- **`GameState` enum** ensures game-phase transitions are explicit and type-safe.

---

##  Getting Started

### Prerequisites

- **Windows OS** (Windows 7 or later)
- **Visual Studio 2019 / 2022** (or any IDE supporting .NET Framework 4.8)
- **.NET Framework 4.8** runtime ([Download here](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net48))

### Installation & Setup

**1. Clone the repository**

```bash
git clone https://github.com/Mohamed-Owaymr/TicTacToe.WinForms.git
cd TicTacToe.WinForms
```

**2. Open the solution**

Open `TicTacToeGame.slnx` in Visual Studio.

**3. Build the project**

```
Build → Build Solution   (Ctrl + Shift + B)
```

**4. Run the game**

```
Debug → Start Without Debugging   (Ctrl + F5)
```

The game will launch directly into the `MainForm` setup screen.

---

##  How to Play

1. **Launch** the application — the Main screen appears.
2. **Enter names** for Player 1 (X) and Player 2 (O).
3. **Click Start** to open the Play screen with the 3×3 board.
4. Players **take turns clicking** empty cells to place their marker.
5. The game **automatically detects** a win or draw and announces the result.
6. **Restart** to play again!

---

##  Built With

| Technology | Purpose |
|---|---|
| **C# (.NET Framework 4.8)** | Primary programming language |
| **Windows Forms (WinForms)** | Desktop UI framework |
| **MSBuild / Visual Studio** | Build system |
| **Embedded Resources** | Image assets bundled into the executable |

---

## 📁 Key Files Explained

| File | Role |
|---|---|
| `Program.cs` | Entry point; configures visual styles and launches `MainForm` |
| `Core/GameLogic.cs` | The brain — contains all game rules independent of the UI |
| `Enums/GameState.cs` | Defines `Playing`, `Win`, and `Draw` states |
| `Models/Player.cs` | Represents a player with a name and assigned symbol |
| `UI/Forms/MainForm.cs` | Welcome screen; collects player info before starting |
| `UI/Forms/PlayForm.cs` | Game board UI; reads input, calls GameLogic, updates board |
| `Resources/*.png` | Custom image assets for game markers and background |

---

##  Contributing

Contributions, bug reports, and feature suggestions are welcome!

1. Fork the repository
2. Create your feature branch: `git checkout -b feature/my-feature`
3. Commit your changes: `git commit -m "Add my feature"`
4. Push to the branch: `git push origin feature/my-feature`
5. Open a **Pull Request**

### 💡 Ideas for Contribution

-  Add an AI opponent (Minimax algorithm)
-  Add a score tracker across multiple rounds
-  Add sound effects for moves and win events
-  Add a save/load game session feature
-  Explore a networked multiplayer mode
-  Redesign UI with custom themes or dark mode

---

##  License

This project is open-source and available under the [MIT License](LICENSE).

---

##  Author

**Mohamed Owaymr**

- GitHub: [@Mohamed-Owaymr](https://github.com/Mohamed-Owaymr)

---

<p align="center">Made with ❤️ and C# because classic games never get old.</p>
