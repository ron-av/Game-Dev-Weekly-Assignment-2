# Game-Dev-Weekly-Assignment-3
# 📝 README – Jungle Hunter (Unity Game)

## 🎮 Game Overview
This project is a modified version of the original space-themed shooter game.  
Throughout the development process, several major improvements were implemented to create a fresh jungle-styled experience with smoother gameplay and better navigation between levels.

---

## ✅ Implemented Features

### **1. Complete Visual Redesign – Space → Jungle**
The entire visual theme of the game was replaced.  
The outer-space background and spaceship were removed and reimagined as:
- A **top-down jungle environment**
- A **hunter character** replacing the spaceship  
This change creates a more immersive and thematic setting.

---

### **2. Score Display Moved to the Screen UI**
Originally, the score ("hit counter") was attached directly to the player object.  
Now it has been moved to a **fixed UI element on the side of the screen**, making it:
- Always visible  
- More readable  
- Consistent across all levels

Each level resets the counter as expected.

---

### **3. Added a Backward Arrow to Return From Level 2 to Level 1**
In addition to the forward progress arrow, a reversed arrow was added in Level 2.  
This allows the player to:
- Step on the arrow
- Follow its direction  
- And travel **back from Level 2 to Level 1**

Useful for debugging, replaying, or revisiting earlier challenges.

---

### **4. Improved Shooting System – Faster & Hold-to-Fire**
The shooting mechanic was upgraded:
- **Increased firing speed**
- **Added the ability to hold the Space key for continuous shooting**

This makes the gameplay feel more dynamic and responsive.

---

## 🎮 How to Play

### **Controls**
- **Arrow Keys** – Move the hunter
- **Spacebar**
  - Tap to shoot once
  - Hold to fire continuously

### **Level Navigation**
To move between levels:
- Walk onto the blue arrows on the ground  
- Move in the direction the arrow points  
This will automatically load the next (or previous) scene.

---

Enjoy the game! 🌿🔫  
