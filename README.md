# ✨ Magical

**Magical** is a third-person wizard spellcasting game built with **Unity 6 (URP)** and embedded into a **React web app**.
The game focuses on fluid spell casting, responsive combat animations, and a clean separation between gameplay (Unity) and UI (React).

> Unity handles the magic.
> React handles the interface.

---

## 🎮 Gameplay Features

* 🧙‍♂️ Third-person wizard character
* 🔮 Directional spell casting (Harry Potter–style)
* 🛡️ Defend mechanic (hold to block)
* 🧭 WASD movement with mouse look
* 🔥 Spell trails & VFX (URP compatible)
* 🎵 Looping background soundtrack
* 🌐 Web build (Unity WebGL embedded in React)

---

## 🕹️ Controls

| Action     | Input              |
| ---------- | ------------------ |
| Move       | `W A S D`          |
| Look       | Mouse              |
| Cast Spell | Left Mouse Button  |
| Melee      | Hold Left Mouse Button |
| Defend     | Right Mouse Button |

---

## 🧩 Architecture

```
React (UI / HUD)
   └── iframe
        └── Unity WebGL Build (Gameplay)
```

### Why this approach?

* Zero Unity UI complexity
* Fast iteration on HUD & menus
* Web-native overlays (score, timer, rooms, etc.)
* Easy multiplayer / backend integration later

---

## 🛠️ Tech Stack

### Game

* **Unity 6**
* **Universal Render Pipeline (URP)**
* Mecanim Animator (state-machine driven)
* Particle & Trail VFX
* AudioSource-based SFX & music

### Web

* **React**
* Unity WebGL build embedded via `<iframe>`
* CSS-based HUD overlay

---

## 🚀 Running the Project

### Unity

1. Open the project in **Unity 6**
2. Open `MainScene`
3. Press ▶ Play for local testing
4. Build for **Web** using Build Profiles

### React

```bash
bun install
bun run dev
```

Make sure the Unity WebGL build is placed in:

```
public/unity/
```

---

## 📦 Version Control Notes

* Asset Serialization: **Force Text**
* Git-friendly Unity setup
* Large generated files excluded via `.gitignore`

```gitignore
[Ll]ibrary/
[Tt]emp/
[Oo]bj/
[Bb]uild/
[Bb]uilds/
[Ll]ogs/
[Uu]serSettings/
.DS_Store
```

---

## 🧪 Current State

* ✅ Core movement & combat working
* ✅ Spell VFX spawning correctly
* ✅ Web build embedded successfully
* 🚧 Jump system intentionally deferred
* 🚧 No scoring / enemies yet

---

## 🗺️ Roadmap

* 🎯 Target practice mode (hit floating targets in 1 min)
* 🏆 Score tracking (React HUD)
* ⚔️ 1v1 duel mode (room-based)
* 🌍 Multiplayer support
* ✨ More spells & effects

---

## 💡 Inspiration

* Harry Potter spell duels
* Mage combat arenas
* Fast prototyping for web games

---

## 🧙‍♂️ Author

Built by **Abhigyan Mohanta**
Exploring the intersection of **gameplay, web tech, and real-time systems**.