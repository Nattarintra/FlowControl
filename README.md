# FlowControl 🎯

This is a C# console application created for practicing **flow control**, **loops**, and **string manipulation**. 
The program presents a simple menu-driven interface that allows users to choose between multiple interactive tasks.

## 📝 About the Project

This project was built as part of an exercise to strengthen my understanding of basic C# programming concepts. 
It demonstrates how to use conditional statements, loops, and string operations to create a user-friendly console application.

Users can:
1. Check cinema tickets based on age categories (youth, senior, etc.)
2. Check cinema tickets based on group and age categories (youth, senior, etc.)
3. Input text and repeat it 10 times in a single line
4. Input a sentence and extract the third word
5. Exit the program

## 💡 My Approach

To solve the task, I created a `Main` menu inside the `Program.cs` file that continuously prompts the user until 
they choose to exit. 
I used a `do-while` loop to ensure the menu is shown at least once and keeps running until the exit condition is met. 
A `switch` statement handles user choices, and each functionality is placed in its own method to keep the code clean 
and organized.


Each menu option corresponds to a real-world problem:
- Menu 1-2: Demonstrates `if-else` logic
- Menu 3: Uses a `for` loop
- Menu 4: Uses string `.Split()` method
- Menu 0: Exit the program when isExit = true;

## ✨ Features
Infinite loop menu system

Ticket pricing logic for individuals and groups

Input validation and parsing

Repeating user input using for loops

Splitting a sentence into words using .Split()

Clear method separation for each functionality

## ⚙️ Installation

To run this project locally:

1. Clone the repository:
   ```bash
   git clone https://github.com/Nattarintra/FlowControl.git

2. Open the folder in Visual Studio or your preferred C# IDE.
3. Build and run the project.
- 3.1. ✅ Requires .NET SDK installed on your system.

## 🚀 Usage
1. Run the program.

2. Select one of the menu options:

1 – Single ticket price by age

2 – Group tickets price by age

3 – Repeat a sentence 10 times

4 – Split a sentence and extract the third word

0 – Exit the program

3. Follow the prompts in the console.

