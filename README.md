# Code Challenge :trophy:

Welcome to `code-challenge-console-app`! This repository contains a simple C# console application that prompts the user to enter a number between 5 and 10. The application will continue to prompt the user until a valid number within the specified range is entered. :1234:

## Techniques Used :hammer_and_wrench:

This project was developed using C# and .NET Core. It utilizes the `Console.ReadLine()` method to capture user input and the `int.TryParse()` method to validate that the input is a numeric value. 

## What I Learned :books:

Through this project, I learned how to:
- Use loops to control the flow of a program.
- Validate user input.
- Handle exceptions and errors gracefully.

## Program Flow :arrow_forward:

1. The program prompts the user to enter a number between 5 and 10.
2. The user's input is read and checked if it's a valid integer using `int.TryParse()`.
3. If the input is not a valid integer, the user is prompted to enter a valid number.
4. If the input is a valid integer but not within the range of 5 to 10, the user is prompted to enter a number within the range.
5. The loop continues until the user enters a valid number within the specified range.
6. Once a valid number is entered, the program acknowledges the input and ends.

## How to Run :rocket:

1. Clone the repository to your local machine. :computer:
2. Open the project in JetBrains Rider. :gear:
3. Run the application. :play_or_pause_button:

Please note that this application was developed using JetBrains Rider 2023.2.3 and may not work as expected in other IDEs or versions.
