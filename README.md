# WinChat 💬

WinChat is a simple chat application built with **C# WinForms** that simulates communication between two users on the same machine using **JSON** files and **FileSystemWatcher**.

## ✨ Features

* Real-time chat simulation between two users
* Dynamic chat bubbles
* Left and right message alignment
* Auto-resizing message input area
* JSON-based message storage
* Real-time file monitoring using `FileSystemWatcher`
* Reusable `UserControls`

## 🛠️ Technologies Used

* C#
* .NET Framework / WinForms
* JSON Serialization
* FileSystemWatcher
* User Controls

## 📷 Preview

![alt text for the image](Screenshots/screenshots.png)

## 🚀 How It Works

1. Launch two instances of the application.
2. Assign one instance as **User1** and the other as **User2**.
3. Messages are stored in a JSON file.
4. `FileSystemWatcher` detects changes in the file and updates the chat interface automatically.

## 📂 Project Structure

```text
WinChat/
│
├── User Controls/
│   └── ctrlChatMessage.cs
│
├── frmMain.cs
├── clsMessage.cs
├── Messages.json
└── README.md
```

## 🔮 Future Improvements

* Replace JSON communication with TCP Sockets
* Add support for multiple users
* Display message status (Sent / Delivered)
* Support emojis and file sharing
* Improve UI design

## 🎯 Learning Objectives

This project was built to practice:

* Event-Driven Programming
* JSON Serialization
* File Monitoring
* Building dynamic UI with WinForms
* Software Design using User Controls

## 📄 License

This project is licensed under the MIT License.

