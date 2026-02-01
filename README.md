🎲 Number Guessing Game (C#)
A robust console-based logic game where players compete against the computer to find a hidden number. This project focuses on efficient control flow, error handling, and clean user experience in a CLI environment.

🧠 Technical Highlights
State Management: Uses a while loop to maintain the game state until the win condition is met.
Intelligent Feedback: Provides real-time "higher" or "lower" hints based on numerical comparisons.
Input Sanitization: (Recommended update) Implementation of int.TryParse to ensure the program doesn't crash when users enter non-numeric characters.
Attempt Tracking: Dynamically counts and displays the total number of guesses upon victory.

🛠️ Built With
Language: C#
Framework: .NET SDK
Namespace: System (for Random and Console classes)

🎮 How to Play
The computer selects a random number between 0 and 4.
The user is prompted to enter a guess.
The game provides feedback:
"Higher" if your guess is too low.
"Lower" if your guess is too high.
Upon winning, the game reveals your total attempts and asks if you'd like to play again.

🚀 Installation & Usage
1. Clone the repository: git clone https://github.com/daviddimi/NumberGuessing.git
2. Navigate to the source folder: cd "Number Guessing"
3. Run the application: dotnet run

📄 License
This project is open-source and free to use for learning and development purposes.
