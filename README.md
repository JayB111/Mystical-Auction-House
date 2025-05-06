# Mystical Auction House

Welcome to the **Mystical Auction House** — a dramatic, dark-fantasy themed auction app where users can bid on enchanted relics, mythical artifacts, and divine curiosities. Every moment is wrapped in ambient sound, mystical animation, real-time bidding, and handcrafted flair.

---

## Built With

* **Frontend**: React + Vite
* **Styling**: Custom CSS (no frameworks)
* **Backend**: ASP.NET Core Web API (C#)
* **Database**: MySQL
* **ORM**: Entity Framework Core
* **Real-Time Communication**: SignalR (WebSocket-based)
* **Testing Tool**: Swagger
* **Dev Tools**: GitHub, VS Code, MySQL Workbench

---

## Features

* Display of over 30 magical items with images, names, and immersive lore
* **Glowing effects** on ultra-rare items like The Thread of Tyron and Oracle's Dice
* **Countdown timers** showing time left until each auction ends
* **Real-time bidding updates** across all browsers using SignalR
* Fully working **Mythos currency system** with bid deduction
* **Coin sound** plays when a bid is placed
* Looping **ambient music**, toggleable by the user
* **Curtain animation** that reveals the page on load
* **Floating sparkles** and atmospheric polish throughout the interface
* Live seed-based database with Entity Framework Core
* Separated and minimal folder structure for clarity and ease

---

## Sample Artifacts

* **The Thread of Tyron**: A silver thread spun by unknown gods. Said to lead lost souls through forgotten paths.
* **The Lantern of the Deep Moon**: Glows only in total darkness. Believed to guide lost spirits home.
* **The Coin of Forgotten Realms**: Flip it and hear the name of a place not on any map.
* **The Wand of the Hollow Grove**: Carved from the last living tree in a cursed forest. Still warm to the touch.
* **Oracle's Dice**: Ancient dice used to divine fate. Each face reveals a different destiny.

---

## How to Run

### Backend (.NET Web API)

1. Navigate to `/backend`
2. Apply the migrations:

   ```bash
   dotnet ef database drop
   dotnet ef database update
   ```
3. Start the API server:

   ```bash
   dotnet run
   ```

### Frontend (React + Vite)

1. Navigate to `/frontend`
2. Install dependencies and run:

   ```bash
   npm install
   npm run dev
   ```
3. Visit `https://localhost:5174`

### MySQL Setup

* Launch MySQL Workbench and connect to your server
* Confirm the database is created with seeded mystical items
* Set your connection string in `appsettings.json`

---

## File Structure

```
AuctionAPI/
├── backend/ (C# Web API)
├── frontend/ (React + Vite)
│   ├── public/images/          # All item images
│   ├── public/sounds/          # Coin + ambient sounds
│   └── src/components/MysticalAuctionHouse.jsx
```

---



## Special Thanks

This project was designed from the heart, drawing from dreams, mythology, and the desire to create a mystical interactive world. Every feature, sound, and glowing detail was imagined as part of a magical journey.

---

## License

This project is open for educational and personal creative exploration.

Created with curiosity, persistence, and inspiration on May 5, 2025.
