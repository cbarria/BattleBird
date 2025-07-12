# Battle Bird

Welcome to **Battle Bird**! This is a Flappy Bird–style game built in Unity, designed for parents and kids to develop together and learn the ropes of game development.

---

## 📖 Overview
In Battle Bird, you control a bird that must fly through gaps between pipes without crashing. Each time you successfully pass a pipe, your score increases. Upon collision, a **Game Over** screen displays your score and your all-time high score, and a **Retry** button lets you play again.

---

## 🎯 Learning Goals
By working on this project, you and your child will learn:
- **C# scripting** fundamentals in Unity
- Handling input via the **Input System** (keyboard, mouse, touch)
- Creating and configuring **UI** with Canvas, Text, and Buttons
- Persisting data using **PlayerPrefs** (for High Score)
- Adding **audio**: sound effects and background music
- **Building** and exporting your game to **Android**
- Version control workflows with **Git** and GitHub

---

## 🚀 Requirements
- **Unity 6** (version 6000.0.32f1) with these modules:
  - Android Build Support
  - Android SDK & NDK Tools
  - OpenJDK
- **Git** installed on your machine
- PC or Mac for development, plus an optional Android device for testing

---

## 🛠️ Setup & Usage
1. **Clone the repository**:
   ```bash
   git clone https://github.com/yourUsername/Battle-Bird.git
   cd Battle-Bird
   ```

2. **Open in Unity**:
   - Launch **Unity Hub**.
   - Click **Add**, then select the project folder.
   - Open the scene `Assets/Scenes/SampleScene.unity`.

3. **Play in the Editor**:
   - Press the **Play** button.
   - Control the bird with **Spacebar**, **Left Click**, or **Tap**.

---

## 📱 Exporting to Android
1. In Unity, go to **File > Build Settings**.
2. Select **Android** and click **Switch Platform**.
3. Ensure your scene is listed under **Scenes In Build**.
4. Under **Player Settings > Resolution and Presentation**:
   - Set **Default Orientation** to **Landscape**.
5. Click **Build** or **Build And Run**.
6. Install the resulting `.apk` on your Android device.

---

## 📂 Project Structure
```
/Battle Bird
  /Assets
    /Audio           ← sound effects & music
    /Scenes          ← Unity .unity scenes
    /Scripts         ← BirdScript, LogicScript, GameManager, etc.
    ...
  /Packages
  /ProjectSettings
  .gitignore
  README.md
```

---

## 🤝 Contributing
1. **Fork** the repository.
2. Create a **branch** (`git checkout -b feature/my-feature`).
3. Make your changes and **commit** them.
4. Push your branch and open a **Pull Request**.

We'll review changes together and learn in the process! 🎉

---

## 👨‍👩‍👧 Tips for Parents & Kids
- Explore scripts in `Assets/Scripts` and tweak parameters like `flapStrength`.
- Add new obstacles or power-ups to experiment with game mechanics.
- Test different resolutions and learn how the **Canvas Scaler** behaves.
- Use Git to track progress, resolve conflicts, and collaborate as a team.

Have fun coding and playing together! 🚀🐦
