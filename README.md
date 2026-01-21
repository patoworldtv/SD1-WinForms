# SD1 WinForms Application — Version 1.0
A Windows Forms–based upgrade of the original SD1 assignment.
This version introduces a full graphical user interface, file operations, optional encryption features, and an installer suitable for end‑user distribution.

# Project Overview
This application is a GUI‑enhanced version of the SD1 console project.
It provides a simple and intuitive interface for:
Opening text files.
Saving edited content.
Encrypting and decrypting text (optional).
Entering a custom encryption key.
Viewing program information.
Installing the application on Windows via a custom installer.

# Application is built using C# (.NET WinForms) and is intended to run on Windows.

# Project Structure
Code
SD1-WINFORMS/
  SD1App.csproj
  Program.cs
  Form1.cs
  Form1.Designer.cs
  
Program.cs — Application entry point
Form1.cs — Main form logic (menus, file operations, encryption)
Form1.Designer.cs — GUI layout (MenuStrip, TextBox, etc.)
SD1App.csproj — Project configuration

## Features
## File Menu
Open…  
Load text from a file using OpenFileDialog.
Save As…  
Save the current text to a file using SaveFileDialog.
Exit  
Close the application.

# Tools Menu (Optional Encryption)
Enter Key…  
Allows the user to input an encryption key.
Encrypt  
 Encrypts the text in the main TextBox using a simple XOR cipher.
Decrypt  
 Decrypts previously encrypted text using the same key.

# Help Menu
About  
Displays program version, author name, and organization (VVK).

# Technical Details
GUI Components
MenuStrip for navigation

TextBox (multiline, scrollable) for displaying and editing text

OpenFileDialog and SaveFileDialog for file selection

Encryption
A simple XOR‑based cipher is used:

Reversible

Key‑based

Demonstrates basic cryptography concepts

# Building the Project
Using GitHub Codespaces
You can edit and build the project in Codespaces, but WinForms cannot run on Linux, so the GUI will not launch there.

Running on Windows
Clone the repository:

bash
git clone https://github.com/patoworldtv/SD1-WinForms.git
Open the solution in Visual Studio

Press F5 to run the application

# Installer
A Windows installer (.msi) is created using Visual Studio Installer Projects.
Installer metadata:

Creator: Patrick Amarakuo
Organization: VVK

.

#  Publishing
The final version of the project (including installer) is published as a GitHub Release:

Source code

Installer (.msi)

Version tag (e.g., v1.0)
